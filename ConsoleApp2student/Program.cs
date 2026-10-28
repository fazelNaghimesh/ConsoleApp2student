
using ConsoleApp2student;

Student[] student = new Student[3];

for (int i=0;i<3;i++)
{
    student[i] = new Student();
    Console.Write($"name of student {i+1} : ");
    student[i].Name = Console.ReadLine();
    Console.WriteLine("----------------");
    student[i].Math();
    student[i].phyisc();
    student[i].prg();
    Console.WriteLine("----------------");
}
foreach (var s in student)
{
    Console.WriteLine($"{s.Name}-->average = {s.average():F2}");
}


