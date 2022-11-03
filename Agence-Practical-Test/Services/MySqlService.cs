using Agence_Practical_Test.DTO;
using Agence_Practical_Test.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace Agence_Practical_Test.Services
{
    public class MySqlService:IMySqlService
    {
            const string connectionString = "Server=localhost;Port=3306;Database=caol;Uid=root;";
        public async Task<List<CaoUsuario>> GetConsultores()
        {
            List<CaoUsuario> response = new List<CaoUsuario>();
            //MySqlConnection conexion = new MySqlConnection(connectionString);
            using (MySqlConnection conexion = new MySqlConnection(connectionString))
            {
                try
                {
                conexion.Open();
                    MySqlCommand cmd = new MySqlCommand();
                    cmd.Connection = conexion;
                    cmd.CommandText = @"select * from caol.cao_usuario cu inner join caol.permissao_sistema p  on cu.co_usuario =p.co_usuario where p.co_sistema =1 and p.in_ativo ='S' and (p.co_tipo_usuario =0 or p.co_tipo_usuario =1 or p.co_tipo_usuario =2)";
                   
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            response.Add(CaoUsuario.FromReader(reader));
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                conexion.Dispose();
            }
            return response;
        }
        public async Task<CaoUsuario> GetConsultor(string coUsuario)
        {
            CaoUsuario response= default;
            using (MySqlConnection conexion = new MySqlConnection(connectionString))
            {
                conexion.Open();
                try
                {
                    MySqlCommand cmd = new MySqlCommand();
                    cmd.Connection = conexion;
                    cmd.CommandText = @"select * from caol.cao_usuario cu inner join caol.permissao_sistema p  on cu.co_usuario =p.co_usuario where p.co_sistema =1 and p.in_ativo ='S' and (p.co_tipo_usuario =0 or p.co_tipo_usuario =1 or p.co_tipo_usuario =2) and co_usuario = ?coUsuario";
                    cmd.Parameters.Add("?coUsuario", MySqlDbType.VarChar).Value =coUsuario;
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            response=CaoUsuario.FromReader(reader);
                        }
                    }
                }
                catch (Exception ex)
                {
                    response = default;
                }
                conexion.Dispose();
            }
            return response;
        }
        public async Task<ConDesemConsultorRel> GetConDesemConsultorRel(string noUsuario, DateTime initialD, DateTime finalD)
        {
            var consultor = GetConsultorByNo(noUsuario);
            if (consultor == default)
                return default;
            var coUsuario = consultor.CoUsuario;

            var response = new ConDesemConsultorRel()
            {
                Name = consultor.NoUsuario,
                Values = GetConDesemConsultorRelValues(coUsuario,initialD,finalD),
                Saldo = new ConDesemConsultorRelSaldo()
                
            };
            response.Saldo.Comissao = response.Values.Sum(x => x.Comissao);
            response.Saldo.CustoFixo = response.Values.Sum(x => x.CustoFixo);
            response.Saldo.Lucro = response.Values.Sum(x => x.Lucro);
            response.Saldo.ReceitaLiquida = response.Values.Sum(x => x.ReceitaLiquida);
            return response;
        }

        public async Task<List<CaoCliente>> GetClientes()
        {
            List<CaoCliente> response = new List<CaoCliente>();
            //MySqlConnection conexion = new MySqlConnection(connectionString);
            using (MySqlConnection conexion = new MySqlConnection(connectionString))
            {
                try
                {
                    conexion.Open();
                    MySqlCommand cmd = new MySqlCommand();
                    cmd.Connection = conexion;
                    cmd.CommandText = @"select * from caol.cao_cliente";

                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            response.Add(CaoCliente.FromReader(reader));
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                conexion.Dispose();
            }
            return response;
        }

        private CaoUsuario GetConsultorByNo(string noUsuario)
        {
            CaoUsuario response = default;
            using (MySqlConnection conexion = new MySqlConnection(connectionString))
            {
                conexion.Open();
                try
                {
                    MySqlCommand cmd = new MySqlCommand();
                    cmd.Connection = conexion;
                    cmd.CommandText = @"select * from caol.cao_usuario cu inner join caol.permissao_sistema p  on cu.co_usuario =p.co_usuario where p.co_sistema =1 and p.in_ativo ='S' and (p.co_tipo_usuario =0 or p.co_tipo_usuario =1 or p.co_tipo_usuario =2) and no_usuario = ?noUsuario";
                    cmd.Parameters.Add("?noUsuario", MySqlDbType.VarChar).Value = noUsuario;
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            response = CaoUsuario.FromReader(reader);
                        }
                    }
                }
                catch (Exception ex)
                {
                    response = default;
                }
                conexion.Dispose();
            }
            return response;
        }

        private List<ConDesemConsultorValue> GetConDesemConsultorRelValues(string coUsuario, DateTime initialD, DateTime finalD)
        {
            List<ConDesemConsultorValue> response = new List<ConDesemConsultorValue>();
            List<CaoFatura> values = GetFacturesByCoUsuario(coUsuario,initialD,finalD);
            if (values == default)
                return response;

            values.GroupBy(v => v.DataEmissao.Month);
            foreach (var item in values.GroupBy(v => v.DataEmissao.Year))
            {
                foreach (var subitem in item.ToList().GroupBy(x=>x.DataEmissao.Month))
                {
                    response.Add(new ConDesemConsultorValue()
                    {
                        Periodo= new DateTime(item.Key, subitem.Key, 1).ToString("MMMM yyyy", new System.Globalization.CultureInfo("Pt-br")),
                        ReceitaLiquida=GetReceitaLiquida(subitem.ToList()),
                        CustoFixo=GetSalario(coUsuario),
                        Comissao=GetComissao(subitem.ToList()),
                        Lucro=0
                        
                    });
                }
            }
            return response;

        }

        private float GetComissao(List<CaoFatura> caoFaturas)
        {
            float response = 0;

            foreach (var item in caoFaturas)
            {
                response += (item.Valor - (item.Valor * item.TotalImpInc / 100))*item.ComissaoCn/100;
            }

            return response;
        }

        private float GetSalario(string coUsuario)
        {
            float response = 0;
            using (MySqlConnection conexion = new MySqlConnection(connectionString))
            {
                conexion.Open();
                try
                {
                    MySqlCommand cmd = new MySqlCommand();
                    cmd.Connection = conexion;
                    cmd.CommandText = @"select * from caol.cao_salario cs where cs.co_usuario =  ?coUsuario";
                    cmd.Parameters.Add("?coUsuario", MySqlDbType.VarChar).Value = coUsuario;
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            response = CaoSalario.FromReader(reader).BrutSalario;
                        }
                    }
                }
                catch (Exception ex)
                {
                    response = default;
                }
                conexion.Dispose();
            }
            return response;
        }

        private List<CaoFatura> GetFacturesByCoUsuario(string coUsuario, DateTime initialD, DateTime finalD)
        {
            List<CaoFatura> response = new List<CaoFatura>();
            using (MySqlConnection conexion = new MySqlConnection(connectionString))
            {
                conexion.Open();
                try
                {
                    MySqlCommand cmd = new MySqlCommand();
                    cmd.Connection = conexion;
                    cmd.CommandText = @"select * from caol.cao_fatura cf inner join caol.cao_sistema  cs  on cf.co_sistema=cs.co_sistema  where cs.co_usuario =  ?coUsuario and (cf.data_emissao >= ?initD and cf.data_emissao <= ?finalD )group by cf.data_emissao ";
                    cmd.Parameters.Add("?coUsuario", MySqlDbType.VarChar).Value = coUsuario;
                    cmd.Parameters.Add("?initD", MySqlDbType.DateTime).Value = initialD;
                    cmd.Parameters.Add("?finalD", MySqlDbType.DateTime).Value = finalD;
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            response.Add(CaoFatura.FromReader(reader));
                        }
                    }
                }
                catch (Exception ex)
                {
                    response = default;
                }
                conexion.Dispose();
            }
            return response;
        }

        private float GetReceitaLiquida(List<CaoFatura> caoFaturas)
        {
            float response = 0;
            foreach (var item in caoFaturas)
            {
                response += item.Valor - (item.Valor * item.TotalImpInc / 100);
            }
            return response;
        }
    }
}