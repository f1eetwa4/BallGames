namespace CatchBallsWindowsFormsApp
{
    partial class CatchBallForm
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
            createButton = new Button();
            caughtBallsTitleLabel = new Label();
            caughtBallsLabel = new Label();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // createButton
            // 
            createButton.BackColor = Color.FromArgb(255, 255, 128);
            createButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            createButton.Location = new Point(0, 0);
            createButton.Name = "createButton";
            createButton.Size = new Size(105, 32);
            createButton.TabIndex = 0;
            createButton.Text = "Создать";
            createButton.UseVisualStyleBackColor = false;
            createButton.Click += createButton_Click;
            // 
            // caughtBallsTitleLabel
            // 
            caughtBallsTitleLabel.AutoSize = true;
            caughtBallsTitleLabel.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            caughtBallsTitleLabel.Location = new Point(478, 7);
            caughtBallsTitleLabel.Name = "caughtBallsTitleLabel";
            caughtBallsTitleLabel.Size = new Size(257, 20);
            caughtBallsTitleLabel.TabIndex = 1;
            caughtBallsTitleLabel.Text = "Количество пойманных шариков:";
            // 
            // caughtBallsLabel
            // 
            caughtBallsLabel.AutoSize = true;
            caughtBallsLabel.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            caughtBallsLabel.ForeColor = Color.Black;
            caughtBallsLabel.Location = new Point(741, 7);
            caughtBallsLabel.Name = "caughtBallsLabel";
            caughtBallsLabel.Size = new Size(18, 20);
            caughtBallsLabel.TabIndex = 2;
            caughtBallsLabel.Text = "0";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(128, 255, 128);
            panel1.Controls.Add(createButton);
            panel1.Controls.Add(caughtBallsLabel);
            panel1.Controls.Add(caughtBallsTitleLabel);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 32);
            panel1.TabIndex = 3;
            // 
            // CatchBallForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Name = "CatchBallForm";
            Text = "Form1";
            MouseDown += CatchBallForm_MouseDown;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button createButton;
        private Label caughtBallsTitleLabel;
        private Label caughtBallsLabel;
        private Panel panel1;
    }
}
