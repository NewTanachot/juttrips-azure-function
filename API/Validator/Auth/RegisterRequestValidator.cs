using juttrips_azure_function.API.Model.Exception;
using juttrips_azure_function.API.Model.Request;
using juttrips_azure_function.API.Model.Validator;

namespace juttrips_azure_function.API.Validator.Auth;

public static class RegisterRequestValidator
{
    public static ValidateResult Validate(this RegisterRequest registerRequest)
    {
        if (string.IsNullOrWhiteSpace(registerRequest.UserName))
        {
            return new ValidateResult(ExceptionType.FieldRequire, 
                ExceptionMessage.GetFieldRequireErrorMessage(nameof(registerRequest.UserName)));
        }

        if (string.IsNullOrWhiteSpace(registerRequest.Password))
        {
            return new ValidateResult(ExceptionType.FieldRequire, 
                ExceptionMessage.GetFieldRequireErrorMessage(nameof(registerRequest.Password)));
        }

        return new ValidateResult();
    }
}