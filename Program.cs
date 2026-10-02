// int lessonNumber = 5;
// int totalLessons = 1;

// while (lessonNumber >= totalLessons) {
//     Console.WriteLine($"Пара {lessonNumber}");
//     lessonNumber--;
// }

// Console.WriteLine("Пары закончились");

// Console.WriteLine("Вводите оценки по одной, для завершения введите -1:");
// int grade = int.Parse(Console.ReadLine());
// int count = 0;

// while (grade != -1) {
//     Console.WriteLine($"Оценка принята: {grade}");
//     count++;
//     grade = int.Parse(Console.ReadLine());
// }

// Console.WriteLine("Ввод завершён");
// Console.WriteLine($"Количество введённых оценок: {count}");

int sum = 0;
int count = 0;
System.Console.WriteLine("Вводите оценки, для завершения введите -1:");
int grade = int.Parse(Console.ReadLine());

while (grade != -1)
{
    sum += grade;
    count++;
    grade = int.Parse(Console.ReadLine);
}
if (count > 0)
{
    System.Console.WriteLine($"Средний балл ");
}