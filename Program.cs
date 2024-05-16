// See https://aka.ms/new-console-template for more information
var counter = 0;
var max = 250;
while (counter < max)
{
    Console.WriteLine($"Counter test: {++counter}");
    await Task.Delay(TimeSpan.FromMilliseconds(1_000));
    ++counter;
}
