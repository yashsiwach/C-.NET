// Represents a user with login credentials
public class User
{
    // Username of the user
    public string? Name { get; set; }

    // Password entered by the user
    public string? Password { get; set; }

    // Confirmation password entered by the user
    public string? ConfirmationPassword { get; set; }
}

// Custom exception used when password and confirmation password do not match
public class PasswordMismatchException : Exception
{
    // Constructor for custom exception
    public PasswordMismatchException(string s) : base()
    {
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        // Create Program object to call non-static methods
        Program obj = new Program();

        // Case where password and confirmation password match
        var res = obj.ValidatePassword("test1", "ok", "ok");

        // Check if returned object is of type User
        if (res is User)
        {
            System.Console.WriteLine("successfull");
        }

        // Case where password and confirmation password do not match
        var res1 = obj.ValidatePassword("test2", "ok", "okk");
    }

    // Validates whether password and confirmation password are same
    public User ValidatePassword(string name, string password, string confirmationPassword)
    {
        try
        {
            // Check for password mismatch
            if (!password.Equals(confirmationPassword))
            {
                // Throw custom exception when passwords do not match
                throw new PasswordMismatchException("Password dont match");
            }
        }
        catch (Exception e)
        {
            // Print exception message
            System.Console.WriteLine(e.Message);
        }

        // Return User object (even if passwords mismatch)
        return new User
        {
            Name = name,
            Password = password,
            ConfirmationPassword = confirmationPassword
        };
    }
}
