using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Redaction.RoleOfUsers
{
    public partial class AdminPanelUsers : Form
    {
        public User CurrentUser { get; set; }
        private string _userDataPath = Directory.GetCurrentDirectory() + "\\userData.json";
        private List<User> _users;
        private string _chosenUserLogin = string.Empty;
        public AdminPanelUsers(User user)
        {
            CurrentUser = user;
            InitializeComponent();
            AddUsersToList();
        }
        public void AddUsersToList()
        {
            string jsonData = File.ReadAllText(_userDataPath);
            if (jsonData == string.Empty)
            {
                _users = new List<User>();
            }
            else
            {
                _users = JsonSerializer.Deserialize<List<User>>(jsonData);

            }
            foreach (var oneUser in _users)
            {
                AllUsersLB.Items.Add(RegistrationForm.DataEncoder(oneUser.UserName));
            }
        }

        private void ExitBTN_Click(object sender, EventArgs e)
        {
            Form1 form1 = (Form1)Application.OpenForms["Form1"];
            form1.Show();
            Close();
        }

        private void ChooseUserBTN_Click(object sender, EventArgs e)
        {
            _chosenUserLogin =Convert.ToString(AllUsersLB.SelectedItem);
            foreach (var oneUser in _users)
            {
                if (_chosenUserLogin == RegistrationForm.DataEncoder(oneUser.UserName))
                {
                    UserNickNameTB.ReadOnly = true;
                    UserEmailTB.ReadOnly = true;
                    UserNickNameTB.Text = RegistrationForm.DataEncoder(oneUser.UserName);
                    UserNameTB.Text = RegistrationForm.DataEncoder(oneUser.FirstName);
                    UserSurnameTB.Text = RegistrationForm.DataEncoder(oneUser.SecondName);
                    UserEmailTB.Text = RegistrationForm.DataEncoder(oneUser.UserEmail);
                    UserPasswordTB.Text = RegistrationForm.DataEncoder(oneUser.Password);
                    UserBirthdayTB.Text = RegistrationForm.DataEncoder(oneUser.BirthDate);
                    UserBirthdayDTP.Value = Convert.ToDateTime(UserBirthdayTB.Text);
                    if (oneUser.Role == Role.Admin)
                    {
                        AdminCHB.Checked = true; AuthorCHB.Checked = false; ReaderCHB.Checked = false;
                    }
                    else if (oneUser.Role == Role.Author)
                    {
                        AuthorCHB.Checked = true; AdminCHB.Checked = false; ReaderCHB.Checked = false;
                    }
                    else
                    {
                        ReaderCHB.Checked = true; AdminCHB.Checked = false; AuthorCHB.Checked = false;
                    }                    
                    if (oneUser.IsRedactor == true)
                    {
                        IsRedactorCHB.Checked = true;
                    }
                    else
                    {
                        IsRedactorCHB.Checked = false;
                    }

                }

            }
        }

        private void ClearAllFieldsBTN_Click(object sender, EventArgs e)
        {
            UserNickNameTB.ReadOnly = false;
            UserEmailTB.ReadOnly = false;
            UserNickNameTB.Clear();
            UserNameTB.Clear();
            UserSurnameTB.Clear();
            UserEmailTB.Clear();
            UserPasswordTB.Clear();
            AdminCHB.Checked = false;
            AuthorCHB.Checked = false;
            ReaderCHB.Checked = false;
            UserBirthdayTB.Clear();
            IsRedactorCHB.Checked = false;
        }

        private void AddUserBTN_Click(object sender, EventArgs e)
        {
            if (UserNickNameTB.Text == ""|| UserNameTB.Text==""||UserSurnameTB.Text ==""||UserEmailTB.Text==""|| UserPasswordTB.Text==""||UserBirthdayTB.Text =="")
            {
                MessageBox.Show("Не все поля заполнены!");
                return;
            }
            else if (ReaderCHB.Checked == false &&
            AuthorCHB.Checked == false && AdminCHB.Checked == false)
            {
                MessageBox.Show("Не указана роль!");
                return;
            }

            string userNickName = RegistrationForm.DataEncoder(UserNickNameTB.Text);
            string userName = RegistrationForm.DataEncoder(UserNameTB.Text);
            string userSecondName = RegistrationForm.DataEncoder(UserSurnameTB.Text);
            string userEmail = RegistrationForm.DataEncoder(UserEmailTB.Text);
            string userPass = RegistrationForm.DataEncoder(UserPasswordTB.Text);
            string userBirthDate = RegistrationForm.DataEncoder(Convert.ToString(UserBirthdayDTP.Value));
            Role userRole;
            bool isRedactor = false;
            if (IsRedactorCHB.Checked == true)
            {
                isRedactor = true;
            }

            if (AdminCHB.Checked)
            {
                userRole = Role.Admin;
            }
            else if (AuthorCHB.Checked)
            {
                userRole = Role.Author;
            }
            else
            {
                userRole = Role.Reader;
            }


            User newUser = new User(userNickName, userName, userSecondName, userEmail, userPass, userBirthDate, userRole, isRedactor);

            UserRegistration.RegisterUser(newUser);
            AllUsersLB.Items.Clear();
            AddUsersToList();
        }

        private void UserBirthdayDTP_ValueChanged(object sender, EventArgs e)
        {
            UserBirthdayTB.Text = Convert.ToString(UserBirthdayDTP.Value);
        }

        private void AdminCHB_Click(object sender, EventArgs e)
        {
            if (AdminCHB.Checked)
            {
                ReaderCHB.Checked = false;
                AuthorCHB.Checked = false;
            }
        }

        private void AuthorCHB_Click(object sender, EventArgs e)
        {
            if (AuthorCHB.Checked)
            {
                ReaderCHB.Checked = false;
                AdminCHB.Checked = false;
            }
        }

        private void ReaderCHB_Click(object sender, EventArgs e)
        {
            if (ReaderCHB.Checked)
            {
                AdminCHB.Checked = false;
                AuthorCHB.Checked = false;
            }
        }

        private void SaveUserChangesBTN_Click(object sender, EventArgs e)
        {
            if (UserNickNameTB.Text=="")
            {
                MessageBox.Show("Не выбран пользователь!");
                return;
            }
            foreach (var oneUser in _users)
            {
                if (UserNickNameTB.Text == RegistrationForm.DataEncoder(oneUser.UserName))
                {
                    oneUser.FirstName = RegistrationForm.DataEncoder(UserNameTB.Text);
                    oneUser.SecondName = RegistrationForm.DataEncoder(UserSurnameTB.Text);
                    oneUser.Password = RegistrationForm.DataEncoder(UserPasswordTB.Text);
                    if (AdminCHB.Checked)
                    {
                        oneUser.Role = Role.Admin;
                    }
                    else if (AuthorCHB.Checked)
                    {
                        oneUser.Role = Role.Author;
                    }
                    else
                    {
                        oneUser.Role = Role.Reader;
                    }
                    if (Convert.ToString(UserBirthdayDTP.Value) == UserBirthdayTB.Text)
                    {
                        oneUser.BirthDate = RegistrationForm.DataEncoder(Convert.ToString(UserBirthdayDTP.Value));
                    }
                    if (IsRedactorCHB.Checked)
                    {
                        oneUser.IsRedactor = true;
                    }
                    else
                    {
                        oneUser.IsRedactor = false;
                    }
                    break;
                }
            }
            UserRegistration.SerializeUsersToJson(_users, _userDataPath);
            AllUsersLB.Items.Clear();
            AddUsersToList();

        }

        private void DeleteUserBTN_Click(object sender, EventArgs e)
        {
            if (UserNickNameTB.Text=="")
            {
                MessageBox.Show("Не выбран пользователь для удаления!");
                return;
            }
            foreach (var oneUser in _users)
            {
                if (UserNickNameTB.Text == RegistrationForm.DataEncoder(oneUser.UserName))
                {
                    _users.Remove(oneUser);
                    for (int i = 0; i < _users.Count; i++)
                    {
                        _users[i].Id = i+1;
                    }
                    break;
                }
            }
            UserRegistration.SerializeUsersToJson(_users, _userDataPath);
            AllUsersLB.Items.Clear();
            AddUsersToList();
        }
    }

}
