namespace Ejercicio1
{
    partial class DataTabla
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
            this.NombreText = new System.Windows.Forms.TextBox();
            this.GuardarBoton = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.Fecha_De_Nacimiento = new System.Windows.Forms.DateTimePicker();
            this.Boton_Eliminar = new System.Windows.Forms.Button();
            this.label_Nombre = new System.Windows.Forms.Label();
            this.label_Apellido = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label_Direccion = new System.Windows.Forms.Label();
            this.DireccionText = new System.Windows.Forms.TextBox();
            this.ApellidoText = new System.Windows.Forms.TextBox();
            this.BotonBuscar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // NombreText
            // 
            this.NombreText.Location = new System.Drawing.Point(80, 52);
            this.NombreText.Name = "NombreText";
            this.NombreText.Size = new System.Drawing.Size(182, 20);
            this.NombreText.TabIndex = 0;
            this.NombreText.TextChanged += new System.EventHandler(this.NombreText_TextChanged);
            // 
            // GuardarBoton
            // 
            this.GuardarBoton.Location = new System.Drawing.Point(29, 221);
            this.GuardarBoton.Name = "GuardarBoton";
            this.GuardarBoton.Size = new System.Drawing.Size(111, 24);
            this.GuardarBoton.TabIndex = 1;
            this.GuardarBoton.Text = "Guardar";
            this.GuardarBoton.UseVisualStyleBackColor = true;
            this.GuardarBoton.Click += new System.EventHandler(this.GuardarBoton_Click);
            // 
            // Fecha_De_Nacimiento
            // 
            this.Fecha_De_Nacimiento.Location = new System.Drawing.Point(146, 106);
            this.Fecha_De_Nacimiento.Name = "Fecha_De_Nacimiento";
            this.Fecha_De_Nacimiento.Size = new System.Drawing.Size(175, 20);
            this.Fecha_De_Nacimiento.TabIndex = 3;
            this.Fecha_De_Nacimiento.ValueChanged += new System.EventHandler(this.Fecha_De_Nacimiento_ValueChanged);
            // 
            // Boton_Eliminar
            // 
            this.Boton_Eliminar.Location = new System.Drawing.Point(270, 221);
            this.Boton_Eliminar.Name = "Boton_Eliminar";
            this.Boton_Eliminar.Size = new System.Drawing.Size(93, 22);
            this.Boton_Eliminar.TabIndex = 4;
            this.Boton_Eliminar.Text = "Eliminar";
            this.Boton_Eliminar.UseVisualStyleBackColor = true;
            this.Boton_Eliminar.Click += new System.EventHandler(this.Boton_Eliminar_Click);
            // 
            // label_Nombre
            // 
            this.label_Nombre.AutoSize = true;
            this.label_Nombre.Location = new System.Drawing.Point(30, 59);
            this.label_Nombre.Name = "label_Nombre";
            this.label_Nombre.Size = new System.Drawing.Size(44, 13);
            this.label_Nombre.TabIndex = 5;
            this.label_Nombre.Text = "Nombre";
            // 
            // label_Apellido
            // 
            this.label_Apellido.AutoSize = true;
            this.label_Apellido.Location = new System.Drawing.Point(30, 87);
            this.label_Apellido.Name = "label_Apellido";
            this.label_Apellido.Size = new System.Drawing.Size(44, 13);
            this.label_Apellido.TabIndex = 6;
            this.label_Apellido.Text = "Apellido";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Fecha De Nacimiento";
            // 
            // label_Direccion
            // 
            this.label_Direccion.AutoSize = true;
            this.label_Direccion.Location = new System.Drawing.Point(88, 139);
            this.label_Direccion.Name = "label_Direccion";
            this.label_Direccion.Size = new System.Drawing.Size(52, 13);
            this.label_Direccion.TabIndex = 9;
            this.label_Direccion.Text = "Direccion";
            // 
            // DireccionText
            // 
            this.DireccionText.Location = new System.Drawing.Point(146, 132);
            this.DireccionText.Name = "DireccionText";
            this.DireccionText.Size = new System.Drawing.Size(168, 20);
            this.DireccionText.TabIndex = 10;
            this.DireccionText.TextChanged += new System.EventHandler(this.DireccionText_TextChanged);
            // 
            // ApellidoText
            // 
            this.ApellidoText.Location = new System.Drawing.Point(80, 80);
            this.ApellidoText.Name = "ApellidoText";
            this.ApellidoText.Size = new System.Drawing.Size(182, 20);
            this.ApellidoText.TabIndex = 11;
            this.ApellidoText.TextChanged += new System.EventHandler(this.ApellidoText_TextChanged);
            // 
            // BotonBuscar
            // 
            this.BotonBuscar.Location = new System.Drawing.Point(168, 220);
            this.BotonBuscar.Name = "BotonBuscar";
            this.BotonBuscar.Size = new System.Drawing.Size(75, 23);
            this.BotonBuscar.TabIndex = 14;
            this.BotonBuscar.Text = "Buscar";
            this.BotonBuscar.UseVisualStyleBackColor = true;
            this.BotonBuscar.Click += new System.EventHandler(this.BotonBuscar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(404, 38);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(340, 159);
            this.dataGridView1.TabIndex = 15;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // DataTabla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.BotonBuscar);
            this.Controls.Add(this.ApellidoText);
            this.Controls.Add(this.DireccionText);
            this.Controls.Add(this.label_Direccion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_Apellido);
            this.Controls.Add(this.label_Nombre);
            this.Controls.Add(this.Boton_Eliminar);
            this.Controls.Add(this.Fecha_De_Nacimiento);
            this.Controls.Add(this.GuardarBoton);
            this.Controls.Add(this.NombreText);
            this.Name = "DataTabla";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NombreText;
        private System.Windows.Forms.Button GuardarBoton;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.DateTimePicker Fecha_De_Nacimiento;
        private System.Windows.Forms.Button Boton_Eliminar;
        private System.Windows.Forms.Label label_Nombre;
        private System.Windows.Forms.Label label_Apellido;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_Direccion;
        private System.Windows.Forms.TextBox DireccionText;
        private System.Windows.Forms.TextBox ApellidoText;
        private System.Windows.Forms.Button BotonBuscar;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

