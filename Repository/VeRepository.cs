
using Microsoft.EntityFrameworkCore;
using QuanLyKVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuanLyKVC.Repository
{
    public class VeRepository : IVeRepository
    {
        AmusementParkContext db;
        public VeRepository(AmusementParkContext _db)
        {
            db = _db;
        }


        public async Task<List<Ve>> List()
        {
            if (db != null)
            {
                try
                {
                    return await (
                        from row in db.Ves
                        orderby row.MaVe descending
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


        public async Task<List<Ve>> Search(string keyword)
        {
            if (db != null)
            {

                try
                {
                    return await (
                        from row in db.Ves
                        where ((row.MaVe.Contains(keyword) || row.MaKhu.Contains(keyword)))
                        orderby row.MaVe descending
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


        public async Task<List<Ve>> ListPaging(int pageIndex, int pageSize)
        {
            int offSet = 0;
            offSet = (pageIndex - 1) * pageSize;
            if (db != null)
            {
                try
                {
                    return await (
                        from row in db.Ves

                        orderby row.MaVe descending
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


        public async Task<List<Ve>> Detail(string id)
        {
            if (db != null)
            {
                try
                {
                    return await (
                        from row in db.Ves
                        where (row.MaVe == id)
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


        public async Task<Ve> Add(Ve obj)
        {
            if (db != null)
            {
                try
                {
                    await db.Ves.AddAsync(obj);
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


        public async Task Update(Ve obj)
        {
            if (db != null)
            {
                try
                {
                    //Update that object
                    db.Ves.Attach(obj);
                    // db.Entry(obj).Property(x => x.Name).IsModified = true;
                    // db.Entry(obj).Property(x => x.Description).IsModified = true;
                    // db.Entry(obj).Property(x => x.Active).IsModified = true;
                    db.Entry(obj).Property(x => x.MaVe).IsModified = true;
                    db.Entry(obj).Property(x => x.MaKhu).IsModified = true;
                    db.Entry(obj).Property(x => x.NgayPhatHanh).IsModified = true;
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


        public async Task Delete(Ve obj)
        {
            if (db != null)
            {
                try
                {
                    //Update that obj
                    db.Ves.Attach(obj);
                    db.Entry(obj).Property(x => x.MaVe).IsModified = true;

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
                    var obj = await db.Ves.FirstOrDefaultAsync(x => x.MaVe == objId);

                    if (obj != null)
                    {
                        //Delete that obj
                        db.Ves.Remove(obj);

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


        public int CountVe()
        {
            int result = 0;

            if (db != null)
            {
                try
                {
                    //Find the obj for specific obj id
                    result = (
                        from row in db.Ves
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

