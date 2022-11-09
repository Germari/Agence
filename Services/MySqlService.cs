using Agence_Practical_Test.Infrastructure;
using Agence_Practical_Test.Models;
using Microsoft.Extensions.Configuration;
using MySql.Data.MySqlClient;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Agence_Practical_Test.Services
{
    public class MySqlService:IMySqlService
    {
        private readonly string connectionString;
        public MySqlService(IConfiguration config)
        {
            connectionString = config.GetValue<string>("ConnectionStrings:DefaultConnection");
        }
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
                    cmd.CommandText = @"select * from cao_usuario cu inner join permissao_sistema p  on cu.co_usuario =p.co_usuario where p.co_sistema =1 and p.in_ativo ='S' and (p.co_tipo_usuario =0 or p.co_tipo_usuario =1 or p.co_tipo_usuario =2)";

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
            CaoUsuario response = default;
            using (MySqlConnection conexion = new MySqlConnection(connectionString))
            {
                conexion.Open();
                try
                {
                    MySqlCommand cmd = new MySqlCommand();
                    cmd.Connection = conexion;
                    cmd.CommandText = @"select * from cao_usuario cu inner join permissao_sistema p  on cu.co_usuario =p.co_usuario where p.co_sistema =1 and p.in_ativo ='S' and (p.co_tipo_usuario =0 or p.co_tipo_usuario =1 or p.co_tipo_usuario =2) and co_usuario = ?coUsuario";
                    cmd.Parameters.Add("?coUsuario", MySqlDbType.VarChar).Value = coUsuario;
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
        public async Task<ConDesemConsultorRel> GetConDesemConsultorRel(string noUsuario, DateTime initialD, DateTime finalD)
        {
            var client = new RestClient("https://webhook.site/4ac0dd1e-0b8f-42da-aaf9-d44aa828f06d");
            var request = new RestRequest(Method.Post.ToString());
            var body = JsonConvert.SerializeObject(new { Method = "GetConDesemConsultorRel in mysqlservice" });
            request.AddParameter("application/json", body, ParameterType.RequestBody);
            RestResponse resp = client.Execute(request);

            var consultor = GetConsultorByNo(noUsuario);

            var client1 = new RestClient("https://webhook.site/4ac0dd1e-0b8f-42da-aaf9-d44aa828f06d");
            var request1 = new RestRequest(Method.Post.ToString());
            var body1 = JsonConvert.SerializeObject(new { consultor });
            request1.AddParameter("application/json", body1, ParameterType.RequestBody);
            RestResponse resp1 = client1.Execute(request1);

            if (consultor == default)
                return default;
            var coUsuario = consultor.CoUsuario;

            var response = new ConDesemConsultorRel()
            {
                Name = consultor.NoUsuario,
                Values = GetConDesemConsultorRelValues(coUsuario, initialD, finalD),
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
                    cmd.CommandText = @"select * from cao_cliente";

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
                    cmd.CommandText = @"select * from cao_usuario cu inner join permissao_sistema p  on cu.co_usuario =p.co_usuario where p.co_sistema =1 and p.in_ativo ='S' and (p.co_tipo_usuario =0 or p.co_tipo_usuario =1 or p.co_tipo_usuario =2) and no_usuario = ?noUsuario";
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
                    var client = new RestClient("https://webhook.site/4ac0dd1e-0b8f-42da-aaf9-d44aa828f06d");
                    var request = new RestRequest(Method.Post.ToString());
                    var body = JsonConvert.SerializeObject(new { ex});
                    request.AddParameter("application/json", body, ParameterType.RequestBody);
                    RestResponse resp = client.Execute(request);

                    response = default;
                }
                conexion.Dispose();
            }
            var client1 = new RestClient("https://webhook.site/4ac0dd1e-0b8f-42da-aaf9-d44aa828f06d");
            var request1 = new RestRequest(Method.Post.ToString());
            var body1 = JsonConvert.SerializeObject(new { response });
            request1.AddParameter("application/json", body1, ParameterType.RequestBody);
            RestResponse resp1 = client1.Execute(request1);
            return response;
        }

        private List<ConDesemConsultorValue> GetConDesemConsultorRelValues(string coUsuario, DateTime initialD, DateTime finalD)
        {
            var client = new RestClient("https://webhook.site/4ac0dd1e-0b8f-42da-aaf9-d44aa828f06d");
            var request = new RestRequest(Method.Post.ToString());
            var body = JsonConvert.SerializeObject(" GetConDesemConsultorRelValues" );
            request.AddParameter("application/json", body, ParameterType.RequestBody);
            RestResponse respons = client.Execute(request);

            var client1 = new RestClient("https://webhook.site/4ac0dd1e-0b8f-42da-aaf9-d44aa828f06d");
            var request1 = new RestRequest(Method.Post.ToString());
            var body1 = JsonConvert.SerializeObject(new { connectionString,initialD,finalD});
            request.AddParameter("application/json", body1, ParameterType.RequestBody);
            RestResponse respons1 = client.Execute(request1);

            List<ConDesemConsultorValue> response = new List<ConDesemConsultorValue>();
            List<CaoFatura> values = GetFacturesByCoUsuario(coUsuario, initialD, finalD);
            if (values == default)
                return response;

            var clientv = new RestClient("https://webhook.site/4ac0dd1e-0b8f-42da-aaf9-d44aa828f06d");
            var requestv = new RestRequest(Method.Post.ToString());
            var bodyv = JsonConvert.SerializeObject(values);
            request.AddParameter("application/json", bodyv, ParameterType.RequestBody);
            RestResponse responsv = client.Execute(requestv);

            var clientvv = new RestClient("https://webhook.site/4ac0dd1e-0b8f-42da-aaf9-d44aa828f06d");
            var requestvv = new RestRequest(Method.Post.ToString());
            var bodyvv = "lo anterior fue values";
            request.AddParameter("application/json", bodyvv, ParameterType.RequestBody);
            RestResponse responsvv = client.Execute(requestvv);

            values.GroupBy(v => v.DataEmissao.Month);
            foreach (var item in values.GroupBy(v => v.DataEmissao.Year))
            {
                foreach (var subitem in item.ToList().GroupBy(x => x.DataEmissao.Month))
                {
                    response.Add(new ConDesemConsultorValue()
                    {
                        Periodo = new DateTime(item.Key, subitem.Key, 1).ToString("MMMM yyyy", new System.Globalization.CultureInfo("Pt-br")),
                        ReceitaLiquida = GetReceitaLiquida(subitem.ToList()),
                        CustoFixo = GetSalario(coUsuario),
                        Comissao = GetComissao(subitem.ToList()),
                        Lucro = 0

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
                response += (item.Valor - (item.Valor * item.TotalImpInc / 100)) * item.ComissaoCn / 100;
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
                    cmd.CommandText = @"select * from cao_salario cs where cs.co_usuario =  ?coUsuario";
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
            var client = new RestClient("https://webhook.site/4ac0dd1e-0b8f-42da-aaf9-d44aa828f06d");
            var request = new RestRequest(Method.Post.ToString());
            var body = "GetFacturesByCoUsuario";
            request.AddParameter("application/json", body, ParameterType.RequestBody);
            RestResponse respons = client.Execute(request);

            List<CaoFatura> response = new List<CaoFatura>();
            using (MySqlConnection conexion = new MySqlConnection(connectionString))
            {
                conexion.Open();
                try
                {
                    MySqlCommand cmd = new MySqlCommand();
                    cmd.Connection = conexion;
                    cmd.CommandText = @"select * from cao_fatura cf inner join cao_sistema  cs  on cf.co_sistema=cs.co_sistema  where cs.co_usuario =  ?coUsuario and (cf.data_emissao >= ?initD and cf.data_emissao <= ?finalD )group by cf.data_emissao ";
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
                    var client1 = new RestClient("https://webhook.site/4ac0dd1e-0b8f-42da-aaf9-d44aa828f06d");
                    var request1 = new RestRequest(Method.Post.ToString());
                    var body1 = JsonConvert.SerializeObject(ex);
                    request1.AddParameter("application/json", body1, ParameterType.RequestBody);
                    RestResponse respons1 = client1.Execute(request1);

                    response = default;
                }
                conexion.Dispose();
            }
            var client2 = new RestClient("https://webhook.site/4ac0dd1e-0b8f-42da-aaf9-d44aa828f06d");
            var request2 = new RestRequest(Method.Post.ToString());
            var body2 = JsonConvert.SerializeObject(response);
            request2.AddParameter("application/json", body2, ParameterType.RequestBody);
            RestResponse respons2 = client2.Execute(request2);
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
