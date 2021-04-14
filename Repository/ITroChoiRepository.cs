
using QuanLyKVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuanLyKVC.Repository
{
    public interface ITroChoiRepository
    {
        Task<List<Trochoi>> List();

        Task<List<Trochoi>> Search(string keyword);

        Task<List<Trochoi>> ListPaging(int pageIndex, int pageSize);

        Task<List<Trochoi>> Detail(string postId);

        Task<Trochoi> Add(Trochoi Trochoi);

        Task Update(Trochoi Trochoi);

        Task Delete(Trochoi Trochoi);

        Task<int> DeletePermanently(string TroChoiId);

        int CountTroChoi();
    }
}
