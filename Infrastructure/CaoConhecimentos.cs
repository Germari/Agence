using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Agence_Practical_Test.Infrastructure
{
    public partial class CaoConhecimentos
    {
        public CaoConhecimentos()
        {
            CaoConhecimentosFontes = new HashSet<CaoConhecimentosFontes>();
            CaoPontosConhecimento = new HashSet<CaoPontosConhecimento>();
        }

        public int Idconhecimento { get; set; }
        public string Assunto { get; set; }
        public string Conhecimento { get; set; }
        public string Url { get; set; }
        public string Tags { get; set; }
        public string Usuario { get; set; }

        public virtual CaoUsuario UsuarioNavigation { get; set; }
        public virtual ICollection<CaoConhecimentosFontes> CaoConhecimentosFontes { get; set; }
        public virtual ICollection<CaoPontosConhecimento> CaoPontosConhecimento { get; set; }
        public DateTime Datahora { get; set; }
    }
}
