namespace SchoolCalendar;

public abstract class Calendar
{
    public Date Create(int year, int month, int day) =>
        new Date(this, year, Create(month, day));

    public YearDay Create(int month, int day) =>
        new YearDay(this, month, day);

    public abstract bool IsLeapYear(int year);
    public abstract bool IsLeapDay(int month, int day);
    public abstract int DaysInMonth(int month);
    public abstract int NextMonth(int month);
}
