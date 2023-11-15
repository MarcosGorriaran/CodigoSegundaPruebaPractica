/*
 * Autor: Marcos Gorriaran
 * Fecha: 15/11/2023
 * Ejercicio 3:
 * Implementa un programa que demani a l’usuari quants valors vol
 * introduir, de manera que el programa generi una llista a partir de
 * valors introduïts per teclat i retorni el producte de tots els
 * elements d’aquesta. Els valors que l’usuari pot introduir són entre
 * (15, 100) i l’usuari disposa de 5 intents en total.
 */
using System;

namespace SegonaProvaPractica
{
    class GorriaranMarcosCodeEx3
    {
        public static void Main()
        {
            const string AskLength = "Cuantos valores introduciras: ";
            const string ShowAttemptsLeft = "Aun le queda {0} intentos";
            const string AskValue = "Proporcioname el valor {0}, el rango permitido es (15-100): ";
            const string ShowResult = "El producto de todos los valores introducido es: ";
            const string TooManyErrors = "Ha superado el limite de errores.";
            const string OutsideOfRangeError = "El valor introducido esta fuera del rango permitido";
            const int MinRange = 15;
            const int MaxRange = 100;
            const int AllowedErrors = 5;

            int[] valueList;
            int multSum = 0;
            int errorCount=0;

            Console.Write(AskLength);
            valueList = new int[Convert.ToInt32(Console.ReadLine())];

            int i = 0;
            while(i < valueList.Length && errorCount < AllowedErrors)
            {
                errorCount = 0;
                do
                {
                    Console.WriteLine(ShowAttemptsLeft,AllowedErrors-errorCount);
                    Console.Write(AskValue, i+1);
                    valueList[i] = Convert.ToInt32(Console.ReadLine());
                    if (valueList[i] <= MinRange || valueList[i] >= MaxRange)
                    {
                        errorCount++;
                        Console.WriteLine(OutsideOfRangeError);
                    }
                } while ((valueList[i]<=MinRange || valueList[i]>=MaxRange) && errorCount < AllowedErrors);
                multSum = i == 0 ? valueList[i] : multSum * valueList[i];
                i++;
            }

            Console.WriteLine(AllowedErrors <= errorCount ? TooManyErrors : ShowResult+multSum);
        }
    }
}