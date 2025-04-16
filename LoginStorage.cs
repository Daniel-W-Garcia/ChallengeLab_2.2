namespace ChallengeLab_2._2;

public class LoginStorage
{
    PeopleManager peopleManager = new();
    private List<Person> people;
    List<UserId> userIds = new();
    private List<UserAccount> userAccounts = new();
    private Password passwordManager = new();
    
    public LoginStorage()
    {
        people = peopleManager.GetPeople();
        foreach (Person person in people)
        {
            userIds.Add(new UserId(person));
        }
    }
    public List<UserId> GetUserIds()
    {
        return userIds;
    }
    public List<Person> GetPeople()
    {
        return people;
    }

    public void PrintPeople()
    {
        foreach (var person in people)
        {
            Console.WriteLine($"{person.FirstName} {person.LastName} ({person.LastFourDigits})");
        }
    }
    public void PrintUserIds()
    {
        foreach (var userId in userIds)
        {
            Console.WriteLine($"Username: {userId.UserName}");
        }
    }

    public void CreateUserAccount(UserId userId, string password)
    {
        string passwordHash = passwordManager.HashPassword(password);
        UserAccount userAccount = new(userId, passwordHash);
        userAccounts.Add(userAccount);
        Console.WriteLine($"User {userId.UserName} created successfully");
    }
    public bool ValidateLogin(string username, string password)
    {
        UserAccount account = userAccounts.FirstOrDefault(a => a.UserId.UserName == username);
        
        if (account == null)
        {
            return false; 
        }
        return passwordManager.VerifyPassword(password, account.PasswordHash);
    }

    public List<UserAccount> GetUserAccounts()
    {
        return userAccounts;
    }

}