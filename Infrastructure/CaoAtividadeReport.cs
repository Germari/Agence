using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Agence_Practical_Test.Infrastructure
{
    public partial class CaoAtividadeReport
    {
        public int Id { get; set; }
        public int CoCliente { get; set; }
        public string Inicio { get; set; }
        public string Fim { get; set; }
        public string Lembrete { get; set; }
        public int CoAtividade { get; set; }
        public int CoOs { get; set; }
        public string Assunto { get; set; }
        public string Conteudo { get; set; }
        public string Status { get; set; }
        public string Tempo { get; set; }
        public string CoUsuario { get; set; }
        public string Retorno { get; set; }
        public int? CoFase { get; set; }
        public DateTime DataAtiv {get;set;}
    }
}
