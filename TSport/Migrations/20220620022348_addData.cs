using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TSport.Migrations
{
    public partial class addData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderHistories_AspNetUsers_UserId1",
                table: "OrderHistories");

            migrationBuilder.DropForeignKey(
                name: "FK_Reviews_AspNetUsers_UserId1",
                table: "Reviews");

            migrationBuilder.DropTable(
                name: "ColorProducts");

            migrationBuilder.DropIndex(
                name: "IX_Reviews_UserId1",
                table: "Reviews");

            migrationBuilder.DropIndex(
                name: "IX_OrderHistories_UserId1",
                table: "OrderHistories");

            migrationBuilder.DropColumn(
                name: "UserId1",
                table: "Reviews");

            migrationBuilder.DropColumn(
                name: "UserId1",
                table: "OrderHistories");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Colors",
                newName: "HexCode");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "Reviews",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "OrderHistories",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateTable(
                name: "ColorProduct",
                columns: table => new
                {
                    ColorsId = table.Column<int>(type: "int", nullable: false),
                    ProductsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ColorProduct", x => new { x.ColorsId, x.ProductsId });
                    table.ForeignKey(
                        name: "FK_ColorProduct_Colors_ColorsId",
                        column: x => x.ColorsId,
                        principalTable: "Colors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ColorProduct_Products_ProductsId",
                        column: x => x.ProductsId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "DisplayName", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "b74ddd14-6340-4840-95c2-db12554843e5", 0, "5a130f9a-b673-4cb0-a21f-efe0d2647964", "User", null, "admin@gmail.com", false, false, null, null, null, null, "123456", false, "ce7847ba-c96c-4513-8cf0-5575b56d66c0", false, "Admin" });

            migrationBuilder.InsertData(
                table: "Blogs",
                columns: new[] { "Id", "Author", "Content", "Tag", "TimePosted", "Title" },
                values: new object[,]
                {
                    { 16, "numberless naive ", "ten love well-made anything ten one tired two pig something body anything naive text text industrious naive naive cent industrious worried one well-made one love fix something something well-made love one cent pig text paragragh body you walk you worried you three bye industrious text text anything paragragh ten else ten pig paragragh well-made naive walk two else numberless thick you ten thick fix industrious ten something two body text walk industrious fix pin cent pig numberless cent love cent bye love love two industrious well-made fix numberless thick one tired walk cent one well-made worried hello industrious pin you ", "ten numberless fix else ", new DateTime(2022, 6, 20, 9, 23, 47, 905, DateTimeKind.Local).AddTicks(5435), "something well-made hello bye ten industrious something anything naive hello " },
                    { 15, "else naive ", "anything two love pin numberless two something thick bye industrious you bye paragragh something ten something body anything else anything well-made you numberless walk walk pig two hello bye pin else tired love walk numberless bye three you tired cent text else something one cent thick you pin industrious bye ten walk text paragragh numberless pin one something ten paragragh pin cent love hello tired hello else one two well-made ten industrious one hello well-made one well-made hello pin love tired one tired body well-made hello text worried worried pin body cent industrious something cent bye three worried cent text ", "fix three paragragh else ", new DateTime(2022, 6, 20, 9, 23, 47, 905, DateTimeKind.Local).AddTicks(5027), "you else else love cent ten worried thick else pig " },
                    { 14, "ten thick ", "something paragragh thick love else body else else pig well-made love hello worried walk love pig pig something naive text tired cent pin three numberless else tired something naive worried industrious love two worried worried bye thick two one numberless numberless hello love industrious fix something thick industrious bye two ten body you naive ten hello text one ten body two numberless naive cent worried body love pin numberless naive anything text industrious well-made something anything naive anything tired fix pig pig industrious text naive worried anything pig thick else three three ten one hello body worried else anything fix ", "numberless cent else industrious ", new DateTime(2022, 6, 20, 9, 23, 47, 905, DateTimeKind.Local).AddTicks(4720), "industrious bye naive tired you industrious two well-made numberless walk " },
                    { 13, "numberless text ", "walk numberless naive text well-made tired numberless paragragh three fix pin text walk worried one industrious else well-made two ten one well-made walk love worried three something numberless something thick tired cent pin bye walk numberless cent text industrious industrious ten tired walk hello pin paragragh tired industrious text pig well-made well-made pin pig bye anything three hello two fix paragragh pin worried hello pin three text else anything bye anything anything worried bye body worried numberless paragragh love thick tired one thick thick industrious cent cent text pin well-made walk text industrious something thick ten pig paragragh fix walk ", "cent cent naive pig ", new DateTime(2022, 6, 20, 9, 23, 47, 905, DateTimeKind.Local).AddTicks(4411), "fix two well-made well-made tired you hello something industrious industrious " },
                    { 12, "bye love ", "tired love ten text paragragh fix numberless something pin worried bye body else three fix thick thick else well-made one anything tired love else anything body else bye fix paragragh three three text well-made numberless naive pin one love tired body pig paragragh paragragh numberless three pig anything walk pig three well-made fix three you pin pin industrious paragragh ten ten one walk well-made pig else pig tired ten worried thick three three three two else something industrious something worried else text naive worried you one tired love naive pin pig you ten industrious something fix industrious bye fix thick ", "cent numberless anything pin ", new DateTime(2022, 6, 20, 9, 23, 47, 905, DateTimeKind.Local).AddTicks(4066), "ten anything ten something else walk anything else thick love " },
                    { 11, "love numberless ", "love cent love else love tired one worried three numberless pig hello else paragragh three body well-made worried text thick fix pin naive two you love two anything bye ten two something one fix body three numberless well-made numberless you numberless ten three text pig ten well-made text ten ten one love text industrious pig love love well-made paragragh body ten two two pin fix something anything walk paragragh body you body numberless ten naive something cent something naive industrious two you cent text well-made paragragh you hello cent worried body ten hello numberless worried hello walk three well-made something ", "anything ten love one ", new DateTime(2022, 6, 20, 9, 23, 47, 905, DateTimeKind.Local).AddTicks(3748), "pig anything fix two paragragh three body fix hello paragragh " },
                    { 10, "pig two ", "fix anything something cent industrious love well-made else industrious you naive bye numberless naive body walk three pin walk body industrious three anything something paragragh something text text fix industrious pin else industrious body you two two hello hello naive tired well-made anything ten two paragragh else naive numberless thick anything three three pin fix something body pin tired fix worried one well-made pin love else fix industrious tired tired something thick one you two three love cent pin body body tired else numberless cent cent three numberless one pig two two numberless numberless walk love pin you you you ", "anything something paragragh one ", new DateTime(2022, 6, 20, 9, 23, 47, 905, DateTimeKind.Local).AddTicks(3386), "pig paragragh something numberless one ten love numberless pin bye " },
                    { 1, "body industrious ", "else bye thick love love else pig three paragragh numberless numberless cent bye two one three anything fix cent bye ten naive worried else something pig body pin you three pig anything tired two cent bye bye fix naive pig paragragh bye pig bye paragragh paragragh body worried well-made hello walk you industrious walk bye naive thick else well-made two else pig anything anything ten worried paragragh you fix pin pig hello worried you ten well-made numberless something you love pig love ten tired two thick love walk numberless love cent three cent text two fix two thick text something ", "else walk cent text ", new DateTime(2022, 6, 20, 9, 23, 47, 904, DateTimeKind.Local).AddTicks(2049), "you hello paragragh ten pig worried naive well-made paragragh pig " },
                    { 8, "naive three ", "you hello well-made fix body anything thick pig worried pin hello worried pin two walk paragragh naive fix ten worried naive fix bye body one worried fix two fix numberless something walk three love walk text hello bye cent body two bye else three anything something anything worried something walk industrious one love three you fix anything pig love three hello ten three industrious thick pig pig worried tired bye pig three well-made three bye ten paragragh text pin anything cent naive anything well-made anything industrious naive pin body paragragh ten cent something thick hello three text one fix else ", "text worried anything well-made ", new DateTime(2022, 6, 20, 9, 23, 47, 905, DateTimeKind.Local).AddTicks(2729), "paragragh body paragragh love anything fix body else anything well-made " },
                    { 7, "you body ", "naive three tired worried you numberless you else you paragragh pig paragragh hello one love love else paragragh else anything fix you numberless three paragragh love else paragragh love walk body walk two else love well-made walk pig three bye well-made pin tired paragragh walk numberless ten bye hello hello three else worried tired well-made fix paragragh two tired numberless tired cent three else ten numberless worried ten text something something tired you worried else tired hello naive two text industrious cent pig thick tired naive industrious walk fix tired hello something you ten worried industrious cent paragragh body worried ", "three three three fix ", new DateTime(2022, 6, 20, 9, 23, 47, 905, DateTimeKind.Local).AddTicks(2408), "ten well-made numberless naive naive bye tired ten naive else " },
                    { 6, "two cent ", "one love cent text text hello else bye love text pig thick naive three body fix thick industrious pin hello pig ten well-made pig else well-made else worried cent worried pin well-made one naive body thick pig numberless tired cent paragragh tired naive worried ten tired cent one anything something three hello industrious three well-made ten something you numberless fix ten bye thick text else numberless ten body love something worried pig text love paragragh you fix worried hello well-made industrious worried walk one naive bye worried paragragh industrious cent text tired pin anything thick walk numberless two fix paragragh ", "text pig hello bye ", new DateTime(2022, 6, 20, 9, 23, 47, 905, DateTimeKind.Local).AddTicks(2093), "paragragh hello tired you numberless walk two worried naive bye " },
                    { 5, "something tired ", "anything hello one something walk bye body walk one two ten thick three anything you ten ten naive else hello thick anything worried paragragh love body three tired well-made numberless fix thick three worried walk text fix worried industrious one industrious cent pin anything one walk industrious something tired cent text body two paragragh industrious body thick ten ten walk text one anything bye cent fix one else paragragh walk naive something well-made worried thick walk anything cent walk else you cent body industrious naive fix paragragh numberless pin walk naive something thick love three one walk hello ten industrious ", "you walk three numberless ", new DateTime(2022, 6, 20, 9, 23, 47, 905, DateTimeKind.Local).AddTicks(1769), "one you one naive anything hello naive pig walk fix " },
                    { 4, "numberless industrious ", "cent hello body paragragh worried something something paragragh two hello well-made anything anything naive else industrious worried well-made worried something hello fix tired pin text thick fix cent two anything tired cent pin walk you two text else three paragragh one thick else three tired anything ten paragragh else you three body pig something fix text numberless anything pin ten cent fix cent else numberless industrious you text tired industrious thick fix fix thick industrious worried ten one something paragragh one text bye else worried fix love thick paragragh walk bye paragragh something numberless one worried walk body ten pig ", "thick one one thick ", new DateTime(2022, 6, 20, 9, 23, 47, 905, DateTimeKind.Local).AddTicks(1417), "you text numberless thick body anything well-made tired pig anything " },
                    { 3, "thick cent ", "love three three three naive else tired fix paragragh numberless industrious industrious paragragh text love pig well-made paragragh ten thick body industrious pig thick body cent industrious bye walk industrious paragragh you body two thick thick worried fix hello text body well-made naive paragragh cent hello naive hello paragragh hello fix worried three fix industrious paragragh bye fix love worried one you walk something naive walk worried worried thick hello worried three well-made industrious tired paragragh ten one walk hello three something paragragh paragragh something two numberless bye bye two love else one naive worried industrious numberless text tired anything ", "worried pig naive something ", new DateTime(2022, 6, 20, 9, 23, 47, 905, DateTimeKind.Local).AddTicks(1088), "two industrious cent something paragragh text love two three industrious " },
                    { 2, "tired tired ", "bye bye naive tired well-made one three one love hello naive tired pig naive something text you pig love cent cent one well-made you two else ten ten something fix numberless paragragh tired ten anything industrious pin naive thick fix well-made worried thick text thick thick you industrious something bye three hello bye worried else anything well-made tired three two paragragh pin anything tired tired one body bye tired one else two you fix anything numberless walk one bye walk paragragh else cent worried two one well-made pig worried body three something hello ten else walk cent anything pig ten ", "else numberless three well-made ", new DateTime(2022, 6, 20, 9, 23, 47, 905, DateTimeKind.Local).AddTicks(712), "ten walk fix pig well-made paragragh ten tired pig three " },
                    { 9, "cent something ", "three two cent pig anything well-made cent something text industrious walk you thick else industrious walk well-made thick something naive two three naive else ten pig else love industrious one you text else naive body worried tired cent paragragh numberless else industrious tired three numberless tired else something pin hello body you pig naive one body well-made hello hello something one pig one cent cent hello walk pin else body ten numberless something one else bye fix hello two tired something numberless love something one pin tired thick paragragh body love you text industrious hello thick bye walk something one ", "anything numberless else anything ", new DateTime(2022, 6, 20, 9, 23, 47, 905, DateTimeKind.Local).AddTicks(3043), "pig pin naive industrious else well-made well-made anything else cent " }
                });

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 5, "Xlowete" },
                    { 4, "Percifco" },
                    { 3, "Mate in TW" },
                    { 2, "Beautifullis" },
                    { 1, "Lakmetao" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 7, "Genuine leather" },
                    { 6, "Funiture" },
                    { 5, "Frame sunglasses" },
                    { 3, "Covid-19" },
                    { 2, "Computer" },
                    { 1, "Shoes" },
                    { 4, "Electronics" }
                });

            migrationBuilder.InsertData(
                table: "Colors",
                columns: new[] { "Id", "HexCode" },
                values: new object[,]
                {
                    { 2, "#505050" },
                    { 3, "#73707A" },
                    { 4, "#C7BB9B" },
                    { 1, "#586882" }
                });

            migrationBuilder.InsertData(
                table: "Sizes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 5, "XXL" },
                    { 1, "S" },
                    { 2, "M" },
                    { 3, "L" },
                    { 4, "XL" }
                });

            migrationBuilder.InsertData(
                table: "OrderHistories",
                columns: new[] { "Id", "CouponCode", "ReceiverPhone", "TimeCreated", "ToLocation", "UserId" },
                values: new object[,]
                {
                    { 5, "7In4cm", "1234567890", new DateTime(2022, 6, 20, 9, 23, 47, 907, DateTimeKind.Local).AddTicks(5109), "two anything numberless thick two else cent one love industrious ", "b74ddd14-6340-4840-95c2-db12554843e5" },
                    { 1, "1rEDJb", "1234567890", new DateTime(2022, 6, 20, 9, 23, 47, 907, DateTimeKind.Local).AddTicks(4813), "three you three pin you ten naive three thick two ", "b74ddd14-6340-4840-95c2-db12554843e5" },
                    { 4, "idFXtc", "1234567890", new DateTime(2022, 6, 20, 9, 23, 47, 907, DateTimeKind.Local).AddTicks(5100), "paragragh body you body well-made walk pig you ten something ", "b74ddd14-6340-4840-95c2-db12554843e5" },
                    { 3, "IZXt8T", "1234567890", new DateTime(2022, 6, 20, 9, 23, 47, 907, DateTimeKind.Local).AddTicks(5090), "thick anything thick well-made text walk walk text ten cent ", "b74ddd14-6340-4840-95c2-db12554843e5" },
                    { 2, "PaU953", "1234567890", new DateTime(2022, 6, 20, 9, 23, 47, 907, DateTimeKind.Local).AddTicks(5078), "ten numberless three anything worried anything industrious cent numberless ten ", "b74ddd14-6340-4840-95c2-db12554843e5" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BrandId", "CategoryId", "Code", "Description", "InStock", "Name", "Overeview", "Price", "SalesOff", "Total", "UserId" },
                values: new object[,]
                {
                    { 27, 2, 5, "uGPBCR", "two something body text hello hello two naive tired worried industrious tired industrious pin ten cent well-made thick industrious walk pin two else two walk anything pin numberless fix tired else something three something naive love numberless ten else bye text something numberless worried pin bye cent pin walk else ", 1706, "industrious pig one well-made ", "bye numberless hello cent body pig body fix well-made worried you pig pin pin love text something anything fix paragragh ", 440f, 3, 635, null },
                    { 23, 2, 5, "FSZBEf", "bye two pin well-made body industrious well-made you bye love you one naive naive industrious pig paragragh numberless naive love bye bye worried fix cent anything hello thick hello worried bye thick three tired tired walk pin paragragh pin you pig else ten else paragragh one worried well-made two paragragh ", 836, "naive you industrious walk ", "ten numberless pin body body bye one naive bye something worried hello one else numberless cent thick paragragh tired body ", 410f, 8, 715, null },
                    { 18, 4, 5, "pxUDfb", "pin love you pin cent love thick well-made tired well-made else text pig pin anything you pig hello thick three anything tired industrious tired you love numberless cent pig cent cent well-made fix ten anything cent text well-made anything bye one tired something paragragh one cent walk anything tired well-made ", 1299, "tired three pig two ", "numberless two well-made industrious tired you else numberless pin well-made you hello body thick worried well-made something pin cent body ", 950f, 4, 407, null },
                    { 17, 2, 5, "VRQXby", "pin love pin three numberless cent numberless pin bye thick tired pin worried numberless two pig paragragh naive love industrious walk walk one anything naive something ten well-made paragragh anything one hello body one three hello you love else three industrious anything pig numberless body body hello bye two paragragh ", 937, "fix hello three cent ", "thick anything else paragragh body cent body three fix tired body something two walk numberless bye you naive cent love ", 750f, 1, 1206, null },
                    { 9, 4, 4, "o8bEFd", "three worried tired two body cent you anything else tired cent numberless industrious paragragh love one text worried well-made fix walk well-made numberless two three body pin walk anything cent pig pig cent worried three you body anything walk three well-made bye numberless fix you worried thick naive body anything ", 960, "ten fix pin two ", "numberless thick bye cent body cent hello paragragh three numberless cent fix numberless love bye something cent text tired two ", 920f, 14, 190, null },
                    { 10, 1, 5, "YjGwv9", "three walk paragragh well-made ten walk cent walk else two hello one naive pin well-made tired tired pin thick worried worried numberless ten text tired hello numberless numberless naive hello fix pin well-made you pin something walk else cent thick something text ten one walk something pig else fix well-made ", 1219, "cent else pin bye ", "love anything you body two ten you fix cent text cent two text text something else well-made body well-made walk ", 260f, 1, 495, null },
                    { 5, 4, 5, "1nB2hJ", "fix three anything numberless cent three text bye love tired pin two else you two thick tired anything something walk three fix tired ten one anything you numberless naive two numberless bye one else tired you love walk body love cent else one something numberless bye tired numberless love hello ", 860, "walk bye two text ", "text ten pig cent text love cent fix pin industrious industrious numberless body hello three two fix numberless cent industrious ", 220f, 14, 1059, null },
                    { 1, 4, 5, "K8WmGr", "worried worried pin naive one cent one well-made numberless body well-made numberless ten something love love text worried cent worried pig ten numberless naive pig tired paragragh anything thick text three bye something fix three anything worried naive anything pig bye pin pin industrious two something worried walk pig hello ", 1856, "numberless else something tired ", "numberless cent else hello hello numberless pig numberless numberless love text anything love cent naive thick love industrious ten thick ", 630f, 10, 1460, null },
                    { 29, 2, 4, "xd4jxf", "body numberless pig well-made numberless body two hello one text walk love you body fix well-made walk ten you ten pig pin walk paragragh else one three ten body industrious fix something you naive else anything naive two you cent pig ten two numberless three anything tired ten two pig ", 1638, "love hello thick something ", "pin two three anything cent you pig cent paragragh pin three naive paragragh pin one ten pin text paragragh worried ", 570f, 14, 553, null },
                    { 22, 4, 4, "Xd6R0d", "walk two three something you well-made naive cent body fix naive pin cent one tired industrious love body cent pig else you cent three one tired anything tired numberless paragragh numberless thick walk worried one tired industrious naive tired three paragragh pin ten text well-made you thick ten numberless naive ", 1685, "body industrious thick cent ", "body anything body naive industrious industrious cent paragragh worried one you one naive fix tired walk numberless body anything paragragh ", 380f, 9, 238, null },
                    { 21, 4, 4, "kBm72G", "one one anything something you numberless hello two fix hello two love worried industrious walk something well-made three paragragh something well-made numberless two else ten fix numberless thick well-made pig two love love walk worried love bye cent something body bye else cent numberless naive thick pin three naive well-made ", 1319, "you well-made well-made three ", "tired hello ten one pin body pig something bye anything walk cent you bye love two else tired anything something ", 370f, 4, 1702, null },
                    { 15, 3, 5, "kiouaC", "love pin something walk ten industrious love love anything walk three two hello cent love you pin paragragh text else fix hello walk hello numberless well-made paragragh ten body love three pig ten numberless pin anything bye else bye anything two text pig else pig you you three paragragh cent ", 1764, "hello fix you ten ", "body cent love pig numberless hello one walk love industrious bye tired pin something numberless two two two body something ", 610f, 4, 1734, null },
                    { 4, 2, 4, "sCv9CI", "pin bye something naive cent hello industrious body body three walk anything two pin thick tired worried three bye anything text thick hello paragragh ten pin pig two tired well-made industrious naive walk ten text cent text well-made else industrious you two pig fix paragragh naive cent else worried naive ", 1821, "hello you ten two ", "text naive two three one pin two well-made well-made body well-made paragragh text hello paragragh walk three fix thick one ", 90f, 6, 1967, null },
                    { 30, 2, 3, "07zfje", "three anything hello text worried three pin tired pin hello pig industrious three pig pin three hello industrious thick anything naive industrious fix naive bye else one love naive worried something three body pin text pin worried one thick industrious two bye text pin walk naive thick else text thick ", 672, "cent three bye hello ", "anything two pig hello you something you text bye bye tired cent anything text cent numberless cent text bye walk ", 560f, 8, 262, null },
                    { 7, 1, 1, "AbsNWv", "hello two paragragh anything text fix else hello bye well-made pin numberless fix bye walk you anything bye hello text cent else text something something thick text love bye anything pig text you text else three ten walk naive pig three tired else thick thick paragragh anything body pig naive ", 1932, "well-made walk cent ten ", "tired bye cent numberless text bye love cent two thick three thick hello hello well-made naive you fix love thick ", 390f, 2, 875, null },
                    { 12, 1, 1, "2xkIt6", "text well-made numberless well-made bye fix pin bye tired walk naive well-made you one pin naive industrious walk pin paragragh bye numberless cent one anything body industrious love bye love numberless you tired hello naive tired fix fix else three anything three two thick pin something text bye love worried ", 1635, "something paragragh text hello ", "something hello else walk pig anything naive pin one naive love two numberless love fix paragragh else three numberless two ", 680f, 4, 966, null },
                    { 8, 4, 2, "Nx0HUW", "paragragh paragragh hello love anything something you body one pin tired industrious tired numberless two walk worried you walk else well-made ten pig fix ten hello love fix anything body well-made ten pin numberless one tired walk body fix hello three cent something love thick anything anything walk pig walk ", 1943, "text three body two ", "cent text love tired worried text cent cent love ten pin thick pig love tired paragragh one cent one you ", 590f, 13, 1362, null },
                    { 14, 3, 2, "pakBbC", "fix well-made three anything worried anything industrious well-made you thick hello numberless tired something paragragh you paragragh hello two bye ten love two industrious bye industrious hello something thick worried something one industrious well-made ten fix love pig you tired something text thick cent industrious love numberless love numberless ten ", 1398, "numberless worried love something ", "else else walk numberless thick paragragh anything pig one one anything hello bye ten else you hello pig one tired ", 150f, 0, 113, null },
                    { 6, 2, 3, "R8aJgM", "industrious two thick fix fix text text ten you bye hello pig naive one hello thick one worried body numberless one else you worried industrious else fix hello something worried fix naive you ten tired fix something numberless well-made ten fix cent love bye something two fix worried one walk ", 1738, "anything something cent pig ", "pin pin hello text bye cent anything paragragh numberless worried love paragragh text numberless one three walk three thick one ", 250f, 4, 200, null },
                    { 11, 1, 3, "FwbC0T", "tired cent three well-made cent cent three three well-made one three two tired paragragh naive you else ten numberless bye naive something two else bye well-made bye industrious worried paragragh fix ten anything anything numberless worried two paragragh fix numberless anything pin paragragh body two else ten ten fix pig ", 107, "worried industrious love cent ", "pig tired body something walk paragragh love body bye fix well-made walk bye paragragh cent thick something industrious walk walk ", 690f, 10, 1709, null },
                    { 2, 1, 4, "EVFsDH", "two anything tired hello love tired pig three you anything worried something anything love walk ten fix thick text well-made bye numberless numberless ten one worried body tired three love anything body pig pin worried hello body pig numberless naive industrious thick pin else worried worried body love tired bye ", 350, "tired two love thick ", "fix thick ten you paragragh thick walk you two pig ten anything text something pig one else you industrious industrious ", 120f, 12, 618, null },
                    { 13, 1, 3, "FpFdTh", "numberless industrious tired else naive anything worried worried fix ten three numberless walk two ten naive pig well-made walk numberless anything something bye tired walk pig you pin well-made three worried two thick bye thick paragragh body one pig anything hello thick text pin love tired two body bye anything ", 333, "thick worried pin one ", "three tired walk two you something bye cent three else fix three one naive pig one pin tired cent something ", 260f, 2, 1536, null },
                    { 19, 1, 3, "DlweFT", "two industrious paragragh naive tired walk cent something text thick hello thick else worried anything text three else numberless anything something ten pin one three fix else thick else else fix you numberless numberless ten worried paragragh ten thick body love you worried you numberless tired else else ten anything ", 1970, "ten walk anything well-made ", "well-made hello industrious paragragh cent pin bye three pig bye ten naive three text else worried paragragh numberless walk pin ", 300f, 3, 249, null },
                    { 20, 4, 3, "YxELe6", "you ten something pin numberless two pig fix tired numberless anything numberless pin hello numberless pin naive pin pin well-made ten you cent else worried body else numberless cent two walk well-made else bye else bye body naive text thick text love else pin ten two industrious numberless thick paragragh ", 1409, "one ten body numberless ", "naive something naive ten anything pin pig industrious industrious text else industrious bye fix ten body two text thick thick ", 640f, 1, 1172, null },
                    { 24, 2, 3, "cAdkDD", "anything pig anything tired paragragh fix text anything pig tired walk fix naive walk ten walk naive text fix tired pig body body something pig pin you fix well-made thick numberless text something worried two fix body bye cent love pig industrious worried cent something pig worried hello three one ", 554, "two love fix thick ", "paragragh anything you you pig body numberless tired one love text fix text something ten well-made ten text paragragh walk ", 890f, 4, 299, null },
                    { 25, 2, 3, "56TTGt", "fix naive walk something worried else tired fix naive pin fix walk three industrious hello anything love hello thick numberless one else cent paragragh industrious bye naive industrious love worried else body fix thick industrious bye body body walk one fix industrious pig worried paragragh else anything you bye you ", 683, "one pig else you ", "three cent something naive walk three bye two worried cent love ten body pin love tired two text hello body ", 540f, 6, 302, null },
                    { 26, 2, 3, "YtIbil", "something pin body thick thick bye fix two cent worried bye industrious three pig you hello you one you else three bye ten anything naive industrious fix worried pin anything paragragh something one paragragh three paragragh hello something two hello tired else something hello you naive well-made paragragh bye industrious ", 55, "thick pig one cent ", "paragragh hello body body body love pig three something fix tired numberless pin tired one tired one anything two one ", 510f, 14, 1984, null },
                    { 28, 2, 3, "sA7Yeh", "ten two you pig anything else pig worried industrious cent ten numberless else one anything text pig pig two anything two pig text thick hello tired three ten paragragh fix text worried numberless numberless text body one tired body fix walk one hello thick two fix love pin paragragh numberless ", 333, "fix one love body ", "one hello text anything industrious hello else one bye thick bye one one text ten pin three paragragh anything tired ", 700f, 14, 1180, null },
                    { 16, 2, 3, "MYzJKg", "tired hello love something industrious tired hello body two bye three walk pig ten industrious bye else three ten pig something worried walk hello walk pig anything pin cent fix numberless pin three thick industrious naive one bye three body love well-made cent two love body well-made fix industrious three ", 64, "thick industrious love numberless ", "three tired worried anything thick naive walk paragragh industrious text walk one walk cent thick you pin three well-made body ", 250f, 14, 474, null },
                    { 3, 4, 1, "ki2k5s", "ten fix fix one two thick tired naive you walk tired body else anything paragragh numberless cent text else body anything paragragh else fix bye hello you hello one naive love else pig naive thick anything hello worried industrious fix paragragh body bye anything paragragh numberless paragragh text else industrious ", 1279, "fix love body pin ", "thick anything text text three worried naive tired cent worried pin tired else fix cent industrious pin naive paragragh else ", 950f, 11, 666, null }
                });

            migrationBuilder.InsertData(
                table: "ColorProduct",
                columns: new[] { "ColorsId", "ProductsId" },
                values: new object[,]
                {
                    { 1, 3 },
                    { 4, 28 },
                    { 1, 30 },
                    { 2, 30 },
                    { 3, 30 },
                    { 4, 30 },
                    { 1, 2 },
                    { 2, 2 },
                    { 3, 2 },
                    { 4, 2 },
                    { 1, 4 },
                    { 2, 4 },
                    { 3, 4 },
                    { 1, 9 },
                    { 2, 9 },
                    { 3, 9 },
                    { 4, 9 },
                    { 1, 21 },
                    { 3, 28 },
                    { 2, 21 },
                    { 2, 28 },
                    { 4, 26 },
                    { 3, 19 },
                    { 4, 19 },
                    { 1, 20 },
                    { 2, 20 },
                    { 3, 20 },
                    { 4, 20 },
                    { 1, 24 },
                    { 2, 24 },
                    { 3, 24 },
                    { 4, 24 },
                    { 1, 25 },
                    { 2, 25 },
                    { 3, 25 },
                    { 4, 25 },
                    { 1, 26 },
                    { 2, 26 },
                    { 3, 26 },
                    { 1, 28 },
                    { 3, 21 },
                    { 4, 21 }
                });

            migrationBuilder.InsertData(
                table: "ColorProduct",
                columns: new[] { "ColorsId", "ProductsId" },
                values: new object[,]
                {
                    { 1, 22 },
                    { 4, 15 },
                    { 1, 17 },
                    { 2, 17 },
                    { 3, 17 },
                    { 4, 17 },
                    { 1, 18 },
                    { 2, 18 },
                    { 3, 18 },
                    { 4, 18 },
                    { 1, 23 },
                    { 2, 23 },
                    { 3, 23 },
                    { 4, 23 },
                    { 1, 27 },
                    { 2, 27 },
                    { 3, 27 },
                    { 4, 27 },
                    { 3, 15 },
                    { 2, 15 },
                    { 1, 15 },
                    { 4, 10 },
                    { 2, 22 },
                    { 3, 22 },
                    { 4, 22 },
                    { 1, 29 },
                    { 2, 29 },
                    { 3, 29 },
                    { 4, 29 },
                    { 1, 1 },
                    { 2, 19 },
                    { 2, 1 },
                    { 4, 1 },
                    { 1, 5 },
                    { 2, 5 },
                    { 3, 5 },
                    { 4, 5 },
                    { 1, 10 },
                    { 2, 10 },
                    { 3, 10 },
                    { 3, 1 },
                    { 1, 19 }
                });

            migrationBuilder.InsertData(
                table: "ColorProduct",
                columns: new[] { "ColorsId", "ProductsId" },
                values: new object[,]
                {
                    { 4, 4 },
                    { 3, 8 },
                    { 4, 6 },
                    { 2, 7 },
                    { 1, 7 },
                    { 2, 8 },
                    { 1, 11 },
                    { 2, 11 },
                    { 2, 6 },
                    { 3, 11 },
                    { 4, 11 },
                    { 3, 3 },
                    { 2, 3 },
                    { 4, 13 },
                    { 3, 13 },
                    { 2, 13 },
                    { 4, 3 },
                    { 3, 7 },
                    { 3, 6 },
                    { 3, 12 },
                    { 1, 8 },
                    { 4, 8 },
                    { 1, 14 },
                    { 2, 14 },
                    { 4, 12 },
                    { 4, 7 },
                    { 2, 12 },
                    { 3, 14 },
                    { 1, 13 },
                    { 1, 12 },
                    { 1, 6 },
                    { 4, 16 },
                    { 3, 16 },
                    { 2, 16 },
                    { 1, 16 },
                    { 4, 14 }
                });

            migrationBuilder.InsertData(
                table: "OHProducts",
                columns: new[] { "Id", "OrderHistoryId", "ProductId", "Quantity" },
                values: new object[,]
                {
                    { 11, 1, 15, 13 },
                    { 1, 1, 16, 17 },
                    { 2, 1, 23, 8 },
                    { 6, 1, 11, 9 },
                    { 10, 1, 27, 4 },
                    { 30, 4, 17, 18 }
                });

            migrationBuilder.InsertData(
                table: "OHProducts",
                columns: new[] { "Id", "OrderHistoryId", "ProductId", "Quantity" },
                values: new object[,]
                {
                    { 37, 4, 15, 17 },
                    { 13, 1, 25, 3 },
                    { 24, 2, 2, 10 },
                    { 25, 2, 16, 1 },
                    { 34, 2, 21, 8 },
                    { 35, 2, 25, 17 },
                    { 36, 2, 25, 12 },
                    { 12, 1, 14, 7 },
                    { 4, 3, 11, 15 },
                    { 7, 3, 20, 2 },
                    { 5, 2, 17, 12 },
                    { 8, 3, 11, 7 },
                    { 20, 3, 5, 8 },
                    { 32, 3, 9, 10 },
                    { 39, 3, 17, 4 },
                    { 40, 3, 1, 17 },
                    { 9, 4, 11, 12 },
                    { 15, 4, 16, 7 },
                    { 16, 4, 16, 8 },
                    { 21, 4, 5, 15 },
                    { 19, 3, 16, 3 },
                    { 3, 2, 21, 8 },
                    { 38, 2, 15, 19 },
                    { 33, 1, 23, 16 },
                    { 26, 1, 20, 16 },
                    { 27, 1, 6, 16 },
                    { 28, 1, 29, 1 },
                    { 22, 1, 22, 17 },
                    { 18, 1, 4, 18 },
                    { 29, 1, 25, 8 },
                    { 31, 1, 18, 14 },
                    { 23, 1, 5, 3 },
                    { 14, 1, 19, 19 },
                    { 17, 1, 27, 19 }
                });

            migrationBuilder.InsertData(
                table: "ProductSize",
                columns: new[] { "ProductsId", "SizesId" },
                values: new object[,]
                {
                    { 12, 4 },
                    { 27, 1 },
                    { 27, 2 },
                    { 10, 3 },
                    { 10, 2 },
                    { 10, 1 },
                    { 27, 3 },
                    { 27, 4 }
                });

            migrationBuilder.InsertData(
                table: "ProductSize",
                columns: new[] { "ProductsId", "SizesId" },
                values: new object[,]
                {
                    { 27, 5 },
                    { 12, 1 },
                    { 1, 1 },
                    { 1, 2 },
                    { 1, 3 },
                    { 5, 5 },
                    { 10, 4 },
                    { 5, 3 },
                    { 5, 2 },
                    { 5, 1 },
                    { 12, 2 },
                    { 12, 3 },
                    { 1, 4 },
                    { 1, 5 },
                    { 12, 5 },
                    { 5, 4 },
                    { 7, 4 },
                    { 7, 5 },
                    { 3, 2 },
                    { 3, 3 },
                    { 3, 4 },
                    { 3, 5 },
                    { 18, 5 },
                    { 18, 4 },
                    { 18, 3 },
                    { 18, 2 },
                    { 18, 1 },
                    { 17, 5 },
                    { 17, 4 },
                    { 17, 3 },
                    { 23, 3 },
                    { 23, 4 },
                    { 23, 5 },
                    { 3, 1 },
                    { 17, 2 },
                    { 17, 1 },
                    { 7, 1 },
                    { 7, 2 },
                    { 15, 5 },
                    { 15, 4 },
                    { 15, 3 },
                    { 15, 2 }
                });

            migrationBuilder.InsertData(
                table: "ProductSize",
                columns: new[] { "ProductsId", "SizesId" },
                values: new object[,]
                {
                    { 15, 1 },
                    { 7, 3 },
                    { 23, 2 },
                    { 10, 5 },
                    { 23, 1 },
                    { 29, 1 },
                    { 29, 4 },
                    { 11, 5 },
                    { 11, 4 },
                    { 26, 1 },
                    { 26, 2 },
                    { 26, 3 },
                    { 26, 4 },
                    { 26, 5 },
                    { 11, 3 },
                    { 11, 2 },
                    { 11, 1 },
                    { 28, 1 },
                    { 25, 5 },
                    { 28, 2 },
                    { 28, 4 },
                    { 28, 5 },
                    { 6, 5 },
                    { 30, 1 },
                    { 30, 2 },
                    { 30, 3 },
                    { 30, 4 },
                    { 30, 5 },
                    { 6, 4 },
                    { 29, 5 },
                    { 6, 2 },
                    { 28, 3 },
                    { 25, 4 },
                    { 25, 3 },
                    { 25, 2 },
                    { 16, 4 },
                    { 16, 3 },
                    { 16, 2 },
                    { 16, 1 },
                    { 19, 1 },
                    { 19, 2 },
                    { 19, 3 }
                });

            migrationBuilder.InsertData(
                table: "ProductSize",
                columns: new[] { "ProductsId", "SizesId" },
                values: new object[,]
                {
                    { 19, 4 },
                    { 19, 5 },
                    { 20, 1 },
                    { 20, 2 },
                    { 20, 3 },
                    { 20, 4 },
                    { 20, 5 },
                    { 13, 5 },
                    { 13, 4 },
                    { 13, 3 },
                    { 13, 2 },
                    { 24, 1 },
                    { 24, 2 },
                    { 24, 3 },
                    { 24, 4 },
                    { 24, 5 },
                    { 13, 1 },
                    { 25, 1 },
                    { 6, 1 },
                    { 2, 1 },
                    { 6, 3 },
                    { 21, 1 },
                    { 22, 3 },
                    { 9, 3 },
                    { 9, 4 },
                    { 9, 5 },
                    { 14, 2 },
                    { 14, 1 },
                    { 21, 2 },
                    { 9, 1 },
                    { 21, 3 },
                    { 21, 5 },
                    { 8, 3 },
                    { 22, 5 },
                    { 8, 5 },
                    { 8, 4 },
                    { 22, 1 },
                    { 22, 2 },
                    { 21, 4 },
                    { 14, 3 },
                    { 9, 2 },
                    { 4, 1 }
                });

            migrationBuilder.InsertData(
                table: "ProductSize",
                columns: new[] { "ProductsId", "SizesId" },
                values: new object[,]
                {
                    { 2, 2 },
                    { 2, 3 },
                    { 29, 3 },
                    { 2, 4 },
                    { 2, 5 },
                    { 29, 2 },
                    { 14, 4 },
                    { 4, 2 },
                    { 22, 4 },
                    { 4, 4 },
                    { 4, 5 },
                    { 16, 5 },
                    { 8, 1 },
                    { 8, 2 },
                    { 14, 5 },
                    { 4, 3 }
                });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "Comment", "ProductId", "Rate", "TimePosted", "UserId" },
                values: new object[,]
                {
                    { 24, "walk walk worried something anything love cent fix cent cent you two numberless anything worried else you thick something body well-made well-made hello industrious pig naive industrious two paragragh pin ", 19, 1, new DateTime(2022, 6, 20, 9, 23, 47, 912, DateTimeKind.Local).AddTicks(905), "b74ddd14-6340-4840-95c2-db12554843e5" },
                    { 15, "paragragh you two three cent hello worried love industrious text pin industrious pin one worried fix body cent ten thick one something one walk bye paragragh industrious one love pin ", 1, 4, new DateTime(2022, 6, 20, 9, 23, 47, 912, DateTimeKind.Local).AddTicks(508), "b74ddd14-6340-4840-95c2-db12554843e5" },
                    { 14, "walk naive bye else bye one bye worried fix well-made numberless numberless thick numberless numberless pin text something else walk worried pin ten paragragh two body text bye worried two ", 1, 3, new DateTime(2022, 6, 20, 9, 23, 47, 912, DateTimeKind.Local).AddTicks(460), "b74ddd14-6340-4840-95c2-db12554843e5" },
                    { 16, "walk numberless pig fix fix walk three well-made bye ten worried tired body text paragragh pin three well-made one body ten else tired worried thick tired naive fix thick one ", 1, 4, new DateTime(2022, 6, 20, 9, 23, 47, 912, DateTimeKind.Local).AddTicks(554), "b74ddd14-6340-4840-95c2-db12554843e5" },
                    { 20, "pin text two body one walk three ten bye walk you well-made worried anything well-made pig something well-made two paragragh worried thick anything industrious text text anything naive else fix ", 22, 2, new DateTime(2022, 6, 20, 9, 23, 47, 912, DateTimeKind.Local).AddTicks(724), "b74ddd14-6340-4840-95c2-db12554843e5" },
                    { 6, "pin bye ten three ten one text numberless well-made one pig tired tired something tired love text walk love else tired two one you text pig worried naive hello ten ", 12, 2, new DateTime(2022, 6, 20, 9, 23, 47, 912, DateTimeKind.Local).AddTicks(115), "b74ddd14-6340-4840-95c2-db12554843e5" },
                    { 12, "fix thick well-made anything fix pig naive text something paragragh fix thick love body paragragh numberless fix one well-made pig else anything you walk paragragh you pig industrious three anything ", 16, 2, new DateTime(2022, 6, 20, 9, 23, 47, 912, DateTimeKind.Local).AddTicks(395), "b74ddd14-6340-4840-95c2-db12554843e5" },
                    { 8, "cent text pig naive love well-made anything something text fix anything worried naive text cent pig industrious paragragh three cent two walk ten text well-made naive cent numberless anything pin ", 1, 2, new DateTime(2022, 6, 20, 9, 23, 47, 912, DateTimeKind.Local).AddTicks(208), "b74ddd14-6340-4840-95c2-db12554843e5" },
                    { 5, "love bye anything worried well-made two something ten well-made walk naive ten else text love naive body fix naive bye fix body ten something pin you worried love tired else ", 3, 1, new DateTime(2022, 6, 20, 9, 23, 47, 912, DateTimeKind.Local).AddTicks(41), "b74ddd14-6340-4840-95c2-db12554843e5" },
                    { 25, "hello pig one love body bye something well-made well-made you something love anything anything you hello you else thick pig text bye you body paragragh numberless naive two paragragh two ", 21, 1, new DateTime(2022, 6, 20, 9, 23, 47, 912, DateTimeKind.Local).AddTicks(922), "b74ddd14-6340-4840-95c2-db12554843e5" },
                    { 9, "else paragragh else pin worried you bye well-made thick bye hello thick hello text industrious pig text three tired else bye tired you body anything one industrious one industrious you ", 21, 2, new DateTime(2022, 6, 20, 9, 23, 47, 912, DateTimeKind.Local).AddTicks(225), "b74ddd14-6340-4840-95c2-db12554843e5" },
                    { 18, "paragragh numberless text three love ten paragragh cent pig three something well-made love two something well-made walk hello fix pig three fix two something industrious naive pig industrious two anything ", 24, 4, new DateTime(2022, 6, 20, 9, 23, 47, 912, DateTimeKind.Local).AddTicks(654), "b74ddd14-6340-4840-95c2-db12554843e5" },
                    { 2, "tired worried body hello body thick you love fix hello ten walk paragragh cent two industrious text else something thick numberless walk industrious naive worried pin anything industrious naive pin ", 3, 2, new DateTime(2022, 6, 20, 9, 23, 47, 911, DateTimeKind.Local).AddTicks(9930), "b74ddd14-6340-4840-95c2-db12554843e5" },
                    { 13, "love cent fix cent one naive industrious pin walk two two three cent text cent something fix something three hello naive industrious two hello hello pin walk bye body walk ", 25, 1, new DateTime(2022, 6, 20, 9, 23, 47, 912, DateTimeKind.Local).AddTicks(443), "b74ddd14-6340-4840-95c2-db12554843e5" },
                    { 11, "three ten body anything well-made bye well-made two else well-made fix you one ten well-made bye naive bye naive walk one two numberless numberless something cent else pig numberless one ", 11, 2, new DateTime(2022, 6, 20, 9, 23, 47, 912, DateTimeKind.Local).AddTicks(347), "b74ddd14-6340-4840-95c2-db12554843e5" },
                    { 17, "else cent love anything pig else body paragragh naive one three ten hello worried walk three pin industrious paragragh two hello numberless numberless one else cent industrious pin you tired ", 26, 1, new DateTime(2022, 6, 20, 9, 23, 47, 912, DateTimeKind.Local).AddTicks(598), "b74ddd14-6340-4840-95c2-db12554843e5" },
                    { 21, "pin body else else walk text hello naive pin numberless you paragragh else you walk bye love fix you well-made pin three walk something paragragh hello pig love well-made bye ", 4, 4, new DateTime(2022, 6, 20, 9, 23, 47, 912, DateTimeKind.Local).AddTicks(768), "b74ddd14-6340-4840-95c2-db12554843e5" },
                    { 23, "anything three pig one something numberless well-made pig thick body fix paragragh numberless worried worried one industrious fix thick three pin three bye anything fix numberless naive well-made something naive ", 15, 3, new DateTime(2022, 6, 20, 9, 23, 47, 912, DateTimeKind.Local).AddTicks(858), "b74ddd14-6340-4840-95c2-db12554843e5" },
                    { 4, "tired hello anything paragragh fix anything one walk body worried one else naive paragragh text anything else you thick bye two paragragh fix numberless two one one love worried text ", 4, 2, new DateTime(2022, 6, 20, 9, 23, 47, 911, DateTimeKind.Local).AddTicks(9998), "b74ddd14-6340-4840-95c2-db12554843e5" },
                    { 22, "hello worried well-made worried pig one numberless anything ten well-made paragragh industrious hello walk tired three bye fix hello well-made one bye text walk ten pin you paragragh fix two ", 2, 1, new DateTime(2022, 6, 20, 9, 23, 47, 912, DateTimeKind.Local).AddTicks(812), "b74ddd14-6340-4840-95c2-db12554843e5" },
                    { 1, "text bye worried cent fix well-made cent numberless you three hello worried ten one body else you paragragh well-made naive ten tired tired industrious walk naive you worried body one ", 17, 4, new DateTime(2022, 6, 20, 9, 23, 47, 911, DateTimeKind.Local).AddTicks(9628), "b74ddd14-6340-4840-95c2-db12554843e5" },
                    { 7, "worried industrious paragragh worried anything numberless bye fix paragragh well-made well-made love text tired walk thick bye pig cent cent ten tired three fix body you industrious hello fix thick ", 17, 3, new DateTime(2022, 6, 20, 9, 23, 47, 912, DateTimeKind.Local).AddTicks(162), "b74ddd14-6340-4840-95c2-db12554843e5" },
                    { 19, "else love numberless fix tired tired body walk thick one naive else tired three text numberless bye three three fix anything two worried naive hello industrious text bye hello something ", 17, 4, new DateTime(2022, 6, 20, 9, 23, 47, 912, DateTimeKind.Local).AddTicks(671), "b74ddd14-6340-4840-95c2-db12554843e5" },
                    { 10, "tired bye fix one pin worried worried cent walk two three industrious text tired well-made one well-made you naive industrious two naive you pig love text industrious one three body ", 5, 3, new DateTime(2022, 6, 20, 9, 23, 47, 912, DateTimeKind.Local).AddTicks(273), "b74ddd14-6340-4840-95c2-db12554843e5" },
                    { 3, "well-made body paragragh something one bye else bye three tired you naive two cent thick numberless paragragh ten fix naive you walk tired cent numberless else thick body tired ten ", 16, 2, new DateTime(2022, 6, 20, 9, 23, 47, 911, DateTimeKind.Local).AddTicks(9951), "b74ddd14-6340-4840-95c2-db12554843e5" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_UserId",
                table: "Reviews",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderHistories_UserId",
                table: "OrderHistories",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_ColorProduct_ProductsId",
                table: "ColorProduct",
                column: "ProductsId");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderHistories_AspNetUsers_UserId",
                table: "OrderHistories",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Reviews_AspNetUsers_UserId",
                table: "Reviews",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderHistories_AspNetUsers_UserId",
                table: "OrderHistories");

            migrationBuilder.DropForeignKey(
                name: "FK_Reviews_AspNetUsers_UserId",
                table: "Reviews");

            migrationBuilder.DropTable(
                name: "ColorProduct");

            migrationBuilder.DropIndex(
                name: "IX_Reviews_UserId",
                table: "Reviews");

            migrationBuilder.DropIndex(
                name: "IX_OrderHistories_UserId",
                table: "OrderHistories");

            migrationBuilder.DeleteData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "OHProducts",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "OHProducts",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "OHProducts",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "OHProducts",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "OHProducts",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "OHProducts",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "OHProducts",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "OHProducts",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "OHProducts",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "OHProducts",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "OHProducts",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "OHProducts",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "OHProducts",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "OHProducts",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "OHProducts",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "OHProducts",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "OHProducts",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "OHProducts",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "OHProducts",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "OHProducts",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "OHProducts",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "OHProducts",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "OHProducts",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "OHProducts",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "OHProducts",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "OHProducts",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "OHProducts",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "OHProducts",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "OHProducts",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "OHProducts",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "OHProducts",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "OHProducts",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "OHProducts",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "OHProducts",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "OHProducts",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "OHProducts",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "OHProducts",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "OHProducts",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "OHProducts",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "OHProducts",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "OrderHistories",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "ProductSize",
                keyColumns: new[] { "ProductsId", "SizesId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "ProductSize",
                keyColumns: new[] { "ProductsId", "SizesId" },
                keyValues: new object[] { 1, 2 });

            migrationBuilder.DeleteData(
                table: "ProductSize",
                keyColumns: new[] { "ProductsId", "SizesId" },
                keyValues: new object[] { 1, 3 });

            migrationBuilder.DeleteData(
                table: "ProductSize",
                keyColumns: new[] { "ProductsId", "SizesId" },
                keyValues: new object[] { 1, 4 });

            migrationBuilder.DeleteData(
                table: "ProductSize",
                keyColumns: new[] { "ProductsId", "SizesId" },
                keyValues: new object[] { 1, 5 });

            migrationBuilder.DeleteData(
                table: "ProductSize",
                keyColumns: new[] { "ProductsId", "SizesId" },
                keyValues: new object[] { 2, 1 });

            migrationBuilder.DeleteData(
                table: "ProductSize",
                keyColumns: new[] { "ProductsId", "SizesId" },
                keyValues: new object[] { 2, 2 });

            migrationBuilder.DeleteData(
                table: "ProductSize",
                keyColumns: new[] { "ProductsId", "SizesId" },
                keyValues: new object[] { 2, 3 });

            migrationBuilder.DeleteData(
                table: "ProductSize",
                keyColumns: new[] { "ProductsId", "SizesId" },
                keyValues: new object[] { 2, 4 });

            migrationBuilder.DeleteData(
                table: "ProductSize",
                keyColumns: new[] { "ProductsId", "SizesId" },
                keyValues: new object[] { 2, 5 });

            migrationBuilder.DeleteData(
                table: "ProductSize",
                keyColumns: new[] { "ProductsId", "SizesId" },
                keyValues: new object[] { 3, 1 });

            migrationBuilder.DeleteData(
                table: "ProductSize",
                keyColumns: new[] { "ProductsId", "SizesId" },
                keyValues: new object[] { 3, 2 });

            migrationBuilder.DeleteData(
                table: "ProductSize",
                keyColumns: new[] { "ProductsId", "SizesId" },
                keyValues: new object[] { 3, 3 });

            migrationBuilder.DeleteData(
                table: "ProductSize",
                keyColumns: new[] { "ProductsId", "SizesId" },
                keyValues: new object[] { 3, 4 });

            migrationBuilder.DeleteData(
                table: "ProductSize",
                keyColumns: new[] { "ProductsId", "SizesId" },
                keyValues: new object[] { 3, 5 });

            migrationBuilder.DeleteData(
                table: "ProductSize",
                keyColumns: new[] { "ProductsId", "SizesId" },
                keyValues: new object[] { 4, 1 });

            migrationBuilder.DeleteData(
                table: "ProductSize",
                keyColumns: new[] { "ProductsId", "SizesId" },
                keyValues: new object[] { 4, 2 });

            migrationBuilder.DeleteData(
                table: "ProductSize",
                keyColumns: new[] { "ProductsId", "SizesId" },
                keyValues: new object[] { 4, 3 });

            migrationBuilder.DeleteData(
                table: "ProductSize",
                keyColumns: new[] { "ProductsId", "SizesId" },
                keyValues: new object[] { 4, 4 });

            migrationBuilder.DeleteData(
                table: "ProductSize",
                keyColumns: new[] { "ProductsId", "SizesId" },
                keyValues: new object[] { 4, 5 });

            migrationBuilder.DeleteData(
                table: "ProductSize",
                keyColumns: new[] { "ProductsId", "SizesId" },
                keyValues: new object[] { 5, 1 });

            migrationBuilder.DeleteData(
                table: "ProductSize",
                keyColumns: new[] { "ProductsId", "SizesId" },
                keyValues: new object[] { 5, 2 });

            migrationBuilder.DeleteData(
                table: "ProductSize",
                keyColumns: new[] { "ProductsId", "SizesId" },
                keyValues: new object[] { 5, 3 });

            migrationBuilder.DeleteData(
                table: "ProductSize",
                keyColumns: new[] { "ProductsId", "SizesId" },
                keyValues: new object[] { 5, 4 });

            migrationBuilder.DeleteData(
                table: "ProductSize",
                keyColumns: new[] { "ProductsId", "SizesId" },
                keyValues: new object[] { 5, 5 });

            migrationBuilder.DeleteData(
                table: "ProductSize",
                keyColumns: new[] { "ProductsId", "SizesId" },
                keyValues: new object[] { 6, 1 });

            migrationBuilder.DeleteData(
                table: "ProductSize",
                keyColumns: new[] { "ProductsId", "SizesId" },
                keyValues: new object[] { 6, 2 });

            migrationBuilder.DeleteData(
                table: "ProductSize",
                keyColumns: new[] { "ProductsId", "SizesId" },
                keyValues: new object[] { 6, 3 });

            migrationBuilder.DeleteData(
                table: "ProductSize",
                keyColumns: new[] { "ProductsId", "SizesId" },
                keyValues: new object[] { 6, 4 });

            migrationBuilder.DeleteData(
                table: "ProductSize",
                keyColumns: new[] { "ProductsId", "SizesId" },
                keyValues: new object[] { 6, 5 });

            migrationBuilder.DeleteData(
                table: "ProductSize",
                keyColumns: new[] { "ProductsId", "SizesId" },
                keyValues: new object[] { 7, 1 });

            migrationBuilder.DeleteData(
                table: "ProductSize",
                keyColumns: new[] { "ProductsId", "SizesId" },
                keyValues: new object[] { 7, 2 });

            migrationBuilder.DeleteData(
                table: "ProductSize",
                keyColumns: new[] { "ProductsId", "SizesId" },
                keyValues: new object[] { 7, 3 });

            migrationBuilder.DeleteData(
                table: "ProductSize",
                keyColumns: new[] { "ProductsId", "SizesId" },
                keyValues: new object[] { 7, 4 });

            migrationBuilder.DeleteData(
                table: "ProductSize",
                keyColumns: new[] { "ProductsId", "SizesId" },
                keyValues: new object[] { 7, 5 });

            migrationBuilder.DeleteData(
                table: "ProductSize",
                keyColumns: new[] { "ProductsId", "SizesId" },
                keyValues: new object[] { 8, 1 });

            migrationBuilder.DeleteData(
                table: "ProductSize",
                keyColumns: new[] { "ProductsId", "SizesId" },
                keyValues: new object[] { 8, 2 });

            migrationBuilder.DeleteData(
                table: "ProductSize",
                keyColumns: new[] { "ProductsId", "SizesId" },
                keyValues: new object[] { 8, 3 });

            migrationBuilder.DeleteData(
                table: "ProductSize",
                keyColumns: new[] { "ProductsId", "SizesId" },
                keyValues: new object[] { 8, 4 });

            migrationBuilder.DeleteData(
                table: "ProductSize",
                keyColumns: new[] { "ProductsId", "SizesId" },
                keyValues: new object[] { 8, 5 });

            migrationBuilder.DeleteData(
                table: "ProductSize",
                keyColumns: new[] { "ProductsId", "SizesId" },
                keyValues: new object[] { 9, 1 });

            migrationBuilder.DeleteData(
                table: "ProductSize",
                keyColumns: new[] { "ProductsId", "SizesId" },
                keyValues: new object[] { 9, 2 });

            migrationBuilder.DeleteData(
                table: "ProductSize",
                keyColumns: new[] { "ProductsId", "SizesId" },
                keyValues: new object[] { 9, 3 });

            migrationBuilder.DeleteData(
                table: "ProductSize",
                keyColumns: new[] { "ProductsId", "SizesId" },
                keyValues: new object[] { 9, 4 });

            migrationBuilder.DeleteData(
                table: "ProductSize",
                keyColumns: new[] { "ProductsId", "SizesId" },
                keyValues: new object[] { 9, 5 });

            migrationBuilder.DeleteData(
                table: "ProductSize",
                keyColumns: new[] { "ProductsId", "SizesId" },
                keyValues: new object[] { 10, 1 });

            migrationBuilder.DeleteData(
                table: "ProductSize",
                keyColumns: new[] { "ProductsId", "SizesId" },
                keyValues: new object[] { 10, 2 });

            migrationBuilder.DeleteData(
                table: "ProductSize",
                keyColumns: new[] { "ProductsId", "SizesId" },
                keyValues: new object[] { 10, 3 });

            migrationBuilder.DeleteData(
                table: "ProductSize",
                keyColumns: new[] { "ProductsId", "SizesId" },
                keyValues: new object[] { 10, 4 });

            migrationBuilder.DeleteData(
                table: "ProductSize",
                keyColumns: new[] { "ProductsId", "SizesId" },
                keyValues: new object[] { 10, 5 });

            migrationBuilder.DeleteData(
                table: "ProductSize",
                keyColumns: new[] { "ProductsId", "SizesId" },
                keyValues: new object[] { 11, 1 });

            migrationBuilder.DeleteData(
                table: "ProductSize",
                keyColumns: new[] { "ProductsId", "SizesId" },
                keyValues: new object[] { 11, 2 });

            migrationBuilder.DeleteData(
                table: "ProductSize",
                keyColumns: new[] { "ProductsId", "SizesId" },
                keyValues: new object[] { 11, 3 });

            migrationBuilder.DeleteData(
                table: "ProductSize",
                keyColumns: new[] { "ProductsId", "SizesId" },
                keyValues: new object[] { 11, 4 });

            migrationBuilder.DeleteData(
                table: "ProductSize",
                keyColumns: new[] { "ProductsId", "SizesId" },
                keyValues: new object[] { 11, 5 });

            migrationBuilder.DeleteData(
                table: "ProductSize",
                keyColumns: new[] { "ProductsId", "SizesId" },
                keyValues: new object[] { 12, 1 });

            migrationBuilder.DeleteData(
                table: "ProductSize",
                keyColumns: new[] { "ProductsId", "SizesId" },
                keyValues: new object[] { 12, 2 });

            migrationBuilder.DeleteData(
                table: "ProductSize",
                keyColumns: new[] { "ProductsId", "SizesId" },
                keyValues: new object[] { 12, 3 });

            migrationBuilder.DeleteData(
                table: "ProductSize",
                keyColumns: new[] { "ProductsId", "SizesId" },
                keyValues: new object[] { 12, 4 });

            migrationBuilder.DeleteData(
                table: "ProductSize",
                keyColumns: new[] { "ProductsId", "SizesId" },
                keyValues: new object[] { 12, 5 });

            migrationBuilder.DeleteData(
                table: "ProductSize",
                keyColumns: new[] { "ProductsId", "SizesId" },
                keyValues: new object[] { 13, 1 });

            migrationBuilder.DeleteData(
                table: "ProductSize",
                keyColumns: new[] { "ProductsId", "SizesId" },
                keyValues: new object[] { 13, 2 });

            migrationBuilder.DeleteData(
                table: "ProductSize",
                keyColumns: new[] { "ProductsId", "SizesId" },
                keyValues: new object[] { 13, 3 });

            migrationBuilder.DeleteData(
                table: "ProductSize",
                keyColumns: new[] { "ProductsId", "SizesId" },
                keyValues: new object[] { 13, 4 });

            migrationBuilder.DeleteData(
                table: "ProductSize",
                keyColumns: new[] { "ProductsId", "SizesId" },
                keyValues: new object[] { 13, 5 });

            migrationBuilder.DeleteData(
                table: "ProductSize",
                keyColumns: new[] { "ProductsId", "SizesId" },
                keyValues: new object[] { 14, 1 });

            migrationBuilder.DeleteData(
                table: "ProductSize",
                keyColumns: new[] { "ProductsId", "SizesId" },
                keyValues: new object[] { 14, 2 });

            migrationBuilder.DeleteData(
                table: "ProductSize",
                keyColumns: new[] { "ProductsId", "SizesId" },
                keyValues: new object[] { 14, 3 });

            migrationBuilder.DeleteData(
                table: "ProductSize",
                keyColumns: new[] { "ProductsId", "SizesId" },
                keyValues: new object[] { 14, 4 });

            migrationBuilder.DeleteData(
                table: "ProductSize",
                keyColumns: new[] { "ProductsId", "SizesId" },
                keyValues: new object[] { 14, 5 });

            migrationBuilder.DeleteData(
                table: "ProductSize",
                keyColumns: new[] { "ProductsId", "SizesId" },
                keyValues: new object[] { 15, 1 });

            migrationBuilder.DeleteData(
                table: "ProductSize",
                keyColumns: new[] { "ProductsId", "SizesId" },
                keyValues: new object[] { 15, 2 });

            migrationBuilder.DeleteData(
                table: "ProductSize",
                keyColumns: new[] { "ProductsId", "SizesId" },
                keyValues: new object[] { 15, 3 });

            migrationBuilder.DeleteData(
                table: "ProductSize",
                keyColumns: new[] { "ProductsId", "SizesId" },
                keyValues: new object[] { 15, 4 });

            migrationBuilder.DeleteData(
                table: "ProductSize",
                keyColumns: new[] { "ProductsId", "SizesId" },
                keyValues: new object[] { 15, 5 });

            migrationBuilder.DeleteData(
                table: "ProductSize",
                keyColumns: new[] { "ProductsId", "SizesId" },
                keyValues: new object[] { 16, 1 });

            migrationBuilder.DeleteData(
                table: "ProductSize",
                keyColumns: new[] { "ProductsId", "SizesId" },
                keyValues: new object[] { 16, 2 });

            migrationBuilder.DeleteData(
                table: "ProductSize",
                keyColumns: new[] { "ProductsId", "SizesId" },
                keyValues: new object[] { 16, 3 });

            migrationBuilder.DeleteData(
                table: "ProductSize",
                keyColumns: new[] { "ProductsId", "SizesId" },
                keyValues: new object[] { 16, 4 });

            migrationBuilder.DeleteData(
                table: "ProductSize",
                keyColumns: new[] { "ProductsId", "SizesId" },
                keyValues: new object[] { 16, 5 });

            migrationBuilder.DeleteData(
                table: "ProductSize",
                keyColumns: new[] { "ProductsId", "SizesId" },
                keyValues: new object[] { 17, 1 });

            migrationBuilder.DeleteData(
                table: "ProductSize",
                keyColumns: new[] { "ProductsId", "SizesId" },
                keyValues: new object[] { 17, 2 });

            migrationBuilder.DeleteData(
                table: "ProductSize",
                keyColumns: new[] { "ProductsId", "SizesId" },
                keyValues: new object[] { 17, 3 });

            migrationBuilder.DeleteData(
                table: "ProductSize",
                keyColumns: new[] { "ProductsId", "SizesId" },
                keyValues: new object[] { 17, 4 });

            migrationBuilder.DeleteData(
                table: "ProductSize",
                keyColumns: new[] { "ProductsId", "SizesId" },
                keyValues: new object[] { 17, 5 });

            migrationBuilder.DeleteData(
                table: "ProductSize",
                keyColumns: new[] { "ProductsId", "SizesId" },
                keyValues: new object[] { 18, 1 });

            migrationBuilder.DeleteData(
                table: "ProductSize",
                keyColumns: new[] { "ProductsId", "SizesId" },
                keyValues: new object[] { 18, 2 });

            migrationBuilder.DeleteData(
                table: "ProductSize",
                keyColumns: new[] { "ProductsId", "SizesId" },
                keyValues: new object[] { 18, 3 });

            migrationBuilder.DeleteData(
                table: "ProductSize",
                keyColumns: new[] { "ProductsId", "SizesId" },
                keyValues: new object[] { 18, 4 });

            migrationBuilder.DeleteData(
                table: "ProductSize",
                keyColumns: new[] { "ProductsId", "SizesId" },
                keyValues: new object[] { 18, 5 });

            migrationBuilder.DeleteData(
                table: "ProductSize",
                keyColumns: new[] { "ProductsId", "SizesId" },
                keyValues: new object[] { 19, 1 });

            migrationBuilder.DeleteData(
                table: "ProductSize",
                keyColumns: new[] { "ProductsId", "SizesId" },
                keyValues: new object[] { 19, 2 });

            migrationBuilder.DeleteData(
                table: "ProductSize",
                keyColumns: new[] { "ProductsId", "SizesId" },
                keyValues: new object[] { 19, 3 });

            migrationBuilder.DeleteData(
                table: "ProductSize",
                keyColumns: new[] { "ProductsId", "SizesId" },
                keyValues: new object[] { 19, 4 });

            migrationBuilder.DeleteData(
                table: "ProductSize",
                keyColumns: new[] { "ProductsId", "SizesId" },
                keyValues: new object[] { 19, 5 });

            migrationBuilder.DeleteData(
                table: "ProductSize",
                keyColumns: new[] { "ProductsId", "SizesId" },
                keyValues: new object[] { 20, 1 });

            migrationBuilder.DeleteData(
                table: "ProductSize",
                keyColumns: new[] { "ProductsId", "SizesId" },
                keyValues: new object[] { 20, 2 });

            migrationBuilder.DeleteData(
                table: "ProductSize",
                keyColumns: new[] { "ProductsId", "SizesId" },
                keyValues: new object[] { 20, 3 });

            migrationBuilder.DeleteData(
                table: "ProductSize",
                keyColumns: new[] { "ProductsId", "SizesId" },
                keyValues: new object[] { 20, 4 });

            migrationBuilder.DeleteData(
                table: "ProductSize",
                keyColumns: new[] { "ProductsId", "SizesId" },
                keyValues: new object[] { 20, 5 });

            migrationBuilder.DeleteData(
                table: "ProductSize",
                keyColumns: new[] { "ProductsId", "SizesId" },
                keyValues: new object[] { 21, 1 });

            migrationBuilder.DeleteData(
                table: "ProductSize",
                keyColumns: new[] { "ProductsId", "SizesId" },
                keyValues: new object[] { 21, 2 });

            migrationBuilder.DeleteData(
                table: "ProductSize",
                keyColumns: new[] { "ProductsId", "SizesId" },
                keyValues: new object[] { 21, 3 });

            migrationBuilder.DeleteData(
                table: "ProductSize",
                keyColumns: new[] { "ProductsId", "SizesId" },
                keyValues: new object[] { 21, 4 });

            migrationBuilder.DeleteData(
                table: "ProductSize",
                keyColumns: new[] { "ProductsId", "SizesId" },
                keyValues: new object[] { 21, 5 });

            migrationBuilder.DeleteData(
                table: "ProductSize",
                keyColumns: new[] { "ProductsId", "SizesId" },
                keyValues: new object[] { 22, 1 });

            migrationBuilder.DeleteData(
                table: "ProductSize",
                keyColumns: new[] { "ProductsId", "SizesId" },
                keyValues: new object[] { 22, 2 });

            migrationBuilder.DeleteData(
                table: "ProductSize",
                keyColumns: new[] { "ProductsId", "SizesId" },
                keyValues: new object[] { 22, 3 });

            migrationBuilder.DeleteData(
                table: "ProductSize",
                keyColumns: new[] { "ProductsId", "SizesId" },
                keyValues: new object[] { 22, 4 });

            migrationBuilder.DeleteData(
                table: "ProductSize",
                keyColumns: new[] { "ProductsId", "SizesId" },
                keyValues: new object[] { 22, 5 });

            migrationBuilder.DeleteData(
                table: "ProductSize",
                keyColumns: new[] { "ProductsId", "SizesId" },
                keyValues: new object[] { 23, 1 });

            migrationBuilder.DeleteData(
                table: "ProductSize",
                keyColumns: new[] { "ProductsId", "SizesId" },
                keyValues: new object[] { 23, 2 });

            migrationBuilder.DeleteData(
                table: "ProductSize",
                keyColumns: new[] { "ProductsId", "SizesId" },
                keyValues: new object[] { 23, 3 });

            migrationBuilder.DeleteData(
                table: "ProductSize",
                keyColumns: new[] { "ProductsId", "SizesId" },
                keyValues: new object[] { 23, 4 });

            migrationBuilder.DeleteData(
                table: "ProductSize",
                keyColumns: new[] { "ProductsId", "SizesId" },
                keyValues: new object[] { 23, 5 });

            migrationBuilder.DeleteData(
                table: "ProductSize",
                keyColumns: new[] { "ProductsId", "SizesId" },
                keyValues: new object[] { 24, 1 });

            migrationBuilder.DeleteData(
                table: "ProductSize",
                keyColumns: new[] { "ProductsId", "SizesId" },
                keyValues: new object[] { 24, 2 });

            migrationBuilder.DeleteData(
                table: "ProductSize",
                keyColumns: new[] { "ProductsId", "SizesId" },
                keyValues: new object[] { 24, 3 });

            migrationBuilder.DeleteData(
                table: "ProductSize",
                keyColumns: new[] { "ProductsId", "SizesId" },
                keyValues: new object[] { 24, 4 });

            migrationBuilder.DeleteData(
                table: "ProductSize",
                keyColumns: new[] { "ProductsId", "SizesId" },
                keyValues: new object[] { 24, 5 });

            migrationBuilder.DeleteData(
                table: "ProductSize",
                keyColumns: new[] { "ProductsId", "SizesId" },
                keyValues: new object[] { 25, 1 });

            migrationBuilder.DeleteData(
                table: "ProductSize",
                keyColumns: new[] { "ProductsId", "SizesId" },
                keyValues: new object[] { 25, 2 });

            migrationBuilder.DeleteData(
                table: "ProductSize",
                keyColumns: new[] { "ProductsId", "SizesId" },
                keyValues: new object[] { 25, 3 });

            migrationBuilder.DeleteData(
                table: "ProductSize",
                keyColumns: new[] { "ProductsId", "SizesId" },
                keyValues: new object[] { 25, 4 });

            migrationBuilder.DeleteData(
                table: "ProductSize",
                keyColumns: new[] { "ProductsId", "SizesId" },
                keyValues: new object[] { 25, 5 });

            migrationBuilder.DeleteData(
                table: "ProductSize",
                keyColumns: new[] { "ProductsId", "SizesId" },
                keyValues: new object[] { 26, 1 });

            migrationBuilder.DeleteData(
                table: "ProductSize",
                keyColumns: new[] { "ProductsId", "SizesId" },
                keyValues: new object[] { 26, 2 });

            migrationBuilder.DeleteData(
                table: "ProductSize",
                keyColumns: new[] { "ProductsId", "SizesId" },
                keyValues: new object[] { 26, 3 });

            migrationBuilder.DeleteData(
                table: "ProductSize",
                keyColumns: new[] { "ProductsId", "SizesId" },
                keyValues: new object[] { 26, 4 });

            migrationBuilder.DeleteData(
                table: "ProductSize",
                keyColumns: new[] { "ProductsId", "SizesId" },
                keyValues: new object[] { 26, 5 });

            migrationBuilder.DeleteData(
                table: "ProductSize",
                keyColumns: new[] { "ProductsId", "SizesId" },
                keyValues: new object[] { 27, 1 });

            migrationBuilder.DeleteData(
                table: "ProductSize",
                keyColumns: new[] { "ProductsId", "SizesId" },
                keyValues: new object[] { 27, 2 });

            migrationBuilder.DeleteData(
                table: "ProductSize",
                keyColumns: new[] { "ProductsId", "SizesId" },
                keyValues: new object[] { 27, 3 });

            migrationBuilder.DeleteData(
                table: "ProductSize",
                keyColumns: new[] { "ProductsId", "SizesId" },
                keyValues: new object[] { 27, 4 });

            migrationBuilder.DeleteData(
                table: "ProductSize",
                keyColumns: new[] { "ProductsId", "SizesId" },
                keyValues: new object[] { 27, 5 });

            migrationBuilder.DeleteData(
                table: "ProductSize",
                keyColumns: new[] { "ProductsId", "SizesId" },
                keyValues: new object[] { 28, 1 });

            migrationBuilder.DeleteData(
                table: "ProductSize",
                keyColumns: new[] { "ProductsId", "SizesId" },
                keyValues: new object[] { 28, 2 });

            migrationBuilder.DeleteData(
                table: "ProductSize",
                keyColumns: new[] { "ProductsId", "SizesId" },
                keyValues: new object[] { 28, 3 });

            migrationBuilder.DeleteData(
                table: "ProductSize",
                keyColumns: new[] { "ProductsId", "SizesId" },
                keyValues: new object[] { 28, 4 });

            migrationBuilder.DeleteData(
                table: "ProductSize",
                keyColumns: new[] { "ProductsId", "SizesId" },
                keyValues: new object[] { 28, 5 });

            migrationBuilder.DeleteData(
                table: "ProductSize",
                keyColumns: new[] { "ProductsId", "SizesId" },
                keyValues: new object[] { 29, 1 });

            migrationBuilder.DeleteData(
                table: "ProductSize",
                keyColumns: new[] { "ProductsId", "SizesId" },
                keyValues: new object[] { 29, 2 });

            migrationBuilder.DeleteData(
                table: "ProductSize",
                keyColumns: new[] { "ProductsId", "SizesId" },
                keyValues: new object[] { 29, 3 });

            migrationBuilder.DeleteData(
                table: "ProductSize",
                keyColumns: new[] { "ProductsId", "SizesId" },
                keyValues: new object[] { 29, 4 });

            migrationBuilder.DeleteData(
                table: "ProductSize",
                keyColumns: new[] { "ProductsId", "SizesId" },
                keyValues: new object[] { 29, 5 });

            migrationBuilder.DeleteData(
                table: "ProductSize",
                keyColumns: new[] { "ProductsId", "SizesId" },
                keyValues: new object[] { 30, 1 });

            migrationBuilder.DeleteData(
                table: "ProductSize",
                keyColumns: new[] { "ProductsId", "SizesId" },
                keyValues: new object[] { 30, 2 });

            migrationBuilder.DeleteData(
                table: "ProductSize",
                keyColumns: new[] { "ProductsId", "SizesId" },
                keyValues: new object[] { 30, 3 });

            migrationBuilder.DeleteData(
                table: "ProductSize",
                keyColumns: new[] { "ProductsId", "SizesId" },
                keyValues: new object[] { 30, 4 });

            migrationBuilder.DeleteData(
                table: "ProductSize",
                keyColumns: new[] { "ProductsId", "SizesId" },
                keyValues: new object[] { 30, 5 });

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "OrderHistories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "OrderHistories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "OrderHistories",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "OrderHistories",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db12554843e5");

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.RenameColumn(
                name: "HexCode",
                table: "Colors",
                newName: "Name");

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "Reviews",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserId1",
                table: "Reviews",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "OrderHistories",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserId1",
                table: "OrderHistories",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "ColorProducts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ColorId = table.Column<int>(type: "int", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ColorProducts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ColorProducts_Colors_ColorId",
                        column: x => x.ColorId,
                        principalTable: "Colors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ColorProducts_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_UserId1",
                table: "Reviews",
                column: "UserId1");

            migrationBuilder.CreateIndex(
                name: "IX_OrderHistories_UserId1",
                table: "OrderHistories",
                column: "UserId1");

            migrationBuilder.CreateIndex(
                name: "IX_ColorProducts_ColorId",
                table: "ColorProducts",
                column: "ColorId");

            migrationBuilder.CreateIndex(
                name: "IX_ColorProducts_ProductId",
                table: "ColorProducts",
                column: "ProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderHistories_AspNetUsers_UserId1",
                table: "OrderHistories",
                column: "UserId1",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Reviews_AspNetUsers_UserId1",
                table: "Reviews",
                column: "UserId1",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
