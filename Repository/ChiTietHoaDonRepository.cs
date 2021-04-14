
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using QuanLyKVC.Models;

namespace QuanLyKVC.Repository
{
    public class ChiTietHoaDonRepository : IChiTietHoaDonRepository
    {
        AmusementParkContext db;
        public ChiTietHoaDonRepository(AmusementParkContext _db)
        {
            db = _db;
        }


        public async Task<List<Chitiethoadon>> List()
        {
            if (db != null)
            {
                try
                {
                    return await (
                        from row in db.Chitiethoadons
                        orderby row.MaHd descending
                        select row
                    ).ToListAsync();
                }
                catch (Exception e)
                {
                    string error = e.Message;
                }
            }

            return null;
        }


        public async Task<List<Chitiethoadon>> Search(string keyword)
        {
            if (db != null)
            {

                try
                {
                    return await (
                        from row in db.Chitiethoadons
                        where ((row.MaHd.Contains(keyword) || row.MaDv.Contains(keyword)))
                        orderby row.MaHd descending
                        select row
                    ).ToListAsync();

                }
                catch (Exception e)
                {
                    string error = e.Message;
                }
            }

            return null;
        }


        public async Task<List<Chitiethoadon>> ListPaging(int pageIndex, int pageSize)
        {
            int offSet = 0;
            offSet = (pageIndex - 1) * pageSize;
            if (db != null)
            {
                try
                {
                    return await (
                        from row in db.Chitiethoadons
                        orderby row.MaHd descending
                        select row
                    ).Skip(offSet).Take(pageSize).ToListAsync();

                }
                catch (Exception e)
                {
                    string error = e.Message;
                }
            }

            return null;
        }


        public async Task<List<Chitiethoadon>> Detail(string id)
        {
            if (db != null)
            {
                try
                {
                    return await (
                        from row in db.Chitiethoadons
                        where (row.MaHd == id)
                        select row)
                    .ToListAsync();

                }
                catch (Exception e)
                {
                    string error = e.Message;
                }
            }

            return null;
        }


        public async Task<Chitiethoadon> Add(Chitiethoadon obj)
        {
            if (db != null)
            {
                try
                {
                    await db.Chitiethoadons.AddAsync(obj);
                    await db.SaveChangesAsync();

                    return obj;

                }
                catch (Exception e)
                {
                    string error = e.Message;
                }
            }

            return null;
        }


        public async Task Update(Chitiethoadon obj)
        {
            if (db != null)
            {
                try
                {
                    //Update that object
                    db.Chitiethoadons.Attach(obj);
                    // db.Entry(obj).Property(x => x.Name).IsModified = true;
                    // db.Entry(obj).Property(x => x.Description).IsModified = true;
                    // db.Entry(obj).Property(x => x.Active).IsModified = true;
                    db.Entry(obj).Property(x => x.MaHd).IsModified = true;
                    db.Entry(obj).Property(x => x.MaDv).IsModified = true;
                    db.Entry(obj).Property(x => x.SoLanSuDungDv).IsModified = true;


                    //Commit the transaction
                    await db.SaveChangesAsync();

                }
                catch (Exception e)
                {
                    string error = e.Message;
                }
            }
        }


        public async Task Delete(Chitiethoadon obj)
        {
            if (db != null)
            {
                try
                {
                    //Update that obj
                    db.Chitiethoadons.Attach(obj);
                    db.Entry(obj).Property(x => x.MaHd).IsModified = true;

                    //Commit the transaction
                    await db.SaveChangesAsync();

                }
                catch (Exception e)
                {
                    string error = e.Message;
                }
            }
        }

        public async Task<int> DeletePermanently(string objId)
        {
            int result = 0;

            if (db != null)
            {
                try
                {
                    //Find the obj for specific obj id
                    var obj = await db.Chitiethoadons.FirstOrDefaultAsync(x => x.MaHd == objId);

                    if (obj != null)
                    {
                        //Delete that obj
                        db.Chitiethoadons.Remove(obj);

                        //Commit the transaction
                        result = await db.SaveChangesAsync();
                    }
                    return result;

                }
                catch (Exception e)
                {
                    string error = e.Message;
                }
            }

            return result;
        }


        public int CountChiTietHoaDon()
        {
            int result = 0;

            if (db != null)
            {
                try
                {
                    //Find the obj for specific obj id
                    result = (
                        from row in db.Chitiethoadons
                        select row
                    ).Count();

                }
                catch (Exception e)
                {
                    string error = e.Message;
                }
            }

            return result;
        }
    }
}

