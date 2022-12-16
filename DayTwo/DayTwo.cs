namespace AdventOfCode2022.DayTwo;

public class DayTwo
{
    private static readonly string[] List = File.ReadAllLines(@"F:\Programmieren\AdventOfCode2022\DayTwo\input.txt");
    private static int _score = 0;

    private static readonly List<string> Rock = new() { "A", "X" };      // 1
    private static readonly List<string> Paper = new() { "B", "Y" };     // 2 
    private static readonly List<string> Scissors = new() { "C", "Z" };  // 3

    public static void Task1()
    {
        foreach (var chars in List
                     .Select(lines => lines
                         .Split(' ').ToList()))
        {
            if (Rock.Contains(chars[0]) && Rock.Contains(chars[1])) _score += 4;
            if (Rock.Contains(chars[0]) && Paper.Contains(chars[1])) _score += 8;
            if (Rock.Contains(chars[0]) && Scissors.Contains(chars[1])) _score += 3;
            
            if (Paper.Contains(chars[0]) && Rock.Contains(chars[1])) _score += 1;
            if (Paper.Contains(chars[0]) && Paper.Contains(chars[1])) _score += 5;
            if (Paper.Contains(chars[0]) && Scissors.Contains(chars[1])) _score += 9;
            
            if (Scissors.Contains(chars[0]) && Rock.Contains(chars[1])) _score += 7;
            if (Scissors.Contains(chars[0]) && Paper.Contains(chars[1])) _score += 2;
            if (Scissors.Contains(chars[0]) && Scissors.Contains(chars[1])) _score += 6;
        }

        Console.WriteLine(_score);
    }

    public static void Task2()
    {
        foreach (var chars in List
                     .Select(lines => lines
                         .Split(' ').ToList()))
        {
            if (chars[1] == "X" && Rock.Contains(chars[0])) _score += 3;
            if (chars[1] == "X" && Paper.Contains(chars[0])) _score += 1;
            if (chars[1] == "X" && Scissors.Contains(chars[0])) _score += 2;
            
            if (chars[1] == "Y" && Rock.Contains(chars[0])) _score += 4;
            if (chars[1] == "Y" && Paper.Contains(chars[0])) _score += 5;
            if (chars[1] == "Y" && Scissors.Contains(chars[0])) _score += 6;
            
            if (chars[1] == "Z" && Rock.Contains(chars[0])) _score += 8;
            if (chars[1] == "Z" && Paper.Contains(chars[0])) _score += 9;
            if (chars[1] == "Z" && Scissors.Contains(chars[0])) _score += 7;
        }

        Console.WriteLine(_score);
    }
} 