namespace ChallengeLab_2._2;

public class UserId
{
    private Person person = new();
    private string userName;
    public string UserName { get => userName; private set => userName = value; }

    public UserId(Person person)
    {
        this.person = person;
        GenerateUserName();
    }

    private void SetUserName(string newUserName)
    {
        userName = newUserName;
    }

    private void GenerateUserName()
    {
        userName = $"{person.FirstName}{person.LastName[0]}{person.LastFourDigits:D4}";
    }
}