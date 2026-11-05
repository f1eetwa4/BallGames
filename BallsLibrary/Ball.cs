using System;
using System.Collections.Generic;
using System.Text;

namespace BallsLibrary
{
    public class Ball
    {
        protected Form mainForm { get; set; }
        public int X { get; protected set; } = 200;
        public int Y { get; protected set; } = 200;
        protected int v_x;
        protected int v_y;
        public int Size { get; protected set; } = 80;
        public Ball(Form mainForm)
        {
            this.mainForm = mainForm;
        }
        public void Show()
        {
            Graphics graphics = mainForm.CreateGraphics();
            Brush brush = Brushes.Green;
            Rectangle rectangle = new Rectangle(X, Y, Size, Size);

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
            X += v_x;
            Y += v_y;
        }
        public void Clear()
        {
            Graphics graphics = mainForm.CreateGraphics();
            Brush brush = Brushes.White;
            Rectangle rectangle = new Rectangle(X, Y, Size, Size);

            graphics.FillEllipse(brush, rectangle);
        }
        
    }
}
