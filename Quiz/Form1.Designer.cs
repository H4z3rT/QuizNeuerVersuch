namespace Quiz
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
            groupBoxLogin = new GroupBox();
            buttonRegister = new Button();
            buttonLogin = new Button();
            textBoxPasswort = new TextBox();
            label2 = new Label();
            label1 = new Label();
            textBoxUsername = new TextBox();
            groupBoxLogin.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxLogin
            // 
            groupBoxLogin.Controls.Add(buttonRegister);
            groupBoxLogin.Controls.Add(buttonLogin);
            groupBoxLogin.Controls.Add(textBoxPasswort);
            groupBoxLogin.Controls.Add(label2);
            groupBoxLogin.Controls.Add(label1);
            groupBoxLogin.Controls.Add(textBoxUsername);
            groupBoxLogin.Location = new Point(12, 12);
            groupBoxLogin.Name = "groupBoxLogin";
            groupBoxLogin.Size = new Size(279, 217);
            groupBoxLogin.TabIndex = 0;
            groupBoxLogin.TabStop = false;
            groupBoxLogin.Text = "Login";
            // 
            // buttonRegister
            // 
            buttonRegister.Location = new Point(146, 138);
            buttonRegister.Name = "buttonRegister";
            buttonRegister.Size = new Size(75, 23);
            buttonRegister.TabIndex = 5;
            buttonRegister.Text = "Register";
            buttonRegister.UseVisualStyleBackColor = true;
            buttonRegister.Click += btnRegister_Click;
            // 
            // buttonLogin
            // 
            buttonLogin.Location = new Point(26, 138);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(75, 23);
            buttonLogin.TabIndex = 4;
            buttonLogin.Text = "Login";
            buttonLogin.UseVisualStyleBackColor = true;
            buttonLogin.Click += btnLogin_Click;
            // 
            // textBoxPasswort
            // 
            textBoxPasswort.Location = new Point(121, 90);
            textBoxPasswort.Name = "textBoxPasswort";
            textBoxPasswort.Size = new Size(100, 23);
            textBoxPasswort.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 93);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 2;
            label2.Text = "Passwort:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 51);
            label1.Name = "label1";
            label1.Size = new Size(63, 15);
            label1.TabIndex = 1;
            label1.Text = "Username:";
            // 
            // textBoxUsername
            // 
            textBoxUsername.Location = new Point(121, 48);
            textBoxUsername.Name = "textBoxUsername";
            textBoxUsername.Size = new Size(100, 23);
            textBoxUsername.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(303, 239);
            Controls.Add(groupBoxLogin);
            Name = "Form1";
            Text = "Form1";
            groupBoxLogin.ResumeLayout(false);
            groupBoxLogin.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxLogin;
        private Button buttonRegister;
        private Button buttonLogin;
        private TextBox textBoxPasswort;
        private Label label2;
        private Label label1;
        private TextBox textBoxUsername;
    }
}
