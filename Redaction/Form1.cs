namespace Redaction
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void RegistrateBTN_Click(object sender, EventArgs e)
        {
            Hide();
            RegistrationForm registrationForm = new RegistrationForm();
            registrationForm.Show();           


        }

        private void EnterBTN_Click(object sender, EventArgs e)
        {
            UserAuthentification authentification = new UserAuthentification();
            Hide();
            authentification.AuthenticateUser(UserLoginTB.Text, UserPasswordTB.Text);
            UserLoginTB.Clear();
            UserPasswordTB.Clear();
           
        }
    }
}