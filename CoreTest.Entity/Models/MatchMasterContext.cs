using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace CoreTest.Entity.Models
{
    public partial class MatchMasterContext : DbContext
    {
        public MatchMasterContext()
        {
        }

        public MatchMasterContext(DbContextOptions<MatchMasterContext> options)
            : base(options)
        {
        }

        public virtual DbSet<BaseMatch> BaseMatch { get; set; }
        public virtual DbSet<ChampionItem> ChampionItem { get; set; }
        public virtual DbSet<ChampionMatch> ChampionMatch { get; set; }
        public virtual DbSet<ChampionMatchDetileView> ChampionMatchDetileView { get; set; }
        public virtual DbSet<ChampionMatchView> ChampionMatchView { get; set; }
        public virtual DbSet<Foofoofoo> Foofoofoo { get; set; }
        public virtual DbSet<GqchangeLog> GqchangeLog { get; set; }
        public virtual DbSet<HgNotice> HgNotice { get; set; }
        public virtual DbSet<Hgconfig> Hgconfig { get; set; }
        public virtual DbSet<MatchMasterBm> MatchMasterBm { get; set; }
        public virtual DbSet<MatchMasterBmsource> MatchMasterBmsource { get; set; }
        public virtual DbSet<MatchMasterResult> MatchMasterResult { get; set; }
        public virtual DbSet<MatchUpdateLog> MatchUpdateLog { get; set; }
        public virtual DbSet<MatchView> MatchView { get; set; }
        public virtual DbSet<Odds> Odds { get; set; }
        public virtual DbSet<Score> Score { get; set; }
        public virtual DbSet<ScoreLog> ScoreLog { get; set; }
        public virtual DbSet<TbLotteryConfig> TbLotteryConfig { get; set; }
        public virtual DbSet<TbLotteryConfig0214> TbLotteryConfig0214 { get; set; }
        public virtual DbSet<TbLotteryOdds> TbLotteryOdds { get; set; }
        public virtual DbSet<TbLotteryPrize> TbLotteryPrize { get; set; }
        public virtual DbSet<TbLotteryPrize1> TbLotteryPrize1 { get; set; }
        public virtual DbSet<TbLotteryPrizeLog> TbLotteryPrizeLog { get; set; }
        public virtual DbSet<TbLotteryPrizeMapping> TbLotteryPrizeMapping { get; set; }
        public virtual DbSet<TbLotteryPrizeRecord> TbLotteryPrizeRecord { get; set; }
        public virtual DbSet<TbLotteryPrizeRecord1> TbLotteryPrizeRecord1 { get; set; }
        public virtual DbSet<TbLotteryPrizeTemp> TbLotteryPrizeTemp { get; set; }
        public virtual DbSet<TbMatchBcqc> TbMatchBcqc { get; set; }
        public virtual DbSet<TbMatchBd> TbMatchBd { get; set; }
        public virtual DbSet<TbMatchDs> TbMatchDs { get; set; }
        public virtual DbSet<TbMatchDx> TbMatchDx { get; set; }
        public virtual DbSet<TbMatchDy> TbMatchDy { get; set; }
        public virtual DbSet<TbMatchMaster> TbMatchMaster { get; set; }
        public virtual DbSet<TbMatchResult> TbMatchResult { get; set; }
        public virtual DbSet<TbMatchRq> TbMatchRq { get; set; }
        public virtual DbSet<TbMatchZhgg> TbMatchZhgg { get; set; }
        public virtual DbSet<TbMatchZrq> TbMatchZrq { get; set; }
        public virtual DbSet<Tblo> Tblo { get; set; }
        public virtual DbSet<TmpTbLotteryOdds> TmpTbLotteryOdds { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=MatchMaster;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BaseMatch>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.CloseTime)
                    .HasColumnName("closeTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.CompetitionName)
                    .HasColumnName("competitionName")
                    .HasMaxLength(255);

                entity.Property(e => e.CreateTime)
                    .HasColumnName("createTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.EndTime)
                    .HasColumnName("endTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.HostsTeam)
                    .HasColumnName("hostsTeam")
                    .HasMaxLength(255);

                entity.Property(e => e.LastUpdateDate)
                    .HasColumnName("lastUpdateDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasMaxLength(10);

                entity.Property(e => e.TingTeam)
                    .HasColumnName("tingTeam")
                    .HasMaxLength(255);

                entity.Property(e => e.Type)
                    .HasColumnName("type")
                    .HasMaxLength(50);

                entity.Property(e => e.WebCode)
                    .HasColumnName("webCode")
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<ChampionItem>(entity =>
            {
                entity.HasIndex(e => new { e.Id, e.TeamName, e.Ratio, e.CreateTime, e.IsChampion, e.ChampionId, e.Mid, e.IsEnable })
                    .HasName("NonClusteredIndex-20160621-155123");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.ChampionId).HasColumnName("championID");

                entity.Property(e => e.CreateTime)
                    .HasColumnName("createTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.IsChampion).HasColumnName("isChampion");

                entity.Property(e => e.IsEnable).HasColumnName("isEnable");

                entity.Property(e => e.Mid)
                    .HasColumnName("mid")
                    .HasMaxLength(20);

                entity.Property(e => e.Ratio).HasColumnName("ratio");

                entity.Property(e => e.TeamName)
                    .HasColumnName("teamName")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<ChampionMatch>(entity =>
            {
                entity.HasIndex(e => new { e.Id, e.Code, e.CompetitionName, e.Type, e.Status, e.Gid })
                    .HasName("NonClusteredIndex-20160621-160734");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.CloseTime)
                    .HasColumnName("closeTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.Code)
                    .HasColumnName("code")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.CompetitionName)
                    .HasColumnName("competitionName")
                    .HasMaxLength(255);

                entity.Property(e => e.CreateTime)
                    .HasColumnName("createTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.EndTime)
                    .HasColumnName("endTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.Gid).HasColumnName("gid");

                entity.Property(e => e.LastUpdateDate)
                    .HasColumnName("lastUpdateDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.ProjectName)
                    .HasColumnName("projectName")
                    .HasMaxLength(255);

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasMaxLength(10);

                entity.Property(e => e.Type)
                    .HasColumnName("type")
                    .HasMaxLength(50);

                entity.Property(e => e.WebCode)
                    .HasColumnName("webCode")
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<ChampionMatchDetileView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ChampionMatchDetileView");

                entity.Property(e => e.ChampionId).HasColumnName("championID");

                entity.Property(e => e.CloseTime)
                    .HasColumnName("closeTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.Code).HasColumnName("code");

                entity.Property(e => e.CompetitionName)
                    .HasColumnName("competitionName")
                    .HasMaxLength(255);

                entity.Property(e => e.CreateTime)
                    .HasColumnName("createTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.EndTime)
                    .HasColumnName("endTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.Gid).HasColumnName("gid");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.IsChampion).HasColumnName("isChampion");

                entity.Property(e => e.IsEnable).HasColumnName("isEnable");

                entity.Property(e => e.LastUpdateDate)
                    .HasColumnName("lastUpdateDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Mid)
                    .HasColumnName("mid")
                    .HasMaxLength(20);

                entity.Property(e => e.Pid).HasColumnName("pid");

                entity.Property(e => e.ProjectName)
                    .HasColumnName("projectName")
                    .HasMaxLength(255);

                entity.Property(e => e.Ratio).HasColumnName("ratio");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasMaxLength(10);

                entity.Property(e => e.TeamName)
                    .HasColumnName("teamName")
                    .HasMaxLength(255);

                entity.Property(e => e.Type)
                    .HasColumnName("type")
                    .HasMaxLength(50);

                entity.Property(e => e.WebCode)
                    .HasColumnName("webCode")
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<ChampionMatchView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ChampionMatchView");

                entity.Property(e => e.CloseTime)
                    .HasColumnName("closeTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.Code)
                    .HasColumnName("code")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.CompetitionName)
                    .HasColumnName("competitionName")
                    .HasMaxLength(255);

                entity.Property(e => e.CreateTime)
                    .HasColumnName("createTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.EndTime)
                    .HasColumnName("endTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.Gid).HasColumnName("gid");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.IsEnd)
                    .IsRequired()
                    .HasColumnName("isEnd")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.ItemCount).HasColumnName("itemCount");

                entity.Property(e => e.LastUpdateDate)
                    .HasColumnName("lastUpdateDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.ProjectName)
                    .HasColumnName("projectName")
                    .HasMaxLength(255);

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasMaxLength(10);

                entity.Property(e => e.Type)
                    .HasColumnName("type")
                    .HasMaxLength(50);

                entity.Property(e => e.WebCode)
                    .HasColumnName("webCode")
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<Foofoofoo>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("foofoofoo");

                entity.Property(e => e.Depth).HasColumnName("depth");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Isfile)
                    .HasColumnName("isfile")
                    .HasMaxLength(50);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(300);
            });

            modelBuilder.Entity<GqchangeLog>(entity =>
            {
                entity.ToTable("GQChangeLog");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.ChangeName)
                    .HasColumnName("changeName")
                    .HasMaxLength(20);

                entity.Property(e => e.CreateTime)
                    .HasColumnName("createTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.Gid).HasColumnName("gid");

                entity.Property(e => e.Type).HasColumnName("type");

                entity.Property(e => e.Value)
                    .HasColumnName("value")
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<HgNotice>(entity =>
            {
                entity.ToTable("HG_Notice");

                entity.HasIndex(e => new { e.Body, e.EndTime, e.UserName, e.MessType, e.Id, e.Title, e.BeginTime, e.CreateTime, e.Type, e.IsRead })
                    .HasName("NonClusteredIndex-20160621-160818");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.BeginTime)
                    .HasColumnName("beginTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.Body)
                    .HasColumnName("body")
                    .HasColumnType("nvarchar(max)");

                entity.Property(e => e.CreateTime)
                    .HasColumnName("createTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.EndTime)
                    .HasColumnName("endTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.IsRead).HasColumnName("isRead");

                entity.Property(e => e.MessType)
                    .HasColumnName("messType")
                    .HasMaxLength(500);

                entity.Property(e => e.Title)
                    .HasColumnName("title")
                    .HasMaxLength(200);

                entity.Property(e => e.Type)
                    .HasColumnName("type")
                    .HasMaxLength(50);

                entity.Property(e => e.UserName)
                    .HasColumnName("userName")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Hgconfig>(entity =>
            {
                entity.ToTable("HGConfig");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.Hgaccount)
                    .HasColumnName("HGAccount")
                    .HasMaxLength(50);

                entity.Property(e => e.Hgmid)
                    .HasColumnName("HGMid")
                    .HasMaxLength(50);

                entity.Property(e => e.Hgpwd)
                    .HasColumnName("HGPwd")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<MatchMasterBm>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("MatchMasterBM");

                entity.Property(e => e.AllSl).HasColumnName("AllSL");

                entity.Property(e => e.CSettlement).HasColumnName("cSettlement");

                entity.Property(e => e.CenterTv)
                    .HasColumnName("center_tv")
                    .HasMaxLength(50);

                entity.Property(e => e.Code).HasMaxLength(50);

                entity.Property(e => e.Content)
                    .HasColumnName("content")
                    .HasMaxLength(500);

                entity.Property(e => e.Datetime)
                    .HasColumnName("datetime")
                    .HasColumnType("datetime");

                entity.Property(e => e.Eventid)
                    .HasColumnName("eventid")
                    .HasMaxLength(200);

                entity.Property(e => e.FPointC).HasColumnName("F_point_c");

                entity.Property(e => e.FPointH).HasColumnName("F_point_h");

                entity.Property(e => e.FScoreC).HasColumnName("F_score_c");

                entity.Property(e => e.FScoreH).HasColumnName("F_score_h");

                entity.Property(e => e.FStatus)
                    .HasColumnName("F_status")
                    .HasMaxLength(50);

                entity.Property(e => e.Gid).HasColumnName("gid");

                entity.Property(e => e.Gidm).HasColumnName("gidm");

                entity.Property(e => e.GunmC).HasColumnName("gunm_c");

                entity.Property(e => e.GunmH).HasColumnName("gunm_h");

                entity.Property(e => e.HPointC).HasColumnName("h_point_c");

                entity.Property(e => e.HPointH).HasColumnName("h_point_h");

                entity.Property(e => e.HScoreC).HasColumnName("h_score_c");

                entity.Property(e => e.HScoreH).HasColumnName("h_score_h");

                entity.Property(e => e.HSettlement).HasColumnName("hSettlement");

                entity.Property(e => e.Hot)
                    .HasColumnName("hot")
                    .HasMaxLength(10);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.IsCancel)
                    .HasColumnName("isCancel")
                    .HasMaxLength(20);

                entity.Property(e => e.IsColse).HasColumnName("isColse");

                entity.Property(e => e.IsEnable).HasColumnName("isEnable");

                entity.Property(e => e.IsEnable2).HasColumnName("isEnable2");

                entity.Property(e => e.IsShowGq).HasColumnName("IsShowGQ");

                entity.Property(e => e.IshowWeb).HasColumnName("ishowWeb");

                entity.Property(e => e.LastUpdateTime)
                    .HasColumnName("lastUpdateTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.League)
                    .HasColumnName("league")
                    .HasMaxLength(200);

                entity.Property(e => e.More).HasColumnName("more");

                entity.Property(e => e.Play)
                    .HasColumnName("play")
                    .HasMaxLength(10);

                entity.Property(e => e.ScoreC).HasColumnName("score_c");

                entity.Property(e => e.ScoreH).HasColumnName("score_h");

                entity.Property(e => e.ShowScoreC).HasColumnName("showScore_C");

                entity.Property(e => e.ShowScoreH).HasColumnName("showScore_H");

                entity.Property(e => e.Sl).HasColumnName("SL");

                entity.Property(e => e.Sl2).HasColumnName("SL2");

                entity.Property(e => e.Status).HasMaxLength(50);

                entity.Property(e => e.Strong)
                    .HasColumnName("strong")
                    .HasMaxLength(10);

                entity.Property(e => e.TeamC)
                    .HasColumnName("team_c")
                    .HasMaxLength(200);

                entity.Property(e => e.TeamH)
                    .HasColumnName("team_h")
                    .HasMaxLength(200);

                entity.Property(e => e.Time).HasColumnName("time");

                entity.Property(e => e.ToSl).HasColumnName("ToSL");

                entity.Property(e => e.UnSl).HasColumnName("UnSL");

                entity.Property(e => e.UnSl2).HasColumnName("UnSL2");
            });

            modelBuilder.Entity<MatchMasterBmsource>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("MatchMasterBMSource");

                entity.Property(e => e.AllSl).HasColumnName("AllSL");

                entity.Property(e => e.CSettlement).HasColumnName("cSettlement");

                entity.Property(e => e.CenterTv)
                    .HasColumnName("center_tv")
                    .HasMaxLength(50);

                entity.Property(e => e.Code).HasMaxLength(50);

                entity.Property(e => e.Content)
                    .HasColumnName("content")
                    .HasMaxLength(500);

                entity.Property(e => e.Datetime)
                    .HasColumnName("datetime")
                    .HasColumnType("datetime");

                entity.Property(e => e.Eventid)
                    .HasColumnName("eventid")
                    .HasMaxLength(200);

                entity.Property(e => e.FPointC).HasColumnName("F_point_c");

                entity.Property(e => e.FPointH).HasColumnName("F_point_h");

                entity.Property(e => e.FScoreC).HasColumnName("F_score_c");

                entity.Property(e => e.FScoreH).HasColumnName("F_score_h");

                entity.Property(e => e.FStatus)
                    .HasColumnName("F_status")
                    .HasMaxLength(50);

                entity.Property(e => e.Gid).HasColumnName("gid");

                entity.Property(e => e.Gidm).HasColumnName("gidm");

                entity.Property(e => e.GunmC).HasColumnName("gunm_c");

                entity.Property(e => e.GunmH).HasColumnName("gunm_h");

                entity.Property(e => e.HPointC).HasColumnName("h_point_c");

                entity.Property(e => e.HPointH).HasColumnName("h_point_h");

                entity.Property(e => e.HScoreC).HasColumnName("h_score_c");

                entity.Property(e => e.HScoreH).HasColumnName("h_score_h");

                entity.Property(e => e.HSettlement).HasColumnName("hSettlement");

                entity.Property(e => e.Hot)
                    .HasColumnName("hot")
                    .HasMaxLength(10);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.IsCancel)
                    .HasColumnName("isCancel")
                    .HasMaxLength(20);

                entity.Property(e => e.IsColse).HasColumnName("isColse");

                entity.Property(e => e.IsEnable).HasColumnName("isEnable");

                entity.Property(e => e.IsEnable2).HasColumnName("isEnable2");

                entity.Property(e => e.IsShowGq).HasColumnName("IsShowGQ");

                entity.Property(e => e.IshowWeb).HasColumnName("ishowWeb");

                entity.Property(e => e.LastUpdateTime)
                    .HasColumnName("lastUpdateTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.League)
                    .HasColumnName("league")
                    .HasMaxLength(200);

                entity.Property(e => e.More).HasColumnName("more");

                entity.Property(e => e.NewValue).HasMaxLength(500);

                entity.Property(e => e.Play)
                    .HasColumnName("play")
                    .HasMaxLength(10);

                entity.Property(e => e.ScoreC).HasColumnName("score_c");

                entity.Property(e => e.ScoreH).HasColumnName("score_h");

                entity.Property(e => e.ShowScoreC).HasColumnName("showScore_C");

                entity.Property(e => e.ShowScoreH).HasColumnName("showScore_H");

                entity.Property(e => e.Sl).HasColumnName("SL");

                entity.Property(e => e.Sl2).HasColumnName("SL2");

                entity.Property(e => e.Status).HasMaxLength(50);

                entity.Property(e => e.Strong)
                    .HasColumnName("strong")
                    .HasMaxLength(10);

                entity.Property(e => e.TeamC)
                    .HasColumnName("team_c")
                    .HasMaxLength(200);

                entity.Property(e => e.TeamH)
                    .HasColumnName("team_h")
                    .HasMaxLength(200);

                entity.Property(e => e.Time).HasColumnName("time");

                entity.Property(e => e.ToSl).HasColumnName("ToSL");

                entity.Property(e => e.UnSl).HasColumnName("UnSL");

                entity.Property(e => e.UnSl2).HasColumnName("UnSL2");

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");

                entity.Property(e => e.UpdateUserName).HasMaxLength(50);
            });

            modelBuilder.Entity<MatchMasterResult>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("MatchMasterResult");

                entity.Property(e => e.CenterTv)
                    .HasColumnName("center_tv")
                    .HasMaxLength(50);

                entity.Property(e => e.Datetime)
                    .HasColumnName("datetime")
                    .HasColumnType("datetime");

                entity.Property(e => e.Eventid)
                    .HasColumnName("eventid")
                    .HasMaxLength(200);

                entity.Property(e => e.FPointC).HasColumnName("F_point_c");

                entity.Property(e => e.FPointH).HasColumnName("F_point_h");

                entity.Property(e => e.FScoreC).HasColumnName("F_score_c");

                entity.Property(e => e.FScoreH).HasColumnName("F_score_h");

                entity.Property(e => e.FStatus)
                    .HasColumnName("F_status")
                    .HasMaxLength(50);

                entity.Property(e => e.Gid).HasColumnName("gid");

                entity.Property(e => e.Gidm).HasColumnName("gidm");

                entity.Property(e => e.GunmC).HasColumnName("gunm_c");

                entity.Property(e => e.GunmH).HasColumnName("gunm_h");

                entity.Property(e => e.HPointC).HasColumnName("h_point_c");

                entity.Property(e => e.HPointH).HasColumnName("h_point_h");

                entity.Property(e => e.HScoreC).HasColumnName("h_score_c");

                entity.Property(e => e.HScoreH).HasColumnName("h_score_h");

                entity.Property(e => e.Hot)
                    .HasColumnName("hot")
                    .HasMaxLength(10);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.IsEnable).HasColumnName("isEnable");

                entity.Property(e => e.IsShowGq).HasColumnName("IsShowGQ");

                entity.Property(e => e.League)
                    .HasColumnName("league")
                    .HasMaxLength(200);

                entity.Property(e => e.More).HasColumnName("more");

                entity.Property(e => e.Phase10C).HasColumnName("Phase10_c");

                entity.Property(e => e.Phase10H).HasColumnName("Phase10_h");

                entity.Property(e => e.Phase1C).HasColumnName("Phase1_c");

                entity.Property(e => e.Phase1H).HasColumnName("Phase1_h");

                entity.Property(e => e.Phase2C).HasColumnName("Phase2_c");

                entity.Property(e => e.Phase2H).HasColumnName("Phase2_h");

                entity.Property(e => e.Phase3C).HasColumnName("Phase3_c");

                entity.Property(e => e.Phase3H).HasColumnName("Phase3_h");

                entity.Property(e => e.Phase4C).HasColumnName("Phase4_c");

                entity.Property(e => e.Phase4H).HasColumnName("Phase4_h");

                entity.Property(e => e.Phase5C).HasColumnName("Phase5_c");

                entity.Property(e => e.Phase5H).HasColumnName("Phase5_h");

                entity.Property(e => e.Phase6C).HasColumnName("Phase6_c");

                entity.Property(e => e.Phase6H).HasColumnName("Phase6_h");

                entity.Property(e => e.Phase7C).HasColumnName("Phase7_c");

                entity.Property(e => e.Phase7H).HasColumnName("Phase7_h");

                entity.Property(e => e.Phase8C).HasColumnName("Phase8_c");

                entity.Property(e => e.Phase8H).HasColumnName("Phase8_h");

                entity.Property(e => e.Phase9C).HasColumnName("Phase9_c");

                entity.Property(e => e.Phase9H).HasColumnName("Phase9_h");

                entity.Property(e => e.Play)
                    .HasColumnName("play")
                    .HasMaxLength(10);

                entity.Property(e => e.Rgid).HasColumnName("rgid");

                entity.Property(e => e.ScoreC).HasColumnName("score_c");

                entity.Property(e => e.ScoreH).HasColumnName("score_h");

                entity.Property(e => e.Status).HasMaxLength(50);

                entity.Property(e => e.Strong)
                    .HasColumnName("strong")
                    .HasMaxLength(10);

                entity.Property(e => e.TeamC)
                    .HasColumnName("team_c")
                    .HasMaxLength(200);

                entity.Property(e => e.TeamH)
                    .HasColumnName("team_h")
                    .HasMaxLength(200);

                entity.Property(e => e.Time).HasColumnName("time");
            });

            modelBuilder.Entity<MatchUpdateLog>(entity =>
            {
                entity.ToTable("matchUpdateLog");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.ColumnName).HasMaxLength(50);

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.NewValue).HasMaxLength(500);

                entity.Property(e => e.OldValue).HasMaxLength(500);

                entity.Property(e => e.Rid)
                    .HasColumnName("rid")
                    .HasMaxLength(100);

                entity.Property(e => e.SysUserName).HasMaxLength(50);

                entity.Property(e => e.Type).HasMaxLength(50);
            });

            modelBuilder.Entity<MatchView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("MatchView");

                entity.Property(e => e.Bcqcgid).HasColumnName("BCQCgid");

                entity.Property(e => e.BcqclastUpdateTime)
                    .HasColumnName("BCQCLastUpdateTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.Bdgid).HasColumnName("BDgid");

                entity.Property(e => e.BdlastUpdateTime)
                    .HasColumnName("BDLastUpdateTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.CSettlement).HasColumnName("cSettlement");

                entity.Property(e => e.CenterTv)
                    .HasColumnName("center_tv")
                    .HasMaxLength(50);

                entity.Property(e => e.Datetime)
                    .HasColumnName("datetime")
                    .HasColumnType("datetime");

                entity.Property(e => e.Dsgid).HasColumnName("DSgid");

                entity.Property(e => e.DslastUpdateTime)
                    .HasColumnName("DSLastUpdateTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.Dxgid).HasColumnName("DXgid");

                entity.Property(e => e.Dygid).HasColumnName("DYgid");

                entity.Property(e => e.Eventid)
                    .HasColumnName("eventid")
                    .HasMaxLength(200);

                entity.Property(e => e.FPointC).HasColumnName("F_point_c");

                entity.Property(e => e.FPointH).HasColumnName("F_point_h");

                entity.Property(e => e.FScoreC).HasColumnName("F_score_c");

                entity.Property(e => e.FScoreH).HasColumnName("F_score_h");

                entity.Property(e => e.FStatus)
                    .HasColumnName("F_status")
                    .HasMaxLength(50);

                entity.Property(e => e.Gid).HasColumnName("gid");

                entity.Property(e => e.Gidm).HasColumnName("gidm");

                entity.Property(e => e.GunmC).HasColumnName("gunm_c");

                entity.Property(e => e.GunmH).HasColumnName("gunm_h");

                entity.Property(e => e.HPointC).HasColumnName("h_point_c");

                entity.Property(e => e.HPointH).HasColumnName("h_point_h");

                entity.Property(e => e.HScoreC).HasColumnName("h_score_c");

                entity.Property(e => e.HScoreH).HasColumnName("h_score_h");

                entity.Property(e => e.HSettlement).HasColumnName("hSettlement");

                entity.Property(e => e.Hot)
                    .HasColumnName("hot")
                    .HasMaxLength(10);

                entity.Property(e => e.Hratio)
                    .HasColumnName("hratio")
                    .HasMaxLength(20);

                entity.Property(e => e.HratioO)
                    .HasColumnName("hratio_o")
                    .HasMaxLength(20);

                entity.Property(e => e.HratioOp)
                    .HasColumnName("hratio_op")
                    .HasMaxLength(20);

                entity.Property(e => e.HratioP)
                    .HasColumnName("hratio_p")
                    .HasMaxLength(20);

                entity.Property(e => e.HratioU)
                    .HasColumnName("hratio_u")
                    .HasMaxLength(20);

                entity.Property(e => e.HratioUp)
                    .HasColumnName("hratio_up")
                    .HasMaxLength(20);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.IorEoe).HasColumnName("ior_EOE");

                entity.Property(e => e.IorEoo).HasColumnName("ior_EOO");

                entity.Property(e => e.IorEven).HasColumnName("ior_EVEN");

                entity.Property(e => e.IorFcc).HasColumnName("ior_FCC");

                entity.Property(e => e.IorFch).HasColumnName("ior_FCH");

                entity.Property(e => e.IorFcn).HasColumnName("ior_FCN");

                entity.Property(e => e.IorFhc).HasColumnName("ior_FHC");

                entity.Property(e => e.IorFhh).HasColumnName("ior_FHH");

                entity.Property(e => e.IorFhn).HasColumnName("ior_FHN");

                entity.Property(e => e.IorFnc).HasColumnName("ior_FNC");

                entity.Property(e => e.IorFnh).HasColumnName("ior_FNH");

                entity.Property(e => e.IorFnn).HasColumnName("ior_FNN");

                entity.Property(e => e.IorH0c0).HasColumnName("ior_H0C0");

                entity.Property(e => e.IorH0c1).HasColumnName("ior_H0C1");

                entity.Property(e => e.IorH0c2).HasColumnName("ior_H0C2");

                entity.Property(e => e.IorH0c3).HasColumnName("ior_H0C3");

                entity.Property(e => e.IorH0c4).HasColumnName("ior_H0C4");

                entity.Property(e => e.IorH1c0).HasColumnName("ior_H1C0");

                entity.Property(e => e.IorH1c1).HasColumnName("ior_H1C1");

                entity.Property(e => e.IorH1c2).HasColumnName("ior_H1C2");

                entity.Property(e => e.IorH1c3).HasColumnName("ior_H1C3");

                entity.Property(e => e.IorH1c4).HasColumnName("ior_H1C4");

                entity.Property(e => e.IorH2c0).HasColumnName("ior_H2C0");

                entity.Property(e => e.IorH2c1).HasColumnName("ior_H2C1");

                entity.Property(e => e.IorH2c2).HasColumnName("ior_H2C2");

                entity.Property(e => e.IorH2c3).HasColumnName("ior_H2C3");

                entity.Property(e => e.IorH2c4).HasColumnName("ior_H2C4");

                entity.Property(e => e.IorH3c0).HasColumnName("ior_H3C0");

                entity.Property(e => e.IorH3c1).HasColumnName("ior_H3C1");

                entity.Property(e => e.IorH3c2).HasColumnName("ior_H3C2");

                entity.Property(e => e.IorH3c3).HasColumnName("ior_H3C3");

                entity.Property(e => e.IorH3c4).HasColumnName("ior_H3C4");

                entity.Property(e => e.IorH4c0).HasColumnName("ior_H4C0");

                entity.Property(e => e.IorH4c1).HasColumnName("ior_H4C1");

                entity.Property(e => e.IorH4c2).HasColumnName("ior_H4C2");

                entity.Property(e => e.IorH4c3).HasColumnName("ior_H4C3");

                entity.Property(e => e.IorH4c4).HasColumnName("ior_H4C4");

                entity.Property(e => e.IorHmc).HasColumnName("ior_HMC");

                entity.Property(e => e.IorHmcp).HasColumnName("ior_HMCP");

                entity.Property(e => e.IorHmh).HasColumnName("ior_HMH");

                entity.Property(e => e.IorHmhp).HasColumnName("ior_HMHP");

                entity.Property(e => e.IorHmn).HasColumnName("ior_HMN");

                entity.Property(e => e.IorHmnp).HasColumnName("ior_HMNP");

                entity.Property(e => e.IorHouc).HasColumnName("ior_HOUC");

                entity.Property(e => e.IorHouh).HasColumnName("ior_HOUH");

                entity.Property(e => e.IorHpouc).HasColumnName("ior_HPOUC");

                entity.Property(e => e.IorHpouh).HasColumnName("ior_HPOUH");

                entity.Property(e => e.IorHprc).HasColumnName("ior_HPRC");

                entity.Property(e => e.IorHprh).HasColumnName("ior_HPRH");

                entity.Property(e => e.IorHrc).HasColumnName("ior_HRC");

                entity.Property(e => e.IorHrh).HasColumnName("ior_HRH");

                entity.Property(e => e.IorMc).HasColumnName("ior_MC");

                entity.Property(e => e.IorMcp).HasColumnName("ior_MCP");

                entity.Property(e => e.IorMh).HasColumnName("ior_MH");

                entity.Property(e => e.IorMhp).HasColumnName("ior_MHP");

                entity.Property(e => e.IorMn).HasColumnName("ior_MN");

                entity.Property(e => e.IorMnp).HasColumnName("ior_MNP");

                entity.Property(e => e.IorOdd).HasColumnName("ior_ODD");

                entity.Property(e => e.IorOuc).HasColumnName("ior_OUC");

                entity.Property(e => e.IorOuco).HasColumnName("ior_OUCO");

                entity.Property(e => e.IorOucu).HasColumnName("ior_OUCU");

                entity.Property(e => e.IorOuh).HasColumnName("ior_OUH");

                entity.Property(e => e.IorOuho).HasColumnName("ior_OUHO");

                entity.Property(e => e.IorOuhu).HasColumnName("ior_OUHU");

                entity.Property(e => e.IorOvc).HasColumnName("ior_OVC");

                entity.Property(e => e.IorOver).HasColumnName("ior_OVER");

                entity.Property(e => e.IorOvh).HasColumnName("ior_OVH");

                entity.Property(e => e.IorPe).HasColumnName("ior_PE");

                entity.Property(e => e.IorPeoe).HasColumnName("ior_PEOE");

                entity.Property(e => e.IorPeoo).HasColumnName("ior_PEOO");

                entity.Property(e => e.IorPo).HasColumnName("ior_PO");

                entity.Property(e => e.IorPouc).HasColumnName("ior_POUC");

                entity.Property(e => e.IorPouco).HasColumnName("ior_POUCO");

                entity.Property(e => e.IorPoucu).HasColumnName("ior_POUCU");

                entity.Property(e => e.IorPouh).HasColumnName("ior_POUH");

                entity.Property(e => e.IorPouho).HasColumnName("ior_POUHO");

                entity.Property(e => e.IorPouhu).HasColumnName("ior_POUHU");

                entity.Property(e => e.IorPrc).HasColumnName("ior_PRC");

                entity.Property(e => e.IorPrh).HasColumnName("ior_PRH");

                entity.Property(e => e.IorRc).HasColumnName("ior_RC");

                entity.Property(e => e.IorRh).HasColumnName("ior_RH");

                entity.Property(e => e.IorT01).HasColumnName("ior_T01");

                entity.Property(e => e.IorT23).HasColumnName("ior_T23");

                entity.Property(e => e.IorT46).HasColumnName("ior_T46");

                entity.Property(e => e.IsEnable).HasColumnName("isEnable");

                entity.Property(e => e.IsEnable2).HasColumnName("isEnable2");

                entity.Property(e => e.IsShowGq).HasColumnName("IsShowGQ");

                entity.Property(e => e.League)
                    .HasColumnName("league")
                    .HasMaxLength(200);

                entity.Property(e => e.MatchLastUpdateTime)
                    .HasColumnName("matchLastUpdateTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.More).HasColumnName("more");

                entity.Property(e => e.MoreP).HasColumnName("more_P");

                entity.Property(e => e.Play)
                    .HasColumnName("play")
                    .HasMaxLength(10);

                entity.Property(e => e.Ratio)
                    .HasColumnName("ratio")
                    .HasMaxLength(20);

                entity.Property(e => e.RatioO)
                    .HasColumnName("ratio_o")
                    .HasMaxLength(20);

                entity.Property(e => e.RatioOp)
                    .HasColumnName("ratio_op")
                    .HasMaxLength(20);

                entity.Property(e => e.RatioOuco)
                    .HasColumnName("ratio_ouco")
                    .HasMaxLength(20);

                entity.Property(e => e.RatioOucu)
                    .HasColumnName("ratio_oucu")
                    .HasMaxLength(20);

                entity.Property(e => e.RatioOuho)
                    .HasColumnName("ratio_ouho")
                    .HasMaxLength(20);

                entity.Property(e => e.RatioOuhu)
                    .HasColumnName("ratio_ouhu")
                    .HasMaxLength(20);

                entity.Property(e => e.RatioP)
                    .HasColumnName("ratio_P")
                    .HasMaxLength(20);

                entity.Property(e => e.RatioPouco)
                    .HasColumnName("ratio_pouco")
                    .HasMaxLength(20);

                entity.Property(e => e.RatioPoucu)
                    .HasColumnName("ratio_poucu")
                    .HasMaxLength(20);

                entity.Property(e => e.RatioPouho)
                    .HasColumnName("ratio_pouho")
                    .HasMaxLength(20);

                entity.Property(e => e.RatioPouhu)
                    .HasColumnName("ratio_pouhu")
                    .HasMaxLength(20);

                entity.Property(e => e.RatioU)
                    .HasColumnName("ratio_u")
                    .HasMaxLength(20);

                entity.Property(e => e.RatioUp)
                    .HasColumnName("ratio_up")
                    .HasMaxLength(20);

                entity.Property(e => e.Rqgid).HasColumnName("RQgid");

                entity.Property(e => e.ScoreC).HasColumnName("score_c");

                entity.Property(e => e.ScoreH).HasColumnName("score_h");

                entity.Property(e => e.ShowScoreC).HasColumnName("showScore_C");

                entity.Property(e => e.ShowScoreH).HasColumnName("showScore_H");

                entity.Property(e => e.Status).HasMaxLength(50);

                entity.Property(e => e.StrEven)
                    .HasColumnName("str_even")
                    .HasMaxLength(20);

                entity.Property(e => e.StrOdd)
                    .HasColumnName("str_odd")
                    .HasMaxLength(20);

                entity.Property(e => e.Strong)
                    .HasColumnName("strong")
                    .HasMaxLength(10);

                entity.Property(e => e.TeamC)
                    .HasColumnName("team_c")
                    .HasMaxLength(200);

                entity.Property(e => e.TeamH)
                    .HasColumnName("team_h")
                    .HasMaxLength(200);

                entity.Property(e => e.Time).HasColumnName("time");

                entity.Property(e => e.Zhgggid).HasColumnName("ZHGGgid");

                entity.Property(e => e.ZhgglastUpdateTime)
                    .HasColumnName("ZHGGLastUpdateTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.Zrqgid).HasColumnName("ZRQgid");

                entity.Property(e => e.ZrqlastUpdateTime)
                    .HasColumnName("ZRQLastUpdateTime")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<Odds>(entity =>
            {
                entity.HasIndex(e => new { e.Id, e.MatchId, e.Type })
                    .HasName("NonClusteredIndex-20160621-161222");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Additional).HasColumnName("additional");

                entity.Property(e => e.LastUpdateTime)
                    .HasColumnName("lastUpdateTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.MatchId).HasColumnName("matchID");

                entity.Property(e => e.Odds1).HasColumnName("odds");

                entity.Property(e => e.P1)
                    .HasColumnName("p1")
                    .HasMaxLength(50);

                entity.Property(e => e.P2)
                    .HasColumnName("p2")
                    .HasMaxLength(50);

                entity.Property(e => e.P3)
                    .HasColumnName("p3")
                    .HasMaxLength(50);

                entity.Property(e => e.Type)
                    .HasColumnName("type")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Score>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Host).HasColumnName("host");

                entity.Property(e => e.LastUpdateTime)
                    .HasColumnName("lastUpdateTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.MatchId).HasColumnName("matchID");

                entity.Property(e => e.P1)
                    .HasColumnName("p1")
                    .HasMaxLength(50);

                entity.Property(e => e.P2)
                    .HasColumnName("p2")
                    .HasMaxLength(50);

                entity.Property(e => e.P3)
                    .HasColumnName("p3")
                    .HasMaxLength(50);

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasMaxLength(50);

                entity.Property(e => e.Ting).HasColumnName("ting");

                entity.Property(e => e.Type)
                    .HasColumnName("type")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<ScoreLog>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.C).HasColumnName("c");

                entity.Property(e => e.CreateTime)
                    .HasColumnName("createTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.Gid).HasColumnName("gid");

                entity.Property(e => e.H).HasColumnName("h");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasMaxLength(50);

                entity.Property(e => e.Time)
                    .HasColumnName("time")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<TbLotteryConfig>(entity =>
            {
                entity.ToTable("tbLotteryConfig");

                entity.HasIndex(e => new { e.Id, e.StartTime, e.PeriodTime, e.EndTime, e.CloseTime, e.EnablePrizeRecord, e.ClosePandingTime, e.LotteryName, e.Status })
                    .HasName("NonClusteredIndex-20160621-161425");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ClosePandingTime).HasColumnName("closePandingTime");

                entity.Property(e => e.CloseTime).HasColumnName("closeTime");

                entity.Property(e => e.EndTime)
                    .HasColumnName("endTime")
                    .HasMaxLength(30);

                entity.Property(e => e.Exp1)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Exp2)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.HgEnable)
                    .IsRequired()
                    .HasColumnName("hgEnable")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Hgsort)
                    .HasColumnName("HGSort")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.IsRecommend).HasColumnName("isRecommend");

                entity.Property(e => e.LotteryName)
                    .HasColumnName("lotteryName")
                    .HasMaxLength(30);

                entity.Property(e => e.LotteryType)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PcEnable)
                    .IsRequired()
                    .HasColumnName("pcEnable")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.PeriodTime).HasColumnName("periodTime");

                entity.Property(e => e.PhoneEnable)
                    .IsRequired()
                    .HasColumnName("phoneEnable")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.PhoneSort).HasDefaultValueSql("((1))");

                entity.Property(e => e.Sort).HasColumnName("sort");

                entity.Property(e => e.StartTime)
                    .HasColumnName("startTime")
                    .HasMaxLength(30);

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasMaxLength(30);
            });

            modelBuilder.Entity<TbLotteryConfig0214>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbLotteryConfig0214");

                entity.Property(e => e.ClosePandingTime).HasColumnName("closePandingTime");

                entity.Property(e => e.CloseTime).HasColumnName("closeTime");

                entity.Property(e => e.EndTime)
                    .HasColumnName("endTime")
                    .HasMaxLength(30);

                entity.Property(e => e.HgEnable).HasColumnName("hgEnable");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.LotteryName)
                    .HasColumnName("lotteryName")
                    .HasMaxLength(30);

                entity.Property(e => e.PcEnable).HasColumnName("pcEnable");

                entity.Property(e => e.PeriodTime).HasColumnName("periodTime");

                entity.Property(e => e.PhoneEnable).HasColumnName("phoneEnable");

                entity.Property(e => e.Sort).HasColumnName("sort");

                entity.Property(e => e.StartTime)
                    .HasColumnName("startTime")
                    .HasMaxLength(30);

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasMaxLength(30);
            });

            modelBuilder.Entity<TbLotteryOdds>(entity =>
            {
                entity.ToTable("tbLotteryOdds");

                entity.HasIndex(e => new { e.LotteryName, e.ShowIndex })
                    .HasName("NonClusteredIndex-20150920-201516");

                entity.HasIndex(e => new { e.Id, e.OddsName, e.PointsOdds, e.ShowIndex, e.LotteryName, e.HroupName, e.Status })
                    .HasName("NonClusteredIndex-20160621-161513");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.HroupName)
                    .HasColumnName("hroupName")
                    .HasMaxLength(40);

                entity.Property(e => e.LotteryName)
                    .HasColumnName("lotteryName")
                    .HasMaxLength(30);

                entity.Property(e => e.OddsName)
                    .HasColumnName("oddsName")
                    .HasMaxLength(40);

                entity.Property(e => e.PointsOdds).HasColumnName("points_Odds");

                entity.Property(e => e.ShowIndex).HasColumnName("showIndex");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasMaxLength(30);
            });

            modelBuilder.Entity<TbLotteryPrize>(entity =>
            {
                entity.ToTable("tbLotteryPrize");

                entity.HasIndex(e => new { e.LotteryName, e.PublishDate })
                    .HasName("tbLotteryPrizelotteryNamepublishDateIndex");

                entity.HasIndex(e => new { e.LotteryName, e.PublishDate, e.Status })
                    .HasName("NonClusteredIndex-20150920-204755");

                entity.HasIndex(e => new { e.PublishDate, e.LotteryName, e.Status })
                    .HasName("tbLotteryPrizelotteryNamestatusIndex");

                entity.HasIndex(e => new { e.LotteryName, e.ButchNo, e.PublishDate, e.Status })
                    .HasName("NonClusteredIndex-20160621-161550");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ButchNo)
                    .HasColumnName("butchNo")
                    .HasMaxLength(30);

                entity.Property(e => e.LotteryName)
                    .HasColumnName("lotteryName")
                    .HasMaxLength(30);

                entity.Property(e => e.Point1).HasColumnName("point1");

                entity.Property(e => e.Point10).HasColumnName("point10");

                entity.Property(e => e.Point11).HasColumnName("point11");

                entity.Property(e => e.Point12).HasColumnName("point12");

                entity.Property(e => e.Point13).HasColumnName("point13");

                entity.Property(e => e.Point14).HasColumnName("point14");

                entity.Property(e => e.Point15).HasColumnName("point15");

                entity.Property(e => e.Point16).HasColumnName("point16");

                entity.Property(e => e.Point17).HasColumnName("point17");

                entity.Property(e => e.Point18).HasColumnName("point18");

                entity.Property(e => e.Point19).HasColumnName("point19");

                entity.Property(e => e.Point2).HasColumnName("point2");

                entity.Property(e => e.Point20).HasColumnName("point20");

                entity.Property(e => e.Point21).HasColumnName("point21");

                entity.Property(e => e.Point3).HasColumnName("point3");

                entity.Property(e => e.Point4).HasColumnName("point4");

                entity.Property(e => e.Point5).HasColumnName("point5");

                entity.Property(e => e.Point6).HasColumnName("point6");

                entity.Property(e => e.Point7).HasColumnName("point7");

                entity.Property(e => e.Point8).HasColumnName("point8");

                entity.Property(e => e.Point9).HasColumnName("point9");

                entity.Property(e => e.PublishDate)
                    .HasColumnName("publishDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<TbLotteryPrize1>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbLotteryPrize1");

                entity.Property(e => e.ButchNo)
                    .HasColumnName("butchNo")
                    .HasMaxLength(30);

                entity.Property(e => e.LotteryName)
                    .HasColumnName("lotteryName")
                    .HasMaxLength(30);

                entity.Property(e => e.Point1).HasColumnName("point1");

                entity.Property(e => e.Point10).HasColumnName("point10");

                entity.Property(e => e.Point11).HasColumnName("point11");

                entity.Property(e => e.Point12).HasColumnName("point12");

                entity.Property(e => e.Point13).HasColumnName("point13");

                entity.Property(e => e.Point14).HasColumnName("point14");

                entity.Property(e => e.Point15).HasColumnName("point15");

                entity.Property(e => e.Point16).HasColumnName("point16");

                entity.Property(e => e.Point17).HasColumnName("point17");

                entity.Property(e => e.Point18).HasColumnName("point18");

                entity.Property(e => e.Point19).HasColumnName("point19");

                entity.Property(e => e.Point2).HasColumnName("point2");

                entity.Property(e => e.Point20).HasColumnName("point20");

                entity.Property(e => e.Point21).HasColumnName("point21");

                entity.Property(e => e.Point3).HasColumnName("point3");

                entity.Property(e => e.Point4).HasColumnName("point4");

                entity.Property(e => e.Point5).HasColumnName("point5");

                entity.Property(e => e.Point6).HasColumnName("point6");

                entity.Property(e => e.Point7).HasColumnName("point7");

                entity.Property(e => e.Point8).HasColumnName("point8");

                entity.Property(e => e.Point9).HasColumnName("point9");

                entity.Property(e => e.PublishDate)
                    .HasColumnName("publishDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<TbLotteryPrizeLog>(entity =>
            {
                entity.ToTable("tbLotteryPrizeLog");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ButchNo)
                    .HasColumnName("butchNo")
                    .HasMaxLength(30);

                entity.Property(e => e.Createtime)
                    .HasColumnName("createtime")
                    .HasColumnType("datetime");

                entity.Property(e => e.LotteryName)
                    .HasColumnName("lotteryName")
                    .HasMaxLength(30);

                entity.Property(e => e.Point1).HasColumnName("point1");

                entity.Property(e => e.Point10).HasColumnName("point10");

                entity.Property(e => e.Point11).HasColumnName("point11");

                entity.Property(e => e.Point12).HasColumnName("point12");

                entity.Property(e => e.Point13).HasColumnName("point13");

                entity.Property(e => e.Point14).HasColumnName("point14");

                entity.Property(e => e.Point15).HasColumnName("point15");

                entity.Property(e => e.Point16).HasColumnName("point16");

                entity.Property(e => e.Point17).HasColumnName("point17");

                entity.Property(e => e.Point18).HasColumnName("point18");

                entity.Property(e => e.Point19).HasColumnName("point19");

                entity.Property(e => e.Point2).HasColumnName("point2");

                entity.Property(e => e.Point20).HasColumnName("point20");

                entity.Property(e => e.Point21).HasColumnName("point21");

                entity.Property(e => e.Point3).HasColumnName("point3");

                entity.Property(e => e.Point4).HasColumnName("point4");

                entity.Property(e => e.Point5).HasColumnName("point5");

                entity.Property(e => e.Point6).HasColumnName("point6");

                entity.Property(e => e.Point7).HasColumnName("point7");

                entity.Property(e => e.Point8).HasColumnName("point8");

                entity.Property(e => e.Point9).HasColumnName("point9");

                entity.Property(e => e.PublishDate)
                    .HasColumnName("publishDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Source)
                    .HasColumnName("source")
                    .HasMaxLength(50);

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<TbLotteryPrizeMapping>(entity =>
            {
                entity.ToTable("tbLotteryPrizeMapping");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.LotteryName).HasMaxLength(50);

                entity.Property(e => e.OddsName)
                    .HasColumnName("oddsName")
                    .HasMaxLength(500);
            });

            modelBuilder.Entity<TbLotteryPrizeRecord>(entity =>
            {
                entity.ToTable("tbLotteryPrizeRecord");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.BatchNo)
                    .HasColumnName("batchNo")
                    .HasMaxLength(30);

                entity.Property(e => e.LotteryName).HasMaxLength(50);
            });

            modelBuilder.Entity<TbLotteryPrizeRecord1>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbLotteryPrizeRecord1");

                entity.Property(e => e.BatchNo).HasColumnName("batchNo");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.PrizeTime).HasMaxLength(255);
            });

            modelBuilder.Entity<TbLotteryPrizeTemp>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbLotteryPrizeTemp");

                entity.Property(e => e.ButchNo)
                    .HasColumnName("butchNo")
                    .HasMaxLength(30);

                entity.Property(e => e.LotteryName)
                    .HasColumnName("lotteryName")
                    .HasMaxLength(30);

                entity.Property(e => e.Point1).HasColumnName("point1");

                entity.Property(e => e.Point10).HasColumnName("point10");

                entity.Property(e => e.Point11).HasColumnName("point11");

                entity.Property(e => e.Point12).HasColumnName("point12");

                entity.Property(e => e.Point13).HasColumnName("point13");

                entity.Property(e => e.Point14).HasColumnName("point14");

                entity.Property(e => e.Point15).HasColumnName("point15");

                entity.Property(e => e.Point16).HasColumnName("point16");

                entity.Property(e => e.Point17).HasColumnName("point17");

                entity.Property(e => e.Point18).HasColumnName("point18");

                entity.Property(e => e.Point19).HasColumnName("point19");

                entity.Property(e => e.Point2).HasColumnName("point2");

                entity.Property(e => e.Point20).HasColumnName("point20");

                entity.Property(e => e.Point21).HasColumnName("point21");

                entity.Property(e => e.Point3).HasColumnName("point3");

                entity.Property(e => e.Point4).HasColumnName("point4");

                entity.Property(e => e.Point5).HasColumnName("point5");

                entity.Property(e => e.Point6).HasColumnName("point6");

                entity.Property(e => e.Point7).HasColumnName("point7");

                entity.Property(e => e.Point8).HasColumnName("point8");

                entity.Property(e => e.Point9).HasColumnName("point9");

                entity.Property(e => e.PublishDate)
                    .HasColumnName("publishDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<TbMatchBcqc>(entity =>
            {
                entity.HasKey(e => new { e.Gid, e.Type })
                    .HasName("PK_tbMatchBCQC_GID_Type");

                entity.ToTable("tbMatchBCQC");

                entity.Property(e => e.Gid).HasColumnName("gid");

                entity.Property(e => e.IorFcc).HasColumnName("ior_FCC");

                entity.Property(e => e.IorFch).HasColumnName("ior_FCH");

                entity.Property(e => e.IorFcn).HasColumnName("ior_FCN");

                entity.Property(e => e.IorFhc).HasColumnName("ior_FHC");

                entity.Property(e => e.IorFhh).HasColumnName("ior_FHH");

                entity.Property(e => e.IorFhn).HasColumnName("ior_FHN");

                entity.Property(e => e.IorFnc).HasColumnName("ior_FNC");

                entity.Property(e => e.IorFnh).HasColumnName("ior_FNH");

                entity.Property(e => e.IorFnn).HasColumnName("ior_FNN");

                entity.Property(e => e.LastUpdateTime)
                    .HasColumnName("lastUpdateTime")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<TbMatchBd>(entity =>
            {
                entity.HasKey(e => new { e.Gid, e.Type })
                    .HasName("PK_tbMatchBD_GID_Type");

                entity.ToTable("tbMatchBD");

                entity.Property(e => e.Gid).HasColumnName("gid");

                entity.Property(e => e.IorH0c0).HasColumnName("ior_H0C0");

                entity.Property(e => e.IorH0c1).HasColumnName("ior_H0C1");

                entity.Property(e => e.IorH0c2).HasColumnName("ior_H0C2");

                entity.Property(e => e.IorH0c3).HasColumnName("ior_H0C3");

                entity.Property(e => e.IorH0c4).HasColumnName("ior_H0C4");

                entity.Property(e => e.IorH1c0).HasColumnName("ior_H1C0");

                entity.Property(e => e.IorH1c1).HasColumnName("ior_H1C1");

                entity.Property(e => e.IorH1c2).HasColumnName("ior_H1C2");

                entity.Property(e => e.IorH1c3).HasColumnName("ior_H1C3");

                entity.Property(e => e.IorH1c4).HasColumnName("ior_H1C4");

                entity.Property(e => e.IorH2c0).HasColumnName("ior_H2C0");

                entity.Property(e => e.IorH2c1).HasColumnName("ior_H2C1");

                entity.Property(e => e.IorH2c2).HasColumnName("ior_H2C2");

                entity.Property(e => e.IorH2c3).HasColumnName("ior_H2C3");

                entity.Property(e => e.IorH2c4).HasColumnName("ior_H2C4");

                entity.Property(e => e.IorH3c0).HasColumnName("ior_H3C0");

                entity.Property(e => e.IorH3c1).HasColumnName("ior_H3C1");

                entity.Property(e => e.IorH3c2).HasColumnName("ior_H3C2");

                entity.Property(e => e.IorH3c3).HasColumnName("ior_H3C3");

                entity.Property(e => e.IorH3c4).HasColumnName("ior_H3C4");

                entity.Property(e => e.IorH4c0).HasColumnName("ior_H4C0");

                entity.Property(e => e.IorH4c1).HasColumnName("ior_H4C1");

                entity.Property(e => e.IorH4c2).HasColumnName("ior_H4C2");

                entity.Property(e => e.IorH4c3).HasColumnName("ior_H4C3");

                entity.Property(e => e.IorH4c4).HasColumnName("ior_H4C4");

                entity.Property(e => e.IorOvc).HasColumnName("ior_OVC");

                entity.Property(e => e.IorOvh).HasColumnName("ior_OVH");

                entity.Property(e => e.LastUpdateTime)
                    .HasColumnName("lastUpdateTime")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<TbMatchDs>(entity =>
            {
                entity.HasKey(e => new { e.Gid, e.Type })
                    .HasName("PK_tbMatchDS_GID_Type");

                entity.ToTable("tbMatchDS");

                entity.Property(e => e.Gid).HasColumnName("gid");

                entity.Property(e => e.IorEoe).HasColumnName("ior_EOE");

                entity.Property(e => e.IorEoo).HasColumnName("ior_EOO");

                entity.Property(e => e.LastUpdateTime)
                    .HasColumnName("lastUpdateTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.StrEven)
                    .HasColumnName("str_even")
                    .HasMaxLength(20);

                entity.Property(e => e.StrOdd)
                    .HasColumnName("str_odd")
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<TbMatchDx>(entity =>
            {
                entity.HasKey(e => new { e.Gid, e.Type })
                    .HasName("PK_tbMatchDX_GID_Type");

                entity.ToTable("tbMatchDX");

                entity.Property(e => e.Gid).HasColumnName("gid");

                entity.Property(e => e.HratioO)
                    .HasColumnName("hratio_o")
                    .HasMaxLength(20);

                entity.Property(e => e.HratioU)
                    .HasColumnName("hratio_u")
                    .HasMaxLength(20);

                entity.Property(e => e.IorHouc).HasColumnName("ior_HOUC");

                entity.Property(e => e.IorHouh).HasColumnName("ior_HOUH");

                entity.Property(e => e.IorOuc).HasColumnName("ior_OUC");

                entity.Property(e => e.IorOuco).HasColumnName("ior_OUCO");

                entity.Property(e => e.IorOucu).HasColumnName("ior_OUCU");

                entity.Property(e => e.IorOuh).HasColumnName("ior_OUH");

                entity.Property(e => e.IorOuho).HasColumnName("ior_OUHO");

                entity.Property(e => e.IorOuhu).HasColumnName("ior_OUHU");

                entity.Property(e => e.RatioO)
                    .HasColumnName("ratio_o")
                    .HasMaxLength(20);

                entity.Property(e => e.RatioOuco)
                    .HasColumnName("ratio_ouco")
                    .HasMaxLength(20);

                entity.Property(e => e.RatioOucu)
                    .HasColumnName("ratio_oucu")
                    .HasMaxLength(20);

                entity.Property(e => e.RatioOuho)
                    .HasColumnName("ratio_ouho")
                    .HasMaxLength(20);

                entity.Property(e => e.RatioOuhu)
                    .HasColumnName("ratio_ouhu")
                    .HasMaxLength(20);

                entity.Property(e => e.RatioU)
                    .HasColumnName("ratio_u")
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<TbMatchDy>(entity =>
            {
                entity.HasKey(e => new { e.Gid, e.Type })
                    .HasName("PK_tbMatchDY_GID_Type");

                entity.ToTable("tbMatchDY");

                entity.Property(e => e.Gid).HasColumnName("gid");

                entity.Property(e => e.IorHmc).HasColumnName("ior_HMC");

                entity.Property(e => e.IorHmh).HasColumnName("ior_HMH");

                entity.Property(e => e.IorHmn).HasColumnName("ior_HMN");

                entity.Property(e => e.IorMc).HasColumnName("ior_MC");

                entity.Property(e => e.IorMh).HasColumnName("ior_MH");

                entity.Property(e => e.IorMn).HasColumnName("ior_MN");
            });

            modelBuilder.Entity<TbMatchMaster>(entity =>
            {
                entity.ToTable("tbMatchMaster");

                entity.HasIndex(e => new { e.Type, e.Gid })
                    .HasName("tbMatchMasterTypegidIndex");

                entity.HasIndex(e => new { e.Gid, e.IshowWeb, e.IsColse, e.IsCancel, e.Type, e.Kind, e.Datetime })
                    .HasName("tbMatchMasterTypeKinddatetimeIndex");

                entity.HasIndex(e => new { e.Type, e.Status, e.Gid, e.League, e.FStatus, e.Kind, e.Gidm, e.IsEnable2 })
                    .HasName("NonClusteredIndex-20160621-161705");

                entity.HasIndex(e => new { e.Type, e.Status, e.Datetime, e.League, e.TeamH, e.Kind, e.IsEnable2, e.FStatus, e.IsEnable })
                    .HasName("NonClusteredIndex-20150922-164948");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CSettlement)
                    .HasColumnName("cSettlement")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CenterTv)
                    .HasColumnName("center_tv")
                    .HasMaxLength(50);

                entity.Property(e => e.ChargeStatus).HasDefaultValueSql("((0))");

                entity.Property(e => e.Datetime)
                    .HasColumnName("datetime")
                    .HasColumnType("datetime");

                entity.Property(e => e.Eventid)
                    .HasColumnName("eventid")
                    .HasMaxLength(200);

                entity.Property(e => e.FPointC)
                    .HasColumnName("F_point_c")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.FPointH)
                    .HasColumnName("F_point_h")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.FScoreC)
                    .HasColumnName("F_score_c")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.FScoreH)
                    .HasColumnName("F_score_h")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.FStatus)
                    .HasColumnName("F_status")
                    .HasMaxLength(50);

                entity.Property(e => e.Gid).HasColumnName("gid");

                entity.Property(e => e.Gidm).HasColumnName("gidm");

                entity.Property(e => e.GunmC).HasColumnName("gunm_c");

                entity.Property(e => e.GunmH).HasColumnName("gunm_h");

                entity.Property(e => e.HPointC)
                    .HasColumnName("h_point_c")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.HPointH)
                    .HasColumnName("h_point_h")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.HScoreC)
                    .HasColumnName("h_score_c")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.HScoreH)
                    .HasColumnName("h_score_h")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.HSettlement)
                    .HasColumnName("hSettlement")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Hot)
                    .HasColumnName("hot")
                    .HasMaxLength(10);

                entity.Property(e => e.IsCancel)
                    .HasColumnName("isCancel")
                    .HasMaxLength(20);

                entity.Property(e => e.IsColse)
                    .HasColumnName("isColse")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.IsEnable)
                    .HasColumnName("isEnable")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.IsEnable2).HasColumnName("isEnable2");

                entity.Property(e => e.IsShowGq)
                    .HasColumnName("IsShowGQ")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.IshowWeb)
                    .HasColumnName("ishowWeb")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.LastUpdateTime)
                    .HasColumnName("lastUpdateTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.League)
                    .HasColumnName("league")
                    .HasMaxLength(200);

                entity.Property(e => e.More)
                    .HasColumnName("more")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Play)
                    .HasColumnName("play")
                    .HasMaxLength(10);

                entity.Property(e => e.ScoreC)
                    .HasColumnName("score_c")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ScoreH)
                    .HasColumnName("score_h")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ShowScoreC)
                    .HasColumnName("showScore_C")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ShowScoreH)
                    .HasColumnName("showScore_H")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Status).HasMaxLength(50);

                entity.Property(e => e.Strong)
                    .HasColumnName("strong")
                    .HasMaxLength(10);

                entity.Property(e => e.TeamC)
                    .HasColumnName("team_c")
                    .HasMaxLength(200);

                entity.Property(e => e.TeamH)
                    .HasColumnName("team_h")
                    .HasMaxLength(200);

                entity.Property(e => e.Time).HasColumnName("time");
            });

            modelBuilder.Entity<TbMatchResult>(entity =>
            {
                entity.HasKey(e => new { e.Gid, e.Type })
                    .HasName("PK_tbMatchResult_GID_Type");

                entity.ToTable("tbMatchResult");

                entity.Property(e => e.Gid).HasColumnName("gid");

                entity.Property(e => e.Phase10C).HasColumnName("Phase10_c");

                entity.Property(e => e.Phase10H).HasColumnName("Phase10_h");

                entity.Property(e => e.Phase1C).HasColumnName("Phase1_c");

                entity.Property(e => e.Phase1H).HasColumnName("Phase1_h");

                entity.Property(e => e.Phase2C).HasColumnName("Phase2_c");

                entity.Property(e => e.Phase2H).HasColumnName("Phase2_h");

                entity.Property(e => e.Phase3C).HasColumnName("Phase3_c");

                entity.Property(e => e.Phase3H).HasColumnName("Phase3_h");

                entity.Property(e => e.Phase4C).HasColumnName("Phase4_c");

                entity.Property(e => e.Phase4H).HasColumnName("Phase4_h");

                entity.Property(e => e.Phase5C).HasColumnName("Phase5_c");

                entity.Property(e => e.Phase5H).HasColumnName("Phase5_h");

                entity.Property(e => e.Phase6C).HasColumnName("Phase6_c");

                entity.Property(e => e.Phase6H).HasColumnName("Phase6_h");

                entity.Property(e => e.Phase7C).HasColumnName("Phase7_c");

                entity.Property(e => e.Phase7H).HasColumnName("Phase7_h");

                entity.Property(e => e.Phase8C).HasColumnName("Phase8_c");

                entity.Property(e => e.Phase8H).HasColumnName("Phase8_h");

                entity.Property(e => e.Phase9C).HasColumnName("Phase9_c");

                entity.Property(e => e.Phase9H).HasColumnName("Phase9_h");
            });

            modelBuilder.Entity<TbMatchRq>(entity =>
            {
                entity.HasKey(e => new { e.Gid, e.Type })
                    .HasName("PK_tbMatchRQ_GID_Type");

                entity.ToTable("tbMatchRQ");

                entity.Property(e => e.Gid).HasColumnName("gid");

                entity.Property(e => e.Hratio)
                    .HasColumnName("hratio")
                    .HasMaxLength(20);

                entity.Property(e => e.IorHrc).HasColumnName("ior_HRC");

                entity.Property(e => e.IorHrh).HasColumnName("ior_HRH");

                entity.Property(e => e.IorRc).HasColumnName("ior_RC");

                entity.Property(e => e.IorRh).HasColumnName("ior_RH");

                entity.Property(e => e.Ratio)
                    .HasColumnName("ratio")
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<TbMatchZhgg>(entity =>
            {
                entity.HasKey(e => new { e.Gid, e.Type })
                    .HasName("PK_tbMatchZHGG_GID_Type");

                entity.ToTable("tbMatchZHGG");

                entity.Property(e => e.Gid).HasColumnName("gid");

                entity.Property(e => e.HratioOp)
                    .HasColumnName("hratio_op")
                    .HasMaxLength(20);

                entity.Property(e => e.HratioP)
                    .HasColumnName("hratio_p")
                    .HasMaxLength(20);

                entity.Property(e => e.HratioUp)
                    .HasColumnName("hratio_up")
                    .HasMaxLength(20);

                entity.Property(e => e.IorHmcp).HasColumnName("ior_HMCP");

                entity.Property(e => e.IorHmhp).HasColumnName("ior_HMHP");

                entity.Property(e => e.IorHmnp).HasColumnName("ior_HMNP");

                entity.Property(e => e.IorHpouc).HasColumnName("ior_HPOUC");

                entity.Property(e => e.IorHpouh).HasColumnName("ior_HPOUH");

                entity.Property(e => e.IorHprc).HasColumnName("ior_HPRC");

                entity.Property(e => e.IorHprh).HasColumnName("ior_HPRH");

                entity.Property(e => e.IorMcp).HasColumnName("ior_MCP");

                entity.Property(e => e.IorMhp).HasColumnName("ior_MHP");

                entity.Property(e => e.IorMnp).HasColumnName("ior_MNP");

                entity.Property(e => e.IorPe).HasColumnName("ior_PE");

                entity.Property(e => e.IorPeoe).HasColumnName("ior_PEOE");

                entity.Property(e => e.IorPeoo).HasColumnName("ior_PEOO");

                entity.Property(e => e.IorPo).HasColumnName("ior_PO");

                entity.Property(e => e.IorPouc).HasColumnName("ior_POUC");

                entity.Property(e => e.IorPouco).HasColumnName("ior_POUCO");

                entity.Property(e => e.IorPoucu).HasColumnName("ior_POUCU");

                entity.Property(e => e.IorPouh).HasColumnName("ior_POUH");

                entity.Property(e => e.IorPouho).HasColumnName("ior_POUHO");

                entity.Property(e => e.IorPouhu).HasColumnName("ior_POUHU");

                entity.Property(e => e.IorPrc).HasColumnName("ior_PRC");

                entity.Property(e => e.IorPrh).HasColumnName("ior_PRH");

                entity.Property(e => e.LastUpdateTime)
                    .HasColumnName("lastUpdateTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.MoreP).HasColumnName("more_P");

                entity.Property(e => e.RatioOp)
                    .HasColumnName("ratio_op")
                    .HasMaxLength(20);

                entity.Property(e => e.RatioP)
                    .HasColumnName("ratio_P")
                    .HasMaxLength(20);

                entity.Property(e => e.RatioPouco)
                    .HasColumnName("ratio_pouco")
                    .HasMaxLength(20);

                entity.Property(e => e.RatioPoucu)
                    .HasColumnName("ratio_poucu")
                    .HasMaxLength(20);

                entity.Property(e => e.RatioPouho)
                    .HasColumnName("ratio_pouho")
                    .HasMaxLength(20);

                entity.Property(e => e.RatioPouhu)
                    .HasColumnName("ratio_pouhu")
                    .HasMaxLength(20);

                entity.Property(e => e.RatioUp)
                    .HasColumnName("ratio_up")
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<TbMatchZrq>(entity =>
            {
                entity.HasKey(e => new { e.Gid, e.Type })
                    .HasName("PK_tbMatchZRQ_GID_Type");

                entity.ToTable("tbMatchZRQ");

                entity.Property(e => e.Gid).HasColumnName("gid");

                entity.Property(e => e.IorEven).HasColumnName("ior_EVEN");

                entity.Property(e => e.IorOdd).HasColumnName("ior_ODD");

                entity.Property(e => e.IorOver).HasColumnName("ior_OVER");

                entity.Property(e => e.IorT01).HasColumnName("ior_T01");

                entity.Property(e => e.IorT23).HasColumnName("ior_T23");

                entity.Property(e => e.IorT46).HasColumnName("ior_T46");

                entity.Property(e => e.LastUpdateTime)
                    .HasColumnName("lastUpdateTime")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<Tblo>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tblo");

                entity.Property(e => e.HroupName)
                    .HasColumnName("hroupName")
                    .HasMaxLength(40);

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.LotteryName)
                    .HasColumnName("lotteryName")
                    .HasMaxLength(30);

                entity.Property(e => e.OddsName)
                    .HasColumnName("oddsName")
                    .HasMaxLength(40);

                entity.Property(e => e.PointsOdds).HasColumnName("points_Odds");

                entity.Property(e => e.ShowIndex).HasColumnName("showIndex");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasMaxLength(30);
            });

            modelBuilder.Entity<TmpTbLotteryOdds>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tmp_tbLotteryOdds");

                entity.Property(e => e.HroupName)
                    .HasColumnName("hroupName")
                    .HasMaxLength(40);

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.LotteryName)
                    .HasColumnName("lotteryName")
                    .HasMaxLength(30);

                entity.Property(e => e.OddsName)
                    .HasColumnName("oddsName")
                    .HasMaxLength(40);

                entity.Property(e => e.PointsOdds).HasColumnName("points_Odds");

                entity.Property(e => e.ShowIndex).HasColumnName("showIndex");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasMaxLength(30);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
