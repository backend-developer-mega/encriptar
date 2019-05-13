using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Descriptyn.Util;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace Descriptyn.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly IOptions<AppSettingsTranslate> _config;

        public ValuesController(IOptions<AppSettingsTranslate> config)
        {
            this._config = config;
        }

        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            string value = new DecryptString(_config).toFormStringKey();
            return new string[] { "FmtT", value };
        }

        // GET api/values/5
        [HttpGet("{text}/{data}")]
        public ActionResult<string> Get(string text, string data)
        {
            string infconfigjson = "{\"nYOlZiAWZxQ=\":\"az/PAM8wHUo=\",\"BFjFcmt9UYk=\":\"Lg6UcClJAIjGUkbMwoAgLg==\"}";
            string infkjson = "{\"Ixis\":\"yxAiSeWSNj2XPdRFqi7q9D+Q/uwzmiGmTTm9m+BWb8IbcAlnKVIa8aSaAjkh2yqkHSl4RHX9gYGo\"}";
            string key = "gqyHU46ImoqpxJqmVWtdexgvmBBjOOPjQaoAfQ/xZ90zUGWAi5kdxrp4Xk1hq7+X8jQX+hIEDkAhQs4BP8C8A/sfs70W4asjxhpt9Sg84rk26xzdWVwpz1CLVPt+TlKiTAnnSLbUTZpVzra1C1IfoHGisrxSBiw+i12dI8vAjgiL9UxDxeKlRQ==AO+oIwHNvWw=nYOlZiAWZxQ=BFjFcmt9UYk=/N4ybPiUIdQ=";
            string result = EncryptClas.Encriptar(infkjson, key);
            return result+data;
        }

        // POST api/values
        [HttpPost]
        public string Post([FromBody] Data request)
        {
            string result = EncryptClas.DesEncriptar(request.cadena, request.key);
            return result;
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
