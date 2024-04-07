using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using SerializeDeserializeDemo.Model;

namespace SerializeDeserializeDemo.Controllers;
[Route("api/[controller]")]
[ApiController]
public class Demo2Controller : ControllerBase
{
    public Demo2Controller()
    {
    }

    [HttpGet]
    public ActionResult NewtonsoftSerializeDeserialize()
    {
        var employee = new Employee
        {
            Id = 1,
            FirstName = "Md. Saddam",
            LastName = "Hossain",
            Email = "test@test.com"
        };

        // Serialize
        var employeeJson = JsonConvert.SerializeObject(employee);
       // return Ok(employeeJson);


        // Deserialize
        var employeeObj = JsonConvert.DeserializeObject<Employee>(employeeJson);
        return Ok(employeeObj);
    }
}
