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
            groupBoxLogin.Location = new Point(22, 26);
            groupBoxLogin.Margin = new Padding(6, 6, 6, 6);
            groupBoxLogin.Name = "groupBoxLogin";
            groupBoxLogin.Padding = new Padding(6, 6, 6, 6);
            groupBoxLogin.Size = new Size(518, 463);
            groupBoxLogin.TabIndex = 0;
            groupBoxLogin.TabStop = false;
            groupBoxLogin.Text = "Login";
            // 
            // buttonRegister
            // 
            buttonRegister.Location = new Point(271, 294);
            buttonRegister.Margin = new Padding(6, 6, 6, 6);
            buttonRegister.Name = "buttonRegister";
            buttonRegister.Size = new Size(139, 49);
            buttonRegister.TabIndex = 5;
            buttonRegister.Text = "Register";
            buttonRegister.UseVisualStyleBackColor = true;
            buttonRegister.Click += btnRegister_Click;
            // 
            // buttonLogin
            // 
            buttonLogin.Location = new Point(48, 294);
            buttonLogin.Margin = new Padding(6, 6, 6, 6);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(139, 49);
            buttonLogin.TabIndex = 4;
            buttonLogin.Text = "Login";
            buttonLogin.UseVisualStyleBackColor = true;
            buttonLogin.Click += btnLogin_Click;
            // 
            // textBoxPasswort
            // 
            textBoxPasswort.Location = new Point(225, 192);
            textBoxPasswort.Margin = new Padding(6, 6, 6, 6);
            textBoxPasswort.Name = "textBoxPasswort";
            textBoxPasswort.Size = new Size(182, 39);
            textBoxPasswort.TabIndex = 3;
            textBoxPasswort.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(48, 198);
            label2.Margin = new Padding(6, 0, 6, 0);
            label2.Name = "label2";
            label2.Size = new Size(110, 32);
            label2.TabIndex = 2;
            label2.Text = "Passwort:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(48, 109);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(126, 32);
            label1.TabIndex = 1;
            label1.Text = "Username:";
            // 
            // textBoxUsername
            // 
            textBoxUsername.Location = new Point(225, 102);
            textBoxUsername.Margin = new Padding(6, 6, 6, 6);
            textBoxUsername.Name = "textBoxUsername";
            textBoxUsername.Size = new Size(182, 39);
            textBoxUsername.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(563, 510);
            Controls.Add(groupBoxLogin);
            Margin = new Padding(6, 6, 6, 6);
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
