using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ERP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private ERPDataContext db = new ERPDataContext();
        private void Form1_Load(object sender, EventArgs e)
        {
            var ChucVu = from p in db.ChucVus
                           select new
                           {
                               p.MaChucVu,
                               p.TenChucVu,
                               p.MoTa,
                          
                           };

            // Hiển thị dữ liệu trong DataGridView
            dataGridView1.DataSource = ChucVu.ToList();
        }
    }
}
