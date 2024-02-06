namespace SchoolCalendar;

public class YearDay(Calendar calendar, int month, int day)
{
    public readonly int Month = month;
    public readonly int Day = day;
    private readonly Calendar _calendar = calendar;

    public override string ToString() =>
        $"{Month}/{Day}";

    public bool IsBefore(YearDay cutoff) =>
        Month < cutoff.Month || Month == cutoff.Month && Day < cutoff.Day;

    public YearDay GetNext() =>
        IsEndOfMonth()
            ? new YearDay(_calendar, _calendar.NextMonth(Month), 1)
            : new YearDay(_calendar, Month, Day + 1);


    // To be moved to Calendar class
    private bool IsEndOfMonth() =>
        Day == _calendar.DaysInMonth(Month);
}
