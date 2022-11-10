// See https://aka.ms/new-console-template for more information
using System;

Console.WriteLine("Демонстрирую программы...");
start();

static void start()
{
    Console.WriteLine("Выберите 1-у из 3-х программ:");
    Console.WriteLine("Выбирет номер программы(находится в самом конце):");
    Console.WriteLine("Игра 'Угадай число' - (4)");
    Console.WriteLine("'Таблица умножения' - (5)");
    Console.WriteLine("'Вывод делителей числа' - (6)");
    Console.WriteLine("Покинуть меню выбора - (7)");
    int oper = Convert.ToInt32(Console.ReadLine());

    if (oper == 4)
    {
        chislo();

    }
    if (oper == 5)
    {
        tabliza();
    }
    if (oper == 6)
    {
        deliteli();
    }
    if (oper == 7)
    {
        vixod();
    }
}
static void chislo()
{
    Random r = new Random();
    int otvet;
    Console.WriteLine("Сейчас я загадаю число от 1 до 100, попробуй отгадать");
    Console.WriteLine("Так, я загадал число попробуй отгадать");
    int r1 = r.Next(100);
    int i;
    for (i = 0; i < 100; i++)
    {
        Console.WriteLine("Введите число:");
        otvet = Convert.ToInt32(Console.ReadLine());
        if (otvet != r1)
        {
            Console.WriteLine("Ответ - неверный");
        }
        if (otvet == r1)
        {
            Console.WriteLine("Вы угадали число за {0} попыток. Загаданное число - {i}!", i, r1);
            start();
        }
    }
    Console.WriteLine("К сожаленеию вы проиграли :(");
    start();
}
static void tabliza()
{
    Console.WriteLine("Проверка, что вы не робот!");
    Console.WriteLine("Нажмите по клавиатуре!");
    Console.ReadKey();
    var isus = new int[10, 10];
    for (int i = 0; i < 10; ++i)
    {
        for (int j = 0; j < 10; ++j)
        {
            isus[i, j] = i * j;
        }
    }
    for (int i = 0; i < 10; ++i)
    {
        for (int j = 0; j < 10; ++j)
        {
            Console.Write("{0, 3}", isus[i, j]);
        }
        Console.WriteLine();
    }
    Console.WriteLine();
    start();
}
static void deliteli()
{
    Console.WriteLine("Вы должны ввести любое число:");
    Console.WriteLine("После введеного вами числа, вам выдастся список, на что делится!");
    int delitel = 1;
    int delimoe = Convert.ToInt32(Console.ReadLine());
    while (delitel <= delimoe)
    {
        if (delimoe % delitel == 0)
        {
            Console.WriteLine("Данное число делятся на: " + delitel);
            delitel++;
        }
        else
        {
            delitel++;
        }
    }
    Console.WriteLine();
    start();
}
static void vixod()
{
    Console.WriteLine("Успешно вышли!");
}

