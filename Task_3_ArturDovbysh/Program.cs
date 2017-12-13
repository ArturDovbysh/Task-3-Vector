using System;
using System.Reflection;


namespace Task_3_ArturDovbysh
{
    class Program
    {
        static void Main(string[] args)
        {
            

            var v1 = new Vector();
            v1.AddElement(1);
            v1.AddElement(2);

            int[] arr = { 1, 2 };
            var v2 = new Vector(arr);
            

            try
            {
                //check compare operators work
                Console.WriteLine(v1 > v2);
                Console.WriteLine(v1 == v2);
                Console.WriteLine(v1 != v2);
                Console.WriteLine(v1 < v2);

                
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }


            try
            {

                //check adding, subtracting and multiplying by number operator
                //and also check indexer's work
                Vector newVec = v1 + v2;

                Console.WriteLine("Adding operator");
                for(int i = 0; i < newVec.Length; i++)
                    Console.WriteLine(newVec[i]);

                Console.WriteLine("Subtracting operator");
                newVec = newVec - v1;
                for (int i = 0; i < newVec.Length; i++)
                    Console.WriteLine(newVec[i]);

                Console.WriteLine("Multiplying operator");
                newVec = newVec * 0;
                for (int i = 0; i < newVec.Length; i++)
                    Console.WriteLine(newVec[i]);


           
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
