using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Agence_Practical_Test.Infrastructure
{
    public partial class CaoFatura
    {
        public int CoFatura { get; set; }
        public int CoCliente { get; set; }
        public int CoSistema { get; set; }
        public int CoOs { get; set; }
        public int NumNf { get; set; }
        public float Total { get; set; }
        public float Valor { get; set; }
        public DateTime DataEmissao { get; set; }
        public string CorpoNf { get; set; }
        public float ComissaoCn { get; set; }
        public float TotalImpInc { get; set; }

        public static CaoFatura FromReader(MySqlDataReader reader)
        {
            return new CaoFatura()
            {
                CoCliente = int.Parse(reader["co_cliente"].ToString()),
                CoFatura=int.Parse(reader["co_fatura"].ToString()),
                CoSistema=int.Parse(reader["co_sistema"].ToString()),
                Valor=float.Parse(reader["valor"].ToString()),
                TotalImpInc=float.Parse(reader["total_imp_inc"].ToString()),
                DataEmissao=DateTime.Parse(reader["data_emissao"].ToString()),
                ComissaoCn=float.Parse(reader["comissao_cn"].ToString())
            };
        }
    }
}
