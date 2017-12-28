using System;

using Task_3_ArturDovbysh.VectorLogic;

namespace Task_3_ArturDovbysh.Program
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                RunDemo();
            }
            catch (Exception e)
            {
                Console.WriteLine("Demo error {0}, in {1}", e.Message, e.TargetSite);
            }

        }


        static void RunDemo()
        {
            CreationDemo();
            ComparingDemo();
            AddingAndSubtractionDemo();
        }

        static void CreationDemo()
        {
            Console.WriteLine("Creation Demo");

            try
            {
                var v1 = new Vector();
                v1.AddElement(1);
                v1.AddElement(2);

                int[] arr = { 1, 2 };
                var v2 = new Vector(arr);

                Console.WriteLine("Vector 1 was created!");
                PrintVectorInfo(v1);

                Console.WriteLine("Vector 2 was created!");
                PrintVectorInfo(v2);
            }
            catch (Exception e)
            {
                throw e;
            }

            Console.WriteLine(new string('-',30));
        }

        static void ComparingDemo()
        {
            Console.WriteLine("Comparing Demo");

            try
            {
                var v1 = new Vector();
                v1.AddElement(1);
                v1.AddElement(2);

                int[] arr = { 1, 2 };
                var v2 = new Vector(arr);

                Console.WriteLine("Vector 1");
                PrintVectorInfo(v1);

                Console.WriteLine("Vector 2");
                PrintVectorInfo(v2);

                //check compare operators work
                Console.WriteLine("Vector 1 > Vector 2 : {0}",v1 > v2);
                Console.WriteLine("Vector 1 = Vector 2 : {0}", v1 == v2);
                Console.WriteLine("Vector 1 != Vector 2 : {0}", v1 != v2);
                Console.WriteLine("Vector 1 < Vector 2 : {0}", v1 < v2);

            }
            catch (Exception e)
            {
                throw e;
            }

            Console.WriteLine(new string('-', 30));
        }

        static void AddingAndSubtractionDemo()
        {
            Console.WriteLine("Operations Demo");

            try
            {
                var v1 = new Vector();
                v1.AddElement(1);
                v1.AddElement(2);

                int[] arr = { 1, 2 };
                var v2 = new Vector(arr);

                Console.WriteLine("Vector 1");
                PrintVectorInfo(v1);

                Console.WriteLine("Vector 2");
                PrintVectorInfo(v2);

                Vector v3 = v1 + v2;

                Console.WriteLine("Vector 1 + Vector 2 = Vector 3");
                PrintVectorInfo(v3);

                v3 = v3 - v1;

                Console.WriteLine("Vector 3 - Vector 1 = Vector 2");
                PrintVectorInfo(v2);

                v3 = v3 * 0;

                Console.WriteLine("Vector 3 * 0 = zero vector");
                PrintVectorInfo(v3);
            }
            catch(Exception e)
            {
                throw e;
            }

            Console.WriteLine(new string('-',30));

        }

        static void PrintVectorInfo(Vector vec)
        {
            Console.Write("Vector : ");

            for(int i = 0; i < vec.Length; i++)
                Console.Write(string.Concat(vec[i], " "));
            
            Console.WriteLine();
        }
    }
}
