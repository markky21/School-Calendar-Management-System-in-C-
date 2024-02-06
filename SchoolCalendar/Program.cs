// See https://aka.ms/new-console-template for more information

using SchoolCalendar;

MyProgram.Main();

static class MyProgram
{
    public static void Main()
    {
        IReadOnlyList<Calendar> calendars = new Calendar[]
        {
            new GregorianCalendar(),
            new JulianCalendar()
        };

        foreach (var calendar in calendars)
        {
            Demonstrate(calendar);
        }

        Console.ReadLine();
    }

    static void Demonstrate(Calendar calendar)
    {
        Console.WriteLine(calendar.GetType().Name);
        var schoolSystem = new SchoolSystem(
            new YearDay(calendar, 1, 1),
            5,
            new YearDay(calendar, 8, 15)
        );

        IReadOnlyList<Child> children = new []
        {
            new Child("Jill", new Date(calendar, 2000, new YearDay(calendar, 4, 2))),
            new Child("Eric", new Date(calendar, 2000, new YearDay(calendar, 2, 29))),
            new Child("John", new Date(calendar, 2000, new YearDay(calendar, 8, 15))),
            new Child("Jane", new Date(calendar, 2000, new YearDay(calendar, 8, 16))),
            new Child("Jack", new Date(calendar, 2000, new YearDay(calendar, 8, 17)))
        };


        Report(children, schoolSystem);
        Console.WriteLine();
    }

    static void Report(Child child, SchoolSystem school) =>
        Console.WriteLine(
            $"{child} starts school on {school.GetBeginning(child)}, celebrates on {child.GetFirstBirthdayAt(school)}");

    static void Report(IEnumerable<Child> children, SchoolSystem school) {
         foreach (var child in children)
            Report(child, school);
    }
}
