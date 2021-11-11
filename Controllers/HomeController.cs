using BankingApi.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankingApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HomeController : Controller


    {

        private BankContext _dbContext;
        public HomeController(BankContext dbContext)
        {
            _dbContext = dbContext;
        }


        //public IActionResult Index()
        //{
        //    return View();
        //}

        [HttpGet]
        public string Get(int accno,float amount)
        {

            var user = _dbContext.Banks.Where(x => x.ACC_NO == accno).FirstOrDefault();
            if (user == null)
              return "incorrect account number";
            

            
            

            if (user.Amount > amount)
                user.Amount -= amount;
            else
                return "Insufficient balance";
            
                     
           


            var vizcartAdmin = _dbContext.Banks.Where(x=>x.ACC_NO==100000001).FirstOrDefault();
            vizcartAdmin.Amount += amount;
            int i= _dbContext.SaveChanges();
            if (i == 2)
            {
                return "successful";

            }
            else
            {
                return "Failed";
            }
           

        }
    }
}







