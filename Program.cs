
//Функция выводит сообщение message и ожидает ввода числа с проверкой, что ввели число.
int ReadIntFromConsole(string message)
{
    int console_int = 0;

    Console.Write($"{message}: ");

    while (true)
    {
        if (int.TryParse(Console.ReadLine(), out console_int))
        {
            break;
        }
        else
        {
            Console.Write("Введено некорректное число, повторите попытку ввода:");
        }
    }
    return console_int;

}
//Функция возвращает кол-во элементов в массиве длинна строки которых <= 3
int CountResultElements(string[] stringArray)
{
    int countElements = 0;
    foreach (string element in stringArray)
    {
        if (element.Length <= 3) countElements++;
    }
    return countElements;
}

//Функция возвращает массив из элементов длинна строки которых <= 3
string[] GetResulElements(string[] stringArray)
{
    string[] resultArray = new string[CountResultElements(stringArray)];

    int i = 0;
    foreach (string element in stringArray)
    {
        if (element.Length <= 3)
        {
            resultArray[i] = element;
            i++;
        }
    }

    return resultArray;
}


/*Вариант решения с помощью LINQ

string[] GetResulElements(string[] stringArray)
{
    return stringArray.Where(o => o.Length <= 3).ToArray();
}
*/

//Функция запрашивает ввод n строк для заполнения массива
string[] FillArray(int n)
{
    string[] resultArray = new string[n];

    for (int i = 0; i < n; i++)
    {
        Console.Write($"Введите строку для {i}-го элемента массива: ");
        string? readString = Console.ReadLine();
        //Если приняли null то запишем пустую строку
        resultArray[i] = readString==null?"":readString;
    }
    return resultArray;
}

Console.WriteLine("Программа выводит из введенного массива все элементы длинна строки которых <= 3");

string[] readArray = new string[ ReadIntFromConsole("Введите кол-во элементов массива") ];

readArray = FillArray( readArray.Length );

Console.WriteLine(string.Join(",", GetResulElements(readArray)));