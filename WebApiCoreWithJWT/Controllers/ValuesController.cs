using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http.Features;
using Microsoft.AspNetCore.Mvc;

namespace WebApiCoreWithJWT.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            var attrs = new List<string> {
                $"Aplicação: WebApiCoreWithJWT",
                $"Versão: {Assembly.GetExecutingAssembly().GetCustomAttribute<AssemblyFileVersionAttribute>().Version}",
                $"Descrição: {Assembly.GetExecutingAssembly().GetCustomAttribute<AssemblyDescriptionAttribute>().Description}",
                //$"IP: {HttpContext.Features.Get<IHttpConnectionFeature>().LocalIpAddress.ToString()}",
                //$"Total de Threads desse POD: {System.Diagnostics.Process.GetCurrentProcess().Threads.Count}",
                $"Data/Hora no servidor : {DateTime.Now.ToString()}",
            };

            return attrs.ToArray();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
