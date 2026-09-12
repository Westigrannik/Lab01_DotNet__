// // // // // See https://aka.ms/new-console-template for more information
// // // // int age = 20;
// // // // double gpa = 4.5;
// // // // bool stud = true;
// // // // string name = "Ivan";



// // // // Console.WriteLine(stud);
// // // // Console.WriteLine(age);
// // // // Console.WriteLine(gpa);
// // // // Console.WriteLine(name);

// // // string first = "Вовк";
// // // string last = "Тимофей";
// // // string group = "ИСП-242";
// // // int birthYear = 2007;
// // // double gpa = 4.5;
// // // bool hasScholarship = true;
// // // int currentYear = 2026;
// // // int age = currentYear - birthYear;

// // // Console.WriteLine("Студенческое удостоверение");
// // // Console.WriteLine($"Имя: {first} {last}");
// // // Console.WriteLine($"Группа: {group}");
// // // Console.WriteLine($"Возраст: {age} лет");
// // // Console.WriteLine($"Средний бал: {gpa}");
// // // Console.WriteLine($"Стипендия: {hasScholarship}");

// // // Console.Write("\nВведите ваш любимый предмет: ");
// // // string subject = Console.ReadLine();
// // // Console.WriteLine($"Отлично! {first} любит {subject}");


// // int a = 15;
// // int b = 4;
// // Console.WriteLine($"Сумма: {a + b}");
// // Console.WriteLine($"Разность: {a - b}");
// // Console.WriteLine($"Произведение: {a * b}");
// // Console.WriteLine($"Частное(int): {a / b}");
// // Console.WriteLine($"Остаток: {a % b}");

// // double result = (double)a / b;
// // Console.WriteLine($"Частное (double): {result}");

// // Console.WriteLine(Math.Abs(-5));
// // Console.WriteLine(Math.Pow(2, 10));
// // Console.WriteLine(Math.Sqrt(144));
// // Console.WriteLine(Math.Max(10, 25));
// // Console.WriteLine(Math.Min(10, 25));
// // Console.WriteLine(Math.Round(3,567, 2));


// Console.WriteLine("Калькулятор");
// Console.Write("Введите первое число: ");
// double num1 = double.Parse(Console.ReadLine());
// Console.Write("Введите второе число: ");
// double num2 = double.Parse(Console.ReadLine());
// Console.WriteLine($"Сумма: {num1 + num2}");
// Console.WriteLine($"Разность: {num1 - num2}");
// Console.WriteLine($"Произведение: {num1 * num2}");
// if (num2 != 0)
//     Console.WriteLine($"Частное: {num1 / num2}");
// else
//     Console.WriteLine("Нельзя делить на ноль!");

Console.WriteLine("добро пожаловать в анкету!");

Console.Write("Введите ваше имя: ");
string name = Console.ReadLine();
Console.Write("Введите вашу фамилию: ");
string surname = Console.ReadLine();
Console.Write("Введите вашу группу: ");
string group = Console.ReadLine();
Console.Write("Введите ваш год рожденья: ");
int birthYear = int.Parse(Console.ReadLine());
Console.Write("Введите ваш средний балл (например, 4.5): ");
double gpa = double.Parse(Console.ReadLine());

int currentYear = 2026;
int age = currentYear - birthYear;
bool isExcellent = gpa >= 4.5;
string status;
if (isExcellent == true) status = "Отличник";
else status = "Хорошист";

Console.WriteLine("Ваша анкета");
Console.WriteLine($"Имя: {name} {surname}");
Console.WriteLine($"Группа: {group}");
Console.WriteLine($"Возраст: {age} лет");
Console.WriteLine($"Средний балл: {gpa}");
Console.WriteLine($"Статус: {status}");
Console.WriteLine($"Лет до 30: {30 - age}");
Console.WriteLine("Нажмите Enter для выхода...");
Console.ReadLine();