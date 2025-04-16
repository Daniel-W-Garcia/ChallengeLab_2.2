namespace ChallengeLab_2._2;

public class Person
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int LastFourDigits { get; set; }
    
    public Person(){} //default constructor

    public Person(string firstName, string lastName, int lastFourDigits)
    {
        FirstName = firstName;
        LastName = lastName;
        LastFourDigits = lastFourDigits;
    }
}

public class PeopleManager
{
    private List<Person> people;
    public PeopleManager()
    {
        people = new List<Person>
        {
            new Person("John", "Doe", 1234),
            new Person ("Hank", "Williams", 5678),
            new Person("Barney", "Rubble", 9012)
        };
    }
    
    public List<Person> GetPeople()
    {
        return people;
    }
}