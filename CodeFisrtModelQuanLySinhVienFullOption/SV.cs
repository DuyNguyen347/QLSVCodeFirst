using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFisrtModelQuanLySinhVienFullOption
{
    // Mặc định khi tạo DB băng code first, tên table sẽ trùng tên lớp
    // Để đặt lại tên table dúng từ khoá [Table("tên table mới")]
    // [Table("sinhvien")]
    public class SV
    {
        [Key][Required][StringLength(50)]
        // Key : khai báo khoá chính
        // Required : Không cho phép null
        // Stringlength: Độ dài chuỗi string tối đa ~ varchar
        // Có thể dùng [Column("ten column") để đổi tên column 
        // [MaxLength(50)]
        // [Column(TypeName = "nvarchar(40)")]
        public string MSSV { get; set; } 
        public string Name { get; set; }
        public bool Gender { get; set; }
        public Double DTB   { get; set; }
        public DateTime BD { get; set; }
        public int ID_Lop { get; set; }
        // Thuộc tính quan hệ
        
        [ForeignKey("ID_Lop")] // Khai báo khoá ngoại
        public virtual LopSH LSH {  get; set; }
        public bool Image { get; set; }
        public bool CMND { get; set; }
        public bool HocBa { get; set; }
    }
}
