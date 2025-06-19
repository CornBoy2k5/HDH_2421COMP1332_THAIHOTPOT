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
    public partial class FormSSTF : Form
    {
        public FormSSTF()
        {
            InitializeComponent();
            this.Size = new System.Drawing.Size(750, 550);
        }

        public FormSSTF(string requestSequence, int headPosition)
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

                // Mô phỏng SSTF
                int totalSeeks = 0;
                int currentHead = head;
                int[] remainingRequests = (int[])requests.Clone(); // Sao chép mảng để xử lý

                // Hiển thị vị trí đầu tiên
                listBoxResult.Items.Add($"Head starts at: {currentHead}");

                while (remainingRequests.Length > 0)
                {
                    // Tìm yêu cầu gần nhất
                    int minDistance = int.MaxValue;
                    int nearestIndex = -1;
                    for (int i = 0; i < remainingRequests.Length; i++)
                    {
                        int distance = Math.Abs(currentHead - remainingRequests[i]);
                        if (distance < minDistance)
                        {
                            minDistance = distance;
                            nearestIndex = i;
                        }
                    }

                    // Di chuyển đến vị trí gần nhất
                    int nextPosition = remainingRequests[nearestIndex];
                    int seek = Math.Abs(currentHead - nextPosition);
                    totalSeeks += seek;
                    listBoxResult.Items.Add($"Move to {nextPosition} | {currentHead}->{nextPosition} | Seek: {seek} | Total: {totalSeeks}");
                    currentHead = nextPosition;

                    // Xóa yêu cầu đã xử lý
                    int[] newRemaining = new int[remainingRequests.Length - 1];
                    Array.Copy(remainingRequests, 0, newRemaining, 0, nearestIndex);
                    Array.Copy(remainingRequests, nearestIndex + 1, newRemaining, nearestIndex, remainingRequests.Length - nearestIndex - 1);
                    remainingRequests = newRemaining;
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

        private void lblTotalSeeks_Click(object sender, EventArgs e)
        {

        }
    }
}
