﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsC_.FactoryPattern
{
    public class WordDocument : IDocument
    {
        public void Print()
        {
            Console.WriteLine("Printing Word document...");
        }
    }
}
