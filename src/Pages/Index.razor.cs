using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.Options;
using System;
using System.Threading.Tasks;
using System.Timers;

namespace DotNetConf.Web.Pages
{
    public partial class Index
    {
        private TimeSpan countDown;
        private static readonly Timer timer = new Timer();

        [Inject] public IOptions<SiteConfigOptions> Options { get; set; }

        private SiteConfigOptions Config => Options.Value;

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
