namespace Preparatoria
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tB1 = new System.Windows.Forms.TextBox();
            this.textsemestre = new System.Windows.Forms.TextBox();
            this.textnombre = new System.Windows.Forms.TextBox();
            this.rBagregar = new System.Windows.Forms.RadioButton();
            this.rBeliminar = new System.Windows.Forms.RadioButton();
            this.rBcalificaciones = new System.Windows.Forms.RadioButton();
            this.dGV = new System.Windows.Forms.DataGridView();
            this.btnaceptar = new System.Windows.Forms.Button();
            this.rBbuscar = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dGV)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Matricula :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(413, 25);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Semestre :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(171, 25);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nombre :";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // tB1
            // 
            this.tB1.Location = new System.Drawing.Point(64, 21);
            this.tB1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tB1.Name = "tB1";
            this.tB1.Size = new System.Drawing.Size(102, 20);
            this.tB1.TabIndex = 3;
            // 
            // textsemestre
            // 
            this.textsemestre.Location = new System.Drawing.Point(474, 22);
            this.textsemestre.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textsemestre.Name = "textsemestre";
            this.textsemestre.Size = new System.Drawing.Size(94, 20);
            this.textsemestre.TabIndex = 4;
            // 
            // textnombre
            // 
            this.textnombre.Location = new System.Drawing.Point(223, 22);
            this.textnombre.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textnombre.Name = "textnombre";
            this.textnombre.Size = new System.Drawing.Size(186, 20);
            this.textnombre.TabIndex = 5;
            // 
            // rBagregar
            // 
            this.rBagregar.AutoSize = true;
            this.rBagregar.Location = new System.Drawing.Point(5, 48);
            this.rBagregar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rBagregar.Name = "rBagregar";
            this.rBagregar.Size = new System.Drawing.Size(62, 17);
            this.rBagregar.TabIndex = 6;
            this.rBagregar.TabStop = true;
            this.rBagregar.Text = "Agregar";
            this.rBagregar.UseVisualStyleBackColor = true;
            this.rBagregar.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rBeliminar
            // 
            this.rBeliminar.AutoSize = true;
            this.rBeliminar.Location = new System.Drawing.Point(5, 69);
            this.rBeliminar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rBeliminar.Name = "rBeliminar";
            this.rBeliminar.Size = new System.Drawing.Size(61, 17);
            this.rBeliminar.TabIndex = 8;
            this.rBeliminar.TabStop = true;
            this.rBeliminar.Text = "Eliminar";
            this.rBeliminar.UseVisualStyleBackColor = true;
            this.rBeliminar.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // rBcalificaciones
            // 
            this.rBcalificaciones.AutoSize = true;
            this.rBcalificaciones.Location = new System.Drawing.Point(5, 90);
            this.rBcalificaciones.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rBcalificaciones.Name = "rBcalificaciones";
            this.rBcalificaciones.Size = new System.Drawing.Size(90, 17);
            this.rBcalificaciones.TabIndex = 9;
            this.rBcalificaciones.TabStop = true;
            this.rBcalificaciones.Text = "Calificaciones";
            this.rBcalificaciones.UseVisualStyleBackColor = true;
            // 
            // dGV
            // 
            this.dGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV.Location = new System.Drawing.Point(12, 59);
            this.dGV.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dGV.Name = "dGV";
            this.dGV.RowTemplate.Height = 24;
            this.dGV.Size = new System.Drawing.Size(408, 195);
            this.dGV.TabIndex = 10;
            this.dGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnaceptar
            // 
            this.btnaceptar.Location = new System.Drawing.Point(455, 196);
            this.btnaceptar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnaceptar.Name = "btnaceptar";
            this.btnaceptar.Size = new System.Drawing.Size(97, 32);
            this.btnaceptar.TabIndex = 11;
            this.btnaceptar.Text = "Aceptar";
            this.btnaceptar.UseVisualStyleBackColor = true;
            this.btnaceptar.Click += new System.EventHandler(this.btnaceptar_Click);
            // 
            // rBbuscar
            // 
            this.rBbuscar.AutoSize = true;
            this.rBbuscar.Location = new System.Drawing.Point(5, 27);
            this.rBbuscar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rBbuscar.Name = "rBbuscar";
            this.rBbuscar.Size = new System.Drawing.Size(58, 17);
            this.rBbuscar.TabIndex = 12;
            this.rBbuscar.TabStop = true;
            this.rBbuscar.Text = "Buscar";
            this.rBbuscar.UseVisualStyleBackColor = true;
            this.rBbuscar.CheckedChanged += new System.EventHandler(this.rBbuscar_CheckedChanged_1);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rBbuscar);
            this.groupBox1.Controls.Add(this.rBagregar);
            this.groupBox1.Controls.Add(this.rBeliminar);
            this.groupBox1.Controls.Add(this.rBcalificaciones);
            this.groupBox1.Location = new System.Drawing.Point(436, 59);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(132, 120);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Opciones :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 270);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnaceptar);
            this.Controls.Add(this.dGV);
            this.Controls.Add(this.textnombre);
            this.Controls.Add(this.textsemestre);
            this.Controls.Add(this.tB1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Alumnos ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.dGV)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tB1;
        private System.Windows.Forms.TextBox textsemestre;
        private System.Windows.Forms.TextBox textnombre;
        private System.Windows.Forms.RadioButton rBagregar;
        private System.Windows.Forms.RadioButton rBeliminar;
        private System.Windows.Forms.RadioButton rBcalificaciones;
        private System.Windows.Forms.DataGridView dGV;
        private System.Windows.Forms.Button btnaceptar;
        private System.Windows.Forms.RadioButton rBbuscar;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

