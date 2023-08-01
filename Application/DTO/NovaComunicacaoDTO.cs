using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTO
{
    public class NovaComunicacaoDTO
    {
        // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
        public class Advogado
        {
            [JsonProperty("nome")]
            public string Nome;

            [JsonProperty("numero_oab")]
            public string NumeroOab;

            [JsonProperty("uf_oab")]
            public string UfOab;
        }

        public class Destinatario
        {
            [JsonProperty("nome")]
            public string Nome;

            [JsonProperty("cpf_cnpj")]
            public string CpfCnpj;

            [JsonProperty("polo")]
            public string Polo;
        }

        public class Root
        {
            [JsonProperty("codigo_classe")]
            public string CodigoClasse;

            [JsonProperty("numero_processo")]
            public string NumeroProcesso;

            [JsonProperty("sigla_tribunal")]
            public string SiglaTribunal;

            [JsonProperty("meio")]
            public string Meio;

            [JsonProperty("link")]
            public string Link;

            [JsonProperty("texto")]
            public string Texto;

            [JsonProperty("tipo_documento")]
            public string TipoDocumento;

            [JsonProperty("orgao")]
            public string Orgao;

            [JsonProperty("data_disponibilizacao")]
            public string DataDisponibilizacao;

            [JsonProperty("tipo_comunicacao")]
            public string TipoComunicacao;

            [JsonProperty("destinatarios")]
            public List<Destinatario> Destinatarios;

            [JsonProperty("advogados")]
            public List<Advogado> Advogados;
        }
    }
}