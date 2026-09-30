namespace EventEase.Services;

public class SessionService
{
    public string? UserName { get; private set; }
    public string? UserEmail { get; private set; }
    public bool IsLoggedIn => !string.IsNullOrWhiteSpace(UserName);

    public void SignIn(string name, string email)
    {
        UserName = name;
        UserEmail = email;
    }

    public void SignOut()
    {
        UserName = null;
        UserEmail = null;
    }
}
