﻿using System;
using System.Collections.Generic;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            // Note: constructors call Factory Method

            List<Document> documents = new List<Document>();

            documents.Add(new Resume());
            documents.Add(new Report());

            // Display document pages

            foreach (Document document in documents)
            {
                Console.WriteLine("\n" + document.GetType().Name + "--");
                foreach (Page page in document.Pages)
                {
                    Console.WriteLine(" " + page.GetType().Name);
                }
            }
        }
    }
}
