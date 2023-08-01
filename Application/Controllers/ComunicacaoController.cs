using Domain.DTO;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Application.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ComunicacaoController : ControllerBase
    {
        public ComunicacaoController()
        {
        }

        public static HttpClient ConsultaComunicacao()
        {
            try
            {
                HttpClient client = new HttpClient();
                var content = new StringContent(JsonConvert.SerializeObject(new ConsultarComunicaoDTO()), Encoding.UTF8, "application/json");

                var reponse = client.PutAsync("https://hcomunicaapi.cnj.jus.br/api/v1/comunicacao", content).Result;
                if (reponse.StatusCode == HttpStatusCode.OK)
                {
                    var token = reponse.Content.ReadAsStringAsync().Result;
                    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
                }
                return client;
            }
            catch
            {
                throw new Exception("Erro ao consultar a comunicação");
            }
        }
    }
}