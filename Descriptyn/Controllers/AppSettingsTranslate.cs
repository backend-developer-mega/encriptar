using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Descriptyn.Controllers
{
    public class AppSettingsTranslate
    {
        // Connection
        public string FmtT { set; get; }
        // Host
        public string GmXd { set; get; }
        // Port
        public string Rywe { set; get; }
        // User
        public string Htcz { set; get; }
        // Password
        public string WfKi { set; get; }
        // ServerName
        public string Zgce { set; get; }
    }

    public class AppSettings
    {
        public AppSettings(AppSettingsTranslate config)
        {
            this.Connection = config.FmtT;
            this.Host = config.GmXd;
            this.Port = config.Rywe;
            this.User = config.Htcz;
            this.Password = config.WfKi;
            this.ServerName = config.Zgce;
        }

        public string Connection { set; get; }
        public string Host { set; get; }
        public string Port { set; get; }
        public string User { set; get; }
        public string Password { set; get; }
        public string ServerName { set; get; }

        public override string ToString()
        {
            return Connection + Host + Port + User + Password + ServerName;
        }
    }

}
