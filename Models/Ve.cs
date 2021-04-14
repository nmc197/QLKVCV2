using System;
using System.Collections.Generic;

#nullable disable

namespace QuanLyKVC.Models
{
    public partial class Ve
    {
        public string MaVe { get; set; }
        public string MaKhu { get; set; }
        public DateTime? NgayPhatHanh { get; set; }
        public string MaHd { get; set; }

        public virtual Hoadon MaHdNavigation { get; set; }
        public virtual Khutrochoi MaKhuNavigation { get; set; }
    }
}
