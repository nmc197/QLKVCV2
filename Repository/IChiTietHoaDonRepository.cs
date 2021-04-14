
using QuanLyKVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuanLyKVC.Repository
{
    public interface IChiTietHoaDonRepository
    {
        Task<List<Chitiethoadon>> List();

        Task<List<Chitiethoadon>> Search(string keyword);

        Task<List<Chitiethoadon>> ListPaging(int pageIndex, int pageSize);

        Task<List<Chitiethoadon>> Detail(string postId);

        Task<Chitiethoadon> Add(Chitiethoadon Chitiethoadon);

        Task Update(Chitiethoadon Chitiethoadon);

        Task Delete(Chitiethoadon Chitiethoadon);

        Task<int> DeletePermanently(string ChiTietHoaDonId);

        int CountChiTietHoaDon();
    }
}
