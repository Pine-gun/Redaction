namespace Redaction
{
    partial class RegistrationForm
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
            label1=new Label();
            NickNameTB=new TextBox();
            label2=new Label();
            NameTB=new TextBox();
            label3=new Label();
            SecondNameTB=new TextBox();
            label4=new Label();
            EmailTB=new TextBox();
            label5=new Label();
            PasswordTB=new TextBox();
            label6=new Label();
            BirthDateDTP=new DateTimePicker();
            RegistrateUserBTN=new Button();
            AuthorCB=new CheckBox();
            ReaderCB=new CheckBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize=true;
            label1.Location=new Point(23, 17);
            label1.Name="label1";
            label1.Size=new Size(60, 15);
            label1.TabIndex=0;
            label1.Text="НикНейм";
            // 
            // NickNameTB
            // 
            NickNameTB.Location=new Point(137, 17);
            NickNameTB.Name="NickNameTB";
            NickNameTB.Size=new Size(250, 23);
            NickNameTB.TabIndex=1;
            // 
            // label2
            // 
            label2.AutoSize=true;
            label2.Location=new Point(23, 55);
            label2.Name="label2";
            label2.Size=new Size(31, 15);
            label2.TabIndex=2;
            label2.Text="Имя";
            // 
            // NameTB
            // 
            NameTB.Location=new Point(137, 55);
            NameTB.Name="NameTB";
            NameTB.Size=new Size(250, 23);
            NameTB.TabIndex=3;
            // 
            // label3
            // 
            label3.AutoSize=true;
            label3.Location=new Point(23, 96);
            label3.Name="label3";
            label3.Size=new Size(58, 15);
            label3.TabIndex=4;
            label3.Text="Фамилия";
            // 
            // SecondNameTB
            // 
            SecondNameTB.Location=new Point(137, 93);
            SecondNameTB.Name="SecondNameTB";
            SecondNameTB.Size=new Size(250, 23);
            SecondNameTB.TabIndex=5;
            // 
            // label4
            // 
            label4.AutoSize=true;
            label4.Location=new Point(23, 136);
            label4.Name="label4";
            label4.Size=new Size(36, 15);
            label4.TabIndex=6;
            label4.Text="Email";
            // 
            // EmailTB
            // 
            EmailTB.Location=new Point(137, 133);
            EmailTB.Name="EmailTB";
            EmailTB.Size=new Size(250, 23);
            EmailTB.TabIndex=7;
            // 
            // label5
            // 
            label5.AutoSize=true;
            label5.Location=new Point(23, 181);
            label5.Name="label5";
            label5.Size=new Size(49, 15);
            label5.TabIndex=8;
            label5.Text="Пароль";
            // 
            // PasswordTB
            // 
            PasswordTB.Location=new Point(137, 173);
            PasswordTB.Name="PasswordTB";
            PasswordTB.Size=new Size(249, 23);
            PasswordTB.TabIndex=9;
            // 
            // label6
            // 
            label6.AutoSize=true;
            label6.Location=new Point(23, 219);
            label6.Name="label6";
            label6.Size=new Size(90, 15);
            label6.TabIndex=10;
            label6.Text="Дата рождения";
            // 
            // BirthDateDTP
            // 
            BirthDateDTP.Location=new Point(137, 219);
            BirthDateDTP.Name="BirthDateDTP";
            BirthDateDTP.Size=new Size(249, 23);
            BirthDateDTP.TabIndex=11;
            // 
            // RegistrateUserBTN
            // 
            RegistrateUserBTN.Location=new Point(23, 324);
            RegistrateUserBTN.Name="RegistrateUserBTN";
            RegistrateUserBTN.Size=new Size(363, 23);
            RegistrateUserBTN.TabIndex=12;
            RegistrateUserBTN.Text="Зарегистрироваться";
            RegistrateUserBTN.UseVisualStyleBackColor=true;
            RegistrateUserBTN.Click+=RegistrateUserBTN_Click;
            // 
            // AuthorCB
            // 
            AuthorCB.AutoSize=true;
            AuthorCB.Location=new Point(136, 256);
            AuthorCB.Name="AuthorCB";
            AuthorCB.Size=new Size(59, 19);
            AuthorCB.TabIndex=13;
            AuthorCB.Text="Автор";
            AuthorCB.UseVisualStyleBackColor=true;
            AuthorCB.Click+=AuthorCB_Click;
            // 
            // ReaderCB
            // 
            ReaderCB.AutoSize=true;
            ReaderCB.Location=new Point(136, 281);
            ReaderCB.Name="ReaderCB";
            ReaderCB.Size=new Size(76, 19);
            ReaderCB.TabIndex=14;
            ReaderCB.Text="Читатель";
            ReaderCB.UseVisualStyleBackColor=true;
            ReaderCB.Click+=ReaderCB_Click;
            // 
            // RegistrationForm
            // 
            AutoScaleDimensions=new SizeF(7F, 15F);
            AutoScaleMode=AutoScaleMode.Font;
            ClientSize=new Size(423, 370);
            Controls.Add(ReaderCB);
            Controls.Add(AuthorCB);
            Controls.Add(RegistrateUserBTN);
            Controls.Add(BirthDateDTP);
            Controls.Add(label6);
            Controls.Add(PasswordTB);
            Controls.Add(label5);
            Controls.Add(EmailTB);
            Controls.Add(label4);
            Controls.Add(SecondNameTB);
            Controls.Add(label3);
            Controls.Add(NameTB);
            Controls.Add(label2);
            Controls.Add(NickNameTB);
            Controls.Add(label1);
            Name="RegistrationForm";
            Text="RegistrationForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox NickNameTB;
        private Label label2;
        private TextBox NameTB;
        private Label label3;
        private TextBox SecondNameTB;
        private Label label4;
        private TextBox EmailTB;
        private Label label5;
        private TextBox PasswordTB;
        private Label label6;
        private DateTimePicker BirthDateDTP;
        private Button RegistrateUserBTN;
        private CheckBox AuthorCB;
        private CheckBox ReaderCB;
    }
}