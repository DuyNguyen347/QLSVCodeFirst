using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFisrtModelQuanLySinhVienFullOption
{
    // Lớp chiến lược khởi tạo DB, có 4 chiến lược chính
    //CreateDatabaseIfNotExists<QLSV>  nếu database đó chưa tồn tại thì nó sẽ khỏi tạo, còn nếu đã tồn tại thì không khởi tạo
    //DropCreateDatabaseIfModelChanges<QLSV> nếu chỉ thay đổi record thì nó sẽ không update còn nếu thay đồi cấu trúc  database thì sẽ xoá db hiện tại và tạo mới
    // DropCreateDatabaseAlways : xoá database hiện tại và tạo database mới
    // Chiến lược khởi tạo thứ 4 : tự nguòi dùng định nghĩa chiến lược khởi tạo
    public class CreateDB: CreateDatabaseIfNotExists<QLSV>
    {
        protected override void Seed(QLSV context)
        {
            context.Lops.AddRange(new LopSH[]
            {
                new LopSH{ID_Lop = 1, NameLop = "20T1"},
                new LopSH{ID_Lop = 2, NameLop = "20T2"},
                new LopSH{ID_Lop = 3, NameLop = "19T2"}
            });
            context.SVs.AddRange(new SV[]
            {
                new SV{MSSV = "001",Name =  "Nguyen Duc Duy",Gender = true, DTB = 10, BD = DateTime.Now,ID_Lop = 1,Image = true,CMND = true,HocBa = true},
                new SV{MSSV = "002",Name =  "Nguyen Quoc Tinh",Gender = true, DTB = 10, BD = DateTime.Now,ID_Lop = 2,Image = true,CMND = false,HocBa = true},
                new SV{MSSV = "003",Name =  "nguyen Huu Thuan ",Gender = true, DTB = 9, BD = DateTime.Now,ID_Lop = 3,Image = false,CMND = true,HocBa = true},

            });
        }
    }
}
