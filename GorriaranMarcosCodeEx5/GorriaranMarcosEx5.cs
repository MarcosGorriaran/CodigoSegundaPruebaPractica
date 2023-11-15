/*
 * Autor: Marcos Gorriaran
 * Fecha: 15/11/2023
 * Ejercicio 5:
 * Implementa un menú que demani per teclat introduir una de les
 * següents opcions: A, B, C, D (éssent vàlida tant majúscula com
 * minúscula), com el següent exemple:
 */
using System;

namespace SegonaProvaPractica
{
    class GorriaranMarcosCodeEx5
    {
        public static void Main()
        {
            const string Menu = "Bienvenid@! Elige una opcion \nA: Buscar una cadena en un texto\nB: Mostrar todas las letras de un texto sparado por espacios\nC: Substituir un caracter en un texto por otro caracter\nD: Confirmar el nombre de un fixero de codigo fuente\nE: Salir\nTu opcion: ";
            const string InvalidOptionError = "La opcion elegida no esta en el rango de casos esperados, vuelva a introducir una opcion.";
            const string ProvideText = "Proporcioname el texto a tratar: ";
            const string ProvideSearchTarget = "Que texto desea buscar del texto proporcionado: ";
            const string ProvideReplaceTarget = "Que caracter desea buscar: ";
            const string AskReplacementChar = "Introduce el caracter con el que sistituir: ";
            const string TargetFound = "El texto a buscar existe en la cadena proporcionada";
            const string TargetNotFound = "El texto a buscar no existe en la cadena proporcionada";
            const string TargetIsCs = "El archivo es codigo fuente de C#";
            const string TargetIsNotCs = "El archivo no es codigo fuente de C#";
            const string CsExtension = ".cs";
            const string ExitMsg = "Adios Raquel o Carles";
            const char SearchInTextOption = 'A';
            const char ShowAllWordsOption = 'B';
            const char ChangeCharInTextOption = 'C';
            const char ValidateCodeFileNameOption = 'D';
            const char ExitOption = 'E';

            string treatedText;
            string searchTarget;
            
            char option;
            do
            {
                Console.Write(Menu);
                option = Console.ReadLine().ToUpper()[0];

                switch (option)
                {
                    case SearchInTextOption:
                        //Caso A
                        Console.Write(ProvideText);
                        treatedText = Console.ReadLine();
                        Console.Write(ProvideSearchTarget);
                        searchTarget = Console.ReadLine();

                        Console.WriteLine(treatedText.Contains(searchTarget) ? TargetFound : TargetNotFound);
                        break;
                    case ShowAllWordsOption:
                        //Caso B
                        Console.Write(ProvideText);
                        treatedText = Console.ReadLine();
                        char[] convertedFromTreated=treatedText.ToCharArray();
                        treatedText = "";
                        for(int i=0; i < convertedFromTreated.Length; i++)
                        {
                            if (convertedFromTreated[i]!=' ')
                            {
                                treatedText += convertedFromTreated[i];
                                treatedText += " ";
                            }
                            
                        }
                        Console.WriteLine(treatedText);
                        break;
                    case ChangeCharInTextOption:
                        //Caso C
                        Console.Write(ProvideText);
                        treatedText = Console.ReadLine();

                        Console.Write(ProvideReplaceTarget);
                        char replaceTarget = Console.ReadLine()[0];
                        Console.Write(AskReplacementChar);
                        char replacementChar = Console.ReadLine()[0];

                        Console.WriteLine(treatedText.Replace(replaceTarget, replacementChar));
                        break;
                    case ValidateCodeFileNameOption:
                        //Caso D
                        Console.Write(ProvideText);
                        treatedText = Console.ReadLine();

                        Console.WriteLine(treatedText.EndsWith(CsExtension) ? TargetIsCs : TargetIsNotCs);
                        break;
                    case ExitOption:
                        //Caso E
                        Console.WriteLine(ExitMsg);
                        break;
                    default:
                        Console.WriteLine(InvalidOptionError);
                        break;
                }
            } while (option!=ExitOption);
        }
    }
}