namespace BilliardBallsWindowsFormsApp
{
    partial class BilliardBallsForm
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
            secondGasLeftLabel = new Label();
            firstGasTopLabel = new Label();
            firstGasRightLabel = new Label();
            firstGasDownLabel = new Label();
            secondGasTopLabel = new Label();
            secondGasDownLabel = new Label();
            firstGasLeftLabel = new Label();
            panel1 = new Panel();
            secondGasRightLabel = new Label();
            SuspendLayout();
            // 
            // secondGasLeftLabel
            // 
            secondGasLeftLabel.AutoSize = true;
            secondGasLeftLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            secondGasLeftLabel.ForeColor = Color.Red;
            secondGasLeftLabel.Location = new Point(12, 303);
            secondGasLeftLabel.Name = "secondGasLeftLabel";
            secondGasLeftLabel.Size = new Size(19, 21);
            secondGasLeftLabel.TabIndex = 0;
            secondGasLeftLabel.Text = "0";
            // 
            // firstGasTopLabel
            // 
            firstGasTopLabel.AutoSize = true;
            firstGasTopLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            firstGasTopLabel.ForeColor = Color.Blue;
            firstGasTopLabel.Location = new Point(355, 9);
            firstGasTopLabel.Name = "firstGasTopLabel";
            firstGasTopLabel.Size = new Size(19, 21);
            firstGasTopLabel.TabIndex = 1;
            firstGasTopLabel.Text = "0";
            // 
            // firstGasRightLabel
            // 
            firstGasRightLabel.AutoSize = true;
            firstGasRightLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            firstGasRightLabel.ForeColor = Color.Blue;
            firstGasRightLabel.Location = new Point(773, 122);
            firstGasRightLabel.Name = "firstGasRightLabel";
            firstGasRightLabel.Size = new Size(19, 21);
            firstGasRightLabel.TabIndex = 2;
            firstGasRightLabel.Text = "0";
            // 
            // firstGasDownLabel
            // 
            firstGasDownLabel.AutoSize = true;
            firstGasDownLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            firstGasDownLabel.ForeColor = Color.Blue;
            firstGasDownLabel.Location = new Point(355, 420);
            firstGasDownLabel.Name = "firstGasDownLabel";
            firstGasDownLabel.Size = new Size(19, 21);
            firstGasDownLabel.TabIndex = 3;
            firstGasDownLabel.Text = "0";
            // 
            // secondGasTopLabel
            // 
            secondGasTopLabel.AutoSize = true;
            secondGasTopLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            secondGasTopLabel.ForeColor = Color.Red;
            secondGasTopLabel.Location = new Point(425, 9);
            secondGasTopLabel.Name = "secondGasTopLabel";
            secondGasTopLabel.Size = new Size(19, 21);
            secondGasTopLabel.TabIndex = 6;
            secondGasTopLabel.Text = "0";
            // 
            // secondGasDownLabel
            // 
            secondGasDownLabel.AutoSize = true;
            secondGasDownLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            secondGasDownLabel.ForeColor = Color.Red;
            secondGasDownLabel.Location = new Point(425, 420);
            secondGasDownLabel.Name = "secondGasDownLabel";
            secondGasDownLabel.Size = new Size(19, 21);
            secondGasDownLabel.TabIndex = 7;
            secondGasDownLabel.Text = "0";
            // 
            // firstGasLeftLabel
            // 
            firstGasLeftLabel.AutoSize = true;
            firstGasLeftLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            firstGasLeftLabel.ForeColor = Color.Blue;
            firstGasLeftLabel.Location = new Point(12, 122);
            firstGasLeftLabel.Name = "firstGasLeftLabel";
            firstGasLeftLabel.Size = new Size(19, 21);
            firstGasLeftLabel.TabIndex = 8;
            firstGasLeftLabel.Text = "0";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Location = new Point(399, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(2, 450);
            panel1.TabIndex = 9;
            // 
            // secondGasRightLabel
            // 
            secondGasRightLabel.AutoSize = true;
            secondGasRightLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            secondGasRightLabel.ForeColor = Color.Red;
            secondGasRightLabel.Location = new Point(773, 303);
            secondGasRightLabel.Name = "secondGasRightLabel";
            secondGasRightLabel.Size = new Size(19, 21);
            secondGasRightLabel.TabIndex = 10;
            secondGasRightLabel.Text = "0";
            // 
            // BilliardBallsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(secondGasRightLabel);
            Controls.Add(panel1);
            Controls.Add(firstGasLeftLabel);
            Controls.Add(secondGasDownLabel);
            Controls.Add(secondGasTopLabel);
            Controls.Add(firstGasDownLabel);
            Controls.Add(firstGasRightLabel);
            Controls.Add(firstGasTopLabel);
            Controls.Add(secondGasLeftLabel);
            Name = "BilliardBallsForm";
            Text = "BilliardBalls";
            FormClosing += BilliardBallsForm_FormClosing;
            Load += Form1_Load;
            Shown += BilliardBallsForm_Shown;
            Paint += BilliardBallsForm_Paint;
            MouseDown += BilliardBallsForm_MouseDown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label secondGasLeftLabel;
        private Label firstGasTopLabel;
        private Label firstGasRightLabel;
        private Label firstGasDownLabel;
        private Label secondGasTopLabel;
        private Label secondGasDownLabel;
        private Label firstGasLeftLabel;
        private Panel panel1;
        private Label secondGasRightLabel;
    }
}
