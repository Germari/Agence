using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Agence_Practical_Test.Models
{
    public partial class CaoHistOcorrenciasOs
    {
        public int Idocorrencia { get; set; }
        public int? CoOs { get; set; }
        public string CoUsuario { get; set; }
        public string Tipo { get; set; }
        public string Descricao { get; set; }
        public string Responsavel { get; set; }
        public DateTime Data { get; set; }
        public DateTime DataFechamento { get; set; }
        public virtual CaoOs CoOsNavigation { get; set; }
        public virtual CaoUsuario CoUsuarioNavigation { get; set; }
    }
}
