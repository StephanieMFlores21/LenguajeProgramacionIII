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
    public partial class FrmMatrices : Form
    {
        public FrmMatrices()
        {
            InitializeComponent();
        }

        private void Consultarbutton_Click(object sender, EventArgs e)
        {
            //int[,] matrizUno = new int[2, 3] { { 5, 6, 7},
            //                                  { 7, 9, 4}};

            int[,] matrizEjemplo = new int[5, 5];

            //matrizEjemplo[0, 0] = 5;
            //matrizEjemplo[0, 1] = 6;

            for (int filas = 0; filas < matrizEjemplo.GetLength(0); filas++)
            {
                for (int col = 0; col < matrizEjemplo.GetLength(1); col++)
                {
                    matrizEjemplo[filas, col] = 5 * filas + col;
                }
            }

            for (int filas = 0; filas < matrizEjemplo.GetLength(0); filas++)
            {
                for (int col = 0; col < matrizEjemplo.GetLength(1); col++)
                {
                    MessageBox.Show("La posicion es: " + filas + ", " + col + " = " + matrizEjemplo[filas, col].ToString());
                }
            }

        }
    }
}
