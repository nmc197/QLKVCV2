  
using QuanLyKVC.Models;
using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    namespace QuanLyKVC.Repository
    {
        public interface INhanVienRepository
        {
            Task<List<Nhanvien>> List();

            Task<List<Nhanvien>> Search(string keyword);

            Task<List<Nhanvien>> ListPaging(int pageIndex, int pageSize);

            Task<List<Nhanvien>> Detail(string postId);

            Task<Nhanvien> Add(Nhanvien Nhanvien);

            Task Update(Nhanvien Nhanvien);

            Task Delete(Nhanvien Nhanvien);

            Task<int> DeletePermanently(string NhanVienId);

            int CountNhanVien();
        }
    }
    