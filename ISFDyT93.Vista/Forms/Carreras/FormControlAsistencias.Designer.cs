
namespace ISFDyT93.Vista.Forms.Carreras
{
    partial class FormControlAsistencias
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			this.components = new System.ComponentModel.Container();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
			this.btnDescargar = new System.Windows.Forms.Button();
			this.lblPorcentajeAsistencia = new System.Windows.Forms.Label();
			this.cmsPyA = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.tsmP = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmA = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmHistorialAsistenciasAlumnos = new System.Windows.Forms.ToolStripMenuItem();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.cboFiltroAnioLectivo = new System.Windows.Forms.ComboBox();
			this.lblFiltroMateria = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.cboFiltroMateria = new System.Windows.Forms.ComboBox();
			this.cboFiltroAnio = new System.Windows.Forms.ComboBox();
			this.lblFiltroAnio = new System.Windows.Forms.Label();
			this.lblDetalleCursadaId = new System.Windows.Forms.Label();
			this.txb_detalleCursadaId = new System.Windows.Forms.TextBox();
			this.lblFiltroCarrera = new System.Windows.Forms.Label();
			this.lblFiltroCurso = new System.Windows.Forms.Label();
			this.cboFiltroCarrera = new System.Windows.Forms.ComboBox();
			this.cboFiltroCurso = new System.Windows.Forms.ComboBox();
			this.btnFiltrar = new System.Windows.Forms.Button();
			this.btn_evaluaciones = new System.Windows.Forms.Button();
			this.panelAsistencias = new System.Windows.Forms.Panel();
			this.dgvAsistenciasCount = new System.Windows.Forms.DataGridView();
			this.dgvAsistencias = new System.Windows.Forms.DataGridView();
			this.panelEvaluaciones = new System.Windows.Forms.Panel();
			this.dgv_totales = new System.Windows.Forms.DataGridView();
			this.dgv_evaluaciones = new System.Windows.Forms.DataGridView();
			this.cmsPyA.SuspendLayout();
			this.tableLayoutPanel1.SuspendLayout();
			this.panelAsistencias.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvAsistenciasCount)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvAsistencias)).BeginInit();
			this.panelEvaluaciones.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgv_totales)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgv_evaluaciones)).BeginInit();
			this.SuspendLayout();
			// 
			// btnDescargar
			// 
			this.btnDescargar.Location = new System.Drawing.Point(0, 0);
			this.btnDescargar.Name = "btnDescargar";
			this.btnDescargar.Size = new System.Drawing.Size(75, 23);
			this.btnDescargar.TabIndex = 0;
			// 
			// lblPorcentajeAsistencia
			// 
			this.lblPorcentajeAsistencia.AutoSize = true;
			this.lblPorcentajeAsistencia.BackColor = System.Drawing.Color.Transparent;
			this.lblPorcentajeAsistencia.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblPorcentajeAsistencia.Location = new System.Drawing.Point(772, 396);
			this.lblPorcentajeAsistencia.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblPorcentajeAsistencia.Name = "lblPorcentajeAsistencia";
			this.lblPorcentajeAsistencia.Size = new System.Drawing.Size(0, 29);
			this.lblPorcentajeAsistencia.TabIndex = 58;
			// 
			// cmsPyA
			// 
			this.cmsPyA.ImageScalingSize = new System.Drawing.Size(24, 24);
			this.cmsPyA.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmP,
            this.tsmA,
            this.tsmHistorialAsistenciasAlumnos});
			this.cmsPyA.Name = "cmsPyA";
			this.cmsPyA.Size = new System.Drawing.Size(150, 100);
			// 
			// tsmP
			// 
			this.tsmP.Name = "tsmP";
			this.tsmP.Size = new System.Drawing.Size(149, 32);
			this.tsmP.Text = "P";
			// 
			// tsmA
			// 
			this.tsmA.Name = "tsmA";
			this.tsmA.Size = new System.Drawing.Size(149, 32);
			this.tsmA.Text = "A";
			// 
			// tsmHistorialAsistenciasAlumnos
			// 
			this.tsmHistorialAsistenciasAlumnos.Name = "tsmHistorialAsistenciasAlumnos";
			this.tsmHistorialAsistenciasAlumnos.Size = new System.Drawing.Size(149, 32);
			this.tsmHistorialAsistenciasAlumnos.Text = "Historial";
			this.tsmHistorialAsistenciasAlumnos.Visible = false;
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tableLayoutPanel1.ColumnCount = 5;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66333F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.64865F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.459459F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 212F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.01001F));
			this.tableLayoutPanel1.Controls.Add(this.cboFiltroAnioLectivo, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.lblFiltroMateria, 0, 2);
			this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.cboFiltroMateria, 1, 2);
			this.tableLayoutPanel1.Controls.Add(this.cboFiltroAnio, 1, 1);
			this.tableLayoutPanel1.Controls.Add(this.lblFiltroAnio, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.lblDetalleCursadaId, 0, 3);
			this.tableLayoutPanel1.Controls.Add(this.txb_detalleCursadaId, 1, 3);
			this.tableLayoutPanel1.Controls.Add(this.lblFiltroCarrera, 2, 0);
			this.tableLayoutPanel1.Controls.Add(this.lblFiltroCurso, 2, 1);
			this.tableLayoutPanel1.Controls.Add(this.cboFiltroCarrera, 3, 0);
			this.tableLayoutPanel1.Controls.Add(this.cboFiltroCurso, 3, 1);
			this.tableLayoutPanel1.Controls.Add(this.btnFiltrar, 4, 0);
			this.tableLayoutPanel1.Controls.Add(this.btn_evaluaciones, 4, 1);
			this.tableLayoutPanel1.Location = new System.Drawing.Point(22, 32);
			this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 3, 3, 20);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 4;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(1222, 162);
			this.tableLayoutPanel1.TabIndex = 80;
			// 
			// cboFiltroAnioLectivo
			// 
			this.cboFiltroAnioLectivo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboFiltroAnioLectivo.Font = new System.Drawing.Font("Tahoma", 11F);
			this.cboFiltroAnioLectivo.Location = new System.Drawing.Point(171, 3);
			this.cboFiltroAnioLectivo.Name = "cboFiltroAnioLectivo";
			this.cboFiltroAnioLectivo.Size = new System.Drawing.Size(233, 35);
			this.cboFiltroAnioLectivo.TabIndex = 77;
			this.cboFiltroAnioLectivo.SelectedIndexChanged += new System.EventHandler(this.cboFiltroAnioLectivo_SelectedIndexChanged);
			// 
			// lblFiltroMateria
			// 
			this.lblFiltroMateria.AutoSize = true;
			this.lblFiltroMateria.Font = new System.Drawing.Font("Tahoma", 11F);
			this.lblFiltroMateria.Location = new System.Drawing.Point(3, 80);
			this.lblFiltroMateria.Name = "lblFiltroMateria";
			this.lblFiltroMateria.Size = new System.Drawing.Size(93, 27);
			this.lblFiltroMateria.TabIndex = 7;
			this.lblFiltroMateria.Text = "Materia:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Tahoma", 11F);
			this.label1.Location = new System.Drawing.Point(3, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(133, 27);
			this.label1.TabIndex = 76;
			this.label1.Text = "Año lectivo: ";
			// 
			// cboFiltroMateria
			// 
			this.cboFiltroMateria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboFiltroMateria.Font = new System.Drawing.Font("Tahoma", 11F);
			this.cboFiltroMateria.Location = new System.Drawing.Point(171, 83);
			this.cboFiltroMateria.Name = "cboFiltroMateria";
			this.cboFiltroMateria.Size = new System.Drawing.Size(233, 35);
			this.cboFiltroMateria.TabIndex = 8;
			this.cboFiltroMateria.SelectedIndexChanged += new System.EventHandler(this.cboFiltroMateria_SelectedIndexChanged);
			// 
			// cboFiltroAnio
			// 
			this.cboFiltroAnio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboFiltroAnio.Font = new System.Drawing.Font("Tahoma", 11F);
			this.cboFiltroAnio.Location = new System.Drawing.Point(171, 43);
			this.cboFiltroAnio.Name = "cboFiltroAnio";
			this.cboFiltroAnio.Size = new System.Drawing.Size(233, 35);
			this.cboFiltroAnio.TabIndex = 4;
			this.cboFiltroAnio.SelectedIndexChanged += new System.EventHandler(this.cboFiltroAnio_SelectedIndexChanged);
			// 
			// lblFiltroAnio
			// 
			this.lblFiltroAnio.AutoSize = true;
			this.lblFiltroAnio.Font = new System.Drawing.Font("Tahoma", 11F);
			this.lblFiltroAnio.Location = new System.Drawing.Point(3, 40);
			this.lblFiltroAnio.Name = "lblFiltroAnio";
			this.lblFiltroAnio.Size = new System.Drawing.Size(57, 27);
			this.lblFiltroAnio.TabIndex = 3;
			this.lblFiltroAnio.Text = "Año:";
			// 
			// lblDetalleCursadaId
			// 
			this.lblDetalleCursadaId.AutoSize = true;
			this.lblDetalleCursadaId.Font = new System.Drawing.Font("Tahoma", 11F);
			this.lblDetalleCursadaId.Location = new System.Drawing.Point(3, 120);
			this.lblDetalleCursadaId.Name = "lblDetalleCursadaId";
			this.lblDetalleCursadaId.Size = new System.Drawing.Size(126, 27);
			this.lblDetalleCursadaId.TabIndex = 79;
			this.lblDetalleCursadaId.Text = "CursadaId: ";
			this.lblDetalleCursadaId.Visible = false;
			// 
			// txb_detalleCursadaId
			// 
			this.txb_detalleCursadaId.Enabled = false;
			this.txb_detalleCursadaId.Location = new System.Drawing.Point(171, 123);
			this.txb_detalleCursadaId.Name = "txb_detalleCursadaId";
			this.txb_detalleCursadaId.Size = new System.Drawing.Size(233, 36);
			this.txb_detalleCursadaId.TabIndex = 80;
			this.txb_detalleCursadaId.Visible = false;
			// 
			// lblFiltroCarrera
			// 
			this.lblFiltroCarrera.AutoSize = true;
			this.lblFiltroCarrera.Font = new System.Drawing.Font("Tahoma", 11F);
			this.lblFiltroCarrera.Location = new System.Drawing.Point(410, 0);
			this.lblFiltroCarrera.Name = "lblFiltroCarrera";
			this.lblFiltroCarrera.Size = new System.Drawing.Size(85, 40);
			this.lblFiltroCarrera.TabIndex = 1;
			this.lblFiltroCarrera.Text = "Carrera:";
			// 
			// lblFiltroCurso
			// 
			this.lblFiltroCurso.AutoSize = true;
			this.lblFiltroCurso.Font = new System.Drawing.Font("Tahoma", 11F);
			this.lblFiltroCurso.Location = new System.Drawing.Point(410, 40);
			this.lblFiltroCurso.Name = "lblFiltroCurso";
			this.lblFiltroCurso.Size = new System.Drawing.Size(75, 27);
			this.lblFiltroCurso.TabIndex = 5;
			this.lblFiltroCurso.Text = "Curso:";
			// 
			// cboFiltroCarrera
			// 
			this.cboFiltroCarrera.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboFiltroCarrera.Font = new System.Drawing.Font("Tahoma", 11F);
			this.cboFiltroCarrera.Location = new System.Drawing.Point(505, 3);
			this.cboFiltroCarrera.Name = "cboFiltroCarrera";
			this.cboFiltroCarrera.Size = new System.Drawing.Size(206, 35);
			this.cboFiltroCarrera.TabIndex = 2;
			this.cboFiltroCarrera.SelectedIndexChanged += new System.EventHandler(this.cboFiltroCarrera_SelectedIndexChanged);
			// 
			// cboFiltroCurso
			// 
			this.cboFiltroCurso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboFiltroCurso.Font = new System.Drawing.Font("Tahoma", 11F);
			this.cboFiltroCurso.Location = new System.Drawing.Point(505, 43);
			this.cboFiltroCurso.Name = "cboFiltroCurso";
			this.cboFiltroCurso.Size = new System.Drawing.Size(206, 35);
			this.cboFiltroCurso.TabIndex = 6;
			this.cboFiltroCurso.SelectedIndexChanged += new System.EventHandler(this.cboFiltroCurso_SelectedIndexChanged);
			// 
			// btnFiltrar
			// 
			this.btnFiltrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(1)))), ((int)(((byte)(124)))));
			this.btnFiltrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnFiltrar.Font = new System.Drawing.Font("Tahoma", 11F);
			this.btnFiltrar.ForeColor = System.Drawing.Color.White;
			this.btnFiltrar.Location = new System.Drawing.Point(717, 3);
			this.btnFiltrar.Name = "btnFiltrar";
			this.btnFiltrar.Size = new System.Drawing.Size(232, 34);
			this.btnFiltrar.TabIndex = 9;
			this.btnFiltrar.Text = "Asistencias";
			this.btnFiltrar.UseVisualStyleBackColor = false;
			this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
			// 
			// btn_evaluaciones
			// 
			this.btn_evaluaciones.BackColor = System.Drawing.Color.Red;
			this.btn_evaluaciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_evaluaciones.Font = new System.Drawing.Font("Tahoma", 11F);
			this.btn_evaluaciones.ForeColor = System.Drawing.Color.White;
			this.btn_evaluaciones.Location = new System.Drawing.Point(717, 43);
			this.btn_evaluaciones.Name = "btn_evaluaciones";
			this.btn_evaluaciones.Size = new System.Drawing.Size(232, 34);
			this.btn_evaluaciones.TabIndex = 78;
			this.btn_evaluaciones.Text = "Evaluaciones";
			this.btn_evaluaciones.UseVisualStyleBackColor = false;
			this.btn_evaluaciones.Click += new System.EventHandler(this.btn_evaluaciones_Click);
			// 
			// panelAsistencias
			// 
			this.panelAsistencias.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panelAsistencias.Controls.Add(this.dgvAsistenciasCount);
			this.panelAsistencias.Controls.Add(this.dgvAsistencias);
			this.panelAsistencias.Location = new System.Drawing.Point(22, 197);
			this.panelAsistencias.Name = "panelAsistencias";
			this.panelAsistencias.Size = new System.Drawing.Size(1222, 429);
			this.panelAsistencias.TabIndex = 81;
			// 
			// dgvAsistenciasCount
			// 
			this.dgvAsistenciasCount.AllowUserToAddRows = false;
			this.dgvAsistenciasCount.AllowUserToDeleteRows = false;
			this.dgvAsistenciasCount.AllowUserToResizeColumns = false;
			this.dgvAsistenciasCount.AllowUserToResizeRows = false;
			this.dgvAsistenciasCount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dgvAsistenciasCount.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvAsistenciasCount.BackgroundColor = System.Drawing.Color.LightGray;
			this.dgvAsistenciasCount.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
			this.dgvAsistenciasCount.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvAsistenciasCount.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dgvAsistenciasCount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvAsistenciasCount.Cursor = System.Windows.Forms.Cursors.Hand;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgvAsistenciasCount.DefaultCellStyle = dataGridViewCellStyle2;
			this.dgvAsistenciasCount.EnableHeadersVisualStyles = false;
			this.dgvAsistenciasCount.GridColor = System.Drawing.Color.White;
			this.dgvAsistenciasCount.Location = new System.Drawing.Point(3, 21);
			this.dgvAsistenciasCount.MultiSelect = false;
			this.dgvAsistenciasCount.Name = "dgvAsistenciasCount";
			this.dgvAsistenciasCount.ReadOnly = true;
			this.dgvAsistenciasCount.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvAsistenciasCount.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
			this.dgvAsistenciasCount.RowHeadersVisible = false;
			this.dgvAsistenciasCount.RowHeadersWidth = 62;
			dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.LightGray;
			dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText;
			this.dgvAsistenciasCount.RowsDefaultCellStyle = dataGridViewCellStyle4;
			this.dgvAsistenciasCount.RowTemplate.Height = 28;
			this.dgvAsistenciasCount.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvAsistenciasCount.Size = new System.Drawing.Size(1213, 108);
			this.dgvAsistenciasCount.TabIndex = 86;
			// 
			// dgvAsistencias
			// 
			this.dgvAsistencias.AllowUserToAddRows = false;
			this.dgvAsistencias.AllowUserToDeleteRows = false;
			this.dgvAsistencias.AllowUserToResizeColumns = false;
			this.dgvAsistencias.AllowUserToResizeRows = false;
			this.dgvAsistencias.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dgvAsistencias.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvAsistencias.BackgroundColor = System.Drawing.Color.LightGray;
			this.dgvAsistencias.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
			this.dgvAsistencias.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
			dataGridViewCellStyle5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
			dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvAsistencias.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
			this.dgvAsistencias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvAsistencias.Cursor = System.Windows.Forms.Cursors.Hand;
			dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle6.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgvAsistencias.DefaultCellStyle = dataGridViewCellStyle6;
			this.dgvAsistencias.EnableHeadersVisualStyles = false;
			this.dgvAsistencias.GridColor = System.Drawing.Color.White;
			this.dgvAsistencias.Location = new System.Drawing.Point(3, 135);
			this.dgvAsistencias.MultiSelect = false;
			this.dgvAsistencias.Name = "dgvAsistencias";
			this.dgvAsistencias.ReadOnly = true;
			this.dgvAsistencias.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
			dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
			dataGridViewCellStyle7.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
			dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvAsistencias.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
			this.dgvAsistencias.RowHeadersVisible = false;
			this.dgvAsistencias.RowHeadersWidth = 62;
			dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle8.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.LightGray;
			dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.ControlText;
			this.dgvAsistencias.RowsDefaultCellStyle = dataGridViewCellStyle8;
			this.dgvAsistencias.RowTemplate.Height = 28;
			this.dgvAsistencias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvAsistencias.Size = new System.Drawing.Size(1210, 332);
			this.dgvAsistencias.TabIndex = 85;
			// 
			// panelEvaluaciones
			// 
			this.panelEvaluaciones.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panelEvaluaciones.BackColor = System.Drawing.Color.White;
			this.panelEvaluaciones.Controls.Add(this.dgv_totales);
			this.panelEvaluaciones.Controls.Add(this.dgv_evaluaciones);
			this.panelEvaluaciones.Location = new System.Drawing.Point(22, 197);
			this.panelEvaluaciones.Name = "panelEvaluaciones";
			this.panelEvaluaciones.Size = new System.Drawing.Size(1221, 440);
			this.panelEvaluaciones.TabIndex = 82;
			// 
			// dgv_totales
			// 
			this.dgv_totales.AllowUserToAddRows = false;
			this.dgv_totales.AllowUserToDeleteRows = false;
			this.dgv_totales.AllowUserToResizeColumns = false;
			this.dgv_totales.AllowUserToResizeRows = false;
			this.dgv_totales.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dgv_totales.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgv_totales.BackgroundColor = System.Drawing.Color.LightGray;
			this.dgv_totales.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
			this.dgv_totales.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
			dataGridViewCellStyle9.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle9.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
			dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgv_totales.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
			this.dgv_totales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgv_totales.Cursor = System.Windows.Forms.Cursors.Hand;
			dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle10.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgv_totales.DefaultCellStyle = dataGridViewCellStyle10;
			this.dgv_totales.EnableHeadersVisualStyles = false;
			this.dgv_totales.GridColor = System.Drawing.Color.White;
			this.dgv_totales.Location = new System.Drawing.Point(5, 308);
			this.dgv_totales.MultiSelect = false;
			this.dgv_totales.Name = "dgv_totales";
			this.dgv_totales.ReadOnly = true;
			this.dgv_totales.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
			dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
			dataGridViewCellStyle11.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
			dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgv_totales.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
			this.dgv_totales.RowHeadersVisible = false;
			this.dgv_totales.RowHeadersWidth = 62;
			dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle12.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle12.ForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.LightGray;
			dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.ControlText;
			this.dgv_totales.RowsDefaultCellStyle = dataGridViewCellStyle12;
			this.dgv_totales.RowTemplate.Height = 28;
			this.dgv_totales.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgv_totales.Size = new System.Drawing.Size(1210, 135);
			this.dgv_totales.TabIndex = 87;
			// 
			// dgv_evaluaciones
			// 
			this.dgv_evaluaciones.AllowUserToAddRows = false;
			this.dgv_evaluaciones.AllowUserToDeleteRows = false;
			this.dgv_evaluaciones.AllowUserToResizeColumns = false;
			this.dgv_evaluaciones.AllowUserToResizeRows = false;
			this.dgv_evaluaciones.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dgv_evaluaciones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgv_evaluaciones.BackgroundColor = System.Drawing.Color.LightGray;
			this.dgv_evaluaciones.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
			this.dgv_evaluaciones.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
			dataGridViewCellStyle13.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle13.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
			dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgv_evaluaciones.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
			this.dgv_evaluaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgv_evaluaciones.Cursor = System.Windows.Forms.Cursors.Hand;
			dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle14.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgv_evaluaciones.DefaultCellStyle = dataGridViewCellStyle14;
			this.dgv_evaluaciones.EnableHeadersVisualStyles = false;
			this.dgv_evaluaciones.GridColor = System.Drawing.Color.White;
			this.dgv_evaluaciones.Location = new System.Drawing.Point(5, 20);
			this.dgv_evaluaciones.MultiSelect = false;
			this.dgv_evaluaciones.Name = "dgv_evaluaciones";
			this.dgv_evaluaciones.ReadOnly = true;
			this.dgv_evaluaciones.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
			dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
			dataGridViewCellStyle15.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle15.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
			dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgv_evaluaciones.RowHeadersDefaultCellStyle = dataGridViewCellStyle15;
			this.dgv_evaluaciones.RowHeadersVisible = false;
			this.dgv_evaluaciones.RowHeadersWidth = 62;
			dataGridViewCellStyle16.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle16.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle16.ForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.LightGray;
			dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.ControlText;
			this.dgv_evaluaciones.RowsDefaultCellStyle = dataGridViewCellStyle16;
			this.dgv_evaluaciones.RowTemplate.Height = 28;
			this.dgv_evaluaciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgv_evaluaciones.Size = new System.Drawing.Size(1210, 299);
			this.dgv_evaluaciones.TabIndex = 86;
			// 
			// FormControlAsistencias
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 29F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoScroll = true;
			this.AutoSize = true;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(1276, 669);
			this.Controls.Add(this.panelEvaluaciones);
			this.Controls.Add(this.panelAsistencias);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Controls.Add(this.lblPorcentajeAsistencia);
			this.Margin = new System.Windows.Forms.Padding(6);
			this.Name = "FormControlAsistencias";
			this.Padding = new System.Windows.Forms.Padding(30, 29, 30, 29);
			this.Text = "ControlAsistencias";
			this.Load += new System.EventHandler(this.ControlAsistencias_Load);
			this.cmsPyA.ResumeLayout(false);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.panelAsistencias.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvAsistenciasCount)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvAsistencias)).EndInit();
			this.panelEvaluaciones.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgv_totales)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgv_evaluaciones)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDescargar;
        private System.Windows.Forms.Label lblPorcentajeAsistencia;
        private System.Windows.Forms.ContextMenuStrip cmsPyA;
        private System.Windows.Forms.ToolStripMenuItem tsmP;
        private System.Windows.Forms.ToolStripMenuItem tsmA;
        private System.Windows.Forms.ToolStripMenuItem tsmHistorialAsistenciasAlumnos;
		private System.Windows.Forms.Button btnAceptarAsistencia;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.ComboBox cboFiltroCarrera;
		private System.Windows.Forms.ComboBox cboFiltroAnio;
		private System.Windows.Forms.Label lblFiltroAnio;
		private System.Windows.Forms.Button btnFiltrar;
		private System.Windows.Forms.Label lblFiltroCurso;
		private System.Windows.Forms.ComboBox cboFiltroAnioLectivo;
		private System.Windows.Forms.Label lblFiltroMateria;
		private System.Windows.Forms.Label lblFiltroCarrera;
		private System.Windows.Forms.ComboBox cboFiltroCurso;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox cboFiltroMateria;
		private System.Windows.Forms.Panel panelAsistencias;
		public System.Windows.Forms.DataGridView dgvAsistenciasCount;
		public System.Windows.Forms.DataGridView dgvAsistencias;
		private System.Windows.Forms.Panel panelEvaluaciones;
		private System.Windows.Forms.Button btn_evaluaciones;
		public System.Windows.Forms.DataGridView dgv_evaluaciones;
		private System.Windows.Forms.Label lblDetalleCursadaId;
		private System.Windows.Forms.TextBox txb_detalleCursadaId;
		public System.Windows.Forms.DataGridView dgv_totales;
	}
}