// See https://aka.ms/new-console-template for more information
using SolidLerning.Abstractions;
using SolidLerning.Implementations;

IRandomNumberGenerator randomNumberGenerator = new RandomNumberGenerator();
IInput input = new ConsoleInput();
IOutput output = new ConsoleOutput();
IValidation validation = new Validation();
IGame guessingGame = new GuessNumberGame(randomNumberGenerator, output, input, validation);
guessingGame.RunGame();

Console.ReadLine();
