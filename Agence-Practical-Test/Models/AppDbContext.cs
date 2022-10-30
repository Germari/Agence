using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Agence_Practical_Test.Models
{
    public partial class AppDbContext : DbContext
    {
        public AppDbContext()
        {
        }

        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<CaoAcompanhamentoSistema> CaoAcompanhamentoSistema { get; set; }
        public virtual DbSet<CaoAgendamento> CaoAgendamento { get; set; }
        public virtual DbSet<CaoArquiteturaOs> CaoArquiteturaOs { get; set; }
        public virtual DbSet<CaoAtividade> CaoAtividade { get; set; }
        public virtual DbSet<CaoAtividadeConsultor> CaoAtividadeConsultor { get; set; }
        public virtual DbSet<CaoAtividadeReport> CaoAtividadeReport { get; set; }
        public virtual DbSet<CaoAtividadeTeste> CaoAtividadeTeste { get; set; }
        public virtual DbSet<CaoAviso> CaoAviso { get; set; }
        public virtual DbSet<CaoBancoDeHoras> CaoBancoDeHoras { get; set; }
        public virtual DbSet<CaoBancoHoras> CaoBancoHoras { get; set; }
        public virtual DbSet<CaoBoleto> CaoBoleto { get; set; }
        public virtual DbSet<CaoBonus> CaoBonus { get; set; }
        public virtual DbSet<CaoBonusStatus> CaoBonusStatus { get; set; }
        public virtual DbSet<CaoCategoriasOmbudsman> CaoCategoriasOmbudsman { get; set; }
        public virtual DbSet<CaoCidade> CaoCidade { get; set; }
        public virtual DbSet<CaoCliente> CaoCliente { get; set; }
        public virtual DbSet<CaoClienteContato> CaoClienteContato { get; set; }
        public virtual DbSet<CaoComissao> CaoComissao { get; set; }
        public virtual DbSet<CaoComplemento> CaoComplemento { get; set; }
        public virtual DbSet<CaoConhecimentoUsuario> CaoConhecimentoUsuario { get; set; }
        public virtual DbSet<CaoConhecimentos> CaoConhecimentos { get; set; }
        public virtual DbSet<CaoConhecimentosFontes> CaoConhecimentosFontes { get; set; }
        public virtual DbSet<CaoCusto> CaoCusto { get; set; }
        public virtual DbSet<CaoDiaryReport> CaoDiaryReport { get; set; }
        public virtual DbSet<CaoDiaryReportConsultor> CaoDiaryReportConsultor { get; set; }
        public virtual DbSet<CaoDocumentacaoCasosUso> CaoDocumentacaoCasosUso { get; set; }
        public virtual DbSet<CaoDocumentacaoOutros> CaoDocumentacaoOutros { get; set; }
        public virtual DbSet<CaoDocumentacaoSistema> CaoDocumentacaoSistema { get; set; }
        public virtual DbSet<CaoDrAtivComp> CaoDrAtivComp { get; set; }
        public virtual DbSet<CaoEscalaRanking> CaoEscalaRanking { get; set; }
        public virtual DbSet<CaoEscritorio> CaoEscritorio { get; set; }
        public virtual DbSet<CaoFatura> CaoFatura { get; set; }
        public virtual DbSet<CaoFaturaPag> CaoFaturaPag { get; set; }
        public virtual DbSet<CaoFeriados> CaoFeriados { get; set; }
        public virtual DbSet<CaoFormacaoIdiomaUsuario> CaoFormacaoIdiomaUsuario { get; set; }
        public virtual DbSet<CaoFormacaoUsuario> CaoFormacaoUsuario { get; set; }
        public virtual DbSet<CaoHelpAutor> CaoHelpAutor { get; set; }
        public virtual DbSet<CaoHelpChamado> CaoHelpChamado { get; set; }
        public virtual DbSet<CaoHelpFilial> CaoHelpFilial { get; set; }
        public virtual DbSet<CaoHelpMotivoChamado> CaoHelpMotivoChamado { get; set; }
        public virtual DbSet<CaoHelpStatusChamado> CaoHelpStatusChamado { get; set; }
        public virtual DbSet<CaoHelpTelaChamado> CaoHelpTelaChamado { get; set; }
        public virtual DbSet<CaoHistOcorrenciasOs> CaoHistOcorrenciasOs { get; set; }
        public virtual DbSet<CaoHorarioAlmoco> CaoHorarioAlmoco { get; set; }
        public virtual DbSet<CaoLogChamado> CaoLogChamado { get; set; }
        public virtual DbSet<CaoMenu> CaoMenu { get; set; }
        public virtual DbSet<CaoMenuContador> CaoMenuContador { get; set; }
        public virtual DbSet<CaoMovimento> CaoMovimento { get; set; }
        public virtual DbSet<CaoMovimentoJustificativa> CaoMovimentoJustificativa { get; set; }
        public virtual DbSet<CaoMovimentoOs> CaoMovimentoOs { get; set; }
        public virtual DbSet<CaoNoticia> CaoNoticia { get; set; }
        public virtual DbSet<CaoObsCliente> CaoObsCliente { get; set; }
        public virtual DbSet<CaoObsSistema> CaoObsSistema { get; set; }
        public virtual DbSet<CaoOmbudsman> CaoOmbudsman { get; set; }
        public virtual DbSet<CaoOs> CaoOs { get; set; }
        public virtual DbSet<CaoOsAnalista> CaoOsAnalista { get; set; }
        public virtual DbSet<CaoOsChamado> CaoOsChamado { get; set; }
        public virtual DbSet<CaoOsDailyReport> CaoOsDailyReport { get; set; }
        public virtual DbSet<CaoOsEmail> CaoOsEmail { get; set; }
        public virtual DbSet<CaoOsFase> CaoOsFase { get; set; }
        public virtual DbSet<CaoOsItemMenu> CaoOsItemMenu { get; set; }
        public virtual DbSet<CaoOsObs> CaoOsObs { get; set; }
        public virtual DbSet<CaoOsObsChamado> CaoOsObsChamado { get; set; }
        public virtual DbSet<CaoOsPrazo> CaoOsPrazo { get; set; }
        public virtual DbSet<CaoOsStatus> CaoOsStatus { get; set; }
        public virtual DbSet<CaoPagamento> CaoPagamento { get; set; }
        public virtual DbSet<CaoParticipacaoFuncionario> CaoParticipacaoFuncionario { get; set; }
        public virtual DbSet<CaoPermissao> CaoPermissao { get; set; }
        public virtual DbSet<CaoPermissaoHoraExtra> CaoPermissaoHoraExtra { get; set; }
        public virtual DbSet<CaoPontosConhecimento> CaoPontosConhecimento { get; set; }
        public virtual DbSet<CaoRamo> CaoRamo { get; set; }
        public virtual DbSet<CaoRelEmailOs> CaoRelEmailOs { get; set; }
        public virtual DbSet<CaoSalario> CaoSalario { get; set; }
        public virtual DbSet<CaoSalarioPag> CaoSalarioPag { get; set; }
        public virtual DbSet<CaoServico> CaoServico { get; set; }
        public virtual DbSet<CaoSistema> CaoSistema { get; set; }
        public virtual DbSet<CaoSistemaObs> CaoSistemaObs { get; set; }
        public virtual DbSet<CaoStatusAgendamento> CaoStatusAgendamento { get; set; }
        public virtual DbSet<CaoStatusCliente> CaoStatusCliente { get; set; }
        public virtual DbSet<CaoStatusClienteComplemento> CaoStatusClienteComplemento { get; set; }
        public virtual DbSet<CaoStatusOs> CaoStatusOs { get; set; }
        public virtual DbSet<CaoTempImport> CaoTempImport { get; set; }
        public virtual DbSet<CaoTipoConhecimentoUsuario> CaoTipoConhecimentoUsuario { get; set; }
        public virtual DbSet<CaoTipoCusto> CaoTipoCusto { get; set; }
        public virtual DbSet<CaoTipoIdiomaUsuario> CaoTipoIdiomaUsuario { get; set; }
        public virtual DbSet<CaoTipoOmbudsman> CaoTipoOmbudsman { get; set; }
        public virtual DbSet<CaoTipoSistemaUsuario> CaoTipoSistemaUsuario { get; set; }
        public virtual DbSet<CaoUf> CaoUf { get; set; }
        public virtual DbSet<CaoUsuario> CaoUsuario { get; set; }
        public virtual DbSet<CaoUsuarioDtDisp> CaoUsuarioDtDisp { get; set; }
        public virtual DbSet<CaoValorDescanso> CaoValorDescanso { get; set; }
        public virtual DbSet<PermissaoSistema> PermissaoSistema { get; set; }
        public virtual DbSet<TipoUsuario> TipoUsuario { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseMySQL("database=caol;server=localhost;port=3306;user id=root;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CaoAcompanhamentoSistema>(entity =>
            {
                entity.HasKey(e => e.CoAcompanhamento)
                    .HasName("PRIMARY");

                entity.ToTable("cao_acompanhamento_sistema");

                entity.Property(e => e.CoAcompanhamento)
                    .HasColumnName("co_acompanhamento")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.CoSistema)
                    .HasColumnName("co_sistema")
                    .HasColumnType("bigint(20)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasMaxLength(40);

                entity.Property(e => e.Senha)
                    .HasColumnName("senha")
                    .HasMaxLength(20);

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasMaxLength(2)
                    .IsFixedLength();
            });

            modelBuilder.Entity<CaoAgendamento>(entity =>
            {
                entity.HasKey(e => e.CoAgendamento)
                    .HasName("PRIMARY");

                entity.ToTable("cao_agendamento");

                entity.Property(e => e.CoAgendamento)
                    .HasColumnName("co_agendamento")
                    .HasColumnType("bigint(10) unsigned");

                entity.Property(e => e.CoComplemento)
                    .HasColumnName("co_complemento")
                    .HasColumnType("bigint(10)");

                entity.Property(e => e.CoDiaryReportConsultor)
                    .HasColumnName("co_diary_report_consultor")
                    .HasColumnType("bigint(10)");

                entity.Property(e => e.CoStatusAgendamento)
                    .HasColumnName("co_status_agendamento")
                    .HasColumnType("bigint(10)");
            });

            modelBuilder.Entity<CaoArquiteturaOs>(entity =>
            {
                entity.HasKey(e => e.CoArquitetura)
                    .HasName("PRIMARY");

                entity.ToTable("cao_arquitetura_os");

                entity.Property(e => e.CoArquitetura)
                    .HasColumnName("co_arquitetura")
                    .HasColumnType("bigint(10)");

                entity.Property(e => e.DsArquitetura)
                    .IsRequired()
                    .HasColumnName("ds_arquitetura")
                    .HasMaxLength(20)
                    .HasDefaultValueSql("''");
            });

            modelBuilder.Entity<CaoAtividade>(entity =>
            {
                entity.HasKey(e => e.CoAtividade)
                    .HasName("PRIMARY");

                entity.ToTable("cao_atividade");

                entity.Property(e => e.CoAtividade)
                    .HasColumnName("co_atividade")
                    .HasColumnType("int(4)");

                entity.Property(e => e.CoTipoUsuario)
                    .HasColumnName("co_tipo_usuario")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.DsAtividade)
                    .IsRequired()
                    .HasColumnName("ds_atividade")
                    .HasMaxLength(30)
                    .HasDefaultValueSql("''");
            });

            modelBuilder.Entity<CaoAtividadeConsultor>(entity =>
            {
                entity.HasKey(e => e.CoAtividade)
                    .HasName("PRIMARY");

                entity.ToTable("cao_atividade_consultor");

                entity.Property(e => e.CoAtividade)
                    .HasColumnName("co_atividade")
                    .HasColumnType("int(20)");

                entity.Property(e => e.Ativo)
                    .HasColumnName("ativo")
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.DsAtividade)
                    .IsRequired()
                    .HasColumnName("ds_atividade")
                    .HasMaxLength(50)
                    .HasDefaultValueSql("''");
            });

            modelBuilder.Entity<CaoAtividadeReport>(entity =>
            {
                entity.ToTable("cao_atividade_report");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(20)");

                entity.Property(e => e.Assunto)
                    .HasColumnName("assunto")
                    .HasMaxLength(120);

                entity.Property(e => e.CoAtividade)
                    .HasColumnName("co_atividade")
                    .HasColumnType("int(20)");

                entity.Property(e => e.CoCliente)
                    .HasColumnName("co_cliente")
                    .HasColumnType("int(20)");

                entity.Property(e => e.CoFase)
                    .HasColumnName("co_fase")
                    .HasColumnType("int(2)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.CoOs)
                    .HasColumnName("co_os")
                    .HasColumnType("int(20)");

                entity.Property(e => e.CoUsuario)
                    .IsRequired()
                    .HasColumnName("co_usuario")
                    .HasMaxLength(50)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Conteudo).HasColumnName("conteudo");

                entity.Property(e => e.Fim)
                    .HasColumnName("fim")
                    .HasMaxLength(30);

                entity.Property(e => e.Inicio)
                    .HasColumnName("inicio")
                    .HasMaxLength(30);

                entity.Property(e => e.Lembrete)
                    .HasColumnName("lembrete")
                    .HasMaxLength(50);

                entity.Property(e => e.Retorno)
                    .IsRequired()
                    .HasColumnName("retorno");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasMaxLength(20)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Tempo)
                    .HasColumnName("tempo")
                    .HasMaxLength(30);
            });

            modelBuilder.Entity<CaoAtividadeTeste>(entity =>
            {
                entity.HasKey(e => e.CoAtividade)
                    .HasName("PRIMARY");

                entity.ToTable("cao_atividade_teste");

                entity.Property(e => e.CoAtividade)
                    .HasColumnName("co_atividade")
                    .HasColumnType("int(4)");

                entity.Property(e => e.CoTipoUsuario)
                    .HasColumnName("co_tipo_usuario")
                    .HasColumnType("bigint(10)");

                entity.Property(e => e.DsAtividade)
                    .IsRequired()
                    .HasColumnName("ds_atividade")
                    .HasMaxLength(30)
                    .HasDefaultValueSql("''");
            });

            modelBuilder.Entity<CaoAviso>(entity =>
            {
                entity.HasKey(e => e.CoAviso)
                    .HasName("PRIMARY");

                entity.ToTable("cao_aviso");

                entity.Property(e => e.CoAviso)
                    .HasColumnName("co_aviso")
                    .HasColumnType("int(11) unsigned");

                entity.Property(e => e.DsAviso)
                    .IsRequired()
                    .HasColumnName("ds_aviso");
            });

            modelBuilder.Entity<CaoBancoDeHoras>(entity =>
            {
                entity.ToTable("cao_banco_de_horas");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(128)");

                entity.Property(e => e.CoUsuario)
                    .IsRequired()
                    .HasColumnName("co_usuario")
                    .HasMaxLength(255)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.DataCadastro)
                    .HasColumnName("data_cadastro")
                    .HasColumnType("date")
                    .HasDefaultValueSql("'0000-00-00'");

                entity.Property(e => e.Segundos)
                    .HasColumnName("segundos")
                    .HasColumnType("int(255)");

                entity.Property(e => e.Tipo)
                    .IsRequired()
                    .HasColumnName("tipo")
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");
            });

            modelBuilder.Entity<CaoBancoHoras>(entity =>
            {
                entity.HasKey(e => e.CoBancHoras)
                    .HasName("PRIMARY");

                entity.ToTable("cao_banco_horas");

                entity.HasComment("Banco de horas dos usuÃ¡rios...");

                entity.Property(e => e.CoBancHoras)
                    .HasColumnName("co_banc_horas")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.CoUsuario)
                    .IsRequired()
                    .HasColumnName("co_usuario")
                    .HasMaxLength(20)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.MinFerias)
                    .HasColumnName("min_ferias")
                    .HasColumnType("int(11)");

                entity.Property(e => e.MinMes)
                    .HasColumnName("min_mes")
                    .HasColumnType("int(11)");

                entity.Property(e => e.MinPago)
                    .HasColumnName("min_pago")
                    .HasColumnType("int(11)");

                entity.Property(e => e.MinTotal)
                    .HasColumnName("min_total")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Periodo)
                    .IsRequired()
                    .HasColumnName("periodo")
                    .HasMaxLength(7)
                    .HasDefaultValueSql("''");
            });

            modelBuilder.Entity<CaoBoleto>(entity =>
            {
                entity.HasKey(e => e.CoBoleto)
                    .HasName("PRIMARY");

                entity.ToTable("cao_boleto");

                entity.Property(e => e.CoBoleto)
                    .HasColumnName("co_boleto")
                    .HasColumnType("int(128)");

                entity.Property(e => e.Boleto)
                    .HasColumnName("boleto")
                    .HasMaxLength(255);

                entity.Property(e => e.CoCliente)
                    .HasColumnName("co_cliente")
                    .HasColumnType("int(128)");

                entity.Property(e => e.CoOs)
                    .HasColumnName("co_os")
                    .HasColumnType("int(128)");

                entity.Property(e => e.CoSistema)
                    .HasColumnName("co_sistema")
                    .HasColumnType("int(128)");

                entity.Property(e => e.LinhaDig)
                    .HasColumnName("linha_dig")
                    .HasMaxLength(255);

                entity.Property(e => e.Parcela)
                    .HasColumnName("parcela")
                    .HasMaxLength(20);

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasColumnType("int(128)");

                entity.Property(e => e.Valor)
                    .IsRequired()
                    .HasColumnName("valor")
                    .HasMaxLength(128)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Vencimento)
                    .IsRequired()
                    .HasColumnName("vencimento")
                    .HasMaxLength(128)
                    .HasDefaultValueSql("''");
            });

            modelBuilder.Entity<CaoBonus>(entity =>
            {
                entity.HasKey(e => new { e.BonCategoria, e.BonInicio, e.BonFim })
                    .HasName("PRIMARY");

                entity.ToTable("cao_bonus");

                entity.Property(e => e.BonCategoria)
                    .HasColumnName("bon_categoria")
                    .HasColumnType("int(3)");

                entity.Property(e => e.BonInicio)
                    .HasColumnName("bon_inicio")
                    .HasColumnType("int(3)");

                entity.Property(e => e.BonFim)
                    .HasColumnName("bon_fim")
                    .HasColumnType("int(3)");

                entity.Property(e => e.BonValorFimsem).HasColumnName("bon_valor_fimsem");

                entity.Property(e => e.BonValorSem).HasColumnName("bon_valor_sem");
            });

            modelBuilder.Entity<CaoBonusStatus>(entity =>
            {
                entity.ToTable("cao_bonus_status");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(128)");

                entity.Property(e => e.CoUsuario)
                    .IsRequired()
                    .HasColumnName("co_usuario")
                    .HasMaxLength(128)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.DataSolic)
                    .HasColumnName("data_solic")
                    .HasColumnType("date")
                    .HasDefaultValueSql("'0000-00-00'");

                entity.Property(e => e.IsHoras)
                    .HasColumnName("is_horas")
                    .HasMaxLength(10);

                entity.Property(e => e.IsPg)
                    .HasColumnName("is_pg")
                    .HasMaxLength(10);

                entity.Property(e => e.IsSolic)
                    .HasColumnName("is_solic")
                    .HasMaxLength(10);

                entity.Property(e => e.Mes)
                    .IsRequired()
                    .HasColumnName("mes")
                    .HasMaxLength(128)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Valor)
                    .IsRequired()
                    .HasColumnName("valor")
                    .HasMaxLength(128)
                    .HasDefaultValueSql("''");
            });

            modelBuilder.Entity<CaoCategoriasOmbudsman>(entity =>
            {
                entity.HasKey(e => e.Idcategoria)
                    .HasName("PRIMARY");

                entity.ToTable("cao_categorias_ombudsman");

                entity.Property(e => e.Idcategoria)
                    .HasColumnName("idcategoria")
                    .HasColumnType("tinyint(4)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Descricao)
                    .IsRequired()
                    .HasColumnName("descricao")
                    .HasMaxLength(100)
                    .HasDefaultValueSql("''");
            });

            modelBuilder.Entity<CaoCidade>(entity =>
            {
                entity.HasKey(e => e.CoCidade)
                    .HasName("PRIMARY");

                entity.ToTable("cao_cidade");

                entity.Property(e => e.CoCidade)
                    .HasColumnName("co_cidade")
                    .HasColumnType("bigint(10) unsigned");

                entity.Property(e => e.CoUf)
                    .HasColumnName("co_uf")
                    .HasColumnType("bigint(10)");

                entity.Property(e => e.NoCidade)
                    .IsRequired()
                    .HasColumnName("no_cidade")
                    .HasMaxLength(30)
                    .HasDefaultValueSql("''");
            });

            modelBuilder.Entity<CaoCliente>(entity =>
            {
                entity.HasKey(e => e.CoCliente)
                    .HasName("PRIMARY");

                entity.ToTable("cao_cliente");

                entity.Property(e => e.CoCliente)
                    .HasColumnName("co_cliente")
                    .HasColumnType("int(11) unsigned");

                entity.Property(e => e.CoCidade)
                    .HasColumnName("co_cidade")
                    .HasColumnType("bigint(10)");

                entity.Property(e => e.CoComplementoStatus)
                    .HasColumnName("co_complemento_status")
                    .HasColumnType("int(11) unsigned");

                entity.Property(e => e.CoRamo)
                    .HasColumnName("co_ramo")
                    .HasColumnType("bigint(10)");

                entity.Property(e => e.CoStatus)
                    .HasColumnName("co_status")
                    .HasColumnType("int(11) unsigned");

                entity.Property(e => e.Ddd2)
                    .HasColumnName("ddd2")
                    .HasMaxLength(10);

                entity.Property(e => e.DsCargoContato)
                    .HasColumnName("ds_cargo_contato")
                    .HasMaxLength(50);

                entity.Property(e => e.DsComplemento)
                    .HasColumnName("ds_complemento")
                    .HasMaxLength(150);

                entity.Property(e => e.DsEmail)
                    .HasColumnName("ds_email")
                    .HasMaxLength(50);

                entity.Property(e => e.DsEndereco)
                    .HasColumnName("ds_endereco")
                    .HasMaxLength(150);

                entity.Property(e => e.DsReferencia)
                    .HasColumnName("ds_referencia")
                    .HasMaxLength(100);

                entity.Property(e => e.DsSite)
                    .HasColumnName("ds_site")
                    .HasMaxLength(50);

                entity.Property(e => e.NoBairro)
                    .IsRequired()
                    .HasColumnName("no_bairro")
                    .HasMaxLength(50)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.NoContato)
                    .HasColumnName("no_contato")
                    .HasMaxLength(30);

                entity.Property(e => e.NoFantasia)
                    .HasColumnName("no_fantasia")
                    .HasMaxLength(50);

                entity.Property(e => e.NoPais)
                    .HasColumnName("no_pais")
                    .HasMaxLength(50);

                entity.Property(e => e.NoRazao)
                    .HasColumnName("no_razao")
                    .HasMaxLength(50);

                entity.Property(e => e.NuCep)
                    .HasColumnName("nu_cep")
                    .HasMaxLength(10);

                entity.Property(e => e.NuCnpj)
                    .HasColumnName("nu_cnpj")
                    .HasMaxLength(18);

                entity.Property(e => e.NuFax)
                    .HasColumnName("nu_fax")
                    .HasMaxLength(15);

                entity.Property(e => e.NuNumero)
                    .HasColumnName("nu_numero")
                    .HasColumnType("int(6)");

                entity.Property(e => e.NuRamal)
                    .HasColumnName("nu_ramal")
                    .HasMaxLength(6);

                entity.Property(e => e.NuTelefone)
                    .HasColumnName("nu_telefone")
                    .HasMaxLength(15);

                entity.Property(e => e.Telefone2)
                    .HasColumnName("telefone2")
                    .HasMaxLength(20);

                entity.Property(e => e.TpCliente)
                    .HasColumnName("tp_cliente")
                    .HasMaxLength(2)
                    .IsFixedLength();
            });

            modelBuilder.Entity<CaoClienteContato>(entity =>
            {
                entity.HasKey(e => e.CoCliente)
                    .HasName("PRIMARY");

                entity.ToTable("cao_cliente_contato");

                entity.Property(e => e.CoCliente)
                    .HasColumnName("co_cliente")
                    .HasColumnType("int(11) unsigned");

                entity.Property(e => e.DtContato)
                    .HasColumnName("dt_contato")
                    .HasColumnType("date")
                    .HasDefaultValueSql("'0000-00-00'");

                entity.Property(e => e.FgAgendado)
                    .HasColumnName("fg_agendado")
                    .HasColumnType("int(1) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.HrEnd)
                    .HasColumnName("hr_end")
                    .HasDefaultValueSql("'00:00:00'");

                entity.Property(e => e.HrIni)
                    .HasColumnName("hr_ini")
                    .HasDefaultValueSql("'00:00:00'");
            });

            modelBuilder.Entity<CaoComissao>(entity =>
            {
                entity.HasKey(e => e.CoComissao)
                    .HasName("PRIMARY");

                entity.ToTable("cao_comissao");

                entity.HasIndex(e => e.CoFatura)
                    .HasName("co_fatura")
                    .IsUnique();

                entity.Property(e => e.CoComissao)
                    .HasColumnName("co_comissao")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CoFatura)
                    .HasColumnName("co_fatura")
                    .HasColumnType("int(11)");

                entity.Property(e => e.DtEfetuado)
                    .HasColumnName("dt_efetuado")
                    .HasColumnType("date")
                    .HasDefaultValueSql("'0000-00-00'");
            });

            modelBuilder.Entity<CaoComplemento>(entity =>
            {
                entity.HasKey(e => e.CoComplemento)
                    .HasName("PRIMARY");

                entity.ToTable("cao_complemento");

                entity.HasComment("DescriÃ§Ã£o da Visita");

                entity.Property(e => e.CoComplemento)
                    .HasColumnName("co_complemento")
                    .HasColumnType("bigint(10) unsigned");

                entity.Property(e => e.DsComplemento)
                    .HasColumnName("ds_complemento")
                    .HasColumnType("longtext");
            });

            modelBuilder.Entity<CaoConhecimentoUsuario>(entity =>
            {
                entity.HasKey(e => new { e.CoUsuario, e.CoConhecimento })
                    .HasName("PRIMARY");

                entity.ToTable("cao_conhecimento_usuario");

                entity.Property(e => e.CoUsuario)
                    .HasColumnName("co_usuario")
                    .HasMaxLength(20)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.CoConhecimento)
                    .HasColumnName("co_conhecimento")
                    .HasColumnType("int(1) unsigned");

                entity.Property(e => e.IsCertificado)
                    .HasColumnName("is_certificado")
                    .HasColumnType("tinyint(1) unsigned");

                entity.Property(e => e.NvConhecimento)
                    .HasColumnName("nv_conhecimento")
                    .HasColumnType("int(1) unsigned");
            });

            modelBuilder.Entity<CaoConhecimentos>(entity =>
            {
                entity.HasKey(e => e.Idconhecimento)
                    .HasName("PRIMARY");

                entity.ToTable("cao_conhecimentos");

                entity.HasIndex(e => e.Usuario)
                    .HasName("usuario");

                entity.Property(e => e.Idconhecimento)
                    .HasColumnName("idconhecimento")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Assunto)
                    .IsRequired()
                    .HasColumnName("assunto")
                    .HasMaxLength(100)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Conhecimento)
                    .IsRequired()
                    .HasColumnName("conhecimento");

                entity.Property(e => e.Tags)
                    .IsRequired()
                    .HasColumnName("tags");

                entity.Property(e => e.Url)
                    .IsRequired()
                    .HasColumnName("url")
                    .HasColumnType("tinytext");

                entity.Property(e => e.Usuario)
                    .IsRequired()
                    .HasColumnName("usuario")
                    .HasMaxLength(20)
                    .HasDefaultValueSql("''");

                entity.HasOne(d => d.UsuarioNavigation)
                    .WithMany(p => p.CaoConhecimentos)
                    .HasForeignKey(d => d.Usuario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("cao_conhecimentos_ibfk_1");
            });

            modelBuilder.Entity<CaoConhecimentosFontes>(entity =>
            {
                entity.HasKey(e => e.Idfonte)
                    .HasName("PRIMARY");

                entity.ToTable("cao_conhecimentos_fontes");

                entity.HasIndex(e => e.Idconhecimento)
                    .HasName("idconhecimento");

                entity.Property(e => e.Idfonte)
                    .HasColumnName("idfonte")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Arquivo)
                    .IsRequired()
                    .HasColumnName("arquivo")
                    .HasMaxLength(50)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Caminho)
                    .IsRequired()
                    .HasColumnName("caminho")
                    .HasMaxLength(50)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Idconhecimento)
                    .HasColumnName("idconhecimento")
                    .HasColumnType("int(11)");

                entity.HasOne(d => d.IdconhecimentoNavigation)
                    .WithMany(p => p.CaoConhecimentosFontes)
                    .HasForeignKey(d => d.Idconhecimento)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("cao_conhecimentos_fontes_ibfk_1");
            });

            modelBuilder.Entity<CaoCusto>(entity =>
            {
                entity.HasKey(e => e.CoCusto)
                    .HasName("PRIMARY");

                entity.ToTable("cao_custo");

                entity.Property(e => e.CoCusto)
                    .HasColumnName("co_custo")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.CoBoleto).HasColumnName("co_boleto");

                entity.Property(e => e.CoCustoHigh)
                    .HasColumnName("co_custo_high")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.CoEscritorio)
                    .HasColumnName("co_escritorio")
                    .HasColumnType("tinyint(3)");

                entity.Property(e => e.CoTipoCusto)
                    .HasColumnName("co_tipo_custo")
                    .HasColumnType("tinyint(3)");

                entity.Property(e => e.Descricao)
                    .IsRequired()
                    .HasColumnName("descricao")
                    .HasMaxLength(100)
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.DtCompra)
                    .HasColumnName("dt_compra")
                    .HasColumnType("date");

                entity.Property(e => e.DtPagamento)
                    .HasColumnName("dt_pagamento")
                    .HasColumnType("date");

                entity.Property(e => e.Pag).HasColumnName("pag");

                entity.Property(e => e.Parcela)
                    .HasColumnName("parcela")
                    .HasMaxLength(5);

                entity.Property(e => e.Valor).HasColumnName("valor");
            });

            modelBuilder.Entity<CaoDiaryReport>(entity =>
            {
                entity.HasKey(e => e.CoDiaryReport)
                    .HasName("PRIMARY");

                entity.ToTable("cao_diary_report");

                entity.Property(e => e.CoDiaryReport)
                    .HasColumnName("co_diary_report")
                    .HasColumnType("int(10)");

                entity.Property(e => e.CoAtividade)
                    .HasColumnName("co_atividade")
                    .HasColumnType("int(4)");

                entity.Property(e => e.CoMovimento)
                    .HasColumnName("co_movimento")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.CoSistema)
                    .HasColumnName("co_sistema")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.DsAssunto)
                    .IsRequired()
                    .HasColumnName("ds_assunto")
                    .HasColumnType("longtext");

                entity.Property(e => e.HrGasta)
                    .HasColumnName("hr_gasta")
                    .HasDefaultValueSql("'00:00:00'");

                entity.Property(e => e.NuOs)
                    .HasColumnName("nu_os")
                    .HasColumnType("bigint(20) unsigned");
            });

            modelBuilder.Entity<CaoDiaryReportConsultor>(entity =>
            {
                entity.HasKey(e => e.CoDiaryReportConsultor)
                    .HasName("PRIMARY");

                entity.ToTable("cao_diary_report_consultor");

                entity.HasComment("contem informacoes referentes a agendamento, visita, elabora");

                entity.Property(e => e.CoDiaryReportConsultor)
                    .HasColumnName("co_diary_report_consultor")
                    .HasColumnType("int(5)");

                entity.Property(e => e.CoAtividade)
                    .HasColumnName("co_atividade")
                    .HasColumnType("int(5)");

                entity.Property(e => e.CoCliente)
                    .HasColumnName("co_cliente")
                    .HasColumnType("bigint(10)");

                entity.Property(e => e.CoMovimento)
                    .HasColumnName("co_movimento")
                    .HasColumnType("int(5)");

                entity.Property(e => e.DsAssunto)
                    .IsRequired()
                    .HasColumnName("ds_assunto")
                    .HasColumnType("mediumtext");

                entity.Property(e => e.DsEmpresa)
                    .IsRequired()
                    .HasColumnName("ds_empresa")
                    .HasColumnType("mediumtext");
            });

            modelBuilder.Entity<CaoDocumentacaoCasosUso>(entity =>
            {
                entity.ToTable("cao_documentacao_casos_uso");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(20)");

                entity.Property(e => e.CoSistema)
                    .HasColumnName("co_sistema")
                    .HasColumnType("int(30)");

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasColumnName("nome")
                    .HasMaxLength(70)
                    .HasDefaultValueSql("''");
            });

            modelBuilder.Entity<CaoDocumentacaoOutros>(entity =>
            {
                entity.ToTable("cao_documentacao_outros");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(20)");

                entity.Property(e => e.CoSistema)
                    .HasColumnName("co_sistema")
                    .HasColumnType("int(30)");

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasColumnName("nome")
                    .HasMaxLength(70)
                    .HasDefaultValueSql("''");
            });

            modelBuilder.Entity<CaoDocumentacaoSistema>(entity =>
            {
                entity.ToTable("cao_documentacao_sistema");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(20)");

                entity.Property(e => e.Arquivo)
                    .IsRequired()
                    .HasColumnName("arquivo")
                    .HasMaxLength(100)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.CoSistema)
                    .HasColumnName("co_sistema")
                    .HasColumnType("int(20)");

                entity.Property(e => e.CoUsuario)
                    .IsRequired()
                    .HasColumnName("co_usuario")
                    .HasMaxLength(60)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Descricao).HasColumnName("descricao");

                entity.Property(e => e.Pasta)
                    .IsRequired()
                    .HasColumnName("pasta")
                    .HasMaxLength(30)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.SubGrupo)
                    .HasColumnName("sub_grupo")
                    .HasColumnType("int(20)");
            });

            modelBuilder.Entity<CaoDrAtivComp>(entity =>
            {
                entity.HasKey(e => e.IdAtivComp)
                    .HasName("PRIMARY");

                entity.ToTable("cao_dr_ativ_comp");

                entity.HasIndex(e => e.CoUsuario)
                    .HasName("co_usuario");

                entity.Property(e => e.IdAtivComp)
                    .HasColumnName("id_ativ_comp")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Assunto)
                    .IsRequired()
                    .HasColumnName("assunto");

                entity.Property(e => e.CoUsuario)
                    .IsRequired()
                    .HasColumnName("co_usuario")
                    .HasMaxLength(20)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Data)
                    .HasColumnName("data")
                    .HasColumnType("date")
                    .HasDefaultValueSql("'0000-00-00'");

                entity.Property(e => e.TempoGasto)
                    .HasColumnName("tempo_gasto")
                    .HasDefaultValueSql("'00:00:00'");
            });

            modelBuilder.Entity<CaoEscalaRanking>(entity =>
            {
                entity.HasKey(e => e.Idescala)
                    .HasName("PRIMARY");

                entity.ToTable("cao_escala_ranking");

                entity.Property(e => e.Idescala)
                    .HasColumnName("idescala")
                    .HasColumnType("tinyint(4)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Pontuacao)
                    .HasColumnName("pontuacao")
                    .HasColumnType("int(11)");

                entity.Property(e => e.QtdVisual)
                    .HasColumnName("qtd_visual")
                    .HasColumnType("tinyint(4)");
            });

            modelBuilder.Entity<CaoEscritorio>(entity =>
            {
                entity.HasKey(e => e.CoEscritorio)
                    .HasName("PRIMARY");

                entity.ToTable("cao_escritorio");

                entity.Property(e => e.CoEscritorio)
                    .HasColumnName("co_escritorio")
                    .HasColumnType("tinyint(3) unsigned")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Local)
                    .IsRequired()
                    .HasColumnName("local")
                    .HasMaxLength(2)
                    .IsFixedLength()
                    .HasDefaultValueSql("''");
            });

            modelBuilder.Entity<CaoFatura>(entity =>
            {
                entity.HasKey(e => e.CoFatura)
                    .HasName("PRIMARY");

                entity.ToTable("cao_fatura");

                entity.Property(e => e.CoFatura)
                    .HasColumnName("co_fatura")
                    .HasColumnType("int(8) unsigned");

                entity.Property(e => e.CoCliente)
                    .HasColumnName("co_cliente")
                    .HasColumnType("int(8)");

                entity.Property(e => e.CoOs)
                    .HasColumnName("co_os")
                    .HasColumnType("int(8)");

                entity.Property(e => e.CoSistema)
                    .HasColumnName("co_sistema")
                    .HasColumnType("int(8)");

                entity.Property(e => e.ComissaoCn).HasColumnName("comissao_cn");

                entity.Property(e => e.CorpoNf)
                    .IsRequired()
                    .HasColumnName("corpo_nf");

                entity.Property(e => e.DataEmissao)
                    .HasColumnName("data_emissao")
                    .HasColumnType("date")
                    .HasDefaultValueSql("'0000-00-00'");

                entity.Property(e => e.NumNf)
                    .HasColumnName("num_nf")
                    .HasColumnType("int(10)");

                entity.Property(e => e.Total).HasColumnName("total");

                entity.Property(e => e.TotalImpInc).HasColumnName("total_imp_inc");

                entity.Property(e => e.Valor).HasColumnName("valor");
            });

            modelBuilder.Entity<CaoFaturaPag>(entity =>
            {
                entity.HasKey(e => e.IdFaturaPag)
                    .HasName("PRIMARY");

                entity.ToTable("cao_fatura_pag");

                entity.HasIndex(e => e.CoFatura)
                    .HasName("co_fatura")
                    .IsUnique();

                entity.Property(e => e.IdFaturaPag)
                    .HasColumnName("id_fatura_pag")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CoFatura)
                    .HasColumnName("co_fatura")
                    .HasColumnType("int(11)");

                entity.Property(e => e.DtEfetuado)
                    .HasColumnName("dt_efetuado")
                    .HasColumnType("date")
                    .HasDefaultValueSql("'0000-00-00'");

                entity.Property(e => e.ValorPago).HasColumnName("valor_pago");
            });

            modelBuilder.Entity<CaoFeriados>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("cao_feriados");

                entity.Property(e => e.Ano)
                    .HasColumnName("ano")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Dia)
                    .HasColumnName("dia")
                    .HasColumnType("tinyint(2) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Mes)
                    .HasColumnName("mes")
                    .HasColumnType("tinyint(2) unsigned")
                    .HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<CaoFormacaoIdiomaUsuario>(entity =>
            {
                entity.HasKey(e => new { e.CoUsuario, e.CoIdioma })
                    .HasName("PRIMARY");

                entity.ToTable("cao_formacao_idioma_usuario");

                entity.Property(e => e.CoUsuario)
                    .HasColumnName("co_usuario")
                    .HasMaxLength(20)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.CoIdioma)
                    .HasColumnName("co_idioma")
                    .HasColumnType("int(1)");

                entity.Property(e => e.NvEscrita)
                    .HasColumnName("nv_escrita")
                    .HasColumnType("int(1)");

                entity.Property(e => e.NvFala)
                    .HasColumnName("nv_fala")
                    .HasColumnType("int(1)");

                entity.Property(e => e.NvLeitura)
                    .HasColumnName("nv_leitura")
                    .HasColumnType("int(1)");
            });

            modelBuilder.Entity<CaoFormacaoUsuario>(entity =>
            {
                entity.HasKey(e => new { e.CoUsuario, e.TpCurso })
                    .HasName("PRIMARY");

                entity.ToTable("cao_formacao_usuario");

                entity.Property(e => e.CoUsuario)
                    .HasColumnName("co_usuario")
                    .HasMaxLength(20)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.TpCurso)
                    .HasColumnName("tp_curso")
                    .HasMaxLength(13)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.DsCurso)
                    .HasColumnName("ds_curso")
                    .HasMaxLength(50);

                entity.Property(e => e.DsInstituicao)
                    .HasColumnName("ds_instituicao")
                    .HasMaxLength(50);

                entity.Property(e => e.DtConclusao)
                    .HasColumnName("dt_conclusao")
                    .HasColumnType("date");
            });

            modelBuilder.Entity<CaoHelpAutor>(entity =>
            {
                entity.HasKey(e => e.CoAutor)
                    .HasName("PRIMARY");

                entity.ToTable("cao_help_autor");

                entity.HasIndex(e => e.CoAutor)
                    .HasName("co_autor");

                entity.Property(e => e.CoAutor)
                    .HasColumnName("co_autor")
                    .HasColumnType("int(6)");

                entity.Property(e => e.CoFilial)
                    .HasColumnName("co_filial")
                    .HasColumnType("int(4)");

                entity.Property(e => e.DsEmail)
                    .HasColumnName("ds_email")
                    .HasMaxLength(50);

                entity.Property(e => e.DsFuncao)
                    .IsRequired()
                    .HasColumnName("ds_funcao")
                    .HasMaxLength(100)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.NoAutor)
                    .IsRequired()
                    .HasColumnName("no_autor")
                    .HasMaxLength(80)
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.NuDdd1)
                    .HasColumnName("nu_ddd1")
                    .HasMaxLength(4);

                entity.Property(e => e.NuDdd2)
                    .HasColumnName("nu_ddd2")
                    .HasMaxLength(4);

                entity.Property(e => e.NuRamal1)
                    .HasColumnName("nu_ramal1")
                    .HasMaxLength(6);

                entity.Property(e => e.NuRamal2)
                    .HasColumnName("nu_ramal2")
                    .HasMaxLength(6);

                entity.Property(e => e.NuTel1)
                    .HasColumnName("nu_tel1")
                    .HasMaxLength(15);

                entity.Property(e => e.NuTel2)
                    .HasColumnName("nu_tel2")
                    .HasMaxLength(15);
            });

            modelBuilder.Entity<CaoHelpChamado>(entity =>
            {
                entity.HasKey(e => e.CoChamado)
                    .HasName("PRIMARY");

                entity.ToTable("cao_help_chamado");

                entity.HasIndex(e => e.CoChamado)
                    .HasName("co_chamado");

                entity.Property(e => e.CoChamado)
                    .HasColumnName("co_chamado")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CoAutor)
                    .HasColumnName("co_autor")
                    .HasColumnType("int(6)");

                entity.Property(e => e.CoFilial)
                    .HasColumnName("co_filial")
                    .HasColumnType("int(3)");

                entity.Property(e => e.CoMotivo)
                    .HasColumnName("co_motivo")
                    .HasColumnType("int(2)");

                entity.Property(e => e.CoSistema)
                    .HasColumnName("co_sistema")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.CoStatus)
                    .HasColumnName("co_status")
                    .HasColumnType("tinyint(4)");

                entity.Property(e => e.CoTela)
                    .HasColumnName("co_tela")
                    .HasColumnType("int(2)");

                entity.Property(e => e.DsChamado)
                    .IsRequired()
                    .HasColumnName("ds_chamado");

                entity.Property(e => e.DsSolucao).HasColumnName("ds_solucao");

                entity.Property(e => e.DtChamado)
                    .HasColumnName("dt_chamado")
                    .HasColumnType("date")
                    .HasDefaultValueSql("'0000-00-00'");

                entity.Property(e => e.DtSolucao)
                    .HasColumnName("dt_solucao")
                    .HasColumnType("date");
            });

            modelBuilder.Entity<CaoHelpFilial>(entity =>
            {
                entity.HasKey(e => e.CoFilial)
                    .HasName("PRIMARY");

                entity.ToTable("cao_help_filial");

                entity.HasIndex(e => e.CoFilial)
                    .HasName("filialId");

                entity.Property(e => e.CoFilial)
                    .HasColumnName("co_filial")
                    .HasColumnType("int(4) unsigned");

                entity.Property(e => e.CoCliente)
                    .HasColumnName("co_cliente")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Estado)
                    .IsRequired()
                    .HasColumnName("estado")
                    .HasMaxLength(2)
                    .IsFixedLength()
                    .HasDefaultValueSql("''");

                entity.Property(e => e.NoFilial)
                    .IsRequired()
                    .HasColumnName("no_filial")
                    .HasMaxLength(70)
                    .HasDefaultValueSql("''");
            });

            modelBuilder.Entity<CaoHelpMotivoChamado>(entity =>
            {
                entity.HasKey(e => e.CoMotivo)
                    .HasName("PRIMARY");

                entity.ToTable("cao_help_motivo_chamado");

                entity.HasIndex(e => e.CoMotivo)
                    .HasName("co_motivo_2");

                entity.Property(e => e.CoMotivo)
                    .HasColumnName("co_motivo")
                    .HasColumnType("int(3)");

                entity.Property(e => e.DsMotivo)
                    .IsRequired()
                    .HasColumnName("ds_motivo")
                    .HasMaxLength(70)
                    .HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<CaoHelpStatusChamado>(entity =>
            {
                entity.HasKey(e => e.CoStatus)
                    .HasName("PRIMARY");

                entity.ToTable("cao_help_status_chamado");

                entity.HasIndex(e => e.CoStatus)
                    .HasName("co_status_2");

                entity.Property(e => e.CoStatus)
                    .HasColumnName("co_status")
                    .HasColumnType("int(3)");

                entity.Property(e => e.DsStatus)
                    .IsRequired()
                    .HasColumnName("ds_status")
                    .HasMaxLength(50)
                    .HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<CaoHelpTelaChamado>(entity =>
            {
                entity.HasKey(e => e.CoTela)
                    .HasName("PRIMARY");

                entity.ToTable("cao_help_tela_chamado");

                entity.Property(e => e.CoTela)
                    .HasColumnName("co_tela")
                    .HasColumnType("int(2)");

                entity.Property(e => e.CoCliente)
                    .HasColumnName("co_cliente")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CoSistema)
                    .HasColumnName("co_sistema")
                    .HasColumnType("int(11)");

                entity.Property(e => e.DsTela)
                    .IsRequired()
                    .HasColumnName("ds_tela")
                    .HasMaxLength(200)
                    .HasDefaultValueSql("''");
            });

            modelBuilder.Entity<CaoHistOcorrenciasOs>(entity =>
            {
                entity.HasKey(e => e.Idocorrencia)
                    .HasName("PRIMARY");

                entity.ToTable("cao_hist_ocorrencias_os");

                entity.HasIndex(e => e.CoOs)
                    .HasName("co_os");

                entity.HasIndex(e => e.CoUsuario)
                    .HasName("co_usuario");

                entity.Property(e => e.Idocorrencia)
                    .HasColumnName("idocorrencia")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CoOs)
                    .HasColumnName("co_os")
                    .HasColumnType("int(8)");

                entity.Property(e => e.CoUsuario)
                    .HasColumnName("co_usuario")
                    .HasMaxLength(20);

                entity.Property(e => e.Descricao)
                    .IsRequired()
                    .HasColumnName("descricao");

                entity.Property(e => e.Responsavel)
                    .IsRequired()
                    .HasColumnName("responsavel")
                    .HasMaxLength(50)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Tipo)
                    .IsRequired()
                    .HasColumnName("tipo")
                    .HasColumnType("enum('Interna','Externa')")
                    .HasDefaultValueSql("'Interna'");

                entity.HasOne(d => d.CoOsNavigation)
                    .WithMany(p => p.CaoHistOcorrenciasOs)
                    .HasForeignKey(d => d.CoOs)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("cao_hist_ocorrencias_os_ibfk_2");

                entity.HasOne(d => d.CoUsuarioNavigation)
                    .WithMany(p => p.CaoHistOcorrenciasOs)
                    .HasForeignKey(d => d.CoUsuario)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("cao_hist_ocorrencias_os_ibfk_1");
            });

            modelBuilder.Entity<CaoHorarioAlmoco>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("cao_horario_almoco");

                entity.Property(e => e.AlmocoSaidaHora)
                    .IsRequired()
                    .HasColumnName("almoco_saida_hora")
                    .HasMaxLength(128)
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.AlmocoVoltaHora)
                    .IsRequired()
                    .HasColumnName("almoco_volta_hora")
                    .HasMaxLength(128)
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.CoUsuario)
                    .IsRequired()
                    .HasColumnName("co_usuario")
                    .HasMaxLength(255)
                    .HasDefaultValueSql("''");
            });

            modelBuilder.Entity<CaoLogChamado>(entity =>
            {
                entity.ToTable("cao_log_chamado");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CoChamado)
                    .HasColumnName("co_chamado")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CoDaily)
                    .HasColumnName("co_daily")
                    .HasColumnType("int(20)");

                entity.Property(e => e.CoUsuario)
                    .IsRequired()
                    .HasColumnName("co_usuario")
                    .HasMaxLength(128)
                    .HasDefaultValueSql("''");
            });

            modelBuilder.Entity<CaoMenu>(entity =>
            {
                entity.HasKey(e => e.CoMenu)
                    .HasName("PRIMARY");

                entity.ToTable("cao_menu");

                entity.Property(e => e.CoMenu)
                    .HasColumnName("co_menu")
                    .HasColumnType("tinyint(3) unsigned")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.DsImagem)
                    .HasColumnName("ds_imagem")
                    .HasMaxLength(255);

                entity.Property(e => e.DsMenu)
                    .IsRequired()
                    .HasColumnName("ds_menu")
                    .HasMaxLength(255)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.DsPagina)
                    .IsRequired()
                    .HasColumnName("ds_pagina")
                    .HasMaxLength(255)
                    .HasDefaultValueSql("''");
            });

            modelBuilder.Entity<CaoMenuContador>(entity =>
            {
                entity.HasKey(e => new { e.CoUsuario, e.CoMenu })
                    .HasName("PRIMARY");

                entity.ToTable("cao_menu_contador");

                entity.Property(e => e.CoUsuario)
                    .HasColumnName("co_usuario")
                    .HasMaxLength(20)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.CoMenu)
                    .HasColumnName("co_menu")
                    .HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.InProcessado)
                    .HasColumnName("in_processado")
                    .HasColumnType("tinyint(1) unsigned");

                entity.Property(e => e.NuPontos)
                    .HasColumnName("nu_pontos")
                    .HasColumnType("tinyint(3)");
            });

            modelBuilder.Entity<CaoMovimento>(entity =>
            {
                entity.HasKey(e => e.CoMovimento)
                    .HasName("PRIMARY");

                entity.ToTable("cao_movimento");

                entity.HasIndex(e => e.CoMovimento)
                    .HasName("co_movimento");

                entity.Property(e => e.CoMovimento)
                    .HasColumnName("co_movimento")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.CoUsuario)
                    .IsRequired()
                    .HasColumnName("co_usuario")
                    .HasMaxLength(50)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.IsEncerrado)
                    .HasColumnName("is_encerrado")
                    .HasColumnType("tinyint(1) unsigned");
            });

            modelBuilder.Entity<CaoMovimentoJustificativa>(entity =>
            {
                entity.HasKey(e => e.CoMovimentoJustificativa)
                    .HasName("PRIMARY");

                entity.ToTable("cao_movimento_justificativa");

                entity.HasIndex(e => e.CoMovimentoJustificativa)
                    .HasName("co_movimento_justificativa");

                entity.Property(e => e.CoMovimentoJustificativa)
                    .HasColumnName("co_movimento_justificativa")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.CoMovimento)
                    .HasColumnName("co_movimento")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.DsJustificativa)
                    .IsRequired()
                    .HasColumnName("ds_justificativa")
                    .HasColumnType("longtext");

                entity.Property(e => e.NuOs)
                    .HasColumnName("nu_os")
                    .HasColumnType("bigint(20) unsigned");
            });

            modelBuilder.Entity<CaoMovimentoOs>(entity =>
            {
                entity.HasKey(e => e.CoMovimentoOs)
                    .HasName("PRIMARY");

                entity.ToTable("cao_movimento_os");

                entity.Property(e => e.CoMovimentoOs)
                    .HasColumnName("co_movimento_os")
                    .HasColumnType("int(5)");

                entity.Property(e => e.CoSistema)
                    .HasColumnName("co_sistema")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.CoTipoMovimento)
                    .HasColumnName("co_tipo_movimento")
                    .HasColumnType("bigint(10)");

                entity.Property(e => e.DsValor)
                    .HasColumnName("ds_valor")
                    .HasColumnType("longtext");

                entity.Property(e => e.NuOs)
                    .HasColumnName("nu_os")
                    .HasColumnType("int(6)");

                entity.Property(e => e.NuValor)
                    .HasColumnName("nu_valor")
                    .HasColumnType("bigint(10)");

                entity.Property(e => e.UsuarioObs)
                    .HasColumnName("usuario_obs")
                    .HasMaxLength(30);
            });

            modelBuilder.Entity<CaoNoticia>(entity =>
            {
                entity.HasKey(e => e.CoNoticia)
                    .HasName("PRIMARY");

                entity.ToTable("cao_noticia");

                entity.Property(e => e.CoNoticia)
                    .HasColumnName("co_noticia")
                    .HasColumnType("int(20)");

                entity.Property(e => e.Assunto)
                    .IsRequired()
                    .HasColumnName("assunto")
                    .HasMaxLength(255)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.CoUsuario)
                    .IsRequired()
                    .HasColumnName("co_usuario")
                    .HasMaxLength(60)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Descricao)
                    .IsRequired()
                    .HasColumnName("descricao");

                entity.Property(e => e.Foto)
                    .IsRequired()
                    .HasColumnName("foto")
                    .HasMaxLength(255)
                    .HasDefaultValueSql("''");
            });

            modelBuilder.Entity<CaoObsCliente>(entity =>
            {
                entity.HasKey(e => e.CoObs)
                    .HasName("PRIMARY");

                entity.ToTable("cao_obs_cliente");

                entity.Property(e => e.CoObs)
                    .HasColumnName("co_obs")
                    .HasColumnType("int(11) unsigned");

                entity.Property(e => e.CoCliente)
                    .HasColumnName("co_cliente")
                    .HasColumnType("int(11) unsigned");

                entity.Property(e => e.CoUsuario)
                    .HasColumnName("co_usuario")
                    .HasMaxLength(30)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Descricao)
                    .IsRequired()
                    .HasColumnName("descricao")
                    .HasMaxLength(250)
                    .HasDefaultValueSql("''");
            });

            modelBuilder.Entity<CaoObsSistema>(entity =>
            {
                entity.HasKey(e => e.CoObs)
                    .HasName("PRIMARY");

                entity.ToTable("cao_obs_sistema");

                entity.Property(e => e.CoObs)
                    .HasColumnName("co_obs")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.CoSistema)
                    .HasColumnName("co_sistema")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.CoUsuario)
                    .HasColumnName("co_usuario")
                    .HasMaxLength(20);

                entity.Property(e => e.Descricao).HasColumnName("descricao");
            });

            modelBuilder.Entity<CaoOmbudsman>(entity =>
            {
                entity.ToTable("cao_ombudsman");

                entity.HasIndex(e => e.CoEscritorio)
                    .HasName("co_escritorio");

                entity.HasIndex(e => e.Idcategoria)
                    .HasName("idcategoria");

                entity.HasIndex(e => e.Idtipo)
                    .HasName("idtipo");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CoEscritorio)
                    .HasColumnName("co_escritorio")
                    .HasColumnType("tinyint(4)");

                entity.Property(e => e.Comentario)
                    .IsRequired()
                    .HasColumnName("comentario");

                entity.Property(e => e.Idcategoria)
                    .HasColumnName("idcategoria")
                    .HasColumnType("tinyint(4)");

                entity.Property(e => e.Idtipo)
                    .HasColumnName("idtipo")
                    .HasColumnType("tinyint(4)");

                entity.HasOne(d => d.IdcategoriaNavigation)
                    .WithMany(p => p.CaoOmbudsman)
                    .HasForeignKey(d => d.Idcategoria)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("cao_ombudsman_ibfk_2");

                entity.HasOne(d => d.IdtipoNavigation)
                    .WithMany(p => p.CaoOmbudsman)
                    .HasForeignKey(d => d.Idtipo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("cao_ombudsman_ibfk_1");
            });

            modelBuilder.Entity<CaoOs>(entity =>
            {
                entity.HasKey(e => e.CoOs)
                    .HasName("PRIMARY");

                entity.ToTable("cao_os");

                entity.Property(e => e.CoOs)
                    .HasColumnName("co_os")
                    .HasColumnType("int(8)");

                entity.Property(e => e.CoArquitetura)
                    .HasColumnName("co_arquitetura")
                    .HasColumnType("int(2)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.CoEmail)
                    .HasColumnName("co_email")
                    .HasColumnType("int(30)");

                entity.Property(e => e.CoOsProspectRel)
                    .HasColumnName("co_os_prospect_rel")
                    .HasColumnType("int(8)");

                entity.Property(e => e.CoSistema)
                    .HasColumnName("co_sistema")
                    .HasColumnType("int(8)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.CoStatus)
                    .HasColumnName("co_status")
                    .HasColumnType("int(2)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.CoUsuario)
                    .HasColumnName("co_usuario")
                    .HasMaxLength(50)
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.DddTelSol)
                    .HasColumnName("ddd_tel_sol")
                    .HasMaxLength(5);

                entity.Property(e => e.DddTelSol2)
                    .HasColumnName("ddd_tel_sol2")
                    .HasMaxLength(5);

                entity.Property(e => e.DiretoriaSol)
                    .HasColumnName("diretoria_sol")
                    .HasMaxLength(50)
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.DsCaracteristica)
                    .HasColumnName("ds_caracteristica")
                    .HasMaxLength(600)
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.DsOs)
                    .HasColumnName("ds_os")
                    .HasMaxLength(200)
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.DsRequisito)
                    .HasColumnName("ds_requisito")
                    .HasMaxLength(200);

                entity.Property(e => e.DtFim)
                    .HasColumnName("dt_fim")
                    .HasColumnType("date");

                entity.Property(e => e.DtGarantia)
                    .HasColumnName("dt_garantia")
                    .HasColumnType("date");

                entity.Property(e => e.DtImp)
                    .HasColumnName("dt_imp")
                    .HasColumnType("date");

                entity.Property(e => e.DtInicio)
                    .HasColumnName("dt_inicio")
                    .HasColumnType("date");

                entity.Property(e => e.DtSol)
                    .HasColumnName("dt_sol")
                    .HasColumnType("date");

                entity.Property(e => e.NuOs)
                    .HasColumnName("nu_os")
                    .HasColumnType("int(8)");

                entity.Property(e => e.NuTelSol)
                    .HasColumnName("nu_tel_sol")
                    .HasMaxLength(20)
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.NuTelSol2)
                    .HasColumnName("nu_tel_sol2")
                    .HasMaxLength(20);

                entity.Property(e => e.UsuarioSol)
                    .HasColumnName("usuario_sol")
                    .HasMaxLength(50)
                    .HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<CaoOsAnalista>(entity =>
            {
                entity.HasKey(e => e.CoAnalista)
                    .HasName("PRIMARY");

                entity.ToTable("cao_os_analista");

                entity.Property(e => e.CoAnalista)
                    .HasColumnName("co_analista")
                    .HasColumnType("int(8)");

                entity.Property(e => e.CoOs)
                    .HasColumnName("co_os")
                    .HasColumnType("int(8)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.CoUsuario)
                    .HasColumnName("co_usuario")
                    .HasMaxLength(50)
                    .HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<CaoOsChamado>(entity =>
            {
                entity.HasKey(e => e.CoChamado)
                    .HasName("PRIMARY");

                entity.ToTable("cao_os_chamado");

                entity.Property(e => e.CoChamado)
                    .HasColumnName("co_chamado")
                    .HasColumnType("int(20)");

                entity.Property(e => e.CoAnalista)
                    .IsRequired()
                    .HasColumnName("co_analista")
                    .HasMaxLength(255)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.CoItem)
                    .HasColumnName("co_item")
                    .HasColumnType("int(20)");

                entity.Property(e => e.CoOs)
                    .HasColumnName("co_os")
                    .HasColumnType("int(20)");

                entity.Property(e => e.CoPrioridade)
                    .HasColumnName("co_prioridade")
                    .HasColumnType("int(20)");

                entity.Property(e => e.CoSistema)
                    .HasColumnName("co_sistema")
                    .HasColumnType("int(20)");

                entity.Property(e => e.CoTipo)
                    .HasColumnName("co_tipo")
                    .HasColumnType("int(20)");

                entity.Property(e => e.CoUsuario)
                    .IsRequired()
                    .HasColumnName("co_usuario")
                    .HasMaxLength(255)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Descricao)
                    .IsRequired()
                    .HasColumnName("descricao");

                entity.Property(e => e.DsChamado)
                    .IsRequired()
                    .HasColumnName("ds_chamado")
                    .HasMaxLength(255)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.DsSolucao)
                    .IsRequired()
                    .HasColumnName("ds_solucao");

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasMaxLength(255);

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasColumnType("int(20)");

                entity.Property(e => e.Tempo)
                    .IsRequired()
                    .HasColumnName("tempo")
                    .HasMaxLength(30)
                    .HasDefaultValueSql("''");
            });

            modelBuilder.Entity<CaoOsDailyReport>(entity =>
            {
                entity.HasKey(e => e.CoDaily)
                    .HasName("PRIMARY");

                entity.ToTable("cao_os_daily_report");

                entity.Property(e => e.CoDaily)
                    .HasColumnName("co_daily")
                    .HasColumnType("int(8)");

                entity.Property(e => e.CoAtividade)
                    .HasColumnName("co_atividade")
                    .HasColumnType("int(4)");

                entity.Property(e => e.CoChamado)
                    .HasColumnName("co_chamado")
                    .HasColumnType("int(20)");

                entity.Property(e => e.CoFase)
                    .HasColumnName("co_fase")
                    .HasColumnType("int(2)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.CoOs)
                    .HasColumnName("co_os")
                    .HasColumnType("int(8)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.CoStatusAtual)
                    .HasColumnName("co_status_atual")
                    .HasColumnType("int(1)");

                entity.Property(e => e.CoUsuario)
                    .HasColumnName("co_usuario")
                    .HasMaxLength(50);

                entity.Property(e => e.DsAssunto).HasColumnName("ds_assunto");

                entity.Property(e => e.TempoGasto).HasColumnName("tempo_gasto");
            });

            modelBuilder.Entity<CaoOsEmail>(entity =>
            {
                entity.HasKey(e => e.CoEmail)
                    .HasName("PRIMARY");

                entity.ToTable("cao_os_email");

                entity.Property(e => e.CoEmail)
                    .HasColumnName("co_email")
                    .HasColumnType("int(8)");

                entity.Property(e => e.Ativo)
                    .HasColumnName("ativo")
                    .HasColumnType("int(20)");

                entity.Property(e => e.Cargo)
                    .HasColumnName("cargo")
                    .HasMaxLength(80);

                entity.Property(e => e.CoCliente)
                    .HasColumnName("co_cliente")
                    .HasColumnType("int(20)");

                entity.Property(e => e.CoOs)
                    .HasColumnName("co_os")
                    .HasColumnType("int(8)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Ddd)
                    .HasColumnName("ddd")
                    .HasMaxLength(20);

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasMaxLength(200)
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasColumnName("nome")
                    .HasMaxLength(255)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Senha)
                    .HasColumnName("senha")
                    .HasMaxLength(20)
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Tel)
                    .HasColumnName("tel")
                    .HasMaxLength(40);
            });

            modelBuilder.Entity<CaoOsFase>(entity =>
            {
                entity.HasKey(e => e.CoFase)
                    .HasName("PRIMARY");

                entity.ToTable("cao_os_fase");

                entity.Property(e => e.CoFase)
                    .HasColumnName("co_fase")
                    .HasColumnType("int(2)");

                entity.Property(e => e.Descricao)
                    .HasColumnName("descricao")
                    .HasMaxLength(200)
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.DescricaoIngl)
                    .IsRequired()
                    .HasColumnName("descricao_ingl")
                    .HasMaxLength(200)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Ordem)
                    .HasColumnName("ordem")
                    .HasColumnType("int(1)");
            });

            modelBuilder.Entity<CaoOsItemMenu>(entity =>
            {
                entity.HasKey(e => e.CoItem)
                    .HasName("PRIMARY");

                entity.ToTable("cao_os_item_menu");

                entity.Property(e => e.CoItem)
                    .HasColumnName("co_item")
                    .HasColumnType("int(20)");

                entity.Property(e => e.CoSistema)
                    .HasColumnName("co_sistema")
                    .HasColumnType("int(20)");

                entity.Property(e => e.DsItem)
                    .IsRequired()
                    .HasColumnName("ds_item")
                    .HasMaxLength(255)
                    .HasDefaultValueSql("''");
            });

            modelBuilder.Entity<CaoOsObs>(entity =>
            {
                entity.HasKey(e => e.CoObs)
                    .HasName("PRIMARY");

                entity.ToTable("cao_os_obs");

                entity.Property(e => e.CoObs)
                    .HasColumnName("co_obs")
                    .HasColumnType("int(8)");

                entity.Property(e => e.CoOs)
                    .HasColumnName("co_os")
                    .HasColumnType("int(8)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.CoUsuario)
                    .HasColumnName("co_usuario")
                    .HasMaxLength(80)
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Descricao).HasColumnName("descricao");
            });

            modelBuilder.Entity<CaoOsObsChamado>(entity =>
            {
                entity.HasKey(e => e.CoObs)
                    .HasName("PRIMARY");

                entity.ToTable("cao_os_obs_chamado");

                entity.Property(e => e.CoObs)
                    .HasColumnName("co_obs")
                    .HasColumnType("int(8)");

                entity.Property(e => e.ArquivoObs)
                    .HasColumnName("arquivo_obs")
                    .HasMaxLength(255);

                entity.Property(e => e.CoChamado)
                    .HasColumnName("co_chamado")
                    .HasColumnType("int(8)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.CoUsuario)
                    .HasColumnName("co_usuario")
                    .HasMaxLength(80)
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Descricao).HasColumnName("descricao");

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<CaoOsPrazo>(entity =>
            {
                entity.HasKey(e => e.CoPrazo)
                    .HasName("PRIMARY");

                entity.ToTable("cao_os_prazo");

                entity.Property(e => e.CoPrazo)
                    .HasColumnName("co_prazo")
                    .HasColumnType("int(8)");

                entity.Property(e => e.CoFase)
                    .HasColumnName("co_fase")
                    .HasColumnType("int(2) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.CoOs)
                    .HasColumnName("co_os")
                    .HasColumnType("int(8)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.TotalAnalista)
                    .HasColumnName("total_analista")
                    .HasColumnType("int(3)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.TotalHora)
                    .HasColumnName("total_hora")
                    .HasColumnType("int(4)")
                    .HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<CaoOsStatus>(entity =>
            {
                entity.HasKey(e => e.CoStatusAtual)
                    .HasName("PRIMARY");

                entity.ToTable("cao_os_status");

                entity.Property(e => e.CoStatusAtual)
                    .HasColumnName("co_status_atual")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.DsStatus)
                    .IsRequired()
                    .HasColumnName("ds_status")
                    .HasMaxLength(50)
                    .IsFixedLength()
                    .HasDefaultValueSql("''");
            });

            modelBuilder.Entity<CaoPagamento>(entity =>
            {
                entity.HasKey(e => e.CoPagamento)
                    .HasName("PRIMARY");

                entity.ToTable("cao_pagamento");

                entity.HasIndex(e => e.CoPagamento)
                    .HasName("nu_os");

                entity.Property(e => e.CoPagamento)
                    .HasColumnName("co_pagamento")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.CoUsuario)
                    .IsRequired()
                    .HasColumnName("co_usuario")
                    .HasMaxLength(20)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.DtPagamento)
                    .HasColumnName("dt_pagamento")
                    .HasColumnType("date")
                    .HasDefaultValueSql("'0000-00-00'");

                entity.Property(e => e.DtReferenciaPagamento)
                    .HasColumnName("dt_referencia_pagamento")
                    .HasColumnType("date")
                    .HasDefaultValueSql("'0000-00-00'");

                entity.Property(e => e.TpPagamento)
                    .IsRequired()
                    .HasColumnName("tp_pagamento")
                    .HasMaxLength(2)
                    .IsFixedLength()
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.VlPagamento).HasColumnName("vl_pagamento");
            });

            modelBuilder.Entity<CaoParticipacaoFuncionario>(entity =>
            {
                entity.HasKey(e => e.CoPartFuncionario)
                    .HasName("PRIMARY");

                entity.ToTable("cao_participacao_funcionario");

                entity.Property(e => e.CoPartFuncionario)
                    .HasColumnName("co_part_funcionario")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.CoEscritorio)
                    .HasColumnName("co_escritorio")
                    .HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.CoUsuario)
                    .IsRequired()
                    .HasColumnName("co_usuario")
                    .HasMaxLength(20)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.DtReferencia)
                    .HasColumnName("dt_referencia")
                    .HasColumnType("date")
                    .HasDefaultValueSql("'0000-00-00'");
            });

            modelBuilder.Entity<CaoPermissao>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("cao_permissao");

                entity.HasIndex(e => e.CoUsuario)
                    .HasName("co_usuario");

                entity.Property(e => e.CoUsuario)
                    .IsRequired()
                    .HasColumnName("co_usuario")
                    .HasMaxLength(20)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.PermissaoHoraExtra)
                    .IsRequired()
                    .HasColumnName("permissao_hora_extra")
                    .HasColumnType("enum('0','1')")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.PermissaoIntervalo)
                    .IsRequired()
                    .HasColumnName("permissao_intervalo")
                    .HasColumnType("enum('0','1')")
                    .HasDefaultValueSql("'0'");

                entity.HasOne(d => d.CoUsuarioNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.CoUsuario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("cao_permissao_ibfk_1");
            });

            modelBuilder.Entity<CaoPermissaoHoraExtra>(entity =>
            {
                entity.HasKey(e => e.IdPermissao)
                    .HasName("PRIMARY");

                entity.ToTable("cao_permissao_hora_extra");

                entity.Property(e => e.IdPermissao)
                    .HasColumnName("id_permissao")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CoMovimento)
                    .HasColumnName("co_movimento")
                    .HasColumnType("bigint(20)");
            });

            modelBuilder.Entity<CaoPontosConhecimento>(entity =>
            {
                entity.HasKey(e => e.Idpontos)
                    .HasName("PRIMARY");

                entity.ToTable("cao_pontos_conhecimento");

                entity.HasIndex(e => e.CoCoordenador)
                    .HasName("co_coordenador");

                entity.HasIndex(e => e.Idconhecimento)
                    .HasName("idconhecimento");

                entity.HasIndex(e => new { e.Pontuacao, e.CoCoordenador, e.Idconhecimento })
                    .HasName("pontuacao");

                entity.Property(e => e.Idpontos)
                    .HasColumnName("idpontos")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CoCoordenador)
                    .IsRequired()
                    .HasColumnName("co_coordenador")
                    .HasMaxLength(50)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Idconhecimento)
                    .HasColumnName("idconhecimento")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Pontuacao)
                    .HasColumnName("pontuacao")
                    .HasColumnType("tinyint(4)");

                entity.HasOne(d => d.CoCoordenadorNavigation)
                    .WithMany(p => p.CaoPontosConhecimento)
                    .HasForeignKey(d => d.CoCoordenador)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("cao_pontos_conhecimento_ibfk_2");

                entity.HasOne(d => d.IdconhecimentoNavigation)
                    .WithMany(p => p.CaoPontosConhecimento)
                    .HasForeignKey(d => d.Idconhecimento)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("cao_pontos_conhecimento_ibfk_3");

                entity.HasOne(d => d.PontuacaoNavigation)
                    .WithMany(p => p.CaoPontosConhecimento)
                    .HasForeignKey(d => d.Pontuacao)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("cao_pontos_conhecimento_ibfk_1");
            });

            modelBuilder.Entity<CaoRamo>(entity =>
            {
                entity.HasKey(e => e.CoRamo)
                    .HasName("PRIMARY");

                entity.ToTable("cao_ramo");

                entity.HasComment("Ramo de atividade de Clientes");

                entity.Property(e => e.CoRamo)
                    .HasColumnName("co_ramo")
                    .HasColumnType("bigint(10) unsigned");

                entity.Property(e => e.DsRamo)
                    .IsRequired()
                    .HasColumnName("ds_ramo")
                    .HasMaxLength(60)
                    .HasDefaultValueSql("''");
            });

            modelBuilder.Entity<CaoRelEmailOs>(entity =>
            {
                entity.ToTable("cao_rel_email_os");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(20)");

                entity.Property(e => e.CoEmail)
                    .HasColumnName("co_email")
                    .HasColumnType("int(20)");

                entity.Property(e => e.CoOs)
                    .HasColumnName("co_os")
                    .HasColumnType("int(20)");
            });

            modelBuilder.Entity<CaoSalario>(entity =>
            {
                entity.HasKey(e => new { e.CoUsuario, e.DtAlteracao })
                    .HasName("PRIMARY");

                entity.ToTable("cao_salario");

                entity.Property(e => e.CoUsuario)
                    .HasColumnName("co_usuario")
                    .HasMaxLength(20)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.DtAlteracao)
                    .HasColumnName("dt_alteracao")
                    .HasColumnType("date")
                    .HasDefaultValueSql("'0000-00-00'");

                entity.Property(e => e.BrutSalario).HasColumnName("brut_salario");

                entity.Property(e => e.LiqSalario).HasColumnName("liq_salario");
            });

            modelBuilder.Entity<CaoSalarioPag>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("cao_salario_pag");

                entity.HasIndex(e => e.IdPagamento)
                    .HasName("id_pagamento");

                entity.HasIndex(e => new { e.CoUsuario, e.DtEfetuado })
                    .HasName("unico")
                    .IsUnique();

                entity.Property(e => e.CoUsuario)
                    .IsRequired()
                    .HasColumnName("co_usuario")
                    .HasMaxLength(20)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.DtEfetuado)
                    .HasColumnName("dt_efetuado")
                    .HasColumnType("date")
                    .HasDefaultValueSql("'0000-00-00'");

                entity.Property(e => e.IdPagamento)
                    .HasColumnName("id_pagamento")
                    .HasColumnType("int(11)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Observacao).HasColumnName("observacao");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasColumnType("enum('Autorizado','Pago','Pendente')")
                    .HasDefaultValueSql("'Pendente'");

                entity.HasOne(d => d.CoUsuarioNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.CoUsuario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("cao_salario_pag_ibfk_1");
            });

            modelBuilder.Entity<CaoServico>(entity =>
            {
                entity.HasKey(e => e.CoServico)
                    .HasName("PRIMARY");

                entity.ToTable("cao_servico");

                entity.Property(e => e.CoServico)
                    .HasColumnName("co_servico")
                    .HasColumnType("int(5)");

                entity.Property(e => e.DsServico)
                    .IsRequired()
                    .HasColumnName("ds_servico")
                    .HasMaxLength(50)
                    .HasDefaultValueSql("''");
            });

            modelBuilder.Entity<CaoSistema>(entity =>
            {
                entity.HasKey(e => e.CoSistema)
                    .HasName("PRIMARY");

                entity.ToTable("cao_sistema");

                entity.HasIndex(e => e.CoSistema)
                    .HasName("co_sistema");

                entity.Property(e => e.CoSistema)
                    .HasColumnName("co_sistema")
                    .HasColumnType("int(8)");

                entity.Property(e => e.CoArquitetura)
                    .HasColumnName("co_arquitetura")
                    .HasColumnType("int(3) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.CoCliente)
                    .HasColumnName("co_cliente")
                    .HasColumnType("int(8) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.CoEmail)
                    .HasColumnName("co_email")
                    .HasColumnType("int(30)");

                entity.Property(e => e.CoUsuario)
                    .HasColumnName("co_usuario")
                    .HasMaxLength(50)
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.DddTelefoneSolic)
                    .HasColumnName("ddd_telefone_solic")
                    .HasMaxLength(5);

                entity.Property(e => e.DsCaracteristica).HasColumnName("ds_caracteristica");

                entity.Property(e => e.DsRequisito).HasColumnName("ds_requisito");

                entity.Property(e => e.DsSistemaResumo).HasColumnName("ds_sistema_resumo");

                entity.Property(e => e.DtEntrega)
                    .HasColumnName("dt_entrega")
                    .HasColumnType("date");

                entity.Property(e => e.DtSolicitacao)
                    .HasColumnName("dt_solicitacao")
                    .HasColumnType("date");

                entity.Property(e => e.NoDiretoriaSolic)
                    .HasColumnName("no_diretoria_solic")
                    .HasMaxLength(100);

                entity.Property(e => e.NoSistema)
                    .HasColumnName("no_sistema")
                    .HasMaxLength(200);

                entity.Property(e => e.NoUsuarioSolic)
                    .HasColumnName("no_usuario_solic")
                    .HasMaxLength(100);

                entity.Property(e => e.NuTelefoneSolic)
                    .HasColumnName("nu_telefone_solic")
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<CaoSistemaObs>(entity =>
            {
                entity.HasKey(e => e.CoObs)
                    .HasName("PRIMARY");

                entity.ToTable("cao_sistema_obs");

                entity.Property(e => e.CoObs)
                    .HasColumnName("co_obs")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.CoSistema)
                    .HasColumnName("co_sistema")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.CoUsuario)
                    .HasColumnName("co_usuario")
                    .HasMaxLength(20);

                entity.Property(e => e.Descricao).HasColumnName("descricao");
            });

            modelBuilder.Entity<CaoStatusAgendamento>(entity =>
            {
                entity.HasKey(e => e.CoStatusAgendamento)
                    .HasName("PRIMARY");

                entity.ToTable("cao_status_agendamento");

                entity.Property(e => e.CoStatusAgendamento)
                    .HasColumnName("co_status_agendamento")
                    .HasColumnType("bigint(10) unsigned");

                entity.Property(e => e.DsStatusAgendamento)
                    .IsRequired()
                    .HasColumnName("ds_status_agendamento")
                    .HasMaxLength(20)
                    .HasDefaultValueSql("''");
            });

            modelBuilder.Entity<CaoStatusCliente>(entity =>
            {
                entity.HasKey(e => e.CoStatus)
                    .HasName("PRIMARY");

                entity.ToTable("cao_status_cliente");

                entity.Property(e => e.CoStatus)
                    .HasColumnName("co_status")
                    .HasColumnType("int(11) unsigned");

                entity.Property(e => e.DsStatus)
                    .IsRequired()
                    .HasColumnName("ds_status")
                    .HasMaxLength(100)
                    .HasDefaultValueSql("''");
            });

            modelBuilder.Entity<CaoStatusClienteComplemento>(entity =>
            {
                entity.HasKey(e => e.CoComplementoStatus)
                    .HasName("PRIMARY");

                entity.ToTable("cao_status_cliente_complemento");

                entity.Property(e => e.CoComplementoStatus)
                    .HasColumnName("co_complemento_status")
                    .HasColumnType("int(11) unsigned");

                entity.Property(e => e.CoStatus)
                    .HasColumnName("co_status")
                    .HasColumnType("int(11) unsigned");

                entity.Property(e => e.DsStatus)
                    .HasColumnName("ds_status")
                    .HasMaxLength(50)
                    .HasDefaultValueSql("''");
            });

            modelBuilder.Entity<CaoStatusOs>(entity =>
            {
                entity.HasKey(e => e.CoStatusAtual)
                    .HasName("PRIMARY");

                entity.ToTable("cao_status_os");

                entity.Property(e => e.CoStatusAtual)
                    .HasColumnName("co_status_atual")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.DsStatus)
                    .IsRequired()
                    .HasColumnName("ds_status")
                    .HasMaxLength(50)
                    .HasDefaultValueSql("''");
            });

            modelBuilder.Entity<CaoTempImport>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PRIMARY");

                entity.ToTable("cao_temp_import");

                entity.Property(e => e.Codigo)
                    .HasColumnName("codigo")
                    .HasColumnType("bigint(10) unsigned");

                entity.Property(e => e.Descricao)
                    .IsRequired()
                    .HasColumnName("descricao")
                    .HasMaxLength(60)
                    .HasDefaultValueSql("''");
            });

            modelBuilder.Entity<CaoTipoConhecimentoUsuario>(entity =>
            {
                entity.HasKey(e => e.CoConhecimento)
                    .HasName("PRIMARY");

                entity.ToTable("cao_tipo_conhecimento_usuario");

                entity.HasIndex(e => e.CoConhecimento)
                    .HasName("co_conhecimento");

                entity.Property(e => e.CoConhecimento)
                    .HasColumnName("co_conhecimento")
                    .HasColumnType("int(1) unsigned");

                entity.Property(e => e.CoSistema)
                    .HasColumnName("co_sistema")
                    .HasColumnType("int(1) unsigned");

                entity.Property(e => e.DsConhecimento)
                    .HasColumnName("ds_conhecimento")
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<CaoTipoCusto>(entity =>
            {
                entity.HasKey(e => e.CoTipoCusto)
                    .HasName("PRIMARY");

                entity.ToTable("cao_tipo_custo");

                entity.Property(e => e.CoTipoCusto)
                    .HasColumnName("co_tipo_custo")
                    .HasColumnType("tinyint(3) unsigned")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Descricao)
                    .IsRequired()
                    .HasColumnName("descricao")
                    .HasMaxLength(30)
                    .HasDefaultValueSql("''");
            });

            modelBuilder.Entity<CaoTipoIdiomaUsuario>(entity =>
            {
                entity.HasKey(e => e.CoIdioma)
                    .HasName("PRIMARY");

                entity.ToTable("cao_tipo_idioma_usuario");

                entity.Property(e => e.CoIdioma)
                    .HasColumnName("co_idioma")
                    .HasColumnType("int(1)");

                entity.Property(e => e.DsIdioma)
                    .HasColumnName("ds_idioma")
                    .HasMaxLength(13);
            });

            modelBuilder.Entity<CaoTipoOmbudsman>(entity =>
            {
                entity.HasKey(e => e.Idtipo)
                    .HasName("PRIMARY");

                entity.ToTable("cao_tipo_ombudsman");

                entity.Property(e => e.Idtipo)
                    .HasColumnName("idtipo")
                    .HasColumnType("tinyint(4)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Descricao)
                    .IsRequired()
                    .HasColumnName("descricao")
                    .HasMaxLength(100)
                    .HasDefaultValueSql("''");
            });

            modelBuilder.Entity<CaoTipoSistemaUsuario>(entity =>
            {
                entity.HasKey(e => e.CoSistema)
                    .HasName("PRIMARY");

                entity.ToTable("cao_tipo_sistema_usuario");

                entity.HasIndex(e => e.CoSistema)
                    .HasName("co_sistema");

                entity.Property(e => e.CoSistema)
                    .HasColumnName("co_sistema")
                    .HasColumnType("int(1) unsigned");

                entity.Property(e => e.DsSistema)
                    .HasColumnName("ds_sistema")
                    .HasMaxLength(40);
            });

            modelBuilder.Entity<CaoUf>(entity =>
            {
                entity.HasKey(e => e.CoUf)
                    .HasName("PRIMARY");

                entity.ToTable("cao_uf");

                entity.Property(e => e.CoUf)
                    .HasColumnName("co_uf")
                    .HasColumnType("bigint(10) unsigned");

                entity.Property(e => e.DsUf)
                    .IsRequired()
                    .HasColumnName("ds_uf")
                    .HasMaxLength(5)
                    .IsFixedLength()
                    .HasDefaultValueSql("''");
            });

            modelBuilder.Entity<CaoUsuario>(entity =>
            {
                entity.HasKey(e => e.CoUsuario)
                    .HasName("PRIMARY");

                entity.ToTable("cao_usuario");

                entity.HasIndex(e => e.CoUsuario)
                    .HasName("co_usuario")
                    .IsUnique();

                entity.Property(e => e.CoUsuario)
                    .HasColumnName("co_usuario")
                    .HasMaxLength(20)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.CoUsuarioAutorizacao)
                    .HasColumnName("co_usuario_autorizacao")
                    .HasMaxLength(20);

                entity.Property(e => e.DsBairro)
                    .HasColumnName("ds_bairro")
                    .HasMaxLength(30);

                entity.Property(e => e.DsCompEnd)
                    .HasColumnName("ds_comp_end")
                    .HasMaxLength(50);

                entity.Property(e => e.DsEndereco)
                    .HasColumnName("ds_endereco")
                    .HasMaxLength(150);

                entity.Property(e => e.DsSenha)
                    .IsRequired()
                    .HasColumnName("ds_senha")
                    .HasMaxLength(14)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.DtAdmissaoEmpresa)
                    .HasColumnName("dt_admissao_empresa")
                    .HasColumnType("date")
                    .HasDefaultValueSql("'0000-00-00'");

                entity.Property(e => e.DtDesligamento)
                    .HasColumnName("dt_desligamento")
                    .HasColumnType("date");

                entity.Property(e => e.DtExpedicao)
                    .HasColumnName("dt_expedicao")
                    .HasColumnType("date");

                entity.Property(e => e.DtExpiracao)
                    .HasColumnName("dt_expiracao")
                    .HasColumnType("date")
                    .HasDefaultValueSql("'0000-00-00'");

                entity.Property(e => e.DtNascimento)
                    .HasColumnName("dt_nascimento")
                    .HasColumnType("date")
                    .HasDefaultValueSql("'0000-00-00'");

                entity.Property(e => e.Icq)
                    .HasColumnName("icq")
                    .HasColumnType("int(13) unsigned");

                entity.Property(e => e.InstantMessenger)
                    .HasColumnName("instant_messenger")
                    .HasMaxLength(80);

                entity.Property(e => e.Msn)
                    .HasColumnName("msn")
                    .HasMaxLength(50);

                entity.Property(e => e.NoCidade)
                    .HasColumnName("no_cidade")
                    .HasMaxLength(50);

                entity.Property(e => e.NoEmail)
                    .HasColumnName("no_email")
                    .HasMaxLength(100);

                entity.Property(e => e.NoEmailPessoal)
                    .HasColumnName("no_email_pessoal")
                    .HasMaxLength(100);

                entity.Property(e => e.NoOrgaoEmissor)
                    .HasColumnName("no_orgao_emissor")
                    .HasMaxLength(10);

                entity.Property(e => e.NoUsuario)
                    .IsRequired()
                    .HasColumnName("no_usuario")
                    .HasMaxLength(50)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.NuCep)
                    .HasColumnName("nu_cep")
                    .HasMaxLength(10);

                entity.Property(e => e.NuCpf)
                    .HasColumnName("nu_cpf")
                    .HasMaxLength(14);

                entity.Property(e => e.NuMatricula)
                    .HasColumnName("nu_matricula")
                    .HasColumnType("bigint(22) unsigned");

                entity.Property(e => e.NuRg)
                    .HasColumnName("nu_rg")
                    .HasMaxLength(20);

                entity.Property(e => e.NuTelefone)
                    .HasColumnName("nu_telefone")
                    .HasMaxLength(64);

                entity.Property(e => e.UfCidade)
                    .HasColumnName("uf_cidade")
                    .HasMaxLength(2);

                entity.Property(e => e.UfOrgaoEmissor)
                    .HasColumnName("uf_orgao_emissor")
                    .HasMaxLength(2);

                entity.Property(e => e.UrlFoto)
                    .HasColumnName("url_foto")
                    .HasMaxLength(255);

                entity.Property(e => e.Yms)
                    .HasColumnName("yms")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<CaoUsuarioDtDisp>(entity =>
            {
                entity.HasKey(e => e.CoDtDisp)
                    .HasName("PRIMARY");

                entity.ToTable("cao_usuario_dt_disp");

                entity.Property(e => e.CoDtDisp)
                    .HasColumnName("co_dt_disp")
                    .HasColumnType("int(6) unsigned");

                entity.Property(e => e.CoUsuario)
                    .HasColumnName("co_usuario")
                    .HasMaxLength(20);

                entity.Property(e => e.DtAlt)
                    .HasColumnName("dt_alt")
                    .HasColumnType("date")
                    .HasDefaultValueSql("'0000-00-00'");

                entity.Property(e => e.DtDisp)
                    .HasColumnName("dt_disp")
                    .HasColumnType("date")
                    .HasDefaultValueSql("'0000-00-00'");
            });

            modelBuilder.Entity<CaoValorDescanso>(entity =>
            {
                entity.ToTable("cao_valor_descanso");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(40)");

                entity.Property(e => e.CoUsuario)
                    .IsRequired()
                    .HasColumnName("co_usuario")
                    .HasMaxLength(40)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.MesReferencia)
                    .IsRequired()
                    .HasColumnName("mes_referencia")
                    .HasMaxLength(50)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Segundos)
                    .IsRequired()
                    .HasColumnName("segundos")
                    .HasMaxLength(50)
                    .HasDefaultValueSql("''");
            });

            modelBuilder.Entity<PermissaoSistema>(entity =>
            {
                entity.HasKey(e => new { e.CoUsuario, e.CoTipoUsuario, e.CoSistema })
                    .HasName("PRIMARY");

                entity.ToTable("permissao_sistema");

                entity.Property(e => e.CoUsuario)
                    .HasColumnName("co_usuario")
                    .HasMaxLength(20)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.CoTipoUsuario)
                    .HasColumnName("co_tipo_usuario")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.CoSistema)
                    .HasColumnName("co_sistema")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.CoUsuarioAtualizacao)
                    .HasColumnName("co_usuario_atualizacao")
                    .HasMaxLength(20);

                entity.Property(e => e.InAtivo)
                    .IsRequired()
                    .HasColumnName("in_ativo")
                    .HasMaxLength(1)
                    .IsFixedLength()
                    .HasDefaultValueSql("'S'");
            });

            modelBuilder.Entity<TipoUsuario>(entity =>
            {
                entity.HasKey(e => new { e.CoTipoUsuario, e.CoSistema })
                    .HasName("PRIMARY");

                entity.ToTable("tipo_usuario");

                entity.HasIndex(e => new { e.CoTipoUsuario, e.CoSistema })
                    .HasName("co_tipo_usuario");

                entity.Property(e => e.CoTipoUsuario)
                    .HasColumnName("co_tipo_usuario")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.CoSistema)
                    .HasColumnName("co_sistema")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.DsTipoUsuario)
                    .IsRequired()
                    .HasColumnName("ds_tipo_usuario")
                    .HasMaxLength(32)
                    .HasDefaultValueSql("''");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
