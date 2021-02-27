using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarImagesController : ControllerBase
    {
        ICarImageService _carImageService;

        public CarImagesController(ICarImageService carImageService)
        {
            _carImageService = carImageService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _carImageService.GetAll();

            if (result.Success)
            {
                return Ok(result); //200
            }

            return BadRequest(result);
        }

        [HttpGet("getimagebyid")]
        public IActionResult GetImageById(int id)
        {
            var result = _carImageService.GetImageById(id);

            if (result.Success)
            {
                return Ok(result); //200
            }

            return BadRequest(result);
        }

        [HttpGet("getallimagesbycarid")]
        public IActionResult GetAllImagesByCarId(int id)
        {
            var result = _carImageService.GetAllImagesByCarId(id);

            if(result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

        [HttpPost("add")]
        public IActionResult Add([FromForm(Name = ("Image"))] IFormFile file,[FromForm] CarImage ci)
        {
            var result = _carImageService.Add(file,ci);
            
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

        [HttpDelete("delete")]
        public IActionResult Delete([FromForm] int carImageId)
        {
            var toDelete = _carImageService.GetImageById(carImageId).Data;

            var result = _carImageService.Delete(toDelete);

            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

        [HttpPost("update")]
        public IActionResult Update([FromForm(Name = ("Image"))] IFormFile file, [FromForm] int carImageId)
        {
            CarImage ci = _carImageService.GetImageById(carImageId).Data;

            var result = _carImageService.Update(file,ci);

            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }
    }
}
