int Part1()
{
    int counter = 0;

    var file = File.ReadAllLines(path: "input.txt");

    var prev_num = int.Parse(file[0]);

    for (int i = 1; i < file.Length; i++)
    {
        var curr_num = int.Parse(file[i]);

        if (curr_num > prev_num)
            counter++;
        prev_num = curr_num;
    }
    return counter;
}

int Part2()
{
    int counter = 0;

    var file = File.ReadAllLines(path: "input.txt");

    var prev_num1 = int.Parse(file[0]);
    var prev_num2 = int.Parse(file[1]);
    var prev_num3 = int.Parse(file[2]);
    for (int i = 3; i < file.Length; i++)
    {
        var curr_num = int.Parse(file[i]);

        if (prev_num1 + prev_num2 + prev_num3 < curr_num + prev_num2 + prev_num3)
            counter++;

        prev_num1 = prev_num2;
        prev_num2 = prev_num3;
        prev_num3 = curr_num;
    }

    return counter;
}

Console.WriteLine("Part 1 has {0} greater numbers", Part1());
Console.WriteLine("Part 2 has {0} greater lines", Part2());
Console.ReadLine();