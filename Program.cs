// int age = 15;
// if (age >= 21) {
//     Console.WriteLine("Доступ разрешён");
// }
// Console.WriteLine("Программа продолжает работу");


// int age = 15;
// if (age >= 18) {
//     Console.WriteLine("Доступ разрешён");
// } else {
//     Console.WriteLine("Доступ запрещён");
//     System.Console.WriteLine($"осталось лет до совершеннолетия: {18 - age}");
// }


// int age = 60;
// if (age < 13)
// {
//     Console.WriteLine("Ребёнок");
// }
// else if (age < 18)
// {
//     Console.WriteLine("Подросток");
// }
// else if (age < 60)
// {
//     Console.WriteLine("Взрослый");
// }
// else
// {
//     System.Console.WriteLine("Пенсионер");
// } // задание 3 


// int age = 16;
// double height = 1.4;
// bool starsh = true;
// if (age >= 14 && height >= 1.5)
// {
//     Console.WriteLine("Можно кататься");
// }
// else if (height < 1.5 && starsh){
//     System.Console.WriteLine("Можно кататься");
// }
// else
// {
//     Console.WriteLine("Пока нельзя");
// } // задание 4

// switch (day) {
//     case 1:
//         dayName = "Понедельник";
//         break;
//     case 2:
//         dayName = "Вторник";
//         break;
//     default:
//         dayName = "Другой день";
//         break;
// }


// System.Console.WriteLine();
// System.Console.WriteLine("задание А");

// Console.Write("Введите число: ");
// double chislo = double.Parse(Console.ReadLine());

// if (chislo % 2 == 0)
// {
//     System.Console.WriteLine("Число четное");
// }
// else
// {
//     System.Console.WriteLine("Число не четное");
// }

// System.Console.WriteLine();
// System.Console.WriteLine("Задание Б");


// Console.Write("Введите число: ");
// int chisloOne = int.Parse(Console.ReadLine());

// if (chisloOne == 5)
// {
//     System.Console.WriteLine("Отлично");
// }
// else if (chisloOne == 4)
// {
//     System.Console.WriteLine("Хорошо");
// }
// else if (chisloOne == 3)
// {
//     System.Console.WriteLine("Удовлетворительно");
// }
// else if (chisloOne == 2)
// {
//     System.Console.WriteLine("Неудовлетворительно");
// }
// else
// {
//     System.Console.WriteLine("Вы ввели не правильное число");
// }


// Console.Write("Введите свою фамилию: ");
// string surname = Console.ReadLine()!.Trim();

// if (string.IsNullOrEmpty(surname)) {
//     Console.WriteLine("Фамилия не введена. Завершение работы.");
//     return;
// }

// Random rnd = new(surname.GetHashCode() + DateTime.Now.DayOfYear);

// var assigned = Enumerable.Range(1, 10)
//     .OrderBy(_ => rnd.Next())
//     .Take(2)
//     .OrderBy(x => x)
//     .ToList();

// Console.WriteLine($"Задачи: №{assigned[0]} и №{assigned[1]}");


System.Console.WriteLine();
System.Console.WriteLine("Задание 3");

System.Console.Write("Введите месяц года: ");
int mes = int.Parse(Console.ReadLine());

string mess = mes switch
{
    12 or 1 or 2 => "зима",
    3 or 4 or 5 => "весна",
    6 or 7 or 8 => "лето",
    9 or 10 or 11 => "осень",
    _ => "Вы ввели не правильно "
};
System.Console.WriteLine(mess);


System.Console.WriteLine();
System.Console.WriteLine("Задание 6");

Console.Write("Введите количество баллов: ");
int balls = int.Parse(Console.ReadLine());

if (balls >= 90 && balls <= 100)
{
    System.Console.WriteLine("Отлично");
}
else if (balls >= 75 && balls <= 89)
{
    System.Console.WriteLine("Хорошо");
}
else if (balls >= 60 && balls <= 74)
{
    System.Console.WriteLine("Удовлетворительно");
}
else if (balls < 60)
{
    System.Console.WriteLine("Неудовлетворительно");
}
else
{
    System.Console.WriteLine("Не верное значение");
}