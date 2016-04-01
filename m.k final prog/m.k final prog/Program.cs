using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace m.k_final_prog
{
    class Program
    {
        static void Main(string[] args)
        {
            l1:
            int select;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("****************************** MAIN MENU ******************************");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n");
            Console.WriteLine("-----------------List of Arrays, which are available for you------------------");
            Console.WriteLine("\n");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("1-2ARRAYS\n\n2-3ARRAYS\n\n3-4ARRAYS\n\n4-5ARRAYS");
            Console.Write(">>>>>");
            select = int.Parse(Console.ReadLine());
            Console.WriteLine("-----------------------------------------------------------------------------");

            switch (select)
            {
                case 1:
                    int[] x1 = new int[100];
                    int[] x2 = new int[100];
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine("-------How many elements you want in your ARRAY 1--------");
                    int a1 = int.Parse(Console.ReadLine());
                    arrays o = new arrays();
                    o.creatrearray(x1, a1);
                    Console.WriteLine("\n");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("-------How many elements you want in your ARRAY 2--------");
                    int a2 = int.Parse(Console.ReadLine());
                    o.creatrearray(x2, a2);
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("---How many QUANTUMS you want to RUN------");
                    int q = int.Parse(Console.ReadLine());
                    Console.WriteLine();
                    arrays f = new arrays();
                    f.quantums(x1, x2, a1, a2,q);

                    Console.ReadKey();
                    
                    break;
                    
                case 2:
                    int[] xx1 = new int[100];
                    int[] xx2 = new int[100];
                    int[] xx3 = new int[100];
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("-------How many elements you want in your ARRAY 1--------");
                    int aa1 = int.Parse(Console.ReadLine());
                    arrays o1 = new arrays();
                    o1.creatrearray(xx1, aa1);
                    Console.WriteLine("\n");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("-------How many elements you want in your ARRAY 2--------");
                    int aa2 = int.Parse(Console.ReadLine());
                    o1.creatrearray(xx2, aa2);
                    Console.WriteLine("\n");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine("-------How many elements you want in your ARRAY 3--------");
                    int aa3 = int.Parse(Console.ReadLine());
                    o1.creatrearray(xx3, aa3);
                    Console.WriteLine("\n");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                     Console.WriteLine("---How many QUANTUMS you want to RUN------");
                    int q1 = int.Parse(Console.ReadLine());
                    Console.WriteLine();
                    arrays f1 = new arrays();
                    f1.quantums(xx1, xx2,xx3, aa1, aa2,aa3,q1);
                    Console.WriteLine("\n");
                    break;
                case 3:
                    int[] xxx1 = new int[100];
                    int[] xxx2 = new int[100];
                    int[] xxx3 = new int[100];
                    int[] xxx4 = new int[100];
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("-------How many elements you want in your ARRAYS 1--------");
                    int aaa1 = int.Parse(Console.ReadLine());
                    arrays oo1 = new arrays();
                    oo1.creatrearray(xxx1, aaa1);
                    Console.WriteLine("\n");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("-------How many elements you want in your ARRAYS 2--------");
                    int aaa2 = int.Parse(Console.ReadLine());
                    oo1.creatrearray(xxx2, aaa2);
                    Console.WriteLine("\n");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("-------How many elements you want in your ARRAYS 3--------");
                    int aaa3 = int.Parse(Console.ReadLine());
                    oo1.creatrearray(xxx3, aaa3);
                    Console.WriteLine("\n");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("-------How many elements you want in your ARRAYS 4--------");
                    int aaa4 = int.Parse(Console.ReadLine());
                    oo1.creatrearray(xxx4, aaa4);
                    Console.WriteLine("\n");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                     Console.WriteLine("---How many QUANTUMS you want to RUN------");
                    int q2 = int.Parse(Console.ReadLine());
                    Console.WriteLine();
                    arrays f2 = new arrays();
                    f2.quantums2(xxx1, xxx2,xxx3,xxx4, aaa1, aaa2,aaa3,aaa4,q2);
                    Console.WriteLine("\n");
                    break;
                case 4:
                    int[] xxx11 = new int[100];
                    int[] xxx21 = new int[100];
                    int[] xxx31 = new int[100];
                    int[] xxx41 = new int[100];
                    int[] xxx51 = new int[100];
                    Console.ForegroundColor = ConsoleColor.Yellow;
                     Console.WriteLine("-------How many elements you want in your ARRAYS 1--------");
                    int aaa11 = int.Parse(Console.ReadLine());
                    arrays ooo1 = new arrays();
                    ooo1.creatrearray(xxx11, aaa11);
                    Console.WriteLine("\n");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("-------How many elements you want in your ARRAYS 2--------");
                    int aaa21 = int.Parse(Console.ReadLine());
                    ooo1.creatrearray(xxx21, aaa21);
                    Console.WriteLine("\n");
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("-------How many elements you want in your ARRAYS 3--------");
                    int aaa31 = int.Parse(Console.ReadLine());
                    ooo1.creatrearray(xxx31, aaa31);
                    Console.WriteLine("\n");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine("-------How many elements you want in your ARRAYS 4--------");
                    int aaa41 = int.Parse(Console.ReadLine());
                    ooo1.creatrearray(xxx41, aaa41);
                    Console.WriteLine("\n");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("-------How many elements you want in your ARRAYS 5--------");
                    int aaa51 = int.Parse(Console.ReadLine());
                    ooo1.creatrearray(xxx51, aaa51);
                    Console.WriteLine("\n");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                      Console.WriteLine("---How many QUANTUMS you want to RUN------");
                    int q3 = int.Parse(Console.ReadLine());
                    Console.WriteLine();
                    arrays f3 = new arrays();
                    f3.quantums3(xxx11, xxx21,xxx31,xxx41,xxx51, aaa11, aaa21,aaa31,aaa41,aaa51,q3);
                    Console.WriteLine("\n");
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("====================YOU HAVE SELECTED A WRONG OPTION====================");
                    break;
            }
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("....................Press any key to start again.................");
            Console.ReadKey();
            Console.Clear();
            goto l1;

            Console.ReadLine();
        }

         
        

    }
}
