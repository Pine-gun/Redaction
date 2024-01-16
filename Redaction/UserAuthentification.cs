using Redaction.RoleOfUsers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Redaction
{
    internal class UserAuthentification
    {
        private List<User> _newUserList;        
        public void AuthenticateUser(string username, string password)
        {
            
            StreamReader reader = new StreamReader(Directory.GetCurrentDirectory() + "\\userData.json");
            string jsonData = reader.ReadToEnd();
            reader.Close();
            if (jsonData == string.Empty)
            {
                _newUserList = new List<User>();
            }
            else
            {
                _newUserList = JsonSerializer.Deserialize<List<User>>(jsonData);
            }
            User? currentUser = null;
            foreach (var user in _newUserList)
            {
                if ((user.UserName ==  RegistrationForm.DataEncoder(username)) && (user.Password == RegistrationForm.DataEncoder(password)))
                {
                    currentUser = user;                    
                    IsUserAuthenticated(currentUser);
                    return;
                }
                else if ((user.UserName == RegistrationForm.DataEncoder(username)) & (user.Password != RegistrationForm.DataEncoder(password)))
                {
                    MessageBox.Show("введен неверный пароль!");
                    Form1 form2 = (Form1)Application.OpenForms["Form1"];
                    form2.Show();
                    return;
                }
            }
            
            MessageBox.Show("нет такого пользователя!");
            Form1 form1 = (Form1)Application.OpenForms["Form1"];
            form1.Show();
            
            return;                 
                    
        }
        public void IsUserAuthenticated(User currentUser)
        {
            string userDataPath = Directory.GetCurrentDirectory() + "\\listOfArticles.json";

            string jsonData = File.ReadAllText(userDataPath);
            if (jsonData == string.Empty)
            {
                currentUser.ArticleList = new List<string>();
            }
            else
            {
                currentUser.ArticleList = JsonSerializer.Deserialize<List<string>>(jsonData);
               
            }
            switch (currentUser.Role)
            {
                case Role.Admin:                                  
                    AdminPanel adminPanel = new AdminPanel(currentUser);
                    adminPanel.Show();
                    break;

                case Role.Author:
                    AuthorPanel authorPanel = new AuthorPanel(currentUser);                                       
                    authorPanel.Show();
                    break;

                case Role.Reader:
                    ReaderPanel readerPanel = new ReaderPanel(currentUser);                   
                    readerPanel.Show();
                    break;

            }

        }
    }
}
