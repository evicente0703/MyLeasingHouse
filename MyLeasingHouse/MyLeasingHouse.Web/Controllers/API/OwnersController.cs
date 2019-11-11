using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyLeasing.Web.Data;
using MyLeasingHouse.Common.Models;
using System.Threading.Tasks;

namespace MyLeasingHouse.Web.Controllers.API
{
    [Route("api/[controller]")]
    [ApiController]
    public class OwnersController : ControllerBase
    {
        private readonly DataContext _dataContext;

        public OwnersController(DataContext dataContext)
        {
            _dataContext = dataContext;
        }


        [HttpPost]
        [Route("GetOwnerByEmail")]
        public async Task<IActionResult> GetOwnerByEmailAsync(EmailRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            var owner = await _dataContext.Owners
                .FirstOrDefaultAsync(o => o.User.Email.ToLower() == request.Email.ToLower());
            if (owner == null)
            {
                return NotFound();
            }
            return Ok(owner);
        }
    }
}
