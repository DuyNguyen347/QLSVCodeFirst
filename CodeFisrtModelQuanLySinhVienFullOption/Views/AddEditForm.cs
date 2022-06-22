using CodeFisrtModelQuanLySinhVienFullOption.BLL;
using CodeFisrtModelQuanLySinhVienFullOption.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodeFisrtModelQuanLySinhVienFullOption
{
    public partial class AddEditForm : Form
    {
        public delegate void MyDel(int ID_Lop);
        public MyDel d { get; set; }
        public string MSSV { get; set; }
        public SV sv { get; set; }
        public AddEditForm(string mssv)
        {
            InitializeComponent();
            if (mssv != "" && mssv != null)
            {
                sv = QLSVBLL.Instance.GetSvByMssv(mssv);
            }
            else
            {
                sv = new SV();
            }

            MSSV = mssv;

            foreach (CBBItem i in QLSVBLL.Instance.GetCBB())
            {
                cbbLopSH.Items.Add(new CBBItem
                {
                    Value = i.Value,
                    Text = i.Text
                });
            }
            GUI();
        }
        public void GUI()
        {
            if (MSSV != "")
            {
                txtMSSV.Enabled = false;

                txtMSSV.Text = sv.MSSV;
                txtName.Text = sv.Name;
                foreach (CBBItem item in cbbLopSH.Items)
                {
                    if (item.Value == sv.ID_Lop)
                    {
                        cbbLopSH.SelectedItem = item;
                        break;
                    }
                }
                txtDTB.Text = sv.DTB.ToString();
                Date.Value = Convert.ToDateTime(sv.BD);
                rbNam.Checked = sv.Gender;
                cbAnh.Checked = sv.Image;
                cbCMND.Checked = sv.CMND;
                cbHocBa.Checked = sv.HocBa;
            }
        }

        private void btOk_Click(object sender, EventArgs e)
        {
            QLSVBLL.Instance.AddUpdate(GetSV());
            d(0);
            this.Close();
        }

        private void btCc_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private SV GetSV()
        {
            sv.CMND = cbCMND.Checked;
            sv.HocBa = cbHocBa.Checked;
            sv.Image = cbAnh.Checked;
            sv.DTB = Convert.ToDouble(txtDTB.Text);
            sv.MSSV = txtMSSV.Text;
            sv.Name = txtName.Text;
            sv.ID_Lop = ((CBBItem)cbbLopSH.SelectedItem).Value;
            sv.BD = Date.Value;
            sv.Gender = rbNam.Checked;
            return sv;
        }
    }
}
