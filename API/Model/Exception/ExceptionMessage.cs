using Microsoft.VisualBasic;

namespace juttrips_azure_function.API.Model.Exception;

public static class ExceptionMessage
{
    private const string FieldRequireErrorMessage = "Invalid input. {0} is require.";

    public static string GetFieldRequireErrorMessage(string field)
    {
        return Strings.Format(FieldRequireErrorMessage, field);
    }
}