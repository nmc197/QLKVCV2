
using Microsoft.EntityFrameworkCore;
using QuanLyKVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuanLyKVC.Repository
{
    public class NhanVienRepository : INhanVienRepository
    {
        AmusementParkContext db;
        public NhanVienRepository(AmusementParkContext _db)
        {
            db = _db;
        }


        public async Task<List<Nhanvien>> List()
        {
            if (db != null)
            {
                try
                {
                    return await (
                        from row in db.Nhanviens
                        orderby row.MaNv descending
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


        public async Task<List<Nhanvien>> Search(string keyword)
        {
            if (db != null)
            {

                try
                {
                    return await (
                        from row in db.Nhanviens
                        where ((row.TenNv.Contains(keyword) || row.MaNv.Contains(keyword)))
                        orderby row.MaNv descending
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


        public async Task<List<Nhanvien>> ListPaging(int pageIndex, int pageSize)
        {
            int offSet = 0;
            offSet = (pageIndex - 1) * pageSize;
            if (db != null)
            {
                try
                {
                    return await (
                        from row in db.Nhanviens
                        orderby row.MaNv descending
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


        public async Task<List<Nhanvien>> Detail(string id)
        {
            if (db != null)
            {
                try
                {
                    return await (
                        from row in db.Nhanviens
                        where (row.MaNv == id)
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


        public async Task<Nhanvien> Add(Nhanvien obj)
        {
            if (db != null)
            {
                try
                {
                    await db.Nhanviens.AddAsync(obj);
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


        public async Task Update(Nhanvien obj)
        {
            if (db != null)
            {
                try
                {
                    //Update that object
                    db.Nhanviens.Attach(obj);
                    // db.Entry(obj).Property(x => x.Name).IsModified = true;
                    // db.Entry(obj).Property(x => x.Description).IsModified = true;
                    // db.Entry(obj).Property(x => x.Active).IsModified = true;
                    db.Entry(obj).Property(x => x.MaNv).IsModified = true;
                    db.Entry(obj).Property(x => x.TenNv).IsModified = true;
                    db.Entry(obj).Property(x => x.GioiTinh).IsModified = true;
                    db.Entry(obj).Property(x => x.MaKhuPhuTrach).IsModified = true;
                    db.Entry(obj).Property(x => x.Luong).IsModified = true;
                    db.Entry(obj).Property(x => x.QueQuan).IsModified = true;


                    //Commit the transaction
                    await db.SaveChangesAsync();

                }
                catch (Exception e)
                {
                    string error = e.Message;
                }
            }
        }


        public async Task Delete(Nhanvien obj)
        {
            if (db != null)
            {
                try
                {
                    //Update that obj
                    db.Nhanviens.Attach(obj);
                    db.Entry(obj).Property(x => x.MaNv).IsModified = true;

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
                    var obj = await db.Nhanviens.FirstOrDefaultAsync(x => x.MaNv == objId);

                    if (obj != null)
                    {
                        //Delete that obj
                        db.Nhanviens.Remove(obj);

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


        public int CountNhanVien()
        {
            int result = 0;

            if (db != null)
            {
                try
                {
                    //Find the obj for specific obj id
                    result = (
                        from row in db.Nhanviens
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

