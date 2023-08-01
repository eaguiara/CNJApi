using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.DTO
{
    public class ConsultarComunicaoDTO
    {
        [Required]
        [JsonProperty("numeroOab")]
        public string NumeroOab;

        [Required]
        [JsonProperty("ufOab")]
        public string UfOab;

        [Required]
        [JsonProperty("nomeAdvogado")]
        public string NomeAdvogado;

        [Required]
        [JsonProperty("nomeParte")]
        public string NomeParte;

        [Required]
        [JsonProperty("numeroProcesso")]
        public string NumeroProcesso;

        [Required]
        [JsonProperty("dataDisponibilizacaoInicio")]
        public string DataDisponibilizacaoInicio;

        [Required]
        [JsonProperty("dataDisponibilizacaoFim")]
        public string dataDisponibilizacaoFim;
    }
}