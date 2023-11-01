using Dapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Data.SqlClient;

namespace AllTech.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class TalabaController : ControllerBase
    {
        private string connectionString = WebApplication.CreateBuilder().Configuration.GetConnectionString("DefaultConnectionString");
        [HttpGet]
        public IActionResult GetAllUsers()
        {
            using (var connection = new SqlConnection(connectionString))
            {
                var result=connection.Query<>
            }
        }
    }
}
