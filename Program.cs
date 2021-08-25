using DesignPatterns.Patrones;
using System;
using System.Threading;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            PatronSingleton("Con sigleton", "Sin singleton");

            //Console.ReadLine();
        }

        #region LLAMADA AL PATRON SINGLETON

        public static void PatronSingleton(string param1, string param2)
        {
            // The client code.

            Console.WriteLine(
                "{0}\n{1}\n\n{2}\n",
                "Si se observa el mismo valor, entonces singleton fue reutilizado :D",
                "Si no se observa el mismo valor, entonces singleton no fue reutilizado :(",
                "RESULT:"
            );

            Thread process1 = new Thread(() => { TestSingleton(param1); });
            Thread process2 = new Thread(() => { TestSingleton(param2); });

            process1.Start();
            process2.Start();

            process1.Join();
            process2.Join();
        }

        public static void TestSingleton(string v)
        {
            Singleton singleton = Singleton.GetInstance(v);
            Console.WriteLine(singleton.Value);
        }
        #endregion

    }
}
