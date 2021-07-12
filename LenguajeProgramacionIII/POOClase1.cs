using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LenguajeProgramacionIII
{
    public partial class POOClase1 : Form
    {
        public POOClase1()
        {
            InitializeComponent();
        }

        //CREACION DE UNA LISTA QUE SE CARGARÁ EN EL DATAGRIPVIEW
        List<Persona> personaLista = new List<Persona>();


        private void Ejecutarbutton1_Click(object sender, EventArgs e)
        {
            //FORMA 1 CONSTRUCTOR
            //Persona Juan = new Persona();

            //Juan.Nombre = NombretextBox.Text;
            //Juan.Apellido = ApellidotextBox.Text;
            //Juan.Edad = Convert.ToInt32 (EdadtextBox.Text);
            //Juan.Direccion = DirecciontextBox.Text;

            //VISUALIZACION DATOS
            //MessageBox.Show(Juan.DevolverNombreCompleto());
            //MessageBox.Show(Juan.MostrarEdad());
            //MessageBox.Show(Juan.MostrarDireccion());


            //FORMA 2 CONSTRUCTOR
            Persona Maria = new Persona(NombretextBox.Text, ApellidotextBox.Text, Convert.ToInt32(EdadtextBox.Text), DirecciontextBox.Text);

            MessageBox.Show(Maria.DevolverNombreCompleto());
            //MessageBox.Show(Maria.MostrarEdad(MostrarEdad());
            MessageBox.Show(Maria.MostrarDireccion());

        }

        private void Listasbutton_Click(object sender, EventArgs e)
        {   
            //CREACION DE LISTA "PERSONA"
            List<string> personas = new List<string>();

            personas.Add("Carlos");
            personas.Add("Mariela");
            personas.Add("Heylin");

            foreach (var item in personas )
            {
                MessageBox.Show(item);
            }

        }

        private void Agregarbutton_Click(object sender, EventArgs e)
        {
            Persona persona = new Persona(NombretextBox.Text, ApellidotextBox.Text, Convert.ToInt32(EdadtextBox.Text), DirecciontextBox.Text);

            personaLista.Add(persona);

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = personaLista;

            //LIMPIEZA DE CONTROLES
            NombretextBox.Clear();
            ApellidotextBox.Clear();
            EdadtextBox.Clear();
            DirecciontextBox.Clear();

        }

        //MAYOR DE EDAD (LINQ) 
        private void MayorEdadbutton_Click(object sender, EventArgs e)
        {
            var listaTmeporal = personaLista.Where(a => a.Edad >= 18).ToList();

            //MOSTRARÁ LOS NOMBRE DE LAS PERSONAS MAYORES DE EDAD
            foreach (var item in listaTmeporal)
            {
                MayorEdadcomboBox.Items.Add(item.Nombre);
            }
        }
    }
}
