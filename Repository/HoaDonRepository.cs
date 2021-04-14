
using Microsoft.EntityFrameworkCore;
using QuanLyKVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuanLyKVC.Repository
{
    public class HoaDonRepository : IHoaDonRepository
    {
        AmusementParkContext db;
        public HoaDonRepository(AmusementParkContext _db)
        {
            db = _db;
        }


        public async Task<List<Hoadon>> List()
        {
            if (db != null)
            {
                try
                {
                    return await (
                        from row in db.Hoadons
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


        public async Task<List<Hoadon>> Search(string keyword)
        {
            if (db != null)
            {

                try
                {
                    return await (
                        from row in db.Hoadons
                        where ((row.MaHd.Contains(keyword)))
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


        public async Task<List<Hoadon>> ListPaging(int pageIndex, int pageSize)
        {
            int offSet = 0;
            offSet = (pageIndex - 1) * pageSize;
            if (db != null)
            {
                try
                {
                    return await (
                        from row in db.Hoadons
                       
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


        public async Task<List<Hoadon>> Detail(string id)
        {
            if (db != null)
            {
                try
                {
                    return await (
                        from row in db.Hoadons
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


        public async Task<Hoadon> Add(Hoadon obj)
        {
            if (db != null)
            {
                try
                {
                    await db.Hoadons.AddAsync(obj);
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


        public async Task Update(Hoadon obj)
        {
            if (db != null)
            {
                try
                {
                    //Update that object
                    db.Hoadons.Attach(obj);
                    // db.Entry(obj).Property(x => x.Name).IsModified = true;
                    // db.Entry(obj).Property(x => x.Description).IsModified = true;
                    // db.Entry(obj).Property(x => x.Active).IsModified = true;
                    db.Entry(obj).Property(x => x.MaHd).IsModified = true;
                    db.Entry(obj).Property(x => x.NgayHd).IsModified = true;
                    db.Entry(obj).Property(x => x.TongTien).IsModified = true;


                    //Commit the transaction
                    await db.SaveChangesAsync();

                }
                catch (Exception e)
                {
                    string error = e.Message;
                }
            }
        }


        public async Task Delete(Hoadon obj)
        {
            if (db != null)
            {
                try
                {
                    //Update that obj
                    db.Hoadons.Attach(obj);
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
                    var obj = await db.Hoadons.FirstOrDefaultAsync(x => x.MaHd == objId);

                    if (obj != null)
                    {
                        //Delete that obj
                        db.Hoadons.Remove(obj);

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


        public int CountHoaDon()
        {
            int result = 0;

            if (db != null)
            {
                try
                {
                    //Find the obj for specific obj id
                    result = (
                        from row in db.Hoadons
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

