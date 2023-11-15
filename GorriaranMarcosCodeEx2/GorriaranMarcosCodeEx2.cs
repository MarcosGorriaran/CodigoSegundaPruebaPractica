/*
 * Autor: Marcos Gorriaran
 * Fecha: 15/11/2023
 * Ejercicio 2:
 *  Implementa un programa que emmagatzemi una frase introduïda per
 *  teclat en la variable stmntOne. Després ha de demanar un altre text
 *  i emmagatzema’l en la variable stmntTwo, afegir stmntOne al final
 *  de stmntTwo i mostrar-la per pantalla. Explica el procés a nivell
 *  informàtic i demostra-ho mitjançant les instruccions en C# que
 *  consideris.
 */
using System;

namespace SegonaProvaPractica
{
    class GorriaranMarcosCodeEx2
    {
        public static void Main()
        {
            string stmntOne;
            string stmntTwo;

            stmntOne = Console.ReadLine();
            stmntTwo = Console.ReadLine();

            Console.WriteLine(stmntTwo.GetHashCode());
            stmntTwo += stmntOne;
            Console.WriteLine(stmntTwo.GetHashCode());

            Console.WriteLine(stmntTwo);
        }
    }
}