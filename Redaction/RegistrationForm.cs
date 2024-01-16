using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Redaction
{
    public partial class RegistrationForm : Form
    {
        private static int key = 123;
        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void RegistrateUserBTN_Click(object sender, EventArgs e)
        {
            RegistrateNewUser();
        }
        private void RegistrateNewUser()
        {
            string userNickName = DataEncoder(NickNameTB.Text);
            string userName = DataEncoder(NameTB.Text);
            string userSecondName = DataEncoder(SecondNameTB.Text);
            string userEmail = DataEncoder(EmailTB.Text);
            string userPass = DataEncoder(PasswordTB.Text);
            string userBirthDate = DataEncoder(Convert.ToString(BirthDateDTP.Value));
            Role userRole;
            bool isRedactor = false;
            if ((AuthorCB.Checked == false) && (ReaderCB.Checked == false))
            {
                MessageBox.Show("введите пользовательскую роль");
                return;
            }
            else if (AuthorCB.Checked == false)
            {
                userRole = Role.Reader;
            }
            else
            {
                userRole = Role.Author;
            }

            User newUser = new User(userNickName, userName, userSecondName, userEmail, userPass,userBirthDate, userRole, isRedactor);

            UserRegistration.RegisterUser(newUser);
            Form1 form1 = (Form1)Application.OpenForms["Form1"];
            form1.Show();
            Close();
        }

        private void AuthorCB_Click(object sender, EventArgs e)
        {
            if (AuthorCB.Checked)
            {
                ReaderCB.Checked = false;
            }
        }

        private void ReaderCB_Click(object sender, EventArgs e)
        {
            if (ReaderCB.Checked)
            {
                AuthorCB.Checked = false;
            }
        }
        public static string DataEncoder(string data)
        {
            char[] charedData = data.ToCharArray();
            byte[] bytes = new byte[charedData.Length];
            

            for (int i = 0; i < bytes.Length; i++)
            {
                bytes[i] = (byte)charedData[i];
            }

            int[] encrypting = new int[charedData.Length];

            for (int i = 0; i < encrypting.Length; i++)
            {
                encrypting[i] = bytes[i]^ key;
            }

            data = String.Empty;
            for (int i = 0; i < encrypting.Length; i++)
            {
                data += (char)encrypting[i];
            }
            return data;

        }
        //public static string DataDecoder(string data)
        //{
        //    char[] charedData = data.ToCharArray();
        //    byte[] bytes = new byte[charedData.Length];

        //    for (int i = 0; i < bytes.Length; i++)
        //    {
        //        bytes[i] = (byte)charedData[i];
        //    }

        //    int[] decrypting = new int[charedData.Length];
            
        //    for (int i = 0; i < decrypting.Length; i++)
        //    {
        //        decrypting[i] = bytes[i]^ key;
        //    }
        //    data = String.Empty;
        //    for (int i = 0; i < encrypting.Length; i++)
        //    {
        //        data += (char)encrypting[i];
        //    }
        //    return data;
        //}
    }
}
