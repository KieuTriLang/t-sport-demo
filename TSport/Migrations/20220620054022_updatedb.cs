using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TSport.Migrations
{
    public partial class updatedb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Images",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Url = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Images", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ImageProduct",
                columns: table => new
                {
                    ImagesId = table.Column<int>(type: "int", nullable: false),
                    ProductsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ImageProduct", x => new { x.ImagesId, x.ProductsId });
                    table.ForeignKey(
                        name: "FK_ImageProduct_Images_ImagesId",
                        column: x => x.ImagesId,
                        principalTable: "Images",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ImageProduct_Products_ProductsId",
                        column: x => x.ProductsId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db12554843e5",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "a94351c1-f374-410e-aab5-9c2ca972ebcd", "dd108c58-083a-445f-8739-295fde74fe7f" });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Author", "Content", "Tag", "TimePosted", "Title" },
                values: new object[] { "cent else ", "worried industrious two love bye body one one pin naive text pin something text industrious three bye paragragh one hello thick fix worried body pig fix naive walk fix cent bye body anything text thick worried cent bye paragragh tired one hello two tired pin pig two text paragragh well-made pig anything body walk love text body two one industrious else thick industrious love three text industrious anything naive anything something pin pin worried anything you three text body pin three two hello cent you two pin paragragh love else worried two anything else paragragh walk thick paragragh two pig ", "tired ten two well-made ", new DateTime(2022, 6, 20, 12, 40, 20, 405, DateTimeKind.Local).AddTicks(176), "pig well-made tired three numberless three else one text well-made " });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Author", "Content", "Tag", "TimePosted", "Title" },
                values: new object[] { "one text ", "love anything anything walk text thick industrious something three numberless industrious thick tired paragragh bye numberless worried else three cent walk text one something text cent hello you ten love anything thick tired else naive fix three tired one three two paragragh body one cent bye fix bye tired ten worried anything text industrious love cent thick naive hello one love cent love anything worried text anything paragragh tired industrious well-made text industrious pin one hello text pin fix cent paragragh anything hello pin paragragh pin else naive three worried numberless hello you pin anything tired you pin fix fix ", "industrious naive one fix ", new DateTime(2022, 6, 20, 12, 40, 20, 406, DateTimeKind.Local).AddTicks(9755), "you three well-made anything love well-made something one well-made numberless " });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Author", "Content", "Tag", "TimePosted", "Title" },
                values: new object[] { "three bye ", "text love walk industrious pin something you pig pin ten ten industrious industrious cent two text two body two numberless three worried fix pig cent body three fix else paragragh two two walk pin text numberless three naive tired anything ten three pig ten something paragragh two thick ten paragragh text love text paragragh industrious one tired you anything numberless three hello two pig cent walk you numberless hello one love pig one else well-made body love else else fix tired hello something anything pin text you fix anything worried something anything thick thick worried pig well-made body two tired ", "you well-made love fix ", new DateTime(2022, 6, 20, 12, 40, 20, 407, DateTimeKind.Local).AddTicks(27), "three else bye tired fix naive love naive three anything " });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Author", "Content", "Tag", "TimePosted", "Title" },
                values: new object[] { "else paragragh ", "love something pig fix pig fix worried naive you anything anything walk bye body paragragh love numberless pig two you two thick numberless two tired love anything three fix you text three paragragh ten fix something text cent industrious thick thick one thick anything hello industrious bye bye thick three else anything you paragragh paragragh hello two text pin fix bye naive you body walk industrious fix paragragh bye industrious cent love cent walk bye pin pin worried industrious pig thick tired hello two well-made ten you body numberless anything numberless body cent else love numberless else thick text tired ", "pin well-made else ten ", new DateTime(2022, 6, 20, 12, 40, 20, 407, DateTimeKind.Local).AddTicks(427), "pig pin hello industrious text text walk bye something naive " });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Author", "Content", "Tag", "TimePosted", "Title" },
                values: new object[] { "tired three ", "three pig paragragh fix cent fix text one numberless cent text hello naive fix thick something fix else something two tired well-made anything fix body walk paragragh naive hello two thick fix two ten walk thick something well-made well-made walk numberless hello cent hello numberless pig thick ten naive love pin anything numberless hello else two thick pig fix anything text thick industrious hello ten well-made you one walk pin body cent fix fix one anything numberless fix tired else three body body two two tired tired industrious industrious something body thick ten pig bye else thick text else three ", "one naive love three ", new DateTime(2022, 6, 20, 12, 40, 20, 407, DateTimeKind.Local).AddTicks(1122), "ten text well-made text hello fix something text industrious industrious " });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Author", "Content", "Tag", "TimePosted", "Title" },
                values: new object[] { "pig bye ", "tired hello love tired love ten fix two numberless something tired cent anything love one thick paragragh two pig pin fix else paragragh ten you paragragh cent thick industrious numberless fix pin worried ten pig you three pig anything something tired anything pig walk tired naive text industrious cent cent cent naive hello worried pig paragragh text industrious hello industrious two numberless hello pin cent thick pin cent two something bye fix something something two hello thick one thick two numberless industrious walk anything love worried bye pin hello bye walk paragragh three three pin naive hello pig pin numberless ", "hello bye something paragragh ", new DateTime(2022, 6, 20, 12, 40, 20, 407, DateTimeKind.Local).AddTicks(1815), "bye something anything paragragh bye anything you paragragh worried text " });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Author", "Content", "Tag", "TimePosted", "Title" },
                values: new object[] { "three cent ", "love bye worried numberless three body else numberless fix ten two three two pig body industrious bye naive pig bye two else naive industrious hello else bye something cent pin numberless body ten hello hello anything worried body walk pig three fix industrious love worried love well-made walk three well-made something tired one bye anything walk walk numberless one cent hello numberless you tired paragragh something pin industrious three numberless body one industrious body else cent two hello body two tired naive three you tired something tired well-made one pig paragragh industrious tired numberless three ten one else worried hello ", "tired ten well-made industrious ", new DateTime(2022, 6, 20, 12, 40, 20, 407, DateTimeKind.Local).AddTicks(2500), "else love bye three thick cent text love numberless bye " });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Author", "Content", "Tag", "TimePosted", "Title" },
                values: new object[] { "hello anything ", "well-made body pin industrious well-made paragragh one one pig you worried numberless cent you something anything thick hello ten well-made you pin else pig naive ten fix ten else pin pin hello pig else one one something pin walk numberless two three hello thick body well-made tired anything cent else thick two cent bye well-made walk naive text paragragh fix naive ten love pig you else ten hello naive numberless pig naive well-made text something industrious bye pig naive industrious tired hello something pin something fix pig paragragh fix naive well-made you pig paragragh text three anything walk hello naive ", "two industrious thick numberless ", new DateTime(2022, 6, 20, 12, 40, 20, 407, DateTimeKind.Local).AddTicks(2873), "pig two three ten two text numberless anything ten cent " });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Author", "Content", "Tag", "TimePosted", "Title" },
                values: new object[] { "pin pig ", "worried love something fix thick numberless numberless body ten thick numberless hello body ten worried naive three body two fix love bye something two worried love three pig else well-made hello two text love text industrious two pin body fix love something pig body pin three fix worried pin thick cent tired numberless two pin something well-made pin naive hello walk paragragh naive one love fix ten worried industrious numberless paragragh three pin cent one well-made walk something two naive tired else well-made pig numberless industrious bye industrious three numberless three one text hello walk worried pig paragragh worried one ", "numberless body two thick ", new DateTime(2022, 6, 20, 12, 40, 20, 407, DateTimeKind.Local).AddTicks(3105), "naive fix you worried else pin tired else numberless love " });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Author", "Content", "Tag", "TimePosted", "Title" },
                values: new object[] { "else something ", "hello pin hello ten you text naive pin walk walk industrious one body fix anything hello bye numberless pig industrious something pig else text text something numberless numberless else well-made industrious text thick else something well-made well-made naive something pig body pin ten tired well-made three anything two three anything industrious tired text body you walk naive ten industrious pig else well-made thick body industrious tired cent pig three text walk walk tired body industrious something hello pig hello love text fix well-made text worried else body tired ten fix you hello walk thick something paragragh else three naive three ", "ten worried text you ", new DateTime(2022, 6, 20, 12, 40, 20, 407, DateTimeKind.Local).AddTicks(3351), "tired you numberless ten tired two fix pin industrious one " });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Author", "Content", "Tag", "TimePosted", "Title" },
                values: new object[] { "else hello ", "body something three tired fix ten bye tired ten text body numberless thick naive body else anything something walk numberless else worried pin well-made else well-made hello hello text love cent body ten fix paragragh pin body you tired love industrious tired thick body you anything thick one pig numberless worried else pin bye one love something two text walk pig pin else anything one body pig you two anything else pin well-made naive body pig paragragh pin naive paragragh love anything walk else text bye body pig you you thick tired walk walk one industrious text fix fix you ", "body thick thick industrious ", new DateTime(2022, 6, 20, 12, 40, 20, 407, DateTimeKind.Local).AddTicks(3581), "pin text you pig text numberless pig well-made one walk " });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Author", "Content", "Tag", "TimePosted", "Title" },
                values: new object[] { "worried naive ", "three pin walk pin pin pin pin else two pig three numberless ten you one naive one tired industrious tired anything three pig something worried pig paragragh something ten paragragh worried well-made love walk well-made else walk fix you something fix pig paragragh numberless pig thick you something text ten numberless love love anything tired body text one you paragragh pig tired you three worried two walk one something love industrious worried bye fix anything else industrious walk thick ten thick industrious anything pin else pig thick anything ten well-made body else one worried thick numberless tired you anything text ", "body three else anything ", new DateTime(2022, 6, 20, 12, 40, 20, 407, DateTimeKind.Local).AddTicks(3848), "tired else bye well-made industrious something well-made body naive thick " });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Author", "Content", "Tag", "TimePosted", "Title" },
                values: new object[] { "naive hello ", "hello you cent three walk well-made ten tired you fix two thick industrious you pig cent pig else something pin industrious industrious thick paragragh anything anything body numberless thick hello fix tired paragragh walk one hello paragragh industrious hello you one two you walk naive anything thick numberless fix text walk one bye thick numberless thick one tired love pig pig text pin fix body cent something love thick ten fix cent cent text fix bye cent worried fix pin two you two something well-made you you tired worried walk anything thick walk walk two love one hello walk cent ", "text else pig pin ", new DateTime(2022, 6, 20, 12, 40, 20, 407, DateTimeKind.Local).AddTicks(4092), "naive fix body paragragh you hello walk worried thick cent " });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Author", "Content", "Tag", "TimePosted", "Title" },
                values: new object[] { "anything text ", "industrious tired cent industrious well-made well-made paragragh worried three numberless body body worried two anything else you pig else worried walk anything thick well-made bye worried bye one pin bye tired naive bye walk paragragh cent naive worried you industrious text one three walk numberless tired something pig something hello bye else cent one cent cent numberless anything one worried text cent industrious naive else something fix you love paragragh thick ten thick two tired else worried worried cent worried hello walk anything one pin text cent anything numberless two worried tired one ten thick bye fix hello one fix ", "fix love worried paragragh ", new DateTime(2022, 6, 20, 12, 40, 20, 407, DateTimeKind.Local).AddTicks(4535), "thick ten you one cent tired anything love else thick " });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Author", "Content", "Tag", "TimePosted", "Title" },
                values: new object[] { "naive you ", "well-made one naive anything hello bye love pig two body well-made two well-made you walk something one paragragh walk paragragh ten numberless fix pig tired two ten one bye walk else industrious cent three well-made you cent something anything tired love cent pig worried hello paragragh naive pig pig tired thick body well-made love paragragh walk worried pin one love text naive paragragh tired naive worried tired tired something pig fix anything ten ten you two ten pig ten something well-made bye well-made worried love else love pig industrious numberless ten cent industrious industrious text one tired love three thick ", "something pin body fix ", new DateTime(2022, 6, 20, 12, 40, 20, 407, DateTimeKind.Local).AddTicks(5203), "naive one cent bye numberless you paragragh fix something bye " });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Author", "Content", "Tag", "TimePosted", "Title" },
                values: new object[] { "cent ten ", "industrious two bye something well-made worried naive two bye pig three text industrious thick cent you fix tired naive thick love walk worried tired hello tired thick anything two anything you cent hello hello hello three naive walk worried walk two numberless hello text two fix thick two anything one tired love two well-made naive love hello worried worried three ten tired body one thick else well-made two you thick one well-made well-made industrious paragragh ten paragragh fix three numberless numberless paragragh body numberless one numberless two walk worried two thick walk numberless pig fix walk industrious you naive anything ", "else one body worried ", new DateTime(2022, 6, 20, 12, 40, 20, 407, DateTimeKind.Local).AddTicks(5860), "cent fix anything worried fix three well-made you something walk " });

            migrationBuilder.InsertData(
                table: "Images",
                columns: new[] { "Id", "Url" },
                values: new object[,]
                {
                    { 1, "assets/img/shop/product-single/1.webp" },
                    { 3, "assets/img/shop/product-single/3.webp" },
                    { 4, "assets/img/shop/product-single/4.webp" },
                    { 2, "assets/img/shop/product-single/2.webp" }
                });

            migrationBuilder.UpdateData(
                table: "OHProducts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "OrderHistoryId", "ProductId", "Quantity" },
                values: new object[] { 3, 25, 11 });

            migrationBuilder.UpdateData(
                table: "OHProducts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "OrderHistoryId", "ProductId", "Quantity" },
                values: new object[] { 3, 25, 4 });

            migrationBuilder.UpdateData(
                table: "OHProducts",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "OrderHistoryId", "ProductId", "Quantity" },
                values: new object[] { 3, 17, 4 });

            migrationBuilder.UpdateData(
                table: "OHProducts",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "OrderHistoryId", "ProductId", "Quantity" },
                values: new object[] { 2, 22, 3 });

            migrationBuilder.UpdateData(
                table: "OHProducts",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ProductId", "Quantity" },
                values: new object[] { 15, 3 });

            migrationBuilder.UpdateData(
                table: "OHProducts",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "OrderHistoryId", "ProductId", "Quantity" },
                values: new object[] { 4, 15, 19 });

            migrationBuilder.UpdateData(
                table: "OHProducts",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "OrderHistoryId", "ProductId", "Quantity" },
                values: new object[] { 2, 23, 17 });

            migrationBuilder.UpdateData(
                table: "OHProducts",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "ProductId", "Quantity" },
                values: new object[] { 24, 16 });

            migrationBuilder.UpdateData(
                table: "OHProducts",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "OrderHistoryId", "ProductId", "Quantity" },
                values: new object[] { 1, 4, 18 });

            migrationBuilder.UpdateData(
                table: "OHProducts",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "OrderHistoryId", "ProductId", "Quantity" },
                values: new object[] { 3, 11, 18 });

            migrationBuilder.UpdateData(
                table: "OHProducts",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "OrderHistoryId", "ProductId", "Quantity" },
                values: new object[] { 3, 17, 10 });

            migrationBuilder.UpdateData(
                table: "OHProducts",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "OrderHistoryId", "ProductId", "Quantity" },
                values: new object[] { 2, 4, 16 });

            migrationBuilder.UpdateData(
                table: "OHProducts",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "ProductId", "Quantity" },
                values: new object[] { 27, 5 });

            migrationBuilder.UpdateData(
                table: "OHProducts",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "OrderHistoryId", "ProductId", "Quantity" },
                values: new object[] { 4, 22, 4 });

            migrationBuilder.UpdateData(
                table: "OHProducts",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "OrderHistoryId", "ProductId", "Quantity" },
                values: new object[] { 3, 14, 3 });

            migrationBuilder.UpdateData(
                table: "OHProducts",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "OrderHistoryId", "ProductId", "Quantity" },
                values: new object[] { 1, 17, 11 });

            migrationBuilder.UpdateData(
                table: "OHProducts",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "OrderHistoryId", "ProductId", "Quantity" },
                values: new object[] { 4, 26, 1 });

            migrationBuilder.UpdateData(
                table: "OHProducts",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "OrderHistoryId", "ProductId", "Quantity" },
                values: new object[] { 4, 27, 5 });

            migrationBuilder.UpdateData(
                table: "OHProducts",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "ProductId", "Quantity" },
                values: new object[] { 3, 1 });

            migrationBuilder.UpdateData(
                table: "OHProducts",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "ProductId", "Quantity" },
                values: new object[] { 14, 14 });

            migrationBuilder.UpdateData(
                table: "OHProducts",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "OrderHistoryId", "ProductId", "Quantity" },
                values: new object[] { 2, 27, 4 });

            migrationBuilder.UpdateData(
                table: "OHProducts",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "OrderHistoryId", "ProductId", "Quantity" },
                values: new object[] { 2, 23, 3 });

            migrationBuilder.UpdateData(
                table: "OHProducts",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "OrderHistoryId", "ProductId", "Quantity" },
                values: new object[] { 3, 24, 8 });

            migrationBuilder.UpdateData(
                table: "OHProducts",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "ProductId", "Quantity" },
                values: new object[] { 25, 12 });

            migrationBuilder.UpdateData(
                table: "OHProducts",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "OrderHistoryId", "ProductId" },
                values: new object[] { 3, 19 });

            migrationBuilder.UpdateData(
                table: "OHProducts",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "OrderHistoryId", "ProductId", "Quantity" },
                values: new object[] { 3, 27, 7 });

            migrationBuilder.UpdateData(
                table: "OHProducts",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "OrderHistoryId", "ProductId", "Quantity" },
                values: new object[] { 3, 1, 11 });

            migrationBuilder.UpdateData(
                table: "OHProducts",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "OrderHistoryId", "ProductId", "Quantity" },
                values: new object[] { 2, 22, 10 });

            migrationBuilder.UpdateData(
                table: "OHProducts",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "OrderHistoryId", "ProductId", "Quantity" },
                values: new object[] { 4, 28, 13 });

            migrationBuilder.UpdateData(
                table: "OHProducts",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "OrderHistoryId", "ProductId", "Quantity" },
                values: new object[] { 1, 23, 1 });

            migrationBuilder.UpdateData(
                table: "OHProducts",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "OrderHistoryId", "ProductId", "Quantity" },
                values: new object[] { 4, 10, 9 });

            migrationBuilder.UpdateData(
                table: "OHProducts",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "ProductId", "Quantity" },
                values: new object[] { 15, 17 });

            migrationBuilder.UpdateData(
                table: "OHProducts",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "ProductId", "Quantity" },
                values: new object[] { 10, 14 });

            migrationBuilder.UpdateData(
                table: "OHProducts",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "OrderHistoryId", "ProductId", "Quantity" },
                values: new object[] { 4, 12, 15 });

            migrationBuilder.UpdateData(
                table: "OHProducts",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "OrderHistoryId", "ProductId", "Quantity" },
                values: new object[] { 1, 19, 1 });

            migrationBuilder.UpdateData(
                table: "OHProducts",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "ProductId", "Quantity" },
                values: new object[] { 1, 6 });

            migrationBuilder.UpdateData(
                table: "OHProducts",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "OrderHistoryId", "ProductId", "Quantity" },
                values: new object[] { 1, 2, 3 });

            migrationBuilder.UpdateData(
                table: "OHProducts",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "OrderHistoryId", "ProductId", "Quantity" },
                values: new object[] { 3, 1, 9 });

            migrationBuilder.UpdateData(
                table: "OHProducts",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "OrderHistoryId", "ProductId", "Quantity" },
                values: new object[] { 1, 28, 3 });

            migrationBuilder.UpdateData(
                table: "OHProducts",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "ProductId", "Quantity" },
                values: new object[] { 13, 16 });

            migrationBuilder.UpdateData(
                table: "OrderHistories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CouponCode", "TimeCreated", "ToLocation" },
                values: new object[] { "kcfhHA", new DateTime(2022, 6, 20, 12, 40, 20, 412, DateTimeKind.Local).AddTicks(9522), "naive industrious ten pin tired you pin naive numberless numberless " });

            migrationBuilder.UpdateData(
                table: "OrderHistories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CouponCode", "TimeCreated", "ToLocation" },
                values: new object[] { "bRBUL7", new DateTime(2022, 6, 20, 12, 40, 20, 413, DateTimeKind.Local).AddTicks(240), "else one text three worried love love well-made industrious tired " });

            migrationBuilder.UpdateData(
                table: "OrderHistories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CouponCode", "TimeCreated", "ToLocation" },
                values: new object[] { "EYdIql", new DateTime(2022, 6, 20, 12, 40, 20, 413, DateTimeKind.Local).AddTicks(271), "hello naive you anything bye fix ten cent you pin " });

            migrationBuilder.UpdateData(
                table: "OrderHistories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CouponCode", "TimeCreated", "ToLocation" },
                values: new object[] { "2HVYho", new DateTime(2022, 6, 20, 12, 40, 20, 413, DateTimeKind.Local).AddTicks(294), "anything something ten anything love pig love fix well-made bye " });

            migrationBuilder.UpdateData(
                table: "OrderHistories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CouponCode", "TimeCreated", "ToLocation" },
                values: new object[] { "480oz4", new DateTime(2022, 6, 20, 12, 40, 20, 413, DateTimeKind.Local).AddTicks(321), "thick three ten else fix walk fix well-made paragragh bye " });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BrandId", "CategoryId", "Code", "Description", "InStock", "Name", "Overeview", "Total" },
                values: new object[] { 2, 4, "5H8t3r", "cent naive thick paragragh hello bye something walk industrious fix walk body one something industrious two walk body bye hello paragragh anything cent else anything pin body thick industrious pin cent text text three two tired three text body walk naive pig paragragh you pin walk tired worried fix pin ", 436, "love tired fix love ", "paragragh walk hello fix text body bye three naive well-made cent body paragragh bye two love walk text cent one ", 517 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CategoryId", "Code", "Description", "InStock", "Name", "Overeview", "Price", "SalesOff", "Total" },
                values: new object[] { 3, "yPKqyc", "hello body pin naive well-made worried you bye else industrious cent else else bye anything something industrious paragragh walk worried walk you one thick numberless you pin industrious three text naive pin else pig pin pig paragragh else fix something two bye something numberless well-made bye two cent ten body ", 1733, "one well-made worried numberless ", "pig paragragh pin else ten hello pin naive worried fix cent well-made else text two three anything industrious tired body ", 730f, 3, 465 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Code", "Description", "InStock", "Name", "Overeview", "Price", "SalesOff", "Total" },
                values: new object[] { "wjbnRU", "cent tired hello hello three worried tired industrious one paragragh three else pig worried bye walk text worried industrious naive love pig text industrious naive anything bye paragragh pin well-made one three body else body two you pin three paragragh pin walk numberless ten love one walk body pin industrious ", 1580, "industrious three else anything ", "body tired hello else you tired naive two one text well-made bye industrious bye pig love pig love body worried ", 170f, 9, 372 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "BrandId", "CategoryId", "Code", "Description", "InStock", "Name", "Overeview", "Price", "SalesOff", "Total" },
                values: new object[] { 1, 1, "P2rZJ4", "pin thick tired industrious you hello three you cent thick worried paragragh something love you two love numberless paragragh hello three hello naive two something ten walk tired walk numberless you worried well-made ten body naive walk pin numberless love love tired worried anything bye bye pig naive love worried ", 390, "two something numberless pig ", "else something worried anything naive text naive naive naive something well-made you walk paragragh text one paragragh anything numberless tired ", 680f, 8, 1423 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "BrandId", "CategoryId", "Code", "Description", "InStock", "Name", "Overeview", "Price", "SalesOff", "Total" },
                values: new object[] { 2, 1, "khCydG", "anything something cent fix pig tired bye anything two fix text pin hello hello body fix fix pig paragragh love else naive body cent walk else text thick two thick love something paragragh pig industrious love else hello pig anything pig numberless pig walk text naive you two worried numberless ", 652, "well-made fix text worried ", "bye three you one thick three pin you something tired naive thick industrious worried bye you one industrious thick cent ", 450f, 7, 627 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "BrandId", "CategoryId", "Code", "Description", "InStock", "Name", "Overeview", "Price", "SalesOff", "Total" },
                values: new object[] { 3, 1, "fmpAOl", "naive walk ten fix cent something walk else well-made worried text pin something something numberless text cent pin well-made hello well-made bye body love two you one thick three one anything three naive body paragragh numberless tired anything anything worried paragragh thick bye fix anything pin worried three three industrious ", 553, "else cent thick well-made ", "pig cent tired worried ten body pin ten one something pin paragragh hello love ten worried walk one you two ", 930f, 6, 520 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CategoryId", "Code", "Description", "InStock", "Name", "Overeview", "Price", "SalesOff", "Total" },
                values: new object[] { 5, "UwP41R", "bye you else body ten hello industrious else pin love bye three well-made numberless pig hello you three ten text cent worried text fix ten text body pig hello thick thick industrious numberless fix thick three body you walk three cent tired industrious love thick cent pig you pig naive ", 1926, "industrious love three text ", "text something you body naive well-made numberless worried paragragh you pin one anything two ten paragragh bye paragragh something paragragh ", 820f, 14, 1401 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "BrandId", "CategoryId", "Code", "Description", "InStock", "Name", "Overeview", "Price", "SalesOff", "Total" },
                values: new object[] { 3, 3, "jYLOMF", "worried worried love body something paragragh text worried naive thick walk fix thick anything fix fix walk ten ten three numberless pin tired three thick thick cent two else fix ten body industrious three pig two body text love paragragh pig bye something cent bye two hello worried cent body ", 741, "bye ten cent something ", "paragragh three else hello bye body something anything bye paragragh numberless three numberless two tired numberless pin cent one else ", 860f, 10, 520 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "BrandId", "CategoryId", "Code", "Description", "InStock", "Name", "Overeview", "Price", "SalesOff", "Total" },
                values: new object[] { 3, 2, "mHtBmQ", "something thick walk cent love anything industrious two cent cent numberless text one pig walk body hello thick bye thick naive naive cent industrious text hello text love tired one else paragragh naive pin two body pig hello anything bye tired pig love thick hello else else pin one you ", 383, "two industrious fix you ", "thick bye something three hello hello you numberless one one tired well-made pig paragragh love pin fix text one one ", 520f, 3, 266 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "BrandId", "CategoryId", "Code", "Description", "InStock", "Name", "Overeview", "Price", "SalesOff", "Total" },
                values: new object[] { 3, 2, "PSKJbY", "one worried paragragh pig three worried pin one pig worried industrious well-made love cent pig worried naive pig well-made hello else walk walk well-made three thick one tired two bye anything text two you paragragh well-made ten thick tired bye pin love text three you walk anything fix ten else ", 507, "walk well-made walk something ", "tired one else well-made else pin tired body body pin fix three two numberless ten text pig hello pin two ", 410f, 8, 102 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CategoryId", "Code", "Description", "InStock", "Name", "Overeview", "Price", "SalesOff", "Total" },
                values: new object[] { 2, "4W3gcc", "hello numberless pin thick thick well-made you anything anything tired anything anything else one one body pin paragragh naive hello industrious one numberless industrious love bye walk love numberless bye body numberless else well-made you two anything pin else industrious pin anything ten numberless love one text paragragh numberless tired ", 1137, "two something anything ten ", "something anything tired pin naive anything you text hello ten hello tired naive something tired industrious something you industrious anything ", 80f, 9, 1766 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "BrandId", "CategoryId", "Code", "Description", "InStock", "Name", "Overeview", "Price", "Total" },
                values: new object[] { 2, 5, "0583e0", "hello numberless tired body something numberless one ten pin anything numberless naive else body pig pig industrious industrious thick industrious ten naive cent else worried body else cent numberless something pig walk pin pig tired walk pin text naive pin fix pig well-made bye industrious fix naive well-made numberless hello ", 606, "numberless numberless you fix ", "well-made fix else body numberless body industrious well-made hello cent ten body well-made naive ten fix ten else fix industrious ", 330f, 1437 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "BrandId", "CategoryId", "Code", "Description", "InStock", "Name", "Overeview", "Price", "SalesOff", "Total" },
                values: new object[] { 3, 5, "UJ4szn", "anything else body well-made pig naive love text something numberless one three love pig industrious anything else anything walk anything anything anything else three numberless well-made worried worried anything body well-made cent industrious industrious you else tired naive three anything bye numberless text one anything well-made ten pig two text ", 720, "tired thick paragragh tired ", "naive thick one industrious well-made tired paragragh naive something hello industrious something one text else tired worried two pig one ", 720f, 5, 421 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "BrandId", "Code", "Description", "InStock", "Name", "Overeview", "Price", "SalesOff", "Total" },
                values: new object[] { 4, "m79ILB", "ten paragragh hello anything else pig worried ten paragragh paragragh pig industrious paragragh one hello numberless you worried cent naive pin numberless you text text love well-made thick one naive walk bye thick text two pin pig fix ten well-made well-made naive bye else something cent naive naive naive fix ", 103, "cent paragragh paragragh something ", "paragragh paragragh thick fix bye thick worried pig fix you well-made industrious love three hello love one well-made well-made industrious ", 940f, 13, 866 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CategoryId", "Code", "Description", "InStock", "Name", "Overeview", "SalesOff", "Total" },
                values: new object[] { 4, "DsyvMx", "fix fix else love walk bye well-made body well-made hello industrious industrious worried three fix pig naive love else hello pin worried three thick cent one else something well-made numberless paragragh worried numberless paragragh naive well-made thick industrious pig well-made walk tired else two two hello worried well-made worried well-made ", 894, "pin paragragh well-made fix ", "text numberless body hello ten hello thick anything industrious else one well-made industrious one bye anything pin industrious thick ten ", 13, 398 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "BrandId", "CategoryId", "Code", "Description", "InStock", "Name", "Overeview", "Price", "SalesOff", "Total" },
                values: new object[] { 3, 5, "vUlSrm", "text worried body body else industrious tired something fix two else bye love something fix paragragh paragragh anything naive thick one numberless else worried you thick bye pin cent thick worried text text worried well-made love thick bye bye three three anything anything something anything anything thick worried well-made else ", 1366, "three two text cent ", "pin thick bye cent you well-made two tired well-made something fix well-made ten text fix fix hello pin fix two ", 690f, 1, 1131 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Code", "Description", "InStock", "Name", "Overeview", "Price", "SalesOff", "Total" },
                values: new object[] { "Bne1GR", "pin something worried something tired hello tired well-made well-made fix fix love worried body worried something paragragh text pig hello industrious cent one thick bye fix text worried well-made cent something body tired anything anything cent two paragragh cent you ten cent well-made numberless cent well-made you cent three thick ", 393, "one tired hello numberless ", "ten text thick one tired walk fix bye bye something industrious pin cent anything pin tired paragragh hello else one ", 640f, 3, 189 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CategoryId", "Code", "Description", "InStock", "Name", "Overeview", "Price", "SalesOff", "Total" },
                values: new object[] { 3, "c0EtF5", "ten cent hello industrious industrious love else well-made industrious one walk walk pig text paragragh text worried three naive else bye three one bye anything two one three thick pig anything industrious bye walk else pig paragragh anything you cent pig pig pig worried text text walk hello bye love ", 1096, "ten well-made body numberless ", "hello walk numberless body pin body bye thick else anything you hello walk pig one bye naive you one two ", 380f, 13, 1068 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "BrandId", "CategoryId", "Code", "Description", "InStock", "Name", "Overeview", "Price", "SalesOff", "Total" },
                values: new object[] { 3, 1, "E8n6Je", "bye something worried else else ten ten tired three fix tired fix bye two numberless worried tired numberless you walk one thick bye three fix walk worried anything worried well-made two thick you walk two pin anything tired ten cent thick one thick you three industrious you walk cent well-made ", 1185, "naive love love three ", "else numberless numberless fix anything cent anything cent thick well-made one tired three walk thick numberless pig bye you tired ", 660f, 10, 538 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CategoryId", "Code", "Description", "InStock", "Name", "Overeview", "Price", "SalesOff", "Total" },
                values: new object[] { 1, "0KHSOb", "ten walk thick tired you something cent thick hello bye well-made ten numberless ten one two cent worried pin else body three love three worried bye pig you worried paragragh industrious tired body bye pig naive body two worried two love you pig naive ten well-made one walk ten paragragh ", 1740, "else love pig one ", "one naive pin pin walk pin well-made paragragh three pin pin something pin naive naive anything ten you two thick ", 740f, 14, 1321 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "BrandId", "CategoryId", "Code", "Description", "InStock", "Name", "Overeview", "Price", "SalesOff", "Total" },
                values: new object[] { 2, 5, "X6VhPZ", "bye pin worried naive body tired thick text walk two else one love you tired numberless text two worried cent something fix worried naive thick ten bye naive hello pig cent love text body naive ten tired cent walk walk walk pig walk walk thick pin else worried hello you ", 509, "thick well-made walk paragragh ", "three bye bye walk something one pin fix three numberless one one numberless you anything numberless industrious thick pin fix ", 350f, 12, 1038 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "BrandId", "CategoryId", "Code", "Description", "InStock", "Name", "Overeview", "Price", "SalesOff", "Total" },
                values: new object[] { 2, 5, "yF3x7M", "two love cent well-made you two walk pin pig walk numberless well-made three bye walk ten one love well-made three industrious naive you hello love body three two numberless one cent else pin paragragh well-made anything text pig paragragh numberless naive thick something paragragh pig body industrious fix worried thick ", 671, "you pin well-made anything ", "three you one something something one tired you anything naive walk you body thick worried thick three two anything else ", 790f, 1, 1973 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "BrandId", "CategoryId", "Code", "Description", "InStock", "Name", "Overeview", "Price", "SalesOff", "Total" },
                values: new object[] { 1, 2, "jQ9sY4", "naive love cent body anything body you three naive text tired you text you text pin cent love pig bye love cent something three one three bye hello pin thick worried well-made body love numberless thick you naive naive industrious thick pig love ten naive ten fix pig cent love ", 814, "paragragh two anything paragragh ", "well-made numberless pig pig numberless pig worried cent hello paragragh text cent cent you you tired fix text paragragh cent ", 240f, 3, 1235 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "BrandId", "CategoryId", "Code", "Description", "InStock", "Name", "Overeview", "Price", "SalesOff", "Total" },
                values: new object[] { 3, 1, "TKPVZG", "love paragragh bye love worried one you well-made something anything fix you walk cent you two tired three paragragh tired industrious walk numberless text love tired three something paragragh walk industrious else love body pig worried naive body walk one anything pig two walk worried tired something naive love paragragh ", 780, "fix tired three body ", "you love love naive worried three bye walk cent two pig love bye ten thick well-made naive worried industrious one ", 840f, 10, 994 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "BrandId", "CategoryId", "Code", "Description", "InStock", "Name", "Overeview", "Price", "SalesOff", "Total" },
                values: new object[] { 4, 4, "doqy9t", "pig worried bye something hello bye body hello three else ten cent thick thick naive tired hello worried hello tired three walk well-made else pin three walk bye body well-made bye bye numberless walk hello you text walk pig ten fix worried thick ten pin hello hello walk cent naive ", 988, "text pig hello fix ", "numberless walk love paragragh pig fix something cent hello ten something love two hello paragragh hello paragragh body thick something ", 40f, 14, 1270 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "BrandId", "CategoryId", "Code", "Description", "InStock", "Name", "Overeview", "Price", "SalesOff", "Total" },
                values: new object[] { 1, 2, "wF2zmn", "pin worried fix thick numberless love two something bye anything something paragragh something paragragh thick thick naive paragragh something ten paragragh three body industrious well-made fix worried numberless naive pig worried love tired well-made well-made anything text bye thick three something well-made cent pin numberless numberless ten anything walk body ", 4, "pig hello bye two ", "industrious worried you tired text well-made love else body text three fix else one naive body thick something walk you ", 650f, 6, 1259 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "BrandId", "CategoryId", "Code", "Description", "InStock", "Name", "Overeview", "Price", "SalesOff", "Total" },
                values: new object[] { 4, 4, "JNJWHl", "love body industrious pin ten thick tired paragragh worried industrious anything anything walk pig text tired fix ten naive three well-made walk well-made something one walk naive anything body bye text anything one pig you thick pig hello two pig fix two else numberless one else paragragh paragragh hello walk ", 54, "text one pig walk ", "thick tired bye tired something three thick ten worried bye something anything pin cent something walk love thick something bye ", 760f, 12, 243 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CategoryId", "Code", "Description", "InStock", "Name", "Overeview", "Price", "SalesOff", "Total" },
                values: new object[] { 5, "Roscbl", "anything text body well-made else three numberless pin pig body three pin else two pig ten tired worried industrious three you pin fix something industrious bye thick one worried fix pin pin love paragragh numberless else anything industrious else pig you worried paragragh fix three bye bye bye two else ", 1359, "pin hello ten something ", "tired anything thick naive worried anything cent pin tired else one walk industrious you hello two fix ten paragragh something ", 200f, 13, 687 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "BrandId", "CategoryId", "Code", "Description", "InStock", "Name", "Overeview", "Price", "SalesOff", "Total" },
                values: new object[] { 4, 5, "s5SWKI", "naive anything pin worried thick two you bye ten thick pig you hello pin thick one body pin three you three love pin body else pig two two worried two two tired two well-made hello walk anything tired walk well-made thick anything pin bye hello thick one paragragh walk fix ", 1274, "hello bye love three ", "worried anything one two love pig hello three you paragragh well-made pin ten two body love anything hello well-made text ", 900f, 5, 1854 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "BrandId", "CategoryId", "Code", "Description", "InStock", "Name", "Overeview", "Price", "SalesOff", "Total" },
                values: new object[] { 4, 5, "1c6DcG", "paragragh well-made tired pin well-made you anything worried well-made numberless one three paragragh two numberless naive walk numberless three thick worried numberless three anything two fix one cent thick cent anything else hello worried industrious numberless three bye you text two something pig hello thick numberless paragragh you well-made tired ", 1770, "pin naive tired walk ", "pig walk bye cent two one ten one bye you love hello hello pig paragragh three thick text text else ", 580f, 5, 719 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Comment", "ProductId", "Rate", "TimePosted" },
                values: new object[] { "text tired fix fix ten naive ten paragragh numberless industrious love naive two hello pin hello text worried industrious ten bye ten thick two one text else you anything two ", 19, 3, new DateTime(2022, 6, 20, 12, 40, 20, 425, DateTimeKind.Local).AddTicks(1772) });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Comment", "ProductId", "Rate", "TimePosted" },
                values: new object[] { "worried something tired something tired industrious industrious tired ten love walk thick hello text worried tired well-made anything love cent ten two pin you numberless love love industrious something you ", 25, 4, new DateTime(2022, 6, 20, 12, 40, 20, 425, DateTimeKind.Local).AddTicks(2439) });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Comment", "ProductId", "TimePosted" },
                values: new object[] { "fix numberless cent body numberless thick industrious something numberless text body something one body industrious love two pig else pin paragragh fix pin one something bye two one walk pin ", 22, new DateTime(2022, 6, 20, 12, 40, 20, 425, DateTimeKind.Local).AddTicks(2483) });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Comment", "ProductId", "Rate", "TimePosted" },
                values: new object[] { "numberless paragragh you tired bye cent naive you three walk worried industrious two thick thick numberless paragragh pin bye thick walk three text pin numberless something thick one paragragh one ", 13, 4, new DateTime(2022, 6, 20, 12, 40, 20, 425, DateTimeKind.Local).AddTicks(2520) });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Comment", "ProductId", "TimePosted" },
                values: new object[] { "anything industrious two ten numberless else naive tired body ten cent one naive anything body well-made worried one ten walk bye tired else walk numberless you thick you ten paragragh ", 5, new DateTime(2022, 6, 20, 12, 40, 20, 425, DateTimeKind.Local).AddTicks(2551) });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Comment", "ProductId", "TimePosted" },
                values: new object[] { "ten industrious worried bye ten two body numberless else industrious tired fix else cent text worried something worried fix walk paragragh walk bye one tired thick text cent naive tired ", 19, new DateTime(2022, 6, 20, 12, 40, 20, 425, DateTimeKind.Local).AddTicks(2590) });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Comment", "ProductId", "Rate", "TimePosted" },
                values: new object[] { "something you paragragh walk ten hello fix one two text bye tired body well-made one you walk walk pig else pig anything bye two one one industrious fix love ten ", 22, 1, new DateTime(2022, 6, 20, 12, 40, 20, 425, DateTimeKind.Local).AddTicks(2626) });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Comment", "ProductId", "TimePosted" },
                values: new object[] { "fix cent ten paragragh tired hello naive cent else you two numberless else worried one worried ten three body industrious worried body you text thick cent something well-made thick pin ", 20, new DateTime(2022, 6, 20, 12, 40, 20, 425, DateTimeKind.Local).AddTicks(2658) });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Comment", "ProductId", "Rate", "TimePosted" },
                values: new object[] { "anything well-made anything three hello ten hello text you industrious body tired naive fix anything fix body body something numberless three else cent hello well-made industrious thick well-made love industrious ", 25, 4, new DateTime(2022, 6, 20, 12, 40, 20, 425, DateTimeKind.Local).AddTicks(2690) });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Comment", "ProductId", "TimePosted" },
                values: new object[] { "walk three industrious tired cent paragragh else pin naive well-made walk numberless body bye thick anything walk cent well-made thick tired something anything pig industrious hello two thick tired well-made ", 25, new DateTime(2022, 6, 20, 12, 40, 20, 425, DateTimeKind.Local).AddTicks(2726) });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Comment", "ProductId", "Rate", "TimePosted" },
                values: new object[] { "well-made thick walk bye thick bye pig well-made naive something text two hello worried bye paragragh paragragh fix pin else three hello well-made one love three naive text worried pig ", 17, 4, new DateTime(2022, 6, 20, 12, 40, 20, 425, DateTimeKind.Local).AddTicks(2752) });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Comment", "ProductId", "Rate", "TimePosted" },
                values: new object[] { "thick tired ten something pig three one text love body numberless ten anything thick three body anything love something anything walk cent anything ten worried else something one cent two ", 4, 1, new DateTime(2022, 6, 20, 12, 40, 20, 425, DateTimeKind.Local).AddTicks(2784) });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Comment", "ProductId", "TimePosted" },
                values: new object[] { "pin two walk numberless naive you fix you you naive ten love tired fix two bye body thick paragragh pig something something you walk fix pin bye something walk pin ", 16, new DateTime(2022, 6, 20, 12, 40, 20, 425, DateTimeKind.Local).AddTicks(2821) });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Comment", "ProductId", "Rate", "TimePosted" },
                values: new object[] { "love pin paragragh thick worried paragragh something pin tired paragragh numberless you thick industrious thick else numberless industrious one three love three tired tired text pin something naive tired ten ", 20, 2, new DateTime(2022, 6, 20, 12, 40, 20, 425, DateTimeKind.Local).AddTicks(2869) });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Comment", "ProductId", "TimePosted" },
                values: new object[] { "ten bye pin tired text well-made thick walk text text love you one body three naive something three two industrious hello text tired pin something naive something worried worried naive ", 19, new DateTime(2022, 6, 20, 12, 40, 20, 425, DateTimeKind.Local).AddTicks(2914) });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Comment", "ProductId", "Rate", "TimePosted" },
                values: new object[] { "numberless walk worried love industrious body body ten text naive worried worried body bye love text cent pig else one walk two tired industrious industrious body ten thick two well-made ", 3, 3, new DateTime(2022, 6, 20, 12, 40, 20, 425, DateTimeKind.Local).AddTicks(2951) });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Comment", "ProductId", "Rate", "TimePosted" },
                values: new object[] { "industrious well-made three naive love body well-made else love ten thick worried two pig numberless industrious hello anything anything three something numberless tired hello three pin paragragh industrious cent two ", 6, 2, new DateTime(2022, 6, 20, 12, 40, 20, 425, DateTimeKind.Local).AddTicks(2995) });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Comment", "ProductId", "Rate", "TimePosted" },
                values: new object[] { "well-made paragragh pin paragragh else bye three walk pin pin text fix walk well-made hello three anything else love else pig well-made paragragh numberless three thick bye three walk cent ", 14, 2, new DateTime(2022, 6, 20, 12, 40, 20, 425, DateTimeKind.Local).AddTicks(3046) });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Comment", "ProductId", "Rate", "TimePosted" },
                values: new object[] { "two love love love well-made pig fix body industrious paragragh three something thick anything pig one bye you worried bye text bye walk pin body body you naive body body ", 29, 2, new DateTime(2022, 6, 20, 12, 40, 20, 425, DateTimeKind.Local).AddTicks(3089) });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Comment", "ProductId", "Rate", "TimePosted" },
                values: new object[] { "bye fix love naive tired something one something walk you two one fix industrious text you industrious body pig naive pin anything one numberless else love love pig tired worried ", 1, 4, new DateTime(2022, 6, 20, 12, 40, 20, 425, DateTimeKind.Local).AddTicks(3120) });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Comment", "ProductId", "Rate", "TimePosted" },
                values: new object[] { "paragragh anything industrious you industrious anything cent you naive bye pig three you else two you well-made pin well-made pin text else love one you ten something one ten pig ", 7, 1, new DateTime(2022, 6, 20, 12, 40, 20, 425, DateTimeKind.Local).AddTicks(3152) });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Comment", "ProductId", "TimePosted" },
                values: new object[] { "you hello ten bye pin ten three worried three tired body bye else text worried pin pig body pin tired love body tired numberless numberless bye pin pig pig two ", 3, new DateTime(2022, 6, 20, 12, 40, 20, 425, DateTimeKind.Local).AddTicks(3178) });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Comment", "ProductId", "Rate", "TimePosted" },
                values: new object[] { "pig cent anything fix love numberless you hello cent industrious cent pig else thick you cent something something well-made three well-made three walk you numberless paragragh fix hello paragragh bye ", 25, 1, new DateTime(2022, 6, 20, 12, 40, 20, 425, DateTimeKind.Local).AddTicks(3208) });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Comment", "ProductId", "TimePosted" },
                values: new object[] { "naive you walk hello paragragh text worried walk numberless one walk ten three worried thick text something love else something thick well-made three hello anything numberless thick worried something tired ", 21, new DateTime(2022, 6, 20, 12, 40, 20, 425, DateTimeKind.Local).AddTicks(3239) });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Comment", "ProductId", "Rate", "TimePosted" },
                values: new object[] { "well-made body anything ten worried tired tired anything bye numberless paragragh else two fix industrious anything thick paragragh three you love walk love numberless industrious paragragh bye text thick pin ", 17, 3, new DateTime(2022, 6, 20, 12, 40, 20, 425, DateTimeKind.Local).AddTicks(3270) });

            migrationBuilder.InsertData(
                table: "ImageProduct",
                columns: new[] { "ImagesId", "ProductsId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 3, 28 },
                    { 3, 27 },
                    { 3, 26 },
                    { 3, 25 },
                    { 3, 24 },
                    { 3, 23 },
                    { 3, 22 },
                    { 3, 21 },
                    { 3, 20 },
                    { 3, 19 },
                    { 3, 18 },
                    { 3, 17 },
                    { 3, 29 },
                    { 3, 16 },
                    { 3, 14 },
                    { 3, 13 },
                    { 3, 12 },
                    { 3, 11 },
                    { 3, 10 },
                    { 3, 9 },
                    { 3, 8 },
                    { 3, 7 },
                    { 3, 6 },
                    { 3, 5 },
                    { 3, 4 },
                    { 3, 3 },
                    { 3, 15 },
                    { 3, 2 },
                    { 3, 30 },
                    { 4, 2 },
                    { 4, 28 },
                    { 4, 27 },
                    { 4, 26 },
                    { 4, 25 },
                    { 4, 24 },
                    { 4, 23 },
                    { 4, 22 },
                    { 4, 21 },
                    { 4, 20 },
                    { 4, 19 },
                    { 4, 18 }
                });

            migrationBuilder.InsertData(
                table: "ImageProduct",
                columns: new[] { "ImagesId", "ProductsId" },
                values: new object[,]
                {
                    { 4, 17 },
                    { 4, 1 },
                    { 4, 16 },
                    { 4, 14 },
                    { 4, 13 },
                    { 4, 12 },
                    { 4, 11 },
                    { 4, 10 },
                    { 4, 9 },
                    { 4, 8 },
                    { 4, 7 },
                    { 4, 6 },
                    { 4, 5 },
                    { 4, 4 },
                    { 4, 3 },
                    { 4, 15 },
                    { 3, 1 },
                    { 2, 30 },
                    { 2, 29 },
                    { 1, 27 },
                    { 1, 26 },
                    { 1, 25 },
                    { 1, 24 },
                    { 1, 23 },
                    { 1, 22 },
                    { 1, 21 },
                    { 1, 20 },
                    { 1, 19 },
                    { 1, 18 },
                    { 1, 17 },
                    { 1, 16 },
                    { 1, 28 },
                    { 1, 15 },
                    { 1, 13 },
                    { 1, 12 },
                    { 1, 11 },
                    { 1, 10 },
                    { 1, 9 },
                    { 1, 8 },
                    { 1, 7 },
                    { 1, 6 },
                    { 1, 5 }
                });

            migrationBuilder.InsertData(
                table: "ImageProduct",
                columns: new[] { "ImagesId", "ProductsId" },
                values: new object[,]
                {
                    { 1, 4 },
                    { 1, 3 },
                    { 1, 2 },
                    { 1, 14 },
                    { 1, 29 },
                    { 1, 30 },
                    { 2, 1 },
                    { 2, 28 },
                    { 2, 27 },
                    { 2, 26 },
                    { 2, 25 },
                    { 2, 24 },
                    { 2, 23 },
                    { 2, 22 },
                    { 2, 21 },
                    { 2, 20 },
                    { 2, 19 },
                    { 2, 18 },
                    { 2, 17 },
                    { 2, 16 },
                    { 2, 15 },
                    { 2, 14 },
                    { 2, 13 },
                    { 2, 12 },
                    { 2, 11 },
                    { 2, 10 },
                    { 2, 9 },
                    { 2, 8 },
                    { 2, 7 },
                    { 2, 6 },
                    { 2, 5 },
                    { 2, 4 },
                    { 2, 3 },
                    { 2, 2 },
                    { 4, 29 },
                    { 4, 30 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ImageProduct_ProductsId",
                table: "ImageProduct",
                column: "ProductsId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ImageProduct");

            migrationBuilder.DropTable(
                name: "Images");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db12554843e5",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "5a130f9a-b673-4cb0-a21f-efe0d2647964", "ce7847ba-c96c-4513-8cf0-5575b56d66c0" });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Author", "Content", "Tag", "TimePosted", "Title" },
                values: new object[] { "body industrious ", "else bye thick love love else pig three paragragh numberless numberless cent bye two one three anything fix cent bye ten naive worried else something pig body pin you three pig anything tired two cent bye bye fix naive pig paragragh bye pig bye paragragh paragragh body worried well-made hello walk you industrious walk bye naive thick else well-made two else pig anything anything ten worried paragragh you fix pin pig hello worried you ten well-made numberless something you love pig love ten tired two thick love walk numberless love cent three cent text two fix two thick text something ", "else walk cent text ", new DateTime(2022, 6, 20, 9, 23, 47, 904, DateTimeKind.Local).AddTicks(2049), "you hello paragragh ten pig worried naive well-made paragragh pig " });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Author", "Content", "Tag", "TimePosted", "Title" },
                values: new object[] { "tired tired ", "bye bye naive tired well-made one three one love hello naive tired pig naive something text you pig love cent cent one well-made you two else ten ten something fix numberless paragragh tired ten anything industrious pin naive thick fix well-made worried thick text thick thick you industrious something bye three hello bye worried else anything well-made tired three two paragragh pin anything tired tired one body bye tired one else two you fix anything numberless walk one bye walk paragragh else cent worried two one well-made pig worried body three something hello ten else walk cent anything pig ten ", "else numberless three well-made ", new DateTime(2022, 6, 20, 9, 23, 47, 905, DateTimeKind.Local).AddTicks(712), "ten walk fix pig well-made paragragh ten tired pig three " });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Author", "Content", "Tag", "TimePosted", "Title" },
                values: new object[] { "thick cent ", "love three three three naive else tired fix paragragh numberless industrious industrious paragragh text love pig well-made paragragh ten thick body industrious pig thick body cent industrious bye walk industrious paragragh you body two thick thick worried fix hello text body well-made naive paragragh cent hello naive hello paragragh hello fix worried three fix industrious paragragh bye fix love worried one you walk something naive walk worried worried thick hello worried three well-made industrious tired paragragh ten one walk hello three something paragragh paragragh something two numberless bye bye two love else one naive worried industrious numberless text tired anything ", "worried pig naive something ", new DateTime(2022, 6, 20, 9, 23, 47, 905, DateTimeKind.Local).AddTicks(1088), "two industrious cent something paragragh text love two three industrious " });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Author", "Content", "Tag", "TimePosted", "Title" },
                values: new object[] { "numberless industrious ", "cent hello body paragragh worried something something paragragh two hello well-made anything anything naive else industrious worried well-made worried something hello fix tired pin text thick fix cent two anything tired cent pin walk you two text else three paragragh one thick else three tired anything ten paragragh else you three body pig something fix text numberless anything pin ten cent fix cent else numberless industrious you text tired industrious thick fix fix thick industrious worried ten one something paragragh one text bye else worried fix love thick paragragh walk bye paragragh something numberless one worried walk body ten pig ", "thick one one thick ", new DateTime(2022, 6, 20, 9, 23, 47, 905, DateTimeKind.Local).AddTicks(1417), "you text numberless thick body anything well-made tired pig anything " });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Author", "Content", "Tag", "TimePosted", "Title" },
                values: new object[] { "something tired ", "anything hello one something walk bye body walk one two ten thick three anything you ten ten naive else hello thick anything worried paragragh love body three tired well-made numberless fix thick three worried walk text fix worried industrious one industrious cent pin anything one walk industrious something tired cent text body two paragragh industrious body thick ten ten walk text one anything bye cent fix one else paragragh walk naive something well-made worried thick walk anything cent walk else you cent body industrious naive fix paragragh numberless pin walk naive something thick love three one walk hello ten industrious ", "you walk three numberless ", new DateTime(2022, 6, 20, 9, 23, 47, 905, DateTimeKind.Local).AddTicks(1769), "one you one naive anything hello naive pig walk fix " });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Author", "Content", "Tag", "TimePosted", "Title" },
                values: new object[] { "two cent ", "one love cent text text hello else bye love text pig thick naive three body fix thick industrious pin hello pig ten well-made pig else well-made else worried cent worried pin well-made one naive body thick pig numberless tired cent paragragh tired naive worried ten tired cent one anything something three hello industrious three well-made ten something you numberless fix ten bye thick text else numberless ten body love something worried pig text love paragragh you fix worried hello well-made industrious worried walk one naive bye worried paragragh industrious cent text tired pin anything thick walk numberless two fix paragragh ", "text pig hello bye ", new DateTime(2022, 6, 20, 9, 23, 47, 905, DateTimeKind.Local).AddTicks(2093), "paragragh hello tired you numberless walk two worried naive bye " });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Author", "Content", "Tag", "TimePosted", "Title" },
                values: new object[] { "you body ", "naive three tired worried you numberless you else you paragragh pig paragragh hello one love love else paragragh else anything fix you numberless three paragragh love else paragragh love walk body walk two else love well-made walk pig three bye well-made pin tired paragragh walk numberless ten bye hello hello three else worried tired well-made fix paragragh two tired numberless tired cent three else ten numberless worried ten text something something tired you worried else tired hello naive two text industrious cent pig thick tired naive industrious walk fix tired hello something you ten worried industrious cent paragragh body worried ", "three three three fix ", new DateTime(2022, 6, 20, 9, 23, 47, 905, DateTimeKind.Local).AddTicks(2408), "ten well-made numberless naive naive bye tired ten naive else " });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Author", "Content", "Tag", "TimePosted", "Title" },
                values: new object[] { "naive three ", "you hello well-made fix body anything thick pig worried pin hello worried pin two walk paragragh naive fix ten worried naive fix bye body one worried fix two fix numberless something walk three love walk text hello bye cent body two bye else three anything something anything worried something walk industrious one love three you fix anything pig love three hello ten three industrious thick pig pig worried tired bye pig three well-made three bye ten paragragh text pin anything cent naive anything well-made anything industrious naive pin body paragragh ten cent something thick hello three text one fix else ", "text worried anything well-made ", new DateTime(2022, 6, 20, 9, 23, 47, 905, DateTimeKind.Local).AddTicks(2729), "paragragh body paragragh love anything fix body else anything well-made " });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Author", "Content", "Tag", "TimePosted", "Title" },
                values: new object[] { "cent something ", "three two cent pig anything well-made cent something text industrious walk you thick else industrious walk well-made thick something naive two three naive else ten pig else love industrious one you text else naive body worried tired cent paragragh numberless else industrious tired three numberless tired else something pin hello body you pig naive one body well-made hello hello something one pig one cent cent hello walk pin else body ten numberless something one else bye fix hello two tired something numberless love something one pin tired thick paragragh body love you text industrious hello thick bye walk something one ", "anything numberless else anything ", new DateTime(2022, 6, 20, 9, 23, 47, 905, DateTimeKind.Local).AddTicks(3043), "pig pin naive industrious else well-made well-made anything else cent " });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Author", "Content", "Tag", "TimePosted", "Title" },
                values: new object[] { "pig two ", "fix anything something cent industrious love well-made else industrious you naive bye numberless naive body walk three pin walk body industrious three anything something paragragh something text text fix industrious pin else industrious body you two two hello hello naive tired well-made anything ten two paragragh else naive numberless thick anything three three pin fix something body pin tired fix worried one well-made pin love else fix industrious tired tired something thick one you two three love cent pin body body tired else numberless cent cent three numberless one pig two two numberless numberless walk love pin you you you ", "anything something paragragh one ", new DateTime(2022, 6, 20, 9, 23, 47, 905, DateTimeKind.Local).AddTicks(3386), "pig paragragh something numberless one ten love numberless pin bye " });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Author", "Content", "Tag", "TimePosted", "Title" },
                values: new object[] { "love numberless ", "love cent love else love tired one worried three numberless pig hello else paragragh three body well-made worried text thick fix pin naive two you love two anything bye ten two something one fix body three numberless well-made numberless you numberless ten three text pig ten well-made text ten ten one love text industrious pig love love well-made paragragh body ten two two pin fix something anything walk paragragh body you body numberless ten naive something cent something naive industrious two you cent text well-made paragragh you hello cent worried body ten hello numberless worried hello walk three well-made something ", "anything ten love one ", new DateTime(2022, 6, 20, 9, 23, 47, 905, DateTimeKind.Local).AddTicks(3748), "pig anything fix two paragragh three body fix hello paragragh " });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Author", "Content", "Tag", "TimePosted", "Title" },
                values: new object[] { "bye love ", "tired love ten text paragragh fix numberless something pin worried bye body else three fix thick thick else well-made one anything tired love else anything body else bye fix paragragh three three text well-made numberless naive pin one love tired body pig paragragh paragragh numberless three pig anything walk pig three well-made fix three you pin pin industrious paragragh ten ten one walk well-made pig else pig tired ten worried thick three three three two else something industrious something worried else text naive worried you one tired love naive pin pig you ten industrious something fix industrious bye fix thick ", "cent numberless anything pin ", new DateTime(2022, 6, 20, 9, 23, 47, 905, DateTimeKind.Local).AddTicks(4066), "ten anything ten something else walk anything else thick love " });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Author", "Content", "Tag", "TimePosted", "Title" },
                values: new object[] { "numberless text ", "walk numberless naive text well-made tired numberless paragragh three fix pin text walk worried one industrious else well-made two ten one well-made walk love worried three something numberless something thick tired cent pin bye walk numberless cent text industrious industrious ten tired walk hello pin paragragh tired industrious text pig well-made well-made pin pig bye anything three hello two fix paragragh pin worried hello pin three text else anything bye anything anything worried bye body worried numberless paragragh love thick tired one thick thick industrious cent cent text pin well-made walk text industrious something thick ten pig paragragh fix walk ", "cent cent naive pig ", new DateTime(2022, 6, 20, 9, 23, 47, 905, DateTimeKind.Local).AddTicks(4411), "fix two well-made well-made tired you hello something industrious industrious " });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Author", "Content", "Tag", "TimePosted", "Title" },
                values: new object[] { "ten thick ", "something paragragh thick love else body else else pig well-made love hello worried walk love pig pig something naive text tired cent pin three numberless else tired something naive worried industrious love two worried worried bye thick two one numberless numberless hello love industrious fix something thick industrious bye two ten body you naive ten hello text one ten body two numberless naive cent worried body love pin numberless naive anything text industrious well-made something anything naive anything tired fix pig pig industrious text naive worried anything pig thick else three three ten one hello body worried else anything fix ", "numberless cent else industrious ", new DateTime(2022, 6, 20, 9, 23, 47, 905, DateTimeKind.Local).AddTicks(4720), "industrious bye naive tired you industrious two well-made numberless walk " });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Author", "Content", "Tag", "TimePosted", "Title" },
                values: new object[] { "else naive ", "anything two love pin numberless two something thick bye industrious you bye paragragh something ten something body anything else anything well-made you numberless walk walk pig two hello bye pin else tired love walk numberless bye three you tired cent text else something one cent thick you pin industrious bye ten walk text paragragh numberless pin one something ten paragragh pin cent love hello tired hello else one two well-made ten industrious one hello well-made one well-made hello pin love tired one tired body well-made hello text worried worried pin body cent industrious something cent bye three worried cent text ", "fix three paragragh else ", new DateTime(2022, 6, 20, 9, 23, 47, 905, DateTimeKind.Local).AddTicks(5027), "you else else love cent ten worried thick else pig " });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Author", "Content", "Tag", "TimePosted", "Title" },
                values: new object[] { "numberless naive ", "ten love well-made anything ten one tired two pig something body anything naive text text industrious naive naive cent industrious worried one well-made one love fix something something well-made love one cent pig text paragragh body you walk you worried you three bye industrious text text anything paragragh ten else ten pig paragragh well-made naive walk two else numberless thick you ten thick fix industrious ten something two body text walk industrious fix pin cent pig numberless cent love cent bye love love two industrious well-made fix numberless thick one tired walk cent one well-made worried hello industrious pin you ", "ten numberless fix else ", new DateTime(2022, 6, 20, 9, 23, 47, 905, DateTimeKind.Local).AddTicks(5435), "something well-made hello bye ten industrious something anything naive hello " });

            migrationBuilder.UpdateData(
                table: "OHProducts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "OrderHistoryId", "ProductId", "Quantity" },
                values: new object[] { 1, 16, 17 });

            migrationBuilder.UpdateData(
                table: "OHProducts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "OrderHistoryId", "ProductId", "Quantity" },
                values: new object[] { 1, 23, 8 });

            migrationBuilder.UpdateData(
                table: "OHProducts",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "OrderHistoryId", "ProductId", "Quantity" },
                values: new object[] { 2, 21, 8 });

            migrationBuilder.UpdateData(
                table: "OHProducts",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "OrderHistoryId", "ProductId", "Quantity" },
                values: new object[] { 3, 11, 15 });

            migrationBuilder.UpdateData(
                table: "OHProducts",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ProductId", "Quantity" },
                values: new object[] { 17, 12 });

            migrationBuilder.UpdateData(
                table: "OHProducts",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "OrderHistoryId", "ProductId", "Quantity" },
                values: new object[] { 1, 11, 9 });

            migrationBuilder.UpdateData(
                table: "OHProducts",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "OrderHistoryId", "ProductId", "Quantity" },
                values: new object[] { 3, 20, 2 });

            migrationBuilder.UpdateData(
                table: "OHProducts",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "ProductId", "Quantity" },
                values: new object[] { 11, 7 });

            migrationBuilder.UpdateData(
                table: "OHProducts",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "OrderHistoryId", "ProductId", "Quantity" },
                values: new object[] { 4, 11, 12 });

            migrationBuilder.UpdateData(
                table: "OHProducts",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "OrderHistoryId", "ProductId", "Quantity" },
                values: new object[] { 1, 27, 4 });

            migrationBuilder.UpdateData(
                table: "OHProducts",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "OrderHistoryId", "ProductId", "Quantity" },
                values: new object[] { 1, 15, 13 });

            migrationBuilder.UpdateData(
                table: "OHProducts",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "OrderHistoryId", "ProductId", "Quantity" },
                values: new object[] { 1, 14, 7 });

            migrationBuilder.UpdateData(
                table: "OHProducts",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "ProductId", "Quantity" },
                values: new object[] { 25, 3 });

            migrationBuilder.UpdateData(
                table: "OHProducts",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "OrderHistoryId", "ProductId", "Quantity" },
                values: new object[] { 1, 19, 19 });

            migrationBuilder.UpdateData(
                table: "OHProducts",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "OrderHistoryId", "ProductId", "Quantity" },
                values: new object[] { 4, 16, 7 });

            migrationBuilder.UpdateData(
                table: "OHProducts",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "OrderHistoryId", "ProductId", "Quantity" },
                values: new object[] { 4, 16, 8 });

            migrationBuilder.UpdateData(
                table: "OHProducts",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "OrderHistoryId", "ProductId", "Quantity" },
                values: new object[] { 1, 27, 19 });

            migrationBuilder.UpdateData(
                table: "OHProducts",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "OrderHistoryId", "ProductId", "Quantity" },
                values: new object[] { 1, 4, 18 });

            migrationBuilder.UpdateData(
                table: "OHProducts",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "ProductId", "Quantity" },
                values: new object[] { 16, 3 });

            migrationBuilder.UpdateData(
                table: "OHProducts",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "ProductId", "Quantity" },
                values: new object[] { 5, 8 });

            migrationBuilder.UpdateData(
                table: "OHProducts",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "OrderHistoryId", "ProductId", "Quantity" },
                values: new object[] { 4, 5, 15 });

            migrationBuilder.UpdateData(
                table: "OHProducts",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "OrderHistoryId", "ProductId", "Quantity" },
                values: new object[] { 1, 22, 17 });

            migrationBuilder.UpdateData(
                table: "OHProducts",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "OrderHistoryId", "ProductId", "Quantity" },
                values: new object[] { 1, 5, 3 });

            migrationBuilder.UpdateData(
                table: "OHProducts",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "ProductId", "Quantity" },
                values: new object[] { 2, 10 });

            migrationBuilder.UpdateData(
                table: "OHProducts",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "OrderHistoryId", "ProductId" },
                values: new object[] { 2, 16 });

            migrationBuilder.UpdateData(
                table: "OHProducts",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "OrderHistoryId", "ProductId", "Quantity" },
                values: new object[] { 1, 20, 16 });

            migrationBuilder.UpdateData(
                table: "OHProducts",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "OrderHistoryId", "ProductId", "Quantity" },
                values: new object[] { 1, 6, 16 });

            migrationBuilder.UpdateData(
                table: "OHProducts",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "OrderHistoryId", "ProductId", "Quantity" },
                values: new object[] { 1, 29, 1 });

            migrationBuilder.UpdateData(
                table: "OHProducts",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "OrderHistoryId", "ProductId", "Quantity" },
                values: new object[] { 1, 25, 8 });

            migrationBuilder.UpdateData(
                table: "OHProducts",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "OrderHistoryId", "ProductId", "Quantity" },
                values: new object[] { 4, 17, 18 });

            migrationBuilder.UpdateData(
                table: "OHProducts",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "OrderHistoryId", "ProductId", "Quantity" },
                values: new object[] { 1, 18, 14 });

            migrationBuilder.UpdateData(
                table: "OHProducts",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "ProductId", "Quantity" },
                values: new object[] { 9, 10 });

            migrationBuilder.UpdateData(
                table: "OHProducts",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "ProductId", "Quantity" },
                values: new object[] { 23, 16 });

            migrationBuilder.UpdateData(
                table: "OHProducts",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "OrderHistoryId", "ProductId", "Quantity" },
                values: new object[] { 2, 21, 8 });

            migrationBuilder.UpdateData(
                table: "OHProducts",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "OrderHistoryId", "ProductId", "Quantity" },
                values: new object[] { 2, 25, 17 });

            migrationBuilder.UpdateData(
                table: "OHProducts",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "ProductId", "Quantity" },
                values: new object[] { 25, 12 });

            migrationBuilder.UpdateData(
                table: "OHProducts",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "OrderHistoryId", "ProductId", "Quantity" },
                values: new object[] { 4, 15, 17 });

            migrationBuilder.UpdateData(
                table: "OHProducts",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "OrderHistoryId", "ProductId", "Quantity" },
                values: new object[] { 2, 15, 19 });

            migrationBuilder.UpdateData(
                table: "OHProducts",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "OrderHistoryId", "ProductId", "Quantity" },
                values: new object[] { 3, 17, 4 });

            migrationBuilder.UpdateData(
                table: "OHProducts",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "ProductId", "Quantity" },
                values: new object[] { 1, 17 });

            migrationBuilder.UpdateData(
                table: "OrderHistories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CouponCode", "TimeCreated", "ToLocation" },
                values: new object[] { "1rEDJb", new DateTime(2022, 6, 20, 9, 23, 47, 907, DateTimeKind.Local).AddTicks(4813), "three you three pin you ten naive three thick two " });

            migrationBuilder.UpdateData(
                table: "OrderHistories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CouponCode", "TimeCreated", "ToLocation" },
                values: new object[] { "PaU953", new DateTime(2022, 6, 20, 9, 23, 47, 907, DateTimeKind.Local).AddTicks(5078), "ten numberless three anything worried anything industrious cent numberless ten " });

            migrationBuilder.UpdateData(
                table: "OrderHistories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CouponCode", "TimeCreated", "ToLocation" },
                values: new object[] { "IZXt8T", new DateTime(2022, 6, 20, 9, 23, 47, 907, DateTimeKind.Local).AddTicks(5090), "thick anything thick well-made text walk walk text ten cent " });

            migrationBuilder.UpdateData(
                table: "OrderHistories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CouponCode", "TimeCreated", "ToLocation" },
                values: new object[] { "idFXtc", new DateTime(2022, 6, 20, 9, 23, 47, 907, DateTimeKind.Local).AddTicks(5100), "paragragh body you body well-made walk pig you ten something " });

            migrationBuilder.UpdateData(
                table: "OrderHistories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CouponCode", "TimeCreated", "ToLocation" },
                values: new object[] { "7In4cm", new DateTime(2022, 6, 20, 9, 23, 47, 907, DateTimeKind.Local).AddTicks(5109), "two anything numberless thick two else cent one love industrious " });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BrandId", "CategoryId", "Code", "Description", "InStock", "Name", "Overeview", "Total" },
                values: new object[] { 4, 5, "K8WmGr", "worried worried pin naive one cent one well-made numberless body well-made numberless ten something love love text worried cent worried pig ten numberless naive pig tired paragragh anything thick text three bye something fix three anything worried naive anything pig bye pin pin industrious two something worried walk pig hello ", 1856, "numberless else something tired ", "numberless cent else hello hello numberless pig numberless numberless love text anything love cent naive thick love industrious ten thick ", 1460 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CategoryId", "Code", "Description", "InStock", "Name", "Overeview", "Price", "SalesOff", "Total" },
                values: new object[] { 4, "EVFsDH", "two anything tired hello love tired pig three you anything worried something anything love walk ten fix thick text well-made bye numberless numberless ten one worried body tired three love anything body pig pin worried hello body pig numberless naive industrious thick pin else worried worried body love tired bye ", 350, "tired two love thick ", "fix thick ten you paragragh thick walk you two pig ten anything text something pig one else you industrious industrious ", 120f, 12, 618 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Code", "Description", "InStock", "Name", "Overeview", "Price", "SalesOff", "Total" },
                values: new object[] { "ki2k5s", "ten fix fix one two thick tired naive you walk tired body else anything paragragh numberless cent text else body anything paragragh else fix bye hello you hello one naive love else pig naive thick anything hello worried industrious fix paragragh body bye anything paragragh numberless paragragh text else industrious ", 1279, "fix love body pin ", "thick anything text text three worried naive tired cent worried pin tired else fix cent industrious pin naive paragragh else ", 950f, 11, 666 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "BrandId", "CategoryId", "Code", "Description", "InStock", "Name", "Overeview", "Price", "SalesOff", "Total" },
                values: new object[] { 2, 4, "sCv9CI", "pin bye something naive cent hello industrious body body three walk anything two pin thick tired worried three bye anything text thick hello paragragh ten pin pig two tired well-made industrious naive walk ten text cent text well-made else industrious you two pig fix paragragh naive cent else worried naive ", 1821, "hello you ten two ", "text naive two three one pin two well-made well-made body well-made paragragh text hello paragragh walk three fix thick one ", 90f, 6, 1967 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "BrandId", "CategoryId", "Code", "Description", "InStock", "Name", "Overeview", "Price", "SalesOff", "Total" },
                values: new object[] { 4, 5, "1nB2hJ", "fix three anything numberless cent three text bye love tired pin two else you two thick tired anything something walk three fix tired ten one anything you numberless naive two numberless bye one else tired you love walk body love cent else one something numberless bye tired numberless love hello ", 860, "walk bye two text ", "text ten pig cent text love cent fix pin industrious industrious numberless body hello three two fix numberless cent industrious ", 220f, 14, 1059 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "BrandId", "CategoryId", "Code", "Description", "InStock", "Name", "Overeview", "Price", "SalesOff", "Total" },
                values: new object[] { 2, 3, "R8aJgM", "industrious two thick fix fix text text ten you bye hello pig naive one hello thick one worried body numberless one else you worried industrious else fix hello something worried fix naive you ten tired fix something numberless well-made ten fix cent love bye something two fix worried one walk ", 1738, "anything something cent pig ", "pin pin hello text bye cent anything paragragh numberless worried love paragragh text numberless one three walk three thick one ", 250f, 4, 200 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CategoryId", "Code", "Description", "InStock", "Name", "Overeview", "Price", "SalesOff", "Total" },
                values: new object[] { 1, "AbsNWv", "hello two paragragh anything text fix else hello bye well-made pin numberless fix bye walk you anything bye hello text cent else text something something thick text love bye anything pig text you text else three ten walk naive pig three tired else thick thick paragragh anything body pig naive ", 1932, "well-made walk cent ten ", "tired bye cent numberless text bye love cent two thick three thick hello hello well-made naive you fix love thick ", 390f, 2, 875 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "BrandId", "CategoryId", "Code", "Description", "InStock", "Name", "Overeview", "Price", "SalesOff", "Total" },
                values: new object[] { 4, 2, "Nx0HUW", "paragragh paragragh hello love anything something you body one pin tired industrious tired numberless two walk worried you walk else well-made ten pig fix ten hello love fix anything body well-made ten pin numberless one tired walk body fix hello three cent something love thick anything anything walk pig walk ", 1943, "text three body two ", "cent text love tired worried text cent cent love ten pin thick pig love tired paragragh one cent one you ", 590f, 13, 1362 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "BrandId", "CategoryId", "Code", "Description", "InStock", "Name", "Overeview", "Price", "SalesOff", "Total" },
                values: new object[] { 4, 4, "o8bEFd", "three worried tired two body cent you anything else tired cent numberless industrious paragragh love one text worried well-made fix walk well-made numberless two three body pin walk anything cent pig pig cent worried three you body anything walk three well-made bye numberless fix you worried thick naive body anything ", 960, "ten fix pin two ", "numberless thick bye cent body cent hello paragragh three numberless cent fix numberless love bye something cent text tired two ", 920f, 14, 190 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "BrandId", "CategoryId", "Code", "Description", "InStock", "Name", "Overeview", "Price", "SalesOff", "Total" },
                values: new object[] { 1, 5, "YjGwv9", "three walk paragragh well-made ten walk cent walk else two hello one naive pin well-made tired tired pin thick worried worried numberless ten text tired hello numberless numberless naive hello fix pin well-made you pin something walk else cent thick something text ten one walk something pig else fix well-made ", 1219, "cent else pin bye ", "love anything you body two ten you fix cent text cent two text text something else well-made body well-made walk ", 260f, 1, 495 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CategoryId", "Code", "Description", "InStock", "Name", "Overeview", "Price", "SalesOff", "Total" },
                values: new object[] { 3, "FwbC0T", "tired cent three well-made cent cent three three well-made one three two tired paragragh naive you else ten numberless bye naive something two else bye well-made bye industrious worried paragragh fix ten anything anything numberless worried two paragragh fix numberless anything pin paragragh body two else ten ten fix pig ", 107, "worried industrious love cent ", "pig tired body something walk paragragh love body bye fix well-made walk bye paragragh cent thick something industrious walk walk ", 690f, 10, 1709 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "BrandId", "CategoryId", "Code", "Description", "InStock", "Name", "Overeview", "Price", "Total" },
                values: new object[] { 1, 1, "2xkIt6", "text well-made numberless well-made bye fix pin bye tired walk naive well-made you one pin naive industrious walk pin paragragh bye numberless cent one anything body industrious love bye love numberless you tired hello naive tired fix fix else three anything three two thick pin something text bye love worried ", 1635, "something paragragh text hello ", "something hello else walk pig anything naive pin one naive love two numberless love fix paragragh else three numberless two ", 680f, 966 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "BrandId", "CategoryId", "Code", "Description", "InStock", "Name", "Overeview", "Price", "SalesOff", "Total" },
                values: new object[] { 1, 3, "FpFdTh", "numberless industrious tired else naive anything worried worried fix ten three numberless walk two ten naive pig well-made walk numberless anything something bye tired walk pig you pin well-made three worried two thick bye thick paragragh body one pig anything hello thick text pin love tired two body bye anything ", 333, "thick worried pin one ", "three tired walk two you something bye cent three else fix three one naive pig one pin tired cent something ", 260f, 2, 1536 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "BrandId", "Code", "Description", "InStock", "Name", "Overeview", "Price", "SalesOff", "Total" },
                values: new object[] { 3, "pakBbC", "fix well-made three anything worried anything industrious well-made you thick hello numberless tired something paragragh you paragragh hello two bye ten love two industrious bye industrious hello something thick worried something one industrious well-made ten fix love pig you tired something text thick cent industrious love numberless love numberless ten ", 1398, "numberless worried love something ", "else else walk numberless thick paragragh anything pig one one anything hello bye ten else you hello pig one tired ", 150f, 0, 113 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CategoryId", "Code", "Description", "InStock", "Name", "Overeview", "SalesOff", "Total" },
                values: new object[] { 5, "kiouaC", "love pin something walk ten industrious love love anything walk three two hello cent love you pin paragragh text else fix hello walk hello numberless well-made paragragh ten body love three pig ten numberless pin anything bye else bye anything two text pig else pig you you three paragragh cent ", 1764, "hello fix you ten ", "body cent love pig numberless hello one walk love industrious bye tired pin something numberless two two two body something ", 4, 1734 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "BrandId", "CategoryId", "Code", "Description", "InStock", "Name", "Overeview", "Price", "SalesOff", "Total" },
                values: new object[] { 2, 3, "MYzJKg", "tired hello love something industrious tired hello body two bye three walk pig ten industrious bye else three ten pig something worried walk hello walk pig anything pin cent fix numberless pin three thick industrious naive one bye three body love well-made cent two love body well-made fix industrious three ", 64, "thick industrious love numberless ", "three tired worried anything thick naive walk paragragh industrious text walk one walk cent thick you pin three well-made body ", 250f, 14, 474 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Code", "Description", "InStock", "Name", "Overeview", "Price", "SalesOff", "Total" },
                values: new object[] { "VRQXby", "pin love pin three numberless cent numberless pin bye thick tired pin worried numberless two pig paragragh naive love industrious walk walk one anything naive something ten well-made paragragh anything one hello body one three hello you love else three industrious anything pig numberless body body hello bye two paragragh ", 937, "fix hello three cent ", "thick anything else paragragh body cent body three fix tired body something two walk numberless bye you naive cent love ", 750f, 1, 1206 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CategoryId", "Code", "Description", "InStock", "Name", "Overeview", "Price", "SalesOff", "Total" },
                values: new object[] { 5, "pxUDfb", "pin love you pin cent love thick well-made tired well-made else text pig pin anything you pig hello thick three anything tired industrious tired you love numberless cent pig cent cent well-made fix ten anything cent text well-made anything bye one tired something paragragh one cent walk anything tired well-made ", 1299, "tired three pig two ", "numberless two well-made industrious tired you else numberless pin well-made you hello body thick worried well-made something pin cent body ", 950f, 4, 407 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "BrandId", "CategoryId", "Code", "Description", "InStock", "Name", "Overeview", "Price", "SalesOff", "Total" },
                values: new object[] { 1, 3, "DlweFT", "two industrious paragragh naive tired walk cent something text thick hello thick else worried anything text three else numberless anything something ten pin one three fix else thick else else fix you numberless numberless ten worried paragragh ten thick body love you worried you numberless tired else else ten anything ", 1970, "ten walk anything well-made ", "well-made hello industrious paragragh cent pin bye three pig bye ten naive three text else worried paragragh numberless walk pin ", 300f, 3, 249 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CategoryId", "Code", "Description", "InStock", "Name", "Overeview", "Price", "SalesOff", "Total" },
                values: new object[] { 3, "YxELe6", "you ten something pin numberless two pig fix tired numberless anything numberless pin hello numberless pin naive pin pin well-made ten you cent else worried body else numberless cent two walk well-made else bye else bye body naive text thick text love else pin ten two industrious numberless thick paragragh ", 1409, "one ten body numberless ", "naive something naive ten anything pin pig industrious industrious text else industrious bye fix ten body two text thick thick ", 640f, 1, 1172 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "BrandId", "CategoryId", "Code", "Description", "InStock", "Name", "Overeview", "Price", "SalesOff", "Total" },
                values: new object[] { 4, 4, "kBm72G", "one one anything something you numberless hello two fix hello two love worried industrious walk something well-made three paragragh something well-made numberless two else ten fix numberless thick well-made pig two love love walk worried love bye cent something body bye else cent numberless naive thick pin three naive well-made ", 1319, "you well-made well-made three ", "tired hello ten one pin body pig something bye anything walk cent you bye love two else tired anything something ", 370f, 4, 1702 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "BrandId", "CategoryId", "Code", "Description", "InStock", "Name", "Overeview", "Price", "SalesOff", "Total" },
                values: new object[] { 4, 4, "Xd6R0d", "walk two three something you well-made naive cent body fix naive pin cent one tired industrious love body cent pig else you cent three one tired anything tired numberless paragragh numberless thick walk worried one tired industrious naive tired three paragragh pin ten text well-made you thick ten numberless naive ", 1685, "body industrious thick cent ", "body anything body naive industrious industrious cent paragragh worried one you one naive fix tired walk numberless body anything paragragh ", 380f, 9, 238 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "BrandId", "CategoryId", "Code", "Description", "InStock", "Name", "Overeview", "Price", "SalesOff", "Total" },
                values: new object[] { 2, 5, "FSZBEf", "bye two pin well-made body industrious well-made you bye love you one naive naive industrious pig paragragh numberless naive love bye bye worried fix cent anything hello thick hello worried bye thick three tired tired walk pin paragragh pin you pig else ten else paragragh one worried well-made two paragragh ", 836, "naive you industrious walk ", "ten numberless pin body body bye one naive bye something worried hello one else numberless cent thick paragragh tired body ", 410f, 8, 715 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "BrandId", "CategoryId", "Code", "Description", "InStock", "Name", "Overeview", "Price", "SalesOff", "Total" },
                values: new object[] { 2, 3, "cAdkDD", "anything pig anything tired paragragh fix text anything pig tired walk fix naive walk ten walk naive text fix tired pig body body something pig pin you fix well-made thick numberless text something worried two fix body bye cent love pig industrious worried cent something pig worried hello three one ", 554, "two love fix thick ", "paragragh anything you you pig body numberless tired one love text fix text something ten well-made ten text paragragh walk ", 890f, 4, 299 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "BrandId", "CategoryId", "Code", "Description", "InStock", "Name", "Overeview", "Price", "SalesOff", "Total" },
                values: new object[] { 2, 3, "56TTGt", "fix naive walk something worried else tired fix naive pin fix walk three industrious hello anything love hello thick numberless one else cent paragragh industrious bye naive industrious love worried else body fix thick industrious bye body body walk one fix industrious pig worried paragragh else anything you bye you ", 683, "one pig else you ", "three cent something naive walk three bye two worried cent love ten body pin love tired two text hello body ", 540f, 6, 302 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "BrandId", "CategoryId", "Code", "Description", "InStock", "Name", "Overeview", "Price", "SalesOff", "Total" },
                values: new object[] { 2, 3, "YtIbil", "something pin body thick thick bye fix two cent worried bye industrious three pig you hello you one you else three bye ten anything naive industrious fix worried pin anything paragragh something one paragragh three paragragh hello something two hello tired else something hello you naive well-made paragragh bye industrious ", 55, "thick pig one cent ", "paragragh hello body body body love pig three something fix tired numberless pin tired one tired one anything two one ", 510f, 14, 1984 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "BrandId", "CategoryId", "Code", "Description", "InStock", "Name", "Overeview", "Price", "SalesOff", "Total" },
                values: new object[] { 2, 5, "uGPBCR", "two something body text hello hello two naive tired worried industrious tired industrious pin ten cent well-made thick industrious walk pin two else two walk anything pin numberless fix tired else something three something naive love numberless ten else bye text something numberless worried pin bye cent pin walk else ", 1706, "industrious pig one well-made ", "bye numberless hello cent body pig body fix well-made worried you pig pin pin love text something anything fix paragragh ", 440f, 3, 635 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CategoryId", "Code", "Description", "InStock", "Name", "Overeview", "Price", "SalesOff", "Total" },
                values: new object[] { 3, "sA7Yeh", "ten two you pig anything else pig worried industrious cent ten numberless else one anything text pig pig two anything two pig text thick hello tired three ten paragragh fix text worried numberless numberless text body one tired body fix walk one hello thick two fix love pin paragragh numberless ", 333, "fix one love body ", "one hello text anything industrious hello else one bye thick bye one one text ten pin three paragragh anything tired ", 700f, 14, 1180 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "BrandId", "CategoryId", "Code", "Description", "InStock", "Name", "Overeview", "Price", "SalesOff", "Total" },
                values: new object[] { 2, 4, "xd4jxf", "body numberless pig well-made numberless body two hello one text walk love you body fix well-made walk ten you ten pig pin walk paragragh else one three ten body industrious fix something you naive else anything naive two you cent pig ten two numberless three anything tired ten two pig ", 1638, "love hello thick something ", "pin two three anything cent you pig cent paragragh pin three naive paragragh pin one ten pin text paragragh worried ", 570f, 14, 553 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "BrandId", "CategoryId", "Code", "Description", "InStock", "Name", "Overeview", "Price", "SalesOff", "Total" },
                values: new object[] { 2, 3, "07zfje", "three anything hello text worried three pin tired pin hello pig industrious three pig pin three hello industrious thick anything naive industrious fix naive bye else one love naive worried something three body pin text pin worried one thick industrious two bye text pin walk naive thick else text thick ", 672, "cent three bye hello ", "anything two pig hello you something you text bye bye tired cent anything text cent numberless cent text bye walk ", 560f, 8, 262 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Comment", "ProductId", "Rate", "TimePosted" },
                values: new object[] { "text bye worried cent fix well-made cent numberless you three hello worried ten one body else you paragragh well-made naive ten tired tired industrious walk naive you worried body one ", 17, 4, new DateTime(2022, 6, 20, 9, 23, 47, 911, DateTimeKind.Local).AddTicks(9628) });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Comment", "ProductId", "Rate", "TimePosted" },
                values: new object[] { "tired worried body hello body thick you love fix hello ten walk paragragh cent two industrious text else something thick numberless walk industrious naive worried pin anything industrious naive pin ", 3, 2, new DateTime(2022, 6, 20, 9, 23, 47, 911, DateTimeKind.Local).AddTicks(9930) });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Comment", "ProductId", "TimePosted" },
                values: new object[] { "well-made body paragragh something one bye else bye three tired you naive two cent thick numberless paragragh ten fix naive you walk tired cent numberless else thick body tired ten ", 16, new DateTime(2022, 6, 20, 9, 23, 47, 911, DateTimeKind.Local).AddTicks(9951) });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Comment", "ProductId", "Rate", "TimePosted" },
                values: new object[] { "tired hello anything paragragh fix anything one walk body worried one else naive paragragh text anything else you thick bye two paragragh fix numberless two one one love worried text ", 4, 2, new DateTime(2022, 6, 20, 9, 23, 47, 911, DateTimeKind.Local).AddTicks(9998) });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Comment", "ProductId", "TimePosted" },
                values: new object[] { "love bye anything worried well-made two something ten well-made walk naive ten else text love naive body fix naive bye fix body ten something pin you worried love tired else ", 3, new DateTime(2022, 6, 20, 9, 23, 47, 912, DateTimeKind.Local).AddTicks(41) });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Comment", "ProductId", "TimePosted" },
                values: new object[] { "pin bye ten three ten one text numberless well-made one pig tired tired something tired love text walk love else tired two one you text pig worried naive hello ten ", 12, new DateTime(2022, 6, 20, 9, 23, 47, 912, DateTimeKind.Local).AddTicks(115) });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Comment", "ProductId", "Rate", "TimePosted" },
                values: new object[] { "worried industrious paragragh worried anything numberless bye fix paragragh well-made well-made love text tired walk thick bye pig cent cent ten tired three fix body you industrious hello fix thick ", 17, 3, new DateTime(2022, 6, 20, 9, 23, 47, 912, DateTimeKind.Local).AddTicks(162) });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Comment", "ProductId", "TimePosted" },
                values: new object[] { "cent text pig naive love well-made anything something text fix anything worried naive text cent pig industrious paragragh three cent two walk ten text well-made naive cent numberless anything pin ", 1, new DateTime(2022, 6, 20, 9, 23, 47, 912, DateTimeKind.Local).AddTicks(208) });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Comment", "ProductId", "Rate", "TimePosted" },
                values: new object[] { "else paragragh else pin worried you bye well-made thick bye hello thick hello text industrious pig text three tired else bye tired you body anything one industrious one industrious you ", 21, 2, new DateTime(2022, 6, 20, 9, 23, 47, 912, DateTimeKind.Local).AddTicks(225) });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Comment", "ProductId", "TimePosted" },
                values: new object[] { "tired bye fix one pin worried worried cent walk two three industrious text tired well-made one well-made you naive industrious two naive you pig love text industrious one three body ", 5, new DateTime(2022, 6, 20, 9, 23, 47, 912, DateTimeKind.Local).AddTicks(273) });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Comment", "ProductId", "Rate", "TimePosted" },
                values: new object[] { "three ten body anything well-made bye well-made two else well-made fix you one ten well-made bye naive bye naive walk one two numberless numberless something cent else pig numberless one ", 11, 2, new DateTime(2022, 6, 20, 9, 23, 47, 912, DateTimeKind.Local).AddTicks(347) });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Comment", "ProductId", "Rate", "TimePosted" },
                values: new object[] { "fix thick well-made anything fix pig naive text something paragragh fix thick love body paragragh numberless fix one well-made pig else anything you walk paragragh you pig industrious three anything ", 16, 2, new DateTime(2022, 6, 20, 9, 23, 47, 912, DateTimeKind.Local).AddTicks(395) });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Comment", "ProductId", "TimePosted" },
                values: new object[] { "love cent fix cent one naive industrious pin walk two two three cent text cent something fix something three hello naive industrious two hello hello pin walk bye body walk ", 25, new DateTime(2022, 6, 20, 9, 23, 47, 912, DateTimeKind.Local).AddTicks(443) });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Comment", "ProductId", "Rate", "TimePosted" },
                values: new object[] { "walk naive bye else bye one bye worried fix well-made numberless numberless thick numberless numberless pin text something else walk worried pin ten paragragh two body text bye worried two ", 1, 3, new DateTime(2022, 6, 20, 9, 23, 47, 912, DateTimeKind.Local).AddTicks(460) });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Comment", "ProductId", "TimePosted" },
                values: new object[] { "paragragh you two three cent hello worried love industrious text pin industrious pin one worried fix body cent ten thick one something one walk bye paragragh industrious one love pin ", 1, new DateTime(2022, 6, 20, 9, 23, 47, 912, DateTimeKind.Local).AddTicks(508) });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Comment", "ProductId", "Rate", "TimePosted" },
                values: new object[] { "walk numberless pig fix fix walk three well-made bye ten worried tired body text paragragh pin three well-made one body ten else tired worried thick tired naive fix thick one ", 1, 4, new DateTime(2022, 6, 20, 9, 23, 47, 912, DateTimeKind.Local).AddTicks(554) });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Comment", "ProductId", "Rate", "TimePosted" },
                values: new object[] { "else cent love anything pig else body paragragh naive one three ten hello worried walk three pin industrious paragragh two hello numberless numberless one else cent industrious pin you tired ", 26, 1, new DateTime(2022, 6, 20, 9, 23, 47, 912, DateTimeKind.Local).AddTicks(598) });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Comment", "ProductId", "Rate", "TimePosted" },
                values: new object[] { "paragragh numberless text three love ten paragragh cent pig three something well-made love two something well-made walk hello fix pig three fix two something industrious naive pig industrious two anything ", 24, 4, new DateTime(2022, 6, 20, 9, 23, 47, 912, DateTimeKind.Local).AddTicks(654) });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Comment", "ProductId", "Rate", "TimePosted" },
                values: new object[] { "else love numberless fix tired tired body walk thick one naive else tired three text numberless bye three three fix anything two worried naive hello industrious text bye hello something ", 17, 4, new DateTime(2022, 6, 20, 9, 23, 47, 912, DateTimeKind.Local).AddTicks(671) });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Comment", "ProductId", "Rate", "TimePosted" },
                values: new object[] { "pin text two body one walk three ten bye walk you well-made worried anything well-made pig something well-made two paragragh worried thick anything industrious text text anything naive else fix ", 22, 2, new DateTime(2022, 6, 20, 9, 23, 47, 912, DateTimeKind.Local).AddTicks(724) });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Comment", "ProductId", "Rate", "TimePosted" },
                values: new object[] { "pin body else else walk text hello naive pin numberless you paragragh else you walk bye love fix you well-made pin three walk something paragragh hello pig love well-made bye ", 4, 4, new DateTime(2022, 6, 20, 9, 23, 47, 912, DateTimeKind.Local).AddTicks(768) });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Comment", "ProductId", "TimePosted" },
                values: new object[] { "hello worried well-made worried pig one numberless anything ten well-made paragragh industrious hello walk tired three bye fix hello well-made one bye text walk ten pin you paragragh fix two ", 2, new DateTime(2022, 6, 20, 9, 23, 47, 912, DateTimeKind.Local).AddTicks(812) });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Comment", "ProductId", "Rate", "TimePosted" },
                values: new object[] { "anything three pig one something numberless well-made pig thick body fix paragragh numberless worried worried one industrious fix thick three pin three bye anything fix numberless naive well-made something naive ", 15, 3, new DateTime(2022, 6, 20, 9, 23, 47, 912, DateTimeKind.Local).AddTicks(858) });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Comment", "ProductId", "TimePosted" },
                values: new object[] { "walk walk worried something anything love cent fix cent cent you two numberless anything worried else you thick something body well-made well-made hello industrious pig naive industrious two paragragh pin ", 19, new DateTime(2022, 6, 20, 9, 23, 47, 912, DateTimeKind.Local).AddTicks(905) });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Comment", "ProductId", "Rate", "TimePosted" },
                values: new object[] { "hello pig one love body bye something well-made well-made you something love anything anything you hello you else thick pig text bye you body paragragh numberless naive two paragragh two ", 21, 1, new DateTime(2022, 6, 20, 9, 23, 47, 912, DateTimeKind.Local).AddTicks(922) });
        }
    }
}
