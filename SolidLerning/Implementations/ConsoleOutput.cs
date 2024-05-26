using SolidLerning.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidLerning.Implementations
{
    internal class ConsoleOutput: IOutput
    {
        public void PrintValue(string value) 
        {
            Console.WriteLine(value);
        }
    }
}
