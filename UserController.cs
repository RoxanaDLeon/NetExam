using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Test_NET.Models;

namespace Test_NET.Controllers
{
    [ApiController]
    [Route("api/controller")]
    public class UserController:ControllerBase
    {
        private static List<User> user= new List<User>{
            new User(),
            new User{UserId=1, Name="Sara", UserType=101, email="sara.heras@deloitte.com",phone=998756}
        };

        
        [HttpPost("AddUser")]
        public ActionResult<List<User>> Add(User newUser)
        {
            user.Add(newUser);
            return Ok(user);  
        }

        [HttpGet("{id}")]
        public ActionResult<User> GetByUser(int Id)
        {
            return Ok(user.FirstOrDefault(c=>c.UserId==Id));
        }

        [HttpPut("Update User")]

        public ActionResult<List<User>> UpdateUser (User newUser)
        {
            user.Add(newUser);    
            return Ok(user);
        } 

        [HttpDelete("DeleteUser")]
        public ActionResult<List<User>> DeleteUser (User newUser){
            user.Remove(newUser);
            return Ok(user);
        }

        [HttpGet("GetAll")]
        public ActionResult<List<User>> Get()
        {
            return Ok(user);  
        }

        [HttpGet("GetByUser")]
        public ActionResult<User> GetUser (int Id)
        {
            return Ok(user.FirstOrDefault(c=>c.UserId==Id));
        }
    }
}