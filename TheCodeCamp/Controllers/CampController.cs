using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;
using TheCodeCamp.Data;

namespace TheCodeCamp.Controllers
{
    public class CampController : ApiController
    {
        private readonly ICampRepository _repository;

        public CampController(ICampRepository repository)
        {
            _repository = repository;
        }
        public async Task<IHttpActionResult> Get()
        {
            try
            {
                var result = await _repository.GetAllCampsAsync();
                return Ok(result);
            }
            catch (Exception ex)
            {
                // TODO Add Logging
                return InternalServerError(ex);   
            }
        }
    }
}