namespace SchoolCalendar;

public class Child(string name, Date birthdate)
{
    private string _name = name;
    private Date _birthdate = birthdate;

    public override string ToString() =>
        $"{_name} born on {_birthdate}";

    // chcemy wiedzieć kiedy będzie pierwszy dzień kiedy dziecko będzie spełniało minimalny wiek
    public Date GetDateByAge(int minAge) =>
        _birthdate.AddYears(minAge);

    // pobrać informację o dniu kiedy idzie dziecko do szkoły,
    // znaleźć pierwszą datę po rozpoczęciu szkoły
    public Date GetFirstBirthdayAt(SchoolSystem school) =>
        school.GetBeginning(this)
            .GetFirstDayOccurence(_birthdate);
}
