int Part1()
{
    int gamma_rate = 0;
    int epsilon_rate = 0;

    const int bit = 12;

    var colum = new int[bit];

    foreach (var line in File.ReadLines(path: "input.txt"))
    {
        for (var i = 0; i < bit; i++)
        {
            if (line[i] == '1')
                colum[i]++;
        }
    }

    for (var i = 0; i < colum.Length;i++)
    {
        gamma_rate += colum[bit - i - 1] / 500 * (1 << i);
    }

    epsilon_rate = ~gamma_rate & 0xFFF;

    return gamma_rate * epsilon_rate;
}

void Part2()
{
    var input = File.ReadAllLines(path:"input.txt").ToList();
    var oxygenOutput = Convert.ToInt32(GetOutput(input, true), 2);
    var co2Output = Convert.ToInt32(GetOutput(input, false), 2);

    Console.WriteLine($"Oxygen generator rating = {oxygenOutput}, CO2 scrubber rating = {co2Output}");
    Console.WriteLine($"Life support raiting: {oxygenOutput * co2Output}");
}

List<string> FilterCommon(List<string> Old, int bit, Char num)
{
    return Old.Where(x => GetBit(x, bit) == num).ToList();
}

string GetOutput(List<string> bitStrings, bool usebest)
{
    var colum = new int[12];
    for (var i = 0; i < colum.Length; i++)
    {
        int Count0 = 0;
        int Count1 = 0;
        char best = '0';
        foreach (var line in bitStrings)
        {
            if (line[i] == '1')
                Count1++;
            if (line[i] == '0')
                Count0++;
        }
        if (Count0 > Count1)
            best = '0';
        else
            best = '1';
        if (!usebest)
            if (best == '1')
                best = '0';
            else
                best = '1';
        bitStrings = FilterCommon(bitStrings, i, best);
        if (bitStrings.Count == 1)
            return bitStrings[0];
    }
    throw new Exception();
}

char GetBit(string line, int index)
{
    return line[index];
}





Console.WriteLine("Power consupmtion: {0}", Part1());
Part2();

Console.ReadLine();