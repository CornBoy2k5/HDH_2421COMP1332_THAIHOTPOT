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
    public partial class FormSCAN : Form
    {
        public FormSCAN()
        {
            InitializeComponent();
            this.Size = new System.Drawing.Size(750, 550);
        }

        public FormSCAN(string requestSequence, int headPosition)
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

                // Mô phỏng SCAN
                int totalSeeks = 0;
                int currentHead = head;
                int[] remainingRequests = (int[])requests.Clone(); // Sao chép mảng để xử lý
                Array.Sort(remainingRequests); // Sắp xếp mảng để dễ xử lý theo hướng

                // Hiển thị vị trí đầu tiên
                listBoxResult.Items.Add($"Head starts at: {currentHead}");

                // Xác định chỉ số bắt đầu
                int startIndex = Array.BinarySearch(remainingRequests, currentHead);
                if (startIndex < 0) startIndex = ~startIndex; // Tìm vị trí chèn nếu không tìm thấy

                // Di chuyển lên trên (tăng dần) trước
                for (int i = startIndex; i < remainingRequests.Length; i++)
                {
                    int nextPosition = remainingRequests[i];
                    int seek = Math.Abs(currentHead - nextPosition);
                    totalSeeks += seek;
                    listBoxResult.Items.Add($"Move to {nextPosition} | {currentHead}->{nextPosition} | Seek: {seek} | Total: {totalSeeks}");
                    currentHead = nextPosition;
                }

                // Di chuyển xuống dưới (giảm dần) sau khi chạm biên (giả sử biên là 199)
                const int maxCylinder = 199;
                if (currentHead < maxCylinder)
                {
                    int seekToMax = Math.Abs(currentHead - maxCylinder);
                    totalSeeks += seekToMax;
                    listBoxResult.Items.Add($"Move to {maxCylinder} | {currentHead}->{maxCylinder} | Seek: {seekToMax} | Total: {totalSeeks}");
                    currentHead = maxCylinder;
                }

                // Di chuyển ngược lại (giảm dần) từ biên
                for (int i = startIndex - 1; i >= 0; i--)
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

        private void FormSCAN_Load(object sender, EventArgs e)
        {

        }
    }
}
