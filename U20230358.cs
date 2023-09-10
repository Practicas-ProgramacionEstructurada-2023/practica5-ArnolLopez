﻿using System;

namespace MyApp// Note: actual namespace depends on the project name.
{
    internal class Program
    {
         static void Main(string[] args)
        {
            Console.WriteLine("\n--->Calculadora de promedio<---");

            //Pide que ingrese las notas del primer computo

            Console.WriteLine("\n->Ingrese las notas del primer computo");
            Console.WriteLine("\nIngrese la nota del Laboratorio 1: ");
            double Lab1 = Convert.ToDouble(Console.ReadLine());


            Console.WriteLine("\nIngrese la nota del parcial 1:");
            double Parc1 = Convert.ToDouble(Console.ReadLine());


            //Pide que ingrese las notas del segundo computo
            Console.WriteLine("\n->Ingrese las notas del segundo computo");
            Console.WriteLine("\nIngrese la nota del Laboratorio 2: ");
            double Lab2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("\nIngrese la nota del parcial 2:");
            double Parc2 = Convert.ToDouble(Console.ReadLine());


            //Pide que ingrese las notas del tercer computo
            Console.WriteLine("\n->Ingrese las notas del tercer computo");
            Console.WriteLine("\nIngrese la nota del Laboratorio 3:");
            double Lab3 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("\nIngrese la nota del parcial 3:");
            double Parc3 = Convert.ToDouble(Console.ReadLine());


            //Calcula el promedio
            double PromedioLab = (Lab1 + Lab2 + Lab3) * 0.60;
            double PromedioParc = (Parc1 + Parc2 + Parc3) * 0.40;
            double Notafinal = (PromedioLab / 3) + (PromedioParc / 3);

            Console.WriteLine("\nSu nota final fue de: " + Math.Round(Notafinal, 1));


            //comparar el promedio de las notas final
            if (Notafinal >= 7)
            {
                Console.WriteLine("\nUsted paso la materia con excelente nota.\n");
            }
            else if (Notafinal >= 6)
            {
                Console.WriteLine("\nUsted paso la materia con nota baja.\n");
            }
            else 
            {
                Console.WriteLine("\nUsted saco una nota menor que 6, reprobo la materia.\n");
            }

            Console.ReadKey(); 
        }
    }
}