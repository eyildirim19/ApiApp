using ApiApp.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace ApiApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaymentController : ControllerBase
    {
        List<string> cartNumbers = new List<string>();
        public PaymentController()
        {
            cartNumbers.Add("123456789");
            cartNumbers.Add("987654321");
        }

        [HttpPost]
        public IActionResult Post(PaymentInputModel model)
        {
            if (cartNumbers.Contains(model.CartNumber))
            {
                //ödeme işlemini al veritabanında iligi tablolara ilgili tutarı yaz...

                Random rnd = new Random();
                int orderNumber = rnd.Next(1000, int.MaxValue); // rasgele sayı üret..
                return Ok(orderNumber);
            }
            else
            {
                return Problem("Kart Bulunamadı");
            }
            // ödeme işlemi gerçekleşti...
        }
    }
}