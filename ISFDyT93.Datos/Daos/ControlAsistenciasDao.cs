using ISFDyT93.Datos.Core;
using ISFDyT93.Datos.Modelos;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ISFDyT93.Datos.Daos
{
	/// <summary>
	/// DAO responsable de todas las operaciones SQL relacionadas con asistencias y control de cursadas.
	/// </summary>
	public class ControlAsistenciasDao : DaoBase
	{
		// ============================================================
		// 🔹 MÉTODOS PARA CARGAR FILTROS (CARRERA / AÑO / CURSO / MATERIA)
		// ============================================================

		/// <summary>
		/// Carga todas las carreras activas (o disponibles).
		/// </summary>
		public DataTable CargarCarreras()
		{
			string query = @"
				SELECT 
					CarreraId AS IdCarrera, 
					DescripcionCorta
				FROM Carreras
				ORDER BY Nombre;";
			return this.Conexion.ObtenerRegistros(query);
		}

		/// <summary>
		/// Carga los años disponibles para una carrera.
		/// </summary>
		public DataTable CargarAnios(int carreraId)
		{
			string query = $@"
			SELECT DISTINCT 
				AC.AnioCarreraId,
				AC.AnioCarrera
			FROM AniosCarreras AC
			LEFT JOIN Cursos C ON C.AnioCarreraId = AC.AnioCarreraId
			WHERE AC.CarreraId = {carreraId}
			ORDER BY AC.AnioCarrera;";

			return this.Conexion.ObtenerRegistros(query);
		}



		/// <summary>
		/// Carga los cursos correspondientes a una carrera y un año.
		/// </summary>
		public DataTable CargarCursos(int carreraId, int anioCarreraId)
		{
			string query = $@"
			SELECT 
				C.CursoId,
				C.NombreCurso
			FROM Cursos C
			INNER JOIN AniosCarreras AC ON C.AnioCarreraId = AC.AnioCarreraId
			WHERE AC.CarreraId = {carreraId}
			  AND C.AnioCarreraId = {anioCarreraId}
			  AND C.Activo = 1
			ORDER BY C.NombreCurso;";
			return this.Conexion.ObtenerRegistros(query);
		}

		/// <summary>
		/// Carga las materias de un curso.
		/// </summary>
		public DataTable CargarMaterias(int cursoId)
		{
			string query = $@"
				SELECT 
					M.MateriaId AS IdMateria,
					M.Nombre
				FROM CursoMaterias CM
				INNER JOIN Materias M ON CM.MateriaId = M.MateriaId
				WHERE CM.CursoId = {cursoId}
				ORDER BY M.Nombre;";
			return this.Conexion.ObtenerRegistros(query);
		}

		/// <summary>
		/// Obtiene la cursada correspondiente a los filtros seleccionados.
		/// </summary>
		public DataRow ObtenerCursada(int carreraId, int anioCarreraId, int cursoId, int materiaId, int anioLectivo)
		{
			string query = $@"
			SELECT TOP 1 
				c.CursadaId AS CursadaId,
				c.AnioLectivo AS AnioLectivo,
				cm.CursoMateriaId AS CursoMateriaId,
				cu.CursoId AS CursoId,
				cu.NombreCurso AS NombreCurso,
				m.MateriaId AS MateriaId,
				m.Nombre AS Materia,
				ac.AnioCarreraId AS AnioCarreraId,
				ac.AnioCarrera AS AnioCarrera,
				ac.CarreraId AS CarreraId
			FROM Cursadas c
			INNER JOIN CursoMaterias cm ON c.CursoMateriaId = cm.CursoMateriaId
			INNER JOIN Cursos cu ON cm.CursoId = cu.CursoId
			INNER JOIN Materias m ON cm.MateriaId = m.MateriaId
			INNER JOIN AniosCarreras ac ON cu.AnioCarreraId = ac.AnioCarreraId
			WHERE ac.CarreraId = {carreraId}
			  AND ac.AnioCarreraId = {anioCarreraId}
			  AND cu.CursoId = {cursoId}
			  AND m.MateriaId = {materiaId}
			  AND c.AnioLectivo = {anioLectivo};";

			return this.Conexion.ObtenerRegistro(query);
		}




		// ============================================================
		// 🔹 MÉTODOS PRINCIPALES DE ASISTENCIAS
		// ============================================================

		/// <summary>
		/// Carga la lista de asistencias de una cursada.
		/// </summary>
		public DataTable CargarAsistenciasPorCursada(int cursadaId)
		{
			MessageBox.Show($"[DAO] Entrando en MÉTODO: CargarAsistenciasPorCursada({cursadaId})");

			string query = $@"
			SELECT 
				ROW_NUMBER() OVER(ORDER BY AL.Apellido, AL.Nombre) AS [N°],
				AL.Apellido + ', ' + AL.Nombre AS [Apellidos y Nombres],
				AL.NumeroDocumento AS [DNI],
				COALESCE(CAC.Estado, 'REG') AS [Condición],
				CAC.HorasCursadas AS [H/Cursadas],
				CAC.UltimoPresentismo AS [Ult/Presentismo],
				CAST(CAC.PorcentajeAsistencia AS DECIMAL(5,2)) AS [% Asistencia]
			FROM CursadaAlumnoCarreras CAC
			INNER JOIN AlumnosCarreras AC ON AC.AlumnoCarreraId = CAC.AlumnoCarreraId
			INNER JOIN Alumnos AL ON AL.AlumnoId = AC.AlumnoId
			WHERE CAC.CursadaId = {cursadaId}
			ORDER BY AL.Apellido, AL.Nombre;";

			MessageBox.Show($"[DAO DEBUG] QUERY EJECUTADA:\n\n{query}");
			return this.Conexion.ObtenerRegistros(query);
		}




		/// <summary>
		/// Devuelve un resumen de asistencias: cantidad de alumnos, promedios, última fecha.
		/// </summary>
		public DataRow CargarResumenAsistencias(int cursadaId)
		{
			// 1️⃣ Ejecutar el SP de actualización
			SqlParameter[] parametros = { new SqlParameter("@CursadaId", cursadaId) };
			this.Conexion.EjecutarStore("SP_ActualizarResumenCursada", parametros);

			// 2️⃣ Consultar el resumen actualizado
			string query = $@"
        SELECT 
            CantidadAlumnos AS [Cant/Alumnos],
            CantidadAlumnosRecursantes AS [Cant/Recur.],
            CantidadAlumnosDesertores AS [Cant/Desertores],
            HoraCatedra AS [H/Cátedra],
            FechaAsistencia AS [Fech/Asistencia],
            PorcentajeAsistencia AS [Porcentaje]
        FROM dbo.Cursadas
        WHERE CursadaId = {cursadaId};";

			return this.Conexion.ObtenerRegistro(query);
		}



		// ============================================================
		// 🔹 MÉTODOS EXISTENTES (NO TOCAR)
		// ============================================================




		public DataTable CargarAsistenciasAlumnos(AsistenciasModelo modelo)
		{
			MessageBox.Show($"[DAO] Entrando en MÉTODO: CargarAsistenciasAlumnos()");

			string query = $@"
				SELECT 
					Al.AlumnoId, 
					AC.AlumnoCarreraId, 
					Ca.CursadaId, 
					Ca.CursadaAlumnoCarreraId, 
					Al.Apellido, 
					Ca.HorasCursadas AS Modulos, 
					Ca.UltimoPresentismo, 
					Ca.PorcentajeAsistencia, 
					A.Asistencia
				FROM AlumnosCarreras AC
				INNER JOIN Alumnos Al ON Al.AlumnoId = AC.AlumnoId
				INNER JOIN CursadaAlumnoCarreras Ca ON AC.AlumnoCarreraId = Ca.AlumnoCarreraId
				LEFT JOIN Asistencias A 
					ON Ca.CursadaAlumnoCarreraId = A.CursadaAlumnoCarreraId 
					AND CONVERT(date, A.Fecha) = CONVERT(date, Ca.UltimoPresentismo)
				WHERE Ca.CursadaId = {modelo.CursadaId}";
			return this.Conexion.ObtenerRegistros(query);
		}

		public DataTable CargarAsistenciasAlumnosReporte(AsistenciasModelo modelo)
		{
			MessageBox.Show($"[DAO] Entrando en MÉTODO: CargarAsistenciasAlumnosReporte()");

			string query = $@"
				SELECT 
					Al.AlumnoId, 
					AC.AlumnoCarreraId, 
					Ca.CursadaId, 
					Ca.CursadaAlumnoCarreraId, 
					CONCAT(Al.Apellido, ', ', Al.Nombre) AS Alumnos,
					Ca.HorasCursadas AS [Módulos],
					Ca.UltimoPresentismo AS Ultimo_Presentismo,
					Ca.PorcentajeAsistencia AS Porcentaje_de_Asistencia,
					A.Asistencia
				FROM AlumnosCarreras AC
				INNER JOIN Alumnos Al ON Al.AlumnoId = AC.AlumnoId
				INNER JOIN CursadaAlumnoCarreras Ca ON AC.AlumnoCarreraId = Ca.AlumnoCarreraId
				LEFT JOIN Asistencias A 
					ON Ca.CursadaAlumnoCarreraId = A.CursadaAlumnoCarreraId 
					AND CONVERT(date, A.Fecha) = CONVERT(date, '{modelo.FechaAsistenciaStr}')
				WHERE Ca.CursadaId = {modelo.CursadaId}";
			return this.Conexion.ObtenerRegistros(query);
		}

		public DataTable CargarAsistenciasAnteriores(AsistenciasModelo modelo)
		{
			string query = $@"
				SELECT 
					Al.AlumnoId, 
					AC.AlumnoCarreraId, 
					Ca.CursadaId, 
					Ca.CursadaAlumnoCarreraId, 
					Al.Apellido, 
					Ca.HorasCursadas AS Modulos, 
					Ca.UltimoPresentismo, 
					Ca.PorcentajeAsistencia, 
					A.Asistencia
				FROM AlumnosCarreras AC
				INNER JOIN Alumnos Al ON Al.AlumnoId = AC.AlumnoId
				INNER JOIN CursadaAlumnoCarreras Ca ON AC.AlumnoCarreraId = Ca.AlumnoCarreraId
				LEFT JOIN Asistencias A 
					ON Ca.CursadaAlumnoCarreraId = A.CursadaAlumnoCarreraId 
					AND CONVERT(date, A.Fecha) = CONVERT(date, '{modelo.FechaAsistenciaStr}')
				WHERE Ca.CursadaId = {modelo.CursadaId}";
			return this.Conexion.ObtenerRegistros(query);
		}

		public DataRow CargarProfesor()
		{
			string query = "SELECT Nombre, Apellido FROM Personal WHERE PersonalId = 2;";
			return this.Conexion.ObtenerRegistro(query);
		}

		public void ActualizoUltimaFechaAsistencia(AsistenciasModelo modelo)
		{
			string fechaA = modelo.UltimoPresentismo.ToString("yyyy-MM-dd");
			string query = $@"
				UPDATE CursadaAlumnoCarreras
				SET UltimoPresentismo = '{fechaA}', 
					HorasCursadas = {modelo.HorasCursadas}, 
					PorcentajeAsistencia = {modelo.PorcentajeAsistencia}
				WHERE CursadaAlumnoCarreraId = {modelo.CursadaAlumnoCarreraId}";
			this.Conexion.EjecutarAccion(query);
		}

		public int AgregarAsistencia(AsistenciasModelo modelo)
		{
			string fechaA = modelo.UltimoPresentismo.ToString("yyyy-MM-dd");
			string query = $@"
				INSERT INTO Asistencias (Fecha, Asistencia, CursadaAlumnoCarreraId)
				VALUES ('{fechaA}', '{modelo.Asistencia}', {modelo.CursadaAlumnoCarreraId})";
			return this.Conexion.EjecutarAccion(query);
		}

		public int ActualizarCursada(AsistenciasModelo modelo)
		{
			string query = $@"
				UPDATE Cursadas 
				SET HoraCatedra = {modelo.HorasCursadas}, 
					FechaAsistencia = '{modelo.FechaAsistenciaStr}', 
					PorcentajeAsistencia = {modelo.PorcentajeAsistencia}
				WHERE CursadaId = {modelo.CursadaId}";
			return this.Conexion.EjecutarAccion(query);
		}

		public DataRow CalculaTotalAlumnos(AsistenciasModelo modelo)
		{
			string query = $"SELECT COUNT(CursadaAlumnoCarreraId) AS Total FROM CursadaAlumnoCarreras WHERE CursadaId = {modelo.CursadaId}";
			return this.Conexion.ObtenerRegistro(query);
		}

		public DataRow CalculaModulosAlumnos(AsistenciasModelo modelo)
		{
			string query = $"SELECT HorasCursadas AS Modulos FROM CursadaAlumnoCarreras WHERE CursadaAlumnoCarreraId = {modelo.CursadaAlumnoCarreraId}";
			return this.Conexion.ObtenerRegistro(query);
		}

		public DataRow CalcularPorcentajeAsistenciaAlumnos(AsistenciasModelo modelo)
		{
			string query = $"SELECT PorcentajeAsistencia FROM CursadaAlumnoCarreras WHERE AlumnoCarreraId = {modelo.AlumnoCarreraId}";
			return this.Conexion.ObtenerRegistro(query);
		}

		public DataTable HistorialAsistenciasAlumnos(AsistenciasModelo modelo)
		{
			string query = $"SELECT Fecha AS [Fechas], IIF(Asistencia = 'P', 'Presente', 'Ausente') AS [Asistencia] FROM Asistencias WHERE CursadaAlumnoCarreraId = {modelo.CursadaAlumnoCarreraId}";
			return this.Conexion.ObtenerRegistros(query);
		}
	}
}
