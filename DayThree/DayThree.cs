namespace AdventOfCode2022.DayThree;

public class DayThree
{
    private static int _sum = 0;
    private static readonly string[] _rucksack = File.ReadAllLines(@"F:\Programmieren\AdventOfCode2022\DayThree\input.txt");
    public static void Task1()
    {
        
        foreach (var item in _rucksack) 
        {
            var compartmentOne = item[..(item.Length / 2)];
            var compartmentTwo = item[(item.Length / 2) ..];

            var duplicate = compartmentOne.Intersect(compartmentTwo);
            foreach (var letter in duplicate)
            {
                if (char.IsLower(letter)) _sum += (int)letter - 96;
                else _sum += (int)letter - 38;
            }
        }
        Console.WriteLine($"Sum: {_sum}");
    }
}