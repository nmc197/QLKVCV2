using System;
using System.Collections.Generic;

#nullable disable

namespace QuanLyKVC.Models
{
    public partial class Chitiethoadon
    {
        public string MaHd { get; set; }
        public string MaDv { get; set; }
        public int? SoLanSuDungDv { get; set; }

        public virtual Hoadon MaHdNavigation { get; set; }
    }
}
