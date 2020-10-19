using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CoreTest.Data.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SysUser",
                columns: table => new
                {
                    id = table.Column<Guid>(nullable: false),
                    name = table.Column<string>(nullable: true),
                    loginName = table.Column<string>(nullable: true),
                    pwd = table.Column<string>(nullable: true),
                    iPplace = table.Column<string>(nullable: true),
                    addrPlace = table.Column<string>(nullable: true),
                    loginPlace = table.Column<bool>(nullable: true),
                    auth = table.Column<string>(nullable: true),
                    stauts = table.Column<string>(nullable: true),
                    menuAuthList = table.Column<string>(nullable: true),
                    funAuthList = table.Column<string>(nullable: true),
                    googleSecretKey = table.Column<string>(nullable: true),
                    enableGoogleAuth = table.Column<bool>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SysUser", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    id = table.Column<Guid>(nullable: false),
                    loginname = table.Column<string>(nullable: true),
                    pwd = table.Column<string>(nullable: true),
                    username = table.Column<string>(nullable: true),
                    registData = table.Column<DateTime>(nullable: true),
                    balance = table.Column<decimal>(nullable: true),
                    registIP = table.Column<string>(nullable: true),
                    lastLoginIP = table.Column<string>(nullable: true),
                    agent = table.Column<string>(nullable: true),
                    phone = table.Column<string>(nullable: true),
                    mailaddr = table.Column<string>(nullable: true),
                    userGroup = table.Column<string>(nullable: true),
                    status = table.Column<string>(nullable: true),
                    sex = table.Column<string>(nullable: true),
                    registaddr = table.Column<string>(nullable: true),
                    pwdAnswer = table.Column<string>(nullable: true),
                    pwdQuestion = table.Column<string>(nullable: true),
                    qq = table.Column<string>(nullable: true),
                    openBank = table.Column<string>(nullable: true),
                    bankCrad = table.Column<string>(nullable: true),
                    openBandAddr = table.Column<string>(nullable: true),
                    lastLoginData = table.Column<DateTime>(nullable: true),
                    lastLogoutData = table.Column<DateTime>(nullable: true),
                    loginCount = table.Column<int>(nullable: true),
                    remark = table.Column<string>(nullable: true),
                    isdelete = table.Column<string>(nullable: true),
                    CradPwd = table.Column<string>(nullable: true),
                    userLeve = table.Column<string>(nullable: true),
                    iPplace = table.Column<string>(nullable: true),
                    playset = table.Column<string>(nullable: true),
                    GamePwd = table.Column<string>(nullable: true),
                    game_account = table.Column<string>(nullable: true),
                    IsTuishui = table.Column<bool>(nullable: true),
                    isreportignore = table.Column<bool>(nullable: true),
                    Province = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    OpenBankSub = table.Column<string>(nullable: true),
                    weixin = table.Column<string>(nullable: true),
                    Eliminated = table.Column<bool>(nullable: true),
                    VipLevel = table.Column<string>(nullable: true),
                    depositCount = table.Column<int>(nullable: true),
                    withdrawCount = table.Column<int>(nullable: true),
                    depositSum = table.Column<decimal>(nullable: true),
                    firstDepositTime = table.Column<DateTime>(nullable: true),
                    firstDepositNum = table.Column<decimal>(nullable: true),
                    maxDepositTime = table.Column<DateTime>(nullable: true),
                    maxDepositNum = table.Column<decimal>(nullable: true),
                    withdrawSum = table.Column<decimal>(nullable: true),
                    firstWithdrawTime = table.Column<DateTime>(nullable: true),
                    firstWithdrawNum = table.Column<decimal>(nullable: true),
                    maxWithdrawTime = table.Column<DateTime>(nullable: true),
                    maxWithdrawNum = table.Column<decimal>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SysUser");

            migrationBuilder.DropTable(
                name: "User");
        }
    }
}
