using System;
using System.Collections.Generic;

#nullable disable

namespace QuanLyKVC.Models
{
    public partial class Khutrochoi
    {
        public Khutrochoi()
        {
            Nhanviens = new HashSet<Nhanvien>();
            Trochois = new HashSet<Trochoi>();
            Ves = new HashSet<Ve>();
        }

        public string MaKhu { get; set; }
        public string TenKhu { get; set; }
        public string MaNvql { get; set; }
        public int? GiaVeTreEm { get; set; }
        public int? GiaVeNguoiLon { get; set; }

        public virtual Nhanvien MaNvqlNavigation { get; set; }
        public virtual ICollection<Nhanvien> Nhanviens { get; set; }
        public virtual ICollection<Trochoi> Trochois { get; set; }
        public virtual ICollection<Ve> Ves { get; set; }
    }
}
