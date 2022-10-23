using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjercicioArreglos2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPrecios_Click(object sender, EventArgs e)
        {
            int[] precios;


            //crear en memoria
            precios = new int[8];
            double acumulado = 0;

            for (int i = 0; i < precios.Length; i++)
            {
                int numero = Convert.ToInt32(Interaction.InputBox("Ingrese precios: "));
                precios[i] = numero;
                acumulado = acumulado + numero;
            }

            MessageBox.Show("La suma total de precios ingresados es: " + acumulado);

        }
    }
}
