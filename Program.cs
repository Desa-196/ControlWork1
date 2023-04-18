
//Функция выводит сообщение message и ожидает ввода числа с проверкой, что ввели число.
int read_int_from_console(string message)
{
    int console_int = 0;

    Console.Write($"{message}: ");

    while(true)
    {
        if( int.TryParse(Console.ReadLine(), out console_int ) )
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
