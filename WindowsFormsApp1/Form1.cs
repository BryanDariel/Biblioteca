using LiteDB;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static WindowsFormsApp1.Biblioteca;

namespace WindowsFormsApp1
{
    public partial class Biblioteca : Form
    {
        List <Estudiante> Estudiantes = new List<Estudiante>();
        public Biblioteca()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Abre la base de datos (o la crea, si no existe)
            using (var db = new LiteDatabase(@"C:\litedb\Biblioteca.db"))
            {
                // Consigue una coleccion (o la crea, si no existe)
                var col = db.GetCollection<Estudiante>("Estudiantes");

                // Crea una nueva instancia
                var estudiante1 = new Estudiante
                {
                    Nombre = "Bryan Rondon",
                    Matricula = "2020-0368",
                    Telefono = "809-523-1784",
                    Id_Libro1 = 3,
                    Id_Libro2 = 0,
                    Id_Libro3 = 0,
                    Activo = true,

                };

                // Inserta la nueva clase (El ID se va a autoincrementar)
                col.Insert(estudiante1);

                //Teoricamente, con el Insert de arriba ya deberia ser suficiente
                col.Update(estudiante1);
            }

            using (var db = new LiteDatabase(@"C:\litedb\Biblioteca.db"))
            {
                var col = db.GetCollection<Libro>("Libros");

                var libro1 = new Libro
                {

                    Titulo = "Programacion Orientada a Objeto",
                    ID_Libro = 3,
                    Categoria = "Programacion",
                    Prestado = true,
                    Activo = true,
                };

                col.Insert(libro1);

                col.Update(libro1);
            }

            using (var db = new LiteDatabase(@"C:\litedb\Biblioteca.db"))
            {
                var col = db.GetCollection<Historico>("Historicos");

                DateTime dias30 = new DateTime();
                dias30 = DateTime.Now;

                var historico = new Historico
                {

                    ID_Estudiante = "2022-0368",
                    ID_Libro = 3,
                    FechaInicio = DateTime.Now,
                    FechaDevolucion = dias30.AddDays(30),
                };

                col.Insert(historico);

                col.Update(historico);
            }
        }

        private void btnAgregarEstudiante_Click(object sender, EventArgs e)
        {

            ValidarCamposAsignacion();
        }
        private void ValidarCamposAsignacion()
        {

            //ErrorProvider de Estudiante
            if (txtEstudiante.Text == "")
            {
                errorProvider1.SetError(txtEstudiante, "Debe ingresar el nombre del estudiante.");
                txtEstudiante.Focus();
                return;
            }
            errorProvider1.SetError(txtEstudiante, "");

            //ErrorProvider de Matricula
            if (txtMatricula.Text == "")
            {
                errorProvider1.SetError(txtMatricula, "Debe ingresar la matricula del estudiante.");
                txtMatricula.Focus();
                return;
            }
            errorProvider1.SetError(txtMatricula, "");

            //ErrorProvider de Telefono
            if (txtTel.Text == "")
            {
                errorProvider1.SetError(txtTel, "Debe ingresar el telefono del estudiante o un familiar.");
                txtTel.Focus();
                return;
            }
            errorProvider1.SetError(txtTel, "");

            int Libro1;
            if(!int.TryParse(txtLibro1.Text, out Libro1))
            {
                errorProvider1.SetError(txtLibro1, "Debe ingresar el ID del libro.");
                txtLibro1.Focus();
                return;
            }
            errorProvider1.SetError(txtLibro1, "");

            int Libro2;
            if (!int.TryParse(txtLibro2.Text, out Libro2))
            {
                errorProvider1.SetError(txtLibro2, "Debe ingresar el ID del libro.");
                txtLibro2.Focus();
                return;
            }
            errorProvider1.SetError(txtLibro2, "");

            int Libro3;
            if (!int.TryParse(txtLibro3.Text, out Libro3))
            {
                errorProvider1.SetError(txtLibro3, "Debe ingresar el ID del libro.");
                txtLibro3.Focus();
                return;
            }
            errorProvider1.SetError(txtLibro3, "");

            Estudiante miEstudiante = new Estudiante();
            miEstudiante.Matricula = txtMatricula.Text;
            miEstudiante.Nombre = txtEstudiante.Text;
            miEstudiante.Telefono = txtTel.Text;
            miEstudiante.Id_Libro1 = Libro1;
            miEstudiante.Id_Libro2 = Libro2;
            miEstudiante.Id_Libro3 = Libro3;
            Estudiantes.Add(miEstudiante);

            dgvAsignacion.DataSource = null;
            dgvAsignacion.DataSource = Estudiantes;

            txtEstudiante.Clear();
            txtTel.Clear();
            txtLibro1.Clear();
            txtLibro2.Clear();
            txtLibro3.Clear();

            return;
        }

        private void btnAgregarLibro_Click(object sender, EventArgs e)
        {
            ValidarCamposAlmacen();
        }

        private bool ValidarCamposAlmacen()
        {
            //ErrorProvider de ID_Libro
            int ID_Libro1;
            if (!int.TryParse(txtID_LibroAlmacen.Text, out ID_Libro1))
            {
                errorProvider1.SetError(txtID_LibroAlmacen, "Debe ingresar el ID del libro.");
                txtID_LibroAlmacen.Focus();
                return false;
            }
            errorProvider1.SetError(txtID_LibroAlmacen, "");

            //ErrorProvider de TituloLibro
            if (txtTituloLibro.Text == "")
            {
                errorProvider1.SetError(txtTituloLibro, "Debe ingresar el titulo del libro.");
                txtTituloLibro.Focus();
                return false;
            }
            errorProvider1.SetError(txtTituloLibro, "");

            //ErrorProvider de CategoriaLibro
            if (txtCategoriaLibro.Text == "")
            {
                errorProvider1.SetError(txtCategoriaLibro, "Debe ingresar la categoria del libro.");
                txtCategoriaLibro.Focus();
                return false;
            }
            errorProvider1.SetError(txtCategoriaLibro, "");

            return true;
        }

    }
}
