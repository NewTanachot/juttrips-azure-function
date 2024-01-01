using System.IO;
using System.Threading.Tasks;
using juttrips_azure_function.Domain.Entities;
using juttrips_azure_function.Infrastructure.DatabaseConfig;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace juttrips_azure_function.API;

public class HttpTest
{
    private readonly JutTripsDbContext _dbContext;

    public HttpTest(JutTripsDbContext dbContext)
    {
        _dbContext = dbContext;
    }
    
    [FunctionName("test")]
    public async Task<IActionResult> RunAsync(
        [HttpTrigger(AuthorizationLevel.Anonymous, "get")] HttpRequest req, ILogger log)
    {
        log.LogInformation("C# HTTP trigger function processed a request.");
        
        log.LogInformation(DatabaseMetaData.GetMySqlConnectionString());
            
        string name = req.Query["name"];

        string requestBody = await new StreamReader(req.Body).ReadToEndAsync();
        dynamic data = JsonConvert.DeserializeObject(requestBody);
        name = name ?? data?.name;

        return name != null
            ? (ActionResult) new OkObjectResult($"Hello, {name}")
            : new BadRequestObjectResult("Please pass a name on the query string or in the request body");
    }
    
    [FunctionName("users")]
    public async Task<IActionResult> GetUsers(
        [HttpTrigger(AuthorizationLevel.Anonymous, "get")] HttpRequest req)
    {
        var result = await _dbContext.Users.ToListAsync();
    
        return new OkObjectResult(result);
    }
    
    [FunctionName("user")]
    public async Task<IActionResult> PostUsers(
        [HttpTrigger(AuthorizationLevel.Anonymous, "post")] HttpRequest req)
    {
        var user = new User()
        {
            UserName = "Newtanachot",
            Password = "password"
        };

        await _dbContext.Users.AddAsync(user);
        await _dbContext.SaveChangesAsync();
    
        return new OkResult();
    }
}