
using QuanLyKVC.Models;
using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    namespace QuanLyKVC.Repository
    {
        public interface IHoaDonRepository
        {
            Task<List<Hoadon>> List();

            Task<List<Hoadon>> Search(string keyword);

            Task<List<Hoadon>> ListPaging(int pageIndex, int pageSize);

            Task<List<Hoadon>> Detail(string postId);

            Task<Hoadon> Add(Hoadon Hoadon);

            Task Update(Hoadon Hoadon);

            Task Delete(Hoadon Hoadon);

            Task<int> DeletePermanently(string HoaDonId);

            int CountHoaDon();
        }
    }
    