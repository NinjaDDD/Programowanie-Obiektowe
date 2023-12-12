using System;
using System.Reflection.Emit;

namespace Zadanie_6
{
    // Zadanie 6.1-3
    // public class rectangle
    // {
    //     private int lenght;
    //     private int height;
    //     public string[] rectangle;
    //
    //     public rectangle(int l, int h)
    //     {
    //         lenght = l;
    //         height = h;
    //     }
    //     private int Surface()
    //     {
    //         return 2 * lenght + 2 * height;
    //     }
    //
    //     private int Perimeter()
    //     {
    //         return lenght * height;
    //     }
    //
    //     public void Show()
    //     {
    //         Console.WriteLine($"Długość prostokąta to {lenght}, wysokość {height}" +
    //                       $", obwód to {Surface()}, pole to {Perimeter()}");
    //     }
    //
    //     public static void MaxPerimeter(rectangle[] arr)
    //     {
    //         int max = arr[0].Perimeter();
    //         foreach (rectangle p in arr)
    //         {
    //             if (p.Perimeter() > max)
    //             {
    //                 max = p.Perimeter();
    //             }
    //         }
    //         Console.WriteLine($"Największe pole prostokąta to: {max}");
    //     }
    // }
    // internal class Program
    // {
    //     public static void Main(string[] args)
    //     {
    //         Console.Write("Podaj długość prostokąta a = ");
    //         int a = int.Parse(Console.ReadLine());
    //         Console.Write("Podaj szerokość prostokąta b = ");
    //         int b = int.Parse(Console.ReadLine());
    //         rectangle p1 = new rectangle(a, b);
    //         rectangle[] arr = new rectangle[3];
    //         arr[0] = p1;
    //         arr[1] = new rectangle(3, 3);
    //         arr[2] = new rectangle(2, 7);
    //         foreach (var x in arr)
    //         {
    //             x.Show();
    //         }
    //         rectangle.MaxPerimeter(arr);
    //     }
    // }
    // Zadanie 6.4
    // public class Energy
    // {
    //     public int primaryUsage;
    //     public int actualUsage;
    //
    //     public void Show()
    //     {
    //         Console.WriteLine($"Początkowe zużycia energi: {primaryUsage} kWh, aktualne zużycie: {actualUsage} kWh");
    //     }
    //
    //     public int Calculate()
    //     {
    //         return actualUsage - primaryUsage;
    //     }
    // }
    // internal class Program
    // {
    //     public static void Main(string[] args)
    //     {
    //         Energy e1 = new Energy();
    //         Console.Write("Podaj początkową wartość licznika: ");
    //         e1.primaryUsage = int.Parse(Console.ReadLine());
    //         Console.Write("Podaj aktualną wartość licznika: ");
    //         e1.actualUsage = int.Parse(Console.ReadLine());
    //         e1.Show();
    //         Console.WriteLine($"Zużyto {e1.Calculate()} kWh");
    //     }
    // }
    // Zadanie 6.5
    // public class Point
    // {
    //     public int x;
    //     public int y;
    //
    //     public Point(int x1, int y1)
    //     {
    //         x = x1 + 4;
    //         y = y1 + 2;
    //     }
    //
    //     public void Show()
    //     {
    //         Console.WriteLine($"Twój punkt a po przesunięciu ({x}, {y})");
    //     }
    //     
    // }
    // internal class Program
    // {
    //     public static void Main(string[] args)
    //     {
    //         Point p1 = new Point(2 ,3);
    //         p1.Show();
    //     }
    // }
    // Zadanie 6.6
    // public class Point
    // {
    //     public int x;
    //     public int y;
    //
    //     public Point(int x, int y)
    //     {
    //         this.x = x;
    //         this.y = y;
    //     }
    //     
    //     public static void czyLeży(Point[] arr)
    //     {
    //         int aab, aac;
    //         aab = (arr[1].y - arr[0].y) / (arr[1].x - arr[0].x);
    //         aac = (arr[2].y - arr[0].y) / (arr[2].x - arr[0].x);
    //         if(aab == aac)
    //             Console.WriteLine("Punkty są współliniowe");
    //         else
    //             Console.WriteLine("Punkty nie są współliniowe");
    //     }
    //     
    // }
    //
    // internal class Program
    // {
    //     public static void Main(string[] args)
    //     {
    //         Point[] arr = new Point[3];
    //         arr[0] = new Point(2, 3);
    //         arr[1] = new Point(4, 1);
    //         arr[2] = new Point(3, 2);
    //         Point.czyLeży(arr);
    //     }
    // }
    // Zadanie 6.7
    // public class lineSegment
    // {
    //     private Point p1;
    //     private Point p2;
    //
    //     public lineSegment(Point p1, Point p2)
    //     {
    //         this.p1 = p1;
    //         this.p2 = p2;
    //     }
    //     public static double lenLine(Point p1, Point p2)
    //     {
    //         return Math.Sqrt(Math.Pow(p2.x - p1.x, 2) + Math.Pow(p2.y - p1.y, 2));
    //     }
    // }
    // public class Point
    // {
    //     public int x;
    //     public int y;
    //
    //     public Point(int x, int y)
    //     {
    //         this.x = x;
    //         this.y = y;
    //     }
    // }
    //
    // internal class Program
    // {
    //     public static void Main(string[] args)
    //     {
    //         Point p1 = new Point(-2, -2);
    //         Point p2 = new Point(3, 3);
    //         Console.WriteLine($"Twoje p1 = {p1.x}, {p1.y}");
    //         Console.WriteLine($"Twoje p2 = {p2.x}, {p2.y}");
    //         Console.WriteLine($"Długość odcinka |p2 p1| = {lineSegment.lenLine(p1, p2)}");
    //     }
    // }
    // Zadanie 6.8
    // public class cuboid
    // {
    //     private int a;
    //     private int b;
    //     private int h;
    //     public int volume;
    //
    //     public cuboid(int a, int b, int h)
    //     {
    //         this.a = a;
    //         this.b = b;
    //         this.h = h;
    //         this.volume = a * b * h;
    //     }
    //     public static void compareVol(cuboid[] arr)
    //     {
    //         Console.WriteLine($"Objętość 1 prostopadłościanu to {arr[0].volume}, " +
    //                           $"objętość 2 prostopadłościanu to {arr[1].volume}, " +
    //                           $"Różnica między nimi to {arr[1].volume-arr[0].volume}");
    //     }
    // }
    // internal class Program
    // {
    //     public static void Main(string[] args)
    //     {
    //         cuboid[] arr = new cuboid[2];
    //         arr[0] = new cuboid(2, 3, 5);
    //         arr[1] = new cuboid(4, 4, 4);
    //         cuboid.compareVol(arr);
    //     }
    // }
    // Zadanie 6.9
    // struct Rectangle
    // {
    //     private int a;
    //     private int b;
    //
    //     public Rectangle(int a, int b)
    //     {
    //         this.a = a;
    //         this.b = b;
    //     }
    //
    //     private int area()
    //     {
    //         return a * b;
    //     }
    //
    //     private int perimeter()
    //     {
    //         return 2 * a + 2 * b;
    //     }
    //
    //     public void show()
    //     {
    //         Console.WriteLine($"Pole twojego prostokąta to - {area()}, a obwód to - {perimeter()}");
    //     }
    // }
    // internal class Program
    // {
    //     public static void Main(string[] args)
    //     {
    //         Rectangle figura = new Rectangle(3, 5);
    //         figura.show();
    //     }
    // }
    // Zadanie 6.10
    // struct kandydatNaStudenta
    // {
    //     public string nazwisko;
    //     public int punktyMatematyka;
    //     public int punktyInformatyka;
    //     public int punktyJezykObcy;
    //
    //     public kandydatNaStudenta(string nazwisko, int pm, int pi, int pjo)
    //     {
    //         this.nazwisko = nazwisko;
    //         punktyMatematyka = pm;
    //         punktyInformatyka = pi;
    //         punktyJezykObcy = pjo;
    //     }
    //     public double iloscPunktów()
    //     {
    //         return punktyMatematyka * 0.6 + punktyInformatyka * 0.5 + punktyJezykObcy * 0.2;
    //     }
    // }
    //
    // internal class Program
    // {
    //     public static void Main(string[] args)
    //     {
    //         kandydatNaStudenta[] arr = new kandydatNaStudenta[3];
    //         arr[0] = new kandydatNaStudenta("Kowalski", 60, 54, 95);
    //         arr[1] = new kandydatNaStudenta("Ząb", 71, 88, 57);
    //         arr[2] = new kandydatNaStudenta("Tkacz", 44, 61, 56);
    //         for (int p = 0; p < arr.Length; p++)
    //         {
    //             Console.Write($"{arr[p].nazwisko} , Punkty matematyka: {arr[p].punktyMatematyka}% , Punkty informatyka: {arr[p].punktyInformatyka}%" +
    //                           $" , Punkty język obcy: {arr[p].punktyJezykObcy}% , Szansa na dostanie się na uczelnie {arr[p].iloscPunktów()}%");
    //             Console.WriteLine();
    //         }
    //     }
    // }
}