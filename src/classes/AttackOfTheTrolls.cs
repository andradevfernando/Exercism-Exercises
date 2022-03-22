using System;

public enum AccountType
{
    Guest,
    User,
    Moderator
}
[Flags]
public enum Permission : short
{
    None = 0,
    Read = 1,
    Write = 2,
    Delete = 4,
    All = 7
}

static class Permissions
{
    public static Permission Default(AccountType accountType)
    {
        return accountType switch
        {
            AccountType.Guest => (Permission)1,
            AccountType.User => (Permission)3,
            AccountType.Moderator => Permission.All,
            _ => Permission.None
        };
    }

    public static Permission Grant(Permission current, Permission grant)
    {
        if (current != grant)
            return grant switch
            {
                Permission.All => Permission.All,
                Permission.Read => (Permission)(int)current + 1,
                Permission.Write => (Permission)(int)current + 2,
                Permission.Delete => (Permission)(int)current + 4,
                Permission n when (int)n == (int)grant => (Permission)(int)current + 3,
                _ => Permission.None
            };
        return current;
    }

    public static Permission Revoke(Permission current, Permission revoke)
    {
        if ((int)current != 0 && revoke != Permission.None)
            return revoke switch
            {
                Permission.All => 0,
                Permission.Read => (Permission)(int)current - 1,
                Permission.Write => (Permission)(int)current - 2,
                Permission.Delete => (Permission)(int)current - 4,
                Permission n when (int)n == 3 && (int)current == 6 => (Permission)4,
                _ => Permission.None
            };
        return current;
    }

    public static bool Check(Permission current, Permission check)
    {
        if ((int)current == (int)check || (int)current == 7)
            return true;
        else if ((int)current == 3 && (int)check == 1)
            return true;

        return false;
    }
}
