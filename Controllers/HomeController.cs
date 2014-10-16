using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using myTestApp.Models;
using Newtonsoft.Json.Serialization;
using StackExchange.Redis;
using Newtonsoft.Json;
namespace myTestApp.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {    
            return View("Index",(object)GetPerson());
        }

        [HttpPost]
        public ActionResult SaveMe(string person)
        {
            
            using (var redis = ConnectionMultiplexer.Connect("localhost"))
            {
                var dbRedis = redis.GetDatabase();
                dbRedis.StringSet("personMe", person);
            }
           
            return Json(new {newPerson=JsonConvert.DeserializeObject<Person>(person)});
        }

        

       

        private string GetPerson()
        {
            var myVal = new Person();
            using (var redis = ConnectionMultiplexer.Connect("localhost"))
            {
                var dbRedis = redis.GetDatabase();
                if (dbRedis.KeyExists("personMe"))
                {
                    var tval = dbRedis.StringGet("personMe");
                    if (!tval.ToString().ToLower().Contains("null"))
                    {
                        myVal = JsonConvert.DeserializeObject<Person>(tval);    
                    }
                    
                }

            }
            var settings = new JsonSerializerSettings { ContractResolver = new CamelCasePropertyNamesContractResolver() };
            var g = JsonConvert.SerializeObject(myVal, Formatting.None, settings);
            return g.Replace(@"\","");
        }
    }
}
