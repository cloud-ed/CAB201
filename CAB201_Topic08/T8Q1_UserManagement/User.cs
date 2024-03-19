namespace UserManagement;
/// <summary>
/// A user with an email and password.
/// </summary>
class User
{
    private string? email;
    private string? password;

    /// <summary>
    /// The email of the user.
    /// </summary>
    /// <exception cref="ArgumentException">Thrown when the email is invalid.</exception>
    public string? Email
    {
        get
        {
            return email;
        }
        private set
        {
            // Insert your solution here to throw an ArgumentException for the following cases:
            // - The email is null or empty, with the message "Email cannot be null or empty"
            // - The email does not contain an @ symbol, with the message "Email must contain an @ symbol"
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentException("Email cannot be null or empty");
            }
            if (!value.Contains("@") )
            {
                throw new ArgumentException("Email must contain an @ symbol");
            }
            email = value;
        }
    }

    /// <summary>
    /// The password of the user.
    /// </summary>
    /// <exception cref="ArgumentException">Thrown when the password is invalid.</exception>
    public string? Password
    {
        get
        {
            return password;
        }
        private set
        {
            // Insert your solution here to throw an ArgumentException for the following cases:
            // - The password is null or empty, with the message "Password cannot be null or empty"
            // - The password is less than 6 characters, with the message "Password must be at least 6 characters"
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentException("Password cannot be null or empty");
            }
            if(value.Length < 6)
            {
                throw new ArgumentException("Password must be at least 6 characters");
            }
            password = value;
        }
    }

    /// <summary>
    /// Creates a new user with the specified email and password.
    /// </summary>
    /// <param name="email">The email of the user.</param>
    /// <param name="password">The password of the user.</param>
    /// <param name="confirmPassword">The confirmation of the password.</param>
    /// <exception cref="ArgumentException">Thrown when the password and confirm password do not match.</exception>
    public User(string? email, string? password, string? confirmPassword)
    {
        // Insert your solution here to throw an ArgumentException, with the message
        // "Password and confirm password do not match"
        // if the password and confirm password do not match.
        if (confirmPassword != password)
        {
            throw new ArgumentException("Password and confirm password do not match");
        }
        Email = email;
        Password = password;
    }
}