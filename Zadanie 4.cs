﻿using System;
using System.Linq;
using System.Threading;

namespace Zadanie4
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // Console.WriteLine("Zadanie 4.1");
            // Console.WriteLine("Podaj długość tablicy");
            // int a = int.Parse(Console.ReadLine());
            // int[] tab = new int[a];
            // for (int i = 0; i < a; i++)
            //     tab[i] = int.Parse(Console.ReadLine());
            // for (int i = 0; i < a; i++)
            //     Console.WriteLine($"{i+1} Element to: {tab[i]}");
            // Console.WriteLine("Zadanie 4.2");
            // int[] tab1 = { 1, -2, 33, 49, -11, -34, -12, 43, 19, 24};
            // int[] tab2 = new int[10];
            // for (int i = 0; i < 10; i++)
            // {
            //     if (tab1[i] > 0)
            //         tab2[i] = tab1[i];
            //     Console.WriteLine($"{i+1} Element tablicy to: {tab2[i]}");
            // }
            // Console.WriteLine("Zadanie 4.3");
            // Console.WriteLine("Podaj długość tablicy");
            // int a = int.Parse(Console.ReadLine());
            // int[] tab = new int[a];
            // for (int i = 0; i < a; i++)
            //     tab[i] = int.Parse(Console.ReadLine());
            // int max = 0, min = tab[0], averge = 0, positive = 0;
            // foreach (int x in tab)
            //     if (x > max)
            //         max = x;
            // foreach (int x in tab)
            //     if (x < min)
            //         min = x;
            // foreach (var x in tab)
            //     averge += x;
            // averge /= tab.Length;
            // foreach (int x in tab)
            //     if (x > 0)
            //         positive++;
            // Console.WriteLine($"Największy element tablicy: {max}");
            // Console.WriteLine($"Najmniejszy element tablicy: {min}");
            // Console.WriteLine($"Średnia arytmetyczna wartości z tablicy: {averge}");
            // Console.WriteLine($"Ilość elementów dodatnich w tablicy: {positive}");
            // Console.WriteLine("Zadanie 4.4");
            // int[] array = new int[100];
            // Random rand = new Random();
            // for (int i = 0; i < 100; i++)
            //     array[i] = (rand.Next(1, 1000));
            // int count = 0;
            // foreach (int x in array)
            // {
            //     int granica = (int)Math.Floor(Math.Sqrt(x));
            //     for (int i = 2; i <= granica; i++)
            //     {
            //         if (x % i == 0)
            //         {
            //             break;
            //         }
            //         else if (i == granica)
            //         {
            //             count++;
            //         }
            //     }
            // }
            // Console.WriteLine("Ilośc liczb pierwszych {0}",count);
            // Console.WriteLine("Zadanie 4.5");
            // int[] arr1 = { 4, 3, 55, 33, 11, 22 };
            // int[] arr2 = new int[arr1.Length];
            // for (int i = 0; i < arr1.Length-1; i++)
            // {
            //         arr2[i+1] = arr1[i];
            // }
            // arr2[0] = arr1[arr1.Length-1];
            // for (int x = 0; x < arr2.Length; x++)
            //     Console.WriteLine(arr2[x]);
            // Console.WriteLine("Zadanie 4.6");
            // int count = 0;
            // int[,] arr = new int[5,5]
            // {
            //     { 1, 7, 2, 5, 3 }, 
            //     { 4, 5, 6, 2, 1 }, 
            //     { 3, 4, 2, 7, 5 }, 
            //     { 2, 3, 11, 4, 5 }, 
            //     { 4, 3, 22, 1, 5 }
            // };
            // for (int i = 0; i < 5; i++)
            // {
            //     for (int j = 0; j < 5; j++)
            //     {
            //         if (i == j)
            //             count += arr[i, j];
            //         Console.Write($"{arr[i,j]}, ");
            //     }
            //     Console.WriteLine();
            // }
            // Console.WriteLine($"Suma liczb po przekątnej to: {count}");
            // Console.WriteLine("Zadanie 4.7");
            // int[,] arrA = new int[,]
            // {
            //     {3, 2, 5},
            //     {4, 7, 1}
            // };
            // int[,] arrB = new int[,]
            // {
            //     {6, 21, 3},
            //     {1, 5, 9}
            // };
            // int[,] arrC = new int[2, 3];
            // for (int i = 0; i < 2; i++)
            // {
            //     for (int j = 0; j < 3; j++)
            //         arrC[i, j] = arrA[i, j] + arrB[i, j];
            // }
            // for (int i = 0; i < 2; i++)
            // {
            //     for (int j = 0; j < 3; j++)
            //     {
            //         Console.Write($"{arrC[i, j]}, ");
            //     }
            //     Console.WriteLine();
            // }
            // Console.WriteLine("Zadanie 4.8");
            // string[,] dniTygodnia;
            // dniTygodnia = new string[3, 7] // pamiętaj o zmianie rozmiaru tablicy
            // {
            //     { "poniedziałek", "wtorek", "środa", "czwartek", "piątek", "sobota", "niedziela" },
            //     { "monday", "tuesday", "wednesday", "thursday", "friday", "saturday", "sunday" },
            //     { "montag", "dienstag", "mittwoch", "donnerstag", "freitag", "samstag", "sonntag" }
            // };
            // for (int i = 0; i < 7; i++)
            // {
            //     for (int j = 0; j < 3; j++)
            //     {
            //         Console.Write($"{dniTygodnia[j, i]}, ");
            //     }
            //     Console.WriteLine();
            // }
            // Console.WriteLine("Zadanie 4.9");
            // Console.WriteLine("Wprowadz przykładowy tekst");
            // string text = Console.ReadLine();
            // int count = 0;
            // for(int i = 0; i < text.Length-1;i++)
            //     if (text[i] == ' ')
            //         count++;
            // count++;
            // Console.WriteLine($"Ilość wyrazów w twoim tekście: {count}");
            // Console.WriteLine("Zadanie 4.10");
            // Console.WriteLine("Wprowadź datę w formacie DD-MM-RRRR");
            // string date = Console.ReadLine();
            // int num = 0;
            // if (date[3] == '1')
            //     num = date[4] - '0' + 10;
            // else if (date[3] == '0')
            //     num = date[4] - '0';
            // switch (num)
            // {
            //     case 1:
            //         Console.WriteLine("Styczeń");
            //         break;
            //     case 2:
            //         Console.WriteLine("Luty");
            //         break;
            //     case 3:
            //         Console.WriteLine("Marzec");
            //         break;
            //     case 4:
            //         Console.WriteLine("Kwiecień");
            //         break;
            //     case 5:
            //         Console.WriteLine("Maj");
            //         break;
            //     case 6:
            //         Console.WriteLine("Czerwiec");
            //         break;
            //     case 7:
            //         Console.WriteLine("Lipiec");
            //         break;
            //     case 8:
            //         Console.WriteLine("Sierpień");
            //         break;
            //     case 9:
            //         Console.WriteLine("Wrzesień");
            //         break;
            //     case 10:
            //         Console.WriteLine("Październik");
            //         break;
            //     case 11:
            //         Console.WriteLine("Listopad");
            //         break;
            //     case 12:
            //         Console.WriteLine("Grudzień");
            //         break;
            //     default:
            //         Console.WriteLine("Nieprawidłowa wartość");
            //         break;
            // }
            // Console.WriteLine("Zadanie 4.11");
            // Console.WriteLine("Wpisz dowolne słowo");
            // string word = Console.ReadLine();
            // char[] words = word.ToCharArray();
            // Array.Sort(words);
            // int c, countwords = 0;
            // for (int x = 0; x < words.Length; x++)
            //     {
            //         do
            //         {
            //             c = x + 1;
            //             countwords++;
            //             if (words[x]==words[c])
            //             {
            //                 x++;
            //             }
            //         } while (words[x]==words[c]);
            //         Console.WriteLine($"Słowo {words[x]} - {countwords}");
            //         countwords = 0;
            //     }
            // Console.WriteLine("Zadanie 4.12");
            // string tekst = "W parę godzin później, gdy noc zbierała się do odejścia, \n" +
            //                "Puchatek obudził się nagle z uczuciem dziwnego przygnębienia.\n" +
            //                "To uczucie dziwnego przygnębienia miewał już nieraz i wiedział,\n" +
            //                "co ono oznacza. Był głodny. Więc poszedł do spiżarni,\n" +
            //                "wgramolił się na krzesełko, sięgnął na górną półkę, ale nic nie znalazł.";
            // int countrow = 0;
            // int countletters = 0;
            // for (int x = 0; x < tekst.Length; x++)
            // {
            //     if (tekst[x] == '\n')
            //     {
            //         countrow++;
            //         Console.WriteLine($"Liczba liter w wierszu {countrow} to: {countletters}");
            //         countletters = 0;
            //     }
            //     else if (tekst[x] == ' ' || tekst[x] == ',' || tekst[x] == '.')
            //         continue;
            //     else
            //         countletters++;
            // }
            // Console.WriteLine("Zadanie 4.13");    
            // string text = "Kiedy idzie się po miód z balonikiem, to trzeba się starać, " +
            //               "żeby pszczoły nie wiedziały, po co się idzie - odpowiedział Puchatek";
            // char[] delimiterchars = { ' ', ',','-'};
            // int countwords = 0;
            // int c=1;
            // string[] words = text.Split(delimiterchars, System.StringSplitOptions.RemoveEmptyEntries);
            // Array.Sort(words);
            // for (int x = 0; x < words.Length; x++)
            // {
            //     do
            //     {
            //         c = x + 1;
            //         countwords++;
            //         if (words[x]==words[c])
            //         {
            //             x++;
            //         }
            //     } while (words[x]==words[c]);
            //     Console.WriteLine($"Słowo {words[x]} - {countwords}");
            //     countwords = 0;
            // }
            // Console.WriteLine("Zadanie 4.14");
            // string[] arrayid = {"OKFDC-2005", "KMERT-2013", "QKY-2000", "OPOP-2009", "SRAT-2018"};
            // string[] zmienna = new string[5];
            // int c = 0;
            // for (int x = 0; x < arrayid.Length; x++)
            // {
            //     for (int y = arrayid[x].Length - 4; y < arrayid[x].Length; y++)
            //     {
            //         zmienna[c] += arrayid[x][y];
            //     }
            //
            //     if (c < 4)
            //         c++;
            // }
            // c = 0;
            // for (int x = 0; x < arrayid.Length; x++)
            // {
            //     c = 2023 - int.Parse(zmienna[x]);
            //     Console.WriteLine($"{x+1} Identyfikator to {arrayid[x]} czas jaki upłynął to {c} lat");
            // }
        }
    }
}