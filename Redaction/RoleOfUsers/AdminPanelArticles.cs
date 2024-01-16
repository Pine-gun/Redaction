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

namespace Redaction.RoleOfUsers
{
    public partial class AdminPanelArticles : Form
    {
        private string _fileDataPath = Directory.GetCurrentDirectory() + "\\listOfArticles.json";
        public User CurrentUser { get; set; }
        private string _openedArticle = string.Empty;

        public AdminPanelArticles(User user)
        {
            InitializeComponent();
            CurrentUser = user;

            if (CurrentUser.ArticleList.Count > 0)
            {
                foreach (string article in CurrentUser.ArticleList)
                {
                    ArticleListB.Items.Add(article.Split("?& ")[1]);
                }
            }
        }

        private void AddNewArticleBTN_Click(object sender, EventArgs e)
        {
            CurrentUser.ArticleList.Add(CurrentUser.UserName + "?& " + ArticleNameTB.Text);
            ArticleListB.Items.Add(ArticleNameTB.Text);

            StreamWriter writeToListOFArticles = new StreamWriter(_fileDataPath);
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
            foreach (string article in CurrentUser.ArticleList)
            {
                if (Convert.ToString(ArticleListB.SelectedItem) == article.Split("?& ")[1])
                {
                    ArticleAuthorTB.Text =  RegistrationForm.DataEncoder(article.Split("?& ")[0]);
                    break;
                }

            }

        }

        private void SaveArticleChangesBTN_Click(object sender, EventArgs e)
        {
            if (_openedArticle == String.Empty)
            {
                MessageBox.Show("Статья не выбрана!");
                return;
            }
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

        private void SaveAuthorChangesBTN_Click(object sender, EventArgs e)
        {
            foreach (var article in CurrentUser.ArticleList)
            {
                if (Convert.ToString(ArticleListB.SelectedItem) == article.Split("?& ")[1])
                {
                    CurrentUser.ArticleList.Remove(article);
                    CurrentUser.ArticleList.Add(RegistrationForm.DataEncoder(ArticleAuthorTB.Text)+ "?& " + ArticleListB.SelectedItem);
                    break;
                }

            }
            StreamWriter writeToListOFArticles = new StreamWriter(_fileDataPath);
            JsonSerializerOptions options = new JsonSerializerOptions()
            {
                WriteIndented = true,
                Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping
            };
            string renewedJsonData = JsonSerializer.Serialize(CurrentUser.ArticleList, typeof(List<string>), options);
            writeToListOFArticles.Write(renewedJsonData);
            writeToListOFArticles.Close();           

            string jsonData = File.ReadAllText(_fileDataPath);
            if (jsonData == string.Empty)
            {
                CurrentUser.ArticleList = new List<string>();
            }
            else
            {
                CurrentUser.ArticleList = JsonSerializer.Deserialize<List<string>>(jsonData);
                ArticleListB.Items.Clear();
                foreach (string article in CurrentUser.ArticleList)
                {
                    ArticleListB.Items.Add(article.Split("?& ")[1]);
                }

            }
        }

        private void DeleteArticleBTN_Click(object sender, EventArgs e)
        {
            
            foreach (var article in CurrentUser.ArticleList)
            {
                if (Convert.ToString(ArticleListB.SelectedItem) == article.Split("?& ")[1])
                {
                    CurrentUser.ArticleList.Remove(article);
                    File.Delete(ArticleListB.SelectedItem + ".txt");
                    break;
                }

            }
            StreamWriter writeToListOFArticles = new StreamWriter(_fileDataPath);
            JsonSerializerOptions options = new JsonSerializerOptions()
            {
                WriteIndented = true,
                Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping
            };
            string renewedJsonData = JsonSerializer.Serialize(CurrentUser.ArticleList, typeof(List<string>), options);
            writeToListOFArticles.Write(renewedJsonData);
            writeToListOFArticles.Close();           

            string jsonData = File.ReadAllText(_fileDataPath);
            if (jsonData == string.Empty)
            {
                CurrentUser.ArticleList = new List<string>();
            }
            else
            {
                CurrentUser.ArticleList = JsonSerializer.Deserialize<List<string>>(jsonData);
                ArticleListB.Items.Clear();
                foreach (string article in CurrentUser.ArticleList)
                {
                    ArticleListB.Items.Add(article.Split("?& ")[1]);
                }

            }
        }
    }
}
