using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace CoreTest.Entity.Models
{
    public partial class GamblingContext : DbContext
    {
        public GamblingContext()
        {
        }

        public GamblingContext(DbContextOptions<GamblingContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AbBetdetail> AbBetdetail { get; set; }
        public virtual DbSet<AdminPageVisit> AdminPageVisit { get; set; }
        public virtual DbSet<AgBetdetail> AgBetdetail { get; set; }
        public virtual DbSet<Agent> Agent { get; set; }
        public virtual DbSet<AgentDayReport> AgentDayReport { get; set; }
        public virtual DbSet<AgentMouthReport> AgentMouthReport { get; set; }
        public virtual DbSet<ApibbetAgsport> ApibbetAgsport { get; set; }
        public virtual DbSet<ApibbetDayMemberReport> ApibbetDayMemberReport { get; set; }
        public virtual DbSet<ApibbetDayMemberReport20170521after> ApibbetDayMemberReport20170521after { get; set; }
        public virtual DbSet<ApibbetDayMemberReport20170521before> ApibbetDayMemberReport20170521before { get; set; }
        public virtual DbSet<ApibbetFileList> ApibbetFileList { get; set; }
        public virtual DbSet<ApibbetSync> ApibbetSync { get; set; }
        public virtual DbSet<ApibbetUserData> ApibbetUserData { get; set; }
        public virtual DbSet<ApibbetUserDataEx> ApibbetUserDataEx { get; set; }
        public virtual DbSet<ApibbetVideoGameType> ApibbetVideoGameType { get; set; }
        public virtual DbSet<AppOrderAll> AppOrderAll { get; set; }
        public virtual DbSet<AppSetting> AppSetting { get; set; }
        public virtual DbSet<AppSettingLog> AppSettingLog { get; set; }
        public virtual DbSet<AsyncSetting> AsyncSetting { get; set; }
        public virtual DbSet<Bak20190701FinanceAccess> Bak20190701FinanceAccess { get; set; }
        public virtual DbSet<Bak20190701Financebak> Bak20190701Financebak { get; set; }
        public virtual DbSet<Bak20190701Financetmp> Bak20190701Financetmp { get; set; }
        public virtual DbSet<Bak20190701VideoGameTransferLog> Bak20190701VideoGameTransferLog { get; set; }
        public virtual DbSet<BakFinanceAccess20181015> BakFinanceAccess20181015 { get; set; }
        public virtual DbSet<BakFinancebak20181015> BakFinancebak20181015 { get; set; }
        public virtual DbSet<BakFinancetmp20181015> BakFinancetmp20181015 { get; set; }
        public virtual DbSet<BakVideoGameTransferLog20181015> BakVideoGameTransferLog20181015 { get; set; }
        public virtual DbSet<BallReport> BallReport { get; set; }
        public virtual DbSet<BankMapping> BankMapping { get; set; }
        public virtual DbSet<BbBetdetail> BbBetdetail { get; set; }
        public virtual DbSet<CspsettlementLog> CspsettlementLog { get; set; }
        public virtual DbSet<CttraceDetailView> CttraceDetailView { get; set; }
        public virtual DbSet<CttraceSummaryView> CttraceSummaryView { get; set; }
        public virtual DbSet<DaiFuSetting> DaiFuSetting { get; set; }
        public virtual DbSet<DaiFuSettingTemp> DaiFuSettingTemp { get; set; }
        public virtual DbSet<DayReportTotalFinance> DayReportTotalFinance { get; set; }
        public virtual DbSet<DayReportUserFinance> DayReportUserFinance { get; set; }
        public virtual DbSet<DepositClass> DepositClass { get; set; }
        public virtual DbSet<DonlinePay> DonlinePay { get; set; }
        public virtual DbSet<FarbudItems> FarbudItems { get; set; }
        public virtual DbSet<Finance> Finance { get; set; }
        public virtual DbSet<FinanceAccess> FinanceAccess { get; set; }
        public virtual DbSet<FinanceAccessAsync> FinanceAccessAsync { get; set; }
        public virtual DbSet<FinanceAccessDaifuView> FinanceAccessDaifuView { get; set; }
        public virtual DbSet<FinanceAccessExt> FinanceAccessExt { get; set; }
        public virtual DbSet<FinanceAccessExtView> FinanceAccessExtView { get; set; }
        public virtual DbSet<FinanceAccessExtView2> FinanceAccessExtView2 { get; set; }
        public virtual DbSet<FinanceAccessUserView> FinanceAccessUserView { get; set; }
        public virtual DbSet<FinanceAccessUserViewSaved> FinanceAccessUserViewSaved { get; set; }
        public virtual DbSet<FinanceAsync> FinanceAsync { get; set; }
        public virtual DbSet<FinanceHisReport> FinanceHisReport { get; set; }
        public virtual DbSet<FinanceRemittance> FinanceRemittance { get; set; }
        public virtual DbSet<FinanceReport> FinanceReport { get; set; }
        public virtual DbSet<FinanceSum> FinanceSum { get; set; }
        public virtual DbSet<Financebak> Financebak { get; set; }
        public virtual DbSet<Financetmp> Financetmp { get; set; }
        public virtual DbSet<Financetmp1> Financetmp1 { get; set; }
        public virtual DbSet<GameDataFile> GameDataFile { get; set; }
        public virtual DbSet<GenerateCode> GenerateCode { get; set; }
        public virtual DbSet<GqchangeLog> GqchangeLog { get; set; }
        public virtual DbSet<GqcheckLog> GqcheckLog { get; set; }
        public virtual DbSet<GroupOrder> GroupOrder { get; set; }
        public virtual DbSet<GroupOrder2> GroupOrder2 { get; set; }
        public virtual DbSet<GroupOrderAsync> GroupOrderAsync { get; set; }
        public virtual DbSet<GroupOrderView> GroupOrderView { get; set; }
        public virtual DbSet<Hongbao> Hongbao { get; set; }
        public virtual DbSet<Hongbaoview> Hongbaoview { get; set; }
        public virtual DbSet<Iplog> Iplog { get; set; }
        public virtual DbSet<Ipsource> Ipsource { get; set; }
        public virtual DbSet<LotteryItemsView> LotteryItemsView { get; set; }
        public virtual DbSet<LotteryOrderPrizeview> LotteryOrderPrizeview { get; set; }
        public virtual DbSet<MaintenancePlan> MaintenancePlan { get; set; }
        public virtual DbSet<MenuInit> MenuInit { get; set; }
        public virtual DbSet<MessageQueue> MessageQueue { get; set; }
        public virtual DbSet<MonitoringAlarmMessage> MonitoringAlarmMessage { get; set; }
        public virtual DbSet<News> News { get; set; }
        public virtual DbSet<NewsApply> NewsApply { get; set; }
        public virtual DbSet<NewsApplyOrder> NewsApplyOrder { get; set; }
        public virtual DbSet<NewsApplyOrderDetail> NewsApplyOrderDetail { get; set; }
        public virtual DbSet<NewsType> NewsType { get; set; }
        public virtual DbSet<OnlinePlay> OnlinePlay { get; set; }
        public virtual DbSet<OptSettlementLog> OptSettlementLog { get; set; }
        public virtual DbSet<Order> Order { get; set; }
        public virtual DbSet<Order3> Order3 { get; set; }
        public virtual DbSet<OrderAll> OrderAll { get; set; }
        public virtual DbSet<OrderAsync> OrderAsync { get; set; }
        public virtual DbSet<OrderBakTo20150101> OrderBakTo20150101 { get; set; }
        public virtual DbSet<OrderCsp> OrderCsp { get; set; }
        public virtual DbSet<OrderOriginal> OrderOriginal { get; set; }
        public virtual DbSet<PayCodeTypeSetting> PayCodeTypeSetting { get; set; }
        public virtual DbSet<PaySetting> PaySetting { get; set; }
        public virtual DbSet<PayTypeSetting> PayTypeSetting { get; set; }
        public virtual DbSet<PlayThreshold> PlayThreshold { get; set; }
        public virtual DbSet<PopupWindow> PopupWindow { get; set; }
        public virtual DbSet<PtBetdetail> PtBetdetail { get; set; }
        public virtual DbSet<PwdChanged> PwdChanged { get; set; }
        public virtual DbSet<RedEnvelope> RedEnvelope { get; set; }
        public virtual DbSet<RedEnvelopeConfig> RedEnvelopeConfig { get; set; }
        public virtual DbSet<RedEnvelopeConfigMoney> RedEnvelopeConfigMoney { get; set; }
        public virtual DbSet<RedEnvelopeDefault> RedEnvelopeDefault { get; set; }
        public virtual DbSet<RedEnvelopeLevelSetting> RedEnvelopeLevelSetting { get; set; }
        public virtual DbSet<RedEnvelopePrize> RedEnvelopePrize { get; set; }
        public virtual DbSet<RedEnvelopeSetting> RedEnvelopeSetting { get; set; }
        public virtual DbSet<RemittanceSetting> RemittanceSetting { get; set; }
        public virtual DbSet<RoleAuthMap> RoleAuthMap { get; set; }
        public virtual DbSet<RoleManage> RoleManage { get; set; }
        public virtual DbSet<Roles> Roles { get; set; }
        public virtual DbSet<SavedSetting> SavedSetting { get; set; }
        public virtual DbSet<SetMessage> SetMessage { get; set; }
        public virtual DbSet<SettlementJob> SettlementJob { get; set; }
        public virtual DbSet<SettlementLog> SettlementLog { get; set; }
        public virtual DbSet<SettlementLog2> SettlementLog2 { get; set; }
        public virtual DbSet<Sheet11> Sheet11 { get; set; }
        public virtual DbSet<ShengXiaoMaping> ShengXiaoMaping { get; set; }
        public virtual DbSet<SiteInfo> SiteInfo { get; set; }
        public virtual DbSet<SiteInfo1> SiteInfo1 { get; set; }
        public virtual DbSet<SiteLog> SiteLog { get; set; }
        public virtual DbSet<SlidingVerifyLog> SlidingVerifyLog { get; set; }
        public virtual DbSet<Suggest> Suggest { get; set; }
        public virtual DbSet<SysLog> SysLog { get; set; }
        public virtual DbSet<SysLogAsync> SysLogAsync { get; set; }
        public virtual DbSet<SysUser> SysUser { get; set; }
        public virtual DbSet<TbLotteryOrderItems> TbLotteryOrderItems { get; set; }
        public virtual DbSet<TbLotteryOrderItemsAsync> TbLotteryOrderItemsAsync { get; set; }
        public virtual DbSet<TbLotteryOrderItemsBakTo20150101> TbLotteryOrderItemsBakTo20150101 { get; set; }
        public virtual DbSet<TbLotteryOrderItemsOriginal> TbLotteryOrderItemsOriginal { get; set; }
        public virtual DbSet<TbLotteryOrders> TbLotteryOrders { get; set; }
        public virtual DbSet<TbLotteryOrdersAsync> TbLotteryOrdersAsync { get; set; }
        public virtual DbSet<TbLotteryOrdersBakTo20150101> TbLotteryOrdersBakTo20150101 { get; set; }
        public virtual DbSet<TbLotteryOrdersOriginal> TbLotteryOrdersOriginal { get; set; }
        public virtual DbSet<TbLotteryReport> TbLotteryReport { get; set; }
        public virtual DbSet<TbLotterySettlementLog> TbLotterySettlementLog { get; set; }
        public virtual DbSet<TeamTmp> TeamTmp { get; set; }
        public virtual DbSet<Test2> Test2 { get; set; }
        public virtual DbSet<TySettlementqueue> TySettlementqueue { get; set; }
        public virtual DbSet<UpgradeLog> UpgradeLog { get; set; }
        public virtual DbSet<UpgradeMonthMoney> UpgradeMonthMoney { get; set; }
        public virtual DbSet<User> User { get; set; }
        public virtual DbSet<User1> User1 { get; set; }
        public virtual DbSet<User2> User2 { get; set; }
        public virtual DbSet<UserAsync> UserAsync { get; set; }
        public virtual DbSet<UserBalance> UserBalance { get; set; }
        public virtual DbSet<UserDayFinanceReport> UserDayFinanceReport { get; set; }
        public virtual DbSet<UserExtensions> UserExtensions { get; set; }
        public virtual DbSet<UserFinance> UserFinance { get; set; }
        public virtual DbSet<UserFinanceReport> UserFinanceReport { get; set; }
        public virtual DbSet<UserFinanceSaved> UserFinanceSaved { get; set; }
        public virtual DbSet<UserIntegral> UserIntegral { get; set; }
        public virtual DbSet<UserIntegralInfo> UserIntegralInfo { get; set; }
        public virtual DbSet<UserLevelPaySetting> UserLevelPaySetting { get; set; }
        public virtual DbSet<UserLever> UserLever { get; set; }
        public virtual DbSet<UserLeverLimitSetting> UserLeverLimitSetting { get; set; }
        public virtual DbSet<UserLoginCount> UserLoginCount { get; set; }
        public virtual DbSet<UserMonthReportByAgent> UserMonthReportByAgent { get; set; }
        public virtual DbSet<UserSetting> UserSetting { get; set; }
        public virtual DbSet<UserSignLog> UserSignLog { get; set; }
        public virtual DbSet<UserUpdateLog> UserUpdateLog { get; set; }
        public virtual DbSet<UserVedioGameDayReport> UserVedioGameDayReport { get; set; }
        public virtual DbSet<Userbak20190528> Userbak20190528 { get; set; }
        public virtual DbSet<Users> Users { get; set; }
        public virtual DbSet<UsersRolesMap> UsersRolesMap { get; set; }
        public virtual DbSet<VAgentUser> VAgentUser { get; set; }
        public virtual DbSet<VApibbetUserData> VApibbetUserData { get; set; }
        public virtual DbSet<VApibbetUserDataEx> VApibbetUserDataEx { get; set; }
        public virtual DbSet<VApibbetUserDataExByProvider> VApibbetUserDataExByProvider { get; set; }
        public virtual DbSet<VUpdateUserVedioGameDayReport> VUpdateUserVedioGameDayReport { get; set; }
        public virtual DbSet<VUser> VUser { get; set; }
        public virtual DbSet<VedioGameDayReport> VedioGameDayReport { get; set; }
        public virtual DbSet<VideoGameTransferLog> VideoGameTransferLog { get; set; }
        public virtual DbSet<VideoGameTransferLogAsync> VideoGameTransferLogAsync { get; set; }
        public virtual DbSet<VipMonthMoneyEveryMonthTable> VipMonthMoneyEveryMonthTable { get; set; }
        public virtual DbSet<VipSetting> VipSetting { get; set; }
        public virtual DbSet<VipSignMoney> VipSignMoney { get; set; }
        public virtual DbSet<VipinputEffectMoneyTotal> VipinputEffectMoneyTotal { get; set; }
        public virtual DbSet<VipinputEffectMoneyTotalHistory> VipinputEffectMoneyTotalHistory { get; set; }
        public virtual DbSet<WalletFinance> WalletFinance { get; set; }
        public virtual DbSet<WalletFinanceOptLog> WalletFinanceOptLog { get; set; }
        public virtual DbSet<Wheel> Wheel { get; set; }
        public virtual DbSet<WheelConfig> WheelConfig { get; set; }
        public virtual DbSet<WheelPrize> WheelPrize { get; set; }
        public virtual DbSet<WheelPrizeRecord> WheelPrizeRecord { get; set; }
        public virtual DbSet<WheelReport> WheelReport { get; set; }
        public virtual DbSet<WheelRules> WheelRules { get; set; }
        public virtual DbSet<WheelRulesRecord> WheelRulesRecord { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=Gambling;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AbBetdetail>(entity =>
            {
                entity.HasKey(e => e.Betnum);

                entity.ToTable("ab_betdetail");

                entity.Property(e => e.Betnum)
                    .HasColumnName("betnum")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.AgentSite)
                    .HasColumnName("agent_site")
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.Betamount)
                    .HasColumnName("betamount")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Bettime)
                    .HasColumnName("bettime")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Bettype)
                    .HasColumnName("bettype")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Client)
                    .HasColumnName("client")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Commission)
                    .HasColumnName("commission")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.CreateTime)
                    .HasColumnName("create_time")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Currency)
                    .HasColumnName("currency")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Exchangerate)
                    .HasColumnName("exchangerate")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Gameresult)
                    .HasColumnName("gameresult")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Gameroundendtime)
                    .HasColumnName("gameroundendtime")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Gameroundid)
                    .HasColumnName("gameroundid")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Gameroundstarttime)
                    .HasColumnName("gameroundstarttime")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Gametype)
                    .HasColumnName("gametype")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.MemberAccount)
                    .HasColumnName("member_account")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.State)
                    .HasColumnName("state")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Tablename)
                    .HasColumnName("tablename")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Validamount)
                    .HasColumnName("validamount")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Winorloss)
                    .HasColumnName("winorloss")
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AdminPageVisit>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.PageCount).HasColumnName("pageCount");

                entity.Property(e => e.PageUrl)
                    .HasColumnName("pageUrl")
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.SiteName)
                    .HasColumnName("siteName")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AgBetdetail>(entity =>
            {
                entity.HasKey(e => e.Billno);

                entity.ToTable("ag_betdetail");

                entity.Property(e => e.Billno)
                    .HasColumnName("billno")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.AgentSite)
                    .HasColumnName("agent_site")
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.Agentcode)
                    .HasColumnName("agentcode")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Betamount)
                    .HasColumnName("betamount")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Bettime)
                    .IsRequired()
                    .HasColumnName("bettime")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Currency)
                    .HasColumnName("currency")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Filename)
                    .IsRequired()
                    .HasColumnName("filename")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Flag)
                    .HasColumnName("flag")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Gamecode)
                    .HasColumnName("gamecode")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Gametype)
                    .HasColumnName("gametype")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Loginip)
                    .HasColumnName("loginip")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Mainbillno)
                    .HasColumnName("mainbillno")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.MemberAccount)
                    .HasColumnName("member_account")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Netamount)
                    .HasColumnName("netamount")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Platformid)
                    .HasColumnName("platformid")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Platformtype)
                    .HasColumnName("platformtype")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Playername)
                    .IsRequired()
                    .HasColumnName("playername")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Playtype)
                    .HasColumnName("playtype")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Recalcutime)
                    .HasColumnName("recalcutime")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Remark)
                    .HasColumnName("remark")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Result)
                    .HasColumnName("result")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Round)
                    .HasColumnName("round")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Slottype)
                    .HasColumnName("slottype")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Stringex)
                    .HasColumnName("stringex")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.SyncTime)
                    .IsRequired()
                    .HasColumnName("sync_time")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Tablecode)
                    .HasColumnName("tablecode")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Validbetamount)
                    .HasColumnName("validbetamount")
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Agent>(entity =>
            {
                entity.HasKey(e => e.LoginName);

                entity.ToTable("agent");

                entity.Property(e => e.LoginName)
                    .HasColumnName("loginName")
                    .HasMaxLength(50)
                    .HasComment("用户名");

                entity.Property(e => e.Aggame)
                    .HasColumnName("AGGame")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.Agvedio)
                    .HasColumnName("AGVedio")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.Allbetgame)
                    .HasColumnName("ALLBETGame")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.Allbetvedio)
                    .HasColumnName("ALLBETVedio")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.BankCrad)
                    .HasColumnName("bankCrad")
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Bbingame)
                    .HasColumnName("BBINGame")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.Bbinlottery)
                    .HasColumnName("BBINLottery")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.Bbinsport)
                    .HasColumnName("BBINSport")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.Bbinvedio)
                    .HasColumnName("BBINVedio")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.BollSet)
                    .HasColumnName("bollSet")
                    .HasComment("球类反水设置");

                entity.Property(e => e.CpJiesuanKind).HasColumnName("cp_jiesuan_kind");

                entity.Property(e => e.CradPwd)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Createtime)
                    .HasColumnName("createtime")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Dj)
                    .HasColumnName("DJ")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.Domain)
                    .HasColumnName("domain")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.Dsvedio)
                    .HasColumnName("DSVedio")
                    .HasColumnType("decimal(18, 5)");

                entity.Property(e => e.EnableAggame)
                    .HasColumnName("EnableAGGame")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.EnableAgvedio)
                    .HasColumnName("EnableAGVedio")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.EnableAllbetgame)
                    .HasColumnName("EnableALLBETGame")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.EnableAllbetvedio)
                    .HasColumnName("EnableALLBETVedio")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.EnableBbingame)
                    .HasColumnName("EnableBBINGame")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.EnableBbinlottery)
                    .HasColumnName("EnableBBINLottery")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.EnableBbinsport)
                    .HasColumnName("EnableBBINSport")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.EnableBbinvedio)
                    .HasColumnName("EnableBBINVedio")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.EnableDj).HasColumnName("EnableDJ");

                entity.Property(e => e.EnableDsvedio).HasColumnName("EnableDSVedio");

                entity.Property(e => e.EnableHggame)
                    .HasColumnName("EnableHGGame")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.EnableHgvedio)
                    .HasColumnName("EnableHGVedio")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.EnableLhc)
                    .HasColumnName("EnableLHC")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.EnableLottery).HasDefaultValueSql("((0))");

                entity.Property(e => e.EnableMggame).HasColumnName("EnableMGGame");

                entity.Property(e => e.EnableMgvedio).HasColumnName("EnableMGVedio");

                entity.Property(e => e.EnableOgvedio).HasColumnName("EnableOGVedio");

                entity.Property(e => e.EnablePlaytechgame)
                    .HasColumnName("EnablePLAYTECHGame")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.EnablePlaytechvedio)
                    .HasColumnName("EnablePLAYTECHVedio")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.EnableSport).HasDefaultValueSql("((0))");

                entity.Property(e => e.Fanshuirate).HasColumnName("fanshuirate");

                entity.Property(e => e.FootBallFazhi).HasColumnName("footBallFazhi");

                entity.Property(e => e.GameJiesuanKind).HasColumnName("game_jiesuan_kind");

                entity.Property(e => e.Hggame)
                    .HasColumnName("HGGame")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.Hgvedio)
                    .HasColumnName("HGVedio")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.Jiesuan)
                    .HasColumnName("jiesuan")
                    .HasMaxLength(50);

                entity.Property(e => e.LasgLoginDate).HasColumnType("datetime");

                entity.Property(e => e.LastLoginIp).HasMaxLength(30);

                entity.Property(e => e.Lhc)
                    .HasColumnName("LHC")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.LiuheJiesuanKind).HasColumnName("liuhe_jiesuan_kind");

                entity.Property(e => e.LoginNameGroup)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Lottery).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.LotterySet)
                    .HasColumnName("lotterySet")
                    .HasComment("彩票反水设置");

                entity.Property(e => e.Mggame)
                    .HasColumnName("MGGame")
                    .HasColumnType("decimal(18, 5)");

                entity.Property(e => e.Mgvedio)
                    .HasColumnName("MGVedio")
                    .HasColumnType("decimal(18, 5)");

                entity.Property(e => e.Ogvedio)
                    .HasColumnName("OGVedio")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.OpenBank)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Phone)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Playtechgame)
                    .HasColumnName("PLAYTECHGame")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.Playtechvedio)
                    .HasColumnName("PLAYTECHVedio")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.Pwd)
                    .HasColumnName("pwd")
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.RegisterIp)
                    .HasColumnName("registerIp")
                    .HasMaxLength(30);

                entity.Property(e => e.Remark)
                    .HasColumnName("remark")
                    .HasMaxLength(200);

                entity.Property(e => e.Sport).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.SportJiesuanKind).HasColumnName("sport_jiesuan_kind");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasMaxLength(50)
                    .HasComment("状态（通过，拒绝，待处理）");

                entity.Property(e => e.UserGroup)
                    .HasColumnName("userGroup")
                    .HasMaxLength(50);

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.VedioGameSet).HasColumnName("vedioGameSet");
            });

            modelBuilder.Entity<AgentDayReport>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AgentName).HasMaxLength(50);

                entity.Property(e => e.BallResultAmount)
                    .HasColumnName("ballResultAmount")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.BallSet).HasColumnName("ballSet");

                entity.Property(e => e.BallSetAmount)
                    .HasColumnName("ballSetAmount")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Ballamount)
                    .HasColumnName("ballamount")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.GainAmount)
                    .HasColumnName("gainAmount")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.GameBetamount)
                    .HasColumnName("gameBetamount")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.GameValidamount)
                    .HasColumnName("gameValidamount")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Gameset)
                    .HasColumnName("gameset")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.LotteryResultAmount)
                    .HasColumnName("lotteryResultAmount")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.LotterySet).HasColumnName("lotterySet");

                entity.Property(e => e.LotterySetAmount)
                    .HasColumnName("lotterySetAmount")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Lotteryamount)
                    .HasColumnName("lotteryamount")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.SumSetAmount)
                    .HasColumnName("sumSetAmount")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Sumamount)
                    .HasColumnName("sumamount")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.YouxiaoAmount)
                    .HasColumnName("youxiaoAmount")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.YouxiaoAmount2)
                    .HasColumnName("youxiaoAmount2")
                    .HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<AgentMouthReport>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AgentName).HasMaxLength(50);

                entity.Property(e => e.BallResultAmount)
                    .HasColumnName("ballResultAmount")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.BallSetAmount)
                    .HasColumnName("ballSetAmount")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Ballamount)
                    .HasColumnName("ballamount")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.GainAmount)
                    .HasColumnName("gainAmount")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.GameBetamount)
                    .HasColumnName("gameBetamount")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.GameValidamount)
                    .HasColumnName("gameValidamount")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Gameset)
                    .HasColumnName("gameset")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.LotteryResultAmount)
                    .HasColumnName("lotteryResultAmount")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.LotterySetAmount)
                    .HasColumnName("lotterySetAmount")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Lotteryamount)
                    .HasColumnName("lotteryamount")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.SumSetAmount)
                    .HasColumnName("sumSetAmount")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Sumamount)
                    .HasColumnName("sumamount")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.YouxiaoAmount)
                    .HasColumnName("youxiaoAmount")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.YouxiaoAmount2)
                    .HasColumnName("youxiaoAmount2")
                    .HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<ApibbetAgsport>(entity =>
            {
                entity.ToTable("ApibbetAGSport");

                entity.HasIndex(e => new { e.Billno, e.Playername, e.Rtime })
                    .HasName("ApibbetAGSport_Index");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Betamount)
                    .HasColumnName("betamount")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Bettime)
                    .HasColumnName("bettime")
                    .HasColumnType("datetime");

                entity.Property(e => e.Billno)
                    .IsRequired()
                    .HasColumnName("billno")
                    .HasMaxLength(50);

                entity.Property(e => e.Category)
                    .HasColumnName("category")
                    .HasMaxLength(500);

                entity.Property(e => e.Competition)
                    .HasColumnName("competition")
                    .HasMaxLength(500);

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.Currency)
                    .HasColumnName("currency")
                    .HasMaxLength(50);

                entity.Property(e => e.Currentscore)
                    .HasColumnName("currentscore")
                    .HasMaxLength(50);

                entity.Property(e => e.Ext1).HasMaxLength(10);

                entity.Property(e => e.Ext2).HasMaxLength(50);

                entity.Property(e => e.Flag)
                    .HasColumnName("flag")
                    .HasMaxLength(10);

                entity.Property(e => e.Gametype)
                    .HasColumnName("gametype")
                    .HasMaxLength(50);

                entity.Property(e => e.Live)
                    .HasColumnName("live")
                    .HasMaxLength(10);

                entity.Property(e => e.Loginip)
                    .HasColumnName("loginip")
                    .HasMaxLength(50);

                entity.Property(e => e.Market)
                    .HasColumnName("market")
                    .HasMaxLength(500);

                entity.Property(e => e.Netamount)
                    .HasColumnName("netamount")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Odds)
                    .HasColumnName("odds")
                    .HasMaxLength(500);

                entity.Property(e => e.Platformtype)
                    .HasColumnName("platformtype")
                    .HasMaxLength(50);

                entity.Property(e => e.Playername)
                    .HasColumnName("playername")
                    .HasMaxLength(50);

                entity.Property(e => e.Playtype)
                    .HasColumnName("playtype")
                    .HasMaxLength(10);

                entity.Property(e => e.Provider)
                    .HasColumnName("provider")
                    .HasMaxLength(50);

                entity.Property(e => e.Racalcutime)
                    .HasColumnName("racalcutime")
                    .HasColumnType("datetime");

                entity.Property(e => e.Rtime)
                    .HasColumnName("rtime")
                    .HasColumnType("datetime");

                entity.Property(e => e.Selection)
                    .HasColumnName("selection")
                    .HasMaxLength(500);

                entity.Property(e => e.Simplifiedresult)
                    .HasColumnName("simplifiedresult")
                    .HasMaxLength(500);

                entity.Property(e => e.Sport)
                    .HasColumnName("sport")
                    .HasMaxLength(500);

                entity.Property(e => e.SyncTime)
                    .HasColumnName("syncTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.Validbetamount)
                    .HasColumnName("validbetamount")
                    .HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<ApibbetDayMemberReport>(entity =>
            {
                entity.HasKey(e => e.RakebackId);

                entity.ToTable("Apibbet_Day_Member_Report");

                entity.Property(e => e.RakebackId).HasColumnName("rakeback_id");

                entity.Property(e => e.AgentSite)
                    .HasColumnName("agent_site")
                    .HasMaxLength(256);

                entity.Property(e => e.Betamount)
                    .HasColumnName("betamount")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CalcDate)
                    .HasColumnName("calc_date")
                    .HasMaxLength(50);

                entity.Property(e => e.CreateTime)
                    .HasColumnName("create_time")
                    .HasColumnType("datetime");

                entity.Property(e => e.GameType)
                    .HasColumnName("game_type")
                    .HasMaxLength(50);

                entity.Property(e => e.MemberAccount)
                    .HasColumnName("member_account")
                    .HasMaxLength(50);

                entity.Property(e => e.MemberId)
                    .HasColumnName("member_id")
                    .HasMaxLength(50);

                entity.Property(e => e.MemberName)
                    .HasColumnName("member_name")
                    .HasMaxLength(50);

                entity.Property(e => e.Netamount)
                    .HasColumnName("netamount")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Provider)
                    .HasColumnName("provider")
                    .HasMaxLength(50);

                entity.Property(e => e.Validamount)
                    .HasColumnName("validamount")
                    .HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<ApibbetDayMemberReport20170521after>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Apibbet_Day_Member_Report20170521after");

                entity.Property(e => e.AgentSite)
                    .HasColumnName("agent_site")
                    .HasMaxLength(256);

                entity.Property(e => e.Betamount)
                    .HasColumnName("betamount")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CalcDate)
                    .HasColumnName("calc_date")
                    .HasMaxLength(50);

                entity.Property(e => e.CreateTime)
                    .HasColumnName("create_time")
                    .HasColumnType("datetime");

                entity.Property(e => e.GameType)
                    .HasColumnName("game_type")
                    .HasMaxLength(50);

                entity.Property(e => e.MemberAccount)
                    .HasColumnName("member_account")
                    .HasMaxLength(50);

                entity.Property(e => e.MemberId)
                    .HasColumnName("member_id")
                    .HasMaxLength(50);

                entity.Property(e => e.MemberName)
                    .HasColumnName("member_name")
                    .HasMaxLength(50);

                entity.Property(e => e.Netamount)
                    .HasColumnName("netamount")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Provider)
                    .HasColumnName("provider")
                    .HasMaxLength(50);

                entity.Property(e => e.RakebackId)
                    .HasColumnName("rakeback_id")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Validamount)
                    .HasColumnName("validamount")
                    .HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<ApibbetDayMemberReport20170521before>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Apibbet_Day_Member_Report20170521before");

                entity.Property(e => e.AgentSite)
                    .HasColumnName("agent_site")
                    .HasMaxLength(256);

                entity.Property(e => e.Betamount)
                    .HasColumnName("betamount")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CalcDate)
                    .HasColumnName("calc_date")
                    .HasMaxLength(50);

                entity.Property(e => e.CreateTime)
                    .HasColumnName("create_time")
                    .HasColumnType("datetime");

                entity.Property(e => e.GameType)
                    .HasColumnName("game_type")
                    .HasMaxLength(50);

                entity.Property(e => e.MemberAccount)
                    .HasColumnName("member_account")
                    .HasMaxLength(50);

                entity.Property(e => e.MemberId)
                    .HasColumnName("member_id")
                    .HasMaxLength(50);

                entity.Property(e => e.MemberName)
                    .HasColumnName("member_name")
                    .HasMaxLength(50);

                entity.Property(e => e.Netamount)
                    .HasColumnName("netamount")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Provider)
                    .HasColumnName("provider")
                    .HasMaxLength(50);

                entity.Property(e => e.RakebackId)
                    .HasColumnName("rakeback_id")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Validamount)
                    .HasColumnName("validamount")
                    .HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<ApibbetFileList>(entity =>
            {
                entity.HasKey(e => e.FileName);

                entity.ToTable("Apibbet_FileList");

                entity.Property(e => e.FileName).HasMaxLength(200);

                entity.Property(e => e.LastModifyDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<ApibbetSync>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.LastUpdateTime).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Remark).HasMaxLength(500);

                entity.Property(e => e.Status).HasDefaultValueSql("((1))");

                entity.Property(e => e.SubName).HasMaxLength(50);

                entity.Property(e => e.SyncApi)
                    .IsRequired()
                    .HasMaxLength(500);
            });

            modelBuilder.Entity<ApibbetUserData>(entity =>
            {
                entity.ToTable("Apibbet_UserData");

                entity.HasIndex(e => e.BillNo)
                    .HasName("Apibbet_UserData_BIllNo");

                entity.HasIndex(e => e.FileName)
                    .HasName("Apibbet_UserData_FileName");

                entity.HasIndex(e => e.MemberName)
                    .HasName("Apibbet_UserData_MemberName");

                entity.HasIndex(e => e.Time)
                    .HasName("Apibbet_UserData_time");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Agent).HasMaxLength(250);

                entity.Property(e => e.BetAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.BillNo)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.FileName)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.LastModifyTime).HasColumnType("datetime");

                entity.Property(e => e.Member).HasMaxLength(250);

                entity.Property(e => e.MemberName)
                    .HasColumnName("Member_Name")
                    .HasMaxLength(250);

                entity.Property(e => e.NetAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Provider).HasMaxLength(50);

                entity.Property(e => e.Status).HasMaxLength(50);

                entity.Property(e => e.Time)
                    .HasColumnName("time")
                    .HasColumnType("datetime");

                entity.Property(e => e.TimeChn)
                    .HasColumnName("time_chn")
                    .HasColumnType("datetime");

                entity.Property(e => e.TimeUst)
                    .HasColumnName("time_ust")
                    .HasColumnType("datetime");

                entity.Property(e => e.TimeUtc)
                    .HasColumnName("time_utc")
                    .HasColumnType("datetime");

                entity.Property(e => e.Type).HasMaxLength(100);

                entity.Property(e => e.UserName).HasMaxLength(250);

                entity.Property(e => e.ValidAmount).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<ApibbetUserDataEx>(entity =>
            {
                entity.ToTable("Apibbet_UserDataEx");

                entity.HasIndex(e => e.BillNo)
                    .HasName("Apibbet_UserDataExBillNoIndex");

                entity.HasIndex(e => new { e.MemberName, e.BillNo, e.LastModifyTime })
                    .HasName("Apibbet_UserDataEx_Index");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Agent).HasMaxLength(250);

                entity.Property(e => e.BetAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.BillNo)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.LastModifyTime).HasColumnType("datetime");

                entity.Property(e => e.Member).HasMaxLength(250);

                entity.Property(e => e.MemberName)
                    .HasColumnName("Member_Name")
                    .HasMaxLength(250);

                entity.Property(e => e.NetAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Provider).HasMaxLength(50);

                entity.Property(e => e.Status).HasMaxLength(50);

                entity.Property(e => e.Time)
                    .HasColumnName("time")
                    .HasColumnType("datetime");

                entity.Property(e => e.TimeChn)
                    .HasColumnName("time_chn")
                    .HasColumnType("datetime");

                entity.Property(e => e.TimeUst)
                    .HasColumnName("time_ust")
                    .HasColumnType("datetime");

                entity.Property(e => e.TimeUtc)
                    .HasColumnName("time_utc")
                    .HasColumnType("datetime");

                entity.Property(e => e.Type).HasMaxLength(100);

                entity.Property(e => e.UserName).HasMaxLength(250);

                entity.Property(e => e.ValidAmount).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<ApibbetVideoGameType>(entity =>
            {
                entity.ToTable("Apibbet_VideoGame_Type");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Provider).HasMaxLength(100);

                entity.Property(e => e.SubType).HasMaxLength(200);

                entity.Property(e => e.Type).HasMaxLength(50);
            });

            modelBuilder.Entity<AppOrderAll>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("AppOrderAll");

                entity.Property(e => e.Amount)
                    .HasColumnName("amount")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Code)
                    .HasColumnName("code")
                    .HasMaxLength(100);

                entity.Property(e => e.ContextExt)
                    .HasColumnName("contextExt")
                    .HasMaxLength(50);

                entity.Property(e => e.CreateTime)
                    .HasColumnName("createTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.GroupCode)
                    .HasColumnName("groupCode")
                    .HasMaxLength(50);

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.LoginName)
                    .HasColumnName("loginName")
                    .HasMaxLength(50);

                entity.Property(e => e.Odds)
                    .HasColumnName("odds")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.OrderType)
                    .HasColumnName("orderType")
                    .HasMaxLength(50);

                entity.Property(e => e.PlayType)
                    .HasColumnName("playType")
                    .HasMaxLength(50);

                entity.Property(e => e.Score)
                    .HasColumnName("score")
                    .HasMaxLength(50);

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasMaxLength(50);

                entity.Property(e => e.TuishuiAmount)
                    .HasColumnName("tuishuiAmount")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasColumnName("type")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.ValidAmount)
                    .HasColumnName("validAmount")
                    .HasColumnType("decimal(19, 2)");

                entity.Property(e => e.WinAmount)
                    .HasColumnName("winAmount")
                    .HasColumnType("decimal(19, 2)");
            });

            modelBuilder.Entity<AppSetting>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Atype)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.Name2).HasMaxLength(50);
            });

            modelBuilder.Entity<AppSettingLog>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AppName)
                    .IsRequired()
                    .HasColumnName("appName")
                    .HasMaxLength(50);

                entity.Property(e => e.AppValue)
                    .IsRequired()
                    .HasColumnName("appValue");

                entity.Property(e => e.CreateTime)
                    .HasColumnName("createTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.Creator)
                    .IsRequired()
                    .HasColumnName("creator")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<AsyncSetting>(entity =>
            {
                entity.HasKey(e => e.TableName)
                    .HasName("PK__AsyncSet__93F7AC694AAA3287");

                entity.Property(e => e.TableName)
                    .HasColumnName("tableName")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<Bak20190701FinanceAccess>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Bak_20190701_FinanceAccess");

                entity.Property(e => e.AccessAfterAmount)
                    .HasColumnName("accessAfterAmount")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.AccessAmount)
                    .HasColumnName("accessAmount")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.AccessBeforeAmount)
                    .HasColumnName("accessBeforeAmount")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ApprovedTime)
                    .HasColumnName("approvedTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.BankCode)
                    .HasColumnName("bankCode")
                    .HasMaxLength(100);

                entity.Property(e => e.Code)
                    .HasColumnName("code")
                    .HasMaxLength(50);

                entity.Property(e => e.CreateTime)
                    .HasColumnName("createTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.DepositWithdrawNum).HasColumnName("depositWithdrawNum");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.LoginName)
                    .HasColumnName("loginName")
                    .HasMaxLength(50);

                entity.Property(e => e.OpenBankAddr)
                    .HasColumnName("openBankAddr")
                    .HasMaxLength(200);

                entity.Property(e => e.OpenName)
                    .HasColumnName("openName")
                    .HasMaxLength(50);

                entity.Property(e => e.Openbank)
                    .HasColumnName("openbank")
                    .HasMaxLength(100);

                entity.Property(e => e.Remark)
                    .HasColumnName("remark")
                    .HasMaxLength(250);

                entity.Property(e => e.RemarkAdmin).HasColumnName("remarkAdmin");

                entity.Property(e => e.Source).HasMaxLength(50);

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasMaxLength(5);

                entity.Property(e => e.SubType)
                    .HasColumnName("subType")
                    .HasMaxLength(50);

                entity.Property(e => e.SubmitTime)
                    .HasColumnName("submitTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.Type)
                    .HasColumnName("type")
                    .HasMaxLength(2);
            });

            modelBuilder.Entity<Bak20190701Financebak>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Bak_20190701_Financebak");

                entity.Property(e => e.AccessAfterAmount)
                    .HasColumnName("accessAfterAmount")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.AccessAmount)
                    .HasColumnName("accessAmount")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.AccessBeforeAmount)
                    .HasColumnName("accessBeforeAmount")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CraeteData)
                    .HasColumnName("craeteData")
                    .HasColumnType("datetime");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.LoginName)
                    .HasColumnName("loginName")
                    .HasMaxLength(50);

                entity.Property(e => e.Remark).HasMaxLength(100);

                entity.Property(e => e.Rid).HasColumnName("rid");

                entity.Property(e => e.Type)
                    .HasColumnName("type")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Bak20190701Financetmp>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Bak_20190701_Financetmp");

                entity.Property(e => e.AccessAfterAmount)
                    .HasColumnName("accessAfterAmount")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.AccessAmount)
                    .HasColumnName("accessAmount")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.AccessBeforeAmount)
                    .HasColumnName("accessBeforeAmount")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CraeteData)
                    .HasColumnName("craeteData")
                    .HasColumnType("datetime");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.LoginName)
                    .HasColumnName("loginName")
                    .HasMaxLength(50);

                entity.Property(e => e.Remark).HasMaxLength(100);

                entity.Property(e => e.Rid).HasColumnName("rid");

                entity.Property(e => e.Type)
                    .HasColumnName("type")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Bak20190701VideoGameTransferLog>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Bak_20190701_VideoGameTransferLog");

                entity.Property(e => e.AdjMoney).HasColumnType("decimal(15, 2)");

                entity.Property(e => e.BillNo).HasMaxLength(100);

                entity.Property(e => e.ClientIp)
                    .HasColumnName("ClientIP")
                    .HasMaxLength(50);

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.Device).HasMaxLength(100);

                entity.Property(e => e.GameAccount).HasMaxLength(50);

                entity.Property(e => e.GamePwd).HasMaxLength(50);

                entity.Property(e => e.Kind).HasMaxLength(50);

                entity.Property(e => e.LoginName).HasMaxLength(50);

                entity.Property(e => e.Remark).HasMaxLength(500);

                entity.Property(e => e.Status).HasMaxLength(100);
            });

            modelBuilder.Entity<BakFinanceAccess20181015>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Bak_FinanceAccess20181015");

                entity.Property(e => e.AccessAfterAmount)
                    .HasColumnName("accessAfterAmount")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.AccessAmount)
                    .HasColumnName("accessAmount")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.AccessBeforeAmount)
                    .HasColumnName("accessBeforeAmount")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ApprovedTime)
                    .HasColumnName("approvedTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.BankCode)
                    .HasColumnName("bankCode")
                    .HasMaxLength(100);

                entity.Property(e => e.Code)
                    .HasColumnName("code")
                    .HasMaxLength(50);

                entity.Property(e => e.CreateTime)
                    .HasColumnName("createTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.LoginName)
                    .HasColumnName("loginName")
                    .HasMaxLength(50);

                entity.Property(e => e.OpenBankAddr)
                    .HasColumnName("openBankAddr")
                    .HasMaxLength(200);

                entity.Property(e => e.OpenName)
                    .HasColumnName("openName")
                    .HasMaxLength(50);

                entity.Property(e => e.Openbank)
                    .HasColumnName("openbank")
                    .HasMaxLength(100);

                entity.Property(e => e.Remark)
                    .HasColumnName("remark")
                    .HasMaxLength(250);

                entity.Property(e => e.Source).HasMaxLength(50);

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasMaxLength(5);

                entity.Property(e => e.SubType)
                    .HasColumnName("subType")
                    .HasMaxLength(50);

                entity.Property(e => e.SubmitTime)
                    .HasColumnName("submitTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.Type)
                    .HasColumnName("type")
                    .HasMaxLength(2);
            });

            modelBuilder.Entity<BakFinancebak20181015>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Bak_Financebak20181015");

                entity.Property(e => e.AccessAfterAmount)
                    .HasColumnName("accessAfterAmount")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.AccessAmount)
                    .HasColumnName("accessAmount")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.AccessBeforeAmount)
                    .HasColumnName("accessBeforeAmount")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CraeteData)
                    .HasColumnName("craeteData")
                    .HasColumnType("datetime");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.LoginName)
                    .HasColumnName("loginName")
                    .HasMaxLength(50);

                entity.Property(e => e.Remark).HasMaxLength(100);

                entity.Property(e => e.Rid).HasColumnName("rid");

                entity.Property(e => e.Type)
                    .HasColumnName("type")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<BakFinancetmp20181015>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Bak_Financetmp20181015");

                entity.Property(e => e.AccessAfterAmount)
                    .HasColumnName("accessAfterAmount")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.AccessAmount)
                    .HasColumnName("accessAmount")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.AccessBeforeAmount)
                    .HasColumnName("accessBeforeAmount")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CraeteData)
                    .HasColumnName("craeteData")
                    .HasColumnType("datetime");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.LoginName)
                    .HasColumnName("loginName")
                    .HasMaxLength(50);

                entity.Property(e => e.Remark).HasMaxLength(100);

                entity.Property(e => e.Rid).HasColumnName("rid");

                entity.Property(e => e.Type)
                    .HasColumnName("type")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<BakVideoGameTransferLog20181015>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Bak_VideoGameTransferLog20181015");

                entity.Property(e => e.AdjMoney).HasColumnType("decimal(15, 2)");

                entity.Property(e => e.ClientIp)
                    .HasColumnName("ClientIP")
                    .HasMaxLength(50);

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.Device).HasMaxLength(100);

                entity.Property(e => e.GameAccount).HasMaxLength(50);

                entity.Property(e => e.GamePwd).HasMaxLength(50);

                entity.Property(e => e.Kind).HasMaxLength(50);

                entity.Property(e => e.LoginName).HasMaxLength(50);

                entity.Property(e => e.Status).HasMaxLength(100);
            });

            modelBuilder.Entity<BallReport>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Bbdds).HasColumnName("BBdds");

                entity.Property(e => e.Bbjs)
                    .HasColumnName("BBjs")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Bbyl)
                    .HasColumnName("BByl")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Bbztze)
                    .HasColumnName("BBztze")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Bdbdds).HasColumnName("BDBdds");

                entity.Property(e => e.Bdbjs)
                    .HasColumnName("BDBjs")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Bdbyl)
                    .HasColumnName("BDByl")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Bdbztze)
                    .HasColumnName("BDBztze")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Bsbdds).HasColumnName("BSBdds");

                entity.Property(e => e.Bsbjs)
                    .HasColumnName("BSBjs")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Bsbyl)
                    .HasColumnName("BSByl")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Bsbztze)
                    .HasColumnName("BSBztze")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Fbdds).HasColumnName("FBdds");

                entity.Property(e => e.Fbjs)
                    .HasColumnName("FBjs")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Fbyl)
                    .HasColumnName("FByl")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Fbztze)
                    .HasColumnName("FBztze")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Otbdds).HasColumnName("OTBdds");

                entity.Property(e => e.Otbjs)
                    .HasColumnName("OTBjs")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Otbyl)
                    .HasColumnName("OTByl")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Otbztze)
                    .HasColumnName("OTBztze")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Ppbdds).HasColumnName("PPBdds");

                entity.Property(e => e.Ppbjs)
                    .HasColumnName("PPBjs")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Ppbyl)
                    .HasColumnName("PPByl")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Ppbztze)
                    .HasColumnName("PPBztze")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ReportDay)
                    .HasColumnName("reportDay")
                    .HasColumnType("datetime");

                entity.Property(e => e.Tbdds).HasColumnName("TBdds");

                entity.Property(e => e.Tbjs)
                    .HasColumnName("TBjs")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Tbyl)
                    .HasColumnName("TByl")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Tbztze)
                    .HasColumnName("TBztze")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Vbdds).HasColumnName("VBdds");

                entity.Property(e => e.Vbjs)
                    .HasColumnName("VBjs")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Vbyl)
                    .HasColumnName("VByl")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Vbztze)
                    .HasColumnName("VBztze")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Zfs)
                    .HasColumnName("zfs")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Zjs)
                    .HasColumnName("zjs")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Zts)
                    .HasColumnName("zts")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Ztz)
                    .HasColumnName("ztz")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Zyl)
                    .HasColumnName("zyl")
                    .HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<BankMapping>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.BankCode).HasMaxLength(50);

                entity.Property(e => e.BankName).HasMaxLength(200);

                entity.Property(e => e.BankNameSub).HasMaxLength(200);

                entity.Property(e => e.City).HasMaxLength(50);

                entity.Property(e => e.Province).HasMaxLength(50);
            });

            modelBuilder.Entity<BbBetdetail>(entity =>
            {
                entity.HasKey(e => e.Wagersid);

                entity.ToTable("bb_betdetail");

                entity.Property(e => e.Wagersid)
                    .HasColumnName("wagersid")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.AgentSite)
                    .HasColumnName("agent_site")
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.Betamount)
                    .HasColumnName("betamount")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Card)
                    .HasColumnName("card")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Commissionable)
                    .HasColumnName("commissionable")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Currency)
                    .HasColumnName("currency")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Exchangerate)
                    .HasColumnName("exchangerate")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Gamecode)
                    .HasColumnName("gamecode")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Gametype)
                    .HasColumnName("gametype")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Ispaid)
                    .HasColumnName("ispaid")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.MemberAccount)
                    .HasColumnName("member_account")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Origin)
                    .HasColumnName("origin")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Payoff)
                    .HasColumnName("payoff")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Result)
                    .HasColumnName("result")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Resulttype)
                    .HasColumnName("resulttype")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Roundno)
                    .HasColumnName("roundno")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Serialid)
                    .HasColumnName("serialid")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.SyncTime)
                    .IsRequired()
                    .HasColumnName("sync_time")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasColumnName("username")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Wagersdate)
                    .IsRequired()
                    .HasColumnName("wagersdate")
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CspsettlementLog>(entity =>
            {
                entity.ToTable("CSPSettlementLog");

                entity.HasIndex(e => e.Mid)
                    .HasName("CSPSettlementLog_Index");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Content).HasMaxLength(500);

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.Mid)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Stauts).HasMaxLength(50);

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.UpdateBy).HasMaxLength(50);
            });

            modelBuilder.Entity<CttraceDetailView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("CTTraceDetailView");

                entity.Property(e => e.ApplicationId).HasColumnName("ApplicationID");

                entity.Property(e => e.ApplicationName).HasMaxLength(128);

                entity.Property(e => e.Cpu).HasColumnName("CPU");

                entity.Property(e => e.EndTime).HasColumnType("datetime");

                entity.Property(e => e.HostId).HasColumnName("HostID");

                entity.Property(e => e.HostName).HasMaxLength(128);

                entity.Property(e => e.LoginId).HasColumnName("LoginID");

                entity.Property(e => e.LoginName).HasMaxLength(256);

                entity.Property(e => e.NormalizedTextData).HasMaxLength(4000);

                entity.Property(e => e.SampleTextData).HasColumnType("ntext");

                entity.Property(e => e.ServerId).HasColumnName("ServerID");

                entity.Property(e => e.ServerName).HasMaxLength(256);

                entity.Property(e => e.TraceFileId).HasColumnName("TraceFileID");

                entity.Property(e => e.TraceId).HasColumnName("TraceID");

                entity.Property(e => e.TraceName).HasMaxLength(128);
            });

            modelBuilder.Entity<CttraceSummaryView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("CTTraceSummaryView");

                entity.Property(e => e.ApplicationId).HasColumnName("ApplicationID");

                entity.Property(e => e.ApplicationName).HasMaxLength(128);

                entity.Property(e => e.CalendarDate).HasColumnType("datetime");

                entity.Property(e => e.Cpu).HasColumnName("CPU");

                entity.Property(e => e.DateId).HasColumnName("DateID");

                entity.Property(e => e.HostId).HasColumnName("HostID");

                entity.Property(e => e.HostName).HasMaxLength(128);

                entity.Property(e => e.LoginId).HasColumnName("LoginID");

                entity.Property(e => e.LoginName).HasMaxLength(256);

                entity.Property(e => e.NormalizedTextData).HasMaxLength(4000);

                entity.Property(e => e.SampleTextData).HasColumnType("ntext");

                entity.Property(e => e.ServerId).HasColumnName("ServerID");

                entity.Property(e => e.ServerName).HasMaxLength(256);

                entity.Property(e => e.TimeId).HasColumnName("TimeID");

                entity.Property(e => e.TraceFileId).HasColumnName("TraceFileID");

                entity.Property(e => e.TraceId).HasColumnName("TraceID");

                entity.Property(e => e.TraceName).HasMaxLength(128);
            });

            modelBuilder.Entity<DaiFuSetting>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.AnsycHost).HasMaxLength(500);

                entity.Property(e => e.BizKey)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Code)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CreateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Creator).HasMaxLength(20);

                entity.Property(e => e.DaiFuCode)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.DaiFuName)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.DaiFuPro).IsRequired();

                entity.Property(e => e.PayPwd)
                    .HasColumnName("PayPWD")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Snk)
                    .IsRequired()
                    .HasColumnName("snk")
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.Snk2)
                    .HasColumnName("snk2")
                    .HasMaxLength(2000);

                entity.Property(e => e.Snk3)
                    .HasColumnName("snk3")
                    .HasMaxLength(2000);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasMaxLength(20)
                    .HasDefaultValueSql("('启用')");

                entity.Property(e => e.UpdateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Updater).HasMaxLength(20);
            });

            modelBuilder.Entity<DaiFuSettingTemp>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.AnsycHost).HasMaxLength(500);

                entity.Property(e => e.BizKey)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.Creator).HasMaxLength(20);

                entity.Property(e => e.DaiFuCode)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.DaiFuName)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.DaiFuPro).IsRequired();

                entity.Property(e => e.PayPwd)
                    .HasColumnName("PayPWD")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Snk)
                    .IsRequired()
                    .HasColumnName("snk")
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.Snk2)
                    .HasColumnName("snk2")
                    .HasMaxLength(2000);

                entity.Property(e => e.Snk3)
                    .HasColumnName("snk3")
                    .HasMaxLength(2000);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasMaxLength(20);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");

                entity.Property(e => e.Updater).HasMaxLength(20);
            });

            modelBuilder.Entity<DayReportTotalFinance>(entity =>
            {
                entity.ToTable("DayReport_TotalFinance");

                entity.HasIndex(e => e.Date)
                    .HasName("NonClusteredIndex-DayReport_TotalFinance");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.DepositAlipay)
                    .HasColumnName("Deposit_Alipay")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.DepositCompany)
                    .HasColumnName("Deposit_Company")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.DepositOnline)
                    .HasColumnName("Deposit_Online")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ExpendOther)
                    .HasColumnName("Expend_Other")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.GameIn)
                    .HasColumnName("Game_In")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.GameOut)
                    .HasColumnName("Game_Out")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.IncomeOther)
                    .HasColumnName("Income_Other")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Withdraw).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<DayReportUserFinance>(entity =>
            {
                entity.ToTable("DayReport_UserFinance");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.DepositAlipay)
                    .HasColumnName("Deposit_Alipay")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.DepositCompany)
                    .HasColumnName("Deposit_Company")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.DepositOnline)
                    .HasColumnName("Deposit_Online")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ExpendOther)
                    .HasColumnName("Expend_Other")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.GameIn)
                    .HasColumnName("Game_In")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.GameOut)
                    .HasColumnName("Game_Out")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.IncomeOther)
                    .HasColumnName("Income_Other")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.LoginName)
                    .HasColumnName("loginName")
                    .HasMaxLength(50);

                entity.Property(e => e.Withdraw).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<DepositClass>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Frontbackgroundcolor)
                    .HasColumnName("frontbackgroundcolor")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Frontcolor)
                    .HasColumnName("frontcolor")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Frontdesc)
                    .HasColumnName("frontdesc")
                    .HasMaxLength(5000)
                    .IsUnicode(false);

                entity.Property(e => e.Frontfontsize)
                    .HasColumnName("frontfontsize")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Hgbackgroundcolor)
                    .HasColumnName("hgbackgroundcolor")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Hgcolor)
                    .HasColumnName("hgcolor")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Hgdesc)
                    .HasColumnName("hgdesc")
                    .HasMaxLength(5000)
                    .IsUnicode(false);

                entity.Property(e => e.Hgfontsize)
                    .HasColumnName("hgfontsize")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Isshow)
                    .IsRequired()
                    .HasColumnName("isshow")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Linkurl)
                    .HasColumnName("linkurl")
                    .HasMaxLength(200);

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Phonebackgroundcolor)
                    .HasColumnName("phonebackgroundcolor")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Phonecolor)
                    .HasColumnName("phonecolor")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Phonedesc)
                    .HasColumnName("phonedesc")
                    .HasMaxLength(5000)
                    .IsUnicode(false);

                entity.Property(e => e.Phonefontsize)
                    .HasColumnName("phonefontsize")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Sort).HasColumnName("sort");

                entity.Property(e => e.Type)
                    .HasColumnName("type")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DonlinePay>(entity =>
            {
                entity.HasKey(e => e.Code);

                entity.Property(e => e.Code)
                    .HasColumnName("code")
                    .HasMaxLength(100);

                entity.Property(e => e.AccBank).HasMaxLength(100);

                entity.Property(e => e.AccBankName).HasMaxLength(100);

                entity.Property(e => e.AccMobile).HasMaxLength(100);

                entity.Property(e => e.AccName)
                    .HasColumnName("accName")
                    .HasMaxLength(50);

                entity.Property(e => e.AccNo)
                    .HasColumnName("accNo")
                    .HasMaxLength(50);

                entity.Property(e => e.Amt)
                    .HasColumnName("amt")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.BranchCode).HasMaxLength(100);

                entity.Property(e => e.BranchName).HasMaxLength(100);

                entity.Property(e => e.LastcallbackTime).HasColumnType("datetime");

                entity.Property(e => e.LoginName)
                    .IsRequired()
                    .HasColumnName("loginName")
                    .HasMaxLength(100);

                entity.Property(e => e.OrderStatusMsg)
                    .HasColumnName("orderStatusMsg")
                    .HasMaxLength(200);

                entity.Property(e => e.Outcode)
                    .HasColumnName("outcode")
                    .HasMaxLength(100);

                entity.Property(e => e.Qcode)
                    .IsRequired()
                    .HasColumnName("qcode")
                    .HasMaxLength(100);

                entity.Property(e => e.Rid).HasColumnName("rid");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasMaxLength(50);

                entity.Property(e => e.SubmitTime)
                    .HasColumnName("submitTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.SubmitUser)
                    .HasColumnName("submitUser")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<FarbudItems>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Cata)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.CreateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Creator)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Exp1)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Exp2)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Exp3)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Kind)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.LoginName)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Ttype)
                    .IsRequired()
                    .HasColumnName("TType")
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<Finance>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Finance");

                entity.Property(e => e.AccessAfterAmount)
                    .HasColumnName("accessAfterAmount")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.AccessAmount)
                    .HasColumnName("accessAmount")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.AccessBeforeAmount)
                    .HasColumnName("accessBeforeAmount")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CraeteData)
                    .HasColumnName("craeteData")
                    .HasColumnType("datetime");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.LoginName)
                    .HasColumnName("loginName")
                    .HasMaxLength(50);

                entity.Property(e => e.Remark).HasMaxLength(100);

                entity.Property(e => e.Rid).HasColumnName("rid");

                entity.Property(e => e.Type)
                    .HasColumnName("type")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<FinanceAccess>(entity =>
            {
                entity.HasIndex(e => new { e.Type, e.Status, e.Source })
                    .HasName("FinanceAccesstypestatusSourceIndex");

                entity.HasIndex(e => new { e.ApprovedTime, e.CreateTime, e.Code, e.LoginName })
                    .HasName("NonClusteredIndex-FinanceAccess");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.AccessAfterAmount)
                    .HasColumnName("accessAfterAmount")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.AccessAmount)
                    .HasColumnName("accessAmount")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.AccessBeforeAmount)
                    .HasColumnName("accessBeforeAmount")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ApprovedTime)
                    .HasColumnName("approvedTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.BankCode)
                    .HasColumnName("bankCode")
                    .HasMaxLength(100);

                entity.Property(e => e.Code)
                    .HasColumnName("code")
                    .HasMaxLength(50);

                entity.Property(e => e.CreateTime)
                    .HasColumnName("createTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.DepositWithdrawNum).HasColumnName("depositWithdrawNum");

                entity.Property(e => e.LoginName)
                    .HasColumnName("loginName")
                    .HasMaxLength(50);

                entity.Property(e => e.OpenBankAddr)
                    .HasColumnName("openBankAddr")
                    .HasMaxLength(200);

                entity.Property(e => e.OpenName)
                    .HasColumnName("openName")
                    .HasMaxLength(50);

                entity.Property(e => e.Openbank)
                    .HasColumnName("openbank")
                    .HasMaxLength(100);

                entity.Property(e => e.Remark)
                    .HasColumnName("remark")
                    .HasMaxLength(250);

                entity.Property(e => e.RemarkAdmin).HasColumnName("remarkAdmin");

                entity.Property(e => e.Source).HasMaxLength(50);

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasMaxLength(5);

                entity.Property(e => e.SubType)
                    .HasColumnName("subType")
                    .HasMaxLength(50);

                entity.Property(e => e.SubmitTime)
                    .HasColumnName("submitTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.Type)
                    .HasColumnName("type")
                    .HasMaxLength(2);
            });

            modelBuilder.Entity<FinanceAccessAsync>(entity =>
            {
                entity.ToTable("FinanceAccess_Async");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Dtime)
                    .HasColumnName("dtime")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<FinanceAccessDaifuView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("FinanceAccessDaifuView");

                entity.Property(e => e.AccBank).HasMaxLength(100);

                entity.Property(e => e.AccBankName).HasMaxLength(100);

                entity.Property(e => e.AccMobile).HasMaxLength(100);

                entity.Property(e => e.AccName)
                    .HasColumnName("accName")
                    .HasMaxLength(50);

                entity.Property(e => e.AccNo)
                    .HasColumnName("accNo")
                    .HasMaxLength(50);

                entity.Property(e => e.AccessAfterAmount)
                    .HasColumnName("accessAfterAmount")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.AccessAmount)
                    .HasColumnName("accessAmount")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.AccessBeforeAmount)
                    .HasColumnName("accessBeforeAmount")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Amt)
                    .HasColumnName("amt")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ApprovedTime)
                    .HasColumnName("approvedTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.BankCode)
                    .HasColumnName("bankCode")
                    .HasMaxLength(100);

                entity.Property(e => e.BranchCode).HasMaxLength(100);

                entity.Property(e => e.BranchName).HasMaxLength(100);

                entity.Property(e => e.Code)
                    .HasColumnName("code")
                    .HasMaxLength(50);

                entity.Property(e => e.CreateTime)
                    .HasColumnName("createTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.DepositWithdrawNum).HasColumnName("depositWithdrawNum");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.LoginName)
                    .HasColumnName("loginName")
                    .HasMaxLength(50);

                entity.Property(e => e.LoginNameUserName)
                    .HasColumnName("loginNameUserName")
                    .HasMaxLength(102);

                entity.Property(e => e.OpenBankAddr)
                    .HasColumnName("openBankAddr")
                    .HasMaxLength(200);

                entity.Property(e => e.OpenName)
                    .HasColumnName("openName")
                    .HasMaxLength(50);

                entity.Property(e => e.Openbank)
                    .HasColumnName("openbank")
                    .HasMaxLength(100);

                entity.Property(e => e.OrderStatusMsg)
                    .HasColumnName("orderStatusMsg")
                    .HasMaxLength(200);

                entity.Property(e => e.Outcode)
                    .HasColumnName("outcode")
                    .HasMaxLength(100);

                entity.Property(e => e.Qcode)
                    .HasColumnName("qcode")
                    .HasMaxLength(100);

                entity.Property(e => e.Remark)
                    .HasColumnName("remark")
                    .HasMaxLength(250);

                entity.Property(e => e.RemarkAdmin).HasColumnName("remarkAdmin");

                entity.Property(e => e.Source).HasMaxLength(50);

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasMaxLength(5);

                entity.Property(e => e.Status2)
                    .HasColumnName("status2")
                    .HasMaxLength(50);

                entity.Property(e => e.SubType)
                    .HasColumnName("subType")
                    .HasMaxLength(50);

                entity.Property(e => e.SubmitTime)
                    .HasColumnName("submitTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.SubmitTime2)
                    .HasColumnName("submitTime2")
                    .HasColumnType("datetime");

                entity.Property(e => e.SubmitUser)
                    .HasColumnName("submitUser")
                    .HasMaxLength(100);

                entity.Property(e => e.Type)
                    .HasColumnName("type")
                    .HasMaxLength(2);

                entity.Property(e => e.UserLeve)
                    .HasColumnName("userLeve")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<FinanceAccessExt>(entity =>
            {
                entity.HasKey(e => e.Gid)
                    .HasName("PK__FinanceA__DCD80EF8C30E479F");

                entity.Property(e => e.Gid)
                    .HasColumnName("gid")
                    .ValueGeneratedNever();

                entity.Property(e => e.ApprovedTime2)
                    .HasColumnName("approvedTime2")
                    .HasColumnType("datetime");

                entity.Property(e => e.ApprovedUser2)
                    .HasColumnName("approvedUser2")
                    .HasMaxLength(50);

                entity.Property(e => e.Status2)
                    .HasColumnName("status2")
                    .HasMaxLength(5);
            });

            modelBuilder.Entity<FinanceAccessExtView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("FinanceAccessExtView");

                entity.Property(e => e.AccessAfterAmount)
                    .HasColumnName("accessAfterAmount")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.AccessAmount)
                    .HasColumnName("accessAmount")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.AccessBeforeAmount)
                    .HasColumnName("accessBeforeAmount")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ApprovedTime)
                    .HasColumnName("approvedTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.ApprovedTime2)
                    .HasColumnName("approvedTime2")
                    .HasColumnType("datetime");

                entity.Property(e => e.ApprovedUser2)
                    .HasColumnName("approvedUser2")
                    .HasMaxLength(50);

                entity.Property(e => e.BankCode)
                    .HasColumnName("bankCode")
                    .HasMaxLength(100);

                entity.Property(e => e.Code)
                    .HasColumnName("code")
                    .HasMaxLength(50);

                entity.Property(e => e.CreateTime)
                    .HasColumnName("createTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.DepositWithdrawNum).HasColumnName("depositWithdrawNum");

                entity.Property(e => e.Gid).HasColumnName("gid");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.LoginName)
                    .HasColumnName("loginName")
                    .HasMaxLength(50);

                entity.Property(e => e.LoginNameUserName)
                    .HasColumnName("loginNameUserName")
                    .HasMaxLength(102);

                entity.Property(e => e.OpenBankAddr)
                    .HasColumnName("openBankAddr")
                    .HasMaxLength(200);

                entity.Property(e => e.OpenName)
                    .HasColumnName("openName")
                    .HasMaxLength(50);

                entity.Property(e => e.Openbank)
                    .HasColumnName("openbank")
                    .HasMaxLength(100);

                entity.Property(e => e.Remark)
                    .HasColumnName("remark")
                    .HasMaxLength(250);

                entity.Property(e => e.RemarkAdmin).HasColumnName("remarkAdmin");

                entity.Property(e => e.Source).HasMaxLength(50);

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasMaxLength(5);

                entity.Property(e => e.Status2)
                    .HasColumnName("status2")
                    .HasMaxLength(5);

                entity.Property(e => e.SubType)
                    .HasColumnName("subType")
                    .HasMaxLength(50);

                entity.Property(e => e.SubmitTime)
                    .HasColumnName("submitTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.Type)
                    .HasColumnName("type")
                    .HasMaxLength(2);
            });

            modelBuilder.Entity<FinanceAccessExtView2>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("FinanceAccessExtView2");

                entity.Property(e => e.AccessAfterAmount)
                    .HasColumnName("accessAfterAmount")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.AccessAmount)
                    .HasColumnName("accessAmount")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.AccessBeforeAmount)
                    .HasColumnName("accessBeforeAmount")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ApprovedTime)
                    .HasColumnName("approvedTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.ApprovedTime2)
                    .HasColumnName("approvedTime2")
                    .HasColumnType("datetime");

                entity.Property(e => e.ApprovedUser2)
                    .HasColumnName("approvedUser2")
                    .HasMaxLength(50);

                entity.Property(e => e.BankCode)
                    .HasColumnName("bankCode")
                    .HasMaxLength(100);

                entity.Property(e => e.Code)
                    .HasColumnName("code")
                    .HasMaxLength(50);

                entity.Property(e => e.CreateTime)
                    .HasColumnName("createTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.DepositWithdrawNum).HasColumnName("depositWithdrawNum");

                entity.Property(e => e.Gid).HasColumnName("gid");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.LoginName)
                    .HasColumnName("loginName")
                    .HasMaxLength(50);

                entity.Property(e => e.LoginNameUserName)
                    .HasColumnName("loginNameUserName")
                    .HasMaxLength(102);

                entity.Property(e => e.OpenBankAddr)
                    .HasColumnName("openBankAddr")
                    .HasMaxLength(200);

                entity.Property(e => e.OpenName)
                    .HasColumnName("openName")
                    .HasMaxLength(50);

                entity.Property(e => e.Openbank)
                    .HasColumnName("openbank")
                    .HasMaxLength(100);

                entity.Property(e => e.OrderStatusMsg)
                    .HasColumnName("orderStatusMsg")
                    .HasMaxLength(200);

                entity.Property(e => e.Remark)
                    .HasColumnName("remark")
                    .HasMaxLength(250);

                entity.Property(e => e.RemarkAdmin).HasColumnName("remarkAdmin");

                entity.Property(e => e.Source).HasMaxLength(50);

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasMaxLength(5);

                entity.Property(e => e.Status2)
                    .HasColumnName("status2")
                    .HasMaxLength(5);

                entity.Property(e => e.Status3)
                    .HasColumnName("status3")
                    .HasMaxLength(50);

                entity.Property(e => e.SubType)
                    .HasColumnName("subType")
                    .HasMaxLength(50);

                entity.Property(e => e.SubmitTime)
                    .HasColumnName("submitTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.Type)
                    .HasColumnName("type")
                    .HasMaxLength(2);
            });

            modelBuilder.Entity<FinanceAccessUserView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("FinanceAccessUserView");

                entity.Property(e => e.AccessAfterAmount)
                    .HasColumnName("accessAfterAmount")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.AccessAmount)
                    .HasColumnName("accessAmount")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.AccessBeforeAmount)
                    .HasColumnName("accessBeforeAmount")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ApprovedTime)
                    .HasColumnName("approvedTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.BankCode)
                    .HasColumnName("bankCode")
                    .HasMaxLength(100);

                entity.Property(e => e.Code)
                    .HasColumnName("code")
                    .HasMaxLength(50);

                entity.Property(e => e.CreateTime)
                    .HasColumnName("createTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.DepositWithdrawNum).HasColumnName("depositWithdrawNum");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.LoginName)
                    .HasColumnName("loginName")
                    .HasMaxLength(50);

                entity.Property(e => e.LoginNameUserName)
                    .HasColumnName("loginNameUserName")
                    .HasMaxLength(102);

                entity.Property(e => e.OpenBankAddr)
                    .HasColumnName("openBankAddr")
                    .HasMaxLength(200);

                entity.Property(e => e.OpenName)
                    .HasColumnName("openName")
                    .HasMaxLength(50);

                entity.Property(e => e.Openbank)
                    .HasColumnName("openbank")
                    .HasMaxLength(100);

                entity.Property(e => e.Remark)
                    .HasColumnName("remark")
                    .HasMaxLength(250);

                entity.Property(e => e.RemarkAdmin).HasColumnName("remarkAdmin");

                entity.Property(e => e.Source).HasMaxLength(50);

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasMaxLength(5);

                entity.Property(e => e.SubType)
                    .HasColumnName("subType")
                    .HasMaxLength(50);

                entity.Property(e => e.SubmitTime)
                    .HasColumnName("submitTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.Type)
                    .HasColumnName("type")
                    .HasMaxLength(2);

                entity.Property(e => e.UserGroup)
                    .HasColumnName("userGroup")
                    .HasMaxLength(50);

                entity.Property(e => e.UserLeve)
                    .HasColumnName("userLeve")
                    .HasMaxLength(50);

                entity.Property(e => e.WrcreateTime)
                    .HasColumnName("WRCreateTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.Wrmessage)
                    .HasColumnName("WRMessage")
                    .HasMaxLength(200);

                entity.Property(e => e.Wrtype).HasColumnName("WRType");
            });

            modelBuilder.Entity<FinanceAccessUserViewSaved>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("FinanceAccessUserViewSaved");

                entity.Property(e => e.AccessAfterAmount)
                    .HasColumnName("accessAfterAmount")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.AccessAmount)
                    .HasColumnName("accessAmount")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.AccessBeforeAmount)
                    .HasColumnName("accessBeforeAmount")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ApprovedTime)
                    .HasColumnName("approvedTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.BankCode)
                    .HasColumnName("bankCode")
                    .HasMaxLength(100);

                entity.Property(e => e.Code)
                    .HasColumnName("code")
                    .HasMaxLength(50);

                entity.Property(e => e.CreateTime)
                    .HasColumnName("createTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.LoginName)
                    .HasColumnName("loginName")
                    .HasMaxLength(50);

                entity.Property(e => e.LoginNameUserName)
                    .HasColumnName("loginNameUserName")
                    .HasMaxLength(102);

                entity.Property(e => e.OpenBankAddr)
                    .HasColumnName("openBankAddr")
                    .HasMaxLength(200);

                entity.Property(e => e.OpenName)
                    .HasColumnName("openName")
                    .HasMaxLength(50);

                entity.Property(e => e.Openbank)
                    .HasColumnName("openbank")
                    .HasMaxLength(100);

                entity.Property(e => e.Remark)
                    .HasColumnName("remark")
                    .HasMaxLength(250);

                entity.Property(e => e.RemarkAdmin).HasColumnName("remarkAdmin");

                entity.Property(e => e.Source).HasMaxLength(50);

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasMaxLength(5);

                entity.Property(e => e.SubType)
                    .HasColumnName("subType")
                    .HasMaxLength(50);

                entity.Property(e => e.SubmitTime)
                    .HasColumnName("submitTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.Type)
                    .HasColumnName("type")
                    .HasMaxLength(2);

                entity.Property(e => e.UserLeve)
                    .HasColumnName("userLeve")
                    .HasMaxLength(50);

                entity.Property(e => e.WrcreateTime)
                    .HasColumnName("WRCreateTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.Wrmessage)
                    .HasColumnName("WRMessage")
                    .HasMaxLength(200);

                entity.Property(e => e.Wrtype).HasColumnName("WRType");
            });

            modelBuilder.Entity<FinanceAsync>(entity =>
            {
                entity.ToTable("Finance_Async");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Dtime)
                    .HasColumnName("dtime")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<FinanceHisReport>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreateData)
                    .HasColumnName("createData")
                    .HasColumnType("datetime");

                entity.Property(e => e.LoginName)
                    .HasColumnName("loginName")
                    .HasMaxLength(50);

                entity.Property(e => e.Resout)
                    .HasColumnName("resout")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Type)
                    .HasColumnName("type")
                    .HasMaxLength(50);

                entity.Property(e => e.Youxiao)
                    .HasColumnName("youxiao")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Zongtouzhu)
                    .HasColumnName("zongtouzhu")
                    .HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<FinanceRemittance>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Code)
                    .HasColumnName("code")
                    .HasMaxLength(50);

                entity.Property(e => e.CreateDate)
                    .HasColumnName("createDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.IsFree).HasColumnName("isFree");

                entity.Property(e => e.LoginName)
                    .HasColumnName("loginName")
                    .HasMaxLength(50);

                entity.Property(e => e.RemittanceAddr).HasMaxLength(500);

                entity.Property(e => e.RemittanceAfterAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.RemittanceAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.RemittanceBankName).HasMaxLength(100);

                entity.Property(e => e.RemittanceBeforeAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.RemittanceDate).HasColumnType("datetime");

                entity.Property(e => e.RemittanceType).HasMaxLength(50);

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasMaxLength(10);
            });

            modelBuilder.Entity<FinanceReport>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AccessAfterAmount)
                    .HasColumnName("accessAfterAmount")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.AccessAmountIn)
                    .HasColumnName("accessAmountIn")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.AccessAmountOut)
                    .HasColumnName("accessAmountOut")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CraeteData)
                    .HasColumnName("craeteData")
                    .HasColumnType("datetime");

                entity.Property(e => e.LoginName)
                    .HasColumnName("loginName")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<FinanceSum>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("FinanceSum");

                entity.Property(e => e.Caijin).HasColumnType("decimal(38, 2)");

                entity.Property(e => e.Date)
                    .HasColumnName("date")
                    .HasColumnType("datetime");

                entity.Property(e => e.DepositAlipay)
                    .HasColumnName("Deposit_Alipay")
                    .HasColumnType("decimal(38, 2)");

                entity.Property(e => e.DepositCompany)
                    .HasColumnName("Deposit_Company")
                    .HasColumnType("decimal(38, 2)");

                entity.Property(e => e.DepositHongbao)
                    .HasColumnName("Deposit_Hongbao")
                    .HasColumnType("decimal(38, 2)");

                entity.Property(e => e.DepositOnline)
                    .HasColumnName("Deposit_Online")
                    .HasColumnType("decimal(38, 2)");

                entity.Property(e => e.DepositQqpay)
                    .HasColumnName("Deposit_QQpay")
                    .HasColumnType("decimal(38, 2)");

                entity.Property(e => e.DepositWeixin)
                    .HasColumnName("Deposit_Weixin")
                    .HasColumnType("decimal(38, 2)");

                entity.Property(e => e.IncomeOther)
                    .HasColumnName("Income_Other")
                    .HasColumnType("decimal(38, 2)");

                entity.Property(e => e.LoginName)
                    .HasColumnName("loginName")
                    .HasMaxLength(50);

                entity.Property(e => e.OutcomeOther)
                    .HasColumnName("Outcome_Other")
                    .HasColumnType("decimal(38, 2)");

                entity.Property(e => e.Present).HasColumnType("decimal(38, 2)");

                entity.Property(e => e.WheelAmount).HasColumnType("decimal(38, 2)");

                entity.Property(e => e.Withdraw).HasColumnType("decimal(38, 2)");

                entity.Property(e => e.Ylsm)
                    .HasColumnName("ylsm")
                    .HasColumnType("decimal(38, 2)");

                entity.Property(e => e.ZrTuishui).HasColumnType("decimal(38, 2)");
            });

            modelBuilder.Entity<Financebak>(entity =>
            {
                entity.HasIndex(e => new { e.CraeteData, e.LoginName, e.Rid })
                    .HasName("NonClusteredIndex-Finance");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.AccessAfterAmount)
                    .HasColumnName("accessAfterAmount")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.AccessAmount)
                    .HasColumnName("accessAmount")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.AccessBeforeAmount)
                    .HasColumnName("accessBeforeAmount")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CraeteData)
                    .HasColumnName("craeteData")
                    .HasColumnType("datetime");

                entity.Property(e => e.LoginName)
                    .HasColumnName("loginName")
                    .HasMaxLength(50);

                entity.Property(e => e.Remark).HasMaxLength(100);

                entity.Property(e => e.Rid).HasColumnName("rid");

                entity.Property(e => e.Type)
                    .HasColumnName("type")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Financetmp>(entity =>
            {
                entity.HasIndex(e => new { e.LoginName, e.CraeteData })
                    .HasName("NonClusteredIndex-20180802-172754");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.AccessAfterAmount)
                    .HasColumnName("accessAfterAmount")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.AccessAmount)
                    .HasColumnName("accessAmount")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.AccessBeforeAmount)
                    .HasColumnName("accessBeforeAmount")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CraeteData)
                    .HasColumnName("craeteData")
                    .HasColumnType("datetime");

                entity.Property(e => e.LoginName)
                    .HasColumnName("loginName")
                    .HasMaxLength(50);

                entity.Property(e => e.Remark).HasMaxLength(100);

                entity.Property(e => e.Rid).HasColumnName("rid");

                entity.Property(e => e.Type)
                    .HasColumnName("type")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Financetmp1>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.AccessAfterAmount)
                    .HasColumnName("accessAfterAmount")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.AccessAmount)
                    .HasColumnName("accessAmount")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.AccessBeforeAmount)
                    .HasColumnName("accessBeforeAmount")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CraeteData)
                    .HasColumnName("craeteData")
                    .HasColumnType("datetime");

                entity.Property(e => e.LoginName)
                    .HasColumnName("loginName")
                    .HasMaxLength(50);

                entity.Property(e => e.Remark).HasMaxLength(100);

                entity.Property(e => e.Rid).HasColumnName("rid");

                entity.Property(e => e.Type)
                    .HasColumnName("type")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<GameDataFile>(entity =>
            {
                entity.ToTable("game_data_file");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.FileName).HasMaxLength(250);

                entity.Property(e => e.FilePath).HasMaxLength(250);

                entity.Property(e => e.LastUpdateTime).HasColumnType("datetime");

                entity.Property(e => e.NeedUpdate).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<GenerateCode>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.DateTime).HasColumnType("datetime");

                entity.Property(e => e.Index).HasColumnName("index");

                entity.Property(e => e.Type)
                    .HasColumnName("type")
                    .HasMaxLength(50);
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

            modelBuilder.Entity<GqcheckLog>(entity =>
            {
                entity.HasKey(e => e.OrderId)
                    .HasName("PK__GQCheckL__0809337D722C0F25");

                entity.ToTable("GQCheckLog");

                entity.Property(e => e.OrderId)
                    .HasColumnName("orderID")
                    .ValueGeneratedNever();

                entity.Property(e => e.CreateTime)
                    .HasColumnName("createTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.MatchView).HasColumnName("matchView");

                entity.Property(e => e.OrderView).HasColumnName("orderView");
            });

            modelBuilder.Entity<GroupOrder>(entity =>
            {
                entity.HasIndex(e => e.SubmitTime)
                    .HasName("NonClusteredIndex-20180802-171823");

                entity.HasIndex(e => new { e.Id, e.Code, e.SubmitTime, e.LoginName, e.Status })
                    .HasName("NonClusteredIndex-20160621-153017");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Amount)
                    .HasColumnName("amount")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Code)
                    .HasColumnName("code")
                    .HasMaxLength(50)
                    .HasComment("串关注单号");

                entity.Property(e => e.Count)
                    .HasColumnName("count")
                    .HasComment("子单数");

                entity.Property(e => e.LoginName)
                    .HasColumnName("loginName")
                    .HasMaxLength(50)
                    .HasComment("创建人");

                entity.Property(e => e.ResultAmount)
                    .HasColumnName("resultAmount")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasMaxLength(50)
                    .HasComment("状态");

                entity.Property(e => e.SubmitTime)
                    .HasColumnName("submitTime")
                    .HasColumnType("datetime")
                    .HasComment("创建时间");

                entity.Property(e => e.TheoryAmount)
                    .HasColumnName("theoryAmount")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TuishuiAmount)
                    .HasColumnName("tuishuiAmount")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Youxiao)
                    .HasColumnName("youxiao")
                    .HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<GroupOrder2>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("GroupOrder2");

                entity.Property(e => e.AccessAfterAmount)
                    .HasColumnName("accessAfterAmount")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.AccessBeforeAmount)
                    .HasColumnName("accessBeforeAmount")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Amount)
                    .HasColumnName("amount")
                    .HasColumnType("decimal(38, 2)");

                entity.Property(e => e.Code)
                    .HasColumnName("code")
                    .HasMaxLength(50);

                entity.Property(e => e.Count).HasColumnName("count");

                entity.Property(e => e.Group).HasColumnName("group");

                entity.Property(e => e.LogionName)
                    .HasColumnName("logionName")
                    .HasMaxLength(50);

                entity.Property(e => e.ResultAmount)
                    .HasColumnName("resultAmount")
                    .HasColumnType("decimal(38, 2)");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.SubmitTime)
                    .HasColumnName("submitTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.TheoryAmount)
                    .HasColumnName("theoryAmount")
                    .HasColumnType("decimal(38, 2)");

                entity.Property(e => e.Yijiesuan).HasColumnName("yijiesuan");
            });

            modelBuilder.Entity<GroupOrderAsync>(entity =>
            {
                entity.ToTable("GroupOrder_Async");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Dtime)
                    .HasColumnName("dtime")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<GroupOrderView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("GroupOrderView");

                entity.Property(e => e.AccessAfterAmount)
                    .HasColumnName("accessAfterAmount")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.AccessBeforeAmount)
                    .HasColumnName("accessBeforeAmount")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Amount)
                    .HasColumnName("amount")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Code)
                    .HasColumnName("code")
                    .HasMaxLength(50);

                entity.Property(e => e.Count).HasColumnName("count");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.LoginName)
                    .HasColumnName("loginName")
                    .HasMaxLength(50);

                entity.Property(e => e.ResultAmount)
                    .HasColumnName("resultAmount")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasMaxLength(50);

                entity.Property(e => e.SubmitTime)
                    .HasColumnName("submitTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.TheoryAmount)
                    .HasColumnName("theoryAmount")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TuishuiAmount)
                    .HasColumnName("tuishuiAmount")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Yijiesuan).HasColumnName("yijiesuan");

                entity.Property(e => e.Youxiao)
                    .HasColumnName("youxiao")
                    .HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<Hongbao>(entity =>
            {
                entity.HasKey(e => e.Gid)
                    .HasName("PK__Hongbao__DCD80EF8E7941FD1");

                entity.Property(e => e.Gid)
                    .HasColumnName("gid")
                    .ValueGeneratedNever();

                entity.Property(e => e.Account)
                    .HasColumnName("account")
                    .HasMaxLength(100);

                entity.Property(e => e.AccountType)
                    .HasColumnName("accountType")
                    .HasMaxLength(100);

                entity.Property(e => e.ApprovedStatus)
                    .HasColumnName("approvedStatus")
                    .HasMaxLength(20);

                entity.Property(e => e.ApprovedTime)
                    .HasColumnName("approvedTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.CreateTime)
                    .HasColumnName("createTime")
                    .HasMaxLength(40);

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasMaxLength(40);

                entity.Property(e => e.IsReal)
                    .HasColumnName("isReal")
                    .HasMaxLength(20);

                entity.Property(e => e.LastUpdateTime)
                    .HasColumnName("lastUpdateTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.Money)
                    .HasColumnName("money")
                    .HasMaxLength(100);

                entity.Property(e => e.NickName)
                    .HasColumnName("nickName")
                    .HasMaxLength(40);

                entity.Property(e => e.PhoneNumber)
                    .HasColumnName("phoneNumber")
                    .HasMaxLength(20);

                entity.Property(e => e.Remark)
                    .HasColumnName("remark")
                    .HasMaxLength(1000);

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasMaxLength(40);

                entity.Property(e => e.UpdateTime)
                    .HasColumnName("updateTime")
                    .HasMaxLength(40);

                entity.Property(e => e.UserId)
                    .HasColumnName("userId")
                    .HasMaxLength(40);
            });

            modelBuilder.Entity<Hongbaoview>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("hongbaoview");

                entity.Property(e => e.Account)
                    .HasColumnName("account")
                    .HasMaxLength(100);

                entity.Property(e => e.AccountType)
                    .HasColumnName("accountType")
                    .HasMaxLength(100);

                entity.Property(e => e.ApprovedStatus)
                    .HasColumnName("approvedStatus")
                    .HasMaxLength(20);

                entity.Property(e => e.ApprovedTime)
                    .HasColumnName("approvedTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.CreateTime)
                    .HasColumnName("createTime")
                    .HasMaxLength(40);

                entity.Property(e => e.Gid).HasColumnName("gid");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasMaxLength(40);

                entity.Property(e => e.IsReal)
                    .HasColumnName("isReal")
                    .HasMaxLength(20);

                entity.Property(e => e.LastUpdateTime)
                    .HasColumnName("lastUpdateTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.Money)
                    .HasColumnName("money")
                    .HasMaxLength(100);

                entity.Property(e => e.NickName)
                    .HasColumnName("nickName")
                    .HasMaxLength(40);

                entity.Property(e => e.PhoneNumber)
                    .HasColumnName("phoneNumber")
                    .HasMaxLength(20);

                entity.Property(e => e.Remark)
                    .HasColumnName("remark")
                    .HasMaxLength(1000);

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasMaxLength(40);

                entity.Property(e => e.UpdateTime)
                    .HasColumnName("updateTime")
                    .HasMaxLength(40);

                entity.Property(e => e.UserId)
                    .HasColumnName("userId")
                    .HasMaxLength(40);

                entity.Property(e => e.Username)
                    .HasColumnName("username")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Iplog>(entity =>
            {
                entity.ToTable("IPLog");

                entity.HasIndex(e => e.LoginName)
                    .HasName("IPLog_Index");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreateTime)
                    .HasColumnName("createTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.Ip)
                    .HasColumnName("ip")
                    .HasMaxLength(15);

                entity.Property(e => e.LoginName)
                    .HasColumnName("loginName")
                    .HasMaxLength(50);

                entity.Property(e => e.SiteName)
                    .HasColumnName("siteName")
                    .HasMaxLength(50);

                entity.Property(e => e.Url)
                    .HasColumnName("url")
                    .HasMaxLength(200);
            });

            modelBuilder.Entity<Ipsource>(entity =>
            {
                entity.ToTable("IPSource");

                entity.HasIndex(e => new { e.Name, e.Bg, e.Ed })
                    .HasName("NonClusteredIndex-20160621-153136");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Bg)
                    .HasColumnName("bg")
                    .HasMaxLength(50);

                entity.Property(e => e.Ed)
                    .HasColumnName("ed")
                    .HasMaxLength(50);

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<LotteryItemsView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("lotteryItemsView");

                entity.Property(e => e.ButchNo)
                    .HasColumnName("butchNo")
                    .HasMaxLength(30);

                entity.Property(e => e.Code)
                    .HasColumnName("code")
                    .HasMaxLength(50);

                entity.Property(e => e.CreateTime)
                    .HasColumnName("createTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.CreteSource)
                    .HasColumnName("creteSource")
                    .HasMaxLength(100);

                entity.Property(e => e.Ext1)
                    .HasColumnName("ext1")
                    .HasMaxLength(50);

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ItemMoney)
                    .HasColumnName("itemMoney")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.LoginName)
                    .HasColumnName("loginName")
                    .HasMaxLength(50);

                entity.Property(e => e.LotteryName)
                    .HasColumnName("lotteryName")
                    .HasMaxLength(30);

                entity.Property(e => e.OddsGroupName)
                    .HasColumnName("oddsGroupName")
                    .HasMaxLength(40);

                entity.Property(e => e.OddsName)
                    .HasColumnName("oddsName")
                    .HasMaxLength(50);

                entity.Property(e => e.OrderMoney)
                    .HasColumnName("orderMoney")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.PointsOdds)
                    .HasColumnName("points_Odds")
                    .HasColumnType("decimal(18, 5)");

                entity.Property(e => e.SettleMoney)
                    .HasColumnName("settleMoney")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasMaxLength(30);

                entity.Property(e => e.TheoryMoney)
                    .HasColumnName("theoryMoney")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TuishuiAmount)
                    .HasColumnName("tuishuiAmount")
                    .HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<LotteryOrderPrizeview>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("LotteryOrderPrizeview");

                entity.Property(e => e.ButchNo)
                    .HasColumnName("butchNo")
                    .HasMaxLength(30);

                entity.Property(e => e.Code)
                    .HasColumnName("code")
                    .HasMaxLength(50);

                entity.Property(e => e.CreateTime)
                    .HasColumnName("createTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.CreteSource)
                    .HasColumnName("creteSource")
                    .HasMaxLength(100);

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Ischuan).HasColumnName("ischuan");

                entity.Property(e => e.LastUpdateTime).HasColumnType("datetime");

                entity.Property(e => e.LoginName)
                    .HasColumnName("loginName")
                    .HasMaxLength(50);

                entity.Property(e => e.LotteryName)
                    .HasColumnName("lotteryName")
                    .HasMaxLength(30);

                entity.Property(e => e.OrderMoney)
                    .HasColumnName("orderMoney")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.PrizeData).HasMaxLength(200);

                entity.Property(e => e.Prizestatus).HasMaxLength(50);

                entity.Property(e => e.Remark).HasMaxLength(50);

                entity.Property(e => e.SettleMoney)
                    .HasColumnName("settleMoney")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasMaxLength(30);

                entity.Property(e => e.TheoryMoney)
                    .HasColumnName("theoryMoney")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TuishuiAmount)
                    .HasColumnName("tuishuiAmount")
                    .HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<MaintenancePlan>(entity =>
            {
                entity.HasIndex(e => new { e.StartTime, e.EndTime })
                    .HasName("NonClusteredIndex-20160621-153234");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Contents).HasMaxLength(2000);

                entity.Property(e => e.EndTime).HasColumnType("datetime");

                entity.Property(e => e.PlanScope).HasMaxLength(200);

                entity.Property(e => e.StartTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<MenuInit>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Exption1)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Exption2)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Exption3)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.GroupName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.IsShow).HasDefaultValueSql("((1))");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<MessageQueue>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.LoginName).HasMaxLength(50);

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<MonitoringAlarmMessage>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.AlarmDescription).HasMaxLength(400);

                entity.Property(e => e.AlarmLevel)
                    .IsRequired()
                    .HasMaxLength(5);

                entity.Property(e => e.AlarmName).HasMaxLength(100);

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.HostGroup).HasMaxLength(100);

                entity.Property(e => e.HostId).HasColumnName("HostID");

                entity.Property(e => e.HostName).HasMaxLength(100);

                entity.Property(e => e.SendTime).HasColumnType("datetime");

                entity.Property(e => e.Status).HasMaxLength(200);

                entity.Property(e => e.ToUser).HasMaxLength(200);
            });

            modelBuilder.Entity<News>(entity =>
            {
                entity.HasIndex(e => new { e.Id, e.Title, e.CreateTime, e.Status })
                    .HasName("NonClusteredIndex-20160621-153324");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Banner)
                    .HasColumnName("banner")
                    .HasMaxLength(1000);

                entity.Property(e => e.Banner2)
                    .HasColumnName("banner2")
                    .HasMaxLength(500);

                entity.Property(e => e.Body).HasColumnName("body");

                entity.Property(e => e.CreateTime)
                    .HasColumnName("createTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.NewsTypeId).HasColumnName("newsTypeId");

                entity.Property(e => e.NewsTypeName)
                    .HasColumnName("newsTypeName")
                    .HasMaxLength(200);

                entity.Property(e => e.Sitekey)
                    .HasColumnName("sitekey")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Sortkey).HasColumnName("sortkey");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasMaxLength(10);

                entity.Property(e => e.Title)
                    .HasColumnName("title")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<NewsApply>(entity =>
            {
                entity.HasIndex(e => e.NewsId)
                    .HasName("NewsApply_Index");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Body).HasMaxLength(500);

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.Type).HasMaxLength(50);
            });

            modelBuilder.Entity<NewsApplyOrder>(entity =>
            {
                entity.HasIndex(e => new { e.NewsId, e.LoginName })
                    .HasName("NewsApplyOrder_Index");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.ApplyNo).HasMaxLength(100);

                entity.Property(e => e.ApplyTime).HasColumnType("datetime");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.Ip)
                    .HasColumnName("IP")
                    .HasMaxLength(50);

                entity.Property(e => e.LoginName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Reamrk).HasMaxLength(500);
            });

            modelBuilder.Entity<NewsApplyOrderDetail>(entity =>
            {
                entity.HasIndex(e => new { e.NewsApplyId, e.NewsApplyOrderId })
                    .HasName("NewsApplyOrderDetail_Index");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Content).HasMaxLength(2000);

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.Name).HasMaxLength(500);

                entity.Property(e => e.Reamrk).HasMaxLength(200);
            });

            modelBuilder.Entity<NewsType>(entity =>
            {
                entity.ToTable("newsType");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Exption1)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Exption2)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ParentId).HasColumnName("parentId");

                entity.Property(e => e.Sort).HasColumnName("sort");

                entity.Property(e => e.TypeName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<OnlinePlay>(entity =>
            {
                entity.HasIndex(e => e.Code)
                    .HasName("OnlinePlaycodeIndex");

                entity.HasIndex(e => new { e.Id, e.LoginName, e.Code, e.Status })
                    .HasName("NonClusteredIndex-20160621-153410");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Amount)
                    .HasColumnName("amount")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Code)
                    .HasColumnName("code")
                    .HasMaxLength(100);

                entity.Property(e => e.CreateTime)
                    .HasColumnName("createTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.LoginName)
                    .HasColumnName("loginName")
                    .HasMaxLength(50);

                entity.Property(e => e.Operator).HasMaxLength(50);

                entity.Property(e => e.PlayType)
                    .HasColumnName("playType")
                    .HasMaxLength(50);

                entity.Property(e => e.Remark).HasColumnName("remark");

                entity.Property(e => e.Remark1).HasColumnName("remark1");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasMaxLength(10);

                entity.Property(e => e.SuccessTime)
                    .HasColumnName("successTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.ThirdLog).HasColumnName("thirdLog");

                entity.Property(e => e.ThirdPlatformNo)
                    .HasColumnName("thirdPlatformNo")
                    .HasMaxLength(300);
            });

            modelBuilder.Entity<OptSettlementLog>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CurrentScore).HasMaxLength(50);

                entity.Property(e => e.CurrentStatus).HasMaxLength(50);

                entity.Property(e => e.LoginName)
                    .HasColumnName("loginName")
                    .HasMaxLength(50);

                entity.Property(e => e.OptTime).HasColumnType("datetime");

                entity.Property(e => e.OrderCode).HasMaxLength(50);

                entity.Property(e => e.OrderId).HasColumnName("OrderID");

                entity.Property(e => e.OrderMoney).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.OrderTime).HasColumnType("datetime");

                entity.Property(e => e.ResultMoney).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<Order>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .IsClustered(false);

                entity.ToTable("order");

                entity.HasIndex(e => e.SubmitTime)
                    .HasName("NonClusteredIndex-20180802-171706");

                entity.HasIndex(e => new { e.SubmitTime, e.GroupCode })
                    .HasName("ordergroupCodeIndex");

                entity.HasIndex(e => new { e.GroupCode, e.LogionName, e.SubmitTime })
                    .HasName("ordergroupCodelogionNamesubmitTimeIndex");

                entity.HasIndex(e => new { e.SubmitTime, e.GroupCode, e.Status })
                    .HasName("ordergroupCodestatusIndex");

                entity.HasIndex(e => new { e.PlayType, e.SubmitTime, e.GroupCode, e.LogionName })
                    .HasName("ordergroupCodelogionNameIndex");

                entity.HasIndex(e => new { e.Id, e.Code, e.MatchId, e.MatchName, e.MatchType, e.Type, e.SubmitTime, e.LogionName, e.Status, e.Islock })
                    .HasName("NonClusteredIndex-20160621-153507");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasComment("主键")
                    .ValueGeneratedNever();

                entity.Property(e => e.AccessAfterAmount)
                    .HasColumnName("accessAfterAmount")
                    .HasColumnType("decimal(18, 2)")
                    .HasComment("投注后金额");

                entity.Property(e => e.AccessBeforeAmount)
                    .HasColumnName("accessBeforeAmount")
                    .HasColumnType("decimal(18, 2)")
                    .HasComment("投注前金额");

                entity.Property(e => e.Amount)
                    .HasColumnName("amount")
                    .HasColumnType("decimal(18, 2)")
                    .HasComment("下注金额");

                entity.Property(e => e.BeginTime)
                    .HasColumnName("beginTime")
                    .HasColumnType("datetime")
                    .HasComment("开赛时间");

                entity.Property(e => e.Code)
                    .HasColumnName("code")
                    .HasMaxLength(50)
                    .HasComment("订单编号");

                entity.Property(e => e.ContextExt).HasMaxLength(50);

                entity.Property(e => e.CreteSource)
                    .HasColumnName("creteSource")
                    .HasMaxLength(100);

                entity.Property(e => e.Freeze).HasMaxLength(2);

                entity.Property(e => e.Gidm).HasColumnName("gidm");

                entity.Property(e => e.GroupCode)
                    .HasColumnName("groupCode")
                    .HasMaxLength(50)
                    .HasComment("如果是组订单，则存储订单号");

                entity.Property(e => e.HostsTing)
                    .HasColumnName("hosts_ting")
                    .HasMaxLength(500)
                    .HasComment("主客队。格式如：（上海恒大=北京恒大）");

                entity.Property(e => e.Info).HasMaxLength(250);

                entity.Property(e => e.IsToSettlement).HasColumnName("isToSettlement");

                entity.Property(e => e.Islock)
                    .HasColumnName("islock")
                    .HasColumnType("datetime");

                entity.Property(e => e.LogionName)
                    .HasColumnName("logionName")
                    .HasMaxLength(50)
                    .HasComment("会员名称");

                entity.Property(e => e.MatchId)
                    .HasColumnName("matchID")
                    .HasComment("赛事ID");

                entity.Property(e => e.MatchName)
                    .HasColumnName("matchName")
                    .HasMaxLength(50)
                    .HasComment("联赛名");

                entity.Property(e => e.MatchTime)
                    .HasColumnName("matchTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.MatchType)
                    .HasColumnName("matchType")
                    .HasMaxLength(50)
                    .HasComment("赛事类型");

                entity.Property(e => e.Odds)
                    .HasColumnName("odds")
                    .HasColumnType("decimal(18, 2)")
                    .HasComment("赔率");

                entity.Property(e => e.OrderContent)
                    .HasMaxLength(50)
                    .HasComment("比如投注球队名称，");

                entity.Property(e => e.PlayType)
                    .HasColumnName("playType")
                    .HasMaxLength(50)
                    .HasComment("投注内容（让球，大小，独赢……）");

                entity.Property(e => e.Remark)
                    .HasColumnName("remark")
                    .HasMaxLength(200)
                    .HasComment("备注信息（用于处理异常投注的处理结果的信息存储）");

                entity.Property(e => e.ResultAmount)
                    .HasColumnName("resultAmount")
                    .HasColumnType("decimal(18, 2)")
                    .HasComment("实际赢取金额");

                entity.Property(e => e.Score)
                    .HasMaxLength(50)
                    .HasComment("当时比分，格式（主队/客队）");

                entity.Property(e => e.ScoreJu).HasMaxLength(50);

                entity.Property(e => e.ScorePan).HasMaxLength(50);

                entity.Property(e => e.ScoreRedCard).HasMaxLength(5);

                entity.Property(e => e.SettlementHpoint)
                    .HasColumnName("SettlementHPoint")
                    .HasMaxLength(100);

                entity.Property(e => e.SettlementTpoint)
                    .HasColumnName("SettlementTPoint")
                    .HasMaxLength(100);

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasMaxLength(50)
                    .HasComment("状态（未结算，赢一半，赢，输，输一半，无效，取消，和局）");

                entity.Property(e => e.SubmitTime)
                    .HasColumnName("submitTime")
                    .HasColumnType("datetime")
                    .HasComment("投注时间");

                entity.Property(e => e.SubmitTimeapprove)
                    .HasColumnName("submitTimeapprove")
                    .HasColumnType("datetime");

                entity.Property(e => e.TheoryAmount)
                    .HasColumnName("theoryAmount")
                    .HasColumnType("decimal(18, 2)")
                    .HasComment("理论赢取金额");

                entity.Property(e => e.TuishuiAmount)
                    .HasColumnName("tuishuiAmount")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Type)
                    .HasColumnName("type")
                    .HasMaxLength(50)
                    .HasComment("投注类型（赛事、滚球、早餐）");

                entity.Property(e => e.Youxiao)
                    .HasColumnName("youxiao")
                    .HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<Order3>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("order3");

                entity.Property(e => e.AccessAfterAmount)
                    .HasColumnName("accessAfterAmount")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.AccessBeforeAmount)
                    .HasColumnName("accessBeforeAmount")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Amount)
                    .HasColumnName("amount")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.BeginTime)
                    .HasColumnName("beginTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.Code)
                    .HasColumnName("code")
                    .HasMaxLength(50);

                entity.Property(e => e.ContextExt).HasMaxLength(50);

                entity.Property(e => e.GroupCode)
                    .HasColumnName("groupCode")
                    .HasMaxLength(50);

                entity.Property(e => e.HostsTing)
                    .HasColumnName("hosts_ting")
                    .HasMaxLength(500);

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.LogionName)
                    .HasColumnName("logionName")
                    .HasMaxLength(50);

                entity.Property(e => e.MatchId).HasColumnName("matchID");

                entity.Property(e => e.MatchName)
                    .HasColumnName("matchName")
                    .HasMaxLength(50);

                entity.Property(e => e.MatchType)
                    .HasColumnName("matchType")
                    .HasMaxLength(50);

                entity.Property(e => e.Odds)
                    .HasColumnName("odds")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.OrderContent).HasMaxLength(50);

                entity.Property(e => e.PlayType)
                    .HasColumnName("playType")
                    .HasMaxLength(50);

                entity.Property(e => e.Remark)
                    .HasColumnName("remark")
                    .HasMaxLength(200);

                entity.Property(e => e.ResultAmount)
                    .HasColumnName("resultAmount")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Score).HasMaxLength(50);

                entity.Property(e => e.ScoreJu).HasMaxLength(50);

                entity.Property(e => e.ScorePan).HasMaxLength(50);

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasMaxLength(50);

                entity.Property(e => e.SubmitTime)
                    .HasColumnName("submitTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.TheoryAmount)
                    .HasColumnName("theoryAmount")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TuishuiAmount)
                    .HasColumnName("tuishuiAmount")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Type)
                    .HasColumnName("type")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<OrderAll>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("OrderAll");

                entity.Property(e => e.Amount)
                    .HasColumnName("amount")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Code)
                    .HasColumnName("code")
                    .HasMaxLength(100);

                entity.Property(e => e.CreateTime)
                    .HasColumnName("createTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.LoginName)
                    .HasColumnName("loginName")
                    .HasMaxLength(50);

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasMaxLength(50);

                entity.Property(e => e.TuishuiAmount)
                    .HasColumnName("tuishuiAmount")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.ValidAmount)
                    .HasColumnName("validAmount")
                    .HasColumnType("decimal(19, 2)");
            });

            modelBuilder.Entity<OrderAsync>(entity =>
            {
                entity.ToTable("order_Async");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Dtime)
                    .HasColumnName("dtime")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<OrderBakTo20150101>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("order_Bak_To20150101");

                entity.Property(e => e.AccessAfterAmount)
                    .HasColumnName("accessAfterAmount")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.AccessBeforeAmount)
                    .HasColumnName("accessBeforeAmount")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Amount)
                    .HasColumnName("amount")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.BeginTime)
                    .HasColumnName("beginTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.Code)
                    .HasColumnName("code")
                    .HasMaxLength(50);

                entity.Property(e => e.ContextExt).HasMaxLength(50);

                entity.Property(e => e.CreteSource)
                    .HasColumnName("creteSource")
                    .HasMaxLength(100);

                entity.Property(e => e.Freeze).HasMaxLength(2);

                entity.Property(e => e.GroupCode)
                    .HasColumnName("groupCode")
                    .HasMaxLength(50);

                entity.Property(e => e.HostsTing)
                    .HasColumnName("hosts_ting")
                    .HasMaxLength(500);

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.IsToSettlement).HasColumnName("isToSettlement");

                entity.Property(e => e.Islock)
                    .HasColumnName("islock")
                    .HasColumnType("datetime");

                entity.Property(e => e.LogionName)
                    .HasColumnName("logionName")
                    .HasMaxLength(50);

                entity.Property(e => e.MatchId).HasColumnName("matchID");

                entity.Property(e => e.MatchName)
                    .HasColumnName("matchName")
                    .HasMaxLength(50);

                entity.Property(e => e.MatchTime)
                    .HasColumnName("matchTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.MatchType)
                    .HasColumnName("matchType")
                    .HasMaxLength(50);

                entity.Property(e => e.Odds)
                    .HasColumnName("odds")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.OrderContent).HasMaxLength(50);

                entity.Property(e => e.PlayType)
                    .HasColumnName("playType")
                    .HasMaxLength(50);

                entity.Property(e => e.Remark)
                    .HasColumnName("remark")
                    .HasMaxLength(200);

                entity.Property(e => e.ResultAmount)
                    .HasColumnName("resultAmount")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Score).HasMaxLength(50);

                entity.Property(e => e.ScoreJu).HasMaxLength(50);

                entity.Property(e => e.ScorePan).HasMaxLength(50);

                entity.Property(e => e.SettlementHpoint)
                    .HasColumnName("SettlementHPoint")
                    .HasMaxLength(100);

                entity.Property(e => e.SettlementTpoint)
                    .HasColumnName("SettlementTPoint")
                    .HasMaxLength(100);

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasMaxLength(50);

                entity.Property(e => e.SubmitTime)
                    .HasColumnName("submitTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.SubmitTimeapprove)
                    .HasColumnName("submitTimeapprove")
                    .HasColumnType("datetime");

                entity.Property(e => e.TheoryAmount)
                    .HasColumnName("theoryAmount")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TuishuiAmount)
                    .HasColumnName("tuishuiAmount")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Type)
                    .HasColumnName("type")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<OrderCsp>(entity =>
            {
                entity.ToTable("OrderCSP");

                entity.HasIndex(e => new { e.Account, e.BetTime, e.OrderNo })
                    .HasName("OrderCSP_Index");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Account)
                    .HasColumnName("account")
                    .HasMaxLength(50);

                entity.Property(e => e.AwayInBall)
                    .HasColumnName("awayInBall")
                    .HasMaxLength(50);

                entity.Property(e => e.AwayInBallHalf)
                    .HasColumnName("awayInBallHalf")
                    .HasMaxLength(50);

                entity.Property(e => e.BetOrderId)
                    .IsRequired()
                    .HasColumnName("betOrderId")
                    .HasMaxLength(100);

                entity.Property(e => e.BetOrderStatus)
                    .HasColumnName("betOrderStatus")
                    .HasMaxLength(50);

                entity.Property(e => e.BetTime)
                    .HasColumnName("betTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.BoiId)
                    .IsRequired()
                    .HasColumnName("boiId")
                    .HasMaxLength(100);

                entity.Property(e => e.Ceiling)
                    .HasColumnName("ceiling")
                    .HasColumnType("decimal(15, 2)");

                entity.Property(e => e.Check).HasColumnName("check");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.Fstatus).HasColumnName("fstatus");

                entity.Property(e => e.GameType)
                    .HasColumnName("gameType")
                    .HasMaxLength(50);

                entity.Property(e => e.HomeInBall)
                    .HasColumnName("homeInBall")
                    .HasMaxLength(50);

                entity.Property(e => e.HomeInBallHalf)
                    .HasColumnName("homeInBallHalf")
                    .HasMaxLength(50);

                entity.Property(e => e.MatchDate)
                    .HasColumnName("matchDate")
                    .HasMaxLength(500);

                entity.Property(e => e.MatchInfo).HasColumnName("matchInfo");

                entity.Property(e => e.MatchRate)
                    .HasColumnName("matchRate")
                    .HasMaxLength(50);

                entity.Property(e => e.OrderNo)
                    .HasColumnName("orderNo")
                    .HasMaxLength(100);

                entity.Property(e => e.RealCeiling)
                    .HasColumnName("realCeiling")
                    .HasColumnType("decimal(15, 2)");

                entity.Property(e => e.RealWinCeiling)
                    .HasColumnName("realWinCeiling")
                    .HasColumnType("decimal(15, 2)");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasMaxLength(50);

                entity.Property(e => e.SubGameType)
                    .HasColumnName("subGameType")
                    .HasMaxLength(1000);

                entity.Property(e => e.SyncTime).HasColumnType("datetime");

                entity.Property(e => e.TuishuiCeiling).HasColumnType("decimal(15, 2)");

                entity.Property(e => e.Type)
                    .HasColumnName("type")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<OrderOriginal>(entity =>
            {
                entity.ToTable("orderOriginal");

                entity.HasIndex(e => e.SubmitTime)
                    .HasName("i_orderOriginal_submitTime")
                    .IsUnique();

                entity.HasIndex(e => new { e.Id, e.Code, e.MatchId, e.MatchName, e.MatchType, e.Type, e.GroupCode, e.SubmitTime, e.LogionName, e.Status })
                    .HasName("NonClusteredIndex-20160621-153619");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.AccessAfterAmount)
                    .HasColumnName("accessAfterAmount")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.AccessBeforeAmount)
                    .HasColumnName("accessBeforeAmount")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Amount)
                    .HasColumnName("amount")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.BeginTime)
                    .HasColumnName("beginTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.Code)
                    .HasColumnName("code")
                    .HasMaxLength(50);

                entity.Property(e => e.ContextExt).HasMaxLength(50);

                entity.Property(e => e.CreteSource)
                    .HasColumnName("creteSource")
                    .HasMaxLength(100);

                entity.Property(e => e.GroupCode)
                    .HasColumnName("groupCode")
                    .HasMaxLength(50);

                entity.Property(e => e.HostsTing)
                    .HasColumnName("hosts_ting")
                    .HasMaxLength(500);

                entity.Property(e => e.IsToSettlement).HasColumnName("isToSettlement");

                entity.Property(e => e.LogionName)
                    .HasColumnName("logionName")
                    .HasMaxLength(50);

                entity.Property(e => e.MatchId).HasColumnName("matchID");

                entity.Property(e => e.MatchName)
                    .HasColumnName("matchName")
                    .HasMaxLength(50);

                entity.Property(e => e.MatchTime)
                    .HasColumnName("matchTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.MatchType)
                    .HasColumnName("matchType")
                    .HasMaxLength(50);

                entity.Property(e => e.MatchViewData).HasColumnName("matchViewData");

                entity.Property(e => e.Odds)
                    .HasColumnName("odds")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.OrderContent).HasMaxLength(50);

                entity.Property(e => e.PlayType)
                    .HasColumnName("playType")
                    .HasMaxLength(50);

                entity.Property(e => e.Remark)
                    .HasColumnName("remark")
                    .HasMaxLength(200);

                entity.Property(e => e.ResultAmount)
                    .HasColumnName("resultAmount")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Score).HasMaxLength(50);

                entity.Property(e => e.ScoreJu).HasMaxLength(50);

                entity.Property(e => e.ScorePan).HasMaxLength(50);

                entity.Property(e => e.SettlementHpoint)
                    .HasColumnName("SettlementHPoint")
                    .HasMaxLength(100);

                entity.Property(e => e.SettlementTpoint)
                    .HasColumnName("SettlementTPoint")
                    .HasMaxLength(100);

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasMaxLength(50);

                entity.Property(e => e.SubmitTime)
                    .HasColumnName("submitTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.TheoryAmount)
                    .HasColumnName("theoryAmount")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TuishuiAmount)
                    .HasColumnName("tuishuiAmount")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Type)
                    .HasColumnName("type")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<PayCodeTypeSetting>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.DisplayName)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.Exption1)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Exption2)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Exption3)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasDefaultValueSql("('启用')");
            });

            modelBuilder.Entity<PaySetting>(entity =>
            {
                entity.HasIndex(e => new { e.LastUpdate, e.PayType, e.Snk, e.Snk2, e.Snk3, e.BankAccount, e.BankName, e.Code, e.Code2, e.Id, e.Name, e.Status, e.TypeName })
                    .HasName("NonClusteredIndex-20160621-153737");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.BankAccount)
                    .HasColumnName("bankAccount")
                    .HasMaxLength(50);

                entity.Property(e => e.BankAccountUserName)
                    .HasColumnName("bankAccountUserName")
                    .HasMaxLength(50);

                entity.Property(e => e.BankName)
                    .HasColumnName("bankName")
                    .HasMaxLength(50);

                entity.Property(e => e.CallbackIp)
                    .HasColumnName("callbackIP")
                    .HasMaxLength(300);

                entity.Property(e => e.Code)
                    .HasColumnName("code")
                    .HasMaxLength(50);

                entity.Property(e => e.Code2)
                    .HasColumnName("code2")
                    .HasMaxLength(50);

                entity.Property(e => e.CreateTime)
                    .HasColumnName("createTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.Deduction)
                    .HasColumnName("deduction")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.DepositBank).HasMaxLength(100);

                entity.Property(e => e.DirectConnectParam)
                    .HasColumnName("directConnectParam")
                    .HasMaxLength(100);

                entity.Property(e => e.FirstPresent).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.FixedAmount)
                    .HasColumnName("fixedAmount")
                    .HasMaxLength(2000)
                    .HasComment("充值的固定金额,用逗号隔开");

                entity.Property(e => e.GatewayUrl)
                    .HasColumnName("gatewayUrl")
                    .HasMaxLength(150);

                entity.Property(e => e.LastUpdate)
                    .HasColumnName("lastUpdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(50);

                entity.Property(e => e.PayType)
                    .HasColumnName("payType")
                    .HasMaxLength(50);

                entity.Property(e => e.PcShow).HasColumnName("pcShow");

                entity.Property(e => e.PhoneShow).HasColumnName("phoneShow");

                entity.Property(e => e.RandomDecimalAmount).HasColumnName("randomDecimalAmount");

                entity.Property(e => e.Remark)
                    .HasColumnName("remark")
                    .HasMaxLength(500);

                entity.Property(e => e.SiteName).HasMaxLength(100);

                entity.Property(e => e.Snk)
                    .HasColumnName("snk")
                    .HasColumnType("nvarchar(max)");

                entity.Property(e => e.Snk2)
                    .HasColumnName("snk2")
                    .HasColumnType("nvarchar(max)");

                entity.Property(e => e.Snk3)
                    .HasColumnName("snk3")
                    .HasColumnType("nvarchar(max)");

                entity.Property(e => e.Sort)
                    .HasColumnName("sort")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasMaxLength(50);

                entity.Property(e => e.TypeName)
                    .HasColumnName("typeName")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<PayTypeSetting>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.DisplayName)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.Exption1)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Exption2)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Exption3)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<PlayThreshold>(entity =>
            {
                entity.HasIndex(e => new { e.ItemType, e.LoginName })
                    .HasName("indexPlayThresholditemType");

                entity.HasIndex(e => new { e.Id, e.Name, e.MaxValue, e.ItemType, e.Sort, e.LoginName })
                    .HasName("NonClusteredIndex-20160621-153826");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.ItemType).HasColumnName("itemType");

                entity.Property(e => e.LoginName)
                    .HasColumnName("loginName")
                    .HasMaxLength(50);

                entity.Property(e => e.MaxValue)
                    .HasColumnName("maxValue")
                    .HasMaxLength(50);

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(50);

                entity.Property(e => e.Sort).HasColumnName("sort");
            });

            modelBuilder.Entity<PopupWindow>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Enable).HasColumnName("enable");

                entity.Property(e => e.Height)
                    .HasColumnName("height")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ImageUrl)
                    .HasColumnName("imageUrl")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SiteName)
                    .HasColumnName("siteName")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Text)
                    .HasColumnName("text")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.Title)
                    .HasColumnName("title")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Width)
                    .HasColumnName("width")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PtBetdetail>(entity =>
            {
                entity.HasKey(e => e.Gamecode);

                entity.ToTable("pt_betdetail");

                entity.Property(e => e.Gamecode)
                    .HasColumnName("gamecode")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.AgentSite)
                    .HasColumnName("agent_site")
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.Balance)
                    .HasColumnName("balance")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Bet)
                    .HasColumnName("bet")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.CreateTime)
                    .HasColumnName("create_time")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Currentbet)
                    .HasColumnName("currentbet")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Gamedate)
                    .HasColumnName("gamedate")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Gameid)
                    .HasColumnName("gameid")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Gamename)
                    .HasColumnName("gamename")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Gametype)
                    .HasColumnName("gametype")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Livenetwork)
                    .HasColumnName("livenetwork")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.MemberAccount)
                    .HasColumnName("member_account")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Playername)
                    .HasColumnName("playername")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Progressivebet)
                    .HasColumnName("progressivebet")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Progressivewin)
                    .HasColumnName("progressivewin")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Sessionid)
                    .HasColumnName("sessionid")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Win)
                    .HasColumnName("win")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Windowcode)
                    .HasColumnName("windowcode")
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PwdChanged>(entity =>
            {
                entity.HasKey(e => e.LoginName)
                    .HasName("PK__PwdChang__E37B63F85FCE0C18");

                entity.Property(e => e.LoginName)
                    .HasColumnName("loginName")
                    .HasMaxLength(100);

                entity.Property(e => e.LastTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<RedEnvelope>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Createtime)
                    .HasColumnName("createtime")
                    .HasColumnType("datetime");

                entity.Property(e => e.LoginName)
                    .HasColumnName("loginName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RedEnvelopePrizeId)
                    .HasColumnName("RedEnvelopePrizeID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Status).HasColumnName("status");
            });

            modelBuilder.Entity<RedEnvelopeConfig>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Creator)
                    .HasColumnName("creator")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IsEnable).HasColumnName("isEnable");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Price)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Probability)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RedEnvelopeNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RedEnvelopeType)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<RedEnvelopeConfigMoney>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.CanRedEnvelopeLevel)
                    .HasColumnName("canRedEnvelopeLevel")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MaxMoney)
                    .HasColumnName("maxMoney")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MinMoney)
                    .HasColumnName("minMoney")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Status).HasColumnName("status");
            });

            modelBuilder.Entity<RedEnvelopeDefault>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Createtime)
                    .HasColumnName("createtime")
                    .HasColumnType("datetime");

                entity.Property(e => e.LoginName)
                    .HasColumnName("loginName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RedEnvelopePrize)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Status).HasColumnName("status");
            });

            modelBuilder.Entity<RedEnvelopeLevelSetting>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.IsEnabled).HasColumnName("isEnabled");

                entity.Property(e => e.LevelName)
                    .HasColumnName("levelName")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<RedEnvelopePrize>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.CreateTime)
                    .HasColumnName("createTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.LoginName)
                    .HasColumnName("loginName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Price).HasColumnType("decimal(18, 0)");
            });

            modelBuilder.Entity<RedEnvelopeSetting>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Activity)
                    .HasColumnName("activity")
                    .IsUnicode(false);

                entity.Property(e => e.EndTime)
                    .HasColumnName("endTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.Flow)
                    .HasColumnName("flow")
                    .IsUnicode(false);

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.IpLimit)
                    .HasColumnName("ipLimit")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IsEnabled).HasColumnName("isEnabled");

                entity.Property(e => e.IsOneDayClearLimit).HasColumnName("isOneDayClearLimit");

                entity.Property(e => e.IsOneMemberDoOne).HasColumnName("isOneMemberDoOne");

                entity.Property(e => e.MobileLimit)
                    .HasColumnName("mobileLimit")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Remark)
                    .HasColumnName("remark")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Rules)
                    .HasColumnName("rules")
                    .IsUnicode(false);

                entity.Property(e => e.StartTime)
                    .HasColumnName("startTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.Statement)
                    .HasColumnName("statement")
                    .IsUnicode(false);

                entity.Property(e => e.TotalLimit).HasColumnName("totalLimit");

                entity.Property(e => e.WheelImgUrl)
                    .HasColumnName("wheelImgUrl")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.WheelName)
                    .HasColumnName("wheelName")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<RemittanceSetting>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.BankAddr)
                    .HasColumnName("bankAddr")
                    .HasMaxLength(100);

                entity.Property(e => e.BankCode)
                    .HasColumnName("bankCode")
                    .HasMaxLength(50);

                entity.Property(e => e.BankName)
                    .HasColumnName("bankName")
                    .HasMaxLength(50);

                entity.Property(e => e.CreateTime)
                    .HasColumnName("createTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.OpenName)
                    .HasColumnName("openName")
                    .HasMaxLength(50);

                entity.Property(e => e.UserGroup)
                    .HasColumnName("userGroup")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<RoleAuthMap>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Auth).HasMaxLength(50);

                entity.Property(e => e.RoleId).HasColumnName("RoleID");
            });

            modelBuilder.Entity<RoleManage>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Exption1)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Exption2)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Exption3)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.FunAuthList)
                    .IsRequired()
                    .HasColumnName("funAuthList")
                    .HasMaxLength(1000)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.MenuAuthList)
                    .IsRequired()
                    .HasColumnName("menuAuthList")
                    .HasMaxLength(1000)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.RoleName)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<Roles>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<SavedSetting>(entity =>
            {
                entity.HasKey(e => e.TableName)
                    .HasName("PK__SavedSet__93F7AC69E4B0AC59");

                entity.Property(e => e.TableName)
                    .HasColumnName("tableName")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<SetMessage>(entity =>
            {
                entity.HasIndex(e => new { e.MessType, e.Id, e.Title, e.BeginTime, e.EndTime, e.CreateTime, e.Type, e.UserName, e.IsRead })
                    .HasName("NonClusteredIndex-20160621-153914");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.BeginTime)
                    .HasColumnName("beginTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.Body).HasColumnName("body");

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

            modelBuilder.Entity<SettlementJob>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.ButchNo)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.LotteryName)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.PublishDate).HasColumnType("datetime");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<SettlementLog>(entity =>
            {
                entity.HasIndex(e => e.OrderCode)
                    .HasName("IX_SettlementLog");

                entity.HasIndex(e => new { e.Id, e.OrderCode, e.Type })
                    .HasName("NonClusteredIndex-20160621-154040");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Content)
                    .HasColumnName("content")
                    .HasMaxLength(500);

                entity.Property(e => e.CreateTime)
                    .HasColumnName("createTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.OrderCode)
                    .HasColumnName("orderCode")
                    .HasMaxLength(50);

                entity.Property(e => e.Source)
                    .HasColumnName("source")
                    .HasMaxLength(50);

                entity.Property(e => e.SysuerName)
                    .HasColumnName("sysuerName")
                    .HasMaxLength(50);

                entity.Property(e => e.Type).HasColumnName("type");
            });

            modelBuilder.Entity<SettlementLog2>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Content)
                    .HasColumnName("content")
                    .HasMaxLength(500);

                entity.Property(e => e.CreateTime)
                    .HasColumnName("createTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.OrderCode)
                    .HasColumnName("orderCode")
                    .HasMaxLength(100);

                entity.Property(e => e.Source)
                    .HasColumnName("source")
                    .HasMaxLength(50);

                entity.Property(e => e.SysuerName)
                    .HasColumnName("sysuerName")
                    .HasMaxLength(50);

                entity.Property(e => e.Type).HasColumnName("type");
            });

            modelBuilder.Entity<Sheet11>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Sheet11$");

                entity.Property(e => e.EMail)
                    .HasColumnName("E_Mail")
                    .HasMaxLength(255);

                entity.Property(e => e.代理).HasMaxLength(255);

                entity.Property(e => e.会员).HasMaxLength(255);

                entity.Property(e => e.启用状态).HasMaxLength(255);

                entity.Property(e => e.备注).HasMaxLength(255);

                entity.Property(e => e.姓名).HasMaxLength(255);

                entity.Property(e => e.密码).HasMaxLength(255);

                entity.Property(e => e.手机号).HasMaxLength(255);

                entity.Property(e => e.提款密码).HasMaxLength(255);

                entity.Property(e => e.注册日期时间).HasMaxLength(255);

                entity.Property(e => e.银行).HasMaxLength(255);

                entity.Property(e => e.银行账号).HasMaxLength(255);
            });

            modelBuilder.Entity<ShengXiaoMaping>(entity =>
            {
                entity.HasKey(e => e.Year);

                entity.HasIndex(e => new { e.Year, e.Shengxiao })
                    .HasName("NonClusteredIndex-20160621-154128");

                entity.Property(e => e.Year)
                    .HasColumnName("year")
                    .ValueGeneratedNever();

                entity.Property(e => e.Shengxiao)
                    .HasColumnName("shengxiao")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<SiteInfo>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.IndexGonggao).HasColumnName("indexGonggao");

                entity.Property(e => e.IsYouhuiHuodong)
                    .HasColumnName("isYouhuiHuodong")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.SiteDesc)
                    .HasColumnName("siteDesc")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.SiteKey)
                    .HasColumnName("siteKey")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SiteName)
                    .HasColumnName("siteName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SiteUrl)
                    .HasColumnName("siteUrl")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SiteInfo1>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.IndexGonggao)
                    .HasColumnName("indexGonggao")
                    .HasColumnType("text");

                entity.Property(e => e.IsYouhuiHuodong)
                    .HasColumnName("isYouhuiHuodong")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.SiteDesc)
                    .HasColumnName("siteDesc")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.SiteName)
                    .HasColumnName("siteName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SiteUrl)
                    .HasColumnName("siteUrl")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SiteLog>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.Title).HasMaxLength(200);
            });

            modelBuilder.Entity<SlidingVerifyLog>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreateTime)
                    .HasColumnName("createTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.Length).HasColumnName("length");

                entity.Property(e => e.LoginName)
                    .HasColumnName("loginName")
                    .HasMaxLength(50);

                entity.Property(e => e.Ma)
                    .HasColumnName("ma")
                    .HasMaxLength(4000);

                entity.Property(e => e.Mv)
                    .HasColumnName("mv")
                    .HasMaxLength(4000);

                entity.Property(e => e.Point).HasColumnName("point");

                entity.Property(e => e.Sdata)
                    .HasColumnName("sdata")
                    .HasMaxLength(4000);

                entity.Property(e => e.Sdatamd5)
                    .HasColumnName("sdatamd5")
                    .HasMaxLength(50);

                entity.Property(e => e.Totaldate).HasColumnName("totaldate");
            });

            modelBuilder.Entity<Suggest>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreateTime)
                    .HasColumnName("createTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.LastUpdateTime)
                    .HasColumnName("lastUpdateTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.LoginName)
                    .HasColumnName("loginName")
                    .HasMaxLength(50);

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<SysLog>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .IsClustered(false);

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Body).HasColumnName("body");

                entity.Property(e => e.CreateTime)
                    .HasColumnName("createTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.LoginName)
                    .HasColumnName("loginName")
                    .HasMaxLength(50);

                entity.Property(e => e.Title)
                    .HasColumnName("title")
                    .HasMaxLength(50);

                entity.Property(e => e.Type)
                    .HasColumnName("type")
                    .HasMaxLength(2);
            });

            modelBuilder.Entity<SysLogAsync>(entity =>
            {
                entity.ToTable("SysLog_Async");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();
            });

            modelBuilder.Entity<SysUser>(entity =>
            {
                entity.HasIndex(e => new { e.IPplace, e.LoginPlace, e.MenuAuthList, e.Name, e.Auth, e.EnableGoogleAuth, e.FunAuthList, e.GoogleSecretKey, e.Id, e.LoginName, e.Pwd, e.AddrPlace, e.Stauts })
                    .HasName("NonClusteredIndex-20160621-154247");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.AddrPlace)
                    .HasColumnName("addrPlace")
                    .HasMaxLength(50);

                entity.Property(e => e.Auth)
                    .HasColumnName("auth")
                    .HasMaxLength(10);

                entity.Property(e => e.EnableGoogleAuth)
                    .HasColumnName("enableGoogleAuth")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.FunAuthList)
                    .HasColumnName("funAuthList")
                    .HasMaxLength(3000);

                entity.Property(e => e.GoogleSecretKey)
                    .HasColumnName("googleSecretKey")
                    .HasMaxLength(50);

                entity.Property(e => e.IPplace)
                    .HasColumnName("iPplace")
                    .HasMaxLength(500);

                entity.Property(e => e.LoginName)
                    .HasColumnName("loginName")
                    .HasMaxLength(50);

                entity.Property(e => e.LoginPlace).HasColumnName("loginPlace");

                entity.Property(e => e.MenuAuthList)
                    .HasColumnName("menuAuthList")
                    .HasMaxLength(3000);

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(50);

                entity.Property(e => e.Pwd)
                    .HasColumnName("pwd")
                    .HasMaxLength(200);

                entity.Property(e => e.Stauts)
                    .HasColumnName("stauts")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<TbLotteryOrderItems>(entity =>
            {
                entity.ToTable("tbLotteryOrderItems");

                entity.HasIndex(e => new { e.OrderId, e.OddsGroupName, e.OddsName })
                    .HasName("NonClusteredIndex-20160616-224656");

                entity.Property(e => e.ID).HasColumnName("iD");

                entity.Property(e => e.Ext1)
                    .HasColumnName("ext1")
                    .HasMaxLength(50);

                entity.Property(e => e.Ext2)
                    .HasColumnName("ext2")
                    .HasMaxLength(50);

                entity.Property(e => e.ItemMoney)
                    .HasColumnName("itemMoney")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.OddsGroupName)
                    .HasColumnName("oddsGroupName")
                    .HasMaxLength(40);

                entity.Property(e => e.OddsName)
                    .HasColumnName("oddsName")
                    .HasMaxLength(50);

                entity.Property(e => e.OrderId).HasColumnName("orderID");

                entity.Property(e => e.PointsOdds)
                    .HasColumnName("points_Odds")
                    .HasColumnType("decimal(18, 5)");

                entity.Property(e => e.TheoryMoney)
                    .HasColumnName("theoryMoney")
                    .HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<TbLotteryOrderItemsAsync>(entity =>
            {
                entity.ToTable("tbLotteryOrderItems_Async");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Dtime)
                    .HasColumnName("dtime")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<TbLotteryOrderItemsBakTo20150101>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbLotteryOrderItems_Bak_To20150101");

                entity.Property(e => e.Ext1)
                    .HasColumnName("ext1")
                    .HasMaxLength(50);

                entity.Property(e => e.Ext2)
                    .HasColumnName("ext2")
                    .HasMaxLength(50);

                entity.Property(e => e.ID)
                    .HasColumnName("iD")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.ItemMoney)
                    .HasColumnName("itemMoney")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.OddsGroupName)
                    .HasColumnName("oddsGroupName")
                    .HasMaxLength(40);

                entity.Property(e => e.OddsName)
                    .HasColumnName("oddsName")
                    .HasMaxLength(50);

                entity.Property(e => e.OrderId).HasColumnName("orderID");

                entity.Property(e => e.PointsOdds)
                    .HasColumnName("points_Odds")
                    .HasColumnType("decimal(18, 5)");

                entity.Property(e => e.TheoryMoney)
                    .HasColumnName("theoryMoney")
                    .HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<TbLotteryOrderItemsOriginal>(entity =>
            {
                entity.ToTable("tbLotteryOrderItemsOriginal");

                entity.Property(e => e.ID).HasColumnName("iD");

                entity.Property(e => e.Ext1)
                    .HasColumnName("ext1")
                    .HasMaxLength(50);

                entity.Property(e => e.Ext2)
                    .HasColumnName("ext2")
                    .HasMaxLength(50);

                entity.Property(e => e.ItemMoney)
                    .HasColumnName("itemMoney")
                    .HasColumnType("decimal(18, 2)")
                    .HasComment("注单行金额");

                entity.Property(e => e.OddsGroupName)
                    .HasColumnName("oddsGroupName")
                    .HasMaxLength(40)
                    .HasComment("赔率组名称");

                entity.Property(e => e.OddsName)
                    .HasColumnName("oddsName")
                    .HasMaxLength(50)
                    .HasComment("赔率组字段");

                entity.Property(e => e.OrderId)
                    .HasColumnName("orderID")
                    .HasComment("注单ID");

                entity.Property(e => e.PointsOdds)
                    .HasColumnName("points_Odds")
                    .HasColumnType("decimal(18, 5)")
                    .HasComment("下单时赔率值");
            });

            modelBuilder.Entity<TbLotteryOrders>(entity =>
            {
                entity.ToTable("tbLotteryOrders");

                entity.HasIndex(e => e.CreateTime)
                    .HasName("NonClusteredIndex-20180802-171950");

                entity.HasIndex(e => new { e.ButchNo, e.Status, e.LotteryName, e.CreateTime })
                    .HasName("tbLotteryOrdersstatuslotteryNamecreateTimeIndex");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.ButchNo)
                    .HasColumnName("butchNo")
                    .HasMaxLength(30);

                entity.Property(e => e.Code)
                    .HasColumnName("code")
                    .HasMaxLength(50);

                entity.Property(e => e.CreateTime)
                    .HasColumnName("createTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.CreteSource)
                    .HasColumnName("creteSource")
                    .HasMaxLength(100);

                entity.Property(e => e.Ischuan).HasColumnName("ischuan");

                entity.Property(e => e.LastUpdateTime).HasColumnType("datetime");

                entity.Property(e => e.LoginName)
                    .HasColumnName("loginName")
                    .HasMaxLength(50);

                entity.Property(e => e.LotteryName)
                    .HasColumnName("lotteryName")
                    .HasMaxLength(30);

                entity.Property(e => e.OrderMoney)
                    .HasColumnName("orderMoney")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.PrizeData).HasMaxLength(200);

                entity.Property(e => e.Remark).HasMaxLength(50);

                entity.Property(e => e.SettleMoney)
                    .HasColumnName("settleMoney")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasMaxLength(30);

                entity.Property(e => e.TheoryMoney)
                    .HasColumnName("theoryMoney")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TuishuiAmount)
                    .HasColumnName("tuishuiAmount")
                    .HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<TbLotteryOrdersAsync>(entity =>
            {
                entity.ToTable("tbLotteryOrders_Async");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Dtime)
                    .HasColumnName("dtime")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<TbLotteryOrdersBakTo20150101>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbLotteryOrders_Bak_To20150101");

                entity.Property(e => e.ButchNo)
                    .HasColumnName("butchNo")
                    .HasMaxLength(30);

                entity.Property(e => e.Code)
                    .HasColumnName("code")
                    .HasMaxLength(50);

                entity.Property(e => e.CreateTime)
                    .HasColumnName("createTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.CreteSource)
                    .HasColumnName("creteSource")
                    .HasMaxLength(100);

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Ischuan).HasColumnName("ischuan");

                entity.Property(e => e.LastUpdateTime).HasColumnType("datetime");

                entity.Property(e => e.LoginName)
                    .HasColumnName("loginName")
                    .HasMaxLength(50);

                entity.Property(e => e.LotteryName)
                    .HasColumnName("lotteryName")
                    .HasMaxLength(30);

                entity.Property(e => e.OrderMoney)
                    .HasColumnName("orderMoney")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.PrizeData).HasMaxLength(200);

                entity.Property(e => e.SettleMoney)
                    .HasColumnName("settleMoney")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasMaxLength(30);

                entity.Property(e => e.TheoryMoney)
                    .HasColumnName("theoryMoney")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TuishuiAmount)
                    .HasColumnName("tuishuiAmount")
                    .HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<TbLotteryOrdersOriginal>(entity =>
            {
                entity.ToTable("tbLotteryOrdersOriginal");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.ButchNo)
                    .HasColumnName("butchNo")
                    .HasMaxLength(30)
                    .HasComment("开奖期次");

                entity.Property(e => e.Code)
                    .HasColumnName("code")
                    .HasMaxLength(50)
                    .HasComment("注单code");

                entity.Property(e => e.CreateTime)
                    .HasColumnName("createTime")
                    .HasColumnType("datetime")
                    .HasComment("下单时间");

                entity.Property(e => e.CreteSource)
                    .HasColumnName("creteSource")
                    .HasMaxLength(100);

                entity.Property(e => e.LastUpdateTime)
                    .HasColumnType("datetime")
                    .HasComment("最后更新日期（结算日期）");

                entity.Property(e => e.LoginName)
                    .HasColumnName("loginName")
                    .HasMaxLength(50)
                    .HasComment("会员登录名");

                entity.Property(e => e.LotteryName)
                    .HasColumnName("lotteryName")
                    .HasMaxLength(30)
                    .HasComment("彩票名称");

                entity.Property(e => e.OrderMoney)
                    .HasColumnName("orderMoney")
                    .HasColumnType("decimal(18, 2)")
                    .HasComment("注单总金额（对item的汇总）");

                entity.Property(e => e.PrizeData)
                    .HasMaxLength(200)
                    .HasComment("结算时的开奖结果");

                entity.Property(e => e.SettleMoney)
                    .HasColumnName("settleMoney")
                    .HasColumnType("decimal(18, 2)")
                    .HasComment("结算后金额");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasMaxLength(30)
                    .HasComment("注单状态（未结算/已结算/作废）");

                entity.Property(e => e.TheoryMoney)
                    .HasColumnName("theoryMoney")
                    .HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<TbLotteryReport>(entity =>
            {
                entity.ToTable("tbLotteryReport");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Ahk3dds)
                    .HasColumnName("AHK3dds")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Ahk3js)
                    .HasColumnName("AHK3js")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Ahk3yl)
                    .HasColumnName("AHK3yl")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Ahk3ztze)
                    .HasColumnName("AHK3ztze")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Azdds)
                    .HasColumnName("AZdds")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Azjs)
                    .HasColumnName("AZjs")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Azyl)
                    .HasColumnName("AZyl")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Azztze)
                    .HasColumnName("AZztze")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Bjkl8dds).HasColumnName("BJKL8dds");

                entity.Property(e => e.Bjkl8js)
                    .HasColumnName("BJKL8js")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Bjkl8yl)
                    .HasColumnName("BJKL8yl")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Bjkl8ztze)
                    .HasColumnName("BJKL8ztze")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Bjpk10dds).HasColumnName("BJPK10dds");

                entity.Property(e => e.Bjpk10js)
                    .HasColumnName("BJPK10js")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Bjpk10yl)
                    .HasColumnName("BJPK10yl")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Bjpk10ztze)
                    .HasColumnName("BJPK10ztze")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Cqklsfdds).HasColumnName("CQKLSFdds");

                entity.Property(e => e.Cqklsfjs)
                    .HasColumnName("CQKLSFjs")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Cqklsfyl)
                    .HasColumnName("CQKLSFyl")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Cqklsfztze)
                    .HasColumnName("CQKLSFztze")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Cqsscdds).HasColumnName("CQSSCdds");

                entity.Property(e => e.Cqsscjs)
                    .HasColumnName("CQSSCjs")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Cqsscyl)
                    .HasColumnName("CQSSCyl")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Cqsscztze)
                    .HasColumnName("CQSSCztze")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Fc3ddds).HasColumnName("FC3Ddds");

                entity.Property(e => e.Fc3djs)
                    .HasColumnName("FC3Djs")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Fc3dyl)
                    .HasColumnName("FC3Dyl")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Fc3dztze)
                    .HasColumnName("FC3Dztze")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Gdklsfdds).HasColumnName("GDKLSFdds");

                entity.Property(e => e.Gdklsfjs)
                    .HasColumnName("GDKLSFjs")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Gdklsfyl)
                    .HasColumnName("GDKLSFyl")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Gdklsfztze)
                    .HasColumnName("GDKLSFztze")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Gg115dds).HasColumnName("GG115dds");

                entity.Property(e => e.Gg115js)
                    .HasColumnName("GG115js")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Gg115yl)
                    .HasColumnName("GG115yl")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Gg115ztze)
                    .HasColumnName("GG115ztze")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Gxklsfdds)
                    .HasColumnName("GXKLSFdds")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Gxklsfjs)
                    .HasColumnName("GXKLSFjs")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Gxklsfyl)
                    .HasColumnName("GXKLSFyl")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Gxklsfztze)
                    .HasColumnName("GXKLSFztze")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Jndbsdds)
                    .HasColumnName("JNDBSdds")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Jndbsjs)
                    .HasColumnName("JNDBSjs")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Jndbsyl)
                    .HasColumnName("JNDBSyl")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Jndbsztze)
                    .HasColumnName("JNDBSztze")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Jsk3dds)
                    .HasColumnName("JSK3dds")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Jsk3js)
                    .HasColumnName("JSK3js")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Jsk3yl)
                    .HasColumnName("JSK3yl")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Jsk3ztze)
                    .HasColumnName("JSK3ztze")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Jx115dds)
                    .HasColumnName("JX115dds")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Jx115js)
                    .HasColumnName("JX115js")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Jx115yl)
                    .HasColumnName("JX115yl")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Jx115ztze)
                    .HasColumnName("JX115ztze")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Jxsscdds).HasColumnName("JXSSCdds");

                entity.Property(e => e.Jxsscjs)
                    .HasColumnName("JXSSCjs")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Jxsscyl)
                    .HasColumnName("JXSSCyl")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Jxsscztze)
                    .HasColumnName("JXSSCztze")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Lhcdds)
                    .HasColumnName("LHCdds")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Lhcjs)
                    .HasColumnName("LHCjs")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Lhcyl)
                    .HasColumnName("LHCyl")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Lhcztze)
                    .HasColumnName("LHCztze")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.ReportDay)
                    .HasColumnName("reportDay")
                    .HasColumnType("datetime");

                entity.Property(e => e.Sd115dds)
                    .HasColumnName("SD115dds")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Sd115js)
                    .HasColumnName("SD115js")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Sd115yl)
                    .HasColumnName("SD115yl")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Sd115ztze)
                    .HasColumnName("SD115ztze")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Shssldds).HasColumnName("SHSSLdds");

                entity.Property(e => e.Shssljs)
                    .HasColumnName("SHSSLjs")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Shsslyl)
                    .HasColumnName("SHSSLyl")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Shsslztze)
                    .HasColumnName("SHSSLztze")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Tcplsdds).HasColumnName("TCPLSdds");

                entity.Property(e => e.Tcplsjs)
                    .HasColumnName("TCPLSjs")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Tcplsyl)
                    .HasColumnName("TCPLSyl")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Tcplsztze)
                    .HasColumnName("TCPLSztze")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Tjklsfdds)
                    .HasColumnName("TJKLSFdds")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Tjklsfjs)
                    .HasColumnName("TJKLSFjs")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Tjklsfyl)
                    .HasColumnName("TJKLSFyl")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Tjklsfztze)
                    .HasColumnName("TJKLSFztze")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Tjsscdds)
                    .HasColumnName("TJSSCdds")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Tjsscjs)
                    .HasColumnName("TJSSCjs")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Tjsscyl)
                    .HasColumnName("TJSSCyl")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Tjsscztze)
                    .HasColumnName("TJSSCztze")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Xjsscdds)
                    .HasColumnName("XJSSCdds")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Xjsscjs)
                    .HasColumnName("XJSSCjs")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Xjsscyl)
                    .HasColumnName("XJSSCyl")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Xjsscztze)
                    .HasColumnName("XJSSCztze")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Zfs)
                    .HasColumnName("zfs")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Zjs)
                    .HasColumnName("zjs")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Zts)
                    .HasColumnName("zts")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Ztz)
                    .HasColumnName("ztz")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Zyl)
                    .HasColumnName("zyl")
                    .HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<TbLotterySettlementLog>(entity =>
            {
                entity.ToTable("tbLotterySettlementLog");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasComment("主键")
                    .ValueGeneratedNever();

                entity.Property(e => e.ButchNo)
                    .HasColumnName("butchNo")
                    .HasMaxLength(30)
                    .HasComment("开奖期次");

                entity.Property(e => e.Code)
                    .HasColumnName("code")
                    .HasMaxLength(50)
                    .HasComment("订单号");

                entity.Property(e => e.CreateTime)
                    .HasColumnName("createTime")
                    .HasColumnType("datetime")
                    .HasComment("结算时间");

                entity.Property(e => e.ItemMoney)
                    .HasColumnName("itemMoney")
                    .HasColumnType("decimal(18, 0)")
                    .HasComment("订单行金额");

                entity.Property(e => e.ItemsettleMoney)
                    .HasColumnName("itemsettleMoney")
                    .HasColumnType("decimal(18, 0)")
                    .HasComment("实际赢取金额（订单行项目的实际赢取金额）");

                entity.Property(e => e.LotteryName)
                    .HasColumnName("lotteryName")
                    .HasMaxLength(30)
                    .HasComment("彩票类型");

                entity.Property(e => e.OddsGroupName)
                    .HasColumnName("oddsGroupName")
                    .HasMaxLength(50)
                    .HasComment("投注类型");

                entity.Property(e => e.OddsName)
                    .HasColumnName("oddsName")
                    .HasMaxLength(50)
                    .HasComment("投注内容");

                entity.Property(e => e.OrderId)
                    .HasColumnName("orderID")
                    .HasComment("订单ID");

                entity.Property(e => e.OrderItemId)
                    .HasColumnName("orderItemID")
                    .HasComment("订单行ID");

                entity.Property(e => e.PointsOdds)
                    .HasColumnName("points_Odds")
                    .HasColumnType("decimal(18, 0)")
                    .HasComment("赔率");

                entity.Property(e => e.PrizeData)
                    .HasMaxLength(1000)
                    .HasComment("开奖结果字符串");

                entity.Property(e => e.Remark)
                    .HasColumnName("remark")
                    .HasComment("附加信息");
            });

            modelBuilder.Entity<TeamTmp>(entity =>
            {
                entity.HasKey(e => e.Id1)
                    .HasName("PK__teamTmp__DC501A3F530065EF");

                entity.ToTable("teamTmp");

                entity.Property(e => e.Id1)
                    .HasColumnName("id1")
                    .HasMaxLength(50);

                entity.Property(e => e.Id2)
                    .HasColumnName("id2")
                    .HasMaxLength(50);

                entity.Property(e => e.Id3)
                    .HasColumnName("id3")
                    .HasMaxLength(100);

                entity.Property(e => e.Id4)
                    .HasColumnName("id4")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<Test2>(entity =>
            {
                entity.HasKey(e => e.A)
                    .HasName("PK_test1");

                entity.ToTable("test2");

                entity.HasIndex(e => new { e.B, e.C })
                    .HasName("NonClusteredIndex-20161128-153828");

                entity.Property(e => e.A)
                    .HasColumnName("a")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.B)
                    .HasColumnName("b")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.C)
                    .HasColumnName("c")
                    .HasMaxLength(10)
                    .IsFixedLength();
            });

            modelBuilder.Entity<TySettlementqueue>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.CreateTime)
                    .HasColumnName("createTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.Source)
                    .HasColumnName("source")
                    .HasMaxLength(100);

                entity.Property(e => e.Sysuser)
                    .HasColumnName("sysuser")
                    .HasMaxLength(100);

                entity.Property(e => e.Type).HasColumnName("type");
            });

            modelBuilder.Entity<UpgradeLog>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.EffectMoney).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.GiveStatus).HasMaxLength(20);

                entity.Property(e => e.InsertDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Inserter)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('系统')");

                entity.Property(e => e.Loginname)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.NewLevel)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.RebateRate).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.SourceLevel)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.UserId).HasColumnName("UserID");
            });

            modelBuilder.Entity<UpgradeMonthMoney>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.GiveStatus)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.InsertDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Inserter)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Loginname)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.RebateRate).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.UpgradeTime).HasColumnType("datetime");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.VipLevel)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.HasIndex(e => e.UserGroup)
                    .HasName("NonClusteredIndex-20180802-172112");

                entity.HasIndex(e => new { e.UserGroup, e.UserLeve, e.PwdAnswer, e.PwdQuestion, e.Qq, e.Registaddr, e.RegistData, e.RegistIp, e.Remark, e.Sex, e.Id, e.IPplace, e.Isdelete, e.IsTuishui, e.LastLoginData, e.LastLoginIp, e.LastLogoutData, e.LoginCount, e.Agent, e.Balance, e.BankCrad, e.CradPwd, e.GameAccount, e.GamePwd, e.Mailaddr, e.OpenBandAddr, e.OpenBank, e.Phone, e.Playset, e.Loginname, e.Pwd, e.Username, e.Status })
                    .HasName("NonClusteredIndex-20160621-154801");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Agent)
                    .HasColumnName("agent")
                    .HasMaxLength(50);

                entity.Property(e => e.Balance)
                    .HasColumnName("balance")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.BankCrad)
                    .HasColumnName("bankCrad")
                    .HasMaxLength(100);

                entity.Property(e => e.City).HasMaxLength(50);

                entity.Property(e => e.CradPwd).HasMaxLength(50);

                entity.Property(e => e.DepositCount).HasColumnName("depositCount");

                entity.Property(e => e.DepositSum)
                    .HasColumnName("depositSum")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.FirstDepositNum)
                    .HasColumnName("firstDepositNum")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.FirstDepositTime)
                    .HasColumnName("firstDepositTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.FirstWithdrawNum)
                    .HasColumnName("firstWithdrawNum")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.FirstWithdrawTime)
                    .HasColumnName("firstWithdrawTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.GameAccount)
                    .HasColumnName("game_account")
                    .HasMaxLength(50);

                entity.Property(e => e.GamePwd).HasMaxLength(50);

                entity.Property(e => e.IPplace)
                    .HasColumnName("iPplace")
                    .HasMaxLength(500);

                entity.Property(e => e.IsTuishui).HasDefaultValueSql("((0))");

                entity.Property(e => e.Isdelete)
                    .HasColumnName("isdelete")
                    .HasMaxLength(1);

                entity.Property(e => e.Isreportignore)
                    .HasColumnName("isreportignore")
                    .HasComment("是否报表忽略，默认不忽略　");

                entity.Property(e => e.LastLoginData)
                    .HasColumnName("lastLoginData")
                    .HasColumnType("datetime");

                entity.Property(e => e.LastLoginIp)
                    .HasColumnName("lastLoginIP")
                    .HasMaxLength(15);

                entity.Property(e => e.LastLogoutData)
                    .HasColumnName("lastLogoutData")
                    .HasColumnType("datetime");

                entity.Property(e => e.LoginCount).HasColumnName("loginCount");

                entity.Property(e => e.Loginname)
                    .HasColumnName("loginname")
                    .HasMaxLength(50);

                entity.Property(e => e.Mailaddr)
                    .HasColumnName("mailaddr")
                    .HasMaxLength(100)
                    .IsFixedLength();

                entity.Property(e => e.MaxDepositNum)
                    .HasColumnName("maxDepositNum")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.MaxDepositTime)
                    .HasColumnName("maxDepositTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.MaxWithdrawNum)
                    .HasColumnName("maxWithdrawNum")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.MaxWithdrawTime)
                    .HasColumnName("maxWithdrawTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.OneDayDepositSum)
                    .HasColumnName("oneDayDepositSum")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.OpenBandAddr)
                    .HasColumnName("openBandAddr")
                    .HasMaxLength(200);

                entity.Property(e => e.OpenBank)
                    .HasColumnName("openBank")
                    .HasMaxLength(100);

                entity.Property(e => e.OpenBankSub).HasMaxLength(50);

                entity.Property(e => e.Phone)
                    .HasColumnName("phone")
                    .HasMaxLength(50);

                entity.Property(e => e.Playset)
                    .HasColumnName("playset")
                    .HasMaxLength(500);

                entity.Property(e => e.Province).HasMaxLength(50);

                entity.Property(e => e.Pwd)
                    .HasColumnName("pwd")
                    .HasMaxLength(50);

                entity.Property(e => e.PwdAnswer)
                    .HasColumnName("pwdAnswer")
                    .HasMaxLength(100);

                entity.Property(e => e.PwdQuestion)
                    .HasColumnName("pwdQuestion")
                    .HasMaxLength(100);

                entity.Property(e => e.Qq)
                    .HasColumnName("qq")
                    .HasMaxLength(100);

                entity.Property(e => e.RegistData)
                    .HasColumnName("registData")
                    .HasColumnType("datetime");

                entity.Property(e => e.RegistIp)
                    .HasColumnName("registIP")
                    .HasMaxLength(15);

                entity.Property(e => e.Registaddr)
                    .HasColumnName("registaddr")
                    .HasMaxLength(100);

                entity.Property(e => e.RegisterDevice)
                    .HasColumnName("registerDevice")
                    .HasMaxLength(50);

                entity.Property(e => e.RegisterSource)
                    .HasColumnName("registerSource")
                    .HasMaxLength(100);

                entity.Property(e => e.Remark)
                    .HasColumnName("remark")
                    .HasMaxLength(200);

                entity.Property(e => e.Sex)
                    .HasColumnName("sex")
                    .HasMaxLength(1);

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasMaxLength(20);

                entity.Property(e => e.UserGroup)
                    .HasColumnName("userGroup")
                    .HasMaxLength(50);

                entity.Property(e => e.UserLeve)
                    .HasColumnName("userLeve")
                    .HasMaxLength(50);

                entity.Property(e => e.Username)
                    .HasColumnName("username")
                    .HasMaxLength(50);

                entity.Property(e => e.VipLevel)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasDefaultValueSql("('VIP0')");

                entity.Property(e => e.Weixin)
                    .HasColumnName("weixin")
                    .HasMaxLength(50);

                entity.Property(e => e.WithdrawCount).HasColumnName("withdrawCount");

                entity.Property(e => e.WithdrawSum)
                    .HasColumnName("withdrawSum")
                    .HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<User1>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Agent)
                    .HasColumnName("agent")
                    .HasMaxLength(50);

                entity.Property(e => e.Balance)
                    .HasColumnName("balance")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.BankCrad)
                    .HasColumnName("bankCrad")
                    .HasMaxLength(100);

                entity.Property(e => e.CradPwd).HasMaxLength(50);

                entity.Property(e => e.GameAccount)
                    .HasColumnName("game_account")
                    .HasMaxLength(50);

                entity.Property(e => e.GamePwd).HasMaxLength(50);

                entity.Property(e => e.IPplace)
                    .HasColumnName("iPplace")
                    .HasMaxLength(500);

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.IsTuishui).HasDefaultValueSql("((0))");

                entity.Property(e => e.Isdelete)
                    .HasColumnName("isdelete")
                    .HasMaxLength(1);

                entity.Property(e => e.Isreportignore)
                    .HasColumnName("isreportignore")
                    .HasComment("是否报表忽略，默认不忽略　");

                entity.Property(e => e.LastLoginData)
                    .HasColumnName("lastLoginData")
                    .HasColumnType("datetime");

                entity.Property(e => e.LastLoginIp)
                    .HasColumnName("lastLoginIP")
                    .HasMaxLength(15);

                entity.Property(e => e.LastLogoutData)
                    .HasColumnName("lastLogoutData")
                    .HasColumnType("datetime");

                entity.Property(e => e.LoginCount).HasColumnName("loginCount");

                entity.Property(e => e.Loginname)
                    .HasColumnName("loginname")
                    .HasMaxLength(50);

                entity.Property(e => e.Mailaddr)
                    .HasColumnName("mailaddr")
                    .HasMaxLength(100)
                    .IsFixedLength();

                entity.Property(e => e.OpenBandAddr)
                    .HasColumnName("openBandAddr")
                    .HasMaxLength(200);

                entity.Property(e => e.OpenBank)
                    .HasColumnName("openBank")
                    .HasMaxLength(100);

                entity.Property(e => e.Phone)
                    .HasColumnName("phone")
                    .HasMaxLength(50);

                entity.Property(e => e.Playset)
                    .HasColumnName("playset")
                    .HasMaxLength(500);

                entity.Property(e => e.Pwd)
                    .HasColumnName("pwd")
                    .HasMaxLength(50);

                entity.Property(e => e.PwdAnswer)
                    .HasColumnName("pwdAnswer")
                    .HasMaxLength(100);

                entity.Property(e => e.PwdQuestion)
                    .HasColumnName("pwdQuestion")
                    .HasMaxLength(100);

                entity.Property(e => e.Qq)
                    .HasColumnName("qq")
                    .HasMaxLength(20);

                entity.Property(e => e.RegistData)
                    .HasColumnName("registData")
                    .HasColumnType("datetime");

                entity.Property(e => e.RegistIp)
                    .HasColumnName("registIP")
                    .HasMaxLength(15);

                entity.Property(e => e.Registaddr)
                    .HasColumnName("registaddr")
                    .HasMaxLength(100);

                entity.Property(e => e.Remark)
                    .HasColumnName("remark")
                    .HasMaxLength(200);

                entity.Property(e => e.Sex)
                    .HasColumnName("sex")
                    .HasMaxLength(1);

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasMaxLength(20);

                entity.Property(e => e.UserGroup)
                    .HasColumnName("userGroup")
                    .HasMaxLength(50);

                entity.Property(e => e.UserLeve)
                    .HasColumnName("userLeve")
                    .HasMaxLength(50);

                entity.Property(e => e.Username)
                    .HasColumnName("username")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<User2>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Agent)
                    .HasColumnName("agent")
                    .HasMaxLength(50);

                entity.Property(e => e.Balance)
                    .HasColumnName("balance")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.BankCrad)
                    .HasColumnName("bankCrad")
                    .HasMaxLength(100);

                entity.Property(e => e.CradPwd).HasMaxLength(50);

                entity.Property(e => e.GameAccount)
                    .HasColumnName("game_account")
                    .HasMaxLength(50);

                entity.Property(e => e.GamePwd).HasMaxLength(50);

                entity.Property(e => e.IPplace)
                    .HasColumnName("iPplace")
                    .HasMaxLength(500);

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Isdelete)
                    .HasColumnName("isdelete")
                    .HasMaxLength(1);

                entity.Property(e => e.Isreportignore).HasColumnName("isreportignore");

                entity.Property(e => e.LastLoginData)
                    .HasColumnName("lastLoginData")
                    .HasColumnType("datetime");

                entity.Property(e => e.LastLoginIp)
                    .HasColumnName("lastLoginIP")
                    .HasMaxLength(15);

                entity.Property(e => e.LastLogoutData)
                    .HasColumnName("lastLogoutData")
                    .HasColumnType("datetime");

                entity.Property(e => e.LoginCount).HasColumnName("loginCount");

                entity.Property(e => e.Loginname)
                    .HasColumnName("loginname")
                    .HasMaxLength(50);

                entity.Property(e => e.Mailaddr)
                    .HasColumnName("mailaddr")
                    .HasMaxLength(100)
                    .IsFixedLength();

                entity.Property(e => e.OpenBandAddr)
                    .HasColumnName("openBandAddr")
                    .HasMaxLength(200);

                entity.Property(e => e.OpenBank)
                    .HasColumnName("openBank")
                    .HasMaxLength(100);

                entity.Property(e => e.Phone)
                    .HasColumnName("phone")
                    .HasMaxLength(50);

                entity.Property(e => e.Playset)
                    .HasColumnName("playset")
                    .HasMaxLength(500);

                entity.Property(e => e.Pwd)
                    .HasColumnName("pwd")
                    .HasMaxLength(50);

                entity.Property(e => e.PwdAnswer)
                    .HasColumnName("pwdAnswer")
                    .HasMaxLength(100);

                entity.Property(e => e.PwdQuestion)
                    .HasColumnName("pwdQuestion")
                    .HasMaxLength(100);

                entity.Property(e => e.Qq)
                    .HasColumnName("qq")
                    .HasMaxLength(20);

                entity.Property(e => e.RegistData)
                    .HasColumnName("registData")
                    .HasColumnType("datetime");

                entity.Property(e => e.RegistIp)
                    .HasColumnName("registIP")
                    .HasMaxLength(15);

                entity.Property(e => e.Registaddr)
                    .HasColumnName("registaddr")
                    .HasMaxLength(100);

                entity.Property(e => e.Remark)
                    .HasColumnName("remark")
                    .HasMaxLength(200);

                entity.Property(e => e.Sex)
                    .HasColumnName("sex")
                    .HasMaxLength(1);

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasMaxLength(20);

                entity.Property(e => e.UserGroup)
                    .HasColumnName("userGroup")
                    .HasMaxLength(50);

                entity.Property(e => e.UserLeve)
                    .HasColumnName("userLeve")
                    .HasMaxLength(50);

                entity.Property(e => e.Username)
                    .HasColumnName("username")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<UserAsync>(entity =>
            {
                entity.ToTable("User_Async");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Dtime)
                    .HasColumnName("dtime")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<UserBalance>(entity =>
            {
                entity.HasIndex(e => new { e.Id, e.Balance, e.Loginname })
                    .HasName("UserBalanceIndex");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Balance)
                    .HasColumnName("balance")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Loginname)
                    .HasColumnName("loginname")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<UserDayFinanceReport>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.DayDeposit).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.DayWithdraw).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.GameAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.GameResultAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.GameTuiShuiAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.LoginName)
                    .HasColumnName("loginName")
                    .HasMaxLength(50);

                entity.Property(e => e.LotteryOrderAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.LotteryOrderResultAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.LotteryTuShuiAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.SportOrderAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.SportOrderResultAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.SportTuiShuiAmount).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<UserExtensions>(entity =>
            {
                entity.HasKey(e => e.UserId);

                entity.HasIndex(e => new { e.Loginname, e.TokenId })
                    .HasName("UserExtensions_Index");

                entity.Property(e => e.UserId)
                    .HasColumnName("UserID")
                    .ValueGeneratedNever();

                entity.Property(e => e.InfoSource).HasMaxLength(100);

                entity.Property(e => e.LoginUrl)
                    .HasColumnName("loginURL")
                    .HasMaxLength(250);

                entity.Property(e => e.Loginname)
                    .HasColumnName("loginname")
                    .HasMaxLength(50);

                entity.Property(e => e.PassTime).HasColumnType("datetime");

                entity.Property(e => e.QuantityAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TokenId).HasMaxLength(50);
            });

            modelBuilder.Entity<UserFinance>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("UserFinance");

                entity.Property(e => e.AccessAfterAmount)
                    .HasColumnName("accessAfterAmount")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.AccessAmount)
                    .HasColumnName("accessAmount")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.AccessBeforeAmount)
                    .HasColumnName("accessBeforeAmount")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasColumnName("code")
                    .HasMaxLength(100);

                entity.Property(e => e.CraeteData)
                    .HasColumnName("craeteData")
                    .HasColumnType("datetime");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.LoginName)
                    .HasColumnName("loginName")
                    .HasMaxLength(50);

                entity.Property(e => e.Remark).HasMaxLength(408);

                entity.Property(e => e.Rid).HasColumnName("rid");

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasColumnName("type")
                    .HasMaxLength(50);

                entity.Property(e => e.WebRemark)
                    .HasColumnName("webRemark")
                    .HasMaxLength(250);
            });

            modelBuilder.Entity<UserFinanceReport>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Chongzhi)
                    .HasColumnName("chongzhi")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Jiesuanjine)
                    .HasColumnName("jiesuanjine")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.LoginName)
                    .HasColumnName("loginName")
                    .HasMaxLength(50);

                entity.Property(e => e.RegistTime)
                    .HasColumnName("registTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.ReportDay)
                    .HasColumnName("reportDay")
                    .HasColumnType("datetime");

                entity.Property(e => e.Tixian)
                    .HasColumnName("tixian")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Touzhujine)
                    .HasColumnName("touzhujine")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Touzhuliang).HasColumnName("touzhuliang");

                entity.Property(e => e.Yinli)
                    .HasColumnName("yinli")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Yue)
                    .HasColumnName("yue")
                    .HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<UserFinanceSaved>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("UserFinanceSaved");

                entity.Property(e => e.AccessAfterAmount)
                    .HasColumnName("accessAfterAmount")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.AccessAmount)
                    .HasColumnName("accessAmount")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.AccessBeforeAmount)
                    .HasColumnName("accessBeforeAmount")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasColumnName("code")
                    .HasMaxLength(50);

                entity.Property(e => e.CraeteData)
                    .HasColumnName("craeteData")
                    .HasColumnType("datetime");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.LoginName)
                    .HasColumnName("loginName")
                    .HasMaxLength(50);

                entity.Property(e => e.Remark).HasMaxLength(408);

                entity.Property(e => e.Rid).HasColumnName("rid");

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasColumnName("type")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<UserIntegral>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.CreateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Exption1)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Exption2)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Exption3)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.LoginName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<UserIntegralInfo>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CreateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Exption1)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Exption2)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Exption3)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.FinanceType)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.LoginName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.TopUpSum).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.WarthDraw).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<UserLevelPaySetting>(entity =>
            {
                entity.HasIndex(e => new { e.Id, e.UserLevelName, e.PaySettingId })
                    .HasName("NonClusteredIndex-20160621-154901");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.PaySettingId)
                    .HasColumnName("PaySettingID")
                    .HasMaxLength(100);

                entity.Property(e => e.UserLevelName).HasMaxLength(100);
            });

            modelBuilder.Entity<UserLever>(entity =>
            {
                entity.HasKey(e => e.Name)
                    .HasName("PK_VIPSetting");

                entity.HasIndex(e => new { e.Ogvedio, e.OnlinepayHandselRate, e.Playset, e.Playtechgame, e.Playtechvedio, e.QrequestMessage, e.VedioGame, e.WithdrawCount, e.Aggame, e.Agvedio, e.Allbetgame, e.Allbetvedio, e.Ball, e.Bbingame, e.Bbinlottery, e.Bbinsport, e.Bbinvedio, e.CompanyHandselRate, e.Dj, e.Dsvedio, e.Hggame, e.Hgvedio, e.Lhc, e.LhcTA, e.LhcTB, e.LhcZA, e.LhcZB, e.Lottery, e.Mggame, e.Mgvedio, e.Name, e.Enable, e.IsTuiShui })
                    .HasName("NonClusteredIndex-20160621-155006");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(50);

                entity.Property(e => e.Aggame)
                    .HasColumnName("AGGame")
                    .HasColumnType("decimal(18, 5)");

                entity.Property(e => e.Agsport)
                    .HasColumnName("AGSport")
                    .HasColumnType("decimal(18, 5)");

                entity.Property(e => e.Agvedio)
                    .HasColumnName("AGVedio")
                    .HasColumnType("decimal(18, 5)");

                entity.Property(e => e.AlipayHandselRate)
                    .HasColumnName("alipayHandselRate")
                    .HasColumnType("decimal(18, 5)");

                entity.Property(e => e.Allbetgame)
                    .HasColumnName("ALLBETGame")
                    .HasColumnType("decimal(18, 5)");

                entity.Property(e => e.Allbetvedio)
                    .HasColumnName("ALLBETVedio")
                    .HasColumnType("decimal(18, 5)");

                entity.Property(e => e.Autolevelup).HasColumnName("autolevelup");

                entity.Property(e => e.Ball)
                    .HasColumnName("ball")
                    .HasColumnType("decimal(18, 5)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.BasketBall).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.Bbingame)
                    .HasColumnName("BBINGame")
                    .HasColumnType("decimal(18, 5)");

                entity.Property(e => e.Bbinlottery)
                    .HasColumnName("BBINLottery")
                    .HasColumnType("decimal(18, 5)");

                entity.Property(e => e.Bbinsport)
                    .HasColumnName("BBINSport")
                    .HasColumnType("decimal(18, 5)");

                entity.Property(e => e.Bbinvedio)
                    .HasColumnName("BBINVedio")
                    .HasColumnType("decimal(18, 5)");

                entity.Property(e => e.Bglottery)
                    .HasColumnName("BGLottery")
                    .HasColumnType("decimal(18, 5)");

                entity.Property(e => e.Bgvideo)
                    .HasColumnName("BGVideo")
                    .HasColumnType("decimal(18, 5)");

                entity.Property(e => e.ButchNoLiuhe).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ButchNoOther).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CompanyHandselRate)
                    .HasColumnName("companyHandselRate")
                    .HasColumnType("decimal(18, 5)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Cqgame)
                    .HasColumnName("CQGame")
                    .HasColumnType("decimal(18, 5)");

                entity.Property(e => e.CspbasketBall)
                    .HasColumnName("CSPBasketBall")
                    .HasColumnType("decimal(18, 5)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CspotherBall)
                    .HasColumnName("CSPOtherBall")
                    .HasColumnType("decimal(18, 5)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Cspsport)
                    .HasColumnName("CSPSport")
                    .HasColumnType("decimal(18, 5)");

                entity.Property(e => e.Dj)
                    .HasColumnName("DJ")
                    .HasColumnType("decimal(18, 5)");

                entity.Property(e => e.DrawCheckEnable).HasMaxLength(50);

                entity.Property(e => e.DrawCheckMode).HasMaxLength(50);

                entity.Property(e => e.Dsvedio)
                    .HasColumnName("DSVedio")
                    .HasColumnType("decimal(18, 5)");

                entity.Property(e => e.Enable).HasColumnName("enable");

                entity.Property(e => e.Esvideo)
                    .HasColumnName("ESVideo")
                    .HasColumnType("decimal(18, 5)");

                entity.Property(e => e.FinanceAccessColor).HasMaxLength(20);

                entity.Property(e => e.HandselRate)
                    .HasColumnType("decimal(18, 5)")
                    .HasDefaultValueSql("('2004')");

                entity.Property(e => e.Hggame)
                    .HasColumnName("HGGame")
                    .HasColumnType("decimal(18, 5)");

                entity.Property(e => e.Hgvedio)
                    .HasColumnName("HGVedio")
                    .HasColumnType("decimal(18, 5)");

                entity.Property(e => e.IsTuiShui)
                    .HasColumnName("isTuiShui")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Jpgame)
                    .HasColumnName("JPGame")
                    .HasColumnType("decimal(18, 5)");

                entity.Property(e => e.Kygame)
                    .HasColumnName("KYGame")
                    .HasColumnType("decimal(18, 5)");

                entity.Property(e => e.Kyvideo)
                    .HasColumnName("KYVideo")
                    .HasColumnType("decimal(18, 5)");

                entity.Property(e => e.Lhc)
                    .HasColumnName("LHC")
                    .HasColumnType("decimal(18, 5)");

                entity.Property(e => e.LhcTA)
                    .HasColumnName("LHC_T_A")
                    .HasColumnType("decimal(18, 5)");

                entity.Property(e => e.LhcTB)
                    .HasColumnName("LHC_T_B")
                    .HasColumnType("decimal(18, 5)");

                entity.Property(e => e.LhcZA)
                    .HasColumnName("LHC_Z_A")
                    .HasColumnType("decimal(18, 5)");

                entity.Property(e => e.LhcZB)
                    .HasColumnName("LHC_Z_B")
                    .HasColumnType("decimal(18, 5)");

                entity.Property(e => e.Lottery)
                    .HasColumnName("lottery")
                    .HasColumnType("decimal(18, 5)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.LotteryLimit).HasColumnType("decimal(15, 5)");

                entity.Property(e => e.MaxDraw).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Mggame)
                    .HasColumnName("MGGame")
                    .HasColumnType("decimal(18, 5)");

                entity.Property(e => e.Mgvedio)
                    .HasColumnName("MGVedio")
                    .HasColumnType("decimal(18, 5)");

                entity.Property(e => e.MinDraw).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.MoneyLimit)
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Nngame)
                    .HasColumnName("NNGame")
                    .HasColumnType("decimal(18, 5)");

                entity.Property(e => e.Nwggame)
                    .HasColumnName("NWGGame")
                    .HasColumnType("decimal(18, 5)");

                entity.Property(e => e.Ogpvideo)
                    .HasColumnName("OGPVideo")
                    .HasColumnType("decimal(18, 5)");

                entity.Property(e => e.Ogvedio)
                    .HasColumnName("OGVedio")
                    .HasColumnType("decimal(18, 5)");

                entity.Property(e => e.OnlinepayHandselRate)
                    .HasColumnName("onlinepayHandselRate")
                    .HasColumnType("decimal(18, 5)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.OtherBall).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.PersonHandselRate).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Playset)
                    .HasColumnName("playset")
                    .HasMaxLength(500);

                entity.Property(e => e.Playtechgame)
                    .HasColumnName("PLAYTECHGame")
                    .HasColumnType("decimal(18, 5)");

                entity.Property(e => e.Playtechvedio)
                    .HasColumnName("PLAYTECHVedio")
                    .HasColumnType("decimal(18, 5)");

                entity.Property(e => e.QqHandselRate)
                    .HasColumnName("qqHandselRate")
                    .HasColumnType("decimal(18, 5)");

                entity.Property(e => e.QrequestMessage).HasMaxLength(100);

                entity.Property(e => e.Rmggame)
                    .HasColumnName("RMGGame")
                    .HasColumnType("decimal(18, 5)");

                entity.Property(e => e.Sexyvideo)
                    .HasColumnName("SEXYVideo")
                    .HasColumnType("decimal(18, 5)");

                entity.Property(e => e.SortNum).HasDefaultValueSql("((0))");

                entity.Property(e => e.SportLimit).HasColumnType("decimal(15, 5)");

                entity.Property(e => e.Tgpgame)
                    .HasColumnName("TGPGame")
                    .HasColumnType("decimal(18, 5)");

                entity.Property(e => e.Tgpvideo)
                    .HasColumnName("TGPVideo")
                    .HasColumnType("decimal(18, 5)");

                entity.Property(e => e.TyConfirmTimeMax).HasColumnName("tyConfirmTimeMax");

                entity.Property(e => e.TyConfirmTimeMin).HasColumnName("tyConfirmTimeMin");

                entity.Property(e => e.Tylimit).HasColumnName("tylimit");

                entity.Property(e => e.VedioGame)
                    .HasColumnName("vedioGame")
                    .HasColumnType("decimal(18, 5)");

                entity.Property(e => e.Vggame)
                    .HasColumnName("VGGame")
                    .HasColumnType("decimal(18, 5)");

                entity.Property(e => e.VideoLimit).HasColumnType("decimal(15, 5)");

                entity.Property(e => e.Vrlottery)
                    .HasColumnName("VRLottery")
                    .HasColumnType("decimal(18, 5)");

                entity.Property(e => e.Vrvideo)
                    .HasColumnName("VRVideo")
                    .HasColumnType("decimal(18, 5)");

                entity.Property(e => e.WeixinHandselRate)
                    .HasColumnName("weixinHandselRate")
                    .HasColumnType("decimal(18, 5)");

                entity.Property(e => e.WithdrawCount).HasDefaultValueSql("((0))");

                entity.Property(e => e.YinlianHandselRate)
                    .HasColumnName("yinlianHandselRate")
                    .HasColumnType("decimal(18, 5)");
            });

            modelBuilder.Entity<UserLeverLimitSetting>(entity =>
            {
                entity.HasKey(e => e.LeverName)
                    .HasName("PK__UserLeve__8F0254225726924E");

                entity.Property(e => e.LeverName).HasMaxLength(50);

                entity.Property(e => e.AomenliuheLimit).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.AomenliuheMax).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.AomenshifenliuheLimit).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.AomenshifenliuheMax).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.CaipiaoLimit).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.CaipiaoMax).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Execties1)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Execties2)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Execties3)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.SportLimit).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.SportMax).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.TygqMax)
                    .HasColumnName("tygqMax")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.TygqMin)
                    .HasColumnName("tygqMin")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.TyzqbdMax)
                    .HasColumnName("tyzqbdMax")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.TyzqbdMin)
                    .HasColumnName("tyzqbdMin")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.TyzqdyMax)
                    .HasColumnName("tyzqdyMax")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.TyzqdyMin)
                    .HasColumnName("tyzqdyMin")
                    .HasColumnType("decimal(18, 0)");
            });

            modelBuilder.Entity<UserLoginCount>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("UserLoginCount");

                entity.Property(e => e.Agent)
                    .HasColumnName("agent")
                    .HasMaxLength(50);

                entity.Property(e => e.Balance)
                    .HasColumnName("balance")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.BankCrad)
                    .HasColumnName("bankCrad")
                    .HasMaxLength(100);

                entity.Property(e => e.City).HasMaxLength(50);

                entity.Property(e => e.CradPwd).HasMaxLength(50);

                entity.Property(e => e.DepositCount).HasColumnName("depositCount");

                entity.Property(e => e.DepositSum)
                    .HasColumnName("depositSum")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.FirstDepositNum)
                    .HasColumnName("firstDepositNum")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.FirstDepositTime)
                    .HasColumnName("firstDepositTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.FirstWithdrawNum)
                    .HasColumnName("firstWithdrawNum")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.FirstWithdrawTime)
                    .HasColumnName("firstWithdrawTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.GameAccount)
                    .HasColumnName("game_account")
                    .HasMaxLength(50);

                entity.Property(e => e.GamePwd).HasMaxLength(50);

                entity.Property(e => e.IPplace)
                    .HasColumnName("iPplace")
                    .HasMaxLength(500);

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Isdelete)
                    .HasColumnName("isdelete")
                    .HasMaxLength(1);

                entity.Property(e => e.Isreportignore).HasColumnName("isreportignore");

                entity.Property(e => e.LastLoginData)
                    .HasColumnName("lastLoginData")
                    .HasColumnType("datetime");

                entity.Property(e => e.LastLoginIp)
                    .HasColumnName("lastLoginIP")
                    .HasMaxLength(15);

                entity.Property(e => e.LastLogoutData)
                    .HasColumnName("lastLogoutData")
                    .HasColumnType("datetime");

                entity.Property(e => e.LoginCount).HasColumnName("loginCount");

                entity.Property(e => e.LoginCount2).HasColumnName("loginCount2");

                entity.Property(e => e.Loginname)
                    .HasColumnName("loginname")
                    .HasMaxLength(50);

                entity.Property(e => e.Mailaddr)
                    .HasColumnName("mailaddr")
                    .HasMaxLength(100)
                    .IsFixedLength();

                entity.Property(e => e.MaxDepositNum)
                    .HasColumnName("maxDepositNum")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.MaxDepositTime)
                    .HasColumnName("maxDepositTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.MaxWithdrawNum)
                    .HasColumnName("maxWithdrawNum")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.MaxWithdrawTime)
                    .HasColumnName("maxWithdrawTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.OneDayDepositSum)
                    .HasColumnName("oneDayDepositSum")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.OpenBandAddr)
                    .HasColumnName("openBandAddr")
                    .HasMaxLength(200);

                entity.Property(e => e.OpenBank)
                    .HasColumnName("openBank")
                    .HasMaxLength(100);

                entity.Property(e => e.OpenBankSub).HasMaxLength(50);

                entity.Property(e => e.Phone)
                    .HasColumnName("phone")
                    .HasMaxLength(50);

                entity.Property(e => e.Playset)
                    .HasColumnName("playset")
                    .HasMaxLength(500);

                entity.Property(e => e.Province).HasMaxLength(50);

                entity.Property(e => e.Pwd)
                    .HasColumnName("pwd")
                    .HasMaxLength(50);

                entity.Property(e => e.PwdAnswer)
                    .HasColumnName("pwdAnswer")
                    .HasMaxLength(100);

                entity.Property(e => e.PwdQuestion)
                    .HasColumnName("pwdQuestion")
                    .HasMaxLength(100);

                entity.Property(e => e.Qq)
                    .HasColumnName("qq")
                    .HasMaxLength(100);

                entity.Property(e => e.RegistData)
                    .HasColumnName("registData")
                    .HasColumnType("datetime");

                entity.Property(e => e.RegistIp)
                    .HasColumnName("registIP")
                    .HasMaxLength(15);

                entity.Property(e => e.Registaddr)
                    .HasColumnName("registaddr")
                    .HasMaxLength(100);

                entity.Property(e => e.RegisterDevice)
                    .HasColumnName("registerDevice")
                    .HasMaxLength(50);

                entity.Property(e => e.RegisterSource)
                    .HasColumnName("registerSource")
                    .HasMaxLength(100);

                entity.Property(e => e.Remark)
                    .HasColumnName("remark")
                    .HasMaxLength(200);

                entity.Property(e => e.Sex)
                    .HasColumnName("sex")
                    .HasMaxLength(1);

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasMaxLength(20);

                entity.Property(e => e.UserGroup)
                    .HasColumnName("userGroup")
                    .HasMaxLength(50);

                entity.Property(e => e.UserLeve)
                    .HasColumnName("userLeve")
                    .HasMaxLength(50);

                entity.Property(e => e.Username)
                    .HasColumnName("username")
                    .HasMaxLength(50);

                entity.Property(e => e.VipLevel)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.Weixin)
                    .HasColumnName("weixin")
                    .HasMaxLength(50);

                entity.Property(e => e.WithdrawCount).HasColumnName("withdrawCount");

                entity.Property(e => e.WithdrawSum)
                    .HasColumnName("withdrawSum")
                    .HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<UserMonthReportByAgent>(entity =>
            {
                entity.HasKey(e => new { e.LoginName, e.ReportMonth });

                entity.Property(e => e.LoginName).HasMaxLength(50);

                entity.Property(e => e.ReportMonth).HasMaxLength(10);

                entity.Property(e => e.Chongzhi).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CpShuYingMoney)
                    .HasColumnName("CP_ShuYing_Money")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CpWeiJieSuanMoney)
                    .HasColumnName("CP_WeiJieSuan_Money")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CpXiaZhuMoney)
                    .HasColumnName("CP_XiaZhu_Money")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.LhShuYingMoney)
                    .HasColumnName("LH_ShuYing_Money")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.LhWeiJieSuanMoney)
                    .HasColumnName("LH_WeiJieSuan_Money")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.LhXiaZhuMoney)
                    .HasColumnName("LH_XiaZhu_Money")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.NspShuYingMoney)
                    .HasColumnName("NSP_ShuYing_Money")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.NspWeiJieSuanMoney)
                    .HasColumnName("NSP_WeiJieSuan_Money")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.NspXiaZhuMoney)
                    .HasColumnName("NSP_XiaZhu_Money")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.NspYouXiaoMoney)
                    .HasColumnName("NSP_YouXiao_Money")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.SpShuYingMoney)
                    .HasColumnName("SP_ShuYing_Money")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.SpWeiJieSuanMoney)
                    .HasColumnName("SP_WeiJieSuan_Money")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.SpXiaZhuMoney)
                    .HasColumnName("SP_XiaZhu_Money")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.SpYouXiaoMoney)
                    .HasColumnName("SP_YouXiao_Money")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Tixian).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.UserGroup).HasMaxLength(50);

                entity.Property(e => e.ZrBetamount)
                    .HasColumnName("ZR_Betamount")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ZrNetamount)
                    .HasColumnName("ZR_Netamount")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ZrTransferInMoney)
                    .HasColumnName("ZR_TransferIn_Money")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ZrTransferOutMoney)
                    .HasColumnName("ZR_TransferOut_Money")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ZrValidamount)
                    .HasColumnName("ZR_Validamount")
                    .HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<UserSetting>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Edzhdetail)
                    .HasColumnName("EDZHDetail")
                    .HasMaxLength(500);

                entity.Property(e => e.IsFarbudBank).HasDefaultValueSql("((1))");

                entity.Property(e => e.IsFarbudBb).HasColumnName("IsFarbudBB");

                entity.Property(e => e.IsFarbudBbdj)
                    .HasColumnName("IsFarbudBBDJ")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.IsFarbudBd).HasColumnName("IsFarbudBD");

                entity.Property(e => e.IsFarbudEdzh).HasColumnName("IsFarbudEDZH");

                entity.Property(e => e.IsFarbudFb).HasColumnName("IsFarbudFB");

                entity.Property(e => e.IsFarbudFbdj)
                    .HasColumnName("IsFarbudFBDJ")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.IsFarbudPp).HasColumnName("IsFarbudPP");

                entity.Property(e => e.IsFarbudTb).HasColumnName("IsFarbudTB");

                entity.Property(e => e.IsFarbudVb).HasColumnName("IsFarbudVB");
            });

            modelBuilder.Entity<UserSignLog>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.EffectiveMoney).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.InsertDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Inserter)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Loginname)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.SignDate).HasColumnType("datetime");

                entity.Property(e => e.SignDayId).HasColumnName("SignDayID");

                entity.Property(e => e.UserId).HasColumnName("UserID");
            });

            modelBuilder.Entity<UserUpdateLog>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.ColumnName).HasMaxLength(50);

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.LoginName)
                    .HasColumnName("loginName")
                    .HasMaxLength(50);

                entity.Property(e => e.SysUserName).HasMaxLength(200);

                entity.Property(e => e.Type).HasMaxLength(50);
            });

            modelBuilder.Entity<UserVedioGameDayReport>(entity =>
            {
                entity.HasIndex(e => e.CreateTime)
                    .HasName("NonClusteredIndex-20180802-172035");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreateTime)
                    .HasColumnName("createTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.EgBetamount)
                    .HasColumnName("eg_betamount")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.EgNetamount)
                    .HasColumnName("eg_netamount")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.EgTsamount)
                    .HasColumnName("eg_tsamount")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.EgValidamount)
                    .HasColumnName("eg_validamount")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.GameRate).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.LoginName)
                    .HasColumnName("loginName")
                    .HasMaxLength(50);

                entity.Property(e => e.LotteryBetamount)
                    .HasColumnName("lottery_betamount")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.LotteryNetamount)
                    .HasColumnName("lottery_netamount")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.LotteryRate).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.LotteryTsamount)
                    .HasColumnName("lottery_tsamount")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.LotteryValidamount)
                    .HasColumnName("lottery_validamount")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Provider)
                    .HasColumnName("provider")
                    .HasMaxLength(50);

                entity.Property(e => e.RealBetamount)
                    .HasColumnName("real_betamount")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.RealNetamount)
                    .HasColumnName("real_netamount")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.RealTsamount)
                    .HasColumnName("real_tsamount")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.RealValidamount)
                    .HasColumnName("real_validamount")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.SportBetamount)
                    .HasColumnName("sport_betamount")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.SportNetamount)
                    .HasColumnName("sport_netamount")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.SportRate).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.SportTsamount)
                    .HasColumnName("sport_tsamount")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.SportValidamount)
                    .HasColumnName("sport_validamount")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TotalBetamount)
                    .HasColumnName("total_betamount")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TotalNetamount)
                    .HasColumnName("total_netamount")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TotalTsamount)
                    .HasColumnName("total_tsamount")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TotalValidamount)
                    .HasColumnName("total_validamount")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.VedioRate).HasColumnType("decimal(18, 5)");
            });

            modelBuilder.Entity<Userbak20190528>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("userbak20190528");

                entity.Property(e => e.Agent)
                    .HasColumnName("agent")
                    .HasMaxLength(50);

                entity.Property(e => e.Balance)
                    .HasColumnName("balance")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.BankCrad)
                    .HasColumnName("bankCrad")
                    .HasMaxLength(100);

                entity.Property(e => e.City).HasMaxLength(50);

                entity.Property(e => e.CradPwd).HasMaxLength(50);

                entity.Property(e => e.DepositCount).HasColumnName("depositCount");

                entity.Property(e => e.GameAccount)
                    .HasColumnName("game_account")
                    .HasMaxLength(50);

                entity.Property(e => e.GamePwd).HasMaxLength(50);

                entity.Property(e => e.IPplace)
                    .HasColumnName("iPplace")
                    .HasMaxLength(500);

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Isdelete)
                    .HasColumnName("isdelete")
                    .HasMaxLength(1);

                entity.Property(e => e.Isreportignore).HasColumnName("isreportignore");

                entity.Property(e => e.LastLoginData)
                    .HasColumnName("lastLoginData")
                    .HasColumnType("datetime");

                entity.Property(e => e.LastLoginIp)
                    .HasColumnName("lastLoginIP")
                    .HasMaxLength(15);

                entity.Property(e => e.LastLogoutData)
                    .HasColumnName("lastLogoutData")
                    .HasColumnType("datetime");

                entity.Property(e => e.LoginCount).HasColumnName("loginCount");

                entity.Property(e => e.Loginname)
                    .HasColumnName("loginname")
                    .HasMaxLength(50);

                entity.Property(e => e.Mailaddr)
                    .HasColumnName("mailaddr")
                    .HasMaxLength(100)
                    .IsFixedLength();

                entity.Property(e => e.OpenBandAddr)
                    .HasColumnName("openBandAddr")
                    .HasMaxLength(200);

                entity.Property(e => e.OpenBank)
                    .HasColumnName("openBank")
                    .HasMaxLength(100);

                entity.Property(e => e.OpenBankSub).HasMaxLength(50);

                entity.Property(e => e.Phone)
                    .HasColumnName("phone")
                    .HasMaxLength(50);

                entity.Property(e => e.Playset)
                    .HasColumnName("playset")
                    .HasMaxLength(500);

                entity.Property(e => e.Province).HasMaxLength(50);

                entity.Property(e => e.Pwd)
                    .HasColumnName("pwd")
                    .HasMaxLength(50);

                entity.Property(e => e.PwdAnswer)
                    .HasColumnName("pwdAnswer")
                    .HasMaxLength(100);

                entity.Property(e => e.PwdQuestion)
                    .HasColumnName("pwdQuestion")
                    .HasMaxLength(100);

                entity.Property(e => e.Qq)
                    .HasColumnName("qq")
                    .HasMaxLength(100);

                entity.Property(e => e.RegistData)
                    .HasColumnName("registData")
                    .HasColumnType("datetime");

                entity.Property(e => e.RegistIp)
                    .HasColumnName("registIP")
                    .HasMaxLength(15);

                entity.Property(e => e.Registaddr)
                    .HasColumnName("registaddr")
                    .HasMaxLength(100);

                entity.Property(e => e.Remark)
                    .HasColumnName("remark")
                    .HasMaxLength(200);

                entity.Property(e => e.Sex)
                    .HasColumnName("sex")
                    .HasMaxLength(1);

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasMaxLength(20);

                entity.Property(e => e.UserGroup)
                    .HasColumnName("userGroup")
                    .HasMaxLength(50);

                entity.Property(e => e.UserLeve)
                    .HasColumnName("userLeve")
                    .HasMaxLength(50);

                entity.Property(e => e.Username)
                    .HasColumnName("username")
                    .HasMaxLength(50);

                entity.Property(e => e.VipLevel)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.Weixin)
                    .HasColumnName("weixin")
                    .HasMaxLength(50);

                entity.Property(e => e.WithdrawCount).HasColumnName("withdrawCount");
            });

            modelBuilder.Entity<Users>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.LoginName).HasMaxLength(50);

                entity.Property(e => e.Pwd).HasMaxLength(50);

                entity.Property(e => e.Status).HasMaxLength(50);
            });

            modelBuilder.Entity<UsersRolesMap>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.RoleName).HasMaxLength(50);

                entity.Property(e => e.UserId).HasColumnName("UserID");
            });

            modelBuilder.Entity<VAgentUser>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vAgentUser");

                entity.Property(e => e.Agent)
                    .HasColumnName("agent")
                    .HasMaxLength(50);

                entity.Property(e => e.Balance)
                    .HasColumnName("balance")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.BankCrad)
                    .HasColumnName("bankCrad")
                    .HasMaxLength(100);

                entity.Property(e => e.CradPwd).HasMaxLength(50);

                entity.Property(e => e.GameAccount)
                    .HasColumnName("game_account")
                    .HasMaxLength(50);

                entity.Property(e => e.GamePwd).HasMaxLength(50);

                entity.Property(e => e.IPplace)
                    .HasColumnName("iPplace")
                    .HasMaxLength(500);

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Isdelete)
                    .HasColumnName("isdelete")
                    .HasMaxLength(1);

                entity.Property(e => e.Isreportignore).HasColumnName("isreportignore");

                entity.Property(e => e.LastLoginData)
                    .HasColumnName("lastLoginData")
                    .HasColumnType("datetime");

                entity.Property(e => e.LastLoginIp)
                    .HasColumnName("lastLoginIP")
                    .HasMaxLength(15);

                entity.Property(e => e.LastLogoutData)
                    .HasColumnName("lastLogoutData")
                    .HasColumnType("datetime");

                entity.Property(e => e.LoginCount).HasColumnName("loginCount");

                entity.Property(e => e.Loginname)
                    .HasColumnName("loginname")
                    .HasMaxLength(50);

                entity.Property(e => e.Mailaddr)
                    .HasColumnName("mailaddr")
                    .HasMaxLength(100)
                    .IsFixedLength();

                entity.Property(e => e.OpenBandAddr)
                    .HasColumnName("openBandAddr")
                    .HasMaxLength(200);

                entity.Property(e => e.OpenBank)
                    .HasColumnName("openBank")
                    .HasMaxLength(100);

                entity.Property(e => e.Phone)
                    .HasColumnName("phone")
                    .HasMaxLength(50);

                entity.Property(e => e.Playset)
                    .HasColumnName("playset")
                    .HasMaxLength(500);

                entity.Property(e => e.Pwd)
                    .HasColumnName("pwd")
                    .HasMaxLength(50);

                entity.Property(e => e.PwdAnswer)
                    .HasColumnName("pwdAnswer")
                    .HasMaxLength(100);

                entity.Property(e => e.PwdQuestion)
                    .HasColumnName("pwdQuestion")
                    .HasMaxLength(100);

                entity.Property(e => e.Qq)
                    .HasColumnName("qq")
                    .HasMaxLength(20);

                entity.Property(e => e.RegistData)
                    .HasColumnName("registData")
                    .HasColumnType("datetime");

                entity.Property(e => e.RegistIp)
                    .HasColumnName("registIP")
                    .HasMaxLength(15);

                entity.Property(e => e.Registaddr)
                    .HasColumnName("registaddr")
                    .HasMaxLength(100);

                entity.Property(e => e.Remark)
                    .HasColumnName("remark")
                    .HasMaxLength(200);

                entity.Property(e => e.Sex)
                    .HasColumnName("sex")
                    .HasMaxLength(1);

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasMaxLength(20);

                entity.Property(e => e.UserGroup)
                    .HasColumnName("userGroup")
                    .HasMaxLength(50);

                entity.Property(e => e.UserLeve)
                    .HasColumnName("userLeve")
                    .HasMaxLength(50);

                entity.Property(e => e.Username)
                    .HasColumnName("username")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<VApibbetUserData>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vApibbet_UserData");

                entity.Property(e => e.Agent).HasMaxLength(250);

                entity.Property(e => e.Aggame)
                    .HasColumnName("AGGame")
                    .HasColumnType("decimal(18, 5)");

                entity.Property(e => e.Agsport)
                    .HasColumnName("AGSport")
                    .HasColumnType("decimal(18, 5)");

                entity.Property(e => e.Agvedio)
                    .HasColumnName("AGVedio")
                    .HasColumnType("decimal(18, 5)");

                entity.Property(e => e.AlipayHandselRate)
                    .HasColumnName("alipayHandselRate")
                    .HasColumnType("decimal(18, 5)");

                entity.Property(e => e.Allbetgame)
                    .HasColumnName("ALLBETGame")
                    .HasColumnType("decimal(18, 5)");

                entity.Property(e => e.Allbetvedio)
                    .HasColumnName("ALLBETVedio")
                    .HasColumnType("decimal(18, 5)");

                entity.Property(e => e.Autolevelup).HasColumnName("autolevelup");

                entity.Property(e => e.Ball)
                    .HasColumnName("ball")
                    .HasColumnType("decimal(18, 5)");

                entity.Property(e => e.BasketBall).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.Bbingame)
                    .HasColumnName("BBINGame")
                    .HasColumnType("decimal(18, 5)");

                entity.Property(e => e.Bbinlottery)
                    .HasColumnName("BBINLottery")
                    .HasColumnType("decimal(18, 5)");

                entity.Property(e => e.Bbinsport)
                    .HasColumnName("BBINSport")
                    .HasColumnType("decimal(18, 5)");

                entity.Property(e => e.Bbinvedio)
                    .HasColumnName("BBINVedio")
                    .HasColumnType("decimal(18, 5)");

                entity.Property(e => e.BetAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Bglottery)
                    .HasColumnName("BGLottery")
                    .HasColumnType("decimal(18, 5)");

                entity.Property(e => e.Bgvideo)
                    .HasColumnName("BGVideo")
                    .HasColumnType("decimal(18, 5)");

                entity.Property(e => e.BillNo)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.ButchNoLiuhe).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ButchNoOther).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CompanyHandselRate)
                    .HasColumnName("companyHandselRate")
                    .HasColumnType("decimal(18, 5)");

                entity.Property(e => e.Cqgame)
                    .HasColumnName("CQGame")
                    .HasColumnType("decimal(18, 5)");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.CspbasketBall)
                    .HasColumnName("CSPBasketBall")
                    .HasColumnType("decimal(18, 5)");

                entity.Property(e => e.CspotherBall)
                    .HasColumnName("CSPOtherBall")
                    .HasColumnType("decimal(18, 5)");

                entity.Property(e => e.Cspsport)
                    .HasColumnName("CSPSport")
                    .HasColumnType("decimal(18, 5)");

                entity.Property(e => e.Dj)
                    .HasColumnName("DJ")
                    .HasColumnType("decimal(18, 5)");

                entity.Property(e => e.DrawCheckEnable).HasMaxLength(50);

                entity.Property(e => e.DrawCheckMode).HasMaxLength(50);

                entity.Property(e => e.Dsvedio)
                    .HasColumnName("DSVedio")
                    .HasColumnType("decimal(18, 5)");

                entity.Property(e => e.Enable).HasColumnName("enable");

                entity.Property(e => e.Esvideo)
                    .HasColumnName("ESVideo")
                    .HasColumnType("decimal(18, 5)");

                entity.Property(e => e.FileName)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.FinanceAccessColor).HasMaxLength(20);

                entity.Property(e => e.HandselRate).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.Hggame)
                    .HasColumnName("HGGame")
                    .HasColumnType("decimal(18, 5)");

                entity.Property(e => e.Hgvedio)
                    .HasColumnName("HGVedio")
                    .HasColumnType("decimal(18, 5)");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.IsTuiShui).HasColumnName("isTuiShui");

                entity.Property(e => e.Jpgame)
                    .HasColumnName("JPGame")
                    .HasColumnType("decimal(18, 5)");

                entity.Property(e => e.Kygame)
                    .HasColumnName("KYGame")
                    .HasColumnType("decimal(18, 5)");

                entity.Property(e => e.Kyvideo)
                    .HasColumnName("KYVideo")
                    .HasColumnType("decimal(18, 5)");

                entity.Property(e => e.LastModifyTime).HasColumnType("datetime");

                entity.Property(e => e.Lhc)
                    .HasColumnName("LHC")
                    .HasColumnType("decimal(18, 5)");

                entity.Property(e => e.LhcTA)
                    .HasColumnName("LHC_T_A")
                    .HasColumnType("decimal(18, 5)");

                entity.Property(e => e.LhcTB)
                    .HasColumnName("LHC_T_B")
                    .HasColumnType("decimal(18, 5)");

                entity.Property(e => e.LhcZA)
                    .HasColumnName("LHC_Z_A")
                    .HasColumnType("decimal(18, 5)");

                entity.Property(e => e.LhcZB)
                    .HasColumnName("LHC_Z_B")
                    .HasColumnType("decimal(18, 5)");

                entity.Property(e => e.Lottery)
                    .HasColumnName("lottery")
                    .HasColumnType("decimal(18, 5)");

                entity.Property(e => e.LotteryLimit).HasColumnType("decimal(15, 5)");

                entity.Property(e => e.MaxDraw).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Member).HasMaxLength(250);

                entity.Property(e => e.MemberName)
                    .HasColumnName("Member_Name")
                    .HasMaxLength(250);

                entity.Property(e => e.Mggame)
                    .HasColumnName("MGGame")
                    .HasColumnType("decimal(18, 5)");

                entity.Property(e => e.Mgvedio)
                    .HasColumnName("MGVedio")
                    .HasColumnType("decimal(18, 5)");

                entity.Property(e => e.MinDraw).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.MoneyLimit).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(50);

                entity.Property(e => e.NetAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Nngame)
                    .HasColumnName("NNGame")
                    .HasColumnType("decimal(18, 5)");

                entity.Property(e => e.Nwggame)
                    .HasColumnName("NWGGame")
                    .HasColumnType("decimal(18, 5)");

                entity.Property(e => e.Ogpvideo)
                    .HasColumnName("OGPVideo")
                    .HasColumnType("decimal(18, 5)");

                entity.Property(e => e.Ogvedio)
                    .HasColumnName("OGVedio")
                    .HasColumnType("decimal(18, 5)");

                entity.Property(e => e.OnlinepayHandselRate)
                    .HasColumnName("onlinepayHandselRate")
                    .HasColumnType("decimal(18, 5)");

                entity.Property(e => e.OtherBall).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.PersonHandselRate).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Playset)
                    .HasColumnName("playset")
                    .HasMaxLength(500);

                entity.Property(e => e.Playtechgame)
                    .HasColumnName("PLAYTECHGame")
                    .HasColumnType("decimal(18, 5)");

                entity.Property(e => e.Playtechvedio)
                    .HasColumnName("PLAYTECHVedio")
                    .HasColumnType("decimal(18, 5)");

                entity.Property(e => e.Provider).HasMaxLength(50);

                entity.Property(e => e.QqHandselRate)
                    .HasColumnName("qqHandselRate")
                    .HasColumnType("decimal(18, 5)");

                entity.Property(e => e.QrequestMessage).HasMaxLength(100);

                entity.Property(e => e.Rmggame)
                    .HasColumnName("RMGGame")
                    .HasColumnType("decimal(18, 5)");

                entity.Property(e => e.Sexyvideo)
                    .HasColumnName("SEXYVideo")
                    .HasColumnType("decimal(18, 5)");

                entity.Property(e => e.SportLimit).HasColumnType("decimal(15, 5)");

                entity.Property(e => e.Status).HasMaxLength(50);

                entity.Property(e => e.Tgpgame)
                    .HasColumnName("TGPGame")
                    .HasColumnType("decimal(18, 5)");

                entity.Property(e => e.Tgpvideo)
                    .HasColumnName("TGPVideo")
                    .HasColumnType("decimal(18, 5)");

                entity.Property(e => e.Time)
                    .HasColumnName("time")
                    .HasColumnType("datetime");

                entity.Property(e => e.TimeChn)
                    .HasColumnName("time_chn")
                    .HasColumnType("datetime");

                entity.Property(e => e.TimeUst)
                    .HasColumnName("time_ust")
                    .HasColumnType("datetime");

                entity.Property(e => e.TimeUtc)
                    .HasColumnName("time_utc")
                    .HasColumnType("datetime");

                entity.Property(e => e.TyConfirmTimeMax).HasColumnName("tyConfirmTimeMax");

                entity.Property(e => e.TyConfirmTimeMin).HasColumnName("tyConfirmTimeMin");

                entity.Property(e => e.Tylimit).HasColumnName("tylimit");

                entity.Property(e => e.Type).HasMaxLength(100);

                entity.Property(e => e.UserName).HasMaxLength(250);

                entity.Property(e => e.ValidAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.VedioGame)
                    .HasColumnName("vedioGame")
                    .HasColumnType("decimal(18, 5)");

                entity.Property(e => e.Vggame)
                    .HasColumnName("VGGame")
                    .HasColumnType("decimal(18, 5)");

                entity.Property(e => e.VideoLimit).HasColumnType("decimal(15, 5)");

                entity.Property(e => e.Vrlottery)
                    .HasColumnName("VRLottery")
                    .HasColumnType("decimal(18, 5)");

                entity.Property(e => e.Vrvideo)
                    .HasColumnName("VRVideo")
                    .HasColumnType("decimal(18, 5)");

                entity.Property(e => e.WeixinHandselRate)
                    .HasColumnName("weixinHandselRate")
                    .HasColumnType("decimal(18, 5)");

                entity.Property(e => e.YinlianHandselRate)
                    .HasColumnName("yinlianHandselRate")
                    .HasColumnType("decimal(18, 5)");
            });

            modelBuilder.Entity<VApibbetUserDataEx>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vApibbet_UserDataEx");

                entity.Property(e => e.Agent).HasMaxLength(250);

                entity.Property(e => e.Aggame)
                    .HasColumnName("AGGame")
                    .HasColumnType("decimal(18, 5)");

                entity.Property(e => e.Agsport)
                    .HasColumnName("AGSport")
                    .HasColumnType("decimal(18, 5)");

                entity.Property(e => e.Agvedio)
                    .HasColumnName("AGVedio")
                    .HasColumnType("decimal(18, 5)");

                entity.Property(e => e.Allbetgame)
                    .HasColumnName("ALLBETGame")
                    .HasColumnType("decimal(18, 5)");

                entity.Property(e => e.Allbetvedio)
                    .HasColumnName("ALLBETVedio")
                    .HasColumnType("decimal(18, 5)");

                entity.Property(e => e.Autolevelup).HasColumnName("autolevelup");

                entity.Property(e => e.Ball)
                    .HasColumnName("ball")
                    .HasColumnType("decimal(18, 5)");

                entity.Property(e => e.Bbingame)
                    .HasColumnName("BBINGame")
                    .HasColumnType("decimal(18, 5)");

                entity.Property(e => e.Bbinlottery)
                    .HasColumnName("BBINLottery")
                    .HasColumnType("decimal(18, 5)");

                entity.Property(e => e.Bbinsport)
                    .HasColumnName("BBINSport")
                    .HasColumnType("decimal(18, 5)");

                entity.Property(e => e.Bbinvedio)
                    .HasColumnName("BBINVedio")
                    .HasColumnType("decimal(18, 5)");

                entity.Property(e => e.BetAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Bglottery)
                    .HasColumnName("BGLottery")
                    .HasColumnType("decimal(18, 5)");

                entity.Property(e => e.Bgvideo)
                    .HasColumnName("BGVideo")
                    .HasColumnType("decimal(18, 5)");

                entity.Property(e => e.BillNo)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.CompanyHandselRate)
                    .HasColumnName("companyHandselRate")
                    .HasColumnType("decimal(18, 5)");

                entity.Property(e => e.Cqgame)
                    .HasColumnName("CQGame")
                    .HasColumnType("decimal(18, 5)");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.Cspsport)
                    .HasColumnName("CSPSport")
                    .HasColumnType("decimal(18, 5)");

                entity.Property(e => e.Dj)
                    .HasColumnName("DJ")
                    .HasColumnType("decimal(18, 5)");

                entity.Property(e => e.DrawCheckEnable).HasMaxLength(50);

                entity.Property(e => e.DrawCheckMode).HasMaxLength(50);

                entity.Property(e => e.Dsvedio)
                    .HasColumnName("DSVedio")
                    .HasColumnType("decimal(18, 5)");

                entity.Property(e => e.Enable).HasColumnName("enable");

                entity.Property(e => e.Esvideo)
                    .HasColumnName("ESVideo")
                    .HasColumnType("decimal(18, 5)");

                entity.Property(e => e.FinanceAccessColor).HasMaxLength(20);

                entity.Property(e => e.Hggame)
                    .HasColumnName("HGGame")
                    .HasColumnType("decimal(18, 5)");

                entity.Property(e => e.Hgvedio)
                    .HasColumnName("HGVedio")
                    .HasColumnType("decimal(18, 5)");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.IsTuiShui).HasColumnName("isTuiShui");

                entity.Property(e => e.Jpgame)
                    .HasColumnName("JPGame")
                    .HasColumnType("decimal(18, 5)");

                entity.Property(e => e.Kygame)
                    .HasColumnName("KYGame")
                    .HasColumnType("decimal(18, 5)");

                entity.Property(e => e.Kyvideo)
                    .HasColumnName("KYVideo")
                    .HasColumnType("decimal(18, 5)");

                entity.Property(e => e.LastModifyTime).HasColumnType("datetime");

                entity.Property(e => e.Lhc)
                    .HasColumnName("LHC")
                    .HasColumnType("decimal(18, 5)");

                entity.Property(e => e.LhcTA)
                    .HasColumnName("LHC_T_A")
                    .HasColumnType("decimal(18, 5)");

                entity.Property(e => e.LhcTB)
                    .HasColumnName("LHC_T_B")
                    .HasColumnType("decimal(18, 5)");

                entity.Property(e => e.LhcZA)
                    .HasColumnName("LHC_Z_A")
                    .HasColumnType("decimal(18, 5)");

                entity.Property(e => e.LhcZB)
                    .HasColumnName("LHC_Z_B")
                    .HasColumnType("decimal(18, 5)");

                entity.Property(e => e.Lottery)
                    .HasColumnName("lottery")
                    .HasColumnType("decimal(18, 5)");

                entity.Property(e => e.LotteryLimit).HasColumnType("decimal(15, 5)");

                entity.Property(e => e.Member).HasMaxLength(250);

                entity.Property(e => e.MemberName)
                    .HasColumnName("Member_Name")
                    .HasMaxLength(250);

                entity.Property(e => e.Mggame)
                    .HasColumnName("MGGame")
                    .HasColumnType("decimal(18, 5)");

                entity.Property(e => e.Mgvedio)
                    .HasColumnName("MGVedio")
                    .HasColumnType("decimal(18, 5)");

                entity.Property(e => e.MinDraw).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.MoneyLimit).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(50);

                entity.Property(e => e.NetAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Nngame)
                    .HasColumnName("NNGame")
                    .HasColumnType("decimal(18, 5)");

                entity.Property(e => e.Nwggame)
                    .HasColumnName("NWGGame")
                    .HasColumnType("decimal(18, 5)");

                entity.Property(e => e.Ogpvideo)
                    .HasColumnName("OGPVideo")
                    .HasColumnType("decimal(18, 5)");

                entity.Property(e => e.Ogvedio)
                    .HasColumnName("OGVedio")
                    .HasColumnType("decimal(18, 5)");

                entity.Property(e => e.OnlinepayHandselRate)
                    .HasColumnName("onlinepayHandselRate")
                    .HasColumnType("decimal(18, 5)");

                entity.Property(e => e.Playset)
                    .HasColumnName("playset")
                    .HasMaxLength(500);

                entity.Property(e => e.Playtechgame)
                    .HasColumnName("PLAYTECHGame")
                    .HasColumnType("decimal(18, 5)");

                entity.Property(e => e.Playtechvedio)
                    .HasColumnName("PLAYTECHVedio")
                    .HasColumnType("decimal(18, 5)");

                entity.Property(e => e.Provider).HasMaxLength(50);

                entity.Property(e => e.QrequestMessage).HasMaxLength(100);

                entity.Property(e => e.Rmggame)
                    .HasColumnName("RMGGame")
                    .HasColumnType("decimal(18, 5)");

                entity.Property(e => e.Sexyvideo)
                    .HasColumnName("SEXYVideo")
                    .HasColumnType("decimal(18, 5)");

                entity.Property(e => e.SportLimit).HasColumnType("decimal(15, 5)");

                entity.Property(e => e.Status).HasMaxLength(50);

                entity.Property(e => e.Tgpgame)
                    .HasColumnName("TGPGame")
                    .HasColumnType("decimal(18, 5)");

                entity.Property(e => e.Tgpvideo)
                    .HasColumnName("TGPVideo")
                    .HasColumnType("decimal(18, 5)");

                entity.Property(e => e.Time)
                    .HasColumnName("time")
                    .HasColumnType("datetime");

                entity.Property(e => e.TimeChn)
                    .HasColumnName("time_chn")
                    .HasColumnType("datetime");

                entity.Property(e => e.TimeUst)
                    .HasColumnName("time_ust")
                    .HasColumnType("datetime");

                entity.Property(e => e.TimeUtc)
                    .HasColumnName("time_utc")
                    .HasColumnType("datetime");

                entity.Property(e => e.TyConfirmTimeMax).HasColumnName("tyConfirmTimeMax");

                entity.Property(e => e.TyConfirmTimeMin).HasColumnName("tyConfirmTimeMin");

                entity.Property(e => e.Tylimit).HasColumnName("tylimit");

                entity.Property(e => e.Type).HasMaxLength(100);

                entity.Property(e => e.UserGroup)
                    .HasColumnName("userGroup")
                    .HasMaxLength(50);

                entity.Property(e => e.UserName).HasMaxLength(250);

                entity.Property(e => e.ValidAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.VedioGame)
                    .HasColumnName("vedioGame")
                    .HasColumnType("decimal(18, 5)");

                entity.Property(e => e.Vggame)
                    .HasColumnName("VGGame")
                    .HasColumnType("decimal(18, 5)");

                entity.Property(e => e.VideoLimit).HasColumnType("decimal(15, 5)");

                entity.Property(e => e.Vrlottery)
                    .HasColumnName("VRLottery")
                    .HasColumnType("decimal(18, 5)");

                entity.Property(e => e.Vrvideo)
                    .HasColumnName("VRVideo")
                    .HasColumnType("decimal(18, 5)");
            });

            modelBuilder.Entity<VApibbetUserDataExByProvider>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vApibbet_UserDataExByProvider");

                entity.Property(e => e.BetAmount).HasColumnType("decimal(38, 2)");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.MemberName)
                    .HasColumnName("Member_Name")
                    .HasMaxLength(250);

                entity.Property(e => e.NetAmount).HasColumnType("decimal(38, 2)");

                entity.Property(e => e.Provider).HasMaxLength(50);

                entity.Property(e => e.TimeChn).HasColumnType("datetime");

                entity.Property(e => e.ValidAmount).HasColumnType("decimal(38, 2)");
            });

            modelBuilder.Entity<VUpdateUserVedioGameDayReport>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_UpdateUserVedioGameDayReport");

                entity.Property(e => e.CalcDate)
                    .HasColumnName("calc_date")
                    .HasMaxLength(50);

                entity.Property(e => e.EgBetamount)
                    .HasColumnName("eg_betamount")
                    .HasColumnType("decimal(38, 2)");

                entity.Property(e => e.EgNetamount)
                    .HasColumnName("eg_netamount")
                    .HasColumnType("decimal(38, 2)");

                entity.Property(e => e.EgTsamount)
                    .HasColumnName("eg_tsamount")
                    .HasColumnType("decimal(38, 7)");

                entity.Property(e => e.EgValidamount)
                    .HasColumnName("eg_validamount")
                    .HasColumnType("decimal(38, 2)");

                entity.Property(e => e.LoginName)
                    .HasColumnName("loginName")
                    .HasMaxLength(50);

                entity.Property(e => e.LotteryBetamount)
                    .HasColumnName("lottery_betamount")
                    .HasColumnType("decimal(38, 2)");

                entity.Property(e => e.LotteryNetamount)
                    .HasColumnName("lottery_netamount")
                    .HasColumnType("decimal(38, 2)");

                entity.Property(e => e.LotteryTsamount)
                    .HasColumnName("lottery_tsamount")
                    .HasColumnType("decimal(38, 7)");

                entity.Property(e => e.LotteryValidamount)
                    .HasColumnName("lottery_validamount")
                    .HasColumnType("decimal(38, 2)");

                entity.Property(e => e.Provider)
                    .HasColumnName("provider")
                    .HasMaxLength(50);

                entity.Property(e => e.RealBetamount)
                    .HasColumnName("real_betamount")
                    .HasColumnType("decimal(38, 2)");

                entity.Property(e => e.RealNetamount)
                    .HasColumnName("real_netamount")
                    .HasColumnType("decimal(38, 2)");

                entity.Property(e => e.RealTsamount)
                    .HasColumnName("real_tsamount")
                    .HasColumnType("decimal(38, 7)");

                entity.Property(e => e.RealValidamount)
                    .HasColumnName("real_validamount")
                    .HasColumnType("decimal(38, 2)");

                entity.Property(e => e.SportBetamount)
                    .HasColumnName("sport_betamount")
                    .HasColumnType("decimal(38, 2)");

                entity.Property(e => e.SportNetamount)
                    .HasColumnName("sport_netamount")
                    .HasColumnType("decimal(38, 2)");

                entity.Property(e => e.SportTsamount)
                    .HasColumnName("sport_tsamount")
                    .HasColumnType("decimal(38, 7)");

                entity.Property(e => e.SportValidamount)
                    .HasColumnName("sport_validamount")
                    .HasColumnType("decimal(38, 2)");

                entity.Property(e => e.TotalBetamount)
                    .HasColumnName("total_betamount")
                    .HasColumnType("decimal(38, 2)");

                entity.Property(e => e.TotalNetamount)
                    .HasColumnName("total_netamount")
                    .HasColumnType("decimal(38, 2)");

                entity.Property(e => e.TotalTsamount)
                    .HasColumnName("total_tsamount")
                    .HasColumnType("decimal(38, 7)");

                entity.Property(e => e.TotalValidamount)
                    .HasColumnName("total_validamount")
                    .HasColumnType("decimal(38, 2)");
            });

            modelBuilder.Entity<VUser>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vUser");

                entity.Property(e => e.Agent)
                    .HasColumnName("agent")
                    .HasMaxLength(50);

                entity.Property(e => e.Balance)
                    .HasColumnName("balance")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.BankCrad)
                    .HasColumnName("bankCrad")
                    .HasMaxLength(100);

                entity.Property(e => e.CradPwd).HasMaxLength(50);

                entity.Property(e => e.GameAccount)
                    .HasColumnName("game_account")
                    .HasMaxLength(50);

                entity.Property(e => e.GamePwd).HasMaxLength(50);

                entity.Property(e => e.IPplace)
                    .HasColumnName("iPplace")
                    .HasMaxLength(500);

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.InfoSource).HasMaxLength(100);

                entity.Property(e => e.Isdelete)
                    .HasColumnName("isdelete")
                    .HasMaxLength(1);

                entity.Property(e => e.Isreportignore).HasColumnName("isreportignore");

                entity.Property(e => e.LastLoginData)
                    .HasColumnName("lastLoginData")
                    .HasColumnType("datetime");

                entity.Property(e => e.LastLoginIp)
                    .HasColumnName("lastLoginIP")
                    .HasMaxLength(15);

                entity.Property(e => e.LastLogoutData)
                    .HasColumnName("lastLogoutData")
                    .HasColumnType("datetime");

                entity.Property(e => e.LoginCount).HasColumnName("loginCount");

                entity.Property(e => e.LoginUrl)
                    .HasColumnName("loginURL")
                    .HasMaxLength(250);

                entity.Property(e => e.Loginname)
                    .HasColumnName("loginname")
                    .HasMaxLength(50);

                entity.Property(e => e.Mailaddr)
                    .HasColumnName("mailaddr")
                    .HasMaxLength(100)
                    .IsFixedLength();

                entity.Property(e => e.OpenBandAddr)
                    .HasColumnName("openBandAddr")
                    .HasMaxLength(200);

                entity.Property(e => e.OpenBank)
                    .HasColumnName("openBank")
                    .HasMaxLength(100);

                entity.Property(e => e.Phone)
                    .HasColumnName("phone")
                    .HasMaxLength(50);

                entity.Property(e => e.Playset)
                    .HasColumnName("playset")
                    .HasMaxLength(500);

                entity.Property(e => e.Pwd)
                    .HasColumnName("pwd")
                    .HasMaxLength(50);

                entity.Property(e => e.PwdAnswer)
                    .HasColumnName("pwdAnswer")
                    .HasMaxLength(100);

                entity.Property(e => e.PwdQuestion)
                    .HasColumnName("pwdQuestion")
                    .HasMaxLength(100);

                entity.Property(e => e.Qq)
                    .HasColumnName("qq")
                    .HasMaxLength(100);

                entity.Property(e => e.QuantityAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.RegistData)
                    .HasColumnName("registData")
                    .HasColumnType("datetime");

                entity.Property(e => e.RegistIp)
                    .HasColumnName("registIP")
                    .HasMaxLength(15);

                entity.Property(e => e.Registaddr)
                    .HasColumnName("registaddr")
                    .HasMaxLength(100);

                entity.Property(e => e.RegisterDevice)
                    .HasColumnName("registerDevice")
                    .HasMaxLength(50);

                entity.Property(e => e.RegisterSource)
                    .HasColumnName("registerSource")
                    .HasMaxLength(100);

                entity.Property(e => e.Remark)
                    .HasColumnName("remark")
                    .HasMaxLength(200);

                entity.Property(e => e.Sex)
                    .HasColumnName("sex")
                    .HasMaxLength(1);

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasMaxLength(20);

                entity.Property(e => e.UserGroup)
                    .HasColumnName("userGroup")
                    .HasMaxLength(50);

                entity.Property(e => e.UserLeve)
                    .HasColumnName("userLeve")
                    .HasMaxLength(50);

                entity.Property(e => e.Username)
                    .HasColumnName("username")
                    .HasMaxLength(50);

                entity.Property(e => e.Weixin)
                    .HasColumnName("weixin")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<VedioGameDayReport>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.AgBetamount)
                    .HasColumnName("ag_betamount")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.AgNetamount)
                    .HasColumnName("ag_netamount")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.AgTsamount)
                    .HasColumnName("ag_tsamount")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.AgValidamount)
                    .HasColumnName("ag_validamount")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.AllbetBetamount)
                    .HasColumnName("allbet_betamount")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.AllbetNetamount)
                    .HasColumnName("allbet_netamount")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.AllbetTsamount)
                    .HasColumnName("allbet_tsamount")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.AllbetValidamount)
                    .HasColumnName("allbet_validamount")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.BbinBetamount)
                    .HasColumnName("bbin_betamount")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.BbinNetamount)
                    .HasColumnName("bbin_netamount")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.BbinTsamount)
                    .HasColumnName("bbin_tsamount")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.BbinValidamount)
                    .HasColumnName("bbin_validamount")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.HgBetamount)
                    .HasColumnName("hg_betamount")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.HgNetamount)
                    .HasColumnName("hg_netamount")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.HgTsamount)
                    .HasColumnName("hg_tsamount")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.HgValidamount)
                    .HasColumnName("hg_validamount")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.PtBetamount)
                    .HasColumnName("pt_betamount")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.PtNetamount)
                    .HasColumnName("pt_netamount")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.PtTsamount)
                    .HasColumnName("pt_tsamount")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.PtValidamount)
                    .HasColumnName("pt_validamount")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ReportDay)
                    .HasColumnName("reportDay")
                    .HasColumnType("datetime");

                entity.Property(e => e.TotalBetamount)
                    .HasColumnName("total_betamount")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TotalNetamount)
                    .HasColumnName("total_netamount")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TotalTsamount)
                    .HasColumnName("total_tsamount")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TotalValidamount)
                    .HasColumnName("total_validamount")
                    .HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<VideoGameTransferLog>(entity =>
            {
                entity.HasIndex(e => new { e.BillNo, e.CreateTime })
                    .HasName("IVideoGameTransferLog");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.AdjMoney).HasColumnType("decimal(15, 2)");

                entity.Property(e => e.BillNo).HasMaxLength(100);

                entity.Property(e => e.ClientIp)
                    .HasColumnName("ClientIP")
                    .HasMaxLength(50);

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.Device).HasMaxLength(100);

                entity.Property(e => e.GameAccount).HasMaxLength(50);

                entity.Property(e => e.GamePwd).HasMaxLength(50);

                entity.Property(e => e.Kind).HasMaxLength(50);

                entity.Property(e => e.LoginName).HasMaxLength(50);

                entity.Property(e => e.Remark).HasMaxLength(500);

                entity.Property(e => e.Status).HasMaxLength(100);
            });

            modelBuilder.Entity<VideoGameTransferLogAsync>(entity =>
            {
                entity.ToTable("VideoGameTransferLog_Async");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Dtime)
                    .HasColumnName("dtime")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<VipMonthMoneyEveryMonthTable>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("vipMonthMoneyEveryMonthTable");

                entity.Property(e => e.AccessAfterAmount)
                    .HasColumnName("accessAfterAmount")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.AccessAmount)
                    .HasColumnName("accessAmount")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.AccessBeforeAmount)
                    .HasColumnName("accessBeforeAmount")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ApprovedTime)
                    .HasColumnName("approvedTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.BankCode)
                    .HasColumnName("bankCode")
                    .HasMaxLength(100);

                entity.Property(e => e.BeginDate)
                    .HasColumnName("beginDate")
                    .HasColumnType("date");

                entity.Property(e => e.Code)
                    .HasColumnName("code")
                    .HasMaxLength(50);

                entity.Property(e => e.CreateTime)
                    .HasColumnName("createTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.DepositWithdrawNum).HasColumnName("depositWithdrawNum");

                entity.Property(e => e.EndDate)
                    .HasColumnName("endDate")
                    .HasColumnType("date");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.InsertTime).HasColumnType("datetime");

                entity.Property(e => e.LoginName)
                    .HasColumnName("loginName")
                    .HasMaxLength(50);

                entity.Property(e => e.OpenBankAddr)
                    .HasColumnName("openBankAddr")
                    .HasMaxLength(200);

                entity.Property(e => e.OpenName)
                    .HasColumnName("openName")
                    .HasMaxLength(50);

                entity.Property(e => e.Openbank)
                    .HasColumnName("openbank")
                    .HasMaxLength(100);

                entity.Property(e => e.Remark)
                    .HasColumnName("remark")
                    .HasMaxLength(250);

                entity.Property(e => e.RemarkAdmin).HasColumnName("remarkAdmin");

                entity.Property(e => e.Source).HasMaxLength(50);

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasMaxLength(5);

                entity.Property(e => e.SubType)
                    .HasColumnName("subType")
                    .HasMaxLength(50);

                entity.Property(e => e.SubmitTime)
                    .HasColumnName("submitTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.Type)
                    .HasColumnName("type")
                    .HasMaxLength(2);

                entity.Property(e => e.VipLevel)
                    .IsRequired()
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<VipSetting>(entity =>
            {
                entity.HasKey(e => e.Name)
                    .HasName("PK__VipSetti__72E12F1AE65003B4");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(20);

                entity.Property(e => e.EveryMonthMoney).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Exp1)
                    .HasColumnName("EXP1")
                    .HasMaxLength(200);

                entity.Property(e => e.Exp2)
                    .HasColumnName("EXP2")
                    .HasMaxLength(200);

                entity.Property(e => e.Exp3)
                    .HasColumnName("EXP3")
                    .HasMaxLength(200);

                entity.Property(e => e.InsertDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Inserter)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.MonthMoneyStandard).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Sort).HasDefaultValueSql("((1))");

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Updater)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.UpgradeForMoney).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.UpgradeMoney)
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((1000))");
            });

            modelBuilder.Entity<VipSignMoney>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.InsertDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Inserter)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.RebateRate)
                    .HasColumnType("decimal(18, 4)")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Updater)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<VipinputEffectMoneyTotal>(entity =>
            {
                entity.HasKey(e => e.Loginname)
                    .HasName("PK__VIPInput__A6F8D79A6D87A088");

                entity.ToTable("VIPInputEffectMoneyTotal");

                entity.Property(e => e.Loginname)
                    .HasColumnName("loginname")
                    .HasMaxLength(50);

                entity.Property(e => e.InsertDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SourceVip)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TotalMoney).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<VipinputEffectMoneyTotalHistory>(entity =>
            {
                entity.HasKey(e => e.Loginname)
                    .HasName("PK__VIPInput__A6F8D79A006A6C3F");

                entity.ToTable("VIPInputEffectMoneyTotalHistory");

                entity.Property(e => e.Loginname)
                    .HasColumnName("loginname")
                    .HasMaxLength(30);

                entity.Property(e => e.Exption1)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Exption2)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.InsertDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.TotalMoney).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<WalletFinance>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.LastDayInCome).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.LoginName)
                    .HasColumnName("loginName")
                    .HasMaxLength(50);

                entity.Property(e => e.Money).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<WalletFinanceOptLog>(entity =>
            {
                entity.HasIndex(e => new { e.LoginName, e.Type })
                    .HasName("NonClusteredIndex-loginNameType");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.CalcAfterMoney).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CalcBeforeMoney).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.LoginName)
                    .HasColumnName("loginName")
                    .HasMaxLength(50);

                entity.Property(e => e.Money).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.OptUser).HasMaxLength(50);

                entity.Property(e => e.Type).HasMaxLength(10);
            });

            modelBuilder.Entity<Wheel>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Activity)
                    .HasColumnName("activity")
                    .IsUnicode(false);

                entity.Property(e => e.Flow)
                    .HasColumnName("flow")
                    .IsUnicode(false);

                entity.Property(e => e.IpLimit)
                    .HasColumnName("ipLimit")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IsEnabled).HasColumnName("isEnabled");

                entity.Property(e => e.IsOneDayClearLimit).HasColumnName("isOneDayClearLimit");

                entity.Property(e => e.IsOneMemberDoOne).HasColumnName("isOneMemberDoOne");

                entity.Property(e => e.MobileLimit)
                    .HasColumnName("mobileLimit")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OneDayMemberDoNumber).HasDefaultValueSql("((1))");

                entity.Property(e => e.Remark)
                    .HasColumnName("remark")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Rules)
                    .HasColumnName("rules")
                    .IsUnicode(false);

                entity.Property(e => e.RulesType)
                    .HasColumnName("rulesType")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Statement)
                    .HasColumnName("statement")
                    .IsUnicode(false);

                entity.Property(e => e.TotalLimit).HasColumnName("totalLimit");

                entity.Property(e => e.WheelImgUrl)
                    .HasColumnName("wheelImgUrl")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.WheelName)
                    .HasColumnName("wheelName")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<WheelConfig>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.BetA).HasColumnName("betA");

                entity.Property(e => e.BetB).HasColumnName("betB");

                entity.Property(e => e.CreateTime)
                    .HasColumnName("createTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.Creator)
                    .HasColumnName("creator")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DepositeA).HasColumnName("depositeA");

                entity.Property(e => e.DepositeB).HasColumnName("depositeB");

                entity.Property(e => e.LoginName)
                    .HasColumnName("loginName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Modifier)
                    .HasColumnName("modifier")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Phone)
                    .HasColumnName("phone")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TotalLimit).HasColumnName("totalLimit");

                entity.Property(e => e.UpdateTime)
                    .HasColumnName("updateTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.UseLimit).HasColumnName("useLimit");

                entity.Property(e => e.UsedLimit).HasColumnName("usedLimit");
            });

            modelBuilder.Entity<WheelPrize>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AddLimit).HasColumnName("addLimit");

                entity.Property(e => e.CreateTime)
                    .HasColumnName("createTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.Creator)
                    .HasColumnName("creator")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MaxAngle)
                    .HasColumnName("maxAngle")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.MinAngle)
                    .HasColumnName("minAngle")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Modifier)
                    .HasColumnName("modifier")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PrizeName)
                    .HasColumnName("prizeName")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Probability)
                    .HasColumnName("probability")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.UpdateTime)
                    .HasColumnName("updateTime")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<WheelPrizeRecord>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreateTime)
                    .HasColumnName("createTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.Creator)
                    .HasColumnName("creator")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LoginName)
                    .HasColumnName("loginName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Mobile)
                    .HasColumnName("mobile")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Modifier)
                    .HasColumnName("modifier")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PrizeName)
                    .HasColumnName("prizeName")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateTime)
                    .HasColumnName("updateTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.UserIp)
                    .HasColumnName("userIp")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserName)
                    .HasColumnName("userName")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<WheelReport>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.Message).HasMaxLength(200);

                entity.Property(e => e.Type).HasColumnName("type");
            });

            modelBuilder.Entity<WheelRules>(entity =>
            {
                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.Creator).HasMaxLength(50);

                entity.Property(e => e.Expression).HasMaxLength(1000);

                entity.Property(e => e.Modifier).HasMaxLength(50);

                entity.Property(e => e.MoneyLimit).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.PayType)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Remark).HasMaxLength(500);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<WheelRulesRecord>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.AccessAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Count).HasDefaultValueSql("((0))");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.Expression).HasMaxLength(100);

                entity.Property(e => e.FinanceAccessId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LoginName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.PayType)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Remark).HasMaxLength(500);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
