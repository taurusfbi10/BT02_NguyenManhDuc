using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BT02_NguyenManhDuc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            SetClassCbb();
        }
        public void SetClassCbb()
        {
            ClassCbb.Items.Add(new LSH() { ID = 0, Name = "All" });
            foreach(LSH i in CSDL_OOP.Instance.GetAllClass())
            {
                ClassCbb.Items.Add(i);
            }
        }
        public void Show(int id, string name)
        {
            dataGridView1.DataSource = CSDL_OOP.Instance.GetListSV(id, name);
        }
        private void ShowBtn_Click(object sender, EventArgs e)
        {
            if(ClassCbb.SelectedIndex != -1)
            {
                Show(((LSH)ClassCbb.SelectedItem).ID, NameInput.Text);
            }
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2("");
            f2.Show();
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            if(dataGridView1.SelectedRows.Count == 1)
            {
                Form2 f2 = new Form2(dataGridView1.SelectedRows[0].Cells["MSSV"].Value.ToString());
                f2.del += new Form2.MyDel(Show);
                f2.Show();
            }
        }
    }
}
