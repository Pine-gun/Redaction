using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Redaction
{
    public enum Role
    {
        Admin,
        Author,
        Reader

    };
    public class User
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string UserEmail { get; set; }
        public string Password { get; set; }
        public DateTime RegistrationDate { get; set; }
        public string BirthDate { get; set;}
        public Role Role { get; set; }
        public bool IsRedactor { get; set; } = false;
        public List<string> ArticleList { get; set; }
        
        
        public User(string userName, string firstName, string secondName, string userEmail, string password, string birthdate, Role role, bool isredactor)
        {            
            UserName = userName;
            FirstName = firstName;
            SecondName = secondName;
            UserEmail = userEmail;
            Password = password;           
            BirthDate = birthdate;
            Role = role;
            IsRedactor = isredactor;

        }
       
        
    }

}
