
using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using QuanLyKVC.Controllers.Core;
using QuanLyKVC.Repository;
using QuanLyKVC.Util;
using QuanLyKVC.Models;

namespace Novatic.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class NhanVienController : ControllerBase
    {
        INhanVienRepository repository;
        public NhanVienController(INhanVienRepository _repository)
        {
            repository = _repository;
        }


       


        [HttpGet]
        [Route("api/List")]
        public async Task<IActionResult> List()
        {
            try
            {
                var dataList = await repository.List();

                if (dataList == null || dataList.Count == 0)
                {
                    return NotFound();
                }

                var novaticResponse = NovaResponse.SUCCESS(dataList.Cast<object>().ToList());
                //var response = Newtonsoft.Json.JsonConvert.SerializeObject(novaticResponse);
                return Ok(novaticResponse);
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }


        [HttpGet]
        [Route("api/Detail/{Id}")]
        public async Task<IActionResult> Detail(string Id)
        {
            if (Id == null)
            {
                return BadRequest();
            }

            try
            {
                var dataList = await repository.Detail(Id);

                if (dataList == null || dataList.Count == 0)
                {
                    return NotFound();
                }

                var novaticResponse = NovaResponse.SUCCESS(dataList.Cast<object>().ToList());
                return Ok(novaticResponse);
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }


        [HttpGet]
        [Route("api/Search")]
        public async Task<IActionResult> Search(string keyword)
        {
            try
            {
                var dataList = await repository.Search(keyword);

                if (dataList == null || dataList.Count == 0)
                {
                    return NotFound();
                }

                var novaticResponse = NovaResponse.SUCCESS(dataList.Cast<object>().ToList());
                return Ok(novaticResponse);
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }


        [HttpGet]
        [Route("api/ListPaging")]
        public async Task<IActionResult> ListPaging(int pageIndex, int pageSize)
        {
            if (pageIndex < 0 || pageSize < 0) return BadRequest();
            try
            {
                var dataList = await repository.ListPaging(pageIndex, pageSize);

                if (dataList == null || dataList.Count == 0)
                {
                    return NotFound();
                }

                var novaticResponse = NovaResponse.SUCCESS(dataList.Cast<object>().ToList());
                return Ok(novaticResponse);
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }


        [HttpPost]
        [Route("api/Add")]
        public async Task<IActionResult> Add([FromBody]Nhanvien model)
        {
            if (ModelState.IsValid)
            {
                //1. business logic

                //data validation
                if (model.TenNv.Length == 0)
                {
                    return BadRequest();
                }

                //auto correct

                //2. add new object
                try
                {
                    var newObj = await repository.Add(model);
                    if (newObj.MaNv != null)
                    {
                        var novaticResponse = NovaResponse.CREATED(model);
                        return Created("", novaticResponse);
                    }
                    else
                    {
                        return NotFound();
                    }
                }
                catch (Exception)
                {

                    return BadRequest();
                }
            }
            return BadRequest();
        }


        [HttpPost]
        [Route("api/Update")]
        public async Task<IActionResult> Update([FromBody]Nhanvien model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    //1. business logic 


                    //2. update object
                    await repository.Update(model);

                    var novaticResponse = NovaResponse.SUCCESS(model);
                    return Ok(novaticResponse);
                }
                catch (Exception ex)
                {
                    if (ex.GetType().FullName == "Microsoft.EntityFrameworkCore.DbUpdateConcurrencyException")
                    {
                        return NotFound();
                    }

                    return BadRequest();
                }
            }
            return BadRequest();
        }


        [HttpPost]
        [Route("api/Delete")]
        public async Task<IActionResult> Delete([FromBody]Nhanvien model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    //1. business logic
                    //set Active to 0

                    //2. logically delete object
                    await repository.Delete(model);

                    var novaticResponse = NovaResponse.SUCCESS(model);
                    return Ok(novaticResponse);
                }
                catch (Exception ex)
                {
                    if (ex.GetType().FullName == "Microsoft.EntityFrameworkCore.DbUpdateConcurrencyException")
                    {
                        return NotFound();
                    }

                    return BadRequest();
                }
            }
            return BadRequest();
        }


        [HttpPost]
        [Route("api/DeletePermanently")]
        public async Task<IActionResult> DeletePermanently([FromBody]Nhanvien model)
        {
            int result = 0;

            if (!(model.MaNv != null))
            {
                return BadRequest();
            }

            try
            {
                //physically delete object
                result = await repository.DeletePermanently(model.MaNv);
                if (result == 0)
                {
                    return NotFound();
                }
                var novaticResponse = NovaResponse.SUCCESS(model);
                return Ok(novaticResponse);
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }


        [HttpGet]
        [Route("api/Count")]
        public int CountNhanVien()
        {
            int result = repository.CountNhanVien();
            return result;
        }
    }
}
