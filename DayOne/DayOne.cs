namespace AdventOfCode2022.DayOne;

public class DayOne
{
    public static void Day1()
    {
        var lines = File.ReadAllLines("""F:\Programmieren\AdventOfCode2022\DayOne\input.txt""");

        var currCal = 0;
        var calList = new List<int>();

        foreach (var line in lines)
        {
            if (line != string.Empty)
            {
                currCal += int.Parse(line);
            }

            if (line != string.Empty) continue;
            calList.Add(currCal);
            currCal = 0;
        }

        Console.WriteLine($"{calList.OrderDescending().Take(3).Sum()}");
    }
}