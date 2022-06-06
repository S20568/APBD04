using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using Cw5.Models;
using Cw5.Services;
using Cw5.Exceptions;

namespace Cw5.Controllers
{
    [Route("api/warehouses")]
    [ApiController]
    public class WarehouseController : ControllerBase
    {
        private readonly IDbService DbService;

        public WarehouseController(IDbService DbService)
        {
            this.DbService = DbService;
        }

        [HttpPost]
        public async Task<IActionResult> AddProductToWarehouse([FromBody]ProductWarehouse productWarehouse)
        {
            int idProductWarehouse;
            try { idProductWarehouse = await DbService.AddProductToWarehouseAsync(productWarehouse); }
            catch (NoRowsException e) { return NotFound(e.Message); }
            catch (SomethingWentWrongException) { return NotFound(); }
            catch (Exception e) { return NotFound(e.Message); }
            return Ok($"Succsesfully added! ID: {idProductWarehouse}!");
        }
    }
}

