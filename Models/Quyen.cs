using System;
using System.Collections.Generic;

#nullable disable

namespace QuanLyKVC.Models
{
    public partial class Quyen
    {
        public Quyen()
        {
            Nguoidungs = new HashSet<Nguoidung>();
        }

        public string MaQuyen { get; set; }
        public string TenQuyen { get; set; }
        public string MieuTa { get; set; }
        public string KyHieuQuyen { get; set; }

        public virtual ICollection<Nguoidung> Nguoidungs { get; set; }
    }
}
