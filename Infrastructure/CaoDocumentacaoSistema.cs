using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Agence_Practical_Test.Infrastructure
{
    public partial class CaoDocumentacaoSistema
    {
        public int Id { get; set; }
        public int CoSistema { get; set; }
        public string Descricao { get; set; }
        public string Pasta { get; set; }
        public int? SubGrupo { get; set; }
        public string CoUsuario { get; set; }
        public string Arquivo { get; set; }
        public DateTime DtDoc { get; set; }
    }
}
