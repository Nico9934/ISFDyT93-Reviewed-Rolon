using System.Data;
using ISFDyT93.Datos.Daos;
using ISFDyT93.Datos.Modelos;
using ISFDyT93.Negocio.Core;

namespace ISFDyT93.Negocio.Logica
{
	/// <summary>
	/// Lógica de negocio para el control de asistencias y sus filtros.
	/// Encapsula la comunicación con el DAO y valida el flujo de datos.
	/// </summary>
	public class ControlAsistenciasLogica : LogicaBase
	{
		private readonly ControlAsistenciasDao controlAsistenciasDao;

		public ControlAsistenciasLogica()
		{
			this.controlAsistenciasDao = new ControlAsistenciasDao();
		}

		// ============================================================
		// 🔹 NUEVOS MÉTODOS PARA FILTROS
		// ============================================================

		/// <summary>
		/// Devuelve todas las carreras activas.
		/// </summary>
		public DataTable CargarCarreras()
		{
			return controlAsistenciasDao.CargarCarreras();
		}

		/// <summary>
		/// Devuelve los años disponibles para una carrera.
		/// </summary>
		public DataTable CargarAnios(int idCarrera)
		{
			return controlAsistenciasDao.CargarAnios(idCarrera);
		}

		/// <summary>
		/// Devuelve los cursos asociados a una carrera y año.
		/// </summary>
		public DataTable CargarCursos(int idCarrera, int anio)
		{
			return controlAsistenciasDao.CargarCursos(idCarrera, anio);
		}

		/// <summary>
		/// Devuelve las materias asociadas a un curso.
		/// </summary>
		public DataTable CargarMaterias(int idCurso)
		{
			return controlAsistenciasDao.CargarMaterias(idCurso);
		}

		/// <summary>
		/// Devuelve la cursada correspondiente a una combinación carrera / año / curso / materia.
		/// </summary>
		public DataRow ObtenerCursada(int idCarrera, int anio, int idCurso, int idMateria, int anioLectivo)
		{
			return controlAsistenciasDao.ObtenerCursada(idCarrera, anio, idCurso, idMateria, anioLectivo);
		}


		/// <summary>
		/// Carga todas las asistencias de la cursada seleccionada.
		/// </summary>
		public DataTable CargarAsistenciasPorCursada(int idCursada)
		{
			return controlAsistenciasDao.CargarAsistenciasPorCursada(idCursada);
		}

		/// <summary>
		/// Devuelve el resumen general de la cursada (para dgvAsistenciaCount).
		/// </summary>
		public DataRow CargarResumenAsistencias(int idCursada)
		{
			return controlAsistenciasDao.CargarResumenAsistencias(idCursada);
		}

		// ============================================================
		// 🔹 MÉTODOS EXISTENTES (SIN CAMBIOS)
		// ============================================================

		public DataTable CargarAsistenciasAlumnosReporte(AsistenciasModelo modelo)
		{
			return controlAsistenciasDao.CargarAsistenciasAlumnosReporte(modelo);
		}

		public DataTable CargarAsistenciasAnteriores(AsistenciasModelo modelo)
		{
			return controlAsistenciasDao.CargarAsistenciasAnteriores(modelo);
		}

		public DataRow CargarProfesor()
		{
			return controlAsistenciasDao.CargarProfesor();
		}

		public void ActualizoUltimaFechaAsistencia(AsistenciasModelo modelo)
		{
			controlAsistenciasDao.ActualizoUltimaFechaAsistencia(modelo);
		}

		public int AgregarAsistencia(AsistenciasModelo modelo)
		{
			return controlAsistenciasDao.AgregarAsistencia(modelo);
		}

		public int ActualizarCursada(AsistenciasModelo modelo)
		{
			return controlAsistenciasDao.ActualizarCursada(modelo);
		}

		public DataRow CalculaModulosAlumnos(AsistenciasModelo modelo)
		{
			return controlAsistenciasDao.CalculaModulosAlumnos(modelo);
		}

		public DataRow CalcularPorcentajeAsistenciaAlumnos(AsistenciasModelo modelo)
		{
			return controlAsistenciasDao.CalcularPorcentajeAsistenciaAlumnos(modelo);
		}

		public DataTable HistorialAsistenciasAlumnos(AsistenciasModelo modelo)
		{
			return controlAsistenciasDao.HistorialAsistenciasAlumnos(modelo);
		}
	}
}

/* 
===============================================
🧩 ESTRUCTURA JERÁRQUICA DE RELACIONES
===============================================

🔹 Nivel 1️⃣ — Carreras
Cada carrera agrupa los planes de estudio (por ejemplo: Desarrollo de Software).

Ejemplo:
CarreraId | Nombre
----------------------------------------
3008      | Tecnicatura en Desarrollo de Software


🔹 Nivel 2️⃣ — AniosCarreras
Cada carrera tiene varios años (1°, 2°, 3°), y cada registro identifica un año dentro de una carrera.

Ejemplo:
AnioCarreraId | AnioCarrera | CarreraId
----------------------------------------
4014          | 1           | 3008
4015          | 2           | 3008
4016          | 3           | 3008


🔹 Nivel 3️⃣ — Cursos
Cada año de carrera tiene uno o más cursos (A, B, C...), y se relacionan con AniosCarreras.

Ejemplo:
CursoId | NombreCurso | AnioCarreraId
----------------------------------------
3008    | A           | 4014
3009    | B           | 4014
3010    | A           | 4015
3011    | B           | 4015


🔹 Nivel 4️⃣ — Materias y CursoMaterias
Las materias se asocian a los cursos mediante la tabla intermedia `CursoMaterias`.

CursoId | MateriaId | CursoMateriaId
----------------------------------------
3008    | 7001      | 9001
3009    | 7002      | 9002

Esto permite dictar una materia específica dentro de un curso.


🔹 Nivel 5️⃣ — Cursadas
Representan las instancias reales de dictado de una materia (un año, profesor, fechas, etc).

CursadaId | CursoMateriaId | Año | FechaInicio   | FechaFin
-------------------------------------------------------------
10001     | 9001            | 2025 | 2025-03-01   | 2025-11-30


🔹 Nivel 6️⃣ — AlumnosCarreras
Vincula a los alumnos con una carrera específica.

AlumnoCarreraId | AlumnoId | CarreraId | AñoIngreso | Activo
---------------------------------------------------------------
5001             | 1        | 3008       | 2024        | 1
5002             | 2        | 3008       | 2024        | 1


🔹 Nivel 7️⃣ — CursadaAlumnoCarreras
Asocia a cada alumno con una cursada específica (inscripción concreta).

CursadaAlumnoCarreraId | AlumnoCarreraId | CursadaId
-----------------------------------------------------
6001                   | 5001            | 10001
6002                   | 5002            | 10001


🔹 Nivel 8️⃣ — Asistencias
Registra la asistencia de cada alumno en cada fecha de la cursada.

AsistenciaId | CursadaAlumnoCarreraId | Fecha       | Asistencia
-----------------------------------------------------------------
7001         | 6001                   | 2025-03-10  | 'P'
7002         | 6002                   | 2025-03-10  | 'A'


===============================================
📘 FLUJO GENERAL DE RELACIONES
===============================================
Carreras (3008)
   ↳ AniosCarreras (4014, 4015, 4016)
       ↳ Cursos (3008, 3009, 3010...)
           ↳ CursoMaterias (curso ↔ materia)
               ↳ Cursadas (instancia de dictado)
                   ↳ CursadaAlumnoCarreras (alumnos inscriptos)
                       ↳ Asistencias (registro de cada clase)
===============================================
*/
