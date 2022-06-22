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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            cbbLopSH.Items.Add(new CBBItem { Value = 0, Text = "All" });
            cbbLopSH.Items.AddRange(QLSVBLL.Instance.GetCBB().ToArray());
            cbbLopSH.SelectedIndex = 0;
        }
        public void ShowDTG(int idlop)
        {
            var l1 = dataGridView1.DataSource = QLSVBLL.Instance.GetSVByIDLop(idlop).Select(x => new
            {
                x.MSSV,
                x.Name,
                x.Gender,
                x.BD,
                x.DTB,
                x.LSH.NameLop,
                x.Image,
                x.HocBa,
                x.CMND
            }).ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //  kiểu var là 1 kiểu dữ liệu động, ở đây ta ko dùng list để lấy danh sách sinh viên vì nếu chỉ muốn lấy 
            // một số thuộc tính của sinh viên thôi thì t phải khai báo lớp mới dẫn đến thừa, còn var giúp t linh động 
            // trong việc lấy các thuộc tính theo ý muốn
            // sử dụng query
            //var l1 = from p in QLSV.Instance.SVs  select p;
            //var l11 = from p in QLSV.Instance.SVs select new {p.MSSV,p.Name,p.Gender,p.BD,p.DTB,p.LSH.NameLop};

            // sử dung method
            //var l2 = QLSV.Instance.SVs.Select(p => p);
            //var l21 = QLSV.Instance.SVs.Select(p => new { p.MSSV, p.Name, p.Gender, p.BD, p.LSH.NameLop });

            //dataGridView1.DataSource = l11.ToList();
            //dataGridView1.Columns.Remove("LSH");
            int ID_lop = ((CBBItem)cbbLopSH.SelectedItem).Value;
            ShowDTG(ID_lop);
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            AddEditForm f = new AddEditForm("");
            f.d = new AddEditForm.MyDel(ShowDTG);
            f.Show();
        }

        private void btUpdate_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                string MSSV = dataGridView1.SelectedRows[0].Cells["MSSV"].Value.ToString();
                AddEditForm f = new AddEditForm(MSSV);
                f.d = new AddEditForm.MyDel(ShowDTG);
                f.Show();
            }
        }

        private void btDel_Click(object sender, EventArgs e)
        {

            if (dataGridView1.SelectedRows.Count > 0)
            {
                List<string> l = new List<string>();
                foreach (DataGridViewRow i in dataGridView1.SelectedRows)
                {
                    l.Add(i.Cells["MSSV"].Value.ToString());
                }
                foreach (string i in l)
                {
                    QLSVBLL.Instance.DeleteSV(i);
                }
            }
            ShowDTG(0);
        }

        private void btSort_Click(object sender, EventArgs e)
        {
            switch (cbbSort.SelectedIndex)
            {
                case 0:
                    dataGridView1.DataSource = QLSVBLL.Instance.GetSVByIDLop(((CBBItem)cbbLopSH.SelectedItem).Value).OrderBy(x => x.MSSV).ToList();

                    break;
                case 1:
                    dataGridView1.DataSource = QLSVBLL.Instance.GetSVByIDLop(((CBBItem)cbbLopSH.SelectedItem).Value).OrderBy(x => x.DTB).ToList();
                    break;
                default:
                    break;
            }
        }

        private void btSearch_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = QLSVBLL.Instance.FindSV(tbSearch.Text, ((CBBItem)cbbLopSH.SelectedItem).Value);
        }
    }
}
