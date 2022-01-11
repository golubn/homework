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
        var rand = new Random();
        for (var i = 0; i < rows; ++i)
        {
            for (var j = 0; j < columns; ++j)
            {
                numbers[i, j] = rand.Next() % 100;
            }
        }
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.Write(numbers[i, j] + "\t");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
        break;
    case "2":
        for (var i = 0; i < rows; ++i)
        {
            for (var j = 0; j < columns; ++j)
            {
                numbers[i, j] = int.Parse(Console.ReadLine());
            }
        }
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.Write(numbers[i, j] + "\t");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
        break;
}

Console.WriteLine("1.Положительные элементы\n2.Отрицательные элементы\n3.Сортировка построчно\n4.Инверсия элементов матрицы построчно\n");
var chs = Console.ReadLine();
switch (chs)
{
    case "1":
        for (var i = 0; i < rows; ++i)
        {
            for (var j = 0; j < columns; ++j)
            {
                if (numbers[i, j] > 0) Console.WriteLine($"{numbers[i, j]}");
            }
        }
        break;
    case "2":
        for (var i = 0; i < rows; ++i)
        {
            for (var j = 0; j < columns; ++j)
            {
                if (numbers[i, j] < 0) Console.WriteLine($"{numbers[i, j]}");
            }
        }
        break;
    case "3":

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
        Console.WriteLine("По возрастанию:\n");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {

                Console.Write(numbers[i, j] + "\t");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
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
        Console.WriteLine("По убыванию:\n");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {

                Console.Write(numbers[i, j] + "\t");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
        break;
    case "4":
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                for (int k = columns - 1; k > j; k--)
                {
                    int temp = numbers[i, j];
                    numbers[i, j] = numbers[i, k];
                    numbers[i, k] = temp;
                    j++;
                }


            }
            Console.WriteLine();
        }
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {

                Console.Write(numbers[i, j] + "\t");
            }
            Console.WriteLine();
        }
        break;

}

