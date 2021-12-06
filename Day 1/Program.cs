int counter = 0;
int curr_num = 0;
int prev_num = int.MaxValue;



foreach (var line in File.ReadLines(path: "input.txt"))
{
    curr_num = int.Parse(line);

    if (curr_num > prev_num)
        counter++;
    prev_num = curr_num;
}

Console.WriteLine("There are greater {0} lines", counter);
Console.ReadLine();

