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

        private void Ordenarbutton_Click(object sender, EventArgs e)
        {
            //ORDENAR EL ARREGLO
            int[] valores = {3, 5, 1, 6, 9, 10, 15, 2};

            //CLASE ARRAY, FUNCION SORT: SIVER PARA ORDENAR INTERNAMENTE
            //ORDENAR MAYOR A MENOR
            Array.Sort(valores);

            //REVIERTE LOS VALORES (Menor a mayor)
            Array.Reverse(valores);

            //foreach (var item in valores)
            //{
            //    OrdenarlistBox.Items.Add(item);
            //}

            //Mayor a menor
            //valores = valores.OrderByDescending(c => c).ToArray();

            foreach (var item in valores)
            {
                OrdenarlistBox.Items.Add(item);
            }
        }

        private void MaxMinbutton_Click(object sender, EventArgs e)
        {
            int[] valores = { 3, 5, 1, 6, 9, 10, 15, 2 };

            //FORMA N° 1 IDENTIFICAR LOS VALORES
            //int maximo = valores[0];
            //int minimo = valores[0];

            //for (int i = 1; i < valores.Length; i++)
            //{
            //    //VALOR MAXIMO
            //    if (valores [i] > maximo)
            //    {
            //        maximo = valores[i];
            //    }

            //    //VALOR MINIMO
            //    if (valores [i] < minimo)
            //    {
            //        minimo = valores[i];
            //    }
            //}

            //FORMA N° 2 IDENTIFICANDO LOS VALORES MAX Y MIN
            Array.Sort(valores);

            int maximo = valores[valores.Length - 1];
            int minimo = valores[0];

            MessageBox.Show("Valor Maximo: " + maximo + " / Valor Minimo:" + minimo);
        }
    }
}
