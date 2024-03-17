using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ThucHanhWebMVC3.Models;

namespace ThucHanhWebMVC3.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductAPIController : ControllerBase
    {
        QlbanVaLiContext db = new QlbanVaLiContext();
        [HttpGet]
        public IEnumerable<TDanhMucSp> GetAllProducts()
        {
            return db.TDanhMucSps.ToList();
        }
    }
}
