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
            leftLabel = new Label();
            topLabel = new Label();
            rightLabel = new Label();
            downLabel = new Label();
            createButton = new Button();
            deleteButton = new Button();
            SuspendLayout();
            // 
            // leftLabel
            // 
            leftLabel.AutoSize = true;
            leftLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            leftLabel.Location = new Point(12, 200);
            leftLabel.Name = "leftLabel";
            leftLabel.Size = new Size(15, 17);
            leftLabel.TabIndex = 0;
            leftLabel.Text = "0";
            // 
            // topLabel
            // 
            topLabel.AutoSize = true;
            topLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            topLabel.Location = new Point(379, 9);
            topLabel.Name = "topLabel";
            topLabel.Size = new Size(15, 17);
            topLabel.TabIndex = 1;
            topLabel.Text = "0";
            // 
            // rightLabel
            // 
            rightLabel.AutoSize = true;
            rightLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            rightLabel.Location = new Point(773, 200);
            rightLabel.Name = "rightLabel";
            rightLabel.Size = new Size(15, 17);
            rightLabel.TabIndex = 2;
            rightLabel.Text = "0";
            // 
            // downLabel
            // 
            downLabel.AutoSize = true;
            downLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            downLabel.Location = new Point(379, 424);
            downLabel.Name = "downLabel";
            downLabel.Size = new Size(15, 17);
            downLabel.TabIndex = 3;
            downLabel.Text = "0";
            // 
            // createButton
            // 
            createButton.BackColor = Color.Lime;
            createButton.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            createButton.Location = new Point(12, 9);
            createButton.Name = "createButton";
            createButton.Size = new Size(146, 38);
            createButton.TabIndex = 4;
            createButton.Text = "Создать шары";
            createButton.UseVisualStyleBackColor = false;
            createButton.Click += createButton_Click;
            // 
            // deleteButton
            // 
            deleteButton.BackColor = Color.Red;
            deleteButton.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            deleteButton.Location = new Point(642, 9);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(146, 38);
            deleteButton.TabIndex = 5;
            deleteButton.Text = "Удалить шары";
            deleteButton.UseVisualStyleBackColor = false;
            deleteButton.Click += this.deleteButton_Click;
            // 
            // BilliardBallsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(deleteButton);
            Controls.Add(createButton);
            Controls.Add(downLabel);
            Controls.Add(rightLabel);
            Controls.Add(topLabel);
            Controls.Add(leftLabel);
            Name = "BilliardBallsForm";
            Text = "BilliardBalls";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label leftLabel;
        private Label topLabel;
        private Label rightLabel;
        private Label downLabel;
        private Button createButton;
        private Button deleteButton;
    }
}
