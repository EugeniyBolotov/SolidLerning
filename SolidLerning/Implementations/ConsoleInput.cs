using SolidLerning.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidLerning.Implementations
{
    internal class ConsoleInput: IInput
    {
        public string ReadLine()
        {
            return Console.ReadLine();
        }
    }
}
