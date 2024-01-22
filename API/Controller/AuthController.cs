using System.Threading.Tasks;
using juttrips_azure_function.API.Model.Function;
using juttrips_azure_function.API.Model.Request;
using juttrips_azure_function.API.Validator.Auth;
using juttrips_azure_function.Core.Interface;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;

namespace juttrips_azure_function.API.Controller;

public class AuthController
{
    private readonly IAuthService _authService;

    public AuthController(IAuthService authService)
    {
        _authService = authService;
    }
    
    [FunctionName(FunctionName.RegisterName)]
    public async Task<IActionResult> Register([HttpTrigger(AuthorizationLevel.Anonymous, "post", 
        Route = EndPoint.RegisterEndPoint)] RegisterRequest registerRequest)
    {
        var validateResult = registerRequest.Validate();
        
        if (!validateResult.IsValid)
        {
            return validateResult.ExceptionResult;
        }
        
        var user = await _authService.CreateUserAsync(registerRequest);
        
        return new OkObjectResult(user);
    }
}