using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using QuanLyKVC.Models;

namespace QuanLyKVC.Repository
{
    public class KhuTroChoiRepository : IKhuTroChoiRepository
    {
        AmusementParkContext db;
        public KhuTroChoiRepository(AmusementParkContext _db)
        {
            db = _db;
        }


        public async Task<List<Khutrochoi>> List()
        {
            if (db != null)
            {
                try
                {
                    return await (
                        from row in db.Khutrochois
                        orderby row.MaKhu descending
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


        public async Task<List<Khutrochoi>> Search(string keyword)
        {
            if (db != null)
            {

                try
                {
                    return await (
                        from row in db.Khutrochois
                        where ((row.TenKhu.Contains(keyword) || row.MaKhu.Contains(keyword)))
                        orderby row.MaKhu descending
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


        public async Task<List<Khutrochoi>> ListPaging(int pageIndex, int pageSize)
        {
            int offSet = 0;
            offSet = (pageIndex - 1) * pageSize;
            if (db != null)
            {
                try
                {
                    return await (
                        from row in db.Khutrochois
                        orderby row.MaKhu descending
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


        public async Task<List<Khutrochoi>> Detail(string id)
        {
            if (db != null)
            {
                try
                {
                    return await (
                        from row in db.Khutrochois
                        where (row.MaKhu == id)
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


        public async Task<Khutrochoi> Add(Khutrochoi obj)
        {
            if (db != null)
            {
                try
                {
                    await db.Khutrochois.AddAsync(obj);
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


        public async Task Update(Khutrochoi obj)
        {
            if (db != null)
            {
                try
                {
                    //Update that object
                    db.Khutrochois.Attach(obj);
                    // db.Entry(obj).Property(x => x.Name).IsModified = true;
                    // db.Entry(obj).Property(x => x.Description).IsModified = true;
                    // db.Entry(obj).Property(x => x.Active).IsModified = true;
                    db.Entry(obj).Property(x => x.MaKhu).IsModified = true;
                    db.Entry(obj).Property(x => x.TenKhu).IsModified = true;
                    db.Entry(obj).Property(x => x.GiaVeTreEm).IsModified = true;
                    db.Entry(obj).Property(x => x.GiaVeNguoiLon).IsModified = true;


                    //Commit the transaction
                    await db.SaveChangesAsync();

                }
                catch (Exception e)
                {
                    string error = e.Message;
                }
            }
        }


        public async Task Delete(Khutrochoi obj)
        {
            if (db != null)
            {
                try
                {
                    //Update that obj
                    db.Khutrochois.Attach(obj);
                    db.Entry(obj).Property(x => x.MaKhu).IsModified = true;

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
                    var obj = await db.Khutrochois.FirstOrDefaultAsync(x => x.MaKhu == objId);

                    if (obj != null)
                    {
                        //Delete that obj
                        db.Khutrochois.Remove(obj);

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


        public int CountKhuTroChoi()
        {
            int result = 0;

            if (db != null)
            {
                try
                {
                    //Find the obj for specific obj id
                    result = (
                        from row in db.Khutrochois
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

