using Descriptyn.Controllers;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Descriptyn.Util
{
    public class DecryptString
    {
        private readonly IOptions<AppSettingsTranslate> _config;

        public DecryptString(IOptions<AppSettingsTranslate> config)
        {
            this._config = config;
        
        }

        public string toFormStringKey()
        {
            AppSettings settings = new AppSettings(_config.Value);
            var result = settings.ToString();
            return result;
        }

        public string readFile(string path, string nameFile)
        {
            return File.ReadAllText(path + nameFile);
        }
            
    }
}
