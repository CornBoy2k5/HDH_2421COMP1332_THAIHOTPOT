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
    public partial class FormDiskScheduling : Form
    {
        public FormDiskScheduling()
        {
            InitializeComponent();
            this.Size = new System.Drawing.Size(750, 550);
        }

        private void btnFCFS_MouseEnter(object sender, EventArgs e)
        {
            btnFCFS.BackColor = System.Drawing.Color.LightGreen;
        }

        private void btnFCFS_MouseLeave(object sender, EventArgs e)
        {
            btnFCFS.BackColor = System.Drawing.Color.White;
        }

        private void btnSSTF_MouseEnter(object sender, EventArgs e)
        {
            btnSSTF.BackColor = System.Drawing.Color.LightBlue;
        }

        private void btnSSTF_MouseLeave(object sender, EventArgs e)
        {
            btnSSTF.BackColor = System.Drawing.Color.White;
        }

        private void btnSCAN_MouseEnter(object sender, EventArgs e)
        {
            btnSCAN.BackColor = System.Drawing.Color.LightPink;
        }

        private void btnSCAN_MouseLeave(object sender, EventArgs e)
        {
            btnSCAN.BackColor = System.Drawing.Color.White;
        }

        private void btnCSCAN_MouseEnter(object sender, EventArgs e)
        {
            btnCSCAN.BackColor = System.Drawing.Color.LightYellow;
        }

        private void btnCSCAN_MouseLeave(object sender, EventArgs e)
        {
            btnSCAN.BackColor = System.Drawing.Color.White;
        }






        public string RequestSequence { get; private set; }
        public int HeadPosition { get; private set; }



        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnFCFS_Click(object sender, EventArgs e)
        {
            try
            {
                RequestSequence = txtRequestSequence.Text.Trim();
                HeadPosition = int.Parse(txtHeadPosition.Text.Trim());
                this.Hide();
                FormFCFS formFCFS = new FormFCFS(RequestSequence, HeadPosition); // Gọi constructor với 2 tham số
                formFCFS.ShowDialog();
                this.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message + "\nVui lòng nhập đúng định dạng (số nguyên, phân cách bằng khoảng trắng).");
            }
        }

        private void btnSSTF_Click(object sender, EventArgs e)
        {
            try
            {
                RequestSequence = txtRequestSequence.Text.Trim();
                HeadPosition = int.Parse(txtHeadPosition.Text.Trim());
                this.Hide();
                FormSSTF formSSTF = new FormSSTF(RequestSequence, HeadPosition);
                formSSTF.ShowDialog(); // Mở FormSSTF
                this.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message + "\nVui lòng nhập đúng định dạng (số nguyên, phân cách bằng khoảng trắng).");
            }
        }

        private void btnSCAN_Click(object sender, EventArgs e)
        {
            try
            {
                RequestSequence = txtRequestSequence.Text.Trim();
                HeadPosition = int.Parse(txtHeadPosition.Text.Trim());
                this.Hide();
                FormSCAN formSCAN = new FormSCAN(RequestSequence, HeadPosition);
                formSCAN.ShowDialog(); // Mở FormSCAN
                this.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message + "\nVui lòng nhập đúng định dạng (số nguyên, phân cách bằng khoảng trắng).");
            }
        }

        private void btnCSCAN_Click(object sender, EventArgs e)
        {
            try
            {
                RequestSequence = txtRequestSequence.Text.Trim();
                HeadPosition = int.Parse(txtHeadPosition.Text.Trim());
                this.Hide();
                FormCSCAN formCSCAN = new FormCSCAN(RequestSequence, HeadPosition);
                formCSCAN.ShowDialog(); // Mở FormCSCAN
                this.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message + "\nVui lòng nhập đúng định dạng (số nguyên, phân cách bằng khoảng trắng).");
            }
        }
    }
}
