using Microsoft.AspNetCore.Mvc;
using SerializeDeserializeDemo.Model;
using System.Text.Json;

namespace SerializeDeserializeDemo.Controllers;

[Route("api/[controller]")]
[ApiController]
public class Demo1Controller : ControllerBase
{
    public Demo1Controller()
    {      
    }

    [HttpGet]
    public ActionResult BuiltInSerializeDeserialize()
    {
        var employee = new Employee
        {
            Id = 1,
            FirstName = "Md. Saddam",
            LastName = "Hossain",
            Email = "test@test.com"
        };

        // Serialize
        var employeeJson = JsonSerializer.Serialize(employee);
       // return Ok(employeeJson);


        // Deserialize
        var employeeObj = JsonSerializer.Deserialize<Employee>(employeeJson);
        return Ok(employeeObj);
    }
}
