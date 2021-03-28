using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
            DummyDatabase dummyDatabase = new DummyDatabase();


            //dummyDatabase.Disconnect();
            dummyDatabase.Connect();
            dummyDatabase.Save("something");

            dummyDatabase.Disconnect();
            dummyDatabase.Print();
            Console.Read();


        }
    }
}
