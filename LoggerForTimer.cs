using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimchaAppV1
{
    public class LoggerForTimer
    {
        private readonly ILogger<LoggerForTimer> logger;

        public LoggerForTimer(ILogger<LoggerForTimer> logger)
        {
            this.logger = logger;

        }
        private void Eventlog()
        {
            logger.LogInformation($"Info:LogSuccessful {DateTime.Now}");
        }

        public void register()
        {
            Task.Delay(5).ContinueWith(x =>
                new System.Threading.Timer(

                e => Eventlog(),
                null,
                TimeSpan.FromSeconds(5),
                TimeSpan.FromSeconds(5)));
        }
    }
    
}
