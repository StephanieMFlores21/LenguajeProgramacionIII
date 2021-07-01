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
    }
}
