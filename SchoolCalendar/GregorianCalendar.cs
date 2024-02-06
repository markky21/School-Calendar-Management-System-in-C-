namespace SchoolCalendar;

public sealed class GregorianCalendar : Calendar
{
    public override bool IsLeapYear(int year) =>
        year % 4 == 0 && (year % 100 != 0 || year % 400 == 0);

    public override bool IsLeapDay(int month, int day) =>
        month == 2 && day == 29;

    public override int DaysInMonth(int month) =>
        month switch
        {
            1 or 3 or 5 or 7 or 8 or 10 or 12 => 31,
            4 or 6 or 9 or 11 => 30,
            2 => 29,
            _ => throw new ArgumentException("Invalid month")
        };

    public override int NextMonth(int month) =>
        month % 12 + 1;
}
