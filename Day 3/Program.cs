int Part1()
{
    int gamma_rate = 0;
    int epsilon_rate = 0;

    const int bin = 12;

    var something = new int[bin];

    foreach (var line in File.ReadLines(path: "input.txt"))
    {
        for (var i = 0; i < bin; i++)
        {
            if (line[i] == '1')
                something[i]++;
        }
    }

    for (var i = 0; i < something.Length;i++)
    {
        gamma_rate += something[bin - i - 1] / 500 * (1 << i);
    }

    epsilon_rate = ~gamma_rate & 0xFFF;

    return gamma_rate * epsilon_rate;
}

Console.WriteLine("{0}", Part1());
Console.ReadLine();