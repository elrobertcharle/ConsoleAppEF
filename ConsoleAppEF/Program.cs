// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


using (var context = new ConsoleAppEF.DAL.Academy())
{
    context.Courses!.Add(new ConsoleAppEF.DAL.Course
    {
        Name = "C1"
    });

    context.SaveChanges();
}