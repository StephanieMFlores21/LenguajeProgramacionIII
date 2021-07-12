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
    public partial class LINQ : Form
    {
        public LINQ()
        {
            InitializeComponent();
        }

        //FORMA 1
        private void Sumabutton_Click(object sender, EventArgs e)
        {
            //CREACION DE lISTA TIPO ENTERO
            List<int> listaDeValores = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            int suma = 0;

            foreach (var item in listaDeValores)
            {
                suma += item;
            }

            MessageBox.Show(suma.ToString());
        }

        //FORMA 2 (LINQ)
        private void SumaLINQbutton_Click(object sender, EventArgs e)
        {
            List<int> listaDeValores = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            int suma = listaDeValores.Sum();

            MessageBox.Show(suma.ToString());
        }

        //FORMA 1
        private void Paresbutton_Click(object sender, EventArgs e)
        {
            List<int> listaDeValores = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            foreach (var item in listaDeValores)
            {
                if (item % 2 == 0)
                {
                    comboBox1.Items.Add(item);
                }
            }
        }

        //FORMA 2 (LINQ)
        private void ParesLINQbutton_Click(object sender, EventArgs e)
        {
            List<int> listaDeValores = new List<int> {1,2,3,4,5,6,7,8,9};

            comboBox1.DataSource = listaDeValores.Where(a => a % 2 == 0).ToList();
        }
    }
}
