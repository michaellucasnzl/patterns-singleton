using System;
using app;

for (int i = 1; i <= 10; i++)
{
    var gen = NumberGenerator.Instance();
    Console.WriteLine($"Random number for iteration {i} is {gen.GetNewRandomInt()}");
}

Console.WriteLine($"Number generator was instantiated {NumberGenerator.Instance().GetInstanceCount()} time.");