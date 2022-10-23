using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace Matriz
{
    class Matriz
    {
        private string[] paises;
        private int[,] tempmen;
        private int[] temptri;
        public void Cargar()
        {
            paises = new String[4];
            tempmen = new int[4, 3];
            for (int f = 0; f < paises.Length; f++)
            {
                Console.Write("Ingrese el nombre de la provincia " + (f + 1) + ": ");
                paises[f] = Console.ReadLine();
                for (int c = 0; c < tempmen.GetLength(1); c++)
                {
                    Console.Write("Ingrese temperatura mensual " + (c + 1) + ": ");
                    string linea = Console.ReadLine();
                    tempmen[f, c] = int.Parse(linea);
                }
            }
        }
        public void ImprimirTempMensuales()
        {
            for (int f = 0; f < paises.Length; f++)
            {
                Console.Write("Provincia:" + paises[f] + ":");
                for (int c = 0; c < tempmen.GetLength(1); c++)
                {
                    Console.Write(tempmen[f, c] + " ");
                }
                Console.WriteLine();
            }
        }
        public void CalcularTemperaturaTri()
        {
            temptri = new int[4];
            for (int f = 0; f < tempmen.GetLength(0); f++)
            {
                int suma = 0;
                for (int c = 0; c < tempmen.GetLength(1); c++)
                {
                    suma = suma + tempmen[f, c];
                }
                temptri[f] = suma / 3;
            }
        }
        public void ImprimirTempTrimestrales()
        {
            Console.WriteLine("Temperaturas trimestrales.");
            for (int f = 0; f < paises.Length; f++)
            {
                Console.WriteLine(paises[f] + " " + temptri[f]);
            }
        }
        public void PaisMayorTemperaturaTri()
        {
            int may = temptri[0];
            string nom = paises[0];
            for (int f = 0; f < paises.Length; f++)
            {
                if (temptri[f] > may)
                {
                    may = temptri[f];
                    nom = paises[f];
                }
            }
            Console.WriteLine("Provincia con temperatura trimestral mayor es " + nom + " que tiene una temperatura de " + may);
        }
        static void Main(string[] args)
        {
            Matriz ma = new Matriz();
            ma.Cargar();
            ma.ImprimirTempMensuales();
            ma.CalcularTemperaturaTri();
            ma.ImprimirTempTrimestrales();
            ma.PaisMayorTemperaturaTri();
            Console.ReadKey();
        }
    }
}