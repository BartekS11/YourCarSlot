using System.Text.RegularExpressions;
using YourCarSlot.Domain.Common;
using YourCarSlot.Domain.Exceptions;

namespace YourCarSlot.Domain.Entities
{
    public class User : BaseEntity
    {
        private static readonly Regex NameRegex = new Regex("^(?![_.-])(?!.*[_.-]{2})[a-zA-Z0-9._.-]+(?<![_.-])$");
        private static readonly Regex EmailRegex = new Regex("^[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?$");

        public string Email { get;  set; }  = string.Empty;
        public string Password { get;  set; }  = string.Empty;
        public string Salt { get;  set; }  = string.Empty;
        public string Username { get;  set; }  = string.Empty;
        public string FullName { get;  set; }  = string.Empty;

        public string PlateNumber { get; }  = string.Empty;

        public User()
        {
        }

        public User(string email, string username, 
            string password, string salt)
        {
            Id = Guid.NewGuid();
            SetEmail(email.ToLowerInvariant());
            SetUsername(username);
            SetPassword(password);
            Salt = salt;
            CreatedAt = DateTime.UtcNow;
        }

        public void SetEmail(string email)
        {
            if(!EmailRegex.IsMatch(email))
            {
                throw new WrongEmailException();
            }

            if(Email == email)
            {
                return;
            }

            Email = email;
        }

        public void SetUsername(string username)
        {
            if(!NameRegex.IsMatch(username))
            {
                throw new WrongUsernameException();
            }

            if(Username == username)
            {
                return;
            }

            Username = username;
        }

        public void SetPassword(string password)
        {
            if(string.IsNullOrWhiteSpace(password))
            {
                throw new WrongPasswordException();
            }

            if(password.Length < 4)
            {
                throw new Exception("Password must contain at least 4 characters.");
            }

            if(password.Length > 50)
            {
                throw new Exception("Password can not contain more than 50 characters.");
            }

            if(Password == password)
            {
                return;
            }

            Password = password;
            CreatedAt = DateTime.UtcNow;
        }
    }
}