using System;
using System.Collections.Generic;

#nullable disable

namespace QuanLyKVC.Models
{
    public partial class Hoadon
    {
        public Hoadon()
        {
            Ves = new HashSet<Ve>();
        }

        public string MaHd { get; set; }
        public DateTime? NgayHd { get; set; }
        public double? TongTien { get; set; }

        public virtual ICollection<Ve> Ves { get; set; }
    }
}
