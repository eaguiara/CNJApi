using Application.DTO;
using Domain.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interface
{
    public class IDiarioOficial
    {
        public void GetComunicacao(ConsultarComunicaoDTO obj)
        {
            throw new NotImplementedException();
        }

        public void PostComunicacao(NovaComunicacaoDTO obj)
        {
            throw new NotImplementedException();
        }

        public void GetComunicacaoHash(ComunicacaoHashdto hash)
        {
            throw new NotImplementedException();
        }
    }
}