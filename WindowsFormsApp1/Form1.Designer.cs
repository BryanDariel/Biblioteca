namespace WindowsFormsApp1
{
    partial class Biblioteca
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
            this.tc1 = new System.Windows.Forms.TabControl();
            this.tabAsignacion = new System.Windows.Forms.TabPage();
            this.btnModificarEstudiante = new System.Windows.Forms.Button();
            this.btnBuscarEstudiante = new System.Windows.Forms.Button();
            this.btnAgregarEstudiante = new System.Windows.Forms.Button();
            this.dgvAsignacion = new System.Windows.Forms.DataGridView();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.lbTel = new System.Windows.Forms.Label();
            this.txtLibro3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.txtLibro1 = new System.Windows.Forms.TextBox();
            this.txtMatricula = new System.Windows.Forms.TextBox();
            this.txtEstudiante = new System.Windows.Forms.TextBox();
            this.lbLibro3 = new System.Windows.Forms.Label();
            this.lbLibro2 = new System.Windows.Forms.Label();
            this.lbLibro1 = new System.Windows.Forms.Label();
            this.lbMatricula = new System.Windows.Forms.Label();
            this.lbEstudiante = new System.Windows.Forms.Label();
            this.tpAlmacen = new System.Windows.Forms.TabPage();
            this.dgvAlmacen = new System.Windows.Forms.DataGridView();
            this.btnBuscarLibro = new System.Windows.Forms.Button();
            this.btnAgregarLibro = new System.Windows.Forms.Button();
            this.txtCategoriaLibro = new System.Windows.Forms.TextBox();
            this.lbCategoriaLibro = new System.Windows.Forms.Label();
            this.txtTituloLibro = new System.Windows.Forms.TextBox();
            this.lbTituloLibro = new System.Windows.Forms.Label();
            this.txtID_LibroAlmacen = new System.Windows.Forms.TextBox();
            this.lbID_LibroAlmacen = new System.Windows.Forms.Label();
            this.tbHistorico = new System.Windows.Forms.TabPage();
            this.btnBuscarHistorico = new System.Windows.Forms.Button();
            this.dgvHistorico = new System.Windows.Forms.DataGridView();
            this.txtID_Libro = new System.Windows.Forms.TextBox();
            this.txtID_Estudiante = new System.Windows.Forms.TextBox();
            this.lbID_LibroHistorico = new System.Windows.Forms.Label();
            this.lbMatricula_EstudianteHistorico = new System.Windows.Forms.Label();
            this.btnModificarLibro = new System.Windows.Forms.Button();
            this.tc1.SuspendLayout();
            this.tabAsignacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAsignacion)).BeginInit();
            this.tpAlmacen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlmacen)).BeginInit();
            this.tbHistorico.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorico)).BeginInit();
            this.SuspendLayout();
            // 
            // tc1
            // 
            this.tc1.Controls.Add(this.tabAsignacion);
            this.tc1.Controls.Add(this.tpAlmacen);
            this.tc1.Controls.Add(this.tbHistorico);
            this.tc1.Location = new System.Drawing.Point(1, 1);
            this.tc1.Name = "tc1";
            this.tc1.SelectedIndex = 0;
            this.tc1.Size = new System.Drawing.Size(773, 522);
            this.tc1.TabIndex = 0;
            // 
            // tabAsignacion
            // 
            this.tabAsignacion.Controls.Add(this.btnModificarEstudiante);
            this.tabAsignacion.Controls.Add(this.btnBuscarEstudiante);
            this.tabAsignacion.Controls.Add(this.btnAgregarEstudiante);
            this.tabAsignacion.Controls.Add(this.dgvAsignacion);
            this.tabAsignacion.Controls.Add(this.txtTel);
            this.tabAsignacion.Controls.Add(this.lbTel);
            this.tabAsignacion.Controls.Add(this.txtLibro3);
            this.tabAsignacion.Controls.Add(this.textBox4);
            this.tabAsignacion.Controls.Add(this.txtLibro1);
            this.tabAsignacion.Controls.Add(this.txtMatricula);
            this.tabAsignacion.Controls.Add(this.txtEstudiante);
            this.tabAsignacion.Controls.Add(this.lbLibro3);
            this.tabAsignacion.Controls.Add(this.lbLibro2);
            this.tabAsignacion.Controls.Add(this.lbLibro1);
            this.tabAsignacion.Controls.Add(this.lbMatricula);
            this.tabAsignacion.Controls.Add(this.lbEstudiante);
            this.tabAsignacion.Location = new System.Drawing.Point(4, 22);
            this.tabAsignacion.Name = "tabAsignacion";
            this.tabAsignacion.Padding = new System.Windows.Forms.Padding(3);
            this.tabAsignacion.Size = new System.Drawing.Size(765, 496);
            this.tabAsignacion.TabIndex = 0;
            this.tabAsignacion.Text = "Asignación";
            this.tabAsignacion.UseVisualStyleBackColor = true;
            // 
            // btnModificarEstudiante
            // 
            this.btnModificarEstudiante.Location = new System.Drawing.Point(381, 64);
            this.btnModificarEstudiante.Name = "btnModificarEstudiante";
            this.btnModificarEstudiante.Size = new System.Drawing.Size(75, 23);
            this.btnModificarEstudiante.TabIndex = 31;
            this.btnModificarEstudiante.Text = "Modificar";
            this.btnModificarEstudiante.UseVisualStyleBackColor = true;
            this.btnModificarEstudiante.Click += new System.EventHandler(this.btnModificarEstudiante_Click);
            // 
            // btnBuscarEstudiante
            // 
            this.btnBuscarEstudiante.Location = new System.Drawing.Point(487, 15);
            this.btnBuscarEstudiante.Name = "btnBuscarEstudiante";
            this.btnBuscarEstudiante.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarEstudiante.TabIndex = 30;
            this.btnBuscarEstudiante.Text = "Buscar";
            this.btnBuscarEstudiante.UseVisualStyleBackColor = true;
            // 
            // btnAgregarEstudiante
            // 
            this.btnAgregarEstudiante.Location = new System.Drawing.Point(381, 15);
            this.btnAgregarEstudiante.Name = "btnAgregarEstudiante";
            this.btnAgregarEstudiante.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarEstudiante.TabIndex = 29;
            this.btnAgregarEstudiante.Text = "Agregar";
            this.btnAgregarEstudiante.UseVisualStyleBackColor = true;
            // 
            // dgvAsignacion
            // 
            this.dgvAsignacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAsignacion.Location = new System.Drawing.Point(12, 205);
            this.dgvAsignacion.Name = "dgvAsignacion";
            this.dgvAsignacion.Size = new System.Drawing.Size(739, 274);
            this.dgvAsignacion.TabIndex = 28;
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(74, 74);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(250, 20);
            this.txtTel.TabIndex = 27;
            // 
            // lbTel
            // 
            this.lbTel.AutoSize = true;
            this.lbTel.Location = new System.Drawing.Point(9, 74);
            this.lbTel.Name = "lbTel";
            this.lbTel.Size = new System.Drawing.Size(49, 13);
            this.lbTel.TabIndex = 26;
            this.lbTel.Text = "Telefono";
            // 
            // txtLibro3
            // 
            this.txtLibro3.Location = new System.Drawing.Point(74, 161);
            this.txtLibro3.Name = "txtLibro3";
            this.txtLibro3.Size = new System.Drawing.Size(250, 20);
            this.txtLibro3.TabIndex = 25;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(73, 130);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(250, 20);
            this.textBox4.TabIndex = 24;
            // 
            // txtLibro1
            // 
            this.txtLibro1.Location = new System.Drawing.Point(74, 102);
            this.txtLibro1.Name = "txtLibro1";
            this.txtLibro1.Size = new System.Drawing.Size(250, 20);
            this.txtLibro1.TabIndex = 23;
            // 
            // txtMatricula
            // 
            this.txtMatricula.Location = new System.Drawing.Point(74, 46);
            this.txtMatricula.Name = "txtMatricula";
            this.txtMatricula.Size = new System.Drawing.Size(250, 20);
            this.txtMatricula.TabIndex = 22;
            // 
            // txtEstudiante
            // 
            this.txtEstudiante.Location = new System.Drawing.Point(73, 15);
            this.txtEstudiante.Name = "txtEstudiante";
            this.txtEstudiante.Size = new System.Drawing.Size(250, 20);
            this.txtEstudiante.TabIndex = 21;
            // 
            // lbLibro3
            // 
            this.lbLibro3.AutoSize = true;
            this.lbLibro3.Location = new System.Drawing.Point(10, 164);
            this.lbLibro3.Name = "lbLibro3";
            this.lbLibro3.Size = new System.Drawing.Size(36, 13);
            this.lbLibro3.TabIndex = 20;
            this.lbLibro3.Text = "Libro3";
            // 
            // lbLibro2
            // 
            this.lbLibro2.AutoSize = true;
            this.lbLibro2.Location = new System.Drawing.Point(9, 130);
            this.lbLibro2.Name = "lbLibro2";
            this.lbLibro2.Size = new System.Drawing.Size(36, 13);
            this.lbLibro2.TabIndex = 19;
            this.lbLibro2.Text = "Libro2";
            // 
            // lbLibro1
            // 
            this.lbLibro1.AutoSize = true;
            this.lbLibro1.Location = new System.Drawing.Point(10, 102);
            this.lbLibro1.Name = "lbLibro1";
            this.lbLibro1.Size = new System.Drawing.Size(36, 13);
            this.lbLibro1.TabIndex = 18;
            this.lbLibro1.Text = "Libro1";
            // 
            // lbMatricula
            // 
            this.lbMatricula.AutoSize = true;
            this.lbMatricula.Location = new System.Drawing.Point(10, 46);
            this.lbMatricula.Name = "lbMatricula";
            this.lbMatricula.Size = new System.Drawing.Size(50, 13);
            this.lbMatricula.TabIndex = 17;
            this.lbMatricula.Text = "Matricula";
            // 
            // lbEstudiante
            // 
            this.lbEstudiante.AutoSize = true;
            this.lbEstudiante.Location = new System.Drawing.Point(9, 15);
            this.lbEstudiante.Name = "lbEstudiante";
            this.lbEstudiante.Size = new System.Drawing.Size(57, 13);
            this.lbEstudiante.TabIndex = 16;
            this.lbEstudiante.Text = "Estudiante";
            // 
            // tpAlmacen
            // 
            this.tpAlmacen.Controls.Add(this.btnModificarLibro);
            this.tpAlmacen.Controls.Add(this.dgvAlmacen);
            this.tpAlmacen.Controls.Add(this.btnBuscarLibro);
            this.tpAlmacen.Controls.Add(this.btnAgregarLibro);
            this.tpAlmacen.Controls.Add(this.txtCategoriaLibro);
            this.tpAlmacen.Controls.Add(this.lbCategoriaLibro);
            this.tpAlmacen.Controls.Add(this.txtTituloLibro);
            this.tpAlmacen.Controls.Add(this.lbTituloLibro);
            this.tpAlmacen.Controls.Add(this.txtID_LibroAlmacen);
            this.tpAlmacen.Controls.Add(this.lbID_LibroAlmacen);
            this.tpAlmacen.Location = new System.Drawing.Point(4, 22);
            this.tpAlmacen.Name = "tpAlmacen";
            this.tpAlmacen.Size = new System.Drawing.Size(765, 496);
            this.tpAlmacen.TabIndex = 2;
            this.tpAlmacen.Text = "Almacen";
            this.tpAlmacen.UseVisualStyleBackColor = true;
            // 
            // dgvAlmacen
            // 
            this.dgvAlmacen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlmacen.Location = new System.Drawing.Point(7, 179);
            this.dgvAlmacen.Name = "dgvAlmacen";
            this.dgvAlmacen.Size = new System.Drawing.Size(743, 302);
            this.dgvAlmacen.TabIndex = 35;
            // 
            // btnBuscarLibro
            // 
            this.btnBuscarLibro.Location = new System.Drawing.Point(487, 20);
            this.btnBuscarLibro.Name = "btnBuscarLibro";
            this.btnBuscarLibro.Size = new System.Drawing.Size(91, 23);
            this.btnBuscarLibro.TabIndex = 34;
            this.btnBuscarLibro.Text = "Buscar";
            this.btnBuscarLibro.UseVisualStyleBackColor = true;
            // 
            // btnAgregarLibro
            // 
            this.btnAgregarLibro.Location = new System.Drawing.Point(371, 18);
            this.btnAgregarLibro.Name = "btnAgregarLibro";
            this.btnAgregarLibro.Size = new System.Drawing.Size(91, 23);
            this.btnAgregarLibro.TabIndex = 33;
            this.btnAgregarLibro.Text = "Agregar";
            this.btnAgregarLibro.UseVisualStyleBackColor = true;
            // 
            // txtCategoriaLibro
            // 
            this.txtCategoriaLibro.Location = new System.Drawing.Point(81, 94);
            this.txtCategoriaLibro.Name = "txtCategoriaLibro";
            this.txtCategoriaLibro.Size = new System.Drawing.Size(250, 20);
            this.txtCategoriaLibro.TabIndex = 32;
            // 
            // lbCategoriaLibro
            // 
            this.lbCategoriaLibro.AutoSize = true;
            this.lbCategoriaLibro.Location = new System.Drawing.Point(4, 94);
            this.lbCategoriaLibro.Name = "lbCategoriaLibro";
            this.lbCategoriaLibro.Size = new System.Drawing.Size(52, 13);
            this.lbCategoriaLibro.TabIndex = 31;
            this.lbCategoriaLibro.Text = "Categoria";
            // 
            // txtTituloLibro
            // 
            this.txtTituloLibro.Location = new System.Drawing.Point(81, 57);
            this.txtTituloLibro.Name = "txtTituloLibro";
            this.txtTituloLibro.Size = new System.Drawing.Size(250, 20);
            this.txtTituloLibro.TabIndex = 30;
            // 
            // lbTituloLibro
            // 
            this.lbTituloLibro.AutoSize = true;
            this.lbTituloLibro.Location = new System.Drawing.Point(4, 57);
            this.lbTituloLibro.Name = "lbTituloLibro";
            this.lbTituloLibro.Size = new System.Drawing.Size(33, 13);
            this.lbTituloLibro.TabIndex = 29;
            this.lbTituloLibro.Text = "Titulo";
            // 
            // txtID_LibroAlmacen
            // 
            this.txtID_LibroAlmacen.Location = new System.Drawing.Point(81, 20);
            this.txtID_LibroAlmacen.Name = "txtID_LibroAlmacen";
            this.txtID_LibroAlmacen.Size = new System.Drawing.Size(250, 20);
            this.txtID_LibroAlmacen.TabIndex = 28;
            // 
            // lbID_LibroAlmacen
            // 
            this.lbID_LibroAlmacen.AutoSize = true;
            this.lbID_LibroAlmacen.Location = new System.Drawing.Point(4, 20);
            this.lbID_LibroAlmacen.Name = "lbID_LibroAlmacen";
            this.lbID_LibroAlmacen.Size = new System.Drawing.Size(44, 13);
            this.lbID_LibroAlmacen.TabIndex = 27;
            this.lbID_LibroAlmacen.Text = "ID Libro";
            // 
            // tbHistorico
            // 
            this.tbHistorico.Controls.Add(this.btnBuscarHistorico);
            this.tbHistorico.Controls.Add(this.dgvHistorico);
            this.tbHistorico.Controls.Add(this.txtID_Libro);
            this.tbHistorico.Controls.Add(this.txtID_Estudiante);
            this.tbHistorico.Controls.Add(this.lbID_LibroHistorico);
            this.tbHistorico.Controls.Add(this.lbMatricula_EstudianteHistorico);
            this.tbHistorico.Location = new System.Drawing.Point(4, 22);
            this.tbHistorico.Name = "tbHistorico";
            this.tbHistorico.Padding = new System.Windows.Forms.Padding(3);
            this.tbHistorico.Size = new System.Drawing.Size(765, 496);
            this.tbHistorico.TabIndex = 1;
            this.tbHistorico.Text = "Historico";
            this.tbHistorico.UseVisualStyleBackColor = true;
            // 
            // btnBuscarHistorico
            // 
            this.btnBuscarHistorico.Location = new System.Drawing.Point(415, 19);
            this.btnBuscarHistorico.Name = "btnBuscarHistorico";
            this.btnBuscarHistorico.Size = new System.Drawing.Size(91, 23);
            this.btnBuscarHistorico.TabIndex = 34;
            this.btnBuscarHistorico.Text = "Buscar";
            this.btnBuscarHistorico.UseVisualStyleBackColor = true;
            // 
            // dgvHistorico
            // 
            this.dgvHistorico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHistorico.Location = new System.Drawing.Point(9, 181);
            this.dgvHistorico.Name = "dgvHistorico";
            this.dgvHistorico.Size = new System.Drawing.Size(743, 298);
            this.dgvHistorico.TabIndex = 27;
            // 
            // txtID_Libro
            // 
            this.txtID_Libro.Location = new System.Drawing.Point(84, 61);
            this.txtID_Libro.Name = "txtID_Libro";
            this.txtID_Libro.Size = new System.Drawing.Size(250, 20);
            this.txtID_Libro.TabIndex = 26;
            // 
            // txtID_Estudiante
            // 
            this.txtID_Estudiante.Location = new System.Drawing.Point(83, 24);
            this.txtID_Estudiante.Name = "txtID_Estudiante";
            this.txtID_Estudiante.Size = new System.Drawing.Size(250, 20);
            this.txtID_Estudiante.TabIndex = 25;
            // 
            // lbID_LibroHistorico
            // 
            this.lbID_LibroHistorico.AutoSize = true;
            this.lbID_LibroHistorico.Location = new System.Drawing.Point(7, 61);
            this.lbID_LibroHistorico.Name = "lbID_LibroHistorico";
            this.lbID_LibroHistorico.Size = new System.Drawing.Size(44, 13);
            this.lbID_LibroHistorico.TabIndex = 24;
            this.lbID_LibroHistorico.Text = "ID Libro";
            // 
            // lbMatricula_EstudianteHistorico
            // 
            this.lbMatricula_EstudianteHistorico.AutoSize = true;
            this.lbMatricula_EstudianteHistorico.Location = new System.Drawing.Point(6, 24);
            this.lbMatricula_EstudianteHistorico.Name = "lbMatricula_EstudianteHistorico";
            this.lbMatricula_EstudianteHistorico.Size = new System.Drawing.Size(50, 13);
            this.lbMatricula_EstudianteHistorico.TabIndex = 23;
            this.lbMatricula_EstudianteHistorico.Text = "Matricula";
            // 
            // btnModificarLibro
            // 
            this.btnModificarLibro.Location = new System.Drawing.Point(371, 57);
            this.btnModificarLibro.Name = "btnModificarLibro";
            this.btnModificarLibro.Size = new System.Drawing.Size(91, 23);
            this.btnModificarLibro.TabIndex = 36;
            this.btnModificarLibro.Text = "Modificar";
            this.btnModificarLibro.UseVisualStyleBackColor = true;
            // 
            // Biblioteca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 522);
            this.Controls.Add(this.tc1);
            this.Name = "Biblioteca";
            this.Text = "Biblioteca";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tc1.ResumeLayout(false);
            this.tabAsignacion.ResumeLayout(false);
            this.tabAsignacion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAsignacion)).EndInit();
            this.tpAlmacen.ResumeLayout(false);
            this.tpAlmacen.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlmacen)).EndInit();
            this.tbHistorico.ResumeLayout(false);
            this.tbHistorico.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorico)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tc1;
        private System.Windows.Forms.TabPage tabAsignacion;
        private System.Windows.Forms.TabPage tbHistorico;
        private System.Windows.Forms.Button btnAgregarEstudiante;
        private System.Windows.Forms.DataGridView dgvAsignacion;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.Label lbTel;
        private System.Windows.Forms.TextBox txtLibro3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox txtLibro1;
        private System.Windows.Forms.TextBox txtMatricula;
        private System.Windows.Forms.TextBox txtEstudiante;
        private System.Windows.Forms.Label lbLibro3;
        private System.Windows.Forms.Label lbLibro2;
        private System.Windows.Forms.Label lbLibro1;
        private System.Windows.Forms.Label lbMatricula;
        private System.Windows.Forms.Label lbEstudiante;
        private System.Windows.Forms.TextBox txtID_Libro;
        private System.Windows.Forms.TextBox txtID_Estudiante;
        private System.Windows.Forms.Label lbID_LibroHistorico;
        private System.Windows.Forms.Label lbMatricula_EstudianteHistorico;
        private System.Windows.Forms.DataGridView dgvHistorico;
        private System.Windows.Forms.Button btnBuscarEstudiante;
        private System.Windows.Forms.TabPage tpAlmacen;
        private System.Windows.Forms.TextBox txtID_LibroAlmacen;
        private System.Windows.Forms.Label lbID_LibroAlmacen;
        private System.Windows.Forms.TextBox txtTituloLibro;
        private System.Windows.Forms.Label lbTituloLibro;
        private System.Windows.Forms.TextBox txtCategoriaLibro;
        private System.Windows.Forms.Label lbCategoriaLibro;
        private System.Windows.Forms.Button btnAgregarLibro;
        private System.Windows.Forms.Button btnBuscarLibro;
        private System.Windows.Forms.DataGridView dgvAlmacen;
        private System.Windows.Forms.Button btnBuscarHistorico;
        private System.Windows.Forms.Button btnModificarEstudiante;
        private System.Windows.Forms.Button btnModificarLibro;
    }
}

