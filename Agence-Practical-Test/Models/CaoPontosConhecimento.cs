using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Agence_Practical_Test.Models
{
    public partial class CaoPontosConhecimento
    {
        public int Idpontos { get; set; }
        public byte Pontuacao { get; set; }
        public string CoCoordenador { get; set; }
        public int Idconhecimento { get; set; }

        public virtual CaoUsuario CoCoordenadorNavigation { get; set; }
        public virtual CaoConhecimentos IdconhecimentoNavigation { get; set; }
        public virtual CaoEscalaRanking PontuacaoNavigation { get; set; }
    }
}
