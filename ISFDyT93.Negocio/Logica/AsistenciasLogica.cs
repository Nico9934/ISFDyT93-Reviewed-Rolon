//using ISFDyT93.Datos.Daos;
//using ISFDyT93.Datos.Modelos;
//using System.Data;

//namespace ISFDyT93.Negocio.Logica
//{
//	public class AsistenciasLogica
//	{
//		private readonly ControlAsistenciasDao asistenciasDao;

//		public AsistenciasLogica()
//		{
//			asistenciasDao = new ControlAsistenciasDao();
//		}

//		/// <summary>
//		/// Carga todas las asistencias registradas de los alumnos de una cursada específica.
//		/// </summary>
//		public DataTable CargarAsistenciasAlumnos(AsistenciasModelo modelo)
//		{
//			return asistenciasDao.CargarAsistenciasAlumnos(modelo);
//		}

//		/// <summary>
//		/// Devuelve el total de alumnos de la cursada.
//		/// </summary>
//		public DataRow CalcularTotalAlumnos(AsistenciasModelo modelo)
//		{
//			return asistenciasDao.CalculaTotalAlumnos(modelo);
//		}

//		/// <summary>
//		/// Devuelve los datos del profesor asignado.
//		/// </summary>
//		public DataRow CargarProfesor()
//		{
//			return asistenciasDao.CargarProfesor();
//		}

//		/// <summary>
//		/// Inserta una nueva asistencia en la base de datos.
//		/// </summary>
//		public int AgregarAsistencia(AsistenciasModelo modelo)
//		{
//			return asistenciasDao.AgregarAsistencia(modelo);
//		}

//		/// <summary>
//		/// Actualiza la última fecha de asistencia, módulos y porcentaje del alumno.
//		/// </summary>
//		public void ActualizarUltimaFecha(AsistenciasModelo modelo)
//		{
//			asistenciasDao.ActualizoUltimaFechaAsistencia(modelo);
//		}

//		/// <summary>
//		/// Devuelve el historial de asistencias de un alumno.
//		/// </summary>
//		public DataTable HistorialAsistenciasAlumno(AsistenciasModelo modelo)
//		{
//			return asistenciasDao.HistorialAsistenciasAlumnos(modelo);
//		}

//		/// <summary>
//		/// Carga las asistencias de una fecha específica (para reportes).
//		/// </summary>
//		public DataTable CargarAsistenciasReporte(AsistenciasModelo modelo)
//		{
//			return asistenciasDao.CargarAsistenciasAlumnosReporte(modelo);
//		}

//		/// <summary>
//		/// Actualiza los datos generales de la cursada (fecha, porcentaje, horas, etc.).
//		/// </summary>
//		public void ActualizarCursada(AsistenciasModelo modelo)
//		{
//			asistenciasDao.ActualizarCursada(modelo);
//		}
//	}
//}
