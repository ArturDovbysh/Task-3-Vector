using System;
using System.Reflection;
using BestLoggerEver;       //My logger.dll


namespace Task_3_ArturDovbysh
{
    class Program
    {
        static void Main(string[] args)
        {
            //logger for logging the state of an application
            Logger logger = LoggerFactory.GetLogger();
            logger.Log($"Assembly : { Assembly.GetAssembly(typeof(Program)).FullName.ToString()} started",LogLevels.Info);

            var v1 = new Vector();
            logger.Log("A new instance of vector object was created!",LogLevels.Info);
            v1.AddElement(1);
            v1.AddElement(2);

            int[] arr = { 1, 2 };
            var v2 = new Vector(arr);
            logger.Log("A new instance of vector object was created!", LogLevels.Info);

            try
            {
                //check compare operators work
                Console.WriteLine(v1 > v2);
                Console.WriteLine(v1 == v2);
                Console.WriteLine(v1 != v2);
                Console.WriteLine(v1 < v2);

                logger.Log("Compare operators works well", LogLevels.Trace);
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


                logger.Log("Adding, subtracting and multiplying operators works well!", LogLevels.Trace);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }




            logger.Log($"Assembly : { Assembly.GetAssembly(typeof(Program)).FullName.ToString()} finished", LogLevels.Info);
            logger.Dispose();
        }
    }
}
