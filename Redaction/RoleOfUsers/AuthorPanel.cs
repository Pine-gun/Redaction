using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Redaction.RoleOfUsers
{
    public partial class AuthorPanel : Form
    {
        public User CurrentUser { get; set; }
        private string _openedArticle = string.Empty;

        public AuthorPanel(User user)
        {
            InitializeComponent();
            CurrentUser = user;
            if (CurrentUser.ArticleList.Count > 0)
            {
                foreach (string article in CurrentUser.ArticleList)
                {
                    if (article.Split("?& ")[0] == CurrentUser.UserName)
                    {
                        ArticleListB.Items.Add(article.Split("?& ")[1]);
                    }

                }
            }
        }


        private void AddNewArticleBTN_Click(object sender, EventArgs e)
        {
            string userDataPath = Directory.GetCurrentDirectory() + "\\listOfArticles.json";

            CurrentUser.ArticleList.Add(CurrentUser.UserName + "?& " + ArticleNameTB.Text);
            ArticleListB.Items.Add(ArticleNameTB.Text);

            StreamWriter writeToListOFArticles = new StreamWriter(userDataPath);
            JsonSerializerOptions options = new JsonSerializerOptions()
            {
                WriteIndented = true,
                Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping
            };
            string renewedJsonData = JsonSerializer.Serialize(CurrentUser.ArticleList, typeof(List<string>), options);
            writeToListOFArticles.Write(renewedJsonData);
            writeToListOFArticles.Close();

            StreamWriter writer = new StreamWriter(ArticleNameTB.Text + ".txt");
            writer.Close();
        }

        private void ExitBTN_Click(object sender, EventArgs e)
        {

            Form1 form1 = (Form1)Application.OpenForms["Form1"];
            form1.Show();
            Close();

        }

        private void OpenArticleBTN_Click(object sender, EventArgs e)
        {
            _openedArticle = Convert.ToString(ArticleListB.SelectedItem) + ".txt";
            ArticleTextTB.Text = File.ReadAllText(_openedArticle);

        }

        private void SaveArticleChangesBTN_Click(object sender, EventArgs e)
        {
            File.WriteAllText(_openedArticle, ArticleTextTB.Text);
        }

        private void AddHeaderBTN_Click(object sender, EventArgs e)
        {
            ArticleTextTB.AppendText(HeaderTB.Text);

        }

        private void AddUnderHeaderBTN_Click(object sender, EventArgs e)
        {
            ArticleTextTB.AppendText(UnderHeaderTB.Text);
        }

        private void AddParagrafBTN_Click(object sender, EventArgs e)
        {
            ArticleTextTB.AppendText(ParagrafTextTB.Text);
        }

        private void ClearALLFieldsBTN_Click(object sender, EventArgs e)
        {
            HeaderTB.Clear();
            UnderHeaderTB.Clear();
            ParagrafTextTB.Clear();
        }
    }
}
