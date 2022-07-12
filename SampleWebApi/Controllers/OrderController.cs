using Microsoft.AspNetCore.Mvc;
using WebApplication1.Model;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private static List<OrderModel> _orders = new List<OrderModel>
        {
            new OrderModel()
            {
                Id = 1,
                CompanyId = "comp01",
                CustomerName = "Bill Smith",
                OrderDate = new DateTime(2022, 07, 6),
                OrderNumber = Guid.NewGuid().ToString(),
                Warehouse = "Warehouse 26"
            },
            new OrderModel()
            {
                Id = 2,
                CompanyId = "comp01",
                CustomerName = "Anne Warren",
                OrderDate = new DateTime(2022, 07, 6),
                OrderNumber = Guid.NewGuid().ToString(),
                Warehouse = "Warehouse 19"
            },
            new OrderModel()
            {
                Id = 3,
                CompanyId = "comp01",
                CustomerName = "Sam Bale",
                OrderDate = new DateTime(2022, 07, 6),
                OrderNumber = Guid.NewGuid().ToString(),
                Warehouse = "Warehouse 3"
            }
        };

        // GET: api/<OrderController>
        [HttpGet]
        public IEnumerable<OrderModel> GetAll()
        {
            return _orders;
        }

        // GET api/<OrderController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<OrderModel>>  Get(int id)
        {
            if (id < 0)
                return BadRequest();

            var order = _orders.FirstOrDefault(x => x.Id == id);

            if (order == null)
                return NotFound();

            return Ok(order);
        }

        // POST api/<OrderController>
        [HttpPost]
        public IActionResult Post([FromBody] OrderModel order)
        {
            // Validate
            if (order == null)
                return BadRequest();

            if (order.Id != 0)
            {
                return BadRequest("Do not set order id");
            }

            ((List<OrderModel>)_orders).Add(order);
            
            return Ok();
        }

        // DELETE api/<OrderController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }

        [HttpPost("Actual")]
        public IActionResult Actual([FromBody] Root root)
        {

            return Ok();
        }
    }
}
