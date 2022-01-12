
Console.WriteLine("Введите текст:\n");
string begStr;
begStr = Console.ReadLine();
Console.WriteLine("Начальный вариант текста: " + begStr);
Console.WriteLine("Выберите действие:\n1.Найти слова с максимальным количеством цифр\n2.Найти самое длинное слово и определить, сколько раз оно было в тексте\n3.Заменить цифры словами\n4.Вывысти ? и ! предложения\n5.Просмотреть предложения без запятых\n6.Найти слова с одинаковыми первой и последней буквой\n");
int choose = Convert.ToInt32(Console.ReadLine());
switch (choose)
{
    case 1:
        char[] ras = new char[] { ' ', '.' };
        string[] tex = begStr.Split(ras, StringSplitOptions.RemoveEmptyEntries);
        foreach (string index in tex)
        {
            int Max = 0;
            int Index = 0;
            for (int i = 0; i < tex.Length; i++)
            {
                int currmax = 0;
                for (int k = 0; k < tex[i].Length; k++)
                {
                    if (char.IsNumber(tex[i][k]))
                    {
                        currmax++;
                    }
                }
                if (currmax > Max)
                {
                    Max = currmax;
                    Index = i;
                }
            }
            Console.WriteLine(tex[Index]);
        }

        break;
    case 2:
        char[] ras1 = new char[] { ' ', '.' };
        string[] tex1 = begStr.Split(ras1, StringSplitOptions.RemoveEmptyEntries);
        foreach (string index in tex1)
        {
            string maxL = "";
            for (int i = 0; i < tex1.Length; i++)
            {
                if (maxL.Length < tex1[i].Length) maxL = tex1[i];
            }
            int count = 0;
            foreach (string w in tex1)
            {
                if (w == maxL) ++count;
            }
            Console.WriteLine($"Самое длинное слово {maxL} встретилось {count} раз");
        }
        break;
    case 3:
        begStr = begStr.Replace("0", "ноль");
        begStr = begStr.Replace("1", "один");
        begStr = begStr.Replace("2", "два");
        begStr = begStr.Replace("3", "три");
        begStr = begStr.Replace("4", "четыре");
        begStr = begStr.Replace("5", "пять");
        begStr = begStr.Replace("6", "шесть");
        begStr = begStr.Replace("7", "семь");
        begStr = begStr.Replace("8", "восемь");
        begStr = begStr.Replace("9", "девять");
        Console.WriteLine(begStr);
        break;
    case 4:
        char[] rasdel = new char[] { ' ', '.' };
        string[] text = begStr.Split(rasdel, StringSplitOptions.RemoveEmptyEntries);
        foreach (string str in text)
        {
            if (str.Contains('?') == true)
            {
                Console.WriteLine(str.Trim());
            }
        }
        foreach (string str in text)
        {
            if (str.Contains('!') == true)
            {
                Console.WriteLine(str.Trim());
            }
        }

        break;
    case 5:
        char[] sep = new char[] { '?', '.', '!' };
        string[] text2 = begStr.Split(sep, StringSplitOptions.RemoveEmptyEntries);
        foreach (string str in text2)
        {
            if (!str.Contains(',') == true)
            {
                Console.WriteLine(str.Trim());
            }
        }
        break;
    case 6:
        begStr = begStr.ToLower();
        var sent = begStr.Split(new char[] { ' ', ',', '.' }, StringSplitOptions.RemoveEmptyEntries);
        int a = 0;
        bool first_letter_k = false;
        while (a < sent.Length && !first_letter_k)
        {
            if (sent[a][0] == sent[a][sent.Length - 1])
                first_letter_k = true;
            a++;
        }
        if (first_letter_k)
            Console.WriteLine(sent[a]);
        else
            Console.WriteLine("Нет таких слов");

        break;
}

