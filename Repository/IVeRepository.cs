
using QuanLyKVC.Models;
using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    namespace QuanLyKVC.Repository
    {
        public interface IVeRepository
        {
            Task<List<Ve>> List();

            Task<List<Ve>> Search(string keyword);

            Task<List<Ve>> ListPaging(int pageIndex, int pageSize);

            Task<List<Ve>> Detail(string postId);

            Task<Ve> Add(Ve Ve);

            Task Update(Ve Ve);

            Task Delete(Ve Ve);

            Task<int> DeletePermanently(string VeId);

            int CountVe();
        }
    }
    