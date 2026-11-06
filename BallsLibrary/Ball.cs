using System;
using System.Collections.Generic;
using System.Text;
using Timer = System.Windows.Forms.Timer;

namespace BallsLibrary
{
    public class Ball
    {
        protected Form mainForm { get; set; }
        private Timer timer;
        public int CenterX { get; protected set; } = 200;
        public int CenterY { get; protected set; } = 200;
        protected int v_x = 3;
        protected int v_y = 3;
        public int Radius { get; protected set; } = 40;
        public Ball(Form mainForm)
        {
            this.mainForm = mainForm;
            timer = new Timer();
            timer.Interval = 20;
            timer.Tick += Timer_Tick;
        }
        public void Start()
        {
            timer.Start();
        }
        public void Stop()
        {
            timer.Stop();
        }
        private void Timer_Tick(object? sender, EventArgs e)
        {
            Move();
        }
        public int LeftSide()
        {
            return Radius;
        }
        public int RightSide()
        {
            return mainForm.ClientSize.Width - Radius;
        }
        public int TopSide()
        {
            return Radius;
        }
        public int DownSide()
        {
            return  mainForm.ClientSize.Height - Radius;
        }
        public bool IsOnForm()
        {
            return (CenterX >= LeftSide() && CenterX <= RightSide() && CenterY >= TopSide() && CenterY <= DownSide());
        }
        public void Show()
        {
            Brush brush = Brushes.Green;
            Draw(brush);
        }
        public void Move()
        {
            Clear();
            Go();
            Show();
        }
        protected virtual void Go()
        {
            CenterX += v_x;
            CenterY += v_y;
        }
        public void Clear()
        {
            Brush brush = Brushes.White;
            Draw(brush);
        }
        private void Draw(Brush brush)
        {
            Graphics graphics = mainForm.CreateGraphics();
            Rectangle rectangle = new Rectangle(CenterX - Radius, CenterY - Radius, 2 * Radius, 2 * Radius);
            graphics.FillEllipse(brush, rectangle);
        }

    }
}
