namespace ClinicaPublic
{
    partial class FormExamen
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            txtNombre = new TextBox();
            txtPrecio = new TextBox();
            groupBoxExamen = new GroupBox();
            lblPrecio = new Label();
            lblNombre = new Label();
            groupBoxOpciones = new GroupBox();
            btnCerrar = new Button();
            btnAgregar = new Button();
            dataGridView1 = new DataGridView();
            colId = new DataGridViewTextBoxColumn();
            colNombre = new DataGridViewTextBoxColumn();
            colPrecio = new DataGridViewTextBoxColumn();
            colFechaRegistro = new DataGridViewTextBoxColumn();
            colDelete = new DataGridViewButtonColumn();
            groupBoxExamen.SuspendLayout();
            groupBoxOpciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // txtNombre
            // 
            txtNombre.CharacterCasing = CharacterCasing.Upper;
            txtNombre.Location = new Point(126, 22);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(320, 23);
            txtNombre.TabIndex = 0;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(126, 52);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(100, 23);
            txtPrecio.TabIndex = 1;
            // 
            // groupBoxExamen
            // 
            groupBoxExamen.Controls.Add(lblPrecio);
            groupBoxExamen.Controls.Add(lblNombre);
            groupBoxExamen.Controls.Add(txtNombre);
            groupBoxExamen.Controls.Add(txtPrecio);
            groupBoxExamen.Location = new Point(12, 12);
            groupBoxExamen.Name = "groupBoxExamen";
            groupBoxExamen.Size = new Size(625, 86);
            groupBoxExamen.TabIndex = 2;
            groupBoxExamen.TabStop = false;
            groupBoxExamen.Text = "groupBox1";
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Location = new Point(31, 55);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(38, 15);
            lblPrecio.TabIndex = 3;
            lblPrecio.Text = "label2";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(31, 25);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(38, 15);
            lblNombre.TabIndex = 2;
            lblNombre.Text = "label1";
            // 
            // groupBoxOpciones
            // 
            groupBoxOpciones.Controls.Add(btnCerrar);
            groupBoxOpciones.Controls.Add(btnAgregar);
            groupBoxOpciones.Location = new Point(643, 12);
            groupBoxOpciones.Name = "groupBoxOpciones";
            groupBoxOpciones.Size = new Size(161, 86);
            groupBoxOpciones.TabIndex = 3;
            groupBoxOpciones.TabStop = false;
            groupBoxOpciones.Text = "groupBox1";
            // 
            // btnCerrar
            // 
            btnCerrar.Location = new Point(6, 51);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(148, 23);
            btnCerrar.TabIndex = 1;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(6, 22);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(148, 23);
            btnAgregar.TabIndex = 0;
            btnAgregar.Text = "Add";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAceptar_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { colId, colNombre, colPrecio, colFechaRegistro, colDelete });
            dataGridView1.Location = new Point(12, 104);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(792, 336);
            dataGridView1.TabIndex = 4;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.CellValueChanged += dataGridView1_CellValueChanged;
            // 
            // colId
            // 
            colId.DataPropertyName = "Id";
            colId.HeaderText = "Id";
            colId.Name = "colId";
            // 
            // colNombre
            // 
            colNombre.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            colNombre.DataPropertyName = "Nombre";
            colNombre.HeaderText = "Nombre";
            colNombre.Name = "colNombre";
            colNombre.Width = 76;
            // 
            // colPrecio
            // 
            colPrecio.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            colPrecio.DataPropertyName = "Precio";
            colPrecio.HeaderText = "Precio";
            colPrecio.Name = "colPrecio";
            colPrecio.Width = 65;
            // 
            // colFechaRegistro
            // 
            colFechaRegistro.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            colFechaRegistro.DataPropertyName = "FechaRegistro";
            colFechaRegistro.HeaderText = "Fecha Registro";
            colFechaRegistro.Name = "colFechaRegistro";
            colFechaRegistro.Width = 109;
            // 
            // colDelete
            // 
            colDelete.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.ForeColor = Color.Red;
            colDelete.DefaultCellStyle = dataGridViewCellStyle1;
            colDelete.HeaderText = "Eliminar";
            colDelete.Name = "colDelete";
            colDelete.Text = "Eliminar";
            colDelete.UseColumnTextForButtonValue = true;
            colDelete.Width = 56;
            // 
            // FormExamen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(815, 479);
            Controls.Add(dataGridView1);
            Controls.Add(groupBoxOpciones);
            Controls.Add(groupBoxExamen);
            Name = "FormExamen";
            Text = "Form1";
            Load += FormExamen_Load;
            groupBoxExamen.ResumeLayout(false);
            groupBoxExamen.PerformLayout();
            groupBoxOpciones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TextBox txtNombre;
        private TextBox txtPrecio;
        private GroupBox groupBoxExamen;
        private Label lblPrecio;
        private Label lblNombre;
        private GroupBox groupBoxOpciones;
        private Button btnCerrar;
        private Button btnAgregar;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn colId;
        private DataGridViewTextBoxColumn colNombre;
        private DataGridViewTextBoxColumn colPrecio;
        private DataGridViewTextBoxColumn colFechaRegistro;
        private DataGridViewButtonColumn colDelete;
    }
}