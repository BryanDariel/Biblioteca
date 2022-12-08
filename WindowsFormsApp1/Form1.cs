using LiteDB;
using System;
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
                    Telefono = new string[] { "809-523-1784" },
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

        private void btnModificarEstudiante_Click(object sender, EventArgs e)
        {

        }
    }
}
