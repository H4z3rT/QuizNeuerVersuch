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
            groupBoxSpielmodus.Location = new Point(12, 12);
            groupBoxSpielmodus.Name = "groupBoxSpielmodus";
            groupBoxSpielmodus.Size = new Size(260, 238);
            groupBoxSpielmodus.TabIndex = 0;
            groupBoxSpielmodus.TabStop = false;
            groupBoxSpielmodus.Text = "Spielmodus";
            // 
            // labelHighscore
            // 
            labelHighscore.AutoSize = true;
            labelHighscore.Location = new Point(108, 19);
            labelHighscore.Name = "labelHighscore";
            labelHighscore.Size = new Size(64, 15);
            labelHighscore.TabIndex = 6;
            labelHighscore.Text = "Highscore:";
            // 
            // comboBoxQuizregion
            // 
            comboBoxQuizregion.FormattingEnabled = true;
            comboBoxQuizregion.Location = new Point(108, 102);
            comboBoxQuizregion.Name = "comboBoxQuizregion";
            comboBoxQuizregion.Size = new Size(120, 23);
            comboBoxQuizregion.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 102);
            label2.Name = "label2";
            label2.Size = new Size(65, 15);
            label2.TabIndex = 4;
            label2.Text = "Quizregion";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 53);
            label1.Name = "label1";
            label1.Size = new Size(69, 15);
            label1.TabIndex = 3;
            label1.Text = "Spielmodus";
            // 
            // comboBoxSpielmodus
            // 
            comboBoxSpielmodus.FormattingEnabled = true;
            comboBoxSpielmodus.Location = new Point(108, 50);
            comboBoxSpielmodus.Name = "comboBoxSpielmodus";
            comboBoxSpielmodus.Size = new Size(120, 23);
            comboBoxSpielmodus.TabIndex = 2;
            // 
            // buttonAusloggen
            // 
            buttonAusloggen.Location = new Point(142, 183);
            buttonAusloggen.Name = "buttonAusloggen";
            buttonAusloggen.Size = new Size(86, 31);
            buttonAusloggen.TabIndex = 1;
            buttonAusloggen.Text = "Ausloggen";
            buttonAusloggen.UseVisualStyleBackColor = true;
            buttonAusloggen.Click += buttonAusloggen_Click;
            // 
            // buttonStart
            // 
            buttonStart.Location = new Point(6, 183);
            buttonStart.Name = "buttonStart";
            buttonStart.Size = new Size(86, 31);
            buttonStart.TabIndex = 0;
            buttonStart.Text = "Start";
            buttonStart.UseVisualStyleBackColor = true;
            buttonStart.Click += buttonStart_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(286, 258);
            Controls.Add(groupBoxSpielmodus);
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