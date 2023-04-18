
//Функция выводит сообщение message и ожидает ввода числа с проверкой, что ввели число.
int read_int_from_console(string message)
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
//Функция запрашивает ввод n строк для заполнения массива
string[] FillArray(int n)
{
    string[] resultArray = new string[n];

    for (int i = 0; i < n; i++)
    {
        Console.Write($"\nВведите строку для {i}-го элемента массива: ");
        string? readString = Console.ReadLine();
        //Если приняли null то запишем пустую строку
        resultArray[i] = readString==null?"":readString;
    }
    return resultArray;
}