using Microsoft.AspNetCore.Components;
using System;
using System.Threading.Tasks;
using System.Timers;
using DotNetConf.Web.Services;

namespace DotNetConf.Web.Pages
{
    public partial class Index : ComponentBase
    {
        private TimeSpan countDown;
        private static readonly Timer timer = new Timer();

        private Locale Config => LocaleService.CurrentLocale;

        protected override Task OnInitializedAsync()
        {
            Refresh();

            timer.Elapsed += Refresh;
            timer.Interval = 500;
            timer.Start();

            return Task.CompletedTask;
        }

        private void Refresh(object sender = default, ElapsedEventArgs e = default)
        {
            if (Config.Conf != null)
            {
                countDown = Config.Conf.Coundown - DateTime.Now;
                InvokeAsync(StateHasChanged);
            }
        }
    }
}