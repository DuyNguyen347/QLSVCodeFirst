using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFisrtModelQuanLySinhVienFullOption
{
    public class LopSH
    {
        // tạo hàm dựng để cho trình biên dịch biết đối tượng lopSH phải được add trước rồi mới add đối tượng SV
        public LopSH()
        {
            SVs = new HashSet<SV>();
        }
        [Key]
        public int ID_Lop { get; set; }
        public string NameLop { get; set; }
        
        // thuộc tính quan hệ : 1 lớp có thể nhiều sinh viên
        public virtual ICollection<SV> SVs { get; set; }
    }
}
