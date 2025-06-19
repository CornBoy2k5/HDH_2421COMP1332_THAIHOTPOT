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
    public partial class FormCSCAN : Form
    {
        public FormCSCAN()
        {
            InitializeComponent();
            this.Size = new System.Drawing.Size(750, 550);
        }

        public FormCSCAN(string requestSequence, int headPosition)
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
                int[] requests = requestString.Select(int.Parse).ToArray();
                int head = int.Parse(lblHeadPosition.Text.Replace("Head Position: ", "").Trim());

                // Xóa kết quả cũ
                listBoxResult.Items.Clear();
                lblTotalSeeks.Text = "Total Seeks: 0";

                // Mô phỏng C-SCAN
                int totalSeeks = 0;
                int currentHead = head;
                int[] remainingRequests = (int[])requests.Clone(); // Sao chép mảng để xử lý
                Array.Sort(remainingRequests); // Sắp xếp mảng để dễ xử lý theo hướng tăng dần

                // Hiển thị vị trí đầu tiên
                listBoxResult.Items.Add($"Head starts at: {currentHead}");

                // Xác định chỉ số bắt đầu
                int startIndex = Array.BinarySearch(remainingRequests, currentHead);
                if (startIndex < 0) startIndex = ~startIndex; // Tìm vị trí chèn nếu không tìm thấy

                // Di chuyển lên trên (tăng dần) đến biên
                const int maxCylinder = 199;
                for (int i = startIndex; i < remainingRequests.Length; i++)
                {
                    int nextPosition = remainingRequests[i];
                    int seek = Math.Abs(currentHead - nextPosition);
                    totalSeeks += seek;
                    listBoxResult.Items.Add($"Move to {nextPosition} | {currentHead}->{nextPosition} | Seek: {seek} | Total: {totalSeeks}");
                    currentHead = nextPosition;
                }

                // Di chuyển đến biên tối đa
                if (currentHead < maxCylinder)
                {
                    int seekToMax = Math.Abs(currentHead - maxCylinder);
                    totalSeeks += seekToMax;
                    listBoxResult.Items.Add($"Move to {maxCylinder} | {currentHead}->{maxCylinder} | Seek: {seekToMax} | Total: {totalSeeks}");
                    currentHead = maxCylinder;
                }

                // Nhảy về 0
                int seekToZero = currentHead; // Khoảng cách từ biên về 0
                totalSeeks += seekToZero;
                listBoxResult.Items.Add($"Move to 0 | {currentHead}->0 | Seek: {seekToZero} | Total: {totalSeeks}");
                currentHead = 0;

                // Di chuyển tăng dần từ 0 đến các yêu cầu còn lại (nếu có)
                for (int i = 0; i < startIndex && i < remainingRequests.Length; i++)
                {
                    int nextPosition = remainingRequests[i];
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
