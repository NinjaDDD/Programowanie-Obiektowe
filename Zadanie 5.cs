using System;
using System.Reflection;

namespace Zadanie_5
{
    internal class Program
    {
        // Zadanie 5.1
        // static void temperature(int temp)
        // {
        //     Console.WriteLine((temp - 32) / 1.8);
        // }
        // public static void Main(string[] args)
        // {
        //     Console.WriteLine("Podaj temperature w Fahrenheita");
        //     int F = int.Parse(Console.ReadLine());
        //     temperature(F);
        // }
        // Zadanie 5.2
        // static bool belong(int a, int b, int x)
        // {
        //     if (a < x && x < b)
        //         return true;
        //     else
        //         return false;
        // }
        // public static void Main(string[] args)
        // {
        //     int a, b, x;
        //     Console.Write("Podaj przedział z lewej strony (a, b) = ");
        //     a = int.Parse(Console.ReadLine());
        //     Console.Write($"Podaj przedział z prawej strony ({a}, b) = ");
        //     b = int.Parse(Console.ReadLine());
        //     Console.Write("Teraz podaj wartość x a program sprawdzi czy mieści się w tym przedziale ");
        //     x = int.Parse(Console.ReadLine());
        //     if (belong(a, b, x) == true)
        //         Console.WriteLine($"{x} należy do przedziału otwartego ({a}, {b})");
        //     else
        //         Console.WriteLine($"{x} nie należy do przedziału otwartego ({a}, {b})");
        // }
        // Zadanie 5.3
        // static void przesun(double[] vector)
        // {
        //     double[] wek = { 2, 1 };
        //     Console.WriteLine($"[{vector[0]+wek[0]}, {vector[1]+wek[1]}]");
        // }
        // public static void Main(string[] args)
        // {
        //     Console.WriteLine("Podaj współrzędne wektora [a, b]");
        //     double[] vec = new double[2];
        //     vec[0] = double.Parse(Console.ReadLine());
        //     vec[1] = double.Parse(Console.ReadLine());
        //     przesun(vec);
        // }
        // Zadanie 5.4
        // static void multiplychange(ref int[] arr1, int x)
        // {
        //     for (int i = 0; i < arr1.Length; i++)
        //         arr1[i] = x * arr1[i];
        // }
        // static int[] multiply(int[] arr, int x)
        // {
        //     int[] arrm = new int[arr.Length];
        //     for (int i = 0; i < arrm.Length; i++)
        //         arrm[i] = x * arr[i];
        //     return arrm;
        // }
        // public static void Main(string[] args)
        // {
        //     Console.Write("Podaj wymiar tablicy n = ");
        //     int n = int.Parse(Console.ReadLine());
        //     int[] arr = new int[n];
        //     Console.WriteLine("Podawaj po kolei elementy tablicy");
        //     for (int i = 0; i < arr.Length; i++)
        //         arr[i] = int.Parse(Console.ReadLine());
        //     Console.Write("Teraz podaj przez ile chcesz pomnożyc elementy w tablicy: ");
        //     int x = int.Parse(Console.ReadLine());
        //     Console.Write("Twoja tablica pomnożona : ");
        //     foreach (int a in multiply(arr, x))
        //         Console.Write($"[{a}]");
        //     Console.WriteLine("");
        //     Console.Write("Twoja tablica pomnożona drugim sposobem: ");
        //     multiplychange(ref arr, x);
        //     foreach (int b in arr)
        //         Console.Write($"[{b}]");
        // }
        // Zadanie 5.5
        // static void Draw(int l, int h, char ch)
        // {
        //     for (int i = 0; i < h; i++)
        //     {
        //         for (int j = 0; j < l; j++)
        //         {
        //             Console.Write(ch);
        //         }
        //         Console.WriteLine("");
        //     }
        // }
        // public static void Main(string[] args)
        // {
        //     Console.Write("Podaj długość tablicy: ");
        //     int len = int.Parse(Console.ReadLine());
        //     Console.Write("Podaj wysokość tablicy: ");
        //     int hei = int.Parse(Console.ReadLine());
        //     Console.Write("Podaj znak rysujący tablice: ");
        //     char chr = char.Parse(Console.ReadLine());
        //     Draw(len, hei, chr);
        //     Console.WriteLine("");
        //     Draw(hei, len, chr);
        // }
        // Zadanie 5.6
        // static void multiplychange(ref string[] arr1, int x)
        // {
        //     string c;
        //     for (int i = 0; i < arr1.Length; i++)
        //     {
        //         c = arr1[i];
        //         for (int j = 0; j < x-1; j++)
        //             arr1[i] += c;
        //     }
        // }
        // public static void Main(string[] args)
        // {
        //     Console.Write("Podaj wymiar tablicy n = ");
        //     int n = int.Parse(Console.ReadLine());
        //     string[] arr = new string[n];
        //     Console.WriteLine("Podawaj po kolei elementy tablicy");
        //     for (int i = 0; i < n; i++)
        //         arr[i] = Console.ReadLine();
        //     Console.Write("Teraz podaj przez ile chcesz pomnożyc elementy w tablicy: ");
        //     int x = int.Parse(Console.ReadLine());
        //     Console.Write("Twoja tablica pomnożona : ");
        //     multiplychange(ref arr, x);
        //     foreach (var a in arr)
        //         Console.Write($"[{a}]");
        // }
        // Zadanie 5.7
        // static int calculatesum (int x, int n)
        // {
        //     int w=0;
        //     for (int i = 1; i <= n; i++)
        //         w += x + i;
        //     return w;
        // }
        // public static void Main(string[] args)
        // {
        //     Console.Write("Podaj długość ciągu sumy n = ");
        //     int n = int.Parse(Console.ReadLine());
        //     Console.Write("Wpisz nie wiadomą x = ");
        //     int x = int.Parse(Console.ReadLine());
        //     Console.Write($"Suma ciągu W = (x+1) + (x+2) + ... + (x+n) dla x = {x} i długości n = {n} wynosi W = {calculatesum(x, n)}");
        // }
        // Zadanie 5.8
        // static void figuresum(int x)
        // {
        //     int result = 0;
        //     string l = x.ToString();
        //     l.Split();
        //     for (int i = 0; i < l.Length; i++)
        //         result += l[i]-48;
        //     Console.Write("(");
        //     for (int i = 0; i < l.Length-1; i++)
        //         Console.Write($"{l[i]}+");
        //     Console.Write($"{l[l.Length-1]} = {result})");
        // }
        // public static void Main(string[] args)
        // {
        //     Console.Write("Podaj dowolną cyfre: ");
        //     int x = int.Parse(Console.ReadLine());
        //     figuresum(x);
        // }
        // Zadanie 5.9
        // static void Fibonacci(int n)
        // {
        //     int f1 = 1, f2 = 0, f = 0, fp = 0;
        //     if (n >= 0 && n <= 1)
        //         Console.WriteLine($"Wyraz ciągu to n: {n}");
        //     else if (n > 1)
        //     {
        //         for (int x = 0; x < n-1; x++)
        //         {
        //             f = f2 + f1;
        //             f2 = f1;
        //             f1 = f;
        //             if (x == n - 3)
        //                 fp = f2;
        //         }
        //         Console.WriteLine($"Wyraz {n}-ty ciągu to Fn = {f2} + {fp} = {f1}");
        //     }
        //     else
        //         Console.WriteLine("Proszę podać liczbę dodatnią, n>0");
        // }
        // public static void Main(string[] args)
        // {
        //     Console.Write("Podaj liczbe n ciągu fibonacciego którą chcesz znaleźć n = ");
        //     int n = int.Parse(Console.ReadLine());
        //     Fibonacci(n);
        // }
        // Zadanie 5.10
        // static int Oblicz(int n)
        // {
        //     if (n <= 1) return (1);
        //     else return (n + Oblicz(n - 1));
        // }
        // public static void Main(string[] args)
        // {
        //     Console.Write("Wprowadz liczbe: ");
        //     int n = int.Parse(Console.ReadLine());
        //     Console.WriteLine(Oblicz(n));
        // }
    }
}