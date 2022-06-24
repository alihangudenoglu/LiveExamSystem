using Quartz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebUI.Jobs
{

    [DisallowConcurrentExecution]
    public class ShowDateTimeJob : IJob
    {
        public ShowDateTimeJob()
        {

        }
        public Task Execute(IJobExecutionContext context)
        {
            var now = DateTime.Now.ToString("HH : mm : ss");
            System.Console.WriteLine($" Merhaba, saat şuan {now}");
            return Task.CompletedTask;
        }
    }
}
