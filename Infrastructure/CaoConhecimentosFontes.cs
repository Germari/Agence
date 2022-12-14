using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Agence_Practical_Test.Infrastructure
{
    public partial class CaoConhecimentosFontes
    {
        public int Idfonte { get; set; }
        public int Idconhecimento { get; set; }
        public string Arquivo { get; set; }
        public string Caminho { get; set; }
        public DateTime Datahora { get; set; }
        public virtual CaoConhecimentos IdconhecimentoNavigation { get; set; }
    }
}
