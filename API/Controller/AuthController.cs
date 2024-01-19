using juttrips_azure_function.API.Enum;
using juttrips_azure_function.API.Model.Request;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;

namespace juttrips_azure_function.API.Controller;

public class AuthController
{
    [FunctionName(AuthEndpoint.RegisterName)]
    public IActionResult Register([HttpTrigger(AuthorizationLevel.Anonymous, "post", 
        Route = AuthEndpoint.RegisterEndPoint)] RegisterRequest registerRequest)
    {
        var response = new OkObjectResult(registerRequest);
        return response;
    }
}