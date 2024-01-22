using System;
using System.Web.Http;
using juttrips_azure_function.API.Model.Exception;
using Microsoft.AspNetCore.Mvc;

namespace juttrips_azure_function.API.Model.Validator;

public class ValidateResult
{
    public bool IsValid { get; set; }
    public IActionResult ExceptionResult { get; set; }

    public ValidateResult()
    {
        this.IsValid = true;
        this.ExceptionResult = new OkResult();
    }

    public ValidateResult(ExceptionType exceptionType, string message)
    {
        this.IsValid = false;
        this.ExceptionResult = exceptionType switch
        {
            ExceptionType.FieldRequire => new BadRequestErrorMessageResult(message),
            _ => new BadRequestResult()
        };
    }
}