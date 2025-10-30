using System;
using ISFDyT93.Datos.Core;
using ISFDyT93.Datos.Core.Attributes;

namespace ISFDyT93.Datos.Modelos
{
	/// <summary>
	/// Modelo de datos que representa una asistencia de un alumno
	/// dentro de una cursada o materia.
	/// </summary>
	public class AsistenciasModelo : ModeloBase
	{
		/// <summary>
		/// Relación directa entre Cursada y AlumnoCarrera.
		/// </summary>
		public int CursadaAlumnoCarreraId { get; set; }

		/// <summary>
		/// Identificador de la relación Alumno-Carrera.
		/// </summary>
		public int AlumnoCarreraId { get; set; }

		/// <summary>
		/// Identificador de la cursada (por materia y año).
		/// </summary>
		public int CursadaId { get; set; }

		/// <summary>
		/// Identificador único del alumno.
		/// </summary>
		public int AlumnoId { get; set; }

		/// <summary>
		/// Identificador del docente o personal a cargo.
		/// </summary>
		public int PersonalId { get; set; }

		/// <summary>
		/// Cantidad total de horas cursadas hasta el momento.
		/// </summary>
		public int HorasCursadas { get; set; }

		/// <summary>
		/// Porcentaje de asistencia acumulado del alumno.
		/// </summary>
		public double PorcentajeAsistencia { get; set; }

		/// <summary>
		/// Cantidad de módulos (bloques) cursados.
		/// </summary>
		public int Modulos { get; set; }

		/// <summary>
		/// Cantidad total de horas de cátedra de la cursada.
		/// </summary>
		public int HoraCatedra { get; set; }

		/// <summary>
		/// Porcentaje de asistencia general de la cursada (nivel global).
		/// </summary>
		public float PorcentajeAsistenciaC { get; set; }

		/// <summary>
		/// Marca de asistencia (P = Presente, A = Ausente, etc.).
		/// </summary>
		public string Asistencia { get; set; }

		/// <summary>
		/// Última fecha en que el alumno tuvo presente/ausente registrado.
		/// </summary>
		public DateTime UltimoPresentismo { get; set; }

		/// <summary>
		/// Fecha de asistencia (formato DateTime real).
		/// </summary>
		public DateTime FechaAsistencia
		{
			get => DateTime.TryParse(FechaAsistenciaStr, out DateTime fecha) ? fecha : DateTime.MinValue;
			set => FechaAsistenciaStr = value.ToString("yyyy-MM-dd");
		}

		/// <summary>
		/// Fecha de asistencia en formato string (para SQL).
		/// </summary>
		public string FechaAsistenciaStr { get; set; }

		/// <summary>
		/// Nombre del alumno (para mostrar en grillas o reportes).
		/// </summary>
		public string Nombre { get; set; }

		/// <summary>
		/// Apellido del alumno.
		/// </summary>
		public string Apellido { get; set; }

		/// <summary>
		/// Carga horaria total definida para la materia.
		/// </summary>
		public int CargaHoraria { get; set; }
		// Filtros opcionales (para UI). No rompen nada existente.
		public int? IdCarrera { get; set; }   // CarreraId a filtrar
		public int? IdCurso { get; set; }     // CursoId a filtrar
		public int? IdMateria { get; set; }   // MateriaId a filtrar
		public int? Anio { get; set; }        // Año lectivo a filtrar (ej: 2024)

		public bool TieneFiltros =>
			IdCarrera.HasValue || IdCurso.HasValue || IdMateria.HasValue || Anio.HasValue;


	}
}
