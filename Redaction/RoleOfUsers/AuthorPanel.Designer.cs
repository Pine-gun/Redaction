namespace Redaction.RoleOfUsers
{
    partial class AuthorPanel
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ArticleTextTB=new TextBox();
            ParagrafTextTB=new TextBox();
            label1=new Label();
            HeaderTB=new TextBox();
            label2=new Label();
            label3=new Label();
            UnderHeaderTB=new TextBox();
            AddParagrafBTN=new Button();
            AddUnderHeaderBTN=new Button();
            AddHeaderBTN=new Button();
            label4=new Label();
            ArticleListB=new ListBox();
            AddNewArticleBTN=new Button();
            label5=new Label();
            ArticleNameTB=new TextBox();
            ExitBTN=new Button();
            label6=new Label();
            SaveArticleChangesBTN=new Button();
            OpenArticleBTN=new Button();
            ClearALLFieldsBTN=new Button();
            SuspendLayout();
            // 
            // ArticleTextTB
            // 
            ArticleTextTB.Location=new Point(392, 29);
            ArticleTextTB.Multiline=true;
            ArticleTextTB.Name="ArticleTextTB";
            ArticleTextTB.ScrollBars=ScrollBars.Vertical;
            ArticleTextTB.Size=new Size(362, 598);
            ArticleTextTB.TabIndex=15;
            // 
            // ParagrafTextTB
            // 
            ParagrafTextTB.Location=new Point(971, 219);
            ParagrafTextTB.Multiline=true;
            ParagrafTextTB.Name="ParagrafTextTB";
            ParagrafTextTB.Size=new Size(349, 408);
            ParagrafTextTB.TabIndex=0;
            // 
            // label1
            // 
            label1.AutoSize=true;
            label1.Location=new Point(970, 3);
            label1.Name="label1";
            label1.Size=new Size(103, 15);
            label1.TabIndex=1;
            label1.Text="Заголовок статьи";
            // 
            // HeaderTB
            // 
            HeaderTB.Font=new Font("Segoe UI Black", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            HeaderTB.Location=new Point(971, 29);
            HeaderTB.Multiline=true;
            HeaderTB.Name="HeaderTB";
            HeaderTB.Size=new Size(349, 55);
            HeaderTB.TabIndex=2;
            // 
            // label2
            // 
            label2.AutoSize=true;
            label2.Location=new Point(970, 190);
            label2.Name="label2";
            label2.Size=new Size(78, 15);
            label2.TabIndex=3;
            label2.Text="Абзац статьи";
            // 
            // label3
            // 
            label3.AutoSize=true;
            label3.Location=new Point(970, 95);
            label3.Name="label3";
            label3.Size=new Size(123, 15);
            label3.TabIndex=4;
            label3.Text="Подзаголовок статьи";
            // 
            // UnderHeaderTB
            // 
            UnderHeaderTB.Font=new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            UnderHeaderTB.Location=new Point(970, 122);
            UnderHeaderTB.Multiline=true;
            UnderHeaderTB.Name="UnderHeaderTB";
            UnderHeaderTB.Size=new Size(350, 50);
            UnderHeaderTB.TabIndex=5;
            // 
            // AddParagrafBTN
            // 
            AddParagrafBTN.Location=new Point(777, 219);
            AddParagrafBTN.Name="AddParagrafBTN";
            AddParagrafBTN.Size=new Size(188, 23);
            AddParagrafBTN.TabIndex=6;
            AddParagrafBTN.Text="Добавить абзац";
            AddParagrafBTN.UseVisualStyleBackColor=true;
            AddParagrafBTN.Click+=AddParagrafBTN_Click;
            // 
            // AddUnderHeaderBTN
            // 
            AddUnderHeaderBTN.Location=new Point(777, 122);
            AddUnderHeaderBTN.Name="AddUnderHeaderBTN";
            AddUnderHeaderBTN.Size=new Size(187, 23);
            AddUnderHeaderBTN.TabIndex=7;
            AddUnderHeaderBTN.Text="Добавить подзаголовок";
            AddUnderHeaderBTN.UseVisualStyleBackColor=true;
            AddUnderHeaderBTN.Click+=AddUnderHeaderBTN_Click;
            // 
            // AddHeaderBTN
            // 
            AddHeaderBTN.Location=new Point(777, 29);
            AddHeaderBTN.Name="AddHeaderBTN";
            AddHeaderBTN.Size=new Size(188, 23);
            AddHeaderBTN.TabIndex=8;
            AddHeaderBTN.Text="Добавить заголовок";
            AddHeaderBTN.UseVisualStyleBackColor=true;
            AddHeaderBTN.Click+=AddHeaderBTN_Click;
            // 
            // label4
            // 
            label4.AutoSize=true;
            label4.Location=new Point(17, 147);
            label4.Name="label4";
            label4.Size=new Size(86, 15);
            label4.TabIndex=9;
            label4.Text="Список статей";
            // 
            // ArticleListB
            // 
            ArticleListB.FormattingEnabled=true;
            ArticleListB.ItemHeight=15;
            ArticleListB.Location=new Point(17, 165);
            ArticleListB.Name="ArticleListB";
            ArticleListB.Size=new Size(344, 349);
            ArticleListB.TabIndex=10;
            // 
            // AddNewArticleBTN
            // 
            AddNewArticleBTN.Location=new Point(17, 96);
            AddNewArticleBTN.Name="AddNewArticleBTN";
            AddNewArticleBTN.Size=new Size(155, 39);
            AddNewArticleBTN.TabIndex=11;
            AddNewArticleBTN.Text="Создать статью";
            AddNewArticleBTN.UseVisualStyleBackColor=true;
            AddNewArticleBTN.Click+=AddNewArticleBTN_Click;
            // 
            // label5
            // 
            label5.AutoSize=true;
            label5.Location=new Point(17, 3);
            label5.Name="label5";
            label5.Size=new Size(97, 15);
            label5.TabIndex=12;
            label5.Text="Название статьи";
            // 
            // ArticleNameTB
            // 
            ArticleNameTB.Location=new Point(17, 29);
            ArticleNameTB.Multiline=true;
            ArticleNameTB.Name="ArticleNameTB";
            ArticleNameTB.Size=new Size(344, 61);
            ArticleNameTB.TabIndex=13;
            // 
            // ExitBTN
            // 
            ExitBTN.Location=new Point(17, 583);
            ExitBTN.Name="ExitBTN";
            ExitBTN.Size=new Size(155, 44);
            ExitBTN.TabIndex=14;
            ExitBTN.Text="Выйти";
            ExitBTN.UseVisualStyleBackColor=true;
            ExitBTN.Click+=ExitBTN_Click;
            // 
            // label6
            // 
            label6.AutoSize=true;
            label6.Location=new Point(392, 3);
            label6.Name="label6";
            label6.Size=new Size(74, 15);
            label6.TabIndex=16;
            label6.Text="Текст статьи";
            // 
            // SaveArticleChangesBTN
            // 
            SaveArticleChangesBTN.Location=new Point(777, 583);
            SaveArticleChangesBTN.Name="SaveArticleChangesBTN";
            SaveArticleChangesBTN.Size=new Size(169, 44);
            SaveArticleChangesBTN.TabIndex=17;
            SaveArticleChangesBTN.Text="Сохранить изменения";
            SaveArticleChangesBTN.UseVisualStyleBackColor=true;
            SaveArticleChangesBTN.Click+=SaveArticleChangesBTN_Click;
            // 
            // OpenArticleBTN
            // 
            OpenArticleBTN.Location=new Point(17, 520);
            OpenArticleBTN.Name="OpenArticleBTN";
            OpenArticleBTN.Size=new Size(155, 48);
            OpenArticleBTN.TabIndex=18;
            OpenArticleBTN.Text="Открыть статью";
            OpenArticleBTN.UseVisualStyleBackColor=true;
            OpenArticleBTN.Click+=OpenArticleBTN_Click;
            // 
            // ClearALLFieldsBTN
            // 
            ClearALLFieldsBTN.Location=new Point(777, 314);
            ClearALLFieldsBTN.Name="ClearALLFieldsBTN";
            ClearALLFieldsBTN.Size=new Size(188, 23);
            ClearALLFieldsBTN.TabIndex=19;
            ClearALLFieldsBTN.Text="Очистить все поля";
            ClearALLFieldsBTN.UseVisualStyleBackColor=true;
            ClearALLFieldsBTN.Click+=ClearALLFieldsBTN_Click;
            // 
            // AuthorPanel
            // 
            AutoScaleDimensions=new SizeF(7F, 15F);
            AutoScaleMode=AutoScaleMode.Font;
            ClientSize=new Size(1345, 639);
            Controls.Add(ClearALLFieldsBTN);
            Controls.Add(OpenArticleBTN);
            Controls.Add(SaveArticleChangesBTN);
            Controls.Add(label6);
            Controls.Add(ArticleTextTB);
            Controls.Add(ExitBTN);
            Controls.Add(ArticleNameTB);
            Controls.Add(label5);
            Controls.Add(AddNewArticleBTN);
            Controls.Add(ArticleListB);
            Controls.Add(label4);
            Controls.Add(AddHeaderBTN);
            Controls.Add(AddUnderHeaderBTN);
            Controls.Add(AddParagrafBTN);
            Controls.Add(UnderHeaderTB);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(HeaderTB);
            Controls.Add(label1);
            Controls.Add(ParagrafTextTB);
            Name="AuthorPanel";
            Text="AuthorPanel";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox ParagrafTextTB;
        private Label label1;
        private TextBox HeaderTB;
        private Label label2;
        private Label label3;
        private TextBox UnderHeaderTB;
        private Button AddParagrafBTN;
        private Button AddUnderHeaderBTN;
        private Button AddHeaderBTN;
        private Label label4;
        private ListBox ArticleListB;
        private Button AddNewArticleBTN;
        private Label label5;
        private TextBox ArticleNameTB;
        private Button ExitBTN;
        private TextBox ArticleTextTB;
        private Label label6;
        private Button SaveArticleChangesBTN;
        private Button OpenArticleBTN;
        private Button ClearALLFieldsBTN;
    }
}