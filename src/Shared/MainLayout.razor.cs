using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetConf.Web.Shared
{
    public partial class MainLayout
    {
        [Inject] public IOptions<SiteConfigOptions> Options { get; set; }

        private SiteConfigOptions Config => Options.Value;
    }
}
