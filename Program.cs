Console.WriteLine("enter numbers : ");
var stringNums = Console.ReadLine();

var arrNums = stringNums.Split(' ');

var intNums = new List<int>();

foreach (var item in arrNums)
{
    intNums.Add(int.Parse(item));
}

var finalNums = new List<int>();
var count = intNums.Count;

for (int i = 0; i < count; i += 2)
{
    if (i == count - 1 && count % 2 != 0)
    {
        finalNums.Add(intNums[i]);
    }
    else
    {

        finalNums.Add(intNums[i] + intNums[i + 1]);

    }
}

Console.WriteLine(string.Join(',', finalNums));