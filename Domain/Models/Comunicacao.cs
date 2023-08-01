using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    public class Advogado
    {
        [JsonProperty("id")]
        public int Id;

        [JsonProperty("nome")]
        public string Nome;

        [JsonProperty("numero_oab")]
        public string NumeroOab;

        [JsonProperty("uf_oab")]
        public string UfOab;

        [JsonProperty("tipo_inscricao")]
        public string TipoInscricao;

        [JsonProperty("email")]
        public string Email;
    }

    public class Destinatario
    {
        [JsonProperty("nome")]
        public string Nome;

        [JsonProperty("polo")]
        public string Polo;

        [JsonProperty("cpf_cnpj")]
        public string CpfCnpj;

        [JsonProperty("comunicacao_id")]
        public int ComunicacaoId;
    }

    public class Destinatarioadvogado
    {
        [JsonProperty("id")]
        public int Id;

        [JsonProperty("comunicacao_id")]
        public int ComunicacaoId;

        [JsonProperty("advogado_id")]
        public int AdvogadoId;

        [JsonProperty("created_at")]
        public string CreatedAt;

        [JsonProperty("updated_at")]
        public string UpdatedAt;

        [JsonProperty("advogado")]
        public Advogado Advogado;
    }

    public class Item
    {
        [JsonProperty("tribunal_id")]
        public int TribunalId;

        [JsonProperty("classe_id")]
        public int ClasseId;

        [JsonProperty("tipo_documento_id")]
        public int TipoDocumentoId;

        [JsonProperty("orgao_id")]
        public int OrgaoId;

        [JsonProperty("tipo_id")]
        public int TipoId;

        [JsonProperty("id")]
        public int Id;

        [JsonProperty("data_publicacao")]
        public string DataPublicacao;

        [JsonProperty("texto")]
        public string Texto;

        [JsonProperty("numero_processo")]
        public string NumeroProcesso;

        [JsonProperty("meio")]
        public string Meio;

        [JsonProperty("link")]
        public string Link;

        [JsonProperty("numero_comunicacao")]
        public int NumeroComunicacao;

        [JsonProperty("ativo")]
        public bool Ativo;

        [JsonProperty("hash")]
        public string Hash;

        [JsonProperty("meiocompleto")]
        public string Meiocompleto;

        [JsonProperty("numeroprocessocommascara")]
        public string Numeroprocessocommascara;

        [JsonProperty("destinatarios")]
        public List<Destinatario> Destinatarios;

        [JsonProperty("destinatarioadvogados")]
        public List<Destinatarioadvogado> Destinatarioadvogados;
    }

    public class Root
    {
        [JsonProperty("status")]
        public string Status;

        [JsonProperty("message")]
        public string Message;

        [JsonProperty("items")]
        public List<Item> Items;
    }
}