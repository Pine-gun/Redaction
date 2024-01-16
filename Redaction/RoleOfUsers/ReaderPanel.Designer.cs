namespace Redaction.RoleOfUsers
{
    partial class ReaderPanel
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
            ExitBTN=new Button();
            ArticleListB=new ListBox();
            label4=new Label();
            ReadArticleBTN=new Button();
            ArticleTextTB=new TextBox();
            label1=new Label();
            SaveArticleChangesBTN=new Button();
            SuspendLayout();
            // 
            // ExitBTN
            // 
            ExitBTN.Location=new Point(12, 580);
            ExitBTN.Name="ExitBTN";
            ExitBTN.Size=new Size(155, 44);
            ExitBTN.TabIndex=20;
            ExitBTN.Text="Выйти";
            ExitBTN.UseVisualStyleBackColor=true;
            ExitBTN.Click+=ExitBTN_Click;
            // 
            // ArticleListB
            // 
            ArticleListB.FormattingEnabled=true;
            ArticleListB.ItemHeight=15;
            ArticleListB.Location=new Point(12, 26);
            ArticleListB.Name="ArticleListB";
            ArticleListB.Size=new Size(344, 439);
            ArticleListB.TabIndex=19;
            // 
            // label4
            // 
            label4.AutoSize=true;
            label4.Location=new Point(12, 0);
            label4.Name="label4";
            label4.Size=new Size(86, 15);
            label4.TabIndex=18;
            label4.Text="Список статей";
            // 
            // ReadArticleBTN
            // 
            ReadArticleBTN.Location=new Point(12, 482);
            ReadArticleBTN.Name="ReadArticleBTN";
            ReadArticleBTN.Size=new Size(155, 43);
            ReadArticleBTN.TabIndex=21;
            ReadArticleBTN.Text="Читать статью";
            ReadArticleBTN.UseVisualStyleBackColor=true;
            ReadArticleBTN.Click+=ReadArticleBTN_Click;
            // 
            // ArticleTextTB
            // 
            ArticleTextTB.Location=new Point(409, 26);
            ArticleTextTB.Multiline=true;
            ArticleTextTB.Name="ArticleTextTB";
            ArticleTextTB.Size=new Size(585, 527);
            ArticleTextTB.TabIndex=22;
            // 
            // label1
            // 
            label1.AutoSize=true;
            label1.Location=new Point(411, 5);
            label1.Name="label1";
            label1.Size=new Size(74, 15);
            label1.TabIndex=23;
            label1.Text="Текст статьи";
            // 
            // SaveArticleChangesBTN
            // 
            SaveArticleChangesBTN.Location=new Point(827, 580);
            SaveArticleChangesBTN.Name="SaveArticleChangesBTN";
            SaveArticleChangesBTN.Size=new Size(167, 44);
            SaveArticleChangesBTN.TabIndex=24;
            SaveArticleChangesBTN.Text="Сохранить изменения";
            SaveArticleChangesBTN.UseMnemonic=false;
            SaveArticleChangesBTN.UseVisualStyleBackColor=true;
            SaveArticleChangesBTN.Click+=SaveArticleChangesBTN_Click;
            // 
            // ReaderPanel
            // 
            AutoScaleDimensions=new SizeF(7F, 15F);
            AutoScaleMode=AutoScaleMode.Font;
            ClientSize=new Size(1012, 639);
            Controls.Add(SaveArticleChangesBTN);
            Controls.Add(label1);
            Controls.Add(ArticleTextTB);
            Controls.Add(ReadArticleBTN);
            Controls.Add(ExitBTN);
            Controls.Add(ArticleListB);
            Controls.Add(label4);
            Name="ReaderPanel";
            Text="ReaderPanel";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button ExitBTN;
        private ListBox ArticleListB;
        private Label label4;
        private Button ReadArticleBTN;
        private TextBox ArticleTextTB;
        private Label label1;
        private Button SaveArticleChangesBTN;
    }
}