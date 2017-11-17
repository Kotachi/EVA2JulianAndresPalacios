namespace EVA2JulianAndresPalacios
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.codigoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rutDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.appaternoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apmaternoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nota1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nota2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nota3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nota4DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalNotasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.notasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iPLEONESDataSet = new EVA2JulianAndresPalacios.IPLEONESDataSet();
            this.fillByToolStrip = new System.Windows.Forms.ToolStrip();
            this.fillByToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.txtBuscarDG = new System.Windows.Forms.ToolStripTextBox();
            this.btnBuscarDG = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnPromMate = new System.Windows.Forms.ToolStripButton();
            this.btnPromProg = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnRepitentes = new System.Windows.Forms.ToolStripButton();
            this.btnExamen = new System.Windows.Forms.ToolStripButton();
            this.btnAprobados = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btnLimpiar = new System.Windows.Forms.ToolStripButton();
            this.notasTableAdapter = new EVA2JulianAndresPalacios.IPLEONESDataSetTableAdapters.notasTableAdapter();
            this.btnSiguiente = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.notasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iPLEONESDataSet)).BeginInit();
            this.fillByToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigoDataGridViewTextBoxColumn,
            this.rutDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.appaternoDataGridViewTextBoxColumn,
            this.apmaternoDataGridViewTextBoxColumn,
            this.nota1DataGridViewTextBoxColumn,
            this.nota2DataGridViewTextBoxColumn,
            this.nota3DataGridViewTextBoxColumn,
            this.nota4DataGridViewTextBoxColumn,
            this.totalNotasDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.notasBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1055, 485);
            this.dataGridView1.TabIndex = 0;
            // 
            // codigoDataGridViewTextBoxColumn
            // 
            this.codigoDataGridViewTextBoxColumn.DataPropertyName = "codigo";
            this.codigoDataGridViewTextBoxColumn.HeaderText = "codigo";
            this.codigoDataGridViewTextBoxColumn.Name = "codigoDataGridViewTextBoxColumn";
            // 
            // rutDataGridViewTextBoxColumn
            // 
            this.rutDataGridViewTextBoxColumn.DataPropertyName = "rut";
            this.rutDataGridViewTextBoxColumn.HeaderText = "rut";
            this.rutDataGridViewTextBoxColumn.Name = "rutDataGridViewTextBoxColumn";
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            // 
            // appaternoDataGridViewTextBoxColumn
            // 
            this.appaternoDataGridViewTextBoxColumn.DataPropertyName = "Appaterno";
            this.appaternoDataGridViewTextBoxColumn.HeaderText = "Appaterno";
            this.appaternoDataGridViewTextBoxColumn.Name = "appaternoDataGridViewTextBoxColumn";
            // 
            // apmaternoDataGridViewTextBoxColumn
            // 
            this.apmaternoDataGridViewTextBoxColumn.DataPropertyName = "Apmaterno";
            this.apmaternoDataGridViewTextBoxColumn.HeaderText = "Apmaterno";
            this.apmaternoDataGridViewTextBoxColumn.Name = "apmaternoDataGridViewTextBoxColumn";
            // 
            // nota1DataGridViewTextBoxColumn
            // 
            this.nota1DataGridViewTextBoxColumn.DataPropertyName = "Nota1";
            this.nota1DataGridViewTextBoxColumn.HeaderText = "Nota1";
            this.nota1DataGridViewTextBoxColumn.Name = "nota1DataGridViewTextBoxColumn";
            // 
            // nota2DataGridViewTextBoxColumn
            // 
            this.nota2DataGridViewTextBoxColumn.DataPropertyName = "Nota2";
            this.nota2DataGridViewTextBoxColumn.HeaderText = "Nota2";
            this.nota2DataGridViewTextBoxColumn.Name = "nota2DataGridViewTextBoxColumn";
            // 
            // nota3DataGridViewTextBoxColumn
            // 
            this.nota3DataGridViewTextBoxColumn.DataPropertyName = "Nota3";
            this.nota3DataGridViewTextBoxColumn.HeaderText = "Nota3";
            this.nota3DataGridViewTextBoxColumn.Name = "nota3DataGridViewTextBoxColumn";
            // 
            // nota4DataGridViewTextBoxColumn
            // 
            this.nota4DataGridViewTextBoxColumn.DataPropertyName = "Nota4";
            this.nota4DataGridViewTextBoxColumn.HeaderText = "Nota4";
            this.nota4DataGridViewTextBoxColumn.Name = "nota4DataGridViewTextBoxColumn";
            // 
            // totalNotasDataGridViewTextBoxColumn
            // 
            this.totalNotasDataGridViewTextBoxColumn.DataPropertyName = "TotalNotas";
            this.totalNotasDataGridViewTextBoxColumn.HeaderText = "TotalNotas";
            this.totalNotasDataGridViewTextBoxColumn.Name = "totalNotasDataGridViewTextBoxColumn";
            // 
            // notasBindingSource
            // 
            this.notasBindingSource.DataMember = "notas";
            this.notasBindingSource.DataSource = this.iPLEONESDataSet;
            // 
            // iPLEONESDataSet
            // 
            this.iPLEONESDataSet.DataSetName = "IPLEONESDataSet";
            this.iPLEONESDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fillByToolStrip
            // 
            this.fillByToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fillByToolStripButton,
            this.txtBuscarDG,
            this.btnBuscarDG,
            this.toolStripSeparator1,
            this.btnPromMate,
            this.btnPromProg,
            this.toolStripSeparator2,
            this.btnRepitentes,
            this.btnExamen,
            this.btnAprobados,
            this.toolStripSeparator3,
            this.btnLimpiar});
            this.fillByToolStrip.Location = new System.Drawing.Point(0, 0);
            this.fillByToolStrip.Name = "fillByToolStrip";
            this.fillByToolStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.fillByToolStrip.Size = new System.Drawing.Size(1231, 25);
            this.fillByToolStrip.TabIndex = 1;
            this.fillByToolStrip.Text = "fillByToolStrip";
            // 
            // fillByToolStripButton
            // 
            this.fillByToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillByToolStripButton.Name = "fillByToolStripButton";
            this.fillByToolStripButton.Size = new System.Drawing.Size(39, 22);
            this.fillByToolStripButton.Text = "FillBy";
            this.fillByToolStripButton.Click += new System.EventHandler(this.fillByToolStripButton_Click);
            // 
            // txtBuscarDG
            // 
            this.txtBuscarDG.Name = "txtBuscarDG";
            this.txtBuscarDG.Size = new System.Drawing.Size(100, 25);
            // 
            // btnBuscarDG
            // 
            this.btnBuscarDG.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnBuscarDG.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarDG.Image")));
            this.btnBuscarDG.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnBuscarDG.Name = "btnBuscarDG";
            this.btnBuscarDG.Size = new System.Drawing.Size(107, 22);
            this.btnBuscarDG.Text = "Buscar por codigo";
            this.btnBuscarDG.Click += new System.EventHandler(this.btnBuscarDG_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // btnPromMate
            // 
            this.btnPromMate.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnPromMate.Image = ((System.Drawing.Image)(resources.GetObject("btnPromMate.Image")));
            this.btnPromMate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPromMate.Name = "btnPromMate";
            this.btnPromMate.Size = new System.Drawing.Size(134, 22);
            this.btnPromMate.Text = "Promedio Matematicas";
            this.btnPromMate.Click += new System.EventHandler(this.btnPromMate_Click);
            // 
            // btnPromProg
            // 
            this.btnPromProg.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnPromProg.Image = ((System.Drawing.Image)(resources.GetObject("btnPromProg.Image")));
            this.btnPromProg.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPromProg.Name = "btnPromProg";
            this.btnPromProg.Size = new System.Drawing.Size(141, 22);
            this.btnPromProg.Text = "Promedio Programacion";
            this.btnPromProg.Click += new System.EventHandler(this.btnPromProg_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // btnRepitentes
            // 
            this.btnRepitentes.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnRepitentes.Image = ((System.Drawing.Image)(resources.GetObject("btnRepitentes.Image")));
            this.btnRepitentes.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRepitentes.Name = "btnRepitentes";
            this.btnRepitentes.Size = new System.Drawing.Size(66, 22);
            this.btnRepitentes.Text = "Repitentes";
            this.btnRepitentes.Click += new System.EventHandler(this.btnRepitentes_Click);
            // 
            // btnExamen
            // 
            this.btnExamen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnExamen.Image = ((System.Drawing.Image)(resources.GetObject("btnExamen.Image")));
            this.btnExamen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnExamen.Name = "btnExamen";
            this.btnExamen.Size = new System.Drawing.Size(76, 22);
            this.btnExamen.Text = "Dan Examen";
            this.btnExamen.Click += new System.EventHandler(this.btnExamen_Click);
            // 
            // btnAprobados
            // 
            this.btnAprobados.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnAprobados.Image = ((System.Drawing.Image)(resources.GetObject("btnAprobados.Image")));
            this.btnAprobados.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAprobados.Name = "btnAprobados";
            this.btnAprobados.Size = new System.Drawing.Size(69, 22);
            this.btnAprobados.Text = "Aprobados";
            this.btnAprobados.Click += new System.EventHandler(this.btnAprobados_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnLimpiar.Image = ((System.Drawing.Image)(resources.GetObject("btnLimpiar.Image")));
            this.btnLimpiar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(51, 22);
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // notasTableAdapter
            // 
            this.notasTableAdapter.ClearBeforeFill = true;
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.Location = new System.Drawing.Point(1121, 91);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(75, 23);
            this.btnSiguiente.TabIndex = 2;
            this.btnSiguiente.Text = "Siguiente";
            this.btnSiguiente.UseVisualStyleBackColor = true;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1231, 513);
            this.Controls.Add(this.btnSiguiente);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.fillByToolStrip);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.notasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iPLEONESDataSet)).EndInit();
            this.fillByToolStrip.ResumeLayout(false);
            this.fillByToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private IPLEONESDataSet iPLEONESDataSet;
        private System.Windows.Forms.BindingSource notasBindingSource;
        private IPLEONESDataSetTableAdapters.notasTableAdapter notasTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rutDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn appaternoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apmaternoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nota1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nota2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nota3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nota4DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalNotasDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStrip fillByToolStrip;
        private System.Windows.Forms.ToolStripButton fillByToolStripButton;
        private System.Windows.Forms.ToolStripButton btnBuscarDG;
        private System.Windows.Forms.ToolStripTextBox txtBuscarDG;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnPromMate;
        private System.Windows.Forms.ToolStripButton btnPromProg;
        private System.Windows.Forms.ToolStripButton btnLimpiar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btnRepitentes;
        private System.Windows.Forms.ToolStripButton btnExamen;
        private System.Windows.Forms.ToolStripButton btnAprobados;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.Button btnSiguiente;
    }
}

