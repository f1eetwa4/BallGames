using System;
using System.Collections.Generic;
using System.Text;

namespace BallGamesWindowsFormsApp
{
    public class Ball
    {
        private MainForm mainForm { get; set; }
        protected int x { get; set; } = 200;
        private int v_x = 3;
        private int v_y = 3;
        protected int y { get; set; } = 200;
        protected int size { get; set; } = 80;
        public Ball(MainForm mainForm)
        {
            this.mainForm = mainForm;
        }
        public void Show()
        {
            Graphics graphics = mainForm.CreateGraphics();
            Brush brush = Brushes.Green;
            Rectangle rectangle = new Rectangle(x, y, size, size);

            graphics.FillEllipse(brush, rectangle);
        }
        public void Move()
        {
            Clear();
            Go();
            Show();
        }
        private void Go()
        {
            x += v_x;
            y += v_y;
        }
        private void Clear()
        {
            Graphics graphics = mainForm.CreateGraphics();
            Brush brush = Brushes.White;
            Rectangle rectangle = new Rectangle(x, y, size, size);

            graphics.FillEllipse(brush, rectangle);
        }
        
    }
}
