// // See https://aka.ms/new-console-template for more information
// int age = 20;
// double gpa = 4.5;
// bool stud = true;
// string name = "Ivan";



// Console.WriteLine(stud);
// Console.WriteLine(age);
// Console.WriteLine(gpa);
// Console.WriteLine(name);

string first = "Вовк";
string last = "Тимофей";
string group = "ИСП-242";
int birthYear = 2007;
double gpa = 4.5;
bool hasScholarship = true;
int currentYear = 2026;
int age = currentYear - birthYear;

Console.WriteLine("Студенческое удостоверение");
Console.WriteLine($"Имя: {first} {last}");
Console.WriteLine($"Группа: {group}");
Console.WriteLine($"Возраст: {age} лет");
Console.WriteLine($"Средний бал: {gpa}");
Console.WriteLine($"Стипендия: {hasScholarship}");

Console.Write("\nВведите ваш любимый предмет: ");
string subject = Console.ReadLine();
Console.WriteLine($"Отлично! {first} любит {subject}");