using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Redaction.RoleOfUsers
{
    public partial class ReaderPanel : Form
    {
        public User CurrentUser { get; set; }
        private string _openedArticle = string.Empty;
        public ReaderPanel(User user)
        {
            InitializeComponent();
            CurrentUser = user;
            if (CurrentUser.IsRedactor == false)
            {
                ArticleTextTB.ReadOnly = true;
            }
            if (CurrentUser.ArticleList.Count > 0)
            {
                foreach (string article in CurrentUser.ArticleList)
                {
                    ArticleListB.Items.Add(article.Split("?& ")[1]);
                }
            }
        }


        private void ExitBTN_Click(object sender, EventArgs e)
        {
            Form1 form1 = (Form1)Application.OpenForms["Form1"];
            form1.Show();
            Close();
        }

        private void ReadArticleBTN_Click(object sender, EventArgs e)
        {
            _openedArticle = Convert.ToString(ArticleListB.SelectedItem) + ".txt";
            ArticleTextTB.Text = File.ReadAllText(_openedArticle);

        }

        private void SaveArticleChangesBTN_Click(object sender, EventArgs e)
        {
            File.WriteAllText(_openedArticle, ArticleTextTB.Text);
        }
    }
}
