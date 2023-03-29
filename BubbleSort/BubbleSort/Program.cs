// See https://aka.ms/new-console-template for more information
using BubbleSort.Library;

Console.WriteLine("Please enter the numbers to be sorted");
Console.WriteLine("Write \"finish\" to end");

string input;
var numbers = new List<int>();

do
{
    input = Console.ReadLine();
    if (int.TryParse(input, out int number))
    {
        numbers.Add(number);
    }

} while (!input.Equals("finish"));

BubbleSortManager manager = new(numbers);
var newList = manager.Sort();
Console.WriteLine(String.Join(',', newList));
Console.ReadKey();