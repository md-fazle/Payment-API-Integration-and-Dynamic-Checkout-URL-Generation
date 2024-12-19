using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Net.Http;
using System.Text;
using VU_Test.Models;
using System;

namespace VU_Test.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaymentController : Controller
    {
        private readonly HttpClient _httpClient;

        public PaymentController(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        [HttpPost]
        [Route("generated")]
        public IActionResult GenerateCheckoutUrl()
        {
             
            var paymentModel = PaymentModel.GeneratePaymentModel();

     
            var content = new StringContent(JsonConvert.SerializeObject(paymentModel), Encoding.UTF8, "application/json");

       
            var apiUrl = "https://bkashtest.shabox.mobi/home/MultiTournamentInBuildCheckoutUrl";
 
            _httpClient.DefaultRequestHeaders.Add("api-key", "796b8b9dbbf46b1d8fd73f68979ae31635da9afabc9dee147adf0440ee7118a8");

            try
            {
               
                var response = _httpClient.PostAsync(apiUrl, content).Result;

              
                if (response.IsSuccessStatusCode)
                {
                  
                    var responseContent = response.Content.ReadAsStringAsync().Result;
                    return Ok(new { PaymentUrl = responseContent });
                }
                else
                {
                
                    return StatusCode((int)response.StatusCode, "Error generating checkout URL");
                }
            }
            catch (Exception ex)
            {
             
                return StatusCode(500, $"Internal Server Error: {ex.Message}");
            }
        }
    }
}
