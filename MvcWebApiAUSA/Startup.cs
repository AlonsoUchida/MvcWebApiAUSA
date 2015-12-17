using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(MvcWebApiAUSA.Startup))]

namespace MvcWebApiAUSA
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            MvcWebApiAUSA.Unity.Bootstrapper.Initialise();
            ConfigureAuth(app);
        }
    }
}
