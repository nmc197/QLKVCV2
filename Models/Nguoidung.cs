using System;
using System.Collections.Generic;

#nullable disable

namespace QuanLyKVC.Models
{
    public partial class Nguoidung
    {
        public string MaNd { get; set; }
        public string Ten { get; set; }
        public string TenDangNhap { get; set; }
        public string MatKhau { get; set; }
        public string MaNv { get; set; }
        public string MaQuyen { get; set; }

        public virtual Nhanvien MaNvNavigation { get; set; }
        public virtual Quyen MaQuyenNavigation { get; set; }
    }
}
