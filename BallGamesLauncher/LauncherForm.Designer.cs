namespace BallGamesLauncher
{
    partial class LauncherForm
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
            ballsButton = new Button();
            billiardButton = new Button();
            catchBallsButton = new Button();
            fireworkButton = new Button();
            fruitNinjaButton = new Button();
            SuspendLayout();
            // 
            // ballsButton
            // 
            ballsButton.Location = new Point(25, 176);
            ballsButton.Name = "ballsButton";
            ballsButton.Size = new Size(125, 69);
            ballsButton.TabIndex = 0;
            ballsButton.Text = "Мячики";
            ballsButton.UseVisualStyleBackColor = true;
            ballsButton.Click += ballsButton_Click;
            // 
            // billiardButton
            // 
            billiardButton.Location = new Point(173, 176);
            billiardButton.Name = "billiardButton";
            billiardButton.Size = new Size(125, 69);
            billiardButton.TabIndex = 1;
            billiardButton.Text = "Бильярд";
            billiardButton.UseVisualStyleBackColor = true;
            billiardButton.Click += billiardButton_Click;
            // 
            // catchBallsButton
            // 
            catchBallsButton.Location = new Point(325, 176);
            catchBallsButton.Name = "catchBallsButton";
            catchBallsButton.Size = new Size(125, 69);
            catchBallsButton.TabIndex = 2;
            catchBallsButton.Text = "Ловить шарики";
            catchBallsButton.UseVisualStyleBackColor = true;
            catchBallsButton.Click += catchBallsButton_Click;
            // 
            // fireworkButton
            // 
            fireworkButton.Location = new Point(478, 176);
            fireworkButton.Name = "fireworkButton";
            fireworkButton.Size = new Size(125, 69);
            fireworkButton.TabIndex = 3;
            fireworkButton.Text = "Салют";
            fireworkButton.UseVisualStyleBackColor = true;
            fireworkButton.Click += fireworkButton_Click;
            // 
            // fruitNinjaButton
            // 
            fruitNinjaButton.Location = new Point(636, 176);
            fruitNinjaButton.Name = "fruitNinjaButton";
            fruitNinjaButton.Size = new Size(125, 69);
            fruitNinjaButton.TabIndex = 4;
            fruitNinjaButton.Text = "FruitNinja";
            fruitNinjaButton.UseVisualStyleBackColor = true;
            fruitNinjaButton.Click += fruitNinjaButton_Click;
            // 
            // LauncherForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(fruitNinjaButton);
            Controls.Add(fireworkButton);
            Controls.Add(catchBallsButton);
            Controls.Add(billiardButton);
            Controls.Add(ballsButton);
            Name = "LauncherForm";
            Text = "Лаунчер";
            Load += LauncherForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button ballsButton;
        private Button billiardButton;
        private Button catchBallsButton;
        private Button fireworkButton;
        private Button fruitNinjaButton;
    }
}
