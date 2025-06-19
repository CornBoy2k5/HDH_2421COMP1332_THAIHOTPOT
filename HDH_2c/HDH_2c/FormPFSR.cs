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
    public partial class FormPFSR : Form
    {
        public FormPFSR()
        {
            InitializeComponent();
            this.Size = new System.Drawing.Size(800, 580);

        }


        private void FormPFSR_Load(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOPT_Click(object sender, EventArgs e)
        {
            SimulateAlgorithm("OPT");
        }

        private void btnLRU_Click(object sender, EventArgs e)
        {
            SimulateAlgorithm("LRU");
        }

        private void btnFIFO_Click(object sender, EventArgs e)
        {
            SimulateAlgorithm("FIFO");
        }

        private void btnClock_Click(object sender, EventArgs e)
        {
            SimulateAlgorithm("Clock");
        }



        private void SimulateAlgorithm(string algorithm)
        {
            try
            {
                int capacity = int.Parse(txtFrameCapacity.Text.Trim());
                string[] pageString = txtPageSequence.Text.Trim().Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
                int[] pages = Array.ConvertAll(pageString, int.Parse);

                int pageFaults = 0;
                List<int> frames = new List<int>();

                listBoxResult.Items.Clear();
                listBoxResult.Items.Add($"Thuật toán: {algorithm}");
                listBoxResult.Items.Add("Trạng thái khung bộ nhớ:");

                switch (algorithm)
                {
                    case "OPT":
                        pageFaults = SimulateOPT(pages, capacity, frames, listBoxResult);
                        break;
                    case "LRU":
                        pageFaults = SimulateLRU(pages, capacity, frames, listBoxResult);
                        break;
                    case "FIFO":
                        pageFaults = SimulateFIFO(pages, capacity, frames, listBoxResult);
                        break;
                    case "Clock":
                        pageFaults = SimulateClock(pages, capacity, frames, listBoxResult);
                        break;
                }

                listBoxResult.Items.Add($"Tổng số lỗi trang: {pageFaults}");
                listBoxResult.Update();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message + "\nVui lòng nhập đúng định dạng (số nguyên, phân cách bằng khoảng trắng).");
            }
        }




        private int SimulateOPT(int[] pages, int capacity, List<int> frames, ListBox listBox)
        {
            int pageFaults = 0;

            // Khởi tạo frames với capacity phần tử, ban đầu là 0
            while (frames.Count < capacity)
            {
                frames.Add(0);
            }

            for (int i = 0; i < pages.Length; i++)
            {
                int page = pages[i];
                int frameIndex = frames.IndexOf(page);

                if (frameIndex == -1) // Page fault xảy ra
                {
                    int emptyIndex = frames.IndexOf(0); // Tìm vị trí trống
                    if (emptyIndex != -1) // Còn khung trống
                    {
                        frames[emptyIndex] = page;
                        pageFaults++;
                    }
                    else // Thay thế theo OPT (frame đã đầy)
                    {
                        int[] futureUse = new int[capacity];
                        // Tính toán chỉ số lần sử dụng tiếp theo trong tương lai
                        for (int j = 0; j < capacity; j++)
                        {
                            futureUse[j] = int.MaxValue; // Khởi tạo với giá trị lớn nhất
                            for (int k = i + 1; k < pages.Length; k++)
                            {
                                if (frames[j] == pages[k])
                                {
                                    futureUse[j] = k; // Chỉ số lần xuất hiện tiếp theo
                                    break;
                                }
                            }
                            if (futureUse[j] == int.MaxValue && frames[j] != 0) futureUse[j] = -1; // Không xuất hiện nữa
                        }

                        // Tìm frame có tham chiếu xa nhất (ưu tiên -1, sau đó so sánh chỉ số lớn nhất)
                        int maxFutureIndex = -1;
                        int replaceIndex = 0;
                        bool hasNotUsed = false;
                        for (int j = 0; j < capacity; j++)
                        {
                            if (futureUse[j] == -1)
                            {
                                hasNotUsed = true;
                                replaceIndex = j;
                                break; // Ưu tiên thay thế trang không xuất hiện
                            }
                            else if (!hasNotUsed && futureUse[j] > maxFutureIndex)
                            {
                                maxFutureIndex = futureUse[j];
                                replaceIndex = j;
                            }
                        }
                        frames[replaceIndex] = page;
                        pageFaults++;
                    }
                }

                // Cập nhật hiển thị
                listBox.Items.Add($"Trang {page}: {string.Join(", ", frames)}");
            }
            return pageFaults;
        }

        private int SimulateLRU(int[] pages, int capacity, List<int> frames, ListBox listBox)
        {
            int pageFaults = 0;
            Dictionary<int, int> pageUsage = new Dictionary<int, int>();

            // Khởi tạo frames với capacity phần tử, ban đầu là 0
            while (frames.Count < capacity)
            {
                frames.Add(0);
            }

            for (int i = 0; i < pages.Length; i++)
            {
                int page = pages[i];
                int frameIndex = frames.IndexOf(page);

                if (frameIndex == -1) // Page fault xảy ra
                {
                    int emptyIndex = frames.IndexOf(0); // Tìm vị trí trống
                    if (emptyIndex != -1) // Còn khung trống
                    {
                        frames[emptyIndex] = page;
                        pageUsage[page] = i;
                        pageFaults++;
                    }
                    else // Thay thế theo LRU (frame đã đầy)
                    {
                        int minUsage = int.MaxValue;
                        int replaceIndex = 0;
                        for (int j = 0; j < capacity; j++)
                        {
                            if (pageUsage[frames[j]] < minUsage)
                            {
                                minUsage = pageUsage[frames[j]];
                                replaceIndex = j;
                            }
                        }
                        frames[replaceIndex] = page;
                        pageUsage[page] = i;
                        pageFaults++;
                    }
                }
                else
                {
                    pageUsage[page] = i; // Cập nhật thời điểm sử dụng gần nhất
                }

                // Cập nhật hiển thị
                listBox.Items.Add($"Trang {page}: {string.Join(", ", frames)}");
            }
            return pageFaults;
        }

        private int SimulateFIFO(int[] pages, int capacity, List<int> frames, ListBox listBox)
        {
            int pageFaults = 0;
            Queue<int> queue = new Queue<int>();

            // Khởi tạo frames với capacity phần tử, ban đầu là 0
            while (frames.Count < capacity)
            {
                frames.Add(0);
            }

            for (int i = 0; i < pages.Length; i++)
            {
                int page = pages[i];
                int frameIndex = frames.IndexOf(page);

                if (frameIndex == -1) // Page fault xảy ra
                {
                    int emptyIndex = frames.IndexOf(0); // Tìm vị trí trống
                    if (emptyIndex != -1) // Còn khung trống
                    {
                        frames[emptyIndex] = page;
                        queue.Enqueue(page);
                        pageFaults++;
                    }
                    else // Thay thế theo FIFO (frame đã đầy)
                    {
                        int replacePage = queue.Dequeue();
                        int replaceIndex = frames.IndexOf(replacePage);
                        frames[replaceIndex] = page;
                        queue.Enqueue(page);
                        pageFaults++;
                    }
                }

                // Cập nhật hiển thị
                listBox.Items.Add($"Trang {page}: {string.Join(", ", frames)}");
            }
            return pageFaults;
        }

        private int SimulateClock(int[] pages, int capacity, List<int> frames, ListBox listBox)
        {
            int pageFaults = 0;
            List<bool> referenceBits = new List<bool>(new bool[capacity]);
            int pointer = 0;

            // Khởi tạo frames với capacity phần tử, ban đầu là 0, đồng bộ với referenceBits
            while (frames.Count < capacity)
            {
                frames.Add(0);
            }

            for (int i = 0; i < pages.Length; i++)
            {
                int page = pages[i];
                int frameIndex = frames.IndexOf(page);

                if (frameIndex == -1) // Page fault xảy ra
                {
                    if (frames.IndexOf(0) != -1) // Còn khung trống
                    {
                        int emptyIndex = frames.IndexOf(0);
                        frames[emptyIndex] = page;
                        referenceBits[emptyIndex] = true;
                        pageFaults++;
                    }
                    else // Thay thế theo Clock
                    {
                        while (true)
                        {
                            if (!referenceBits[pointer])
                            {
                                frames[pointer] = page;
                                referenceBits[pointer] = true;
                                pageFaults++;
                                pointer = (pointer + 1) % capacity;
                                break;
                            }
                            else
                            {
                                referenceBits[pointer] = false;
                                pointer = (pointer + 1) % capacity;
                            }
                        }
                    }
                }
                else
                {
                    referenceBits[frameIndex] = true; // Cập nhật bit tham chiếu
                }

                // Cập nhật hiển thị
                listBox.Items.Add($"Trang {page}: {string.Join(", ", frames)}");
            }
            return pageFaults;
        }

        private void btnOPT_MouseEnter(object sender, EventArgs e)
        {
            btnOPT.BackColor = System.Drawing.Color.LightGreen;
        }

        private void btnOPT_MouseLeave(object sender, EventArgs e)
        {
            btnOPT.BackColor = System.Drawing.Color.White;
        }

        private void btnLRU_MouseEnter(object sender, EventArgs e)
        {
            btnLRU.BackColor = System.Drawing.Color.LightBlue;
        }

        private void btnLRU_MouseLeave(object sender, EventArgs e)
        {
            btnLRU.BackColor = System.Drawing.Color.White;
        }

        private void btnFIFO_MouseEnter(object sender, EventArgs e)
        {
            btnFIFO.BackColor = System.Drawing.Color.LightYellow;
        }

        private void btnFIFO_MouseLeave(object sender, EventArgs e)
        {
            btnFIFO.BackColor = System.Drawing.Color.White;
        }

        private void btnClock_MouseEnter(object sender, EventArgs e)
        {
            btnClock.BackColor = System.Drawing.Color.Red;
        }

        private void btnClock_MouseLeave(object sender, EventArgs e)
        {
            btnClock.BackColor = System.Drawing.Color.White;
        }
    }
}
