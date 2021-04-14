
using QuanLyKVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuanLyKVC.Repository
{
    public interface IQuyenRepository
    {
        Task<List<Quyen>> List();

        Task<List<Quyen>> Search(string keyword);

        Task<List<Quyen>> ListPaging(int pageIndex, int pageSize);

        Task<List<Quyen>> Detail(string postId);

        Task<Quyen> Add(Quyen Quyen);

        Task Update(Quyen Quyen);

        Task Delete(Quyen Quyen);

        Task<int> DeletePermanently(string QuyenId);

        int CountQuyen();
    }
}
