namespace EVA2JulianAndresPalacios
{
    partial class Conexion
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
            this.btnConexion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnConexion
            // 
            this.btnConexion.Location = new System.Drawing.Point(335, 54);
            this.btnConexion.Name = "btnConexion";
            this.btnConexion.Size = new System.Drawing.Size(75, 23);
            this.btnConexion.TabIndex = 0;
            this.btnConexion.Text = "Conexion";
            this.btnConexion.UseVisualStyleBackColor = true;
            this.btnConexion.Click += new System.EventHandler(this.btnConexion_Click);
            // 
            // Conexion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1146, 507);
            this.Controls.Add(this.btnConexion);
            this.Name = "Conexion";
            this.ShowIcon = false;
            this.Text = "Conexion";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnConexion;
    }
}