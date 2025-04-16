namespace ChallengeLab_2._2;

public class UserAccount
{
    public UserId UserId { get; private set; }
    public string PasswordHash { get; private set; }

    public UserAccount(UserId userId, string passwordHash)
    {
        UserId = userId;
        PasswordHash = passwordHash;
    }
}