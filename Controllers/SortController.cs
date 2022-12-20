using Microsoft.AspNetCore.Mvc;

namespace app.Controllers;

[ApiController]
[Route("sort")]
public class sort{

    [HttpGet]
    public String[] sortNames([FromQuery]string[] names){

        int comp = 0;

        for(int i = 0; i < names.Length; i++){
            for(int j = 0; j < names.Length - 1; j++){
                comp = String.Compare(names[j], names[j+1]);
                if(comp > 0){
                    string temp = names[j];
                    names[j] = names[j+1];
                    names[j+1] = temp;
                }
            }
            
        }
        return names;
    }
}