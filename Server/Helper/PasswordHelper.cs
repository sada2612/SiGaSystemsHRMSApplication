namespace Siga_Hrms.ApiService.Helper;

public static class PasswordHelper
{
    public static string GenerateSalt()
    {
        return BCrypt.Net.BCrypt.GenerateSalt();
    }

    public static string HashPassword(string password, string salt)
    {
        return BCrypt.Net.BCrypt.HashPassword(password + salt);
    }

    public static bool VerifyPassword(string enteredPassword, string storedHash, string storedSalt)
    {
        return BCrypt.Net.BCrypt.Verify(enteredPassword + storedSalt, storedHash);
    }
}
