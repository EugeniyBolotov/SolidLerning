using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidLerning.Abstractions
{
    internal interface IValidation
    {
        bool ValidateInt(string value, out int guessedNumber);
    }
}
