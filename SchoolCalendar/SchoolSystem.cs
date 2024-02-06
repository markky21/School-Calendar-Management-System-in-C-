namespace SchoolCalendar;

public class SchoolSystem(YearDay cutoff, int minAge, YearDay schoolStart)
{
    private readonly YearDay _cutoff = cutoff;
    private readonly int _minAge = minAge;
    private readonly YearDay _schoolStart = schoolStart;

    // 1. Get child's birth year
    // 2. Add minimum age to that
    // 3. Add one year if birthday is before cut off date
    // 4. Append school year beginning to that year
    public Date GetBeginning(Child schoolChild) =>
        schoolChild.GetDateByAge(_minAge)
            .GetFirstOccurence(_cutoff)
            .GetFirstOccurence(_schoolStart);
}
