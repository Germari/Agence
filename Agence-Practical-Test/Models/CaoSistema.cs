using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Agence_Practical_Test.Models
{
    public partial class CaoSistema
    {
        public int CoSistema { get; set; }
        public int? CoCliente { get; set; }
        public string CoUsuario { get; set; }
        public int? CoArquitetura { get; set; }
        public string NoSistema { get; set; }
        public string DsSistemaResumo { get; set; }
        public string DsCaracteristica { get; set; }
        public string DsRequisito { get; set; }
        public string NoDiretoriaSolic { get; set; }
        public string DddTelefoneSolic { get; set; }
        public string NuTelefoneSolic { get; set; }
        public string NoUsuarioSolic { get; set; }
        public DateTime? DtSolicitacao { get; set; }
        public DateTime? DtEntrega { get; set; }
        public int? CoEmail { get; set; }
    }
}
