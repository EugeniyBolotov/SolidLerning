using SolidLerning.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace SolidLerning.Implementations
{
    internal class GuessNumberGame: IGame
    {
        private int minNumber;
        private int maxNumber;
        private int targetNumber;
        private int attempts;
        private IRandomNumberGenerator randomNumberGenerator;
        private IOutput output;
        private IInput input;
        private IValidation validation;
        public GuessNumberGame(IRandomNumberGenerator randomNumberGenerator, IOutput output, IInput input, IValidation validation)
        {
            this.randomNumberGenerator = randomNumberGenerator;
            this.output = output;
            this.input = input;
            this.validation = validation;

            attempts = 0;
        }

        public void RunGame()
        {
            output.PrintValue(@"Привет, это игра ""Угадай число""!");

            InputNumbersInterval();

            targetNumber = randomNumberGenerator.GenerateNumber(minNumber, maxNumber);

            output.PrintValue($"Отлчно, теперь попробуйте отгадать число в интервале {minNumber} - {maxNumber}!");

            int guessedNumber;
            do
            {
                output.PrintValue("Введите число: ");

                if (validation.ValidateInt(input.ReadLine(), out guessedNumber))
                {
                    CompareNumber(guessedNumber);
                }

            } while (guessedNumber != targetNumber);

            output.PrintValue("Поздравляю! Вы угадали число!");
            output.PrintValue($"Вы потратили {attempts} попыток.");
        }
        private void CompareNumber(int number)
        {
            attempts++;

            if (number < minNumber || number > maxNumber)
            {
                output.PrintValue("Будте внимательней! Вы ввели число вне интервала.");
            }
            else if (number < targetNumber)
            {
                output.PrintValue("Загаданное число больше.");
            }
            else if (number > targetNumber)
            {
                output.PrintValue("Загаданное число меньше.");
            }
        }

        private void InputNumbersInterval()
        {
            output.PrintValue("Вам необходимо указать интервал в котором будете угадывать число.");

            bool isValid;
            do
            {
                output.PrintValue("Укажите минимальное число:");

                isValid = validation.ValidateInt(input.ReadLine(), out minNumber);

                if(!isValid) output.PrintValue("Неккоректный ввод! Пожалуйста, введите целое число.");

            } while (!isValid);

            do
            {
                output.PrintValue("Укажите максимальное число:");

                isValid = validation.ValidateInt(input.ReadLine(), out maxNumber);

                if (!isValid) output.PrintValue("Неккоректный ввод! Пожалуйста, введите целое число.");

                if (maxNumber < minNumber && isValid)
                {
                    output.PrintValue("Максимальное число не может быть меньше минимального!");
                    isValid = false;
                }
            } while (!isValid);
        }
    }
}
