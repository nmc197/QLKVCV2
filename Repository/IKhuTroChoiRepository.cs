
using QuanLyKVC.Models;
using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    namespace QuanLyKVC.Repository
    {
        public interface IKhuTroChoiRepository
        {
            Task<List<Khutrochoi>> List();

            Task<List<Khutrochoi>> Search(string keyword);

            Task<List<Khutrochoi>> ListPaging(int pageIndex, int pageSize);

            Task<List<Khutrochoi>> Detail(string postId);

            Task<Khutrochoi> Add(Khutrochoi KhuTroChoi);

            Task Update(Khutrochoi KhuTroChoi);

            Task Delete(Khutrochoi KhuTroChoi);

            Task<int> DeletePermanently(string KhuTroChoiId);

            int CountKhuTroChoi();
        }
    }
    