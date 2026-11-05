namespace BallGamesWindowsFormsApp
{
    partial class MainForm
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
            stopButton = new Button();
            createButton = new Button();
            SuspendLayout();
            // 
            // stopButton
            // 
            stopButton.Location = new Point(621, 12);
            stopButton.Name = "stopButton";
            stopButton.Size = new Size(167, 30);
            stopButton.TabIndex = 2;
            stopButton.Text = "Остановить все шарики";
            stopButton.UseVisualStyleBackColor = true;
            stopButton.Click += button3_Click;
            // 
            // createButton
            // 
            createButton.Location = new Point(391, 12);
            createButton.Name = "createButton";
            createButton.Size = new Size(210, 30);
            createButton.TabIndex = 3;
            createButton.Text = "Создать";
            createButton.UseVisualStyleBackColor = true;
            createButton.Click += button4_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(createButton);
            Controls.Add(stopButton);
            Name = "MainForm";
            Text = "Мячики";
            MouseDown += MainForm_MouseDown;
            ResumeLayout(false);
        }

        #endregion
        private Button stopButton;
        private Button createButton;
    }
}
