using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace m.k_final_prog
{
    class arrays
    {
    
        public  int[] creatrearray(int[]a,int num)
    {
        for (int i = 0; i < num; i++)
        {
            Console.Write("Enter number on index #"+i +"=");
            a[i] = int.Parse(Console.ReadLine());
        }
        
        Console.WriteLine("=====You have following numbers in your ARRAY=======");

        for (int i = 0; i < num; i++)
        {
            Console.Write(a[i] + " ");
        }
        return a; 
    }

        public void quantums(int []z,int[]y,int array1,int array2,int q)
        {
            
            //Console.WriteLine("----------How many Quantum you want-----------");
            //q = int.Parse(Console.ReadLine());
            //Console.WriteLine();
            int r = 0, a = 0,f=q;
        l1:



            for (int i = r; i < q; i++)
            {

                if (i <array1)
                {

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write(z[i] + ",");
                    r = i + 1;

                }


                else
                {
                    break;
                }
                
                Console.WriteLine("..............from array 1");
                Console.WriteLine();
            }


            for (int i = a; i < q; i++)
            {
                if (i < array2)
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write(y[i] + ",");
                    a = i + 1;

                }
                else
                {
                    break;
                }
                Console.WriteLine("--------------from array 2");
                Console.WriteLine();
            }

            q = q +f;
            goto l1;
            //Console.ReadLine();


        }
        public void quantums(int[] z, int[] y,int[]x, int array1, int array2,int array3, int q)
        {

            //Console.WriteLine("----------How many Quantum you want-----------");
            //q = int.Parse(Console.ReadLine());
            //Console.WriteLine();
            int r = 0, a = 0,n=0,f=q;
        l1:



            for (int i = r; i < q; i++)
            {

                if (i < array1)
                {


                    Console.Write(z[i] + ",");
                    r = i + 1;

                }


                else
                {
                    break;
                }

                Console.WriteLine("..............from array 1");
                Console.WriteLine();
            }


            for (int i = a; i < q; i++)
            {
                if (i < array2)
                {

                    Console.Write(y[i] + ",");
                    a = i + 1;

                }
                else
                {
                    break;
                }
                Console.WriteLine("--------------from array 2");
                Console.WriteLine();
            }
            for (int i = n; i < q; i++)
            {
                if (i < array3)
                {

                    Console.Write(x[i] + ",");
                    n = i + 1;

                }
                else
                {
                    break;
                }
                Console.WriteLine("--------------from array 3");
                Console.WriteLine();
            }

            q =q+ f ;
           // q =q+q;
            goto l1;
            //Console.ReadLine();


        }

        public void quantums2(int[] z, int[] y, int[] x,int[]d, int array1, int array2,int array3, int array4, int q)
        {

            //Console.WriteLine("----------How many Quantum you want-----------");
            //q = int.Parse(Console.ReadLine());
            //Console.WriteLine();
            int r = 0, a = 0, n = 0,n2=0,f=q;
        l1:



            for (int i = r; i < q; i++)
            {

                if (i < array1)
                {


                    Console.Write(z[i] + ",");
                    r = i + 1;

                }


                else
                {
                    break;
                }

                Console.WriteLine("..............from array 1");
                Console.WriteLine();
            }


            for (int i = a; i < q; i++)
            {
                if (i < array2)
                {

                    Console.Write(y[i] + ",");
                    a = i + 1;

                }
                else
                {
                    break;
                }
                Console.WriteLine("--------------from array 2");
                Console.WriteLine();
            }
            for (int i = n; i < q; i++)
            {
                if (i < array3)
                {

                    Console.Write(x[i] + ",");
                    n = i + 1;

                }
                else
                {
                    break;
                }
                Console.WriteLine("--------------from array 3");
                Console.WriteLine();
            }

            

            for (int i = n2; i < q; i++)
            {
                if (i < array4)
                {

                    Console.Write(d[i] + ",");
                    n2 = i + 1;

                }
                else
                {
                    break;
                }
                Console.WriteLine("--------------from array 4");
                Console.WriteLine();
            }

            q = q + f;
            // q =q+q;
            goto l1;
            //Console.ReadLine();

        }
        public void quantums3(int[] z, int[] y, int[] x, int[] d,int[]m, int array1, int array2, int array3,int array4, int array5, int q)
        {

            //Console.WriteLine("----------How many Quantum you want-----------");
            //q = int.Parse(Console.ReadLine());
            //Console.WriteLine();
            int r = 0, a = 0, n = 0, n2 = 0,n3=0,f=q;
        l1:



            for (int i = r; i < q; i++)
            {

                if (i < array1)
                {


                    Console.Write(z[i] + ",");
                    r = i + 1;

                }


                else
                {
                    break;
                }

                Console.WriteLine("..............from array 1");
                Console.WriteLine();
            }


            for (int i = a; i < q; i++)
            {
                if (i < array2)
                {

                    Console.Write(y[i] + ",");
                    a = i + 1;

                }
                else
                {
                    break;
                }
                Console.WriteLine("--------------from array 2");
                Console.WriteLine();
            }
            for (int i = n; i < q; i++)
            {
                if (i < array3)
                {

                    Console.Write(x[i] + ",");
                    n = i + 1;

                }
                else
                {
                    break;
                }
                Console.WriteLine("--------------from array 3");
                Console.WriteLine();
            }



            for (int i = n2; i < q; i++)
            {
                if (i < array4)
                {

                    Console.Write(d[i] + ",");
                    n2 = i + 1;

                }
                else
                {
                    break;
                }
                Console.WriteLine("--------------from array 4");
                Console.WriteLine();
            }

           
            for (int i = n3; i < q; i++)
            {
                if (i < array5)
                {

                    Console.Write(m[i] + ",");
                    n3 = i + 1;

                }
                else
                {
                    break;
                }
                Console.WriteLine("--------------from array 5");
                Console.WriteLine();
            }

            q = q + f;
            // q =q+q;
            goto l1;
        }
    }
}
