using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Привет!");
        Console.WriteLine("Глазков Александр Юрьевич");
        Console.WriteLine("ИСП-242");
        Console.WriteLine("26.10.2026");

        Console.WriteLine("Меню:");
        Console.WriteLine("1 - Показать ФИО");
        Console.WriteLine("2 - Показать группу");
        Console.WriteLine("3 - Показать дату");
        Console.WriteLine("4 - Выход");
        Console.Write("Выберете: ");
        int i = Convert.ToInt32(Console.ReadLine());
        switch (i)
        {
            case 1:
                Console.WriteLine("Глазков Александр Юрьевич");
                break;
            case 2:
                Console.WriteLine("ИСП-242");
                break;
            case 3:
                Console.WriteLine("26.10.2026");
                break;
            case 4:
                Console.WriteLine("До свидания!");
                return;
        }
    }
}