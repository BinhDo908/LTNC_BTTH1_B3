using System;
using System.Windows.Forms;

namespace B3_BTTH1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtNhap.TabIndex = 0;
            btnCapNhat.TabIndex = 1;
            cbbox.TabIndex = 2;
            ltBox.TabIndex = 3;
            btnSum.TabIndex = 4;
            btnSumEven.TabIndex = 5;
            btnSumOdd.TabIndex = 6;
            btnExit.TabIndex = 7;
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtNhap.Text, out int so))
            {
                cbbox.Items.Add(so); 
                txtNhap.Clear();    
                txtNhap.Focus();    
            }
            else
            {
                MessageBox.Show("Vui lòng nhập một số hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbox.SelectedItem != null)
            {
                int so = (int)cbbox.SelectedItem;
                ltBox.Items.Clear();

                for (int i = 1; i <= so; i++)
                {
                    if ((so % i) == 0)
                    {
                        ltBox.Items.Add(i); 
                    }
                }
            }
        }

        private void btnSum_Click(object sender, EventArgs e)
        {
            int sum = 0;
            foreach (var item in ltBox.Items)
            {
                sum += (int)item;
            }
            MessageBox.Show("Tổng các ước số: " + sum, "Kết quả", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnSumEven_Click(object sender, EventArgs e)
        {
            int evenCount = 0;
            foreach (var item in ltBox.Items)
            {
                if ((int)item % 2 == 0)
                {
                    evenCount++; 
                }
            }
            MessageBox.Show("Số lượng các ước số chẵn: " + evenCount, "Kết quả", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnSumOdd_Click(object sender, EventArgs e)
        {
            int primeCount = 0;
            foreach (var item in ltBox.Items)
            {
                int number = (int)item;
                if (IsPrime(number))
                {
                    primeCount++;
                }
            }
            MessageBox.Show("Số lượng các ước số nguyên tố: " + primeCount, "Kết quả", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private bool IsPrime(int number)
        {
            if (number < 2) return false;
            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();        }
    }
}

