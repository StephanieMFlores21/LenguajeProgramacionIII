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
    public partial class FrmArreglos : Form
    {
        public FrmArreglos()
        {
            InitializeComponent();
        }

        private void ejecutarbutton_Click(object sender, EventArgs e)
        {
            //FORMA N° 1 DE INICIALIZAR
            int[] edades = new int[5];

            edades[0] = 10;
            edades[1] = 20;
            edades[2] = 30;
            edades[3] = 40;
            edades[4] = 50;

            //FORMA N° 2
            string[] paises = new string[5] {"Honduras", "Costa Rica", "Guatemala", "El Salvador", "Nicaragua"};

            for (int i = 0; i < edades.Length; i++)
            {
                ArregloslistBox.Items.Add(edades[i]);
            }

            foreach (var item in paises)
            {
                PaiseslistBox.Items.Add(item);
            }
        }
    }
}
