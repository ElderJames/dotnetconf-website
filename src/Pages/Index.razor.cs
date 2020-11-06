using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Timers;

namespace DotNetConf.Web.Pages
{
    public partial class Index
    {
        private TimeSpan countDown;
        private static readonly Timer timer = new Timer();

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
            countDown = new DateTime(2020, 12, 19, 9, 30, 0, DateTimeKind.Local) - DateTime.Now;
            InvokeAsync(StateHasChanged);
        }
    }
}
