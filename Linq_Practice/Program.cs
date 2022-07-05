List<int> num = new List<int>() {36, 71, 12,
                            15, 29, 18, 27, 17, 9, 34};

var newNum1 = num.FindAll(x => (x % 3) == 0);

var newNum2 = num.OrderByDescending(x => (x % 2) == 0);

var newNum3 = num.Select(x => x * x);

foreach(int number in newNum1)
{
    Console.WriteLine(number + " ");
}

Console.WriteLine();

foreach (int number in newNum2)
{
    Console.WriteLine(number + " ");
}

Console.WriteLine();

foreach (int number in newNum3)
{
    Console.WriteLine(number + " ");
}