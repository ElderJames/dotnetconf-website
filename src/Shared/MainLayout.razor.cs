using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DotNetConf.Web.Services;

namespace DotNetConf.Web.Shared
{
    public partial class MainLayout
    {
        private Locale Config => LocaleService.CurrentLocale;
    }
}