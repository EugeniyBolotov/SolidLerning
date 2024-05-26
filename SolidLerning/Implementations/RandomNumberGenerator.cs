using SolidLerning.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidLerning.Implementations
{
    internal class RandomNumberGenerator : IRandomNumberGenerator
    {
        private readonly Random _random;

        public RandomNumberGenerator()
        {
            _random = new Random();
        }

        public int GenerateNumber(int min, int max)
        {
            return _random.Next(min, max + 1);
        }
    }
}
