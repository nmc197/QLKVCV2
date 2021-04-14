
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;
//using Novatic.Repository;
//using Microsoft.AspNetCore.Http;
//using Microsoft.AspNetCore.Mvc;
//using QuanLyKVC.Controllers.Core;
//using QuanLyKVC.Util;
//using QuanLyKVC.Models;

//namespace Novatic.Controllers
//{
//    [Route("[controller]")]
//    [ApiController]
//    public class ThietBiController : BaseController
//    {
//        IThietBiRepository repository;
//        public ThietBiController(IThietBiRepository _repository, ICacheHelper cacheHelper) : base(cacheHelper)
//        {
//            repository = _repository;
//        }


//        [HttpGet]
//        [Route("admin/List")]
//        public async Task<IActionResult> AdminList()
//        {
//            try
//            {
//                var dataList = await repository.List();

//                if (dataList == null || dataList.Count == 0)
//                {
//                    //return NotFound();
//                }


//                ViewBag.entities = dataList;
//                return View(dataList);

//                //var novaticResponse = NovaResponse.SUCCESS(dataList.Cast<object>().ToList());
//                ////var response = Newtonsoft.Json.JsonConvert.SerializeObject(novaticResponse);
//                //return Ok(novaticResponse);
//            }
//            catch (Exception)
//            {
//                return BadRequest();
//            }
//        }


//        [HttpGet]
//        [Route("api/List")]
//        public async Task<IActionResult> List()
//        {
//            try
//            {
//                var dataList = await repository.List();

//                if (dataList == null || dataList.Count == 0)
//                {
//                    return NotFound();
//                }

//                var novaticResponse = NovaResponse.SUCCESS(dataList.Cast<object>().ToList());
//                //var response = Newtonsoft.Json.JsonConvert.SerializeObject(novaticResponse);
//                return Ok(novaticResponse);
//            }
//            catch (Exception)
//            {
//                return BadRequest();
//            }
//        }


//        [HttpGet]
//        [Route("api/Detail/{Id}")]
//        public async Task<IActionResult> Detail(string Id)
//        {
//            if (Id == null)
//            {
//                return BadRequest();
//            }

//            try
//            {
//                var dataList = await repository.Detail(Id);

//                if (dataList == null || dataList.Count == 0)
//                {
//                    return NotFound();
//                }

//                var novaticResponse = NovaResponse.SUCCESS(dataList.Cast<object>().ToList());
//                return Ok(novaticResponse);
//            }
//            catch (Exception)
//            {
//                return BadRequest();
//            }
//        }


//        [HttpGet]
//        [Route("api/Search")]
//        public async Task<IActionResult> Search(string keyword)
//        {
//            try
//            {
//                var dataList = await repository.Search(keyword);

//                if (dataList == null || dataList.Count == 0)
//                {
//                    return NotFound();
//                }

//                var novaticResponse = NovaResponse.SUCCESS(dataList.Cast<object>().ToList());
//                return Ok(novaticResponse);
//            }
//            catch (Exception)
//            {
//                return BadRequest();
//            }
//        }


//        [HttpGet]
//        [Route("api/ListPaging")]
//        public async Task<IActionResult> ListPaging(int pageIndex, int pageSize)
//        {
//            if (pageIndex < 0 || pageSize < 0) return BadRequest();
//            try
//            {
//                var dataList = await repository.ListPaging(pageIndex, pageSize);

//                if (dataList == null || dataList.Count == 0)
//                {
//                    return NotFound();
//                }

//                var novaticResponse = NovaResponse.SUCCESS(dataList.Cast<object>().ToList());
//                return Ok(novaticResponse);
//            }
//            catch (Exception)
//            {
//                return BadRequest();
//            }
//        }


//        [HttpPost]
//        [Route("api/Add")]
//        public async Task<IActionResult> Add([FromBody]Thietbi model)
//        {
//            if (ModelState.IsValid)
//            {
//                //1. business logic

//                //data validation
//                if (model.TenTb.Length == 0)
//                {
//                    return BadRequest();
//                }

//                //auto correct

//                //2. add new object
//                try
//                {
//                    var newObj = await repository.Add(model);
//                    if (newObj.Id > 0)
//                    {
//                        var novaticResponse = NovaResponse.CREATED(model);
//                        return Created("", novaticResponse);
//                    }
//                    else
//                    {
//                        return NotFound();
//                    }
//                }
//                catch (Exception)
//                {

//                    return BadRequest();
//                }
//            }
//            return BadRequest();
//        }


//        [HttpPost]
//        [Route("api/Update")]
//        public async Task<IActionResult> Update([FromBody]Thietbi model)
//        {
//            if (ModelState.IsValid)
//            {
//                try
//                {
//                    //1. business logic 


//                    //2. update object
//                    await repository.Update(model);

//                    var novaticResponse = NovaResponse.SUCCESS(model);
//                    return Ok(novaticResponse);
//                }
//                catch (Exception ex)
//                {
//                    if (ex.GetType().FullName == "Microsoft.EntityFrameworkCore.DbUpdateConcurrencyException")
//                    {
//                        return NotFound();
//                    }

//                    return BadRequest();
//                }
//            }
//            return BadRequest();
//        }


//        [HttpPost]
//        [Route("api/Delete")]
//        public async Task<IActionResult> Delete([FromBody]ThietBi model)
//        {
//            if (ModelState.IsValid)
//            {
//                try
//                {
//                    //1. business logic
//                    //set Active to 0
//                    model.Active = 0;

//                    //2. logically delete object
//                    await repository.Delete(model);

//                    var novaticResponse = NovaResponse.SUCCESS(model);
//                    return Ok(novaticResponse);
//                }
//                catch (Exception ex)
//                {
//                    if (ex.GetType().FullName == "Microsoft.EntityFrameworkCore.DbUpdateConcurrencyException")
//                    {
//                        return NotFound();
//                    }

//                    return BadRequest();
//                }
//            }
//            return BadRequest();
//        }


//        [HttpPost]
//        [Route("api/DeletePermanently")]
//        public async Task<IActionResult> DeletePermanently([FromBody]ThietBi model)
//        {
//            int result = 0;

//            if (!(model.Id > 0))
//            {
//                return BadRequest();
//            }

//            try
//            {
//                //physically delete object
//                result = await repository.DeletePermanently(model.Id);
//                if (result == 0)
//                {
//                    return NotFound();
//                }
//                var novaticResponse = NovaResponse.SUCCESS(model);
//                return Ok(novaticResponse);
//            }
//            catch (Exception)
//            {
//                return BadRequest();
//            }
//        }


//        [HttpGet]
//        [Route("api/Count")]
//        public int CountThietBi()
//        {
//            int result = repository.CountThietBi();
//            return result;
//        }
//    }
//}
