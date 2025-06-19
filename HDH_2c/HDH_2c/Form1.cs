using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HDH_2c
{
    public partial class Form1 : Form
    {
        private Timer timer;
        private List<Column> columns;
        private Random random;

        // Lớp Column với tham số Random được truyền vào
        private class Column
        {
            public int X { get; set; }
            public int Y { get; set; }
            public int Speed { get; set; }
            public List<char> Characters { get; set; }
            private readonly Random random;

            public Column(int x, int maxHeight, Random rand)
            {
                random = rand;
                X = x;
                Y = -random.Next(maxHeight);
                Speed = random.Next(1, 4);
                Characters = new List<char>();
                for (int i = 0; i < maxHeight / 20; i++)
                    Characters.Add(GetRandomChar());
            }

            public void Update()
            {
                Y += Speed;
                if (Y > 889) Y = -random.Next(200); // Điều chỉnh theo chiều cao form (889)
            }

            public char GetRandomChar()
            {
                return (char)random.Next(2) == 0 ? '0' : '1'; // Sử dụng 0 hoặc 1
            }
        }

        public Form1()
        {
            InitializeComponent();
            this.Size = new Size(800, 550); // Đặt lại kích thước form theo thiết kế ban đầu
            this.BackColor = Color.Black; // Đổi nền thành màu đen
            label1.ForeColor = Color.White; // Đổi màu chữ label thành trắng để hiển thị trên nền đen
            InitializeAnimation();
        }

        private void InitializeAnimation()
        {
            random = new Random();
            columns = new List<Column>();
            int columnCount = this.Width / 20;
            for (int i = 0; i < columnCount; i++)
            {
                columns.Add(new Column(i * 20, this.Height, random));
            }

            timer = new Timer
            {
                Interval = 50
            };
            timer.Tick += Timer_Tick;
            timer.Start();

            this.DoubleBuffered = true;
            this.Paint += Form1_Paint;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            foreach (var column in columns)
            {
                column.Update();
                column.Characters.RemoveAt(0);
                column.Characters.Add(column.GetRandomChar());
            }
            this.Invalidate();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Brush greenBrush = new SolidBrush(Color.LimeGreen); // Màu xanh lá cho 0,1
            Brush fadeBrush = new SolidBrush(Color.FromArgb(0, 64, 0)); // Màu mờ hơn

            foreach (var column in columns)
            {
                for (int i = 0; i < column.Characters.Count; i++)
                {
                    int y = column.Y + (i * 20);
                    if (y >= 0 && y < this.Height)
                    {
                        if (i == column.Characters.Count - 1)
                            g.DrawString(column.Characters[i].ToString(), new Font("Courier New", 12), greenBrush, column.X, y);
                        else
                            g.DrawString(column.Characters[i].ToString(), new Font("Courier New", 12), fadeBrush, column.X, y);
                    }
                }
            }
        }

        private void btnBanker_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormBanker formBanker = new FormBanker();
            formBanker.ShowDialog();
            this.Show();
        }

        private void btnCPUScheduling_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormCPU formCPU = new FormCPU();
            formCPU.ShowDialog();
            this.Show();
        }

        private void btnPFSR_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormPFSR formPFSR = new FormPFSR();
            formPFSR.ShowDialog();
            this.Show();
        }

        private void btnAboutUs_Click(object sender, EventArgs e)
        {
            FormAboutUs formAboutUs = new FormAboutUs();
            formAboutUs.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnDiskScheduling_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormDiskScheduling formDisk = new FormDiskScheduling();
            formDisk.ShowDialog();
            this.Show();
        }
    }
}