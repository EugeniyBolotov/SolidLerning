using SolidLerning.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidLerning.Implementations
{
    internal class Validation: IValidation
    {
        public bool ValidateInt(string value, out int guessedNumber)
        {
            if (int.TryParse(value, out guessedNumber))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
