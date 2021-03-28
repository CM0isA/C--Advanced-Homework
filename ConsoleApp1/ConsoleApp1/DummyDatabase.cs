using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class DummyDatabase
    {
        private bool IsConnected = false;
        private bool AttemptedConnectiion = false;
        private List<string> words = new List<string>();

        public DummyDatabase()
        {
            words.Capacity = 5;
        }

        public void Connect() {
            Random random = new Random();
            int con = random.Next(1, 5);
            try
            {
                if (con == 5)
                {
                    throw new DummyDatabaseConnectionException("Connection Failed\n" + "Please try again");
                }
                else
                    IsConnected = true;

            }
            catch(DummyDatabaseConnectionException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                AttemptedConnectiion = true;
            }
        }

        public void Disconnect()
        {
            if (AttemptedConnectiion == false)
                throw new NonExistentConnectionException("The connection doesn't exists");
            else
                IsConnected = false;
        }

        public void Save(string wordToSave)
        {
            if (wordToSave == null)
                throw new ArgumentNullException();
            else
            if (IsConnected == true)
            {
                if (words.Count == words.Capacity)
                {
                    Console.WriteLine("Select the item you want to override:");
                    Print();

                    Console.WriteLine("Specify the item to replace");
                    string a = Console.ReadLine();
                    words[words.FindIndex(ind => ind.Equals(a))] = wordToSave;
                }
                else
                    words.Add(wordToSave);
            }
            else
                throw new NonExistentConnectionException("The connection could not be established for this operation.");
        }

        public void Print()
        {
            for (int i = 0; i < words.Count; i++)
                Console.WriteLine(words[i]);
        }
    }
}
