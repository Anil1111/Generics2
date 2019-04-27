using System;
using System.Collections.Generic;

   class Program
    {
        static void Main(string[] args)
        {
            var langs = new List<string>();

            langs.Add("Pascal");
            langs.Add("Simula");
            langs.Add("Pearl");
            langs.Add("Java");
            langs.Add("C#");
            langs.Add("C");
            langs.Add("C++");
            langs.Add("Ruby");
            langs.Add("Javascript");

            

            langs.Remove("C++");
           

            Console.WriteLine(langs.Contains("C#"));

            langs.Insert(4, "Haskell");

            langs.Sort();

            foreach (string lang in langs)
            {
                Console.WriteLine(lang);
            }
        }
    }

