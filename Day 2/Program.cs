int Part1()
{
    int depth = 0;
    int horizontal = 0;

    foreach (var line in File.ReadLines(path: "input.txt"))
    {
        var something = line.Split(' ');

        if (something[0] == "forward")
            horizontal = horizontal + int.Parse(something[1]);
        else if (something[0] == "down")
            depth = depth + int.Parse(something[1]);
        else if (something[0] == "up")
            depth = depth - int.Parse(something[1]);
    }

    return depth * horizontal;
}

int Part2()
{
    int depth = 0;
    int horizontal = 0;
    int aim = 0;

    foreach (var line in File.ReadLines(path: "input.txt"))
    {
        var something = line.Split(' ');

        if (something[0] == "forward")
        {
            horizontal = horizontal + int.Parse(something[1]);
            depth = depth + (int.Parse(something[1]) * aim);
        }
        else if (something[0] == "down")
            aim = aim + int.Parse(something[1]);
        else if (something[0] == "up")
            aim = aim - int.Parse(something[1]);
    }

    return depth * horizontal;
}

Console.WriteLine("Depth multiplied by horizontal position is {0}", Part1());
Console.WriteLine("Depth multiplied by horizontal position while using aimbot is {0}", Part2());
Console.ReadLine();