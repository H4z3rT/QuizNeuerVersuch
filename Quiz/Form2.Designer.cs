namespace Quiz
{
    partial class Form2
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
            groupBoxSpielmodus = new GroupBox();
            labelHighscore = new Label();
            comboBoxQuizregion = new ComboBox();
            label2 = new Label();
            label1 = new Label();
            comboBoxSpielmodus = new ComboBox();
            buttonAusloggen = new Button();
            buttonStart = new Button();
            groupBoxSpielmodus.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxSpielmodus
            // 
            groupBoxSpielmodus.Controls.Add(labelHighscore);
            groupBoxSpielmodus.Controls.Add(comboBoxQuizregion);
            groupBoxSpielmodus.Controls.Add(label2);
            groupBoxSpielmodus.Controls.Add(label1);
            groupBoxSpielmodus.Controls.Add(comboBoxSpielmodus);
            groupBoxSpielmodus.Controls.Add(buttonAusloggen);
            groupBoxSpielmodus.Controls.Add(buttonStart);
            groupBoxSpielmodus.Location = new Point(22, 26);
            groupBoxSpielmodus.Margin = new Padding(6, 6, 6, 6);
            groupBoxSpielmodus.Name = "groupBoxSpielmodus";
            groupBoxSpielmodus.Padding = new Padding(6, 6, 6, 6);
            groupBoxSpielmodus.Size = new Size(623, 508);
            groupBoxSpielmodus.TabIndex = 0;
            groupBoxSpielmodus.TabStop = false;
            groupBoxSpielmodus.Text = "Spielmodus";
            // 
            // labelHighscore
            // 
            labelHighscore.AutoSize = true;
            labelHighscore.Location = new Point(201, 41);
            labelHighscore.Margin = new Padding(6, 0, 6, 0);
            labelHighscore.Name = "labelHighscore";
            labelHighscore.Size = new Size(126, 32);
            labelHighscore.TabIndex = 6;
            labelHighscore.Text = "Highscore:";
            // 
            // comboBoxQuizregion
            // 
            comboBoxQuizregion.FormattingEnabled = true;
            comboBoxQuizregion.Location = new Point(201, 218);
            comboBoxQuizregion.Margin = new Padding(6, 6, 6, 6);
            comboBoxQuizregion.Name = "comboBoxQuizregion";
            comboBoxQuizregion.Size = new Size(219, 40);
            comboBoxQuizregion.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(11, 218);
            label2.Margin = new Padding(6, 0, 6, 0);
            label2.Name = "label2";
            label2.Size = new Size(132, 32);
            label2.TabIndex = 4;
            label2.Text = "Quizregion";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(11, 113);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(139, 32);
            label1.TabIndex = 3;
            label1.Text = "Spielmodus";
            // 
            // comboBoxSpielmodus
            // 
            comboBoxSpielmodus.FormattingEnabled = true;
            comboBoxSpielmodus.Location = new Point(201, 107);
            comboBoxSpielmodus.Margin = new Padding(6, 6, 6, 6);
            comboBoxSpielmodus.Name = "comboBoxSpielmodus";
            comboBoxSpielmodus.Size = new Size(331, 40);
            comboBoxSpielmodus.TabIndex = 2;
            // 
            // buttonAusloggen
            // 
            buttonAusloggen.Location = new Point(264, 390);
            buttonAusloggen.Margin = new Padding(6, 6, 6, 6);
            buttonAusloggen.Name = "buttonAusloggen";
            buttonAusloggen.Size = new Size(160, 66);
            buttonAusloggen.TabIndex = 1;
            buttonAusloggen.Text = "Ausloggen";
            buttonAusloggen.UseVisualStyleBackColor = true;
            buttonAusloggen.Click += buttonAusloggen_Click;
            // 
            // buttonStart
            // 
            buttonStart.Location = new Point(11, 390);
            buttonStart.Margin = new Padding(6, 6, 6, 6);
            buttonStart.Name = "buttonStart";
            buttonStart.Size = new Size(160, 66);
            buttonStart.TabIndex = 0;
            buttonStart.Text = "Start";
            buttonStart.UseVisualStyleBackColor = true;
            buttonStart.Click += buttonStart_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(681, 550);
            Controls.Add(groupBoxSpielmodus);
            Margin = new Padding(6, 6, 6, 6);
            Name = "Form2";
            Text = "Form2";
            groupBoxSpielmodus.ResumeLayout(false);
            groupBoxSpielmodus.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxSpielmodus;
        private Label labelHighscore;
        private ComboBox comboBoxQuizregion;
        private Label label2;
        private Label label1;
        private ComboBox comboBoxSpielmodus;
        private Button buttonAusloggen;
        private Button buttonStart;
    }
}