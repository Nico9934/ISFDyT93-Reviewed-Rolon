using ISFDyT93.Datos.Modelos;
using ISFDyT93.Negocio.Logica;
using ISFDyT93.Vista.Core;
using ISFDyT93.Vista.Core.Enums;
using ISFDyT93.Vista.Forms.Common;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Drawing;
using System;
using System.Data;
using System.Drawing;
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
			panelAsistencias.Visible = true;
			panelEvaluaciones.Visible = false;
		
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
			// ✅ Evita ejecutar mientras el ComboBox se está llenando
			if (cboFiltroCurso.DataSource == null) return;

			// ✅ Si el valor actual NO es un número, salimos sin error
			if (cboFiltroCurso.SelectedValue == null ||
				cboFiltroCurso.SelectedValue is DataRowView)
				return;

			// ✅ Ahora sí, es un número válido → continuamos
			if (!int.TryParse(cboFiltroCurso.SelectedValue.ToString(), out int idCurso))
				return;

			// ✅ Cargar materias normalmente
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
			panelAsistencias.Visible = true;
			panelEvaluaciones.Visible = false;
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
				// 🧩 Paso 5: Cargar resumen de asistencias (encabezado)
				// 🧩 Paso 5: Cargar resumen de asistencias (encabezado)
				//MessageBox.Show($"📌 Debug → Estoy en Paso 5. CursadaId = {CursadaId.Value}");

				var dtCuenta = controlAsistenciasLogica.ObtenerCursadasCuenta(CursadaId.Value);


				dgvAsistenciasCount.DataSource = null;
				dgvAsistenciasCount.Rows.Clear();
				dgvAsistenciasCount.AutoGenerateColumns = true; // por si tenés columnas auto

				if (dtCuenta != null && dtCuenta.Rows.Count > 0)
				{
					dgvAsistenciasCount.DataSource = dtCuenta;

					// Opcional: forzar encabezados (ya vienen con alias "bonitos")
					dgvAsistenciasCount.Columns["Cant/Alumnos"].HeaderText = "Cant/Alumnos";
					dgvAsistenciasCount.Columns["Cant/Recur."].HeaderText = "Cant/Recur.";
					dgvAsistenciasCount.Columns["Cant/Desertores"].HeaderText = "Cant/Desertores";
					dgvAsistenciasCount.Columns["H/Cátedra"].HeaderText = "H/Cátedra";
					dgvAsistenciasCount.Columns["Fech/Asistencia"].HeaderText = "Fech/Asistencia";
					dgvAsistenciasCount.Columns["Porcentaje"].HeaderText = "% Asistencia";
				}
				else
				{
					// Si no hay fila en Cursadas, mostrás una vacía amable (opcional)
					DataTable molde = new DataTable();
					molde.Columns.Add("Cant/Alumnos", typeof(int));
					molde.Columns.Add("Cant/Recur.", typeof(int));
					molde.Columns.Add("Cant/Desertores", typeof(int));
					molde.Columns.Add("H/Cátedra", typeof(int));
					molde.Columns.Add("Fech/Asistencia", typeof(DateTime));
					molde.Columns.Add("Porcentaje", typeof(decimal));
					molde.Rows.Add(0, 0, 0, 0, DBNull.Value, 0m);
					dgvAsistenciasCount.DataSource = molde;
				}


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
		// 🔹 BOTÓN EVALUACIONES
		// =====================================================

		private void btn_evaluaciones_Click(object sender, EventArgs e)
		{
			panelAsistencias.Visible = false;
			panelEvaluaciones.Visible = true;

			if (CursadaId == null)
			{
				MessageBox.Show("Debe seleccionar una cursada primero.");
				return;
			}

			// 1️⃣ Traer notas
			var tabla = controlAsistenciasLogica.ObtenerEvaluacionesCursada(CursadaId.Value);
			dgv_evaluaciones.DataSource = tabla;

			// 2️⃣ Mostrar únicamente estas columnas
			string[] columnasVisibles = { "Nro", "DNI", "Alumno", "Condición", "REC1", "INF1", "REC2", "INF2", "APromocion", "AFinal", "Recursa", "Observaciones" };

			foreach (DataGridViewColumn col in dgv_evaluaciones.Columns)
				col.Visible = columnasVisibles.Contains(col.Name);

			// 3️⃣ Congelar primeras columnas + ajuste de ancho automático
			dgv_evaluaciones.Columns["Nro"].Frozen = true;
			dgv_evaluaciones.Columns["DNI"].Frozen = true;
			dgv_evaluaciones.Columns["Alumno"].Frozen = true;

			dgv_evaluaciones.Columns["Nro"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
			dgv_evaluaciones.Columns["DNI"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
			dgv_evaluaciones.Columns["Alumno"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
			dgv_evaluaciones.Columns["APromocion"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
			dgv_evaluaciones.Columns["AFinal"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
			dgv_evaluaciones.Columns["AFinal"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
			dgv_evaluaciones.Columns["Recursa"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
			dgv_evaluaciones.Columns["Observaciones"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

			// 4️⃣ Ajustar ancho automático también para notas (NO fijo en 60)
			foreach (var name in new[] {"Condición","REC1", "INF1", "REC2", "INF2" })
				if (dgv_evaluaciones.Columns.Contains(name))
					dgv_evaluaciones.Columns[name].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

			// 5️⃣ Estética general de headers
			dgv_evaluaciones.EnableHeadersVisualStyles = false;
			dgv_evaluaciones.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(2, 28, 71); // azul
			dgv_evaluaciones.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;              // texto blanco
			dgv_evaluaciones.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9, FontStyle.Bold);
			dgv_evaluaciones.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;

			// 6️⃣ Altura suficiente para columnas rotadas
			dgv_evaluaciones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
			dgv_evaluaciones.ColumnHeadersHeight = 65;

			// 7️⃣ Bordes tipo Excel
			dgv_evaluaciones.GridColor = Color.Black;
			dgv_evaluaciones.CellBorderStyle = DataGridViewCellBorderStyle.Single;

			// 8️⃣ Reemplazar nulos por “-”
			foreach (DataGridViewRow row in dgv_evaluaciones.Rows)
				foreach (DataGridViewCell cell in row.Cells)
					if (cell.Value == null || string.IsNullOrWhiteSpace(cell.Value.ToString()))
						cell.Value = "-";

			// 9️⃣ Eventos de pintado (evitar duplicados)
			dgv_evaluaciones.Paint -= dgv_evaluaciones_Paint;
			dgv_evaluaciones.Paint += dgv_evaluaciones_Paint;

			dgv_evaluaciones.CellPainting -= dgv_evaluaciones_CellPainting;
			dgv_evaluaciones.CellPainting += dgv_evaluaciones_CellPainting;

			// 🔟 Totales


			// ✅ Transponer ANTES de asignar al DataGridView
	
			// 🔹 1. Obtener totales y transponerlo
			var tablaTotales = controlAsistenciasLogica.ObtenerTotalesEvaluaciones(CursadaId.Value);
			var tablaTranspuesta = TransponerTotales(tablaTotales);
			dgv_totales.DataSource = tablaTranspuesta;

			// 🔹 2. Estilos generales del DataGridView
			dgv_totales.EnableHeadersVisualStyles = false;
			dgv_totales.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(2, 28, 71);
			dgv_totales.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
			dgv_totales.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9, FontStyle.Bold);
			dgv_totales.ColumnHeadersHeight = 40;
			dgv_totales.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;

			// 🔹 3. Pintar la PRIMERA COLUMNA ("Indicador") como si fuera encabezado
			DataGridViewColumn firstCol = dgv_totales.Columns[0];
			firstCol.DefaultCellStyle.BackColor = Color.FromArgb(2, 28, 71);
			firstCol.DefaultCellStyle.ForeColor = Color.White;
			firstCol.DefaultCellStyle.Font = new Font("Segoe UI", 9, FontStyle.Bold);
			firstCol.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

			dgv_totales.CellPainting -= dgv_totales_CellPainting;
			dgv_totales.CellPainting += dgv_totales_CellPainting;

			// Opcional: fijarla para que no se mueva cuando haces scroll
			firstCol.Frozen = true;

			// 🔹 4. Ajustar tamaño automático de columnas
			foreach (DataGridViewColumn col in dgv_totales.Columns)
			{
				col.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
			}

			// 🔹 5. Opcional → evitar que se pueda seleccionar esa columna azul
			firstCol.ReadOnly = true;


		}

		// =====================================================
		// 🔹 DIBUJAR AGRUPACIÓN DE CUATRIMESTRES (SIN DUPLICAR TEXTO)
		// =====================================================
		private void dgv_evaluaciones_Paint(object sender, PaintEventArgs e)
		{
			var grupos = new List<(string Titulo, string[] Columnas)>
			{
				("1° CUATRIMESTRE", new[] { "REC1", "INF1" }),
				("2° CUATRIMESTRE", new[] { "REC2", "INF2" }),
				("NOTA DE CURSADA", new[] { "APromocion", "AFinal", "Recursa" })
			};

			int headerHeight = dgv_evaluaciones.ColumnHeadersHeight / 2;
			using (SolidBrush backColor = new SolidBrush(Color.FromArgb(2, 28, 71)))
			using (Pen pen = new Pen(Color.Black))
			using (StringFormat sf = new StringFormat { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center })
			{
				foreach (var grupo in grupos)
				{
					var cols = dgv_evaluaciones.Columns
						.Cast<DataGridViewColumn>()
						.Where(c => grupo.Columnas.Contains(c.Name))
						.OrderBy(c => c.DisplayIndex)
						.ToList();

					if (cols.Count == 0) continue;

					Rectangle rect = new Rectangle(
						dgv_evaluaciones.GetColumnDisplayRectangle(cols.First().Index, true).Left,
						0,
						dgv_evaluaciones.GetColumnDisplayRectangle(cols.Last().Index, true).Right -
						dgv_evaluaciones.GetColumnDisplayRectangle(cols.First().Index, true).Left,
						headerHeight
					);

					e.Graphics.FillRectangle(backColor, rect);
					e.Graphics.DrawRectangle(pen, rect);
					e.Graphics.DrawString(grupo.Titulo, new Font("Segoe UI", 9, FontStyle.Bold), Brushes.White, rect, sf);
				}
			}

			// Línea que divide grupo de headers individuales
			e.Graphics.DrawLine(Pens.Black, 0, headerHeight, dgv_evaluaciones.Width, headerHeight);
		}

		// =====================================================
		// 🔹 ROTAR SOLO ENCABEZADO DE REC1, INF1, REC2, INF2 – SIN SUPERPONER
		// =====================================================
		private void dgv_evaluaciones_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
		{
			if (e.RowIndex == -1 && e.ColumnIndex >= 0)
			{
				string[] rotar = { "REC1", "INF1", "REC2", "INF2" };
				string col = dgv_evaluaciones.Columns[e.ColumnIndex].Name;

				if (rotar.Contains(col))
				{
					e.PaintBackground(e.CellBounds, true);

					// Bajamos el texto para que se vea bien centrado hacia abajo
					e.Graphics.TranslateTransform(e.CellBounds.Left + 5, e.CellBounds.Bottom - 5);
					e.Graphics.RotateTransform(-90);
					e.Graphics.DrawString(col, new Font("Segoe UI", 9, FontStyle.Bold), Brushes.White, 0, 0);
					e.Graphics.ResetTransform();

					e.Handled = true;
				}
			}
		}

		private void dgv_totales_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
		{
			// Si estoy en una celda de datos (fila >= 0) y primera columna (col = 0)
			if (e.RowIndex >= 0 && e.ColumnIndex == 0)
			{
				e.PaintBackground(e.CellBounds, true);

				// Fondo igual al header superior
				using (Brush backColor = new SolidBrush(Color.FromArgb(2, 28, 71)))
				{
					e.Graphics.FillRectangle(backColor, e.CellBounds);
				}

				// Borde
				using (Pen pen = new Pen(Color.Black))
				{
					e.Graphics.DrawRectangle(pen, e.CellBounds);
				}

				// Texto blanco centrado
				TextRenderer.DrawText(
					e.Graphics,
					e.FormattedValue?.ToString(),
					new Font("Segoe UI", 9, FontStyle.Bold),
					e.CellBounds,
					Color.White,
					TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter
				);

				e.Handled = true; // Ya lo pintamos
			}
		}


		public static DataTable TransponerTotales(DataTable tablaOriginal)
		{
			DataTable tablaTranspuesta = new DataTable();

			// 📌 Primera columna de filas: "Indicador" (TotalConNota, Aprobados, etc.)
			tablaTranspuesta.Columns.Add("Indicador");

			// 📌 Agregar como columnas los valores de "Examen" (TP1, REC1, INF1...)
			foreach (DataRow row in tablaOriginal.Rows)
				tablaTranspuesta.Columns.Add(row["Examen"].ToString());

			// 📌 Lista de indicadores fijos (las filas originales que ahora serán columnas)
			string[] indicadores = { "TotalConNota", "CantidadAprobados", "CantidadDesaprobados", "CantidadAusentes", "Promedio" };

			foreach (string indicador in indicadores)
			{
				DataRow nuevaFila = tablaTranspuesta.NewRow();
				nuevaFila["Indicador"] = indicador;

				foreach (DataRow row in tablaOriginal.Rows)
				{
					string examen = row["Examen"].ToString();
					nuevaFila[examen] = row[indicador];
				}

				tablaTranspuesta.Rows.Add(nuevaFila);
			}

			return tablaTranspuesta;
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

		private void cboFiltroMateria_SelectedIndexChanged(object sender, EventArgs e)
		{
			try
			{
				// ✅ Validación: si falta alguno, no sigo
				if (cboFiltroCarrera.SelectedValue == null ||
					cboFiltroAnio.SelectedValue == null ||
					cboFiltroCurso.SelectedValue == null ||
					cboFiltroMateria.SelectedValue == null ||
					cboFiltroAnioLectivo.SelectedValue == null)
				{
					return;
				}

				// ✅ Conversión segura a int — si falla, no sigue
				if (!int.TryParse(cboFiltroCarrera.SelectedValue.ToString(), out int idCarrera)) return;
				if (!int.TryParse(cboFiltroAnio.SelectedValue.ToString(), out int anioCarrera)) return;
				if (!int.TryParse(cboFiltroCurso.SelectedValue.ToString(), out int idCurso)) return;
				if (!int.TryParse(cboFiltroMateria.SelectedValue.ToString(), out int idMateria)) return;
				if (!int.TryParse(cboFiltroAnioLectivo.SelectedValue.ToString(), out int anioLectivo)) return;

				// ✅ Hasta acá todo bien: recién acá podrías buscar la cursada si querés
				var cursada = controlAsistenciasLogica.ObtenerCursada(idCarrera, anioCarrera, idCurso, idMateria, anioLectivo);

				if (cursada != null)
				{
					CursadaId = Convert.ToInt32(cursada["CursadaId"]);
					txb_detalleCursadaId.Text = $"CursadaId = {CursadaId}";
				}
				else
				{
					CursadaId = null;
					txb_detalleCursadaId.Text = "❌ No existe cursada para esta materia";
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Error al detectar la cursada: {ex.Message}");
				txb_detalleCursadaId.Text = "⚠ Error al buscar cursada";
			}
		}

	}
}
