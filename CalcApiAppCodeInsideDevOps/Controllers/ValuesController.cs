using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CalcApiAppCodeInsideDevOps.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        // GET: api/<ValuesController>
        [HttpGet("/average")]
        public int Average([FromQueryAttribute]int[]nums)
        {
                int tot = 0;
                foreach (var num in nums)
                {
                    tot += num;

                }
                return tot / nums.Count();

        }
        [HttpGet("/smallest")]
        public int Smallest([FromQueryAttribute] int[] nums)
        {
            int smallest = nums[0];

            foreach (var num in nums)
            {

                if (num < smallest)
                {
                    smallest = num;
                }

            }

            return smallest;
        }
        [HttpGet("/largest")]
        public int Largest([FromQueryAttribute] int[] nums)
        {

            int largest = nums[0];

            foreach (var num in nums)
            {

                if (num > largest)
                {
                    largest = num;
                }

            }

            return largest;
        }
    }

        
    
}
