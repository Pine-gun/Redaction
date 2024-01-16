using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Threading.Tasks;

namespace Redaction
{
    class UserRegistration
    {
        
        private static  List<User> _newUserList;
        
        public  static void RegisterUser(User newUser)
        {
            string userDataPath = Directory.GetCurrentDirectory() + "\\userData.json";
            
            string jsonData = File.ReadAllText(userDataPath);
            if (jsonData == string.Empty) 
            {
                _newUserList = new List<User>();
            }
            else
            {
                _newUserList = JsonSerializer.Deserialize<List<User>>(jsonData);
            }
            
                        
            foreach (var user in _newUserList)
            {
                if (user.UserName == newUser.UserName)
                {
                    MessageBox.Show("пользователь с таким именем уже существует");
                    return;
                }
                else if(user.UserEmail == newUser.UserEmail)
                {
                    MessageBox.Show("пользователь с таким адресом почты уже существует");
                    return;
                }
            }
            newUser.Id = _newUserList.Count + 1;
            newUser.RegistrationDate = DateTime.Now;
            _newUserList.Add(newUser);
            SerializeUsersToJson(_newUserList, userDataPath);
        }
        
        public static void SerializeUsersToJson(List<User> users, string fileName)
        {
            StreamWriter writer = new StreamWriter(fileName);
            JsonSerializerOptions options = new JsonSerializerOptions()
            {
                WriteIndented = true,
                Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping
            };
            string renewedJsonData = JsonSerializer.Serialize(users, typeof(List<User>), options);
            writer.Write(renewedJsonData);
            writer.Close();           
        }
        
    }
}
