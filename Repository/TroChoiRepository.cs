
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using QuanLyKVC.Models;

namespace QuanLyKVC.Repository
{
    public class TroChoiRepository : ITroChoiRepository
    {
        AmusementParkContext db;
        public TroChoiRepository(AmusementParkContext _db)
        {
            db = _db;
        }


        public async Task<List<Trochoi>> List()
        {
            if (db != null)
            {
                try
                {
                    return await (
                        from row in db.Trochois
                        orderby row.MaTroChoi descending
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


        public async Task<List<Trochoi>> Search(string keyword)
        {
            if (db != null)
            {

                try
                {
                    return await (
                        from row in db.Trochois
                        where ((row.TenTroChoi.Contains(keyword) || row.MaTroChoi.Contains(keyword)))
                        orderby row.MaTroChoi descending
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


        public async Task<List<Trochoi>> ListPaging(int pageIndex, int pageSize)
        {
            int offSet = 0;
            offSet = (pageIndex - 1) * pageSize;
            if (db != null)
            {
                try
                {
                    return await (
                        from row in db.Trochois
                        orderby row.MaTroChoi descending
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


        public async Task<List<Trochoi>> Detail(string id)
        {
            if (db != null)
            {
                try
                {
                    return await (
                        from row in db.Trochois
                        where (row.MaTroChoi == id)
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


        public async Task<Trochoi> Add(Trochoi obj)
        {
            if (db != null)
            {
                try
                {
                    await db.Trochois.AddAsync(obj);
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


        public async Task Update(Trochoi obj)
        {
            if (db != null)
            {
                try
                {
                    //Update that object
                    db.Trochois.Attach(obj);
                    // db.Entry(obj).Property(x => x.Name).IsModified = true;
                    // db.Entry(obj).Property(x => x.Description).IsModified = true;
                    // db.Entry(obj).Property(x => x.Active).IsModified = true;
                    db.Entry(obj).Property(x => x.MaTroChoi).IsModified = true;
                    db.Entry(obj).Property(x => x.TenTroChoi).IsModified = true;
                    db.Entry(obj).Property(x => x.MaNvphuTrach).IsModified = true;
                    db.Entry(obj).Property(x => x.SoLuongNguoiChoiMax).IsModified = true;
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


        public async Task Delete(Trochoi obj)
        {
            if (db != null)
            {
                try
                {
                    //Update that obj
                    db.Trochois.Attach(obj);
                    db.Entry(obj).Property(x => x.MaTroChoi).IsModified = true;

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
                    var obj = await db.Trochois.FirstOrDefaultAsync(x => x.MaTroChoi == objId);

                    if (obj != null)
                    {
                        //Delete that obj
                        db.Trochois.Remove(obj);

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


        public int CountTroChoi()
        {
            int result = 0;

            if (db != null)
            {
                try
                {
                    //Find the obj for specific obj id
                    result = (
                        from row in db.Trochois
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

