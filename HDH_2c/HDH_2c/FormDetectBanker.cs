using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace HDH_2c
{
    public partial class FormDetectBanker : Form
    {

        public FormDetectBanker()
        {
            InitializeComponent();
            // Đặt kích thước form
            this.Size = new System.Drawing.Size(1000, 600); // Width = 700, Height = 800
        }

        private void btnConfigureGrid_Click(object sender, EventArgs e)
        {
            try
            {
                int n = int.Parse(txtNumProcesses.Text.Trim());
                int m = int.Parse(txtNumResources.Text.Trim());

                ConfigureDataGridView(dataGridViewAllocation, n, m);
                ConfigureDataGridView(dataGridViewRequest, n, m);

                MessageBox.Show("Cấu hình DataGridView thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message + "\nVui lòng nhập số nguyên cho n và m.");
            }
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            try
            {
                int n = int.Parse(txtNumProcesses.Text.Trim());
                int m = int.Parse(txtNumResources.Text.Trim());

                int[,] allocation = GetMatrixFromDataGridView(dataGridViewAllocation, n, m);
                int[,] request = GetMatrixFromDataGridView(dataGridViewRequest, n, m);
                int[] available = Array.ConvertAll(txtAvailable.Text.Trim().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries), int.Parse);

                bool[] finish = new bool[n];
                int[] work = new int[m];
                Array.Copy(available, work, m);
                for (int i = 0; i < n; i++)
                    finish[i] = (IsRowZero(allocation, i, m)) ? true : false;

                // Lưu chuỗi tiến trình an toàn
                List<int> safeSequence = new List<int>();
                bool safe = false;
                while (!safe)
                {
                    safe = true;
                    for (int i = 0; i < n; i++)
                    {
                        if (!finish[i] && IsLessThanOrEqual(request, i, work, m))
                        {
                            for (int j = 0; j < m; j++)
                                work[j] += allocation[i, j];
                            finish[i] = true;
                            safeSequence.Add(i); // Thêm tiến trình vào chuỗi an toàn
                            safe = false;
                        }
                    }
                }

                List<int> deadlockedProcesses = new List<int>();
                for (int i = 0; i < n; i++)
                {
                    if (!finish[i])
                        deadlockedProcesses.Add(i);
                }

                listBoxResult.Items.Clear();
                if (deadlockedProcesses.Count == 0)
                {
                    listBoxResult.Items.Add("Hệ thống không bị deadlock.");
                    listBoxResult.Items.Add("Chuỗi tiến trình an toàn: " + string.Join(" -> ", safeSequence));
                }
                else
                {
                    listBoxResult.Items.Add("Hệ thống bị deadlock.");
                    listBoxResult.Items.Add("Các tiến trình bị deadlock: " + string.Join(", ", deadlockedProcesses));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message + "\nVui lòng nhập đúng định dạng (số nguyên).");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // Xóa dữ liệu trong các TextBox
            txtNumProcesses.Text = "";
            txtNumResources.Text = "";
            txtAvailable.Text = "";

            // Xóa dữ liệu trong DataGridView
            dataGridViewAllocation.Rows.Clear();
            dataGridViewAllocation.Columns.Clear();
            dataGridViewRequest.Rows.Clear();
            dataGridViewRequest.Columns.Clear();

            // Xóa kết quả trong ListBox
            listBoxResult.Items.Clear();

            MessageBox.Show("Đã xóa tất cả dữ liệu!");
        }

        private void ConfigureDataGridView(DataGridView grid, int rows, int cols)
        {
            grid.Rows.Clear();
            grid.Columns.Clear();
            for (int j = 0; j < cols; j++)
            {
                grid.Columns.Add("col" + j, "R" + j);
            }
            for (int i = 0; i < rows; i++)
            {
                grid.Rows.Add();
            }
            grid.AllowUserToAddRows = false;
            foreach (DataGridViewColumn column in grid.Columns)
            {
                column.ValueType = typeof(int);
            }
            grid.DataError += (s, args) =>
            {
                if (args.Exception != null && args.Exception is FormatException)
                {
                    args.ThrowException = false;
                    MessageBox.Show("Vui lòng nhập số nguyên vào ô!");
                    grid.Rows[args.RowIndex].Cells[args.ColumnIndex].Value = 0;
                }
            };
        }

        private int[,] GetMatrixFromDataGridView(DataGridView grid, int rows, int cols)
        {
            int[,] matrix = new int[rows, cols];
            for (int i = 0; i < rows; i++)
                for (int j = 0; j < cols; j++)
                    matrix[i, j] = int.Parse(grid.Rows[i].Cells[j].Value?.ToString() ?? "0");
            return matrix;
        }

        private bool IsRowZero(int[,] matrix, int row, int cols)
        {
            for (int j = 0; j < cols; j++)
                if (matrix[row, j] != 0) return false;
            return true;
        }

        private bool IsLessThanOrEqual(int[,] request, int row, int[] work, int cols)
        {
            for (int j = 0; j < cols; j++)
                if (request[row, j] > work[j]) return false;
            return true;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}