
using Microsoft.EntityFrameworkCore;
using QuanLyKVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuanLyKVC.Repository
{
    public class QuyenRepository : IQuyenRepository
    {
        AmusementParkContext db;
        public QuyenRepository(AmusementParkContext _db)
        {
            db = _db;
        }


        public async Task<List<Quyen>> List()
        {
            if (db != null)
            {
                try
                {
                    return await (
                        from row in db.Quyens
                        orderby row.MaQuyen descending
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


        public async Task<List<Quyen>> Search(string keyword)
        {
            if (db != null)
            {

                try
                {
                    return await (
                        from row in db.Quyens
                        where ((row.MieuTa.Contains(keyword) || row.KyHieuQuyen.Contains(keyword)))
                        orderby row.MaQuyen descending
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


        public async Task<List<Quyen>> ListPaging(int pageIndex, int pageSize)
        {
            int offSet = 0;
            offSet = (pageIndex - 1) * pageSize;
            if (db != null)
            {
                try
                {
                    return await (
                        from row in db.Quyens
                        orderby row.MaQuyen descending
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


        public async Task<List<Quyen>> Detail(string id)
        {
            if (db != null)
            {
                try
                {
                    return await (
                        from row in db.Quyens
                        where (row.MaQuyen == id)
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


        public async Task<Quyen> Add(Quyen obj)
        {
            if (db != null)
            {
                try
                {
                    await db.Quyens.AddAsync(obj);
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


        public async Task Update(Quyen obj)
        {
            if (db != null)
            {
                try
                {
                    //Update that object
                    db.Quyens.Attach(obj);
                    // db.Entry(obj).Property(x => x.Name).IsModified = true;
                    // db.Entry(obj).Property(x => x.Description).IsModified = true;
                    // db.Entry(obj).Property(x => x.Active).IsModified = true;
                    db.Entry(obj).Property(x => x.MaQuyen).IsModified = true;
                    db.Entry(obj).Property(x => x.TenQuyen).IsModified = true;
                    db.Entry(obj).Property(x => x.MieuTa).IsModified = true;
                    db.Entry(obj).Property(x => x.KyHieuQuyen).IsModified = true;


                    //Commit the transaction
                    await db.SaveChangesAsync();

                }
                catch (Exception e)
                {
                    string error = e.Message;
                }
            }
        }


        public async Task Delete(Quyen obj)
        {
            if (db != null)
            {
                try
                {
                    //Update that obj
                    db.Quyens.Attach(obj);
                    db.Entry(obj).Property(x => x.MaQuyen).IsModified = true;

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
                    var obj = await db.Quyens.FirstOrDefaultAsync(x => x.MaQuyen == objId);

                    if (obj != null)
                    {
                        //Delete that obj
                        db.Quyens.Remove(obj);

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


        public int CountQuyen()
        {
            int result = 0;

            if (db != null)
            {
                try
                {
                    //Find the obj for specific obj id
                    result = (
                        from row in db.Quyens
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

