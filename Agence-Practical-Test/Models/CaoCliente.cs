using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Agence_Practical_Test.Models
{
    public partial class CaoCliente
    {
        public int CoCliente { get; set; }
        public string NoRazao { get; set; }
        public string NoFantasia { get; set; }
        public string NoContato { get; set; }
        public string NuTelefone { get; set; }
        public string NuRamal { get; set; }
        public string NuCnpj { get; set; }
        public string DsEndereco { get; set; }
        public int? NuNumero { get; set; }
        public string DsComplemento { get; set; }
        public string NoBairro { get; set; }
        public string NuCep { get; set; }
        public string NoPais { get; set; }
        public long? CoRamo { get; set; }
        public long CoCidade { get; set; }
        public int? CoStatus { get; set; }
        public string DsSite { get; set; }
        public string DsEmail { get; set; }
        public string DsCargoContato { get; set; }
        public string TpCliente { get; set; }
        public string DsReferencia { get; set; }
        public int? CoComplementoStatus { get; set; }
        public string NuFax { get; set; }
        public string Ddd2 { get; set; }
        public string Telefone2 { get; set; }
    }
}
