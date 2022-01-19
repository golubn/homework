//матрицы методы
Console.WriteLine("Введите количетво строк:\n");
int rows = Int32.Parse(Console.ReadLine());
Console.WriteLine("Введите количетво столбцов:\n");
int columns = Int32.Parse(Console.ReadLine());
Console.WriteLine("1.Заполнить матрицу рандомными числами\n2.Заполнить матрицу вручную\n");
var ch = Console.ReadLine();
int[,] numbers = new int[rows, columns];
switch (ch)
{
    case "1":
        RandomFilling(in rows, in columns, numbers);
        Shown(rows, columns, numbers);
        Console.WriteLine();
        break;
    case "2":
        ManuallyFilling(in rows, in columns, numbers);
        Shown(rows, columns, numbers);
        Console.WriteLine();
        break;
}
bool breakFlag = false;
while (!breakFlag)
{
    Console.WriteLine("1.Положительные элементы\n2.Отрицательные элементы\n3.Сортировка построчно\n4.Инверсия элементов матрицы построчно\n5.Выход из программы\n");
    var chs = Console.ReadLine();
    switch (chs)
    {
        case "1":
            PositiveShown(rows, columns, ref numbers);
            break;
        case "2":
            NegativeShown(rows, columns, ref numbers);
            break;
        case "3":
            AscendingSort(in rows, in columns, ref numbers);
            Console.WriteLine("По возрастанию:\n");
            Shown(rows, columns, numbers);
            Console.WriteLine();
            DescendingSort(in rows, in columns, ref numbers);
            Console.WriteLine("По убыванию:\n");
            Shown(rows, columns, numbers);
            break;
        case "4":
            InversionSort(in rows, in columns, ref numbers);
            Shown(rows, columns, numbers);
            break;
        case "5":
            breakFlag = true;

            break;

    }
}

static void Shown(int rows, int columns, int[,] numbers)
{
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Console.Write(numbers[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

static void RandomFilling(in int rows, in int columns, int[,] numbers)
{
    var rand = new Random();
    for (var i = 0; i < rows; ++i)
    {
        for (var j = 0; j < columns; ++j)
        {
            numbers[i, j] = rand.Next() % 100;
        }
    }
}

static void ManuallyFilling(in int rows, in int columns, int[,] numbers)
{
    for (var i = 0; i < rows; ++i)
    {
        for (var j = 0; j < columns; ++j)
        {
            numbers[i, j] = int.Parse(Console.ReadLine());
        }
    }
}

static void PositiveShown(int rows, int columns, ref int[,] numbers)
{
    for (var i = 0; i < rows; ++i)
    {
        for (var j = 0; j < columns; ++j)
        {
            if (numbers[i, j] > 0) Console.WriteLine($"{numbers[i, j]}");
        }
    }
}

static void NegativeShown(int rows, int columns, ref int[,] numbers)
{
    for (var i = 0; i < rows; ++i)
    {
        for (var j = 0; j < columns; ++j)
        {
            if (numbers[i, j] < 0) Console.WriteLine($"{numbers[i, j]}");
        }
    }
}

static void AscendingSort(in int rows, in int columns, ref int[,] numbers)
{
    for (var i = 0; i < rows; ++i)
    {
        for (var j = 0; j < columns; ++j)
        {
            for (int k = 0; k < columns - j - 1; k++)
            {
                if (numbers[i, k] > numbers[i, k + 1])
                {
                    int temp = numbers[i, k];
                    numbers[i, k] = numbers[i, k + 1];
                    numbers[i, k + 1] = temp;
                }
            }
        }
    }
}

static void DescendingSort(in int rows, in int columns, ref int[,] numbers)
{
    for (var i = 0; i < rows; ++i)
    {
        for (var j = 0; j < columns; ++j)
        {
            for (int k = 0; k < columns - j - 1; k++)
            {
                if (numbers[i, k] < numbers[i, k + 1])
                {
                    int temp = numbers[i, k];
                    numbers[i, k] = numbers[i, k + 1];
                    numbers[i, k + 1] = temp;
                }
            }
        }
    }
}

static void InversionSort(in int rows, in int columns, ref int[,] numbers)
{
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            for (int k = columns - 1; k >= j; j++)
            {
                int temp = numbers[i, j];
                numbers[i, j] = numbers[i, k];
                numbers[i, k] = temp;
                k--;
            }


        }
        Console.WriteLine();
    }
}