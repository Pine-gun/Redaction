namespace Redaction
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            UserLoginTB = new TextBox();
            label2 = new Label();
            UserPasswordTB = new TextBox();
            label3 = new Label();
            EnterBTN = new Button();
            RegistrateBTN = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 15);
            label1.Name = "label1";
            label1.Size = new Size(119, 15);
            label1.TabIndex = 0;
            label1.Text = "Логин пользователя";
            // 
            // UserLoginTB
            // 
            UserLoginTB.Location = new Point(14, 38);
            UserLoginTB.Name = "UserLoginTB";
            UserLoginTB.Size = new Size(311, 23);
            UserLoginTB.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 71);
            label2.Name = "label2";
            label2.Size = new Size(127, 15);
            label2.TabIndex = 2;
            label2.Text = "Пароль пользователя";
            // 
            // UserPasswordTB
            // 
            UserPasswordTB.Location = new Point(14, 100);
            UserPasswordTB.Name = "UserPasswordTB";
            UserPasswordTB.Size = new Size(311, 23);
            UserPasswordTB.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(14, 259);
            label3.Name = "label3";
            label3.Size = new Size(157, 15);
            label3.TabIndex = 4;
            label3.Text = "Еще не зарегистрированы?";
            // 
            // EnterBTN
            // 
            EnterBTN.Location = new Point(180, 164);
            EnterBTN.Name = "EnterBTN";
            EnterBTN.Size = new Size(145, 33);
            EnterBTN.TabIndex = 5;
            EnterBTN.Text = "Войти";
            EnterBTN.UseVisualStyleBackColor = true;
            EnterBTN.Click += EnterBTN_Click;
            // 
            // RegistrateBTN
            // 
            RegistrateBTN.Location = new Point(192, 255);
            RegistrateBTN.Name = "RegistrateBTN";
            RegistrateBTN.Size = new Size(133, 23);
            RegistrateBTN.TabIndex = 6;
            RegistrateBTN.Text = "Зарегистрироваться";
            RegistrateBTN.UseVisualStyleBackColor = true;
            RegistrateBTN.Click += RegistrateBTN_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(339, 298);
            Controls.Add(RegistrateBTN);
            Controls.Add(EnterBTN);
            Controls.Add(label3);
            Controls.Add(UserPasswordTB);
            Controls.Add(label2);
            Controls.Add(UserLoginTB);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        protected TextBox UserLoginTB;
        private Label label2;
        protected TextBox UserPasswordTB;
        private Label label3;
        private Button EnterBTN;
        private Button RegistrateBTN;
    }
}