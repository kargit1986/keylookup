using System.Linq;
using keylookup.Application.UseCases.LookupFromCache;
using keylookup.Common;
using Microsoft.AspNetCore.Mvc;

namespace keylookup.Controllers
{
    [Route("api/[controller]")]
    public class LookupController : Controller
    {
        private LookupFromCache lookUpFromCache;
        public LookupController(LookupFromCache lookupUseCase)
        {
            this.lookUpFromCache = lookupUseCase;
        }
        

        [HttpGet]
        [Route("convert/{id}")]
        public IActionResult Index(string id)
        {
            var response = this.lookUpFromCache.Execute(new LookupFromCacheRequest() {Id = id});
            return Ok(response);
        }
    }
}