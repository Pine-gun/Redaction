using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Redaction
{
    internal class Admin 
    {
        private int Id { get; set; }
        private string UserName { get; set; }
        private string FirstName { get; set; }
        private string SecondName { get; set; }
        private string UserEmail { get; set; }
        private string Password { get; set; }
        private DateTime RegistrationDate { get; set; }
        private DateTime BirthDate { get; set; }
        private Role Role { get; set; } = Role.Admin;
        private bool IsRedactor { get; set; } = true;
        private List<string> ArticleList { get; set; }

        public Admin()
        {
           

        }
    }
}
