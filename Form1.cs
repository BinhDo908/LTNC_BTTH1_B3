using System;
using System.Windows.Forms;

namespace BTTH1_B1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            txtPass.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                {
                    e.Handled = true;
                    e.SuppressKeyPress = true;  // Ngừng tiếp tục xử lý sự kiện này
                    btnLogin.PerformClick();

                }
            };

        private void label1_Click(object sender, EventArgs e)
        {
           
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string thongbao = "Ten dang nhap la: "
                + txtUser.Text + "\r\nMat Khau la:" + txtPass.Text;

            if(checkNho.Checked)
            {
                thongbao += "\r\nBan co ghi nho.";
            }
            MessageBox.Show(thongbao, "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            checkNho.Checked = false;

            ClearAllTextBoxes(this);

            txtUser.Focus();
        }

        private void ClearAllTextBoxes(Control parent)
        {
            foreach (Control c in parent.Controls)
            {
                if (c is TextBox tb)
                {
                    tb.Clear();
                }
                else if (c.HasChildren)
                {
                    ClearAllTextBoxes(c);
                }
            }
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            var dr = MessageBox.Show("Exit Confirmed?", "Confirmed.", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        if (dr == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
       

    }
}
