using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio1Arreglo_IVANKOLARIK
{
    public partial class Form1 : Form
    {

        public struct DatoAlumno
        {
            public string Nota1;
            public string Nota2;
            public string Nota3;
            public string Nombre;
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void btnVerNotas_Click(object sender, EventArgs e)
        {
            notas();
        }
        private void btnPromedio_Click_1(object sender, EventArgs e)
        {
            primerAlumno();
        }

        private void btn_VerNotas2_Click(object sender, EventArgs e)
        {
            segundoAlumno();
        }
        private void btn_VerNotas3_Click(object sender, EventArgs e)
        {
            tercerAlumno();
        }

        private void btn_VerNotas4_Click(object sender, EventArgs e)
        {
            cuartoAlumno();
        }

      






        #region metodos

        private void primerAlumno()
        {
            DatoAlumno Alumno1;

            Alumno1.Nombre = txtNombre1.Text;
            Alumno1.Nota1 = txtNota1.Text;
            Decimal primerNota = Convert.ToDecimal(Alumno1.Nota1);
            Alumno1.Nota2 = txtNota2.Text;
            Decimal segundaNota = Convert.ToDecimal(Alumno1.Nota2);
            Alumno1.Nota3 = txtNota3.Text;
            Decimal tercerNota = Convert.ToDecimal(Alumno1.Nota3);

            if (primerNota > segundaNota && primerNota > tercerNota && primerNota < 4)
            {
                MessageBox.Show("Su nota mayor es: " + primerNota + " DEBE IR AL RECUPERATORIO" + "." + "Su promedio de notas es de: " + " " + (primerNota + segundaNota + tercerNota) / 3);
            }
            else if (segundaNota > tercerNota && segundaNota > primerNota && segundaNota < 4)
            {
                MessageBox.Show("Su nota mayor es: " + segundaNota + " DEBE IR AL RECUPERATORIO" + "." + "Su promedio de notas es de: " + " " + (primerNota + segundaNota + tercerNota) / 3);
            }
            else if (tercerNota > segundaNota && tercerNota > primerNota && tercerNota < 4)
            {
                MessageBox.Show("Su nota mayor es: " + tercerNota + " DEBE IR AL RECUPERATORIO" + "." + "Su promedio de notas es de: " + " " + (primerNota + segundaNota + tercerNota) / 3);
            }
            else if (primerNota > segundaNota && primerNota > tercerNota && primerNota >= 4 && primerNota < 7)
            {
                MessageBox.Show("Su nota mayor es: " + primerNota + " BIEN" + "." + "Su promedio de notas es de: " + " " + (primerNota + segundaNota + tercerNota) / 3);
            }
            else if (segundaNota > tercerNota && segundaNota > primerNota && segundaNota >= 4 && segundaNota < 7)
            {
                MessageBox.Show("Su nota mayor es: " + segundaNota + " BIEN" + "." + "Su promedio de notas es de: " + " " + (primerNota + segundaNota + tercerNota) / 3);
            }
            else if (tercerNota > segundaNota && tercerNota > primerNota && tercerNota >= 4 && tercerNota < 7)
            {
                MessageBox.Show("Su nota mayor es: " + tercerNota + "  BIEN" + "." + "Su promedio de notas es de: " + " " + (primerNota + segundaNota + tercerNota) / 3);
            }
            else if (primerNota > segundaNota && primerNota > tercerNota && primerNota > 7)
            {
                MessageBox.Show("Su nota mayor es: " + primerNota + " MUY BIEN" + "." + "Su promedio de notas es de: " + " " + (primerNota + segundaNota + tercerNota) / 3);
            }
            else if (segundaNota > tercerNota && segundaNota > primerNota && segundaNota > 7)
            {
                MessageBox.Show("Su nota mayor es: " + segundaNota + " MUY BIEN" + "." + "Su promedio de notas es de: " + " " + (primerNota + segundaNota + tercerNota) / 3);
            }
            else
            {
                MessageBox.Show("Su nota mayor es: " + tercerNota + "  MUY BIEN" + "." + "Su promedio de notas es de: " + " " + (primerNota + segundaNota + tercerNota) / 3);
            }

        }


        private void segundoAlumno()
        {
            DatoAlumno Alumno2;

            Alumno2.Nombre = txtNombre2.Text;
            Alumno2.Nota1 = txtNota4.Text;
            Decimal primerNota = Convert.ToDecimal(Alumno2.Nota1);
            Alumno2.Nota2 = txtNota5.Text;
            Decimal segundaNota = Convert.ToDecimal(Alumno2.Nota2);
            Alumno2.Nota3 = txtNota6.Text;
            Decimal tercerNota = Convert.ToDecimal(Alumno2.Nota3);

            if (primerNota > segundaNota && primerNota > tercerNota && primerNota < 4)
            {
                MessageBox.Show("Su nota mayor es: " + primerNota + " DEBE IR AL RECUPERATORIO" + "." + "Su promedio de notas es de: " + " " + (primerNota + segundaNota + tercerNota) / 3);
            }
            else if (segundaNota > tercerNota && segundaNota > primerNota && segundaNota < 4)
            {
                MessageBox.Show("Su nota mayor es: " + segundaNota + " DEBE IR AL RECUPERATORIO" + "." + "Su promedio de notas es de: " + " " + (primerNota + segundaNota + tercerNota) / 3);
            }
            else if (tercerNota > segundaNota && tercerNota > primerNota && tercerNota < 4)
            {
                MessageBox.Show("Su nota mayor es: " + tercerNota + " DEBE IR AL RECUPERATORIO" + "." + "Su promedio de notas es de: " + " " + (primerNota + segundaNota + tercerNota) / 3);
            }
            else if (primerNota > segundaNota && primerNota > tercerNota && primerNota >= 4 && primerNota < 7)
            {
                MessageBox.Show("Su nota mayor es: " + primerNota + " BIEN" + "." + "Su promedio de notas es de: " + " " + (primerNota + segundaNota + tercerNota) / 3);
            }
            else if (segundaNota > tercerNota && segundaNota > primerNota && segundaNota >= 4 && segundaNota < 7)
            {
                MessageBox.Show("Su nota mayor es: " + segundaNota + " BIEN" + "." + "Su promedio de notas es de: " + " " + (primerNota + segundaNota + tercerNota) / 3);
            }
            else if (tercerNota > segundaNota && tercerNota > primerNota && tercerNota >= 4 && tercerNota < 7)
            {
                MessageBox.Show("Su nota mayor es: " + tercerNota + "  BIEN" + "." + "Su promedio de notas es de: " + " " + +(primerNota + segundaNota + tercerNota) / 3);
            }
            else if (primerNota > segundaNota && primerNota > tercerNota && primerNota > 7)
            {
                MessageBox.Show("Su nota mayor es: " + primerNota + " MUY BIEN" + "." + "Su promedio de notas es de: " + " " + (primerNota + segundaNota + tercerNota) / 3);
            }
            else if (segundaNota > tercerNota && segundaNota > primerNota && segundaNota > 7)
            {
                MessageBox.Show("Su nota mayor es: " + segundaNota + " MUY BIEN" + "." + "Su promedio de notas es de: " + " " + (primerNota + segundaNota + tercerNota) / 3);
            }
            else
            {
                MessageBox.Show("Su nota mayor es: " + tercerNota + "  MUY BIEN" + "." + "Su promedio de notas es de: " + " " + (primerNota + segundaNota + tercerNota) / 3);
            }
        }

        private void tercerAlumno()
        {
            DatoAlumno Alumno3;

            Alumno3.Nombre = txtNombre2.Text;
            Alumno3.Nota1 = txtNota7.Text;
            Decimal primerNota = Convert.ToDecimal(Alumno3.Nota1);
            Alumno3.Nota2 = txtNota8.Text;
            Decimal segundaNota = Convert.ToDecimal(Alumno3.Nota2);
            Alumno3.Nota3 = txtNota9.Text;
            Decimal tercerNota = Convert.ToDecimal(Alumno3.Nota3);

            if (primerNota > segundaNota && primerNota > tercerNota && primerNota < 4)
            {
                MessageBox.Show("Su nota mayor es: " + primerNota + " DEBE IR AL RECUPERATORIO" + "." + "Su promedio de notas es de: " + " " + (primerNota + segundaNota + tercerNota) / 3);
            }
            else if (segundaNota > tercerNota && segundaNota > primerNota && segundaNota < 4)
            {
                MessageBox.Show("Su nota mayor es: " + segundaNota + " DEBE IR AL RECUPERATORIO" + "." + "Su promedio de notas es de: " + " " + (primerNota + segundaNota + tercerNota) / 3);
            }
            else if (tercerNota > segundaNota && tercerNota > primerNota && tercerNota < 4)
            {
                MessageBox.Show("Su nota mayor es: " + tercerNota + " DEBE IR AL RECUPERATORIO" + "." + "Su promedio de notas es de: " + " " + (primerNota + segundaNota + tercerNota) / 3);
            }
            else if (primerNota > segundaNota && primerNota > tercerNota && primerNota >= 4 && primerNota < 7)
            {
                MessageBox.Show("Su nota mayor es: " + primerNota + " BIEN" + "." + "Su promedio de notas es de: " + " " + (primerNota + segundaNota + tercerNota) / 3);
            }
            else if (segundaNota > tercerNota && segundaNota > primerNota && segundaNota >= 4 && segundaNota < 7)
            {
                MessageBox.Show("Su nota mayor es: " + segundaNota + " BIEN" + "." + "Su promedio de notas es de: " + " " + (primerNota + segundaNota + tercerNota) / 3);
            }
            else if (tercerNota > segundaNota && tercerNota > primerNota && tercerNota >= 4 && tercerNota < 7)
            {
                MessageBox.Show("Su nota mayor es: " + tercerNota + "  BIEN" + "." + "Su promedio de notas es de: " + " " + (primerNota + segundaNota + tercerNota) / 3);
            }
            else if (primerNota > segundaNota && primerNota > tercerNota && primerNota > 7)
            {
                MessageBox.Show("Su nota mayor es: " + primerNota + " MUY BIEN" + "." + "Su promedio de notas es de: " + " " + (primerNota + segundaNota + tercerNota) / 3);
            }
            else if (segundaNota > tercerNota && segundaNota > primerNota && segundaNota > 7)
            {
                MessageBox.Show("Su nota mayor es: " + segundaNota + " MUY BIEN" + "." + "Su promedio de notas es de: " + " " + (primerNota + segundaNota + tercerNota) / 3);
            }
            else
            {
                MessageBox.Show("Su nota mayor es: " + tercerNota + "  MUY BIEN" + "." + "Su promedio de notas es de: " + " " + (primerNota + segundaNota + tercerNota) / 3);
            }
        }

        private void cuartoAlumno()
        {
            DatoAlumno Alumno4;

            Alumno4.Nombre = txtNombre2.Text;
            Alumno4.Nota1 = txtNota10.Text;
            Decimal primerNota = Convert.ToDecimal(Alumno4.Nota1);
            Alumno4.Nota2 = txtNota11.Text;
            Decimal segundaNota = Convert.ToDecimal(Alumno4.Nota2);
            Alumno4.Nota3 = txtNota12.Text;
            Decimal tercerNota = Convert.ToDecimal(Alumno4.Nota3);

            if (primerNota > segundaNota && primerNota > tercerNota && primerNota < 4)
            {
                MessageBox.Show("Su nota mayor es: " + primerNota + " DEBE IR AL RECUPERATORIO" + "." + "Su promedio de notas es de: " + " " + (primerNota + segundaNota + tercerNota) / 3);
            }
            else if (segundaNota > tercerNota && segundaNota > primerNota && segundaNota < 4)
            {
                MessageBox.Show("Su nota mayor es: " + segundaNota + " DEBE IR AL RECUPERATORIO" + "." + "Su promedio de notas es de: " + " " + (primerNota + segundaNota + tercerNota) / 3);
            }
            else if (tercerNota > segundaNota && tercerNota > primerNota && tercerNota < 4)
            {
                MessageBox.Show("Su nota mayor es: " + tercerNota + " DEBE IR AL RECUPERATORIO" + "." + "Su promedio de notas es de: " + " " + (primerNota + segundaNota + tercerNota) / 3);
            }
            else if (primerNota > segundaNota && primerNota > tercerNota && primerNota >= 4 && primerNota < 7)
            {
                MessageBox.Show("Su nota mayor es: " + primerNota + " BIEN" + "." + "Su promedio de notas es de: " + " " + (primerNota + segundaNota + tercerNota) / 3);
            }
            else if (segundaNota > tercerNota && segundaNota > primerNota && segundaNota >= 4 && segundaNota < 7)
            {
                MessageBox.Show("Su nota mayor es: " + segundaNota + " BIEN" + "." + "Su promedio de notas es de: " + " " + (primerNota + segundaNota + tercerNota) / 3);
            }
            else if (tercerNota > segundaNota && tercerNota > primerNota && tercerNota >= 4 && tercerNota < 7)
            {
                MessageBox.Show("Su nota mayor es: " + tercerNota + "  BIEN" + "." + "Su promedio de notas es de: " + " " + (primerNota + segundaNota + tercerNota) / 3);
            }
            else if (primerNota > segundaNota && primerNota > tercerNota && primerNota > 7)
            {
                MessageBox.Show("Su nota mayor es: " + primerNota + " MUY BIEN" + "." + "Su promedio de notas es de: " + " " + (primerNota + segundaNota + tercerNota) / 3);
            }
            else if (segundaNota > tercerNota && segundaNota > primerNota && segundaNota > 7)
            {
                MessageBox.Show("Su nota mayor es: " + segundaNota + " MUY BIEN" + "." + "Su promedio de notas es de: " + " " + (primerNota + segundaNota + tercerNota) / 3);
            }
            else
            {
                MessageBox.Show("Su nota mayor es: " + tercerNota + "  MUY BIEN" + "." + "Su promedio de notas es de: " + " " + (primerNota + segundaNota + tercerNota) / 3);
            }
        }

        private void notas()
        {
            DatoAlumno Alumno1;
            DatoAlumno Alumno2;
            DatoAlumno Alumno3;
            DatoAlumno Alumno4;


            Alumno1.Nombre = txtNombre1.Text;
            Alumno1.Nota1 = txtNota1.Text;
            Alumno1.Nota2 = txtNota2.Text;
            Alumno1.Nota3 = txtNota3.Text;

            Alumno2.Nombre = txtNombre2.Text;
            Alumno2.Nota1 = txtNota4.Text;
            Alumno2.Nota2 = txtNota5.Text;
            Alumno2.Nota3 = txtNota6.Text;

            Alumno3.Nombre = txtNombre3.Text;
            Alumno3.Nota1 = txtNota7.Text;
            Alumno3.Nota2 = txtNota8.Text;
            Alumno3.Nota3 = txtNota9.Text;

            Alumno4.Nombre = txtNombre4.Text;
            Alumno4.Nota1 = txtNota10.Text;
            Alumno4.Nota1 = txtNota11.Text;
            Alumno4.Nota1 = txtNota12.Text;


            MessageBox.Show("Las notas de :" + " " + Alumno1.Nombre + " " + "es de :" + " " + Alumno1.Nota1 + " ," + Alumno1.Nota2 + " ," + Alumno1.Nota3 + "." + " " + " Las notas de: " + " " + Alumno2.Nombre + " " + "es de: " + " " + Alumno2.Nota1 + " ," + Alumno2.Nota2 + " ," + Alumno2.Nota3 + "." + " " + " Las notas de: " + " " + Alumno3.Nombre + " " + "es de: " + " " + Alumno3.Nota1 + " ," + Alumno3.Nota2 + " ," + Alumno3.Nota3 + "." + " " + " Las notas de: " + " " + Alumno4.Nombre + " " + "es de: " + " " + Alumno2.Nota1 + " ," + Alumno2.Nota2 + " ," + Alumno2.Nota2);

        }









        #endregion

   
    }
}

    

