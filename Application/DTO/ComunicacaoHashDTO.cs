using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.DTO
{
    //duvida usar ou não usar por no ComunicacaoModel já tem uma propriedade hash
    public class ComunicacaoHashdto
    {
        [JsonProperty("hash")]
        public string Hash;
    }
}