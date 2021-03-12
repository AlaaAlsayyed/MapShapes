using Application.DTOModels;
using Application.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UI.WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RegionShapeController : ControllerBase
    {
        private IRegionShapeService _regionShapeService;
        public RegionShapeController(IRegionShapeService regionShapeService)
        {
            _regionShapeService = regionShapeService;
        }

        // GET: api/RegionShape
        [HttpGet]
        public string Get()
        {
            var result = _regionShapeService.GetAll();
            return JsonConvert.SerializeObject(result);
        }

        // GET: api/RegionShape/5
        [HttpGet("{id}")]
        public string Get(int Id)
        {
            var result = _regionShapeService.GetById(Id);
            return JsonConvert.SerializeObject(result);
        }

        // POST: api/RegionShape
        [HttpPost]
        public string Post([FromBody] RegionShapeDTO AreaDto)
        {
            var result = _regionShapeService.Add(AreaDto);
            return JsonConvert.SerializeObject(result);
        }

        // PUT api/RegionShape
        [HttpPut]
        public string Put([FromBody] RegionShapeDTO AreaDto)
        {
            var result = _regionShapeService.Update(AreaDto);
            return JsonConvert.SerializeObject(result);
        }

        // DELETE api/RegionShape/5
        [HttpDelete("{id}")]
        public string Delete(int Id)
        {
            var result = _regionShapeService.DeleteById(Id);
            return JsonConvert.SerializeObject(result);
        }

    }
}
