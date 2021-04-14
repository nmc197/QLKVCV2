using System;
using System.Collections.Generic;

#nullable disable

namespace QuanLyKVC.Models
{
    public partial class Nhanvien
    {
        public Nhanvien()
        {
            Khutrochois = new HashSet<Khutrochoi>();
            Nguoidungs = new HashSet<Nguoidung>();
            Trochois = new HashSet<Trochoi>();
        }

        public string MaNv { get; set; }
        public string TenNv { get; set; }
        public DateTime? NgaySinh { get; set; }
        public string GioiTinh { get; set; }
        public string MaKhuPhuTrach { get; set; }
        public double? Luong { get; set; }
        public string QueQuan { get; set; }

        public virtual Khutrochoi MaKhuPhuTrachNavigation { get; set; }
        public virtual ICollection<Khutrochoi> Khutrochois { get; set; }
        public virtual ICollection<Nguoidung> Nguoidungs { get; set; }
        public virtual ICollection<Trochoi> Trochois { get; set; }
    }
}
