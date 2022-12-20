using Microsoft.AspNetCore.Mvc;

namespace app.Controllers;

[ApiController]
[Route("Count")]
public class NumbersController : ControllerBase{

    [HttpGet]
    public int Get(){
        return 1+1;
    }

    [HttpGet("{num}")]  
    public int multi(int num){
        return num * 7;
    }

}