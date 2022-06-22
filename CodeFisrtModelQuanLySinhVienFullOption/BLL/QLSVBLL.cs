using CodeFisrtModelQuanLySinhVienFullOption.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFisrtModelQuanLySinhVienFullOption.BLL
{
    public class QLSVBLL
    {
        private static QLSVBLL _Instance;
        public static QLSVBLL Instance
        {
            get
            {
                if (_Instance == null)
                    _Instance = new QLSVBLL();
                return _Instance;
            }
            private set { }
        }
        private QLSVBLL() { }
        public List<CBBItem> GetCBB()
        {
            List<CBBItem> data = new List<CBBItem>();
            foreach (LopSH item in QLSV.Instance.Lops)
            {
                data.Add(new CBBItem { Text = item.NameLop, Value = item.ID_Lop });
            }
            return data;

        }

        public List<SV> GetSVByIDLop(int id_Lop)
        {
            if (id_Lop == 0)
            {
                return QLSV.Instance.SVs.ToList();
            }
            else
            {
                return QLSV.Instance.SVs.Where(x => x.ID_Lop == id_Lop).ToList();
            }

        }

        internal SV GetSvByMssv(string mssv)
        {
            return QLSV.Instance.SVs.Where(x => x.MSSV == mssv).FirstOrDefault();
        }

        internal void AddUpdate(SV sv)
        {
            if (QLSV.Instance.SVs.Find(sv.MSSV) != null)
            {
                QLSV.Instance.SaveChanges();
            }
            else
            {
                QLSV.Instance.SVs.Add(sv);
                QLSV.Instance.SaveChanges();
            }
        }

        internal void DeleteSV(string mssv)
        {
            QLSV.Instance.SVs.Remove(QLSV.Instance.SVs.Find(mssv));
            QLSV.Instance.SaveChanges();
        }

        internal List<SV> FindSV(string text, int value)
        {
            List<SV> l1;
            if (value == 0)
            {
                l1 = QLSV.Instance.SVs.Where(x => x.Name.Contains(text)).ToList();
            }
            else
            {
                l1 = QLSV.Instance.SVs.Where(x => x.Name.Contains(text) & x.ID_Lop == value).ToList();
            }
            return l1;
        }

        internal List<SV> SortSv(int value, string text)
        {
            return QLSV.Instance.SVs.Where(x => x.ID_Lop == value).OrderBy(x => x.MSSV).ToList();
        }
    }
}
