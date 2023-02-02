using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

using MongoDB.Driver;
using MongoORM.Models;
using MongoDB.Entities;
namespace MongoORM.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MongoOrm : ControllerBase
    {


 
        [HttpGet(Name = "test")]
        public void Get1()

        {

        }




    }
}