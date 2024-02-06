namespace SchoolCalendar;

public class Date(Calendar calendar, int year, YearDay yearDay)
{
    private readonly int _year = year;
    private readonly YearDay _yearDay = yearDay;
    private readonly Calendar _calendar = calendar;

    public override string ToString() =>
        $"{_yearDay}/{_year}";


    public Date GetFirstOccurence(YearDay day) =>
        GetFirstDayOccurence(
            day.IsBefore(_yearDay) ? _year + 1 : _year,
            day);

    public Date GetFirstDayOccurence(Date date) =>
        GetFirstDayOccurence(_year, date._yearDay);

    public Date AddYears(int count) =>
        GetFirstValidDate(_year + count, _yearDay);

    private Date GetFirstDayOccurence(int year, YearDay day) =>
        new Date(
            _calendar,
            _calendar.IsLeapDay(day.Month, day.Day)
                ? GetLeapYear(year)
                : year, day
        );

    private int GetLeapYear(int year) =>
        _calendar.IsLeapYear(year) ? year : GetLeapYear(year + 1);

    private Date GetFirstValidDate(int year, YearDay day) =>
        new Date(
            _calendar,
            year,
            (_calendar.IsLeapYear(year) && _calendar.IsLeapDay(day.Month, day.Day))
                ? day.GetNext()
                : day
        );
}
