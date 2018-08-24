using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using SGI.DataBase.Models;

namespace SGI.DataBase
{
    public partial class SgiDbContext : DbContext
    {

        public SgiDbContext(DbContextOptions<SgiDbContext> options)
          : base(options)
        {
        }

        public virtual DbSet<SGI_AUX_Acabamentos> SGI_AUX_Acabamentos { get; set; }
        public virtual DbSet<SGI_AUX_Caracteristicas> SGI_AUX_Caracteristicas { get; set; }
        public virtual DbSet<SGI_AUX_Caracteristicas_Predio_Casa> SGI_AUX_Caracteristicas_Predio_Casa { get; set; }
        public virtual DbSet<SGI_AUX_Composicao> SGI_AUX_Composicao { get; set; }
        public virtual DbSet<SGI_AUX_Conservacao> SGI_AUX_Conservacao { get; set; }
        public virtual DbSet<SGI_AUX_Posicao> SGI_AUX_Posicao { get; set; }
        public virtual DbSet<SGI_AUX_Sub_Tipo> SGI_AUX_Sub_Tipo { get; set; }
        public virtual DbSet<SGI_AUX_Tipo> SGI_AUX_Tipo { get; set; }
        public virtual DbSet<SGI_CRM_Agenda> SGI_CRM_Agenda { get; set; }
        public virtual DbSet<SGI_CRM_Atendimento> SGI_CRM_Atendimento { get; set; }
        public virtual DbSet<SGI_CRM_Atendimento_Encerramento> SGI_CRM_Atendimento_Encerramento { get; set; }
        public virtual DbSet<SGI_CRM_Atendimento_Historico> SGI_CRM_Atendimento_Historico { get; set; }
        public virtual DbSet<SGI_CRM_Cliente> SGI_CRM_Cliente { get; set; }
        public virtual DbSet<SGI_CRM_Cliente_Complementar> SGI_CRM_Cliente_Complementar { get; set; }
        public virtual DbSet<SGI_CRM_Cliente_Documentos> SGI_CRM_Cliente_Documentos { get; set; }
        public virtual DbSet<SGI_CRM_Cliente_Email> SGI_CRM_Cliente_Email { get; set; }
        public virtual DbSet<SGI_CRM_Cliente_Imovel> SGI_CRM_Cliente_Imovel { get; set; }
        public virtual DbSet<SGI_CRM_Cliente_Propostas> SGI_CRM_Cliente_Propostas { get; set; }
        public virtual DbSet<SGI_CRM_Cliente_Propostas_Historico> SGI_CRM_Cliente_Propostas_Historico { get; set; }
        public virtual DbSet<SGI_CRM_Contato> SGI_CRM_Contato { get; set; }
        public virtual DbSet<SGI_CRM_Expectativa> SGI_CRM_Expectativa { get; set; }
        public virtual DbSet<SGI_CRM_Ficha_Imovel> SGI_CRM_Ficha_Imovel { get; set; }
        public virtual DbSet<SGI_CRM_Ficha_Visita> SGI_CRM_Ficha_Visita { get; set; }
        public virtual DbSet<SGI_CRM_operadora> SGI_CRM_operadora { get; set; }
        public virtual DbSet<SGI_CRM_Processo> SGI_CRM_Processo { get; set; }
        public virtual DbSet<SGI_CRM_Processo_Tipo> SGI_CRM_Processo_Tipo { get; set; }
        public virtual DbSet<SGI_CRM_Propostas_Status> SGI_CRM_Propostas_Status { get; set; }
        public virtual DbSet<SGI_CRM_Retorno> SGI_CRM_Retorno { get; set; }
        public virtual DbSet<SGI_CRM_Status> SGI_CRM_Status { get; set; }
        public virtual DbSet<SGI_CRM_Status_Agenda> SGI_CRM_Status_Agenda { get; set; }
        public virtual DbSet<SGI_Disparo> SGI_Disparo { get; set; }
        public virtual DbSet<SGI_Financeiro_Indicies> SGI_Financeiro_Indicies { get; set; }
        public virtual DbSet<SGI_Imobiliaria> SGI_Imobiliaria { get; set; }
        public virtual DbSet<SGI_Imobiliaria_conf> SGI_Imobiliaria_conf { get; set; }
        public virtual DbSet<SGI_Imobiliaria_Corretor> SGI_Imobiliaria_Corretor { get; set; }
        public virtual DbSet<SGI_Imobiliaria_Filial> SGI_Imobiliaria_Filial { get; set; }
        public virtual DbSet<SGI_Imobiliaria_Imagens> SGI_Imobiliaria_Imagens { get; set; }
        public virtual DbSet<SGI_Imovel> SGI_Imovel { get; set; }
        public virtual DbSet<SGI_Imovel_Acabamento> SGI_Imovel_Acabamento { get; set; }
        public virtual DbSet<SGI_Imovel_ADM_Forma_Pgto> SGI_Imovel_ADM_Forma_Pgto { get; set; }
        public virtual DbSet<SGI_Imovel_ADM_Origem> SGI_Imovel_ADM_Origem { get; set; }
        public virtual DbSet<SGI_Imovel_ADM_Pgto> SGI_Imovel_ADM_Pgto { get; set; }
        public virtual DbSet<SGI_Imovel_ADM_Status> SGI_Imovel_ADM_Status { get; set; }
        public virtual DbSet<SGI_Imovel_Auxiliar> SGI_Imovel_Auxiliar { get; set; }
        public virtual DbSet<SGI_Imovel_Caracteristicas> SGI_Imovel_Caracteristicas { get; set; }
        public virtual DbSet<SGI_Imovel_Caracteristicas_Predio_Casa> SGI_Imovel_Caracteristicas_Predio_Casa { get; set; }
        public virtual DbSet<SGI_Imovel_Composicao> SGI_Imovel_Composicao { get; set; }
        public virtual DbSet<SGI_Imovel_documentos> SGI_Imovel_documentos { get; set; }
        public virtual DbSet<SGI_Imovel_email> SGI_Imovel_email { get; set; }
        public virtual DbSet<SGI_Imovel_Fotos> SGI_Imovel_Fotos { get; set; }
        public virtual DbSet<SGI_Imovel_Imobiliaria> SGI_Imovel_Imobiliaria { get; set; }
        public virtual DbSet<SGI_Imovel_Motivo_Venda> SGI_Imovel_Motivo_Venda { get; set; }
        public virtual DbSet<SGI_Imovel_Proprietario> SGI_Imovel_Proprietario { get; set; }
        public virtual DbSet<SGI_Imovel_Seo> SGI_Imovel_Seo { get; set; }
        public virtual DbSet<SGI_Imovel_Sub_Tipo> SGI_Imovel_Sub_Tipo { get; set; }
        public virtual DbSet<SGI_Imovel_Temporada> SGI_Imovel_Temporada { get; set; }
        public virtual DbSet<SGI_Imovel_Venda> SGI_Imovel_Venda { get; set; }
        public virtual DbSet<SGI_Perfil> SGI_Perfil { get; set; }
        public virtual DbSet<SGI_Pessoa> SGI_Pessoa { get; set; }
        public virtual DbSet<SGI_Usuario_Perfil> SGI_Usuario_Perfil { get; set; }
        public virtual DbSet<SGI_Usuarios> SGI_Usuarios { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SGI_AUX_Acabamentos>(entity =>
            {
                entity.Property(e => e.DESCRICAO)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<SGI_AUX_Caracteristicas>(entity =>
            {
                entity.Property(e => e.DESCRICAO)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<SGI_AUX_Caracteristicas_Predio_Casa>(entity =>
            {
                entity.Property(e => e.DESCRICAO)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<SGI_AUX_Composicao>(entity =>
            {
                entity.HasIndex(e => new { e.ORDEM, e.ATIVO })
                    .HasName("FBK_SGI_AUX_Composicao_Imovel_AUX");

                entity.Property(e => e.DESCRICAO)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<SGI_AUX_Conservacao>(entity =>
            {
                entity.Property(e => e.DESCRICAO)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<SGI_AUX_Posicao>(entity =>
            {
                entity.Property(e => e.DESCRICAO)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<SGI_AUX_Sub_Tipo>(entity =>
            {
                entity.Property(e => e.DESCRICAO)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<SGI_AUX_Tipo>(entity =>
            {
                entity.Property(e => e.DESCRICAO)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<SGI_CRM_Agenda>(entity =>
            {
                entity.HasOne(d => d.COD_)
                    .WithMany(p => p.SGI_CRM_Agenda)
                    .HasPrincipalKey(p => new { p.COD_ATENDIMENTO, p.COD_ORIGEM, p.COD_UNIDADE })
                    .HasForeignKey(d => new { d.COD_ATENDIMENTO, d.COD_ORIGEM, d.COD_UNIDADE })
                    .HasConstraintName("FBK_ATENDIMENTO_AGENDA");
            });

            modelBuilder.Entity<SGI_CRM_Atendimento>(entity =>
            {
                entity.HasIndex(e => new { e.COD_ATENDIMENTO, e.COD_ORIGEM, e.COD_UNIDADE })
                    .HasName("SGI_CRM_Atendimento_ATENDIMENTO")
                    .IsUnique();

                entity.HasIndex(e => new { e.COD_CLIENTE, e.COD_ORIGEM, e.COD_UNIDADE })
                    .HasName("CLIENTE");

                entity.HasOne(d => d.COD_)
                    .WithMany(p => p.SGI_CRM_Atendimento)
                    .HasPrincipalKey(p => new { p.COD_CLIENTE, p.COD_ORIGEM, p.COD_UNIDADE })
                    .HasForeignKey(d => new { d.COD_CLIENTE, d.COD_ORIGEM, d.COD_UNIDADE })
                    .HasConstraintName("SGI_CRM_Atendimento_CLIENTE");
            });

            modelBuilder.Entity<SGI_CRM_Atendimento_Encerramento>(entity =>
            {
                entity.Property(e => e.ATIVO).HasDefaultValueSql("('1')");

                entity.Property(e => e.DESCRICAO).IsUnicode(false);
            });

            modelBuilder.Entity<SGI_CRM_Atendimento_Historico>(entity =>
            {
                entity.HasIndex(e => new { e.COD_ATENDIMENTO, e.COD_ORIGEM, e.COD_UNIDADE })
                    .HasName("ATENDIMENTO");

                entity.Property(e => e.DESCRICAO).IsUnicode(false);

                entity.HasOne(d => d.COD_)
                    .WithMany(p => p.SGI_CRM_Atendimento_Historico)
                    .HasPrincipalKey(p => new { p.COD_ATENDIMENTO, p.COD_ORIGEM, p.COD_UNIDADE })
                    .HasForeignKey(d => new { d.COD_ATENDIMENTO, d.COD_ORIGEM, d.COD_UNIDADE })
                    .HasConstraintName("FBK_ATENDIMENTO_HISTORICO");
            });

            modelBuilder.Entity<SGI_CRM_Cliente>(entity =>
            {
                entity.HasIndex(e => new { e.EMAIL, e.NOME })
                    .HasName("SGI_CRM_Cliente_MAIL")
                    .IsUnique();

                entity.HasIndex(e => new { e.COD_CLIENTE, e.COD_ORIGEM, e.COD_UNIDADE })
                    .HasName("SGI_CRM_Cliente_CLIENTE")
                    .IsUnique();

                entity.Property(e => e.ANO_ENTREGA_OBRA)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('ESCOLHA')");

                entity.Property(e => e.AREA_UTIL_MINIMA).HasDefaultValueSql("('0.00')");

                entity.Property(e => e.CELULAR).IsUnicode(false);

                entity.Property(e => e.CIDADE).IsUnicode(false);

                entity.Property(e => e.EMAIL).IsUnicode(false);

                entity.Property(e => e.IMOVEL_BAIRRO).IsUnicode(false);

                entity.Property(e => e.IMOVEL_CIDADE).IsUnicode(false);

                entity.Property(e => e.IMOVEL_DORMS).HasDefaultValueSql("('00')");

                entity.Property(e => e.IMOVEL_EDIFICIO).IsUnicode(false);

                entity.Property(e => e.IMOVEL_RUAS).IsUnicode(false);

                entity.Property(e => e.IMOVEL_SUITES).HasDefaultValueSql("('00')");

                entity.Property(e => e.IMOVEL_VAGAS).HasDefaultValueSql("('00')");

                entity.Property(e => e.MES_ENTREGA_OBRA).IsUnicode(false);

                entity.Property(e => e.NEXTEL_ID).IsUnicode(false);

                entity.Property(e => e.NOME).IsUnicode(false);

                entity.Property(e => e.OBS).IsUnicode(false);

                entity.Property(e => e.RECADO_CORRETOR).IsUnicode(false);

                entity.Property(e => e.REGIAO).IsUnicode(false);

                entity.Property(e => e.TELEFONE_RESIDENCIAL).IsUnicode(false);

                entity.Property(e => e.TEL_COMERCIAL).IsUnicode(false);

                entity.Property(e => e.TIPO).HasDefaultValueSql("('00')");

                entity.Property(e => e.VALOR_MAXIMO).HasDefaultValueSql("('0.00')");

                entity.Property(e => e.VALOR_MAX_CONDOMINIO).HasDefaultValueSql("('0.00')");

                entity.Property(e => e.VALOR_MAX_ENTRADA).HasDefaultValueSql("('0.00')");
            });

            modelBuilder.Entity<SGI_CRM_Cliente_Complementar>(entity =>
            {
                entity.Property(e => e.CNH).IsUnicode(false);

                entity.Property(e => e.NOME_DOCUMENTO)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('000.000.000-00')");

                entity.Property(e => e.VALOR_CODUMENTO).IsUnicode(false);

                entity.HasOne(d => d.COD_)
                    .WithMany(p => p.SGI_CRM_Cliente_Complementar)
                    .HasPrincipalKey(p => new { p.COD_CLIENTE, p.COD_ORIGEM, p.COD_UNIDADE })
                    .HasForeignKey(d => new { d.COD_CLIENTE, d.COD_ORIGEM, d.COD_UNIDADE })
                    .HasConstraintName("FBK_CLIENTE_COMPLEMENTAR");
            });

            modelBuilder.Entity<SGI_CRM_Cliente_Documentos>(entity =>
            {
                entity.HasIndex(e => new { e.COD_CLIENTE, e.COD_ORIGEM, e.COD_UNIDADE })
                    .HasName("CLIENTE");

                entity.Property(e => e.DESCRICAO).IsUnicode(false);

                entity.HasOne(d => d.COD_)
                    .WithMany(p => p.SGI_CRM_Cliente_Documentos)
                    .HasPrincipalKey(p => new { p.COD_CLIENTE, p.COD_ORIGEM, p.COD_UNIDADE })
                    .HasForeignKey(d => new { d.COD_CLIENTE, d.COD_ORIGEM, d.COD_UNIDADE })
                    .HasConstraintName("FBK_CLIENTE_DOCUMENTO");
            });

            modelBuilder.Entity<SGI_CRM_Cliente_Email>(entity =>
            {
                entity.HasIndex(e => e.COD_ATENDIMENTO)
                    .HasName("ATENDIMENTO");

                entity.HasIndex(e => e.COD_CLIENTE)
                    .HasName("CLIENTE");

                entity.Property(e => e.ASSUNTO).IsUnicode(false);

                entity.Property(e => e.CORPO).IsUnicode(false);

                entity.Property(e => e.PARA).IsUnicode(false);

                entity.HasOne(d => d.COD_)
                    .WithMany(p => p.SGI_CRM_Cliente_Email)
                    .HasPrincipalKey(p => new { p.COD_CLIENTE, p.COD_ORIGEM, p.COD_UNIDADE })
                    .HasForeignKey(d => new { d.COD_CLIENTE, d.COD_ORIGEM, d.COD_UNIDADE })
                    .HasConstraintName("FB_CLIENTE_EMAIL");
            });

            modelBuilder.Entity<SGI_CRM_Cliente_Imovel>(entity =>
            {
                entity.HasIndex(e => e.COD_IMOVEL)
                    .HasName("IMOVEL");

                entity.HasIndex(e => new { e.COD_ATENDIMENTO, e.COD_ORIGEM, e.COD_UNIDADE })
                    .HasName("ATENDIMENTO");

                entity.Property(e => e.IMOVEL_REFERENCIA)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('REF')");

                entity.HasOne(d => d.COD_IMOVELNavigation)
                    .WithMany(p => p.SGI_CRM_Cliente_Imovel)
                    .HasForeignKey(d => d.COD_IMOVEL)
                    .HasConstraintName("SGI_CRM_Cliente_Imovel_CLIENTES_Imovel");

                entity.HasOne(d => d.COD_)
                    .WithMany(p => p.SGI_CRM_Cliente_Imovel)
                    .HasPrincipalKey(p => new { p.COD_ATENDIMENTO, p.COD_ORIGEM, p.COD_UNIDADE })
                    .HasForeignKey(d => new { d.COD_ATENDIMENTO, d.COD_ORIGEM, d.COD_UNIDADE })
                    .HasConstraintName("SGI_CRM_Cliente_Imovel_Imovel_CLIENTES");
            });

            modelBuilder.Entity<SGI_CRM_Cliente_Propostas>(entity =>
            {
                entity.HasIndex(e => new { e.COD_CLIENTE, e.COD_ORIGEM, e.COD_UNIDADE })
                    .HasName("CLIENTE");

                entity.HasIndex(e => new { e.COD_IMOVEL, e.IMOVEL_ORIGEM, e.IMOVEL_UNIDADE })
                    .HasName("IMOVEL");

                entity.HasIndex(e => new { e.COD_PROPOSTA, e.PROPOSTA_ORIGEM, e.PROPOSTA_UNIDADE })
                    .HasName("SGI_CRM_Cliente_Propostas_PROPOSTA")
                    .IsUnique();

                entity.HasOne(d => d.COD_IMOVELNavigation)
                    .WithMany(p => p.SGI_CRM_Cliente_Propostas)
                    .HasForeignKey(d => d.COD_IMOVEL)
                    .HasConstraintName("SGI_CRM_Cliente_Propostas_CLIENTES_Imovel");

                entity.HasOne(d => d.COD_)
                    .WithMany(p => p.SGI_CRM_Cliente_Propostas)
                    .HasPrincipalKey(p => new { p.COD_CLIENTE, p.COD_ORIGEM, p.COD_UNIDADE })
                    .HasForeignKey(d => new { d.COD_CLIENTE, d.COD_ORIGEM, d.COD_UNIDADE })
                    .HasConstraintName("SGI_CRM_Cliente_Propostas_CLIENTES_PROPOSTAS");
            });

            modelBuilder.Entity<SGI_CRM_Cliente_Propostas_Historico>(entity =>
            {
                entity.HasIndex(e => new { e.COD_PROPOSTA, e.PROPOSTA_ORIGEM, e.PROPOSTA_UNIDADE })
                    .HasName("PROPOSTA");

                entity.Property(e => e.FILE_NAME).IsUnicode(false);

                entity.HasOne(d => d.SGI_CRM_Cliente_Propostas)
                    .WithMany(p => p.SGI_CRM_Cliente_Propostas_Historico)
                    .HasPrincipalKey(p => new { p.COD_PROPOSTA, p.PROPOSTA_ORIGEM, p.PROPOSTA_UNIDADE })
                    .HasForeignKey(d => new { d.COD_PROPOSTA, d.PROPOSTA_ORIGEM, d.PROPOSTA_UNIDADE })
                    .HasConstraintName("FBK_PROPOSTA_HISTORICO");
            });

            modelBuilder.Entity<SGI_CRM_Contato>(entity =>
            {
                entity.Property(e => e.ATIVO).HasDefaultValueSql("('1')");

                entity.Property(e => e.DESCRICAO).IsUnicode(false);
            });

            modelBuilder.Entity<SGI_CRM_Expectativa>(entity =>
            {
                entity.Property(e => e.ATIVO).HasDefaultValueSql("('1')");

                entity.Property(e => e.DESCRICAO).IsUnicode(false);
            });

            modelBuilder.Entity<SGI_CRM_Ficha_Imovel>(entity =>
            {
                entity.HasIndex(e => new { e.COD_ATENDIMENTO, e.COD_ORIGEM, e.COD_UNIDADE, e.COD_FICHA })
                    .HasName("SGI_CRM_Ficha_Imovel_FICHA_IMOVEL");

                entity.HasIndex(e => new { e.COD_FICHA, e.COD_ATENDIMENTO, e.COD_ORIGEM, e.COD_UNIDADE })
                    .HasName("SGI_CRM_Ficha_Imovel_FBK_FICHA_Imovel");

                entity.Property(e => e.IMOVEL)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('IMOVEL')");

                entity.HasOne(d => d.COD_)
                    .WithMany(p => p.SGI_CRM_Ficha_Imovel)
                    .HasPrincipalKey(p => new { p.COD_ATENDIMENTO, p.COD_ORIGEM, p.COD_UNIDADE, p.COD_FICHA })
                    .HasForeignKey(d => new { d.COD_ATENDIMENTO, d.COD_ORIGEM, d.COD_UNIDADE, d.COD_FICHA })
                    .HasConstraintName("FBK_FICHA_Imovel");
            });

            modelBuilder.Entity<SGI_CRM_Ficha_Visita>(entity =>
            {
                entity.HasIndex(e => new { e.COD_ATENDIMENTO, e.COD_ORIGEM, e.COD_UNIDADE, e.COD_FICHA })
                    .HasName("SGI_CRM_Ficha_Visita_FICHA")
                    .IsUnique();

                entity.HasOne(d => d.COD_)
                    .WithMany(p => p.SGI_CRM_Ficha_Visita)
                    .HasPrincipalKey(p => new { p.COD_ATENDIMENTO, p.COD_ORIGEM, p.COD_UNIDADE })
                    .HasForeignKey(d => new { d.COD_ATENDIMENTO, d.COD_ORIGEM, d.COD_UNIDADE })
                    .HasConstraintName("SGI_CRM_Ficha_Visita_ATENDIMENTO_FICHA");
            });

            modelBuilder.Entity<SGI_CRM_operadora>(entity =>
            {
                entity.Property(e => e.DESCRICAO)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<SGI_CRM_Processo>(entity =>
            {
                entity.HasIndex(e => new { e.COD_CLIENTE, e.COD_ORIGEM, e.COD_UNIDADE })
                    .HasName("SGI_CRM_Processo_CLIENTE");

                entity.HasIndex(e => new { e.COD_PROCESSO, e.COD_ORIGEM, e.COD_UNIDADE })
                    .HasName("SGI_CRM_Processo_Imovel_PROPOSTA")
                    .IsUnique();

                entity.HasOne(d => d.COD_)
                    .WithMany(p => p.SGI_CRM_Processo)
                    .HasPrincipalKey(p => new { p.COD_ATENDIMENTO, p.COD_ORIGEM, p.COD_UNIDADE })
                    .HasForeignKey(d => new { d.COD_ATENDIMENTO, d.COD_ORIGEM, d.COD_UNIDADE })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("SGI_CRM_Processo_ATENDIMENTO_FICHA");

                entity.HasOne(d => d.COD_Navigation)
                    .WithMany(p => p.SGI_CRM_Processo)
                    .HasPrincipalKey(p => new { p.COD_CLIENTE, p.COD_ORIGEM, p.COD_UNIDADE })
                    .HasForeignKey(d => new { d.COD_CLIENTE, d.COD_ORIGEM, d.COD_UNIDADE })
                    .HasConstraintName("SGI_CRM_Processo_CLIENTE_PROCESSO");
            });

            modelBuilder.Entity<SGI_CRM_Processo_Tipo>(entity =>
            {
                entity.Property(e => e.DESCRICAO).IsUnicode(false);
            });

            modelBuilder.Entity<SGI_CRM_Propostas_Status>(entity =>
            {
                entity.Property(e => e.DESCRICAO).IsUnicode(false);
            });

            modelBuilder.Entity<SGI_CRM_Retorno>(entity =>
            {
                entity.Property(e => e.ATIVO).HasDefaultValueSql("('1')");

                entity.Property(e => e.DESCRICAO).IsUnicode(false);
            });

            modelBuilder.Entity<SGI_CRM_Status>(entity =>
            {
                entity.Property(e => e.ATIVO).HasDefaultValueSql("('1')");

                entity.Property(e => e.DESCRICAO).IsUnicode(false);
            });

            modelBuilder.Entity<SGI_CRM_Status_Agenda>(entity =>
            {
                entity.Property(e => e.ATIVO).HasDefaultValueSql("('1')");

                entity.Property(e => e.DESCRICAO).IsUnicode(false);
            });

            modelBuilder.Entity<SGI_Disparo>(entity =>
            {
                entity.HasIndex(e => e.DATA)
                    .HasName("DATA")
                    .IsUnique();

                entity.Property(e => e.LIMITE).HasDefaultValueSql("('12')");
            });

            modelBuilder.Entity<SGI_Financeiro_Indicies>(entity =>
            {
                entity.Property(e => e.DESCRICAO).IsUnicode(false);

                entity.Property(e => e.SIGLA).IsUnicode(false);
            });

            modelBuilder.Entity<SGI_Imobiliaria>(entity =>
            {
                entity.HasIndex(e => new { e.COD_IMOB, e.FILIAL })
                    .HasName("SGI_Imobiliaria_IMOB")
                    .IsUnique();

                entity.HasIndex(e => new { e.VALIDACAO, e.FILIAL })
                    .HasName("SGI_Imobiliaria_VALIDACAO")
                    .IsUnique();

                entity.Property(e => e.BAIRRO).IsUnicode(false);

                entity.Property(e => e.CELULAR_01)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('(00)00000-0000')");

                entity.Property(e => e.CELULAR_02)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('(00)00000-0000')");

                entity.Property(e => e.CEP).IsUnicode(false);

                entity.Property(e => e.CIDADE).IsUnicode(false);

                entity.Property(e => e.CNPJ)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('000.000.000/000-00')");

                entity.Property(e => e.COPLEMENTO).IsUnicode(false);

                entity.Property(e => e.CPF)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('000.000.000-00')");

                entity.Property(e => e.CRECI).IsUnicode(false);

                entity.Property(e => e.EMAIL_PRINCIPAL).IsUnicode(false);

                entity.Property(e => e.EMAIL_SITE).IsUnicode(false);

                entity.Property(e => e.ENDERECO).IsUnicode(false);

                entity.Property(e => e.FACEBOOK).IsUnicode(false);

                entity.Property(e => e.LINKEDIN).IsUnicode(false);

                entity.Property(e => e.NEXTEL_ID).IsUnicode(false);

                entity.Property(e => e.NOME_IMOB)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.NUMERO).IsUnicode(false);

                entity.Property(e => e.RESPONSAVEL).IsUnicode(false);

                entity.Property(e => e.TELEFONE_01)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('(00) 0000-0000')");

                entity.Property(e => e.TELEFONE_02)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('(00) 0000-0000')");

                entity.Property(e => e.UF).IsUnicode(false);

                entity.Property(e => e.URL_01).IsUnicode(false);

                entity.Property(e => e.URL_02).IsUnicode(false);

                entity.Property(e => e.VALIDACAO)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.WHATSAPP)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('(00)00000-0000')");
            });

            modelBuilder.Entity<SGI_Imobiliaria_conf>(entity =>
            {
                entity.HasIndex(e => e.COD_IMOB)
                    .HasName("SGI_Imobiliaria_conf_VALIDACAO1")
                    .IsUnique();

                entity.Property(e => e.FOTOS).IsUnicode(false);

                entity.Property(e => e.MAIL_HOST).IsUnicode(false);

                entity.Property(e => e.MAIL_SENHA).IsUnicode(false);

                entity.Property(e => e.MAIL_USER).IsUnicode(false);

                entity.HasOne(d => d.COD_IMOBNavigation)
                    .WithOne(p => p.SGI_Imobiliaria_conf)
                    .HasForeignKey<SGI_Imobiliaria_conf>(d => d.COD_IMOB)
                    .HasConstraintName("SGI_Imobiliaria_conf_IMOB");
            });

            modelBuilder.Entity<SGI_Imobiliaria_Corretor>(entity =>
            {
                entity.HasIndex(e => new { e.COD_PESSOA, e.COD_IMOB })
                    .HasName("SGI_Imobiliaria_Corretor_VALIDACAO1")
                    .IsUnique();

                entity.HasOne(d => d.COD_IMOBNavigation)
                    .WithMany(p => p.SGI_Imobiliaria_Corretor)
                    .HasForeignKey(d => d.COD_IMOB)
                    .HasConstraintName("FBK_CORRETOR_IMOBILIARIA");

                entity.HasOne(d => d.COD_PESSOANavigation)
                    .WithMany(p => p.SGI_Imobiliaria_Corretor)
                    .HasForeignKey(d => d.COD_PESSOA)
                    .HasConstraintName("FBK_CORRETOR_PESSOA");
            });

            modelBuilder.Entity<SGI_Imobiliaria_Filial>(entity =>
            {
                entity.HasIndex(e => new { e.COD_IMOB, e.COD_FILIAL })
                    .HasName("SGI_Imobiliaria_Filial_VALIDACAO2")
                    .IsUnique();

                entity.HasIndex(e => new { e.VALIDACAO, e.COD_FILIAL })
                    .HasName("SGI_Imobiliaria_Filial_VALIDACAO1")
                    .IsUnique();

                entity.Property(e => e.BAIRRO).IsUnicode(false);

                entity.Property(e => e.CELULAR_01)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('(00)00000-0000')");

                entity.Property(e => e.CELULAR_02)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('(00)00000-0000')");

                entity.Property(e => e.CEP).IsUnicode(false);

                entity.Property(e => e.CIDADE).IsUnicode(false);

                entity.Property(e => e.CNPJ)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('000.000.000/000-00')");

                entity.Property(e => e.COPLEMENTO).IsUnicode(false);

                entity.Property(e => e.CPF)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('000.000.000-00')");

                entity.Property(e => e.CRECI).IsUnicode(false);

                entity.Property(e => e.DESCRICAO_FILIAL)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.EMAIL_PRINCIPAL).IsUnicode(false);

                entity.Property(e => e.EMAIL_SITE).IsUnicode(false);

                entity.Property(e => e.ENDERECO).IsUnicode(false);

                entity.Property(e => e.NOME_IMOB)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.NUMERO).IsUnicode(false);

                entity.Property(e => e.RESPONSAVEL).IsUnicode(false);

                entity.Property(e => e.TELEFONE_01)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('(00) 0000-0000')");

                entity.Property(e => e.TELEFONE_02)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('(00) 0000-0000')");

                entity.Property(e => e.UF).IsUnicode(false);

                entity.Property(e => e.URL_01).IsUnicode(false);

                entity.Property(e => e.URL_02).IsUnicode(false);

                entity.Property(e => e.VALIDACAO)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.HasOne(d => d.COD_IMOBNavigation)
                    .WithMany(p => p.SGI_Imobiliaria_Filial)
                    .HasForeignKey(d => d.COD_IMOB)
                    .HasConstraintName("FBK_IMOB_FILIAL");
            });

            modelBuilder.Entity<SGI_Imobiliaria_Imagens>(entity =>
            {
                entity.HasOne(d => d.COD_IMOBNavigation)
                    .WithMany(p => p.SGI_Imobiliaria_Imagens)
                    .HasForeignKey(d => d.COD_IMOB)
                    .HasConstraintName("FKB_IMG_IMOB");
            });

            modelBuilder.Entity<SGI_Imovel>(entity =>
            {
                entity.HasIndex(e => e.COD_UNIDADE)
                    .HasName("SGI_Imovel_UNIDADE");

                entity.HasIndex(e => e.REFERENCIA)
                    .HasName("SGI_Imovel_IMOVEL2");

                entity.HasIndex(e => e.VALIDACAO)
                    .HasName("SGI_Imovel_VALIDACAO");

                entity.HasIndex(e => new { e.COD_IMOVEL, e.COD_ORIGEM, e.COD_UNIDADE })
                    .HasName("SGI_Imovel_IMOVEL")
                    .IsUnique();

                entity.Property(e => e.AGUA).IsUnicode(false);

                entity.Property(e => e.ANO_CONSTRUCAO)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('0000')");

                entity.Property(e => e.APTO).IsUnicode(false);

                entity.Property(e => e.AREA_TOTAL).HasDefaultValueSql("('0.00')");

                entity.Property(e => e.AREA_UTIL).HasDefaultValueSql("('0.00')");

                entity.Property(e => e.AVERBACAO).IsUnicode(false);

                entity.Property(e => e.BAIRRO).IsUnicode(false);

                entity.Property(e => e.BLOCO).IsUnicode(false);

                entity.Property(e => e.CEP).IsUnicode(false);

                entity.Property(e => e.CIDADE).IsUnicode(false);

                entity.Property(e => e.CIDADE_CONTATO).IsUnicode(false);

                entity.Property(e => e.DIMENSAO_LADO_1).HasDefaultValueSql("('0.00')");

                entity.Property(e => e.DIMENSAO_LADO_2).HasDefaultValueSql("('0.00')");

                entity.Property(e => e.EDIFICIO).IsUnicode(false);

                entity.Property(e => e.ENERGIA).IsUnicode(false);

                entity.Property(e => e.ENTREGA_OBRA)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('0000-00')");

                entity.Property(e => e.FINALIDADE)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('0000000000000000')");

                entity.Property(e => e.GAS).IsUnicode(false);

                entity.Property(e => e.INDICADOR).IsUnicode(false);

                entity.Property(e => e.LANCTO_IPTU).IsUnicode(false);

                entity.Property(e => e.LOCAL_CHAVES).IsUnicode(false);

                entity.Property(e => e.LOGRADOURO).IsUnicode(false);

                entity.Property(e => e.MATRICULA_CARTORIO).IsUnicode(false);

                entity.Property(e => e.NOME_CARTORIO).IsUnicode(false);

                entity.Property(e => e.NUMERO).IsUnicode(false);

                entity.Property(e => e.OUTROS_CONTATOS).IsUnicode(false);

                entity.Property(e => e.PAVIMENTO).IsUnicode(false);

                entity.Property(e => e.PONTO_REFERENCIA).IsUnicode(false);

                entity.Property(e => e.PUBLICAR).HasDefaultValueSql("('1')");

                entity.Property(e => e.REFERENCIA)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('REF')");

                entity.Property(e => e.REF_ALTERNATIVA).IsUnicode(false);

                entity.Property(e => e.REF_MIGRACAO).IsUnicode(false);

                entity.Property(e => e.REGIAO).IsUnicode(false);

                entity.Property(e => e.REGIAO_CONTATO).IsUnicode(false);

                entity.Property(e => e.UF).IsUnicode(false);

                entity.Property(e => e.VALIDACAO)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('AAA')");

                entity.Property(e => e.VALOR_CONDOMINIO).HasDefaultValueSql("('0.00')");

                entity.Property(e => e.VALOR_IPTU).HasDefaultValueSql("('0.00')");

                entity.Property(e => e.VALOR_LOCACAO).HasDefaultValueSql("('0.00')");

                entity.Property(e => e.VALOR_VENDA).HasDefaultValueSql("('0.00')");

                entity.HasOne(d => d.COD_POSICAONavigation)
                    .WithMany(p => p.SGI_Imovel)
                    .HasForeignKey(d => d.COD_POSICAO)
                    .HasConstraintName("SGI_Imovel_POSICAO");

                entity.HasOne(d => d.COD_TIPONavigation)
                    .WithMany(p => p.SGI_Imovel)
                    .HasForeignKey(d => d.COD_TIPO)
                    .HasConstraintName("SGI_Imovel_TIPO");
            });

            modelBuilder.Entity<SGI_Imovel_Acabamento>(entity =>
            {
                entity.HasOne(d => d.COD_ACABAMENTONavigation)
                    .WithMany(p => p.SGI_Imovel_Acabamento)
                    .HasForeignKey(d => d.COD_ACABAMENTO)
                    .HasConstraintName("SGI_Imovel_Acabamento_ACABAMENTO");

                entity.HasOne(d => d.COD_IMOVELNavigation)
                    .WithMany(p => p.SGI_Imovel_Acabamento)
                    .HasForeignKey(d => d.COD_IMOVEL)
                    .HasConstraintName("SGI_Imovel_Acabamento_IMOVEL");
            });

            modelBuilder.Entity<SGI_Imovel_ADM_Forma_Pgto>(entity =>
            {
                entity.Property(e => e.ATIVO).HasDefaultValueSql("('1')");

                entity.Property(e => e.DESCRICAO).IsUnicode(false);
            });

            modelBuilder.Entity<SGI_Imovel_ADM_Origem>(entity =>
            {
                entity.Property(e => e.ATIVO).HasDefaultValueSql("('1')");

                entity.Property(e => e.DESCRICAO).IsUnicode(false);
            });

            modelBuilder.Entity<SGI_Imovel_ADM_Pgto>(entity =>
            {
                entity.HasIndex(e => new { e.CODIGO_ADM, e.COD_IMOVEL, e.COD_ORIGEM })
                    .HasName("SGI_Imovel_ADM_Pgto_VALIDACAO1")
                    .IsUnique();

                entity.HasIndex(e => new { e.COD_IMOVEL, e.COD_ORIGEM, e.COD_UNIDADE })
                    .HasName("IMOVEL");

                entity.Property(e => e.COMPROVANTE).IsUnicode(false);

                entity.Property(e => e.CONTA).IsUnicode(false);

                entity.Property(e => e.DESCRICAO).IsUnicode(false);

                entity.Property(e => e.OBS).IsUnicode(false);

                entity.Property(e => e.VALOR).HasDefaultValueSql("('0.00')");

                entity.HasOne(d => d.COD_)
                    .WithMany(p => p.SGI_Imovel_ADM_Pgto)
                    .HasPrincipalKey(p => new { p.COD_IMOVEL, p.COD_ORIGEM, p.COD_UNIDADE })
                    .HasForeignKey(d => new { d.COD_IMOVEL, d.COD_ORIGEM, d.COD_UNIDADE })
                    .HasConstraintName("FBK_IMOVEL_ADM");
            });

            modelBuilder.Entity<SGI_Imovel_ADM_Status>(entity =>
            {
                entity.Property(e => e.ATIVO).HasDefaultValueSql("('1')");

                entity.Property(e => e.DESCRICAO).IsUnicode(false);
            });

            modelBuilder.Entity<SGI_Imovel_Auxiliar>(entity =>
            {
                entity.HasIndex(e => new { e.COD_IMOVEL, e.COD_ORIGEM, e.COD_UNIDADE })
                    .HasName("FBK_Imovel_AUX");

                entity.HasIndex(e => new { e.COD_IMOVEL, e.COD_UNIDADE, e.COD_ORIGEM })
                    .HasName("SGI_Imovel_Auxiliar_VALIDACAO1")
                    .IsUnique();

                entity.Property(e => e.CIDADE).IsUnicode(false);

                entity.Property(e => e.DIAS_EXCLUSIVIDADE).IsUnicode(false);

                entity.Property(e => e.DIAS_RESERVADOS).IsUnicode(false);

                entity.Property(e => e.DISTANCIA_CENTRO)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('00.000000000')");

                entity.Property(e => e.DISTANCIA_METRO)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('00.000000000')");

                entity.Property(e => e.DISTANCIA_PRAIA)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('00.000000000')");

                entity.Property(e => e.FATOR_APOS).HasDefaultValueSql("('0.00')");

                entity.Property(e => e.FATOR_DURANTE).HasDefaultValueSql("('0.00')");

                entity.Property(e => e.OBS_LOCACAO).IsUnicode(false);

                entity.Property(e => e.OBS_PERMUTA).IsUnicode(false);

                entity.Property(e => e.REGIAO).IsUnicode(false);

                entity.Property(e => e.VALOR_ANUAIS).HasDefaultValueSql("('0.00')");

                entity.Property(e => e.VALOR_A_VISTA).HasDefaultValueSql("('0.00')");

                entity.Property(e => e.VALOR_CHAVES).HasDefaultValueSql("('0.00')");

                entity.Property(e => e.VALOR_COMPRA).HasDefaultValueSql("('0.00')");

                entity.Property(e => e.VALOR_ENTRADA).HasDefaultValueSql("('0.00')");

                entity.Property(e => e.VALOR_MENSAIS).HasDefaultValueSql("('0.00')");

                entity.Property(e => e.VALOR_SEMESTRAIS).HasDefaultValueSql("('0.00')");

                entity.Property(e => e.VALOR_TRIMESTRAIS).HasDefaultValueSql("('0.00')");

                entity.HasOne(d => d.COD_)
                    .WithMany(p => p.SGI_Imovel_Auxiliar)
                    .HasPrincipalKey(p => new { p.COD_IMOVEL, p.COD_ORIGEM, p.COD_UNIDADE })
                    .HasForeignKey(d => new { d.COD_IMOVEL, d.COD_ORIGEM, d.COD_UNIDADE })
                    .HasConstraintName("FBK_Imovel_AUX");
            });

            modelBuilder.Entity<SGI_Imovel_Caracteristicas>(entity =>
            {
                entity.HasOne(d => d.COD_CARACTERISTICANavigation)
                    .WithMany(p => p.SGI_Imovel_Caracteristicas)
                    .HasForeignKey(d => d.COD_CARACTERISTICA)
                    .HasConstraintName("SGI_Imovel_Caracteristicas_CARACTERISTICAS");

                entity.HasOne(d => d.COD_IMOVELNavigation)
                    .WithMany(p => p.SGI_Imovel_Caracteristicas)
                    .HasForeignKey(d => d.COD_IMOVEL)
                    .HasConstraintName("SGI_Imovel_Caracteristicas_IMOVEL");
            });

            modelBuilder.Entity<SGI_Imovel_Caracteristicas_Predio_Casa>(entity =>
            {
                entity.HasOne(d => d.COD_IMOVELNavigation)
                    .WithMany(p => p.SGI_Imovel_Caracteristicas_Predio_Casa)
                    .HasForeignKey(d => d.COD_IMOVEL)
                    .HasConstraintName("SGI_Imovel_Caracteristicas_Predio_Casa_IMOVEL");

                entity.HasOne(d => d.COD_PREDIO_CASANavigation)
                    .WithMany(p => p.SGI_Imovel_Caracteristicas_Predio_Casa)
                    .HasForeignKey(d => d.COD_PREDIO_CASA)
                    .HasConstraintName("SGI_Imovel_Caracteristicas_Predio_Casa_PREDIOCASA");
            });

            modelBuilder.Entity<SGI_Imovel_Composicao>(entity =>
            {
                entity.HasOne(d => d.COD_COMPOSICAONavigation)
                    .WithMany(p => p.SGI_Imovel_Composicao)
                    .HasForeignKey(d => d.COD_COMPOSICAO)
                    .HasConstraintName("SGI_Imovel_Composicao_COMPOSICAO");

                entity.HasOne(d => d.COD_IMOVELNavigation)
                    .WithMany(p => p.SGI_Imovel_Composicao)
                    .HasForeignKey(d => d.COD_IMOVEL)
                    .HasConstraintName("SGI_Imovel_Composicao_IMOVEL");
            });

            modelBuilder.Entity<SGI_Imovel_documentos>(entity =>
            {
                entity.HasIndex(e => new { e.COD_IMOVEL, e.COD_ORIGEM, e.COD_UNIDADE, e.COD_DOC })
                    .HasName("SGI_Imovel_documentos_VALIDACAO1")
                    .IsUnique();

                entity.Property(e => e.DOCUMENTO).IsUnicode(false);

                entity.Property(e => e.EXTENSAO).IsUnicode(false);

                entity.HasOne(d => d.COD_)
                    .WithMany(p => p.SGI_Imovel_documentos)
                    .HasPrincipalKey(p => new { p.COD_IMOVEL, p.COD_ORIGEM, p.COD_UNIDADE })
                    .HasForeignKey(d => new { d.COD_IMOVEL, d.COD_ORIGEM, d.COD_UNIDADE })
                    .HasConstraintName("FBK_IMOVEL_DOC");
            });

            modelBuilder.Entity<SGI_Imovel_email>(entity =>
            {
                entity.HasIndex(e => new { e.COD_IMOVEL, e.COD_ORIGEM, e.COD_UNIDADE })
                    .HasName("IMOVEL");

                entity.Property(e => e.EMAIL_DESTINO)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.EMAIL_ORIGEM)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.OBSERVACAO)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.REFERENCIA)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.HasOne(d => d.COD_)
                    .WithMany(p => p.SGI_Imovel_email)
                    .HasPrincipalKey(p => new { p.COD_IMOVEL, p.COD_ORIGEM, p.COD_UNIDADE })
                    .HasForeignKey(d => new { d.COD_IMOVEL, d.COD_ORIGEM, d.COD_UNIDADE })
                    .HasConstraintName("FBK_Imovel");
            });

            modelBuilder.Entity<SGI_Imovel_Fotos>(entity =>
            {
                entity.HasIndex(e => new { e.COD_IMOVEL, e.COD_ORIGEM, e.COD_UNIDADE })
                    .HasName("FBK_FOTOS_Imovel");

                entity.Property(e => e.ENDERECO)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.EXIBIR).HasDefaultValueSql("('1')");

                entity.Property(e => e.NOME).IsUnicode(false);

                entity.HasOne(d => d.COD_)
                    .WithMany(p => p.SGI_Imovel_Fotos)
                    .HasPrincipalKey(p => new { p.COD_IMOVEL, p.COD_ORIGEM, p.COD_UNIDADE })
                    .HasForeignKey(d => new { d.COD_IMOVEL, d.COD_ORIGEM, d.COD_UNIDADE })
                    .HasConstraintName("FBK_FOTOS_Imovel");
            });

            modelBuilder.Entity<SGI_Imovel_Imobiliaria>(entity =>
            {
                entity.HasIndex(e => e.COD_IMOB)
                    .HasName("SGI_Imovel_Imobiliaria_IMOBILIARIA");

                entity.HasIndex(e => new { e.COD_IMOVEL, e.COD_ORIGEM, e.COD_UNIDADE })
                    .HasName("SGI_Imovel_Imobiliaria_IMOVEL");

                entity.HasIndex(e => new { e.COD_IMOB, e.COD_IMOVEL, e.COD_ORIGEM, e.COD_UNIDADE })
                    .HasName("SGI_Imovel_Imobiliaria_IMOBILIARIA_IMOVEL");

                entity.HasIndex(e => new { e.COD_IMOB, e.COD_IMOVEL, e.COD_UNIDADE, e.COD_ORIGEM })
                    .HasName("SGI_Imovel_Imobiliaria_VALIDACAO1")
                    .IsUnique();

                entity.HasOne(d => d.COD_IMOBNavigation)
                    .WithMany(p => p.SGI_Imovel_Imobiliaria)
                    .HasForeignKey(d => d.COD_IMOB)
                    .HasConstraintName("SGI_Imovel_Imobiliaria_IMOB");

                entity.HasOne(d => d.COD_)
                    .WithMany(p => p.SGI_Imovel_Imobiliaria)
                    .HasPrincipalKey(p => new { p.COD_IMOVEL, p.COD_ORIGEM, p.COD_UNIDADE })
                    .HasForeignKey(d => new { d.COD_IMOVEL, d.COD_ORIGEM, d.COD_UNIDADE })
                    .HasConstraintName("SGI_Imovel_Imobiliaria_Imovel");
            });

            modelBuilder.Entity<SGI_Imovel_Motivo_Venda>(entity =>
            {
                entity.Property(e => e.DESCRICAO)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<SGI_Imovel_Proprietario>(entity =>
            {
                entity.HasIndex(e => new { e.COD_IMOVEL, e.COD_ORIGEM, e.COD_UNIDADE })
                    .HasName("FBK_PROPRIETARIO_Imovel");

                entity.HasIndex(e => new { e.COD_PESSOA, e.COD_ORIGEM, e.COD_UNIDADE, e.COD_IMOVEL })
                    .HasName("SGI_Imovel_Proprietario_VALIDACAO1")
                    .IsUnique();

                entity.HasOne(d => d.COD_PESSOANavigation)
                    .WithMany(p => p.SGI_Imovel_Proprietario)
                    .HasForeignKey(d => d.COD_PESSOA)
                    .HasConstraintName("FBK_PROPRIETARIO_PESSOA");

                entity.HasOne(d => d.COD_)
                    .WithMany(p => p.SGI_Imovel_Proprietario)
                    .HasPrincipalKey(p => new { p.COD_IMOVEL, p.COD_ORIGEM, p.COD_UNIDADE })
                    .HasForeignKey(d => new { d.COD_IMOVEL, d.COD_ORIGEM, d.COD_UNIDADE })
                    .HasConstraintName("FBK_PROPRIETARIO_Imovel");
            });

            modelBuilder.Entity<SGI_Imovel_Seo>(entity =>
            {
                entity.HasIndex(e => new { e.COD_IMOVEL, e.COD_ORIGEM, e.COD_UNIDADE })
                    .HasName("FBK_Imovel_SEO");

                entity.HasIndex(e => new { e.COD_IMOVEL, e.COD_UNIDADE, e.COD_ORIGEM })
                    .HasName("SGI_Imovel_seo_VALIDACAO1")
                    .IsUnique();

                entity.Property(e => e.DESCRICAO_EM_INGLES).IsUnicode(false);

                entity.Property(e => e.DESCRICAO_INTERNA).IsUnicode(false);

                entity.Property(e => e.DESCRICAO_NO_SITE).IsUnicode(false);

                entity.Property(e => e.LATITUDE)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('00.000000000')");

                entity.Property(e => e.LONGITUDE)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('00.000000000')");

                entity.Property(e => e.META_DESCRIPTION).IsUnicode(false);

                entity.Property(e => e.PALAVRAS_CHAVES).IsUnicode(false);

                entity.Property(e => e.PREPOSICAO_BAIRRO).IsUnicode(false);

                entity.Property(e => e.PREPOSICAO_CIDADE).IsUnicode(false);

                entity.Property(e => e.TITULO_PAGINA).IsUnicode(false);

                entity.Property(e => e.YOUTUBE).IsUnicode(false);

                entity.HasOne(d => d.COD_)
                    .WithMany(p => p.SGI_Imovel_Seo)
                    .HasPrincipalKey(p => new { p.COD_IMOVEL, p.COD_ORIGEM, p.COD_UNIDADE })
                    .HasForeignKey(d => new { d.COD_IMOVEL, d.COD_ORIGEM, d.COD_UNIDADE })
                    .HasConstraintName("FBK_Imovel_SEO");
            });

            modelBuilder.Entity<SGI_Imovel_Sub_Tipo>(entity =>
            {
                entity.HasOne(d => d.COD_IMOVELNavigation)
                    .WithMany(p => p.SGI_Imovel_Sub_Tipo)
                    .HasForeignKey(d => d.COD_IMOVEL)
                    .HasConstraintName("SGI_Imovel_Sub_Tipo_IMOVEL");

                entity.HasOne(d => d.COD_SUB_TIPONavigation)
                    .WithMany(p => p.SGI_Imovel_Sub_Tipo)
                    .HasForeignKey(d => d.COD_SUB_TIPO)
                    .HasConstraintName("SGI_Imovel_Sub_Tipo_COMPOSICAO");
            });

            modelBuilder.Entity<SGI_Imovel_Temporada>(entity =>
            {
                entity.HasIndex(e => new { e.COD_IMOVEL, e.COD_ORIGEM, e.COD_UNIDADE })
                    .HasName("FBK_Imovel_TEMPORADA");

                entity.HasIndex(e => new { e.COD_IMOVEL, e.COD_UNIDADE, e.COD_ORIGEM })
                    .HasName("SGI_Imovel_Temporada_VALIDACAO1")
                    .IsUnique();

                entity.Property(e => e.VALOR_ADM).HasDefaultValueSql("('0.00')");

                entity.Property(e => e.VALOR_CAUCAO).HasDefaultValueSql("('0.00')");

                entity.Property(e => e.VALOR_DIARIA_BAIXA).HasDefaultValueSql("('0.00')");

                entity.Property(e => e.VALOR_DIARIA_CARNAVAL).HasDefaultValueSql("('0.00')");

                entity.Property(e => e.VALOR_DIARIA_DATAS).HasDefaultValueSql("('0.00')");

                entity.Property(e => e.VALOR_DIARIA_NATAL).HasDefaultValueSql("('0.00')");

                entity.Property(e => e.VALOR_DIARIA_NATAL_REV).HasDefaultValueSql("('0.00')");

                entity.Property(e => e.VALOR_DIARIA_REV).HasDefaultValueSql("('0.00')");

                entity.Property(e => e.VALOR_DIARIA_TEMP).HasDefaultValueSql("('0.00')");

                entity.Property(e => e.VALOR_LIMPEZA).HasDefaultValueSql("('0.00')");

                entity.HasOne(d => d.COD_)
                    .WithMany(p => p.SGI_Imovel_Temporada)
                    .HasPrincipalKey(p => new { p.COD_IMOVEL, p.COD_ORIGEM, p.COD_UNIDADE })
                    .HasForeignKey(d => new { d.COD_IMOVEL, d.COD_ORIGEM, d.COD_UNIDADE })
                    .HasConstraintName("FBK_Imovel_TEMPORADA");
            });

            modelBuilder.Entity<SGI_Imovel_Venda>(entity =>
            {
                entity.HasIndex(e => new { e.COD_IMOVEL, e.COD_ORIGEM, e.COD_UNIDADE })
                    .HasName("SGI_Imovel_Venda_UQ")
                    .IsUnique();

                entity.HasOne(d => d.COD_)
                    .WithOne(p => p.SGI_Imovel_Venda)
                    .HasPrincipalKey<SGI_Imovel>(p => new { p.COD_IMOVEL, p.COD_ORIGEM, p.COD_UNIDADE })
                    .HasForeignKey<SGI_Imovel_Venda>(d => new { d.COD_IMOVEL, d.COD_ORIGEM, d.COD_UNIDADE })
                    .HasConstraintName("SGI_Imovel_Venda_Imovel_VENDA");
            });

            modelBuilder.Entity<SGI_Perfil>(entity =>
            {
                entity.Property(e => e.NOME_PERFIL)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('NOME PERFIL')");
            });

            modelBuilder.Entity<SGI_Pessoa>(entity =>
            {
                entity.HasIndex(e => e.CNPJCPF)
                    .HasName("SGI_Pessoa_CNPJCPF");

                entity.HasIndex(e => e.DATA_CADASTRO)
                    .HasName("SGI_Pessoa_DATA");

                entity.HasIndex(e => new { e.COD_PESSOA, e.COD_UNIDADE, e.COD_ORIGEM })
                    .HasName("SGI_Pessoa_VALIDACAO1")
                    .IsUnique();

                entity.Property(e => e.ATIVO).HasDefaultValueSql("('1')");

                entity.Property(e => e.BAIRRO)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('BAIRRO')");

                entity.Property(e => e.CELULAR_01)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('(00) 00000-0000')");

                entity.Property(e => e.CELULAR_02)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('(00) 00000-0000')");

                entity.Property(e => e.CEP)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('00.000-000')");

                entity.Property(e => e.CIDADE)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('CIDADE')");

                entity.Property(e => e.CNPJCPF)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('000.000.000-00')");

                entity.Property(e => e.COMPLEMENTO).IsUnicode(false);

                entity.Property(e => e.CORRETOR).HasDefaultValueSql("('0')");

                entity.Property(e => e.CRECI).IsUnicode(false);

                entity.Property(e => e.EMAIL_01).IsUnicode(false);

                entity.Property(e => e.EMAIL_02).IsUnicode(false);

                entity.Property(e => e.ENDERECO)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('ENDERECO')");

                entity.Property(e => e.FANTASIA).IsUnicode(false);

                entity.Property(e => e.IERG).IsUnicode(false);

                entity.Property(e => e.NEXTEL)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('00*00*0000')");

                entity.Property(e => e.NOME)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('NOME')");

                entity.Property(e => e.NUMERO).IsUnicode(false);

                entity.Property(e => e.OBS).IsUnicode(false);

                entity.Property(e => e.REFERENCIA).IsUnicode(false);

                entity.Property(e => e.TEL_COMERCIAL)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('(00) 0000-0000')");

                entity.Property(e => e.TEL_RESISENCIAL)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('(00) 0000-0000')");

                entity.Property(e => e.UF)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('UF')");

                entity.Property(e => e.WHATSAPP)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('(00) 00000-0000')");
            });

            modelBuilder.Entity<SGI_Usuario_Perfil>(entity =>
            {
                entity.HasOne(d => d.COD_PERFILNavigation)
                    .WithMany(p => p.SGI_Usuario_Perfil)
                    .HasForeignKey(d => d.COD_PERFIL)
                    .HasConstraintName("FBK_PERFIL");

                entity.HasOne(d => d.COD_USUARIONavigation)
                    .WithMany(p => p.SGI_Usuario_Perfil)
                    .HasForeignKey(d => d.COD_USUARIO)
                    .HasConstraintName("FBK_USUARIO");
            });

            modelBuilder.Entity<SGI_Usuarios>(entity =>
            {
                entity.HasIndex(e => e.COD_PESSOA)
                    .HasName("CORRETOR");

                entity.Property(e => e.SENHA)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('SENHA')");

                entity.Property(e => e.USER_EMAIL)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('USER_NAME@SOMINIO.COM.BR')");

                entity.Property(e => e.USER_NAME)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('USER_NAME')");

                entity.HasOne(d => d.COD_PESSOANavigation)
                    .WithMany(p => p.SGI_Usuarios)
                    .HasForeignKey(d => d.COD_PESSOA)
                    .HasConstraintName("FBK_USUARIO_PESSOA");
            });

            modelBuilder.EnableAutoHistory(2048);
            base.OnModelCreating(modelBuilder);
            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
