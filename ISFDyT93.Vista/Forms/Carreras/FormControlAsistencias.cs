using ISFDyT93.Datos.Modelos;
using ISFDyT93.Negocio.Logica;
using ISFDyT93.Vista.Core;
using ISFDyT93.Vista.Core.Enums;
using ISFDyT93.Vista.Forms.Common;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace ISFDyT93.Vista.Forms.Carreras
{
	public partial class FormControlAsistencias : FormBase
	{
		#region Propiedades
		public int? CursadaId { get; set; }

		private readonly ControlAsistenciasLogica controlAsistenciasLogica;

		private int filaSeleccionada = -1;
		#endregion

		public FormControlAsistencias()
		{
			InitializeComponent();
			controlAsistenciasLogica = new ControlAsistenciasLogica();
		}

		// =====================================================
		// 🔹 CARGA INICIAL DEL FORMULARIO
		// =====================================================
		private void ControlAsistencias_Load(object sender, EventArgs e)
		{
			try
			{
				CargarAnioLectivo();
				CargarCarreras();
				dgvAsistencias.DataSource = null;
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Error al inicializar el formulario: {ex.Message}");
			}
		}

		private void CargarAnioLectivo()
		{
			int anioActual = DateTime.Now.Year;
			DataTable dt = new DataTable();
			dt.Columns.Add("Anio", typeof(int));

			for (int i = anioActual - 3; i <= anioActual + 2; i++)
				dt.Rows.Add(i);

			cboFiltroAnioLectivo.DataSource = dt;
			cboFiltroAnioLectivo.DisplayMember = "Anio";
			cboFiltroAnioLectivo.ValueMember = "Anio";
			cboFiltroAnioLectivo.SelectedValue = anioActual;
		}




		// =====================================================
		// 🔹 CARGA DE COMBOS EN CASCADA
		// =====================================================
		private void CargarCarreras()
		{
			var dt = controlAsistenciasLogica.CargarCarreras();
			
			cboFiltroCarrera.DataSource = dt;
			cboFiltroCarrera.DisplayMember = "DescripcionCorta";
			cboFiltroCarrera.ValueMember = "IdCarrera";
			cboFiltroCarrera.SelectedIndex = -1;

			cboFiltroAnio.DataSource = null;
			cboFiltroCurso.DataSource = null;
			cboFiltroMateria.DataSource = null;
		}

		private void cboFiltroAnioLectivo_SelectedIndexChanged(object sender, EventArgs e)
		{

		}
		private void cboFiltroCarrera_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (cboFiltroCarrera.SelectedValue == null) return;
			if (!int.TryParse(cboFiltroCarrera.SelectedValue.ToString(), out int idCarrera)) return;

			var dtAnios = controlAsistenciasLogica.CargarAnios(idCarrera);
			cboFiltroAnio.DataSource = dtAnios;
			cboFiltroAnio.DisplayMember = "AnioCarrera";
			cboFiltroAnio.ValueMember = "AnioCarreraId";
			cboFiltroAnio.SelectedIndex = -1;

			cboFiltroCurso.DataSource = null;
			cboFiltroMateria.DataSource = null;
		}

		private void cboFiltroAnio_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (cboFiltroCarrera.SelectedValue == null || cboFiltroAnio.SelectedValue == null) return;
			if (!int.TryParse(cboFiltroCarrera.SelectedValue.ToString(), out int idCarrera)) return;
			if (!int.TryParse(cboFiltroAnio.SelectedValue.ToString(), out int anio)) return;

			var dtCursos = controlAsistenciasLogica.CargarCursos(idCarrera, anio);
			cboFiltroCurso.DataSource = dtCursos;
			cboFiltroCurso.DisplayMember = "NombreCurso";
			cboFiltroCurso.ValueMember = "CursoId";
			cboFiltroCurso.SelectedIndex = -1;



			cboFiltroMateria.DataSource = null;
		}

		private void cboFiltroCurso_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (cboFiltroCurso.SelectedValue == null) return;
			if (!int.TryParse(cboFiltroCurso.SelectedValue.ToString(), out int idCurso)) return;

			var dtMaterias = controlAsistenciasLogica.CargarMaterias(idCurso);
			cboFiltroMateria.DataSource = dtMaterias;
			cboFiltroMateria.DisplayMember = "Nombre";
			cboFiltroMateria.ValueMember = "IdMateria";
			cboFiltroMateria.SelectedIndex = -1;
		}

		// =====================================================
		// 🔹 BOTÓN FILTRAR
		// =====================================================
		private void btnFiltrar_Click(object sender, EventArgs e)
		{
			try
			{
				// 🧠 Paso 1: Validar que los combos tengan valor
				if (cboFiltroCarrera.SelectedValue == null ||
					cboFiltroAnio.SelectedValue == null ||
					cboFiltroCurso.SelectedValue == null ||
					cboFiltroMateria.SelectedValue == null)
				{
					MessageBox.Show(
						"Debe seleccionar Carrera, Año, Curso y Materia.",
						"Atención",
						MessageBoxButtons.OK,
						MessageBoxIcon.Warning
					);
					return;
				}

				// 🧩 Paso 2: Capturar valores seleccionados
				int idCarrera = Convert.ToInt32(cboFiltroCarrera.SelectedValue);
				int anio = Convert.ToInt32(cboFiltroAnio.SelectedValue);
				int idCurso = Convert.ToInt32(cboFiltroCurso.SelectedValue);
				int idMateria = Convert.ToInt32(cboFiltroMateria.SelectedValue);
				int anioLectivo = Convert.ToInt32(cboFiltroAnioLectivo.SelectedValue);


			

				// 🧩 Paso 3: Buscar la cursada que corresponde
				var cursada = controlAsistenciasLogica.ObtenerCursada(idCarrera, anio, idCurso, idMateria, anioLectivo);

				if (cursada == null)
				{
					MessageBox.Show("⚠️ No se encontró ninguna cursada...", "Sin resultados",
						MessageBoxButtons.OK, MessageBoxIcon.Warning);
					dgvAsistencias.DataSource = null;
					return;
				}

				CursadaId = Convert.ToInt32(cursada["CursadaId"]);

				

				// 🧩 Paso 4: Cargar asistencias
				var asistencias = controlAsistenciasLogica.CargarAsistenciasPorCursada(CursadaId.Value);
				

				dgvAsistencias.DataSource = null;
				dgvAsistencias.Rows.Clear();
				dgvAsistencias.DataSource = asistencias;

				if (asistencias.Rows.Count == 0)
				{
					MessageBox.Show(
						"No hay registros de asistencia para esta cursada.",
						"Información",
						MessageBoxButtons.OK,
						MessageBoxIcon.Information
					);
				}
				else
				{
					FormatearGrillaAsistencias();
				}

				// 🧩 Paso 5: Cargar resumen de asistencias
				var resumen = controlAsistenciasLogica.CargarResumenAsistencias(CursadaId.Value);

				if (resumen != null)
				{
					MessageBox.Show(
						$"📘 Resumen:\n" +
						$"Total alumnos: {resumen["Cant/Alumnos"]}\n" +
						$"Porcentaje promedio: {resumen["Porcentaje"]}\n" +
						$"Horas promedio: {resumen["H/Cátedra"]}",
						"Depuración - Resumen",
						MessageBoxButtons.OK,
						MessageBoxIcon.Information
					);

					// 🔹 Convertir DataRow a DataTable
					DataTable tablaResumen = resumen.Table.Clone();  // crea la estructura
					tablaResumen.ImportRow(resumen);                 // copia el contenido

					dgvAsistenciasCount.DataSource = null;
					dgvAsistenciasCount.Rows.Clear();
					dgvAsistenciasCount.DataSource = tablaResumen;
				}
				else
				{
					MessageBox.Show(
						"⚠️ No se pudo generar el resumen de asistencias (devuelve null).",
						"Depuración - Resumen",
						MessageBoxButtons.OK,
						MessageBoxIcon.Warning
					);
				}
				dgvAsistenciasCount.Columns["Cant/Alumnos"].HeaderText = "Cant/Alumnos";
				dgvAsistenciasCount.Columns["Cant/Recur."].HeaderText = "Cant/Recur.";
				dgvAsistenciasCount.Columns["Cant/Desertores"].HeaderText = "Cant/Desert.";
				dgvAsistenciasCount.Columns["H/Cátedra"].HeaderText = "H/Cátedra";
				dgvAsistenciasCount.Columns["Fech/Asistencia"].HeaderText = "Últ. Asistencia";
				dgvAsistenciasCount.Columns["Porcentaje"].HeaderText = "% Asistencia";

			}
			catch (Exception ex)
			{
				MessageBox.Show(
					$"💥 Error al filtrar:\n{ex.Message}",
					"Error",
					MessageBoxButtons.OK,
					MessageBoxIcon.Error
				);
			}
		}

		// =====================================================
		// 🔹 FORMATEO DE GRILLA
		// =====================================================
		private void FormatearGrillaAsistencias()
		{
			if (dgvAsistencias.Columns.Contains("IdAsistencia"))
				dgvAsistencias.Columns["IdAsistencia"].Visible = false;

			if (dgvAsistencias.Columns.Contains("Asistencia"))
			{
				dgvAsistencias.Columns["Asistencia"].HeaderText = "Estado";
				dgvAsistencias.Columns["Asistencia"].Width = 80;
			}

			if (dgvAsistencias.Columns.Contains("Alumno"))
				dgvAsistencias.Columns["Alumno"].HeaderText = "Alumno";

			if (dgvAsistencias.Columns.Contains("FechaAsistencia"))
				dgvAsistencias.Columns["FechaAsistencia"].HeaderText = "Fecha";
		}

		// =====================================================
		// 🔹 CONTEXT MENU EN GRILLA
		// =====================================================
		private void dgvAsistencias_MouseUp(object sender, MouseEventArgs e)
		{
			if (e.Button != MouseButtons.Right) return;

			var info = dgvAsistencias.HitTest(e.X, e.Y);
			if (info.Type == DataGridViewHitTestType.Cell && info.RowIndex >= 0)
			{
				filaSeleccionada = info.RowIndex;
				dgvAsistencias.Rows[filaSeleccionada].Selected = true;
				tsmP.Visible = tsmA.Visible = tsmHistorialAsistenciasAlumnos.Visible = true;
				cmsPyA.Show(dgvAsistencias, e.X, e.Y);
			}
		}

		private void tsmP_Click(object sender, EventArgs e)
		{
			if (filaSeleccionada >= 0)
				dgvAsistencias.Rows[filaSeleccionada].Cells["Asistencia"].Value = "P";
		}

		private void tsmA_Click(object sender, EventArgs e)
		{
			if (filaSeleccionada >= 0)
				dgvAsistencias.Rows[filaSeleccionada].Cells["Asistencia"].Value = "A";
		}

	}
}
