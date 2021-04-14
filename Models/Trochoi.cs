using System;
using System.Collections.Generic;

#nullable disable

namespace QuanLyKVC.Models
{
    public partial class Trochoi
    {
        public string MaTroChoi { get; set; }
        public string TenTroChoi { get; set; }
        public string MaNvphuTrach { get; set; }
        public int? SoLuongNguoiChoiMax { get; set; }
        public string MaKhu { get; set; }

        public virtual Khutrochoi MaKhuNavigation { get; set; }
        public virtual Nhanvien MaNvphuTrachNavigation { get; set; }
    }
}
