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
    public partial class FormFCFS : Form
    {
        public FormFCFS()
        {
            InitializeComponent();
            this.Size = new System.Drawing.Size(300, 300);
        }

        public FormFCFS(string requestSequence, int headPosition)
        {
            InitializeComponent();
            SetupForm(requestSequence, headPosition);
        }

        private void SetupForm(string requestSequence, int headPosition)
        {
            lblHeadPosition.Text = $"Head Position: {headPosition}";
            lblRequestSequence.Text = $"Request Sequence: {requestSequence}";
        }

        private void btnSimulate_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy dữ liệu từ Label
                string[] requestString = lblRequestSequence.Text.Replace("Request Sequence: ", "").Trim().Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
                int[] requests = Array.ConvertAll(requestString, int.Parse);
                int head = int.Parse(lblHeadPosition.Text.Replace("Head Position: ", "").Trim());

                // Xóa kết quả cũ
                listBoxResult.Items.Clear();
                lblTotalSeeks.Text = "Total Seeks: 0";

                // Mô phỏng FCFS
                int totalSeeks = 0;
                int currentHead = head;

                // Hiển thị vị trí đầu tiên
                listBoxResult.Items.Add($"Head starts at: {currentHead}");

                // Tính toán và hiển thị từng bước di chuyển
                for (int i = 0; i < requests.Length; i++)
                {
                    int nextPosition = requests[i];
                    int seek = Math.Abs(currentHead - nextPosition);
                    totalSeeks += seek;
                    listBoxResult.Items.Add($"Move to {nextPosition} | {currentHead}->{nextPosition} | Seek: {seek} | Total: {totalSeeks}");
                    currentHead = nextPosition;
                }

                // Cập nhật tổng seek
                lblTotalSeeks.Text = $"Total Seeks: {totalSeeks}";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message + "\nDữ liệu không hợp lệ.");
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close(); // Đóng form và quay lại FormDiskScheduling
        }
    }
}
