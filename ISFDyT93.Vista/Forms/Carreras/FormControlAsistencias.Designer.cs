
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
			this.cboFiltroCarrera = new System.Windows.Forms.ComboBox();
			this.lblFiltroCarrera = new System.Windows.Forms.Label();
			this.cboFiltroAnio = new System.Windows.Forms.ComboBox();
			this.lblFiltroCurso = new System.Windows.Forms.Label();
			this.cboFiltroCurso = new System.Windows.Forms.ComboBox();
			this.lblFiltroAnio = new System.Windows.Forms.Label();
			this.btnFiltrar = new System.Windows.Forms.Button();
			this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this.dgvAsistenciasCount = new System.Windows.Forms.DataGridView();
			this.dgvAsistencias = new System.Windows.Forms.DataGridView();
			this.cmsPyA.SuspendLayout();
			this.tableLayoutPanel1.SuspendLayout();
			this.tableLayoutPanel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvAsistenciasCount)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvAsistencias)).BeginInit();
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
			this.tableLayoutPanel1.ColumnCount = 5;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66333F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.14257F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.022245F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 136F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.01001F));
			this.tableLayoutPanel1.Controls.Add(this.cboFiltroAnioLectivo, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.lblFiltroMateria, 0, 2);
			this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.cboFiltroMateria, 1, 2);
			this.tableLayoutPanel1.Controls.Add(this.cboFiltroCarrera, 4, 0);
			this.tableLayoutPanel1.Controls.Add(this.lblFiltroCarrera, 3, 0);
			this.tableLayoutPanel1.Controls.Add(this.cboFiltroAnio, 1, 1);
			this.tableLayoutPanel1.Controls.Add(this.lblFiltroCurso, 3, 1);
			this.tableLayoutPanel1.Controls.Add(this.cboFiltroCurso, 4, 1);
			this.tableLayoutPanel1.Controls.Add(this.lblFiltroAnio, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.btnFiltrar, 4, 3);
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
			this.cboFiltroAnioLectivo.Location = new System.Drawing.Point(184, 3);
			this.cboFiltroAnioLectivo.Name = "cboFiltroAnioLectivo";
			this.cboFiltroAnioLectivo.Size = new System.Drawing.Size(301, 35);
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
			this.cboFiltroMateria.Location = new System.Drawing.Point(184, 83);
			this.cboFiltroMateria.Name = "cboFiltroMateria";
			this.cboFiltroMateria.Size = new System.Drawing.Size(301, 35);
			this.cboFiltroMateria.TabIndex = 8;
			// 
			// cboFiltroCarrera
			// 
			this.cboFiltroCarrera.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboFiltroCarrera.Font = new System.Drawing.Font("Tahoma", 11F);
			this.cboFiltroCarrera.Location = new System.Drawing.Point(679, 3);
			this.cboFiltroCarrera.Name = "cboFiltroCarrera";
			this.cboFiltroCarrera.Size = new System.Drawing.Size(383, 35);
			this.cboFiltroCarrera.TabIndex = 2;
			this.cboFiltroCarrera.SelectedIndexChanged += new System.EventHandler(this.cboFiltroCarrera_SelectedIndexChanged);
			// 
			// lblFiltroCarrera
			// 
			this.lblFiltroCarrera.AutoSize = true;
			this.lblFiltroCarrera.Font = new System.Drawing.Font("Tahoma", 11F);
			this.lblFiltroCarrera.Location = new System.Drawing.Point(543, 0);
			this.lblFiltroCarrera.Name = "lblFiltroCarrera";
			this.lblFiltroCarrera.Size = new System.Drawing.Size(93, 27);
			this.lblFiltroCarrera.TabIndex = 1;
			this.lblFiltroCarrera.Text = "Carrera:";
			// 
			// cboFiltroAnio
			// 
			this.cboFiltroAnio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboFiltroAnio.Font = new System.Drawing.Font("Tahoma", 11F);
			this.cboFiltroAnio.Location = new System.Drawing.Point(184, 43);
			this.cboFiltroAnio.Name = "cboFiltroAnio";
			this.cboFiltroAnio.Size = new System.Drawing.Size(301, 35);
			this.cboFiltroAnio.TabIndex = 4;
			this.cboFiltroAnio.SelectedIndexChanged += new System.EventHandler(this.cboFiltroAnio_SelectedIndexChanged);
			// 
			// lblFiltroCurso
			// 
			this.lblFiltroCurso.AutoSize = true;
			this.lblFiltroCurso.Font = new System.Drawing.Font("Tahoma", 11F);
			this.lblFiltroCurso.Location = new System.Drawing.Point(543, 40);
			this.lblFiltroCurso.Name = "lblFiltroCurso";
			this.lblFiltroCurso.Size = new System.Drawing.Size(75, 27);
			this.lblFiltroCurso.TabIndex = 5;
			this.lblFiltroCurso.Text = "Curso:";
			// 
			// cboFiltroCurso
			// 
			this.cboFiltroCurso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboFiltroCurso.Font = new System.Drawing.Font("Tahoma", 11F);
			this.cboFiltroCurso.Location = new System.Drawing.Point(679, 43);
			this.cboFiltroCurso.Name = "cboFiltroCurso";
			this.cboFiltroCurso.Size = new System.Drawing.Size(383, 35);
			this.cboFiltroCurso.TabIndex = 6;
			this.cboFiltroCurso.SelectedIndexChanged += new System.EventHandler(this.cboFiltroCurso_SelectedIndexChanged);
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
			// btnFiltrar
			// 
			this.btnFiltrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(1)))), ((int)(((byte)(124)))));
			this.btnFiltrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnFiltrar.Font = new System.Drawing.Font("Tahoma", 11F);
			this.btnFiltrar.ForeColor = System.Drawing.Color.White;
			this.btnFiltrar.Location = new System.Drawing.Point(679, 123);
			this.btnFiltrar.Name = "btnFiltrar";
			this.btnFiltrar.Size = new System.Drawing.Size(383, 36);
			this.btnFiltrar.TabIndex = 9;
			this.btnFiltrar.Text = "Filtrar";
			this.btnFiltrar.UseVisualStyleBackColor = false;
			this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
			// 
			// tableLayoutPanel2
			// 
			this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tableLayoutPanel2.ColumnCount = 1;
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel2.Controls.Add(this.dgvAsistenciasCount, 0, 0);
			this.tableLayoutPanel2.Controls.Add(this.dgvAsistencias, 0, 1);
			this.tableLayoutPanel2.Location = new System.Drawing.Point(22, 193);
			this.tableLayoutPanel2.Name = "tableLayoutPanel2";
			this.tableLayoutPanel2.RowCount = 2;
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 26.55087F));
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 73.44913F));
			this.tableLayoutPanel2.Size = new System.Drawing.Size(1222, 476);
			this.tableLayoutPanel2.TabIndex = 84;
			// 
			// dgvAsistenciasCount
			// 
			this.dgvAsistenciasCount.AllowUserToAddRows = false;
			this.dgvAsistenciasCount.AllowUserToDeleteRows = false;
			this.dgvAsistenciasCount.AllowUserToResizeColumns = false;
			this.dgvAsistenciasCount.AllowUserToResizeRows = false;
			this.dgvAsistenciasCount.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvAsistenciasCount.BackgroundColor = System.Drawing.Color.White;
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
			this.dgvAsistenciasCount.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgvAsistenciasCount.EnableHeadersVisualStyles = false;
			this.dgvAsistenciasCount.GridColor = System.Drawing.Color.White;
			this.dgvAsistenciasCount.Location = new System.Drawing.Point(3, 3);
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
			this.dgvAsistenciasCount.Size = new System.Drawing.Size(1216, 120);
			this.dgvAsistenciasCount.TabIndex = 85;
			// 
			// dgvAsistencias
			// 
			this.dgvAsistencias.AllowUserToAddRows = false;
			this.dgvAsistencias.AllowUserToDeleteRows = false;
			this.dgvAsistencias.AllowUserToResizeColumns = false;
			this.dgvAsistencias.AllowUserToResizeRows = false;
			this.dgvAsistencias.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvAsistencias.BackgroundColor = System.Drawing.Color.White;
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
			this.dgvAsistencias.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgvAsistencias.EnableHeadersVisualStyles = false;
			this.dgvAsistencias.GridColor = System.Drawing.Color.White;
			this.dgvAsistencias.Location = new System.Drawing.Point(3, 129);
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
			this.dgvAsistencias.Size = new System.Drawing.Size(1216, 344);
			this.dgvAsistencias.TabIndex = 84;
			// 
			// FormControlAsistencias
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 29F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoScroll = true;
			this.AutoSize = true;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(1276, 669);
			this.Controls.Add(this.tableLayoutPanel2);
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
			this.tableLayoutPanel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvAsistenciasCount)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvAsistencias)).EndInit();
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
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
		public System.Windows.Forms.DataGridView dgvAsistencias;
		public System.Windows.Forms.DataGridView dgvAsistenciasCount;
	}
}