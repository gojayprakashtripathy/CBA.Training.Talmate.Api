using CBA.Training.Talmate.Services.LoggerService;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CBA.Training.Talmate.Api.ExceptionHandling
{
    public class CustomExceptionHandler : ExceptionFilterAttribute
    {
        private readonly ILoggerService _logger;
        public CustomExceptionHandler(ILoggerService logger)
        {
            _logger = logger;
        }
        public override void OnException(ExceptionContext context)
        {            
            Exception ex = context.Exception;
            _logger.WriteErrorToFile(ex.Message.ToString());
        }
    }
}
