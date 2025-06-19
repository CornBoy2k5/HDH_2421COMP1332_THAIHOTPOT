using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace HDH_2c // Thay bằng namespace thực tế của bạn
{
    public partial class FormAboutUs : Form
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
                if (Y > 600) Y = -random.Next(200);
            }

            public char GetRandomChar()
            {
                return (char)random.Next(48, 123);
            }
        }

        public FormAboutUs()
        {
            InitializeComponent();
            SetupForm();
            InitializeAnimation();
            // Gắn sự kiện FormClosing
            this.FormClosing += FormAboutUs_FormClosing;
        }

        private void SetupForm()
        {
            this.Text = "About Us";
            this.Size = new System.Drawing.Size(700, 700); // Giảm chiều dài xuống còn 700
            this.BackColor = Color.Black; // Đổi nền thành màu đen
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;

            Label lblGroupName = new Label
            {
                Text = "THAIHOTPOT GROUP",
                Location = new Point(50, 20),
                AutoSize = true,
                Font = new Font("Arial", 14, FontStyle.Bold),
                ForeColor = Color.White // Đổi màu chữ thành trắng để hiển thị trên nền đen
            };
            this.Controls.Add(lblGroupName);

            Label lblMembers = new Label
            {
                Text = "Thành viên:\n" +
                       "- Trần Nguyễn Gia Huy - MSSV: 49.01.104.059\n" +
                       "- Trần Đức Anh - MSSV: 49.01.104.006\n" +
                       "- Ngô Dương Đức Thắng - MSSV: 49.01.104.137\n" +
                       "- Nguyễn Thị Vinh - MSSV: 49.01.104.175",
                Location = new Point(50, 50),
                AutoSize = true,
                Font = new Font("Arial", 12),
                ForeColor = Color.White // Đổi màu chữ thành trắng
            };
            this.Controls.Add(lblMembers);

            Label lblDescription = new Label
            {
                Text = "Chương trình này được thiết kế để mô phỏng các yêu cầu sau:.\n" +
                       "   a/ Dùng giải thuật Banker để tránh, phát hiện và giải quyết Deadlock \n" +
                       "   b/ Giải thuật phân phối CPU cho các tiếng trình \n" +
                       "   c/ Giải thuật thay thế trong quy trình PFSR \n" +
                       "   d/ Giải thuật định thời truy cập đĩa để quản lý tập tin \n" +
                       "Nhóm em xin chân thành cảm ơn GVHD-ThS.Trần Quang Huy đã hướng dẫn và hỗ trợ \n" +
                       "nhóm chúng em trong suốt quá trình học tập.",
                Location = new Point(50, 150),
                AutoSize = true,
                Font = new Font("Arial", 12),
                ForeColor = Color.White // Đổi màu chữ thành trắng
            };
            this.Controls.Add(lblDescription);

            Button btnBack = new Button
            {
                Text = "Back",
                Location = new Point(50, 500),
                Size = new Size(100, 50),
                ForeColor = Color.White,
                BackColor = Color.Gray
            };
            btnBack.Click += BtnBack_Click;
            this.Controls.Add(btnBack);
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.Close(); // Đóng form About Us để quay về form trước
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
            this.Paint += FormAboutUs_Paint;
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

        private void FormAboutUs_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Brush greenBrush = new SolidBrush(Color.FromArgb(0, 255, 0));
            Brush fadeBrush = new SolidBrush(Color.FromArgb(0, 128, 0));

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

        private void FormAboutUs_FormClosing(object sender, FormClosingEventArgs e)
        {
            timer.Stop(); // Dừng timer khi đóng form
        }
    }
}