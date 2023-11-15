/*
 * Autor: Marcos Gorriaran
 * Fecha: 15/11/2023
 * Ejercicio 4:
 * El següent tipus de dades emmagatzema les notes mitjanes d’un grup
 * de cicles formatius. Cada nota correspon a la nota mitjana de cada
 * alumne:
 * Implementa un programa perquè faci el següent (fent servir la
 * interpolació i el composite formatting):
 */
using System;

namespace SegonaProvaPractica
{
    class GorriaranMarcosCodeEx4
    {
        public static void Main()
        {
            const string ShowNote = "Nota {0}: {1}";
            const string SplitCases = "----------------------------------";
            const int MinNoteRange = 4;
            const int MaxNoteRange = 9;
            const string InRangeAmountResult = "Hay {0} alumnos que han obtenido notas entre {1} y {2} de mediana (incluidos)";
            float[] marks = { 5.5f, 10f, 3.5f, 1.25f, 1.75f, 6.2f, 5.15f, 6.75f, 4.15f, 9.25f, 8.75f, 2.75f, 0.0f, 1.35f, 6.55f };
            float avg = 0;
            float aux;
            int countInRange = 0;

            //Caso A
            for (int i = 0; i < marks.Length; i++)
            {
                Console.WriteLine(ShowNote, i + 1, marks[i]);
                avg += marks[i];
            }
            avg /= marks.Length;
            Console.WriteLine($"La nota media de la clase es: {avg}");
            
            Console.WriteLine(SplitCases);

            //Caso B
            for (int i = 0; i < marks.Length-1; i++)
            {
                for(int j = i+1; j < marks.Length; j++)
                {
                    if (marks[i] < marks[j])
                    {
                        aux = marks[j];
                        marks[j] = marks[i];
                        marks[i] = aux;
                    }
                }
                Console.WriteLine(ShowNote, i + 1, marks[i]);
            }
            Console.WriteLine(ShowNote, marks.Length, marks[marks.Length-1]);
            Console.WriteLine($"La nota media de la clase es: {avg}");

            Console.WriteLine(SplitCases);

            //Caso C
            for (int i = 0; i < marks.Length; i++)
            {
                Console.WriteLine(ShowNote, i + 1, marks[i]);
                if (marks[i]>=MinNoteRange && marks[i]<=MaxNoteRange)
                {
                    countInRange++;
                }
            }
            Console.WriteLine($"La nota media de la clase es: {avg}");
            Console.WriteLine(InRangeAmountResult, countInRange, MinNoteRange, MaxNoteRange);

        }
    }
}