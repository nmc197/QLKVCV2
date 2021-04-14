
using QuanLyKVC.Models;
using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    namespace QuanLyKVC.Repository
    {
        public interface INguoiDungRepository
        {
            Task<List<Nguoidung>> List();

            Task<List<Nguoidung>> Search(string keyword);

            Task<List<Nguoidung>> ListPaging(int pageIndex, int pageSize);

            Task<List<Nguoidung>> Detail(string postId);

            Task<Nguoidung> Add(Nguoidung Nguoidung);

            Task Update(Nguoidung Nguoidung);

            Task Delete(Nguoidung Nguoidung);

            Task<int> DeletePermanently(string NguoiDungId);

            int CountNguoiDung();
        }
    }
    