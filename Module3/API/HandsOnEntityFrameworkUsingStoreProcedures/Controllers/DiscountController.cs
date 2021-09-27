using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using HandsOnEntityFrameworkUsingStoreProcedures.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Data.SqlClient;

namespace HandsOnEntityFrameworkUsingStoreProcedures.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DiscountController : ControllerBase
    {
        [Route("Get/{cCode}")]
        public IActionResult Get(string cCode)
        {
            
            using(DiscountPricingContext db=new DiscountPricingContext())
            {
                //List<TblExclusions> list = db.TblExclusions.FromSqlRaw("prcSelExclusions @p0", new[] { cCode }).ToList();
                List<TblExclusions> list = db.TblExclusions.FromSqlRaw("prcSelExclusions @strContractCode", 
                    new[] {
                    new SqlParameter("@strContractCode", cCode),
                    //new SqlParameter("@",cCode) 
                    }).ToList();

                return Ok(list);
            }
        }
        [HttpPost]
        [Route("Add/{StrDrugNdc}/{StrContractCode}")]
        public IActionResult AddExculsions(string StrDrugNdc,string StrContractCode)
        {
           try
            {
                using (DiscountPricingContext db = new DiscountPricingContext())
                {
                    //db.Database.ExecuteSqlRaw("prcInsExclusions @p0,@p1",
                    //    new[] { StrDrugNdc, StrContractCode });
                    db.Database.ExecuteSqlRaw("prcInsExclusions @StrDrugNdc,@StrContractCode",
                        new[] { new SqlParameter("@StrDrugNdc",StrDrugNdc),
                                new SqlParameter("@StrContractCode",StrContractCode) 
                        });
                    return Ok("Record Added");
                }
            }
            catch(Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
        [HttpPut]
        [Route("Edit/{StrDrugNdc}/{StrContractCode}")]
        public IActionResult UpdateExculsions(string StrDrugNdc, string StrContractCode)
        {
            try
            {
                using (DiscountPricingContext db = new DiscountPricingContext())
                {
                    //db.Database.ExecuteSqlRaw("prcInsExclusions @p0,@p1",
                    //    new[] { StrDrugNdc, StrContractCode });
                    db.Database.ExecuteSqlRaw("prcUpdExclusions @StrDrugNdc,@StrContractCode",
                        new[] { new SqlParameter("@StrDrugNdc",StrDrugNdc),
                                new SqlParameter("@StrContractCode",StrContractCode)
                        });
                    return Ok("Record Updated");
                }
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
        [HttpDelete]
        [Route("Delete/{StrDrugNdc}/{StrContractCode}")]
        public IActionResult RemoveExculsions(string StrDrugNdc, string StrContractCode)
        {
            try
            {
                using (DiscountPricingContext db = new DiscountPricingContext())
                {
                    //db.Database.ExecuteSqlRaw("prcInsExclusions @p0,@p1",
                    //    new[] { StrDrugNdc, StrContractCode });
                    db.Database.ExecuteSqlRaw("prcDelExclusions @StrDrugNdc,@StrContractCode",
                        new[] { new SqlParameter("@StrDrugNdc",StrDrugNdc),
                                new SqlParameter("@StrContractCode",StrContractCode)
                        });
                    return Ok("Record Deleted");
                }
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
    }
}
