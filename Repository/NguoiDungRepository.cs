
using Microsoft.EntityFrameworkCore;
using QuanLyKVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuanLyKVC.Repository
{
    public class NguoiDungRepository : INguoiDungRepository
    {
        AmusementParkContext db;
        public NguoiDungRepository(AmusementParkContext _db)
        {
            db = _db;
        }


        public async Task<List<Nguoidung>> List()
        {
            if (db != null)
            {
                try
                {
                    return await (
                        from row in db.Nguoidungs
                        orderby row.MaNd descending
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


        public async Task<List<Nguoidung>> Search(string keyword)
        {
            if (db != null)
            {

                try
                {
                    return await (
                        from row in db.Nguoidungs
                        where ((row.Ten.Contains(keyword) || row.MaNd.Contains(keyword)))
                        orderby row.MaNd descending
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


        public async Task<List<Nguoidung>> ListPaging(int pageIndex, int pageSize)
        {
            int offSet = 0;
            offSet = (pageIndex - 1) * pageSize;
            if (db != null)
            {
                try
                {
                    return await (
                        from row in db.Nguoidungs
                        orderby row.MaNd descending
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


        public async Task<List<Nguoidung>> Detail(string id)
        {
            if (db != null)
            {
                try
                {
                    return await (
                        from row in db.Nguoidungs
                        where (row.MaNd == id)
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


        public async Task<Nguoidung> Add(Nguoidung obj)
        {
            if (db != null)
            {
                try
                {
                    await db.Nguoidungs.AddAsync(obj);
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


        public async Task Update(Nguoidung obj)
        {
            if (db != null)
            {
                try
                {
                    //Update that object
                    db.Nguoidungs.Attach(obj);
                    // db.Entry(obj).Property(x => x.Name).IsModified = true;
                    // db.Entry(obj).Property(x => x.Description).IsModified = true;
                    // db.Entry(obj).Property(x => x.Active).IsModified = true;
                    db.Entry(obj).Property(x => x.MaNd).IsModified = true;
                    db.Entry(obj).Property(x => x.Ten).IsModified = true;
                    db.Entry(obj).Property(x => x.TenDangNhap).IsModified = true;
                    db.Entry(obj).Property(x => x.MatKhau).IsModified = true;
                    db.Entry(obj).Property(x => x.MaNv).IsModified = true;
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


        public async Task Delete(Nguoidung obj)
        {
            if (db != null)
            {
                try
                {
                    //Update that obj
                    db.Nguoidungs.Attach(obj);
                    db.Entry(obj).Property(x => x.MaNd).IsModified = true;

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
                    var obj = await db.Nguoidungs.FirstOrDefaultAsync(x => x.MaNd == objId);

                    if (obj != null)
                    {
                        //Delete that obj
                        db.Nguoidungs.Remove(obj);

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


        public int CountNguoiDung()
        {
            int result = 0;

            if (db != null)
            {
                try
                {
                    //Find the obj for specific obj id
                    result = (
                        from row in db.Nguoidungs
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

