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
    public partial class Form2 : Form
    {
        public delegate void MyDel(int id, string name);
        public MyDel del;
        private string MSSV;
        public Form2(string ID)
        {
            InitializeComponent();
            MSSV = ID;
            SetClassCbb();
            SetInfor();
        }
        public void SetClassCbb()
        {
            foreach (LSH i in CSDL_OOP.Instance.GetAllClass())
            {
                CbbLSH.Items.Add(i);
            }
        }
        public void SetInfor()
        {
            SV sv = CSDL_OOP.Instance.GetSVByID(MSSV);
            if(sv != null)
            {
                MSSVInput.Text = sv.MSSV;
                NameInput.Text = sv.Name;
                if (sv.Gender == true)
                    Malerdo.Checked = true;
                else
                    Femalerdo.Checked = true;
                dateTimePicker1.Value = sv.Date;
                foreach(var i in CbbLSH.Items)
                {
                    if(((LSH)i).ID == sv.ID_Class)
                    {
                        CbbLSH.SelectedItem = i;
                        break;
                    }
                }
            }
        }

        private void Okbtn_Click(object sender, EventArgs e)
        {
            SV sv = new SV()
            {
                MSSV = MSSVInput.Text,
                Name = NameInput.Text,
                Gender = Malerdo.Checked == true ? true : false,
                Date = Convert.ToDateTime(dateTimePicker1.Value),
                ID_Class = ((LSH)CbbLSH.SelectedItem).ID
            };
            if(CSDL_OOP.Instance.GetSVByID(MSSVInput.Text) == null)
            {
                CSDL_OOP.Instance.AddSV(sv);
            }
            else
            {
                CSDL_OOP.Instance.UpdateSV(sv);
            }
            del(CSDL_OOP.Instance.GetSVByID(sv.MSSV).ID_Class, "");
            this.Dispose();
        }

        private void Cancelbtn_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
