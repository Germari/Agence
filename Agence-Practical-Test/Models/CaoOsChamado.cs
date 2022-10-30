using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Agence_Practical_Test.Models
{
    public partial class CaoOsChamado
    {
        public int CoChamado { get; set; }
        public int CoSistema { get; set; }
        public int CoOs { get; set; }
        public string DsChamado { get; set; }
        public int CoTipo { get; set; }
        public int CoPrioridade { get; set; }
        public int CoItem { get; set; }
        public string Descricao { get; set; }
        public string DsSolucao { get; set; }
        public string Tempo { get; set; }
        public int Status { get; set; }
        public string CoUsuario { get; set; }
        public string CoAnalista { get; set; }
        public string Email { get; set; }
        public DateTime DtChamado { get; set; }
    }
}
