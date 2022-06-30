using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TSport.Migrations
{
    public partial class updateReview : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "Reviews",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db12554843e5",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "2306e663-939f-4c35-9a3c-74bc03a22364", "65fe3acd-120d-4d09-8e46-482698a7d4e1" });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Author", "Content", "Tag", "TimePosted", "Title" },
                values: new object[] { "worried walk ", "love body text fix paragragh three text worried pig body three text else else thick paragragh industrious else worried numberless body naive fix walk something pig pin well-made fix naive anything tired anything walk tired bye worried bye one bye anything hello thick paragragh naive love else three cent you bye industrious bye numberless bye one one bye ten hello ten fix text anything pin fix paragragh fix pig love two one worried something worried hello anything else love paragragh something walk industrious bye ten three love love text three anything something text numberless text bye ten tired text you ", "one pig pig anything ", new DateTime(2022, 6, 21, 9, 38, 44, 120, DateTimeKind.Local).AddTicks(122), "one naive hello bye something two paragragh else worried hello " });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Author", "Content", "Tag", "TimePosted", "Title" },
                values: new object[] { "industrious walk ", "naive cent cent walk one love paragragh fix you body love numberless you something text bye anything anything something tired something ten walk three love body anything else walk industrious body something walk worried cent two well-made bye thick well-made fix worried tired naive industrious you body pig pig industrious you else fix fix anything one anything naive naive one anything numberless walk three body walk three ten hello industrious well-made fix two tired anything bye tired you paragragh anything pin something tired worried cent pig walk ten cent something else anything walk three pig tired you one naive you ", "three cent three hello ", new DateTime(2022, 6, 21, 9, 38, 44, 122, DateTimeKind.Local).AddTicks(1754), "body you anything pin something love something numberless love two " });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Author", "Content", "Tag", "TimePosted", "Title" },
                values: new object[] { "three you ", "else industrious else text body numberless something three fix naive walk ten industrious one two love one three love three ten walk pig else cent cent pig text hello something naive three well-made pin text three love something you pin one body paragragh bye well-made naive body anything love well-made fix paragragh bye paragragh hello fix three body bye three ten you thick ten pin tired bye industrious three ten body anything you three well-made three hello ten fix three walk naive love walk cent one naive bye bye pig pin you industrious industrious well-made something something anything bye love ", "worried numberless pig bye ", new DateTime(2022, 6, 21, 9, 38, 44, 122, DateTimeKind.Local).AddTicks(3005), "industrious numberless bye fix worried pin two thick one pig " });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Author", "Content", "Tag", "TimePosted", "Title" },
                values: new object[] { "something pig ", "numberless worried two fix numberless body one one paragragh industrious love three two two cent one well-made one pin naive walk ten anything else paragragh else pin love pig body thick tired hello ten two bye naive industrious ten love naive one naive walk else pin industrious you hello fix ten body else naive well-made well-made walk anything else tired anything text well-made ten text fix thick ten body else walk cent ten cent body something hello text pin text two worried thick love cent thick paragragh worried bye naive pig tired tired tired you something naive bye hello walk ", "you ten walk two ", new DateTime(2022, 6, 21, 9, 38, 44, 122, DateTimeKind.Local).AddTicks(3628), "three else hello else body numberless one else something hello " });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Author", "Content", "Tag", "TimePosted", "Title" },
                values: new object[] { "body industrious ", "naive thick two thick text walk pig something thick three ten tired well-made thick pig body well-made ten numberless naive walk one something two cent walk ten love one three hello tired two industrious pig anything you worried bye fix body pig fix tired ten ten well-made body naive three well-made worried you bye two ten text pin cent hello tired tired industrious one naive thick three cent numberless thick numberless industrious pig something naive anything worried well-made ten thick anything three bye paragragh one naive bye numberless hello bye walk you anything pin pin one walk love numberless fix ", "you body paragragh worried ", new DateTime(2022, 6, 21, 9, 38, 44, 122, DateTimeKind.Local).AddTicks(4210), "walk bye naive something ten hello anything body three three " });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Author", "Content", "Tag", "TimePosted", "Title" },
                values: new object[] { "three fix ", "love naive body pin love paragragh else one worried cent cent well-made something paragragh paragragh well-made cent thick tired love you one body fix fix well-made you ten love text else worried hello tired text love love numberless one well-made tired naive three two body two something fix anything tired naive love tired else text naive naive one one two three you text tired hello pin ten walk numberless love thick worried ten worried fix one text tired hello love two fix love fix tired three text three text thick bye naive hello anything tired bye something tired industrious anything ", "thick numberless pin walk ", new DateTime(2022, 6, 21, 9, 38, 44, 122, DateTimeKind.Local).AddTicks(4951), "love well-made cent else something hello walk ten bye two " });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Author", "Content", "Tag", "TimePosted", "Title" },
                values: new object[] { "pig three ", "pin well-made pin else pig anything hello else naive numberless something love text anything anything pig pig bye numberless cent industrious three fix walk paragragh fix two two paragragh two well-made ten anything pin hello thick tired fix else love anything else text body one walk one well-made walk naive something two else three pig walk three three you three naive you anything paragragh ten three you text fix one you love three cent well-made tired industrious hello something one you thick tired fix anything else worried industrious text pig one two bye three bye pin paragragh anything cent paragragh ", "ten something tired ten ", new DateTime(2022, 6, 21, 9, 38, 44, 122, DateTimeKind.Local).AddTicks(5595), "numberless pig walk worried two anything industrious text pin thick " });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Author", "Content", "Tag", "TimePosted", "Title" },
                values: new object[] { "something paragragh ", "bye hello ten worried text ten body cent pin pig naive pin something walk something worried naive love pig numberless one paragragh pin cent anything something bye three cent walk tired cent you one bye pig cent pin pin hello love something two worried fix paragragh love thick pig body pin pig numberless love fix paragragh fix something walk numberless well-made cent pin three love cent industrious industrious text thick body pig love ten walk anything worried you text walk ten cent bye cent cent industrious industrious pin industrious paragragh three bye three body walk else two ten well-made pig ", "else you body paragragh ", new DateTime(2022, 6, 21, 9, 38, 44, 122, DateTimeKind.Local).AddTicks(6221), "paragragh hello two you industrious naive cent thick anything body " });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Author", "Content", "Tag", "TimePosted", "Title" },
                values: new object[] { "tired well-made ", "something three something ten industrious industrious body anything bye fix fix love one bye naive thick something fix one pin hello something walk fix something ten naive two worried pig two three text industrious numberless paragragh cent hello cent bye ten text thick bye pig one text cent cent well-made you fix fix walk two pin something walk worried pig paragragh thick three well-made three something cent hello fix two cent cent well-made numberless well-made ten well-made else worried numberless industrious worried fix you thick cent thick hello hello pin industrious body naive you paragragh fix you worried else else ", "text two numberless text ", new DateTime(2022, 6, 21, 9, 38, 44, 122, DateTimeKind.Local).AddTicks(6927), "fix pig else bye two one you pin well-made industrious " });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Author", "Content", "Tag", "TimePosted", "Title" },
                values: new object[] { "walk body ", "anything anything you else well-made else body fix hello walk three thick pig ten you worried body fix else love tired love three something anything body hello else well-made worried you pig paragragh worried hello body walk pin fix paragragh pig pig industrious three you love worried walk anything else pin something tired naive walk industrious industrious well-made text pig cent pig cent thick naive one something worried pig you you body pin you one worried paragragh body paragragh industrious love pig text one worried well-made you tired anything tired love anything pig worried one body industrious text bye thick ", "you pin ten pin ", new DateTime(2022, 6, 21, 9, 38, 44, 122, DateTimeKind.Local).AddTicks(7519), "walk tired body three ten body numberless numberless cent something " });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Author", "Content", "Tag", "TimePosted", "Title" },
                values: new object[] { "one fix ", "one something well-made numberless something walk walk you numberless anything text love thick two pin numberless hello thick love love tired text ten industrious something tired something love industrious text fix something text else tired hello hello fix text pin ten body body three naive text worried walk numberless well-made else worried paragragh one hello love three worried fix well-made two naive ten naive bye numberless cent else cent one one pin else love industrious tired paragragh body ten you pig fix three three numberless pig you worried cent bye else naive pin hello tired fix walk something naive pig ", "pin hello text something ", new DateTime(2022, 6, 21, 9, 38, 44, 122, DateTimeKind.Local).AddTicks(8089), "two hello ten numberless naive worried bye something fix you " });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Author", "Content", "Tag", "TimePosted", "Title" },
                values: new object[] { "else well-made ", "bye anything pig well-made worried numberless hello something you walk pin cent fix else walk worried else bye thick three tired naive worried tired ten pin else industrious tired ten body bye bye well-made anything well-made naive numberless worried bye body tired two hello something naive fix three love pin walk love worried worried paragragh cent three love fix industrious thick tired well-made industrious well-made hello something cent paragragh anything ten two thick love love pin text something ten hello two love walk thick two worried thick tired bye paragragh tired fix two pin worried one worried bye well-made worried ", "industrious you well-made two ", new DateTime(2022, 6, 21, 9, 38, 44, 122, DateTimeKind.Local).AddTicks(8793), "hello love hello industrious worried love thick bye anything cent " });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Author", "Content", "Tag", "TimePosted", "Title" },
                values: new object[] { "pig fix ", "cent you hello worried industrious well-made else body bye naive body thick text pig love walk tired something ten thick ten naive worried pin something industrious worried ten pig well-made naive something bye two tired well-made pin worried pin tired one industrious thick you something worried one body love walk ten fix cent worried paragragh love ten hello hello pin worried you text pig pin thick love industrious love something walk pig something tired three else anything walk tired bye one worried anything numberless fix you fix thick love one hello bye something pin pig else tired industrious you well-made ", "industrious walk pin hello ", new DateTime(2022, 6, 21, 9, 38, 44, 122, DateTimeKind.Local).AddTicks(9408), "hello pig pig text fix cent industrious body bye bye " });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Author", "Content", "Tag", "TimePosted", "Title" },
                values: new object[] { "cent three ", "body something three worried anything hello well-made naive worried else else something worried cent pig love naive worried well-made worried pin text pin body numberless else numberless ten something anything fix something two pig else paragragh well-made ten naive ten cent ten numberless thick three walk else cent ten numberless walk body paragragh pig body well-made two love numberless pig fix hello else walk well-made pin numberless three hello bye two one three fix anything walk else else worried love body love body one paragragh hello you pig naive fix cent thick text numberless naive text worried three worried three ", "text pig hello something ", new DateTime(2022, 6, 21, 9, 38, 44, 123, DateTimeKind.Local).AddTicks(131), "three ten naive numberless you one industrious body fix body " });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Author", "Content", "Tag", "TimePosted", "Title" },
                values: new object[] { "tired love ", "hello industrious hello paragragh worried paragragh bye pin naive well-made love paragragh industrious well-made industrious three one pig text cent cent text industrious industrious naive two you one love well-made something bye ten paragragh well-made pin thick thick text tired pig else anything walk ten tired walk industrious something ten thick fix hello industrious tired paragragh body tired fix one three anything cent industrious something naive body naive pin numberless fix cent two pig love hello ten love naive anything tired ten anything numberless you cent pin else thick hello numberless body you cent one naive hello three two hello ", "industrious two naive cent ", new DateTime(2022, 6, 21, 9, 38, 44, 123, DateTimeKind.Local).AddTicks(944), "worried pig thick paragragh two you paragragh cent pig one " });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Author", "Content", "Tag", "TimePosted", "Title" },
                values: new object[] { "body walk ", "pin worried walk fix pig naive body bye pin hello pig fix paragragh bye body body pig three one one text thick text text naive love fix fix one anything you tired pin bye naive thick something worried cent numberless love two one love you tired fix text you body three walk body two naive else tired hello worried fix you bye body industrious one love fix walk walk two naive worried else hello else industrious ten love ten you tired paragragh bye one industrious else fix tired cent something body worried body paragragh cent thick something hello pig numberless ", "hello naive else text ", new DateTime(2022, 6, 21, 9, 38, 44, 123, DateTimeKind.Local).AddTicks(1537), "love cent well-made you anything industrious numberless bye worried pin " });

            migrationBuilder.UpdateData(
                table: "OHProducts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "OrderHistoryId", "ProductId", "Quantity" },
                values: new object[] { 2, 15, 14 });

            migrationBuilder.UpdateData(
                table: "OHProducts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "OrderHistoryId", "ProductId", "Quantity" },
                values: new object[] { 2, 22, 14 });

            migrationBuilder.UpdateData(
                table: "OHProducts",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ProductId", "Quantity" },
                values: new object[] { 26, 2 });

            migrationBuilder.UpdateData(
                table: "OHProducts",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "OrderHistoryId", "ProductId", "Quantity" },
                values: new object[] { 1, 20, 12 });

            migrationBuilder.UpdateData(
                table: "OHProducts",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ProductId", "Quantity" },
                values: new object[] { 5, 1 });

            migrationBuilder.UpdateData(
                table: "OHProducts",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "OrderHistoryId", "ProductId", "Quantity" },
                values: new object[] { 2, 23, 12 });

            migrationBuilder.UpdateData(
                table: "OHProducts",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "OrderHistoryId", "Quantity" },
                values: new object[] { 1, 5 });

            migrationBuilder.UpdateData(
                table: "OHProducts",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "ProductId", "Quantity" },
                values: new object[] { 5, 16 });

            migrationBuilder.UpdateData(
                table: "OHProducts",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "OrderHistoryId", "ProductId" },
                values: new object[] { 1, 3 });

            migrationBuilder.UpdateData(
                table: "OHProducts",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "OrderHistoryId", "ProductId", "Quantity" },
                values: new object[] { 1, 3, 17 });

            migrationBuilder.UpdateData(
                table: "OHProducts",
                keyColumn: "Id",
                keyValue: 11,
                column: "Quantity",
                value: 18);

            migrationBuilder.UpdateData(
                table: "OHProducts",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "OrderHistoryId", "ProductId", "Quantity" },
                values: new object[] { 1, 27, 7 });

            migrationBuilder.UpdateData(
                table: "OHProducts",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "OrderHistoryId", "ProductId", "Quantity" },
                values: new object[] { 1, 24, 19 });

            migrationBuilder.UpdateData(
                table: "OHProducts",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "ProductId", "Quantity" },
                values: new object[] { 25, 9 });

            migrationBuilder.UpdateData(
                table: "OHProducts",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "ProductId", "Quantity" },
                values: new object[] { 7, 14 });

            migrationBuilder.UpdateData(
                table: "OHProducts",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "OrderHistoryId", "ProductId", "Quantity" },
                values: new object[] { 3, 28, 2 });

            migrationBuilder.UpdateData(
                table: "OHProducts",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "OrderHistoryId", "ProductId", "Quantity" },
                values: new object[] { 3, 22, 8 });

            migrationBuilder.UpdateData(
                table: "OHProducts",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "ProductId", "Quantity" },
                values: new object[] { 21, 18 });

            migrationBuilder.UpdateData(
                table: "OHProducts",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "OrderHistoryId", "ProductId", "Quantity" },
                values: new object[] { 3, 18, 7 });

            migrationBuilder.UpdateData(
                table: "OHProducts",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "OrderHistoryId", "ProductId", "Quantity" },
                values: new object[] { 4, 6, 13 });

            migrationBuilder.UpdateData(
                table: "OHProducts",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "OrderHistoryId", "Quantity" },
                values: new object[] { 2, 16 });

            migrationBuilder.UpdateData(
                table: "OHProducts",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "OrderHistoryId", "ProductId", "Quantity" },
                values: new object[] { 2, 5, 3 });

            migrationBuilder.UpdateData(
                table: "OHProducts",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "OrderHistoryId", "ProductId", "Quantity" },
                values: new object[] { 3, 6, 5 });

            migrationBuilder.UpdateData(
                table: "OHProducts",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "OrderHistoryId", "ProductId", "Quantity" },
                values: new object[] { 3, 7, 19 });

            migrationBuilder.UpdateData(
                table: "OHProducts",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "OrderHistoryId", "ProductId", "Quantity" },
                values: new object[] { 3, 11, 1 });

            migrationBuilder.UpdateData(
                table: "OHProducts",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "ProductId", "Quantity" },
                values: new object[] { 8, 18 });

            migrationBuilder.UpdateData(
                table: "OHProducts",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "OrderHistoryId", "ProductId", "Quantity" },
                values: new object[] { 1, 13, 3 });

            migrationBuilder.UpdateData(
                table: "OHProducts",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "OrderHistoryId", "ProductId", "Quantity" },
                values: new object[] { 2, 16, 7 });

            migrationBuilder.UpdateData(
                table: "OHProducts",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "ProductId", "Quantity" },
                values: new object[] { 25, 17 });

            migrationBuilder.UpdateData(
                table: "OHProducts",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "OrderHistoryId", "ProductId", "Quantity" },
                values: new object[] { 4, 13, 6 });

            migrationBuilder.UpdateData(
                table: "OHProducts",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "OrderHistoryId", "ProductId", "Quantity" },
                values: new object[] { 4, 9, 12 });

            migrationBuilder.UpdateData(
                table: "OHProducts",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "OrderHistoryId", "ProductId", "Quantity" },
                values: new object[] { 2, 14, 1 });

            migrationBuilder.UpdateData(
                table: "OHProducts",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "OrderHistoryId", "ProductId", "Quantity" },
                values: new object[] { 3, 10, 2 });

            migrationBuilder.UpdateData(
                table: "OHProducts",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "OrderHistoryId", "ProductId", "Quantity" },
                values: new object[] { 3, 29, 15 });

            migrationBuilder.UpdateData(
                table: "OHProducts",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "ProductId", "Quantity" },
                values: new object[] { 1, 10 });

            migrationBuilder.UpdateData(
                table: "OHProducts",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "ProductId", "Quantity" },
                values: new object[] { 12, 7 });

            migrationBuilder.UpdateData(
                table: "OHProducts",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "OrderHistoryId", "ProductId", "Quantity" },
                values: new object[] { 4, 27, 7 });

            migrationBuilder.UpdateData(
                table: "OHProducts",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "OrderHistoryId", "ProductId", "Quantity" },
                values: new object[] { 2, 22, 15 });

            migrationBuilder.UpdateData(
                table: "OHProducts",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "OrderHistoryId", "ProductId", "Quantity" },
                values: new object[] { 2, 5, 5 });

            migrationBuilder.UpdateData(
                table: "OHProducts",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "OrderHistoryId", "ProductId", "Quantity" },
                values: new object[] { 2, 24, 7 });

            migrationBuilder.UpdateData(
                table: "OrderHistories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CouponCode", "TimeCreated", "ToLocation" },
                values: new object[] { "ie6P2g", new DateTime(2022, 6, 21, 9, 38, 44, 128, DateTimeKind.Local).AddTicks(2949), "text well-made pin cent body tired body you fix numberless " });

            migrationBuilder.UpdateData(
                table: "OrderHistories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CouponCode", "TimeCreated", "ToLocation" },
                values: new object[] { "CjmLH4", new DateTime(2022, 6, 21, 9, 38, 44, 128, DateTimeKind.Local).AddTicks(3545), "naive naive fix naive one paragragh anything cent well-made walk " });

            migrationBuilder.UpdateData(
                table: "OrderHistories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CouponCode", "TimeCreated", "ToLocation" },
                values: new object[] { "4XG5c5", new DateTime(2022, 6, 21, 9, 38, 44, 128, DateTimeKind.Local).AddTicks(3577), "ten fix fix paragragh text pin thick walk hello tired " });

            migrationBuilder.UpdateData(
                table: "OrderHistories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CouponCode", "TimeCreated", "ToLocation" },
                values: new object[] { "l5L3qd", new DateTime(2022, 6, 21, 9, 38, 44, 128, DateTimeKind.Local).AddTicks(3596), "two something cent something ten one body body naive love " });

            migrationBuilder.UpdateData(
                table: "OrderHistories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CouponCode", "TimeCreated", "ToLocation" },
                values: new object[] { "3vflwf", new DateTime(2022, 6, 21, 9, 38, 44, 128, DateTimeKind.Local).AddTicks(3699), "two worried ten cent paragragh thick walk naive anything walk " });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CategoryId", "Code", "Description", "InStock", "Name", "Overeview", "Price", "SalesOff", "Total" },
                values: new object[] { 5, "0JIAAW", "else one text three three naive love bye walk numberless three naive paragragh ten body one else pig anything naive walk naive hello body bye numberless else anything pig pin text two pin you worried one bye else something industrious pin one thick something numberless naive naive one numberless bye ", 502, "bye fix ten hello ", "worried walk hello hello fix love industrious two text love something industrious naive numberless industrious bye text walk fix love ", 850f, 1, 965 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "BrandId", "Code", "Description", "InStock", "Name", "Overeview", "Price", "SalesOff", "Total" },
                values: new object[] { 2, "nVEsTv", "naive you pig ten hello three thick you hello industrious naive cent pig three pin bye anything something hello love three tired ten body thick walk ten industrious numberless bye numberless hello numberless worried you tired one three anything walk something paragragh thick walk naive three one industrious cent walk ", 550, "something you well-made walk ", "pig three something fix numberless pin something three naive something body love anything walk text worried love paragragh worried well-made ", 200f, 4, 517 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Code", "Description", "InStock", "Name", "Overeview", "Price", "SalesOff", "Total" },
                values: new object[] { "Z5HRaP", "walk paragragh text anything pig pig tired text cent tired you tired worried hello text fix cent bye well-made industrious bye pin industrious naive love bye two love two thick pig body something well-made two naive tired body thick else else body industrious ten walk else fix walk three walk ", 1208, "pin well-made three body ", "industrious worried anything something anything industrious text well-made walk industrious numberless two else one something else anything love naive three ", 520f, 3, 862 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "BrandId", "CategoryId", "Code", "Description", "InStock", "Name", "Overeview", "Price", "Total" },
                values: new object[] { 1, 5, "SMpZFu", "thick fix anything tired something pin you something body industrious you well-made else pig you two naive fix walk naive walk pin paragragh paragragh pig thick pig love else pig one text body walk one naive anything hello paragragh pin pig one two naive something else something three naive hello ", 363, "else one industrious three ", "paragragh love love tired pin cent cent two fix bye anything naive industrious walk numberless tired pin tired three you ", 80f, 1180 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "BrandId", "CategoryId", "Code", "Description", "InStock", "Name", "Overeview", "Price", "SalesOff", "Total" },
                values: new object[] { 3, 1, "pVpMHS", "bye bye one walk else paragragh thick fix pig well-made two you ten fix fix cent worried paragragh three well-made love body tired body you well-made numberless one one well-made hello paragragh hello two else paragragh anything bye you you hello well-made you three numberless one something text worried one ", 710, "text pin anything text ", "well-made hello text one something three text walk numberless else fix fix worried two text fix one cent walk body ", 340f, 14, 1629 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "BrandId", "CategoryId", "Code", "Description", "InStock", "Name", "Overeview", "Price", "Total" },
                values: new object[] { 4, 5, "GhFhSa", "tired bye hello worried something thick walk hello well-made else thick love numberless walk worried hello anything hello naive text body fix well-made bye hello bye something anything three pig tired love worried numberless fix love text something numberless love thick thick else numberless walk walk bye text walk industrious ", 1340, "else ten love numberless ", "tired cent paragragh else well-made two three you paragragh two numberless two you thick two thick tired pin you else ", 440f, 1856 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "BrandId", "CategoryId", "Code", "Description", "InStock", "Name", "Overeview", "Price", "SalesOff", "Total" },
                values: new object[] { 2, 3, "s7R8oJ", "walk anything thick hello two text body you industrious industrious text text paragragh text hello bye anything anything naive cent hello cent three industrious cent industrious else tired cent three two you industrious ten pig three something well-made else numberless pig bye tired well-made you industrious fix one ten hello ", 802, "paragragh pig something anything ", "paragragh body paragragh pig ten pig fix hello thick two ten walk pig well-made body anything text paragragh love hello ", 990f, 10, 1558 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "BrandId", "CategoryId", "Code", "Description", "InStock", "Name", "Overeview", "Price", "SalesOff", "Total" },
                values: new object[] { 2, 5, "9BFQUg", "hello tired ten pig text thick anything worried pin text ten worried paragragh numberless hello fix worried worried two naive hello worried three pin walk bye numberless walk love you body numberless fix else naive walk walk worried anything bye text worried well-made cent cent else three worried something walk ", 231, "pin two paragragh well-made ", "two body fix else you else pig pig love body ten one walk industrious something worried two text three three ", 980f, 7, 974 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "BrandId", "CategoryId", "Code", "Description", "InStock", "Name", "Overeview", "Price", "SalesOff", "Total" },
                values: new object[] { 3, 4, "UXjvDM", "anything anything thick anything something fix industrious paragragh walk pin you worried fix tired body text tired thick anything body well-made numberless you body hello you you bye hello tired industrious two walk cent three paragragh paragragh ten something three you fix love two fix paragragh well-made fix one body ", 1438, "pig text well-made worried ", "else industrious paragragh pig well-made body walk numberless two naive love else love one text you two else anything bye ", 520f, 14, 583 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "BrandId", "CategoryId", "Code", "Description", "InStock", "Name", "Overeview", "Price", "SalesOff", "Total" },
                values: new object[] { 4, 2, "Q1BWcu", "love well-made you body paragragh thick naive you naive pig cent pin else worried three body love naive body you one two love fix else else three text industrious pin else paragragh body numberless fix else thick two bye something pig three three ten something cent else tired anything else ", 1029, "bye two well-made three ", "anything well-made one well-made body two text worried industrious three walk naive bye paragragh something hello anything bye love love ", 610f, 14, 1269 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "BrandId", "CategoryId", "Code", "Description", "InStock", "Name", "Overeview", "Price", "SalesOff", "Total" },
                values: new object[] { 3, 3, "TQZcSD", "well-made pin paragragh cent well-made love pig fix numberless else pin bye worried walk worried numberless else ten pin thick ten worried naive two hello thick else three pin industrious three thick love two cent numberless love bye you paragragh anything thick pig body text well-made anything two thick body ", 824, "one something ten pig ", "numberless something text cent something well-made three thick something text ten numberless ten hello pin fix ten fix fix numberless ", 750f, 1, 115 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "BrandId", "CategoryId", "Code", "Description", "InStock", "Name", "Overeview", "Price", "SalesOff", "Total" },
                values: new object[] { 4, 4, "PGqJq4", "anything ten thick industrious thick text love body bye hello anything naive cent pin one tired one pig three two worried worried else three well-made naive well-made fix hello worried pin tired something body paragragh you cent body text fix pig love paragragh anything hello bye walk love else pin ", 426, "walk hello fix body ", "else bye numberless industrious cent cent love pig tired fix love thick you well-made tired numberless hello pin thick three ", 520f, 11, 470 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Code", "Description", "InStock", "Name", "Overeview", "Price", "SalesOff", "Total" },
                values: new object[] { "rxGhzA", "cent love pig anything ten something worried text body love thick naive hello anything three pin two pin ten anything something three fix tired tired thick walk industrious love numberless else numberless paragragh else thick three you naive love two fix three tired tired you numberless pig thick you worried ", 1315, "fix tired bye tired ", "text cent pig else walk two one thick pig pig tired paragragh naive text worried tired paragragh fix something three ", 780f, 10, 1531 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "BrandId", "CategoryId", "Code", "Description", "InStock", "Name", "Overeview", "Price", "SalesOff", "Total" },
                values: new object[] { 1, 2, "KVZ1ia", "tired industrious hello pin tired pin paragragh fix cent fix pin hello walk something hello hello ten you body hello something fix walk thick you thick thick well-made naive two ten industrious something naive you hello naive two two worried bye else numberless numberless ten body three love three two ", 1556, "fix pin three you ", "one three two body worried pig worried walk hello ten fix pin bye naive industrious three walk paragragh pig you ", 50f, 11, 719 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "BrandId", "CategoryId", "Code", "Description", "InStock", "Name", "Overeview", "Price", "SalesOff", "Total" },
                values: new object[] { 3, 5, "R72GGC", "pig three pin anything two walk hello one fix body two hello tired love worried anything cent three hello love pin you three naive one text bye walk hello cent worried thick pin cent something body love ten tired anything text ten tired body thick you paragragh paragragh paragragh two ", 538, "else bye industrious one ", "three you text pin worried walk naive love body anything tired cent two you one hello tired paragragh one hello ", 320f, 10, 1189 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "BrandId", "CategoryId", "Code", "Description", "InStock", "Name", "Overeview", "Price", "SalesOff", "Total" },
                values: new object[] { 4, 2, "cXBqY2", "industrious naive text well-made body cent tired bye well-made fix text worried worried cent fix bye bye two bye anything worried paragragh one walk love walk text paragragh you anything love cent tired pig industrious worried bye anything walk anything body anything pig text bye thick else three cent fix ", 782, "text pig numberless well-made ", "fix well-made walk cent industrious tired fix bye worried well-made bye three body something body ten fix you love one ", 240f, 14, 1676 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "BrandId", "CategoryId", "Code", "Description", "InStock", "Name", "Overeview", "Price", "SalesOff", "Total" },
                values: new object[] { 3, 3, "aWwdXu", "ten fix love paragragh thick numberless two fix hello thick naive body worried anything two three paragragh love hello else tired three pin walk you anything paragragh love walk one numberless worried something one ten pig body pig body anything body body industrious one love fix text paragragh you paragragh ", 1966, "fix something two naive ", "paragragh love numberless naive body one tired one anything walk fix three text bye one you one fix else pin ", 140f, 0, 1443 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "BrandId", "CategoryId", "Code", "Description", "InStock", "Name", "Overeview", "Price", "SalesOff", "Total" },
                values: new object[] { 2, 2, "l7bozZ", "worried two anything three love naive hello one something well-made text cent pig else industrious worried two two you else three fix naive worried well-made pin pig thick cent pig ten ten bye anything numberless paragragh something thick hello bye body naive you fix paragragh one cent text thick industrious ", 1107, "pig paragragh well-made anything ", "thick one cent naive three hello love one else fix text fix thick fix well-made pin anything fix tired thick ", 420f, 10, 778 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "BrandId", "CategoryId", "Code", "Description", "InStock", "Name", "Overeview", "Price", "SalesOff", "Total" },
                values: new object[] { 2, 5, "hsRyk0", "well-made three tired naive hello ten paragragh something bye you anything one body three anything three industrious pin two cent well-made cent numberless pin cent tired tired anything pin tired numberless pig hello pin else three anything well-made love text hello bye love ten one anything you one text pin ", 979, "pin industrious thick naive ", "something thick two thick bye well-made worried thick else bye bye you tired else three two pin industrious love fix ", 500f, 10, 135 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CategoryId", "Code", "Description", "InStock", "Name", "Overeview", "Price", "Total" },
                values: new object[] { 4, "MEvVJE", "three ten three two numberless two industrious ten naive else you ten anything you love anything thick two cent something you two body hello paragragh hello love anything two bye two two cent ten three pig worried two industrious well-made paragragh naive one numberless three bye thick one thick one ", 1679, "tired three two industrious ", "industrious anything cent worried love love worried you text paragragh pig pig hello walk hello love walk body you numberless ", 500f, 1303 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "BrandId", "CategoryId", "Code", "Description", "InStock", "Name", "Overeview", "Price", "SalesOff", "Total" },
                values: new object[] { 1, 2, "JMyWzi", "ten you something something hello paragragh paragragh one bye two worried ten pin one you well-made hello ten text text worried anything thick two cent you paragragh two tired tired two cent paragragh numberless bye text hello hello numberless numberless pin anything tired pig fix well-made anything numberless naive you ", 620, "paragragh cent walk ten ", "two worried industrious one three ten hello you you one pin anything something well-made worried naive one pin pin body ", 850f, 4, 1568 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "BrandId", "CategoryId", "Code", "Description", "InStock", "Name", "Overeview", "Price", "Total" },
                values: new object[] { 1, 5, "z0gCbl", "love fix well-made else cent fix pin fix numberless three three pig pig hello well-made body pin worried worried love pin something two something pig fix love bye something thick anything something bye walk industrious one else thick pin naive body pig something love thick well-made ten else else body ", 717, "pin cent worried industrious ", "pin anything numberless walk paragragh pin paragragh else text walk one industrious cent anything body else well-made bye one three ", 650f, 330 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CategoryId", "Code", "Description", "InStock", "Name", "Overeview", "Price", "SalesOff", "Total" },
                values: new object[] { 2, "wN0mWu", "well-made three fix love text numberless pin pig ten hello hello anything pin cent hello paragragh pig pin something pin pin bye love pin walk worried thick naive industrious thick something worried body numberless anything anything something one anything well-made something three numberless thick pig numberless text industrious two you ", 47, "one hello three else ", "paragragh numberless tired else naive something industrious three love paragragh pin text well-made numberless something cent three else text three ", 900f, 10, 1667 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Code", "Description", "InStock", "Name", "Overeview", "Price", "SalesOff", "Total" },
                values: new object[] { "xs6Zok", "worried naive well-made well-made pin well-made you thick one you else something bye body worried paragragh love numberless ten cent paragragh something pig two walk fix else bye cent tired body anything anything pin walk something text body bye love love text three hello one love body paragragh body something ", 845, "text text cent tired ", "anything anything walk bye industrious paragragh numberless tired tired walk hello bye paragragh worried tired pig text walk fix three ", 430f, 4, 1347 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "BrandId", "Code", "Description", "InStock", "Name", "Overeview", "Price", "SalesOff", "Total" },
                values: new object[] { 4, "DeBoAj", "bye else body text two numberless body anything pig hello bye else bye three cent bye body hello two one industrious hello body body text walk two something worried else three something cent two walk pin bye numberless you pin love something something three one industrious pig well-made walk anything ", 1932, "one thick cent worried ", "else hello ten bye numberless love one anything naive numberless ten three numberless thick fix you bye one body naive ", 900f, 6, 153 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "BrandId", "CategoryId", "Code", "Description", "InStock", "Name", "Overeview", "Price", "SalesOff", "Total" },
                values: new object[] { 3, 5, "OCq89a", "else ten thick cent naive one industrious hello bye bye love pin walk something two thick two industrious anything body tired tired text ten cent one bye thick bye industrious anything two love three well-made paragragh one hello ten fix three worried numberless cent two three you ten pin one ", 557, "hello thick ten something ", "bye anything something worried body you two two else fix three worried fix two you thick tired walk paragragh three ", 750f, 11, 691 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "BrandId", "CategoryId", "Code", "Description", "InStock", "Name", "Overeview", "Price", "SalesOff", "Total" },
                values: new object[] { 3, 2, "YQCk8w", "pig industrious tired body text body hello pin fix worried cent something two naive else bye tired cent paragragh something pin ten something worried anything hello tired two worried pig thick body numberless you body numberless body tired worried three something pig pin pin industrious text body love else worried ", 407, "pin text anything tired ", "worried tired tired love ten worried naive hello worried pig naive one cent thick something paragragh thick anything thick something ", 320f, 11, 443 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "BrandId", "CategoryId", "Code", "Description", "InStock", "Name", "Overeview", "Price", "SalesOff", "Total" },
                values: new object[] { 4, 1, "nfcSDO", "ten naive pig hello two else thick you pig paragragh fix love walk you worried naive hello numberless two naive cent pig paragragh anything text three well-made three paragragh body anything love well-made something tired well-made tired you pin love else industrious something well-made pig you tired worried numberless cent ", 840, "one you love cent ", "one else thick two one pin pin you body text ten two pin walk hello one anything pin anything cent ", 80f, 9, 1732 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "BrandId", "CategoryId", "Code", "Description", "InStock", "Name", "Overeview", "Price", "SalesOff", "Total" },
                values: new object[] { 4, 3, "AfiUtv", "fix two two you text numberless cent well-made fix worried anything thick fix text pig ten something cent well-made hello ten text body anything love numberless else anything pig pig paragragh two thick else industrious pin body something cent love fix three pig bye worried pig numberless anything bye else ", 611, "tired bye cent pig ", "something two bye you you two numberless text else numberless something bye else ten fix worried ten one you industrious ", 500f, 6, 1228 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "BrandId", "CategoryId", "Code", "Description", "InStock", "Name", "Overeview", "Price", "SalesOff", "Total" },
                values: new object[] { 2, 2, "SumoBn", "pig anything tired naive tired naive two one fix walk love industrious industrious ten naive pig naive walk love bye two you thick naive naive cent three hello something text ten naive thick pig pin pin thick pig you hello tired fix anything love worried naive thick pin well-made text ", 1555, "tired walk anything cent ", "body paragragh something pig ten pin body tired numberless body fix fix three one pin text fix something ten worried ", 380f, 4, 507 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Comment", "ProductId", "Rate", "TimePosted", "Title" },
                values: new object[] { "you paragragh tired one paragragh three ten pig you pin naive tired industrious cent body hello walk pin three ten walk you naive two bye industrious paragragh two fix naive ", 8, 1, new DateTime(2022, 6, 21, 9, 38, 44, 133, DateTimeKind.Local).AddTicks(5630), "bye tired two numberless pin walk bye " });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Comment", "Rate", "TimePosted", "Title" },
                values: new object[] { "bye well-made anything three naive you tired cent thick fix industrious love pin tired text you body fix three pin else industrious cent love two ten something fix three something ", 3, new DateTime(2022, 6, 21, 9, 38, 44, 133, DateTimeKind.Local).AddTicks(6174), "else anything pig bye cent hello one " });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Comment", "ProductId", "TimePosted", "Title" },
                values: new object[] { "else worried you thick cent naive fix well-made pig well-made thick one text something bye you fix numberless industrious walk one well-made anything thick paragragh something numberless well-made two worried ", 6, new DateTime(2022, 6, 21, 9, 38, 44, 133, DateTimeKind.Local).AddTicks(6324), "pin something fix pig one well-made industrious " });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Comment", "ProductId", "Rate", "TimePosted", "Title" },
                values: new object[] { "bye cent bye thick walk hello industrious numberless thick industrious bye three bye worried love tired tired cent bye something one well-made cent else worried numberless text something well-made bye ", 19, 1, new DateTime(2022, 6, 21, 9, 38, 44, 133, DateTimeKind.Local).AddTicks(6393), "else you hello worried you paragragh text " });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Comment", "ProductId", "TimePosted", "Title" },
                values: new object[] { "you else one text worried industrious pig else bye pin industrious text text walk industrious hello well-made body love walk worried ten fix three love fix thick industrious hello one ", 24, new DateTime(2022, 6, 21, 9, 38, 44, 133, DateTimeKind.Local).AddTicks(6460), "cent text pin two numberless numberless you " });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Comment", "ProductId", "Rate", "TimePosted", "Title" },
                values: new object[] { "one love tired cent something worried ten anything anything something one naive industrious cent text something worried well-made text three text text cent cent anything well-made paragragh walk pig two ", 5, 1, new DateTime(2022, 6, 21, 9, 38, 44, 133, DateTimeKind.Local).AddTicks(6532), "thick bye tired something anything body one " });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Comment", "ProductId", "Rate", "TimePosted", "Title" },
                values: new object[] { "else numberless hello fix hello you walk text cent ten ten hello text well-made paragragh naive love else walk walk thick tired two else naive hello industrious something cent you ", 11, 4, new DateTime(2022, 6, 21, 9, 38, 44, 133, DateTimeKind.Local).AddTicks(6607), "hello else anything pig thick paragragh two " });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Comment", "ProductId", "Rate", "TimePosted", "Title" },
                values: new object[] { "well-made paragragh bye one tired hello industrious fix walk anything two fix text bye thick fix well-made hello three industrious pin three one one pig fix anything anything pig walk ", 29, 3, new DateTime(2022, 6, 21, 9, 38, 44, 133, DateTimeKind.Local).AddTicks(6693), "love bye tired numberless paragragh walk pig " });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Comment", "ProductId", "Rate", "TimePosted", "Title" },
                values: new object[] { "cent walk pin love text one fix something naive cent body ten pig thick walk else fix cent body pig anything one worried worried body body hello you text two ", 27, 1, new DateTime(2022, 6, 21, 9, 38, 44, 133, DateTimeKind.Local).AddTicks(6777), "worried one body anything hello love three " });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Comment", "ProductId", "Rate", "TimePosted", "Title" },
                values: new object[] { "body three ten two ten naive fix else paragragh thick pig bye pig love one walk something industrious you you text numberless one anything paragragh well-made tired naive body paragragh ", 10, 4, new DateTime(2022, 6, 21, 9, 38, 44, 133, DateTimeKind.Local).AddTicks(6822), "two fix pig something love body anything " });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Comment", "ProductId", "Rate", "TimePosted", "Title" },
                values: new object[] { "three bye pig paragragh one fix industrious something text love numberless pin ten industrious numberless worried anything pig love three one you industrious text pin pin something pin anything love ", 3, 2, new DateTime(2022, 6, 21, 9, 38, 44, 133, DateTimeKind.Local).AddTicks(6911), "else hello naive body fix worried anything " });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Comment", "ProductId", "Rate", "TimePosted", "Title" },
                values: new object[] { "hello else something else fix you text bye one fix cent numberless cent well-made worried three you tired two paragragh bye three numberless else love ten body naive numberless pin ", 20, 1, new DateTime(2022, 6, 21, 9, 38, 44, 133, DateTimeKind.Local).AddTicks(6996), "industrious else text industrious thick tired naive " });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Comment", "ProductId", "TimePosted", "Title" },
                values: new object[] { "ten pig hello numberless one ten ten you three one you cent anything three two hello else two anything three else anything tired hello one paragragh fix fix you love ", 28, new DateTime(2022, 6, 21, 9, 38, 44, 133, DateTimeKind.Local).AddTicks(7062), "text two well-made tired cent you walk " });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Comment", "ProductId", "Rate", "TimePosted", "Title" },
                values: new object[] { "you numberless you worried paragragh worried three text you pin ten text two anything thick body love you pin hello ten naive naive body body something pin hello walk numberless ", 4, 3, new DateTime(2022, 6, 21, 9, 38, 44, 133, DateTimeKind.Local).AddTicks(7126), "you else paragragh ten fix numberless paragragh " });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Comment", "ProductId", "Rate", "TimePosted", "Title" },
                values: new object[] { "naive text numberless one fix worried worried thick anything naive paragragh you one pin well-made text one text you cent worried worried thick bye three you naive ten bye love ", 17, 3, new DateTime(2022, 6, 21, 9, 38, 44, 133, DateTimeKind.Local).AddTicks(7193), "fix you industrious numberless ten ten ten " });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Comment", "ProductId", "Rate", "TimePosted", "Title" },
                values: new object[] { "three three well-made numberless cent fix cent one fix something thick hello industrious love two hello walk thick bye paragragh bye ten thick love numberless paragragh one ten pig naive ", 15, 4, new DateTime(2022, 6, 21, 9, 38, 44, 133, DateTimeKind.Local).AddTicks(7255), "walk industrious well-made text ten paragragh paragragh " });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Comment", "ProductId", "Rate", "TimePosted", "Title" },
                values: new object[] { "industrious else thick you worried worried tired hello thick bye ten bye tired well-made pin tired numberless hello tired body fix you thick well-made industrious cent fix text naive ten ", 7, 1, new DateTime(2022, 6, 21, 9, 38, 44, 133, DateTimeKind.Local).AddTicks(7283), "anything ten ten numberless thick love numberless " });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Comment", "ProductId", "Rate", "TimePosted", "Title" },
                values: new object[] { "text else well-made cent pig bye three industrious text paragragh thick pin you hello numberless paragragh cent pig industrious ten body text else cent one pig cent thick walk ten ", 29, 1, new DateTime(2022, 6, 21, 9, 38, 44, 133, DateTimeKind.Local).AddTicks(7412), "two worried cent fix numberless cent you " });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Comment", "ProductId", "Rate", "TimePosted", "Title" },
                values: new object[] { "text pig numberless paragragh anything anything ten naive worried industrious fix well-made ten industrious industrious walk pin body industrious something pin thick fix love you ten worried love something ten ", 22, 1, new DateTime(2022, 6, 21, 9, 38, 44, 133, DateTimeKind.Local).AddTicks(7500), "walk worried well-made else naive cent text " });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Comment", "ProductId", "Rate", "TimePosted", "Title" },
                values: new object[] { "well-made ten anything pin pig ten bye walk worried numberless pin else naive numberless industrious industrious thick three walk three worried ten you else thick naive love ten one text ", 17, 4, new DateTime(2022, 6, 21, 9, 38, 44, 133, DateTimeKind.Local).AddTicks(7590), "two fix walk thick bye you anything " });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Comment", "ProductId", "Rate", "TimePosted", "Title" },
                values: new object[] { "industrious thick two pin three something worried fix bye thick worried body else text industrious something fix love well-made else anything anything paragragh something fix hello text two industrious walk ", 8, 1, new DateTime(2022, 6, 21, 9, 38, 44, 133, DateTimeKind.Local).AddTicks(7672), "naive numberless well-made love three numberless naive " });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Comment", "ProductId", "Rate", "TimePosted", "Title" },
                values: new object[] { "numberless well-made you naive fix tired text you two anything two tired anything ten something walk cent something anything one thick you bye naive pig industrious industrious anything pin two ", 19, 1, new DateTime(2022, 6, 21, 9, 38, 44, 133, DateTimeKind.Local).AddTicks(7754), "pin numberless else industrious hello bye ten " });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Comment", "ProductId", "Rate", "TimePosted", "Title" },
                values: new object[] { "walk text one industrious something hello three pig walk tired fix anything love one walk text cent text one numberless naive pig ten you pin naive hello text worried two ", 7, 2, new DateTime(2022, 6, 21, 9, 38, 44, 133, DateTimeKind.Local).AddTicks(7816), "industrious else three cent fix numberless two " });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Comment", "ProductId", "TimePosted", "Title" },
                values: new object[] { "love hello three love one one something paragragh one hello industrious pin text hello bye body you anything else industrious pig body industrious worried something cent pig thick bye three ", 10, new DateTime(2022, 6, 21, 9, 38, 44, 133, DateTimeKind.Local).AddTicks(7880), "cent two naive paragragh love ten three " });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Comment", "ProductId", "Rate", "TimePosted", "Title" },
                values: new object[] { "thick thick one anything walk numberless one hello else numberless thick three you worried text two love thick else well-made thick well-made well-made well-made text worried walk else you ten ", 27, 1, new DateTime(2022, 6, 21, 9, 38, 44, 133, DateTimeKind.Local).AddTicks(7945), "you thick three text two bye fix " });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Title",
                table: "Reviews");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db12554843e5",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "1d03134c-fe08-487d-af5e-9e30030d975d", "30f96a71-c175-42b6-82d5-40a3cf149866" });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Author", "Content", "Tag", "TimePosted", "Title" },
                values: new object[] { "worried fix ", "paragragh anything well-made something industrious numberless else bye thick walk cent one hello ten hello worried thick pin two worried industrious tired numberless anything pig fix well-made walk industrious thick ten walk numberless you text industrious bye fix industrious well-made paragragh cent you three you something numberless anything numberless thick cent text thick fix hello thick love naive naive something three hello fix pin tired body bye two industrious tired two anything anything thick tired anything hello walk pin else tired pig worried text cent numberless love something fix naive walk cent industrious hello fix pig paragragh you fix anything ", "love else paragragh well-made ", new DateTime(2022, 6, 20, 14, 49, 30, 341, DateTimeKind.Local).AddTicks(4794), "walk one paragragh one hello one paragragh anything one two " });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Author", "Content", "Tag", "TimePosted", "Title" },
                values: new object[] { "worried numberless ", "naive text three naive industrious love cent paragragh cent fix three fix anything worried cent one ten industrious one anything tired hello body anything well-made love two love fix one love fix well-made you anything pin numberless industrious three well-made pig worried hello pig tired naive numberless you thick naive love walk industrious well-made industrious love text you numberless well-made well-made pig pig something one thick walk pin walk worried hello text pig pig else pig body else bye anything ten else bye industrious text something thick body ten numberless naive cent pin one body body three love paragragh pin ", "text walk love worried ", new DateTime(2022, 6, 20, 14, 49, 30, 342, DateTimeKind.Local).AddTicks(9039), "ten body pin one you something naive something walk bye " });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Author", "Content", "Tag", "TimePosted", "Title" },
                values: new object[] { "two something ", "paragragh walk you you pin well-made well-made worried three naive else text pig else fix worried anything bye ten text body naive well-made one text bye tired anything cent pig three love industrious tired walk two anything three pin you three two thick bye fix well-made bye you thick paragragh industrious love thick paragragh two fix body thick walk hello three pig anything one hello three something you hello three walk worried bye you you thick body text industrious hello pin hello two fix cent body bye naive ten ten something two something bye numberless bye something ten numberless something ", "fix bye bye body ", new DateTime(2022, 6, 20, 14, 49, 30, 342, DateTimeKind.Local).AddTicks(9497), "anything three two three love numberless thick worried hello two " });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Author", "Content", "Tag", "TimePosted", "Title" },
                values: new object[] { "thick hello ", "text bye tired bye pig pig industrious else cent something bye body three thick paragragh cent else hello love thick numberless numberless you walk something numberless hello one naive tired thick you pin text three worried tired bye naive pig one paragragh naive you hello thick something fix hello naive two paragragh love worried pig something two cent you well-made three bye thick ten pig something body worried one two paragragh worried worried one three pig text pin paragragh pig fix pin industrious pin three two pin you tired walk one walk something industrious hello pin thick one something three ", "you love one fix ", new DateTime(2022, 6, 20, 14, 49, 30, 342, DateTimeKind.Local).AddTicks(9865), "thick fix three well-made hello well-made well-made text hello thick " });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Author", "Content", "Tag", "TimePosted", "Title" },
                values: new object[] { "love three ", "fix thick body else two industrious paragragh thick numberless bye bye pin industrious ten you cent thick you you anything industrious walk fix tired body paragragh two tired pig anything ten pin pig else two pin two anything well-made pig paragragh one ten pin anything two walk hello industrious paragragh walk one text three text well-made you one text love hello naive numberless worried paragragh hello paragragh tired walk you two fix something something walk one tired fix fix thick bye worried naive bye paragragh well-made pig fix body naive industrious pin walk tired ten tired hello else well-made fix ", "well-made cent cent paragragh ", new DateTime(2022, 6, 20, 14, 49, 30, 343, DateTimeKind.Local).AddTicks(214), "something pig pig pin you two fix something ten ten " });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Author", "Content", "Tag", "TimePosted", "Title" },
                values: new object[] { "fix you ", "pin bye thick bye walk pig tired love three one walk well-made three ten numberless text cent pin bye text love worried thick body naive cent three three hello two you you numberless fix thick anything naive paragragh well-made one tired thick naive two one something pig three industrious worried pig industrious ten something hello love cent thick cent pin hello one tired walk else naive walk thick tired industrious tired fix ten body naive hello ten paragragh fix text you body paragragh thick naive ten industrious fix anything bye ten anything one walk industrious three body worried anything well-made ", "fix pin paragragh three ", new DateTime(2022, 6, 20, 14, 49, 30, 343, DateTimeKind.Local).AddTicks(584), "you industrious something worried three hello worried naive naive thick " });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Author", "Content", "Tag", "TimePosted", "Title" },
                values: new object[] { "pig text ", "three pin you love well-made ten tired you pig fix you one love hello bye else three cent well-made body one text something hello hello well-made worried anything fix thick body numberless worried two body body well-made numberless body else bye bye text pig anything paragragh body three hello tired two paragragh walk worried anything industrious tired tired thick body something fix hello anything fix love fix well-made bye bye fix ten cent two hello pin pin naive one paragragh pig naive hello pin ten well-made three body else you two three else pin pin numberless pin ten love industrious ", "naive body body three ", new DateTime(2022, 6, 20, 14, 49, 30, 343, DateTimeKind.Local).AddTicks(1012), "pig three pig body numberless tired anything hello industrious hello " });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Author", "Content", "Tag", "TimePosted", "Title" },
                values: new object[] { "hello cent ", "body hello worried walk pin fix two something anything something industrious cent one tired pin well-made hello fix fix one pin hello numberless body else walk naive paragragh ten bye anything numberless pig else industrious one something something numberless three worried else pin thick paragragh thick numberless pig you three one tired cent cent naive hello tired cent bye three worried three three tired else pin you you pig fix something three tired two fix naive hello text well-made pig worried numberless three body anything bye you industrious thick two worried fix industrious well-made text pig love two else text ", "body hello walk text ", new DateTime(2022, 6, 20, 14, 49, 30, 343, DateTimeKind.Local).AddTicks(1467), "one something else you industrious numberless love something text naive " });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Author", "Content", "Tag", "TimePosted", "Title" },
                values: new object[] { "thick thick ", "pin three fix worried worried ten one else pig cent text worried you worried fix love numberless bye three body numberless thick paragragh walk hello naive thick naive two fix hello love two two well-made pin worried bye two else something pig cent pin body you else two two worried else fix tired text pin something industrious walk something ten fix walk industrious three else love one pig love tired text bye you worried thick ten cent paragragh walk two something paragragh paragragh hello ten numberless hello love one something anything anything love ten walk tired walk thick naive worried ", "text cent tired worried ", new DateTime(2022, 6, 20, 14, 49, 30, 343, DateTimeKind.Local).AddTicks(1902), "pin one paragragh pin pin text anything well-made else industrious " });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Author", "Content", "Tag", "TimePosted", "Title" },
                values: new object[] { "body anything ", "hello two numberless something tired else text well-made fix ten something industrious you body one three tired industrious well-made well-made pin one numberless something one walk one naive worried two anything three something bye you two naive text paragragh else else hello paragragh something bye tired naive thick else something anything you ten you else anything one tired industrious walk worried tired industrious three love three fix tired numberless body bye text naive one two one three fix worried worried love cent something bye else pin pin paragragh love body numberless you something one one well-made thick you paragragh else ", "naive text worried well-made ", new DateTime(2022, 6, 20, 14, 49, 30, 343, DateTimeKind.Local).AddTicks(2296), "bye well-made naive well-made hello naive body numberless cent text " });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Author", "Content", "Tag", "TimePosted", "Title" },
                values: new object[] { "well-made paragragh ", "ten two worried love ten text bye numberless anything two numberless ten pin naive cent you else fix worried you three you thick fix fix ten hello paragragh love anything else else walk two hello paragragh paragragh you you pig fix well-made ten bye cent ten walk anything anything cent fix ten three fix worried love walk text tired body walk ten cent pin anything tired one fix love tired cent paragragh one love hello two worried love pig something two bye ten text hello love love ten fix two one numberless bye you numberless something numberless ten one paragragh ", "industrious bye pin else ", new DateTime(2022, 6, 20, 14, 49, 30, 343, DateTimeKind.Local).AddTicks(2641), "two walk pig worried industrious worried well-made body naive body " });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Author", "Content", "Tag", "TimePosted", "Title" },
                values: new object[] { "tired two ", "body hello bye industrious one paragragh body well-made love industrious well-made else three three bye thick pig bye thick three fix well-made else ten something anything three anything love cent something paragragh hello naive else one well-made hello walk bye ten three else you fix two industrious worried pin thick numberless you tired two pig paragragh three paragragh hello something you numberless tired text hello bye cent hello cent anything industrious ten pig love numberless two two ten thick pin three text you hello industrious paragragh naive you numberless you paragragh bye pin two two text fix anything fix you ", "body numberless pig pig ", new DateTime(2022, 6, 20, 14, 49, 30, 343, DateTimeKind.Local).AddTicks(3015), "well-made anything anything bye paragragh thick tired ten tired text " });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Author", "Content", "Tag", "TimePosted", "Title" },
                values: new object[] { "numberless naive ", "worried you two text cent pig fix well-made cent two paragragh else pig naive cent something thick fix two walk paragragh love walk three worried three thick tired ten paragragh worried two three thick one one thick text paragragh worried cent text love else bye you walk walk hello hello else anything three one hello pig else ten two naive you numberless hello fix fix cent love you ten something pig else text hello numberless pin body one pig walk something cent you pig numberless walk ten well-made you pig love two worried tired walk industrious well-made fix well-made thick ", "tired love walk pin ", new DateTime(2022, 6, 20, 14, 49, 30, 343, DateTimeKind.Local).AddTicks(3340), "two bye bye else worried pin thick fix ten walk " });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Author", "Content", "Tag", "TimePosted", "Title" },
                values: new object[] { "well-made naive ", "worried cent thick walk tired two body bye paragragh else bye naive well-made anything ten one naive anything cent naive paragragh numberless numberless numberless pin fix paragragh hello anything paragragh worried paragragh else hello body numberless numberless pin body fix naive you industrious one hello you industrious one else ten three one cent tired body industrious worried naive walk body love bye one body one ten something paragragh body text hello pig body paragragh body three anything bye one industrious naive walk three cent anything two two well-made hello love anything text ten body one ten thick industrious pin text ", "one anything pig bye ", new DateTime(2022, 6, 20, 14, 49, 30, 343, DateTimeKind.Local).AddTicks(3742), "walk naive bye fix naive worried hello thick text paragragh " });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Author", "Content", "Tag", "TimePosted", "Title" },
                values: new object[] { "body pin ", "text thick numberless body cent tired well-made worried ten paragragh bye body cent walk hello three bye love love body else love you fix pin cent three thick text naive anything else thick you industrious pin numberless pin bye love numberless tired cent one body two well-made walk else naive industrious you well-made something body three hello two body pin one you fix fix ten love something well-made industrious fix paragragh hello naive body you well-made text thick fix tired you two else thick well-made numberless tired text anything well-made one fix numberless hello pig cent body text paragragh worried ", "worried walk one two ", new DateTime(2022, 6, 20, 14, 49, 30, 343, DateTimeKind.Local).AddTicks(4115), "one fix fix worried cent two paragragh worried something something " });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Author", "Content", "Tag", "TimePosted", "Title" },
                values: new object[] { "pig cent ", "well-made numberless walk paragragh hello you naive love you naive tired three text paragragh well-made body two naive tired you hello fix three something hello worried body cent worried tired naive hello thick naive you anything bye pin something numberless else pig pig well-made walk paragragh one anything hello worried bye ten cent well-made hello ten walk two well-made naive anything worried paragragh hello body anything hello tired love pig hello two else thick walk walk worried two fix paragragh one pin else body you bye naive worried three industrious paragragh you paragragh naive worried one bye ten well-made well-made ", "industrious cent something anything ", new DateTime(2022, 6, 20, 14, 49, 30, 343, DateTimeKind.Local).AddTicks(4461), "one well-made text paragragh worried worried worried one worried body " });

            migrationBuilder.UpdateData(
                table: "OHProducts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "OrderHistoryId", "ProductId", "Quantity" },
                values: new object[] { 3, 20, 2 });

            migrationBuilder.UpdateData(
                table: "OHProducts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "OrderHistoryId", "ProductId", "Quantity" },
                values: new object[] { 4, 3, 17 });

            migrationBuilder.UpdateData(
                table: "OHProducts",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ProductId", "Quantity" },
                values: new object[] { 15, 9 });

            migrationBuilder.UpdateData(
                table: "OHProducts",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "OrderHistoryId", "ProductId", "Quantity" },
                values: new object[] { 3, 10, 9 });

            migrationBuilder.UpdateData(
                table: "OHProducts",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ProductId", "Quantity" },
                values: new object[] { 8, 13 });

            migrationBuilder.UpdateData(
                table: "OHProducts",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "OrderHistoryId", "ProductId", "Quantity" },
                values: new object[] { 1, 16, 17 });

            migrationBuilder.UpdateData(
                table: "OHProducts",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "OrderHistoryId", "Quantity" },
                values: new object[] { 2, 8 });

            migrationBuilder.UpdateData(
                table: "OHProducts",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "ProductId", "Quantity" },
                values: new object[] { 22, 11 });

            migrationBuilder.UpdateData(
                table: "OHProducts",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "OrderHistoryId", "ProductId" },
                values: new object[] { 4, 27 });

            migrationBuilder.UpdateData(
                table: "OHProducts",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "OrderHistoryId", "ProductId", "Quantity" },
                values: new object[] { 2, 11, 14 });

            migrationBuilder.UpdateData(
                table: "OHProducts",
                keyColumn: "Id",
                keyValue: 11,
                column: "Quantity",
                value: 1);

            migrationBuilder.UpdateData(
                table: "OHProducts",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "OrderHistoryId", "ProductId", "Quantity" },
                values: new object[] { 4, 12, 4 });

            migrationBuilder.UpdateData(
                table: "OHProducts",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "OrderHistoryId", "ProductId", "Quantity" },
                values: new object[] { 3, 18, 17 });

            migrationBuilder.UpdateData(
                table: "OHProducts",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "ProductId", "Quantity" },
                values: new object[] { 9, 12 });

            migrationBuilder.UpdateData(
                table: "OHProducts",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "ProductId", "Quantity" },
                values: new object[] { 18, 13 });

            migrationBuilder.UpdateData(
                table: "OHProducts",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "OrderHistoryId", "ProductId", "Quantity" },
                values: new object[] { 2, 20, 16 });

            migrationBuilder.UpdateData(
                table: "OHProducts",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "OrderHistoryId", "ProductId", "Quantity" },
                values: new object[] { 1, 21, 7 });

            migrationBuilder.UpdateData(
                table: "OHProducts",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "ProductId", "Quantity" },
                values: new object[] { 23, 14 });

            migrationBuilder.UpdateData(
                table: "OHProducts",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "OrderHistoryId", "ProductId", "Quantity" },
                values: new object[] { 2, 26, 18 });

            migrationBuilder.UpdateData(
                table: "OHProducts",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "OrderHistoryId", "ProductId", "Quantity" },
                values: new object[] { 2, 5, 4 });

            migrationBuilder.UpdateData(
                table: "OHProducts",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "OrderHistoryId", "Quantity" },
                values: new object[] { 3, 3 });

            migrationBuilder.UpdateData(
                table: "OHProducts",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "OrderHistoryId", "ProductId", "Quantity" },
                values: new object[] { 3, 26, 15 });

            migrationBuilder.UpdateData(
                table: "OHProducts",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "OrderHistoryId", "ProductId", "Quantity" },
                values: new object[] { 2, 12, 17 });

            migrationBuilder.UpdateData(
                table: "OHProducts",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "OrderHistoryId", "ProductId", "Quantity" },
                values: new object[] { 2, 11, 18 });

            migrationBuilder.UpdateData(
                table: "OHProducts",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "OrderHistoryId", "ProductId", "Quantity" },
                values: new object[] { 4, 10, 11 });

            migrationBuilder.UpdateData(
                table: "OHProducts",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "ProductId", "Quantity" },
                values: new object[] { 6, 3 });

            migrationBuilder.UpdateData(
                table: "OHProducts",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "OrderHistoryId", "ProductId", "Quantity" },
                values: new object[] { 4, 15, 5 });

            migrationBuilder.UpdateData(
                table: "OHProducts",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "OrderHistoryId", "ProductId", "Quantity" },
                values: new object[] { 3, 2, 13 });

            migrationBuilder.UpdateData(
                table: "OHProducts",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "ProductId", "Quantity" },
                values: new object[] { 22, 16 });

            migrationBuilder.UpdateData(
                table: "OHProducts",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "OrderHistoryId", "ProductId", "Quantity" },
                values: new object[] { 2, 20, 10 });

            migrationBuilder.UpdateData(
                table: "OHProducts",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "OrderHistoryId", "ProductId", "Quantity" },
                values: new object[] { 1, 5, 10 });

            migrationBuilder.UpdateData(
                table: "OHProducts",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "OrderHistoryId", "ProductId", "Quantity" },
                values: new object[] { 3, 13, 10 });

            migrationBuilder.UpdateData(
                table: "OHProducts",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "OrderHistoryId", "ProductId", "Quantity" },
                values: new object[] { 2, 25, 15 });

            migrationBuilder.UpdateData(
                table: "OHProducts",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "OrderHistoryId", "ProductId", "Quantity" },
                values: new object[] { 4, 27, 6 });

            migrationBuilder.UpdateData(
                table: "OHProducts",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "ProductId", "Quantity" },
                values: new object[] { 23, 7 });

            migrationBuilder.UpdateData(
                table: "OHProducts",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "ProductId", "Quantity" },
                values: new object[] { 2, 8 });

            migrationBuilder.UpdateData(
                table: "OHProducts",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "OrderHistoryId", "ProductId", "Quantity" },
                values: new object[] { 1, 15, 13 });

            migrationBuilder.UpdateData(
                table: "OHProducts",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "OrderHistoryId", "ProductId", "Quantity" },
                values: new object[] { 4, 17, 13 });

            migrationBuilder.UpdateData(
                table: "OHProducts",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "OrderHistoryId", "ProductId", "Quantity" },
                values: new object[] { 4, 1, 14 });

            migrationBuilder.UpdateData(
                table: "OHProducts",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "OrderHistoryId", "ProductId", "Quantity" },
                values: new object[] { 3, 12, 3 });

            migrationBuilder.UpdateData(
                table: "OrderHistories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CouponCode", "TimeCreated", "ToLocation" },
                values: new object[] { "HyBSpm", new DateTime(2022, 6, 20, 14, 49, 30, 346, DateTimeKind.Local).AddTicks(5008), "worried bye paragragh you fix paragragh two hello two naive " });

            migrationBuilder.UpdateData(
                table: "OrderHistories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CouponCode", "TimeCreated", "ToLocation" },
                values: new object[] { "jvjj0X", new DateTime(2022, 6, 20, 14, 49, 30, 346, DateTimeKind.Local).AddTicks(5415), "walk else else naive naive cent fix tired you bye " });

            migrationBuilder.UpdateData(
                table: "OrderHistories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CouponCode", "TimeCreated", "ToLocation" },
                values: new object[] { "U8XgGg", new DateTime(2022, 6, 20, 14, 49, 30, 346, DateTimeKind.Local).AddTicks(5431), "fix industrious paragragh walk one walk industrious ten walk paragragh " });

            migrationBuilder.UpdateData(
                table: "OrderHistories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CouponCode", "TimeCreated", "ToLocation" },
                values: new object[] { "p7kUmE", new DateTime(2022, 6, 20, 14, 49, 30, 346, DateTimeKind.Local).AddTicks(5444), "industrious paragragh two thick something naive pig body numberless thick " });

            migrationBuilder.UpdateData(
                table: "OrderHistories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CouponCode", "TimeCreated", "ToLocation" },
                values: new object[] { "A7ZnGD", new DateTime(2022, 6, 20, 14, 49, 30, 346, DateTimeKind.Local).AddTicks(5454), "walk numberless naive fix three something three pin one you " });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CategoryId", "Code", "Description", "InStock", "Name", "Overeview", "Price", "SalesOff", "Total" },
                values: new object[] { 4, "Hkefzj", "three paragragh walk else hello one bye fix numberless worried paragragh hello worried hello cent walk something pin hello something ten tired bye one anything love paragragh pig one text pin fix text thick you cent you worried pig two else ten numberless walk three cent hello well-made thick ten ", 1941, "love pig love something ", "you industrious three ten worried walk walk worried thick one something two paragragh bye pin cent well-made fix you two ", 550f, 4, 536 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "BrandId", "Code", "Description", "InStock", "Name", "Overeview", "Price", "SalesOff", "Total" },
                values: new object[] { 1, "wYMptl", "fix fix one bye body walk tired else ten hello you text industrious bye fix text text thick fix numberless bye numberless naive paragragh pin love anything body walk pig well-made numberless walk naive love pig walk pin numberless industrious numberless pin industrious hello industrious something well-made walk naive else ", 676, "ten walk love thick ", "paragragh ten one pin naive hello text you anything pin thick naive text ten tired hello anything ten cent ten ", 780f, 1, 1212 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Code", "Description", "InStock", "Name", "Overeview", "Price", "SalesOff", "Total" },
                values: new object[] { "RXGxeF", "paragragh industrious numberless hello cent tired bye anything three something one something pig well-made worried hello one cent walk industrious well-made body industrious three tired well-made worried industrious fix one ten anything anything bye industrious tired text walk anything numberless cent thick bye thick you naive two tired well-made worried ", 653, "pig fix hello hello ", "bye paragragh else worried hello else naive naive pin hello body love else tired something paragragh something bye bye else ", 200f, 6, 950 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "BrandId", "CategoryId", "Code", "Description", "InStock", "Name", "Overeview", "Price", "Total" },
                values: new object[] { 4, 4, "ZtBND6", "something one industrious thick thick hello worried pin ten paragragh love well-made bye pig else three pig bye naive love walk walk hello bye well-made naive pig body pig one two cent anything hello body worried something paragragh thick naive walk walk naive walk pin well-made cent something tired three ", 1955, "pig fix hello pig ", "else paragragh worried text ten naive well-made worried anything you hello text you numberless else text three naive naive thick ", 450f, 695 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "BrandId", "CategoryId", "Code", "Description", "InStock", "Name", "Overeview", "Price", "SalesOff", "Total" },
                values: new object[] { 1, 4, "IaFkHD", "cent fix thick one numberless numberless something pig cent pin hello industrious numberless pig anything worried pig love else anything worried body three worried one three numberless worried you hello two naive worried love bye three text ten bye worried love love love something bye ten cent walk numberless pin ", 1521, "cent cent paragragh well-made ", "pig numberless naive one cent bye cent pin something pin love well-made bye pin worried else one fix industrious well-made ", 400f, 2, 1454 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "BrandId", "CategoryId", "Code", "Description", "InStock", "Name", "Overeview", "Price", "Total" },
                values: new object[] { 2, 1, "HOmN9M", "one body paragragh pig walk hello ten pig worried thick hello cent cent thick three body fix anything two you thick walk industrious three worried tired two walk one worried fix hello two one two body tired hello love anything text numberless tired text three anything numberless walk anything something ", 636, "body bye tired else ", "anything cent paragragh industrious fix bye thick one numberless pig industrious walk two ten something love numberless you industrious love ", 400f, 300 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "BrandId", "CategoryId", "Code", "Description", "InStock", "Name", "Overeview", "Price", "SalesOff", "Total" },
                values: new object[] { 4, 5, "gV24Ky", "cent tired pin well-made industrious bye pig numberless numberless cent pig fix ten three thick tired fix industrious numberless tired pin else pin walk one hello you body fix hello pig love well-made one three cent two one paragragh numberless else pin two pin pin thick two walk three anything ", 1650, "love one paragragh body ", "one something ten three two body industrious something cent naive ten tired pin cent thick tired pig you paragragh naive ", 970f, 4, 405 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "BrandId", "CategoryId", "Code", "Description", "InStock", "Name", "Overeview", "Price", "SalesOff", "Total" },
                values: new object[] { 4, 3, "TfYzqm", "pin you well-made pig ten paragragh love worried fix thick fix pin worried one cent tired cent two industrious industrious ten three two naive fix thick something hello paragragh anything worried industrious numberless paragragh fix pig anything text fix industrious pin well-made one thick one pin love something numberless hello ", 829, "something pig two one ", "walk walk pin walk three love thick pin paragragh body numberless pin cent walk love else cent bye bye worried ", 500f, 6, 1168 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "BrandId", "CategoryId", "Code", "Description", "InStock", "Name", "Overeview", "Price", "SalesOff", "Total" },
                values: new object[] { 1, 2, "VMT51X", "else something tired well-made body pin love numberless body something love pin worried walk numberless hello hello cent numberless pin thick tired naive three you industrious cent fix love numberless anything worried industrious else else thick body you you tired two worried pin fix something well-made industrious one thick pin ", 425, "industrious thick thick bye ", "body thick worried love fix hello cent pin industrious bye pig walk paragragh tired bye pin fix well-made fix one ", 550f, 5, 617 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "BrandId", "CategoryId", "Code", "Description", "InStock", "Name", "Overeview", "Price", "SalesOff", "Total" },
                values: new object[] { 3, 4, "LQSjT2", "you text hello fix numberless tired two pin one walk anything industrious paragragh love naive else pin text bye anything pin one body anything love tired thick else you walk naive naive tired numberless three well-made anything industrious two worried pin walk industrious walk pig pig worried naive naive pig ", 683, "love tired cent anything ", "anything fix bye else bye two well-made something tired well-made thick love walk else body something numberless love bye else ", 620f, 8, 820 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "BrandId", "CategoryId", "Code", "Description", "InStock", "Name", "Overeview", "Price", "SalesOff", "Total" },
                values: new object[] { 4, 4, "oUsiio", "body love tired bye bye tired one anything industrious industrious industrious paragragh naive else something fix pig well-made two text pig anything two love three anything you body tired anything two one text anything something three naive bye one naive thick worried pig love else paragragh fix body body three ", 21, "pin anything worried naive ", "else text pin industrious text you industrious tired anything ten hello paragragh something two pig numberless naive two two anything ", 770f, 13, 223 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "BrandId", "CategoryId", "Code", "Description", "InStock", "Name", "Overeview", "Price", "SalesOff", "Total" },
                values: new object[] { 2, 3, "oBPgoj", "bye three pig something two ten love body three three one worried tired worried text numberless body cent text pin thick paragragh two hello thick bye naive one numberless one one pin body anything pin walk industrious thick walk naive love text tired bye two bye thick numberless tired fix ", 1630, "hello one one worried ", "pin thick pin ten worried paragragh else well-made naive cent else paragragh cent industrious bye anything pin one cent one ", 940f, 2, 1702 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Code", "Description", "InStock", "Name", "Overeview", "Price", "SalesOff", "Total" },
                values: new object[] { "KwNwQF", "walk ten paragragh well-made body naive worried worried love one paragragh worried well-made pin thick you you you hello thick you tired pin hello fix worried love fix anything worried worried naive else bye thick thick else you bye something hello three bye two you walk three love hello well-made ", 252, "fix naive anything pig ", "cent fix worried hello anything two anything tired worried else naive industrious you three worried pig cent two two text ", 390f, 3, 616 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "BrandId", "CategoryId", "Code", "Description", "InStock", "Name", "Overeview", "Price", "SalesOff", "Total" },
                values: new object[] { 2, 3, "zwxQx2", "cent tired text one one tired industrious something walk ten something ten cent fix paragragh worried walk hello numberless thick love pig thick paragragh you thick else two two fix paragragh bye body bye well-made pin pin worried tired ten anything paragragh something industrious fix worried well-made worried fix cent ", 1279, "fix else walk paragragh ", "fix text else body walk pin tired three love numberless you fix two walk pig body anything else paragragh love ", 780f, 5, 969 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "BrandId", "CategoryId", "Code", "Description", "InStock", "Name", "Overeview", "Price", "SalesOff", "Total" },
                values: new object[] { 1, 1, "93C6pN", "love two bye thick body numberless fix walk numberless fix text love numberless naive naive two anything text numberless text thick tired body love well-made paragragh something you industrious cent thick something industrious paragragh walk walk industrious three paragragh numberless something you cent anything tired three walk body fix bye ", 764, "text hello numberless paragragh ", "ten something walk text industrious industrious industrious well-made tired worried else pig naive ten industrious one worried fix else pig ", 620f, 14, 880 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "BrandId", "CategoryId", "Code", "Description", "InStock", "Name", "Overeview", "Price", "SalesOff", "Total" },
                values: new object[] { 1, 1, "4dmpHO", "well-made worried love paragragh one fix text bye something numberless ten pig love naive numberless anything love naive pin bye tired tired love fix well-made two walk text else paragragh worried bye naive worried love two fix thick one numberless thick hello thick pin else anything cent worried thick two ", 1142, "fix one industrious you ", "paragragh pig industrious worried hello industrious body body industrious hello walk pin fix tired one else fix two one anything ", 780f, 0, 337 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "BrandId", "CategoryId", "Code", "Description", "InStock", "Name", "Overeview", "Price", "SalesOff", "Total" },
                values: new object[] { 4, 2, "g0QZd8", "anything naive something pin naive pin love two three thick else hello industrious tired body fix else love industrious pig thick two you two three tired something worried bye worried something paragragh love anything thick something industrious fix worried hello something cent cent paragragh pig bye paragragh thick thick body ", 1915, "well-made pin three love ", "anything text fix hello hello bye paragragh body worried anything pin love ten naive fix industrious thick numberless body pin ", 430f, 10, 1018 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "BrandId", "CategoryId", "Code", "Description", "InStock", "Name", "Overeview", "Price", "SalesOff", "Total" },
                values: new object[] { 3, 5, "nVaCM5", "ten cent pig pin walk numberless well-made walk industrious you worried hello pin thick you two naive body something walk paragragh naive numberless fix you pig text anything pig worried anything bye anything two industrious fix love pin worried pig body bye one paragragh industrious anything industrious anything thick pin ", 1780, "tired paragragh numberless else ", "something cent numberless thick thick walk paragragh something something walk fix worried pig pig something well-made ten bye text cent ", 910f, 7, 1622 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "BrandId", "CategoryId", "Code", "Description", "InStock", "Name", "Overeview", "Price", "SalesOff", "Total" },
                values: new object[] { 4, 4, "ZdG1G4", "something fix cent something naive pin anything well-made body else two two three hello fix else else you naive two body bye pig walk text three bye worried text bye paragragh else paragragh ten body numberless pig something worried text thick two tired bye two cent hello love bye one ", 1882, "naive naive you anything ", "bye fix well-made hello text naive three thick walk walk paragragh pig naive anything walk ten one well-made walk worried ", 130f, 9, 1339 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CategoryId", "Code", "Description", "InStock", "Name", "Overeview", "Price", "Total" },
                values: new object[] { 5, "LFK74g", "text worried two you you naive text two walk two numberless anything two something naive fix naive cent cent industrious love naive thick ten anything tired thick thick cent three cent tired numberless three walk text fix something fix numberless naive cent thick something naive walk worried anything well-made you ", 1978, "hello ten one fix ", "love numberless bye thick thick pin ten two walk thick worried paragragh two one naive else something cent tired industrious ", 330f, 945 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "BrandId", "CategoryId", "Code", "Description", "InStock", "Name", "Overeview", "Price", "SalesOff", "Total" },
                values: new object[] { 2, 4, "NXux7e", "tired paragragh two three body something else anything industrious body paragragh body walk else pig thick bye something you two text love bye bye fix body naive walk walk one walk worried anything text well-made cent cent two something naive numberless ten pin ten body body one ten fix you ", 706, "body thick fix tired ", "you ten fix two body text text industrious paragragh text anything paragragh hello paragragh pig tired worried pig hello text ", 880f, 13, 1035 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "BrandId", "CategoryId", "Code", "Description", "InStock", "Name", "Overeview", "Price", "Total" },
                values: new object[] { 4, 3, "9gMFZ8", "ten numberless text text body industrious cent else pin something pin hello pin thick anything industrious naive naive text anything hello ten thick numberless else fix one body bye ten something fix three pin ten pin paragragh text worried industrious paragragh naive one you you thick text cent hello thick ", 1188, "naive fix paragragh bye ", "numberless hello fix worried cent you pin one bye anything love paragragh one fix fix one ten naive else text ", 200f, 994 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CategoryId", "Code", "Description", "InStock", "Name", "Overeview", "Price", "SalesOff", "Total" },
                values: new object[] { 4, "OBqpDg", "three worried ten ten naive industrious something two two bye walk naive you naive text text two bye pin one pig body bye industrious ten walk one paragragh ten worried text anything else three ten bye walk three something well-made body one pin else anything you one three two pin ", 274, "bye walk worried well-made ", "something body two anything naive something cent two walk worried walk fix worried pig text thick hello cent two cent ", 780f, 0, 1929 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Code", "Description", "InStock", "Name", "Overeview", "Price", "SalesOff", "Total" },
                values: new object[] { "20mr8F", "three else anything anything you hello three one else industrious paragragh two love else pig hello pig tired hello pin numberless naive tired cent love ten bye industrious tired three text pin numberless numberless fix body cent two well-made pin anything thick industrious bye anything thick anything bye two walk ", 651, "one you ten fix ", "something industrious bye cent bye ten you ten two text body three cent love else text cent ten thick paragragh ", 440f, 5, 1516 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "BrandId", "Code", "Description", "InStock", "Name", "Overeview", "Price", "SalesOff", "Total" },
                values: new object[] { 2, "qdOwCH", "else text tired body paragragh thick one worried numberless walk well-made well-made worried walk three worried pig naive you paragragh two you naive body well-made naive one bye well-made anything well-made you hello thick industrious three tired well-made one anything worried pin thick three hello body ten pin else text ", 618, "body text worried love ", "bye ten walk pig naive else cent fix numberless text walk you walk bye love pin hello walk tired body ", 730f, 9, 445 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "BrandId", "CategoryId", "Code", "Description", "InStock", "Name", "Overeview", "Price", "SalesOff", "Total" },
                values: new object[] { 4, 2, "YxYYsa", "two three body pig fix body bye industrious worried industrious worried well-made three worried walk pin love else body text tired naive body love pig you love fix you well-made cent naive anything anything text anything ten three two paragragh hello else three one tired pig something thick numberless bye ", 1159, "ten pin love worried ", "ten paragragh worried pin paragragh pin ten body something one bye hello bye pig one one love one walk numberless ", 690f, 7, 450 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "BrandId", "CategoryId", "Code", "Description", "InStock", "Name", "Overeview", "Price", "SalesOff", "Total" },
                values: new object[] { 4, 5, "nQ0HAf", "paragragh fix pig fix industrious else three numberless something tired fix anything something two anything paragragh you ten pig something industrious thick pig you paragragh tired else body well-made two text love naive you numberless you two pin cent one walk pin two ten pig one three love numberless bye ", 140, "worried industrious walk you ", "naive you fix well-made walk numberless industrious walk walk paragragh bye fix fix pin pig bye thick thick one body ", 590f, 13, 1182 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "BrandId", "CategoryId", "Code", "Description", "InStock", "Name", "Overeview", "Price", "SalesOff", "Total" },
                values: new object[] { 3, 3, "3YHYor", "ten fix pin else ten walk thick hello one thick cent one worried text anything industrious naive body thick text anything naive fix ten two two ten fix worried cent you industrious pin bye three cent else love pig anything bye cent cent industrious you walk tired anything pig hello ", 701, "body three three pin ", "two text bye numberless cent you something text fix industrious ten bye something walk two ten anything text pin cent ", 470f, 4, 1949 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "BrandId", "CategoryId", "Code", "Description", "InStock", "Name", "Overeview", "Price", "SalesOff", "Total" },
                values: new object[] { 2, 1, "Nb9ODJ", "paragragh text pig thick cent fix three worried bye two three ten two three else ten numberless bye numberless pin pig anything worried hello well-made something naive else anything two ten text else one pig love pig bye two body else bye you one anything tired paragragh numberless text tired ", 1178, "fix anything naive thick ", "one two love paragragh tired hello else tired cent paragragh cent thick you tired walk three worried something text you ", 790f, 10, 1291 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "BrandId", "CategoryId", "Code", "Description", "InStock", "Name", "Overeview", "Price", "SalesOff", "Total" },
                values: new object[] { 4, 1, "mzj0Gi", "industrious body anything hello pig fix tired numberless love bye naive body paragragh ten pig text bye you you pig text bye thick three ten pin pig well-made text three walk else worried else pin worried worried numberless one numberless industrious love well-made three fix numberless three paragragh one cent ", 1225, "worried worried walk you ", "industrious numberless one three bye bye anything industrious thick ten pin one bye love love pig anything bye ten worried ", 770f, 7, 211 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Comment", "ProductId", "Rate", "TimePosted" },
                values: new object[] { "two two industrious else pig worried cent thick pin naive something love numberless paragragh cent one fix naive three cent three well-made bye tired paragragh walk one else one numberless ", 5, 2, new DateTime(2022, 6, 20, 14, 49, 30, 349, DateTimeKind.Local).AddTicks(9544) });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Comment", "Rate", "TimePosted" },
                values: new object[] { "two walk fix bye numberless tired pig you anything bye walk bye three walk paragragh pin tired two naive text paragragh thick something naive industrious text anything numberless two hello ", 1, new DateTime(2022, 6, 20, 14, 49, 30, 349, DateTimeKind.Local).AddTicks(9934) });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Comment", "ProductId", "TimePosted" },
                values: new object[] { "cent one well-made love naive something bye numberless numberless you walk pig numberless body one bye fix one pig anything paragragh tired pig well-made two industrious fix naive fix walk ", 10, new DateTime(2022, 6, 20, 14, 49, 30, 349, DateTimeKind.Local).AddTicks(9990) });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Comment", "ProductId", "Rate", "TimePosted" },
                values: new object[] { "text well-made thick well-made anything you text paragragh numberless pig something love cent naive pig worried worried tired something numberless walk love walk paragragh well-made pin well-made walk walk cent ", 18, 2, new DateTime(2022, 6, 20, 14, 49, 30, 350, DateTimeKind.Local).AddTicks(38) });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Comment", "ProductId", "TimePosted" },
                values: new object[] { "two paragragh one ten two naive two one three bye you fix paragragh fix numberless well-made three pig walk numberless two pig pig love numberless two body anything something hello ", 17, new DateTime(2022, 6, 20, 14, 49, 30, 350, DateTimeKind.Local).AddTicks(57) });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Comment", "ProductId", "Rate", "TimePosted" },
                values: new object[] { "text ten well-made tired ten bye bye ten three numberless walk else body ten body three anything body tired you anything bye pig naive hello text paragragh body thick something ", 28, 4, new DateTime(2022, 6, 20, 14, 49, 30, 350, DateTimeKind.Local).AddTicks(111) });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Comment", "ProductId", "Rate", "TimePosted" },
                values: new object[] { "body pin paragragh body walk else hello naive ten fix well-made bye numberless two you pig something cent body something industrious something anything cent bye anything anything numberless ten bye ", 13, 2, new DateTime(2022, 6, 20, 14, 49, 30, 350, DateTimeKind.Local).AddTicks(164) });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Comment", "ProductId", "Rate", "TimePosted" },
                values: new object[] { "industrious love else anything pin pin two pig bye numberless worried bye pig paragragh well-made love ten fix thick walk something pig well-made naive industrious two hello pig text tired ", 16, 1, new DateTime(2022, 6, 20, 14, 49, 30, 350, DateTimeKind.Local).AddTicks(226) });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Comment", "ProductId", "Rate", "TimePosted" },
                values: new object[] { "pin numberless fix cent you anything well-made something one text worried pin bye tired you paragragh else numberless pig naive worried walk bye ten something thick love fix bye naive ", 17, 2, new DateTime(2022, 6, 20, 14, 49, 30, 350, DateTimeKind.Local).AddTicks(274) });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Comment", "ProductId", "Rate", "TimePosted" },
                values: new object[] { "bye love bye walk naive numberless anything love cent paragragh something anything cent walk ten else text text two something worried walk worried ten bye something one one numberless three ", 4, 1, new DateTime(2022, 6, 20, 14, 49, 30, 350, DateTimeKind.Local).AddTicks(342) });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Comment", "ProductId", "Rate", "TimePosted" },
                values: new object[] { "worried numberless hello else you else fix two industrious tired worried tired two one something tired one cent paragragh three paragragh you anything naive text paragragh else else bye tired ", 23, 1, new DateTime(2022, 6, 20, 14, 49, 30, 350, DateTimeKind.Local).AddTicks(360) });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Comment", "ProductId", "Rate", "TimePosted" },
                values: new object[] { "something fix three worried text worried ten pin well-made body one text industrious text walk body body worried pin love numberless pig hello walk industrious cent anything worried body paragragh ", 3, 2, new DateTime(2022, 6, 20, 14, 49, 30, 350, DateTimeKind.Local).AddTicks(411) });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Comment", "ProductId", "TimePosted" },
                values: new object[] { "something paragragh ten worried paragragh bye else tired tired text one paragragh thick walk walk pin one text else thick tired you pig naive body something pin one cent something ", 2, new DateTime(2022, 6, 20, 14, 49, 30, 350, DateTimeKind.Local).AddTicks(465) });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Comment", "ProductId", "Rate", "TimePosted" },
                values: new object[] { "you three industrious naive anything numberless walk hello hello two hello thick paragragh text three love anything anything two pig industrious text naive paragragh hello fix worried industrious hello worried ", 7, 2, new DateTime(2022, 6, 20, 14, 49, 30, 350, DateTimeKind.Local).AddTicks(513) });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Comment", "ProductId", "Rate", "TimePosted" },
                values: new object[] { "else numberless three one worried you numberless hello hello walk you ten tired anything two well-made three cent two well-made numberless paragragh tired cent hello thick love hello you worried ", 1, 4, new DateTime(2022, 6, 20, 14, 49, 30, 350, DateTimeKind.Local).AddTicks(565) });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Comment", "ProductId", "Rate", "TimePosted" },
                values: new object[] { "thick paragragh else else love well-made text numberless love worried ten love three bye naive bye three you pig pig one body text you something else numberless ten pin two ", 17, 2, new DateTime(2022, 6, 20, 14, 49, 30, 350, DateTimeKind.Local).AddTicks(620) });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Comment", "ProductId", "Rate", "TimePosted" },
                values: new object[] { "walk one fix else well-made anything tired one fix bye thick you body bye thick anything pin naive else pin three text ten thick pin paragragh pin walk walk you ", 1, 2, new DateTime(2022, 6, 20, 14, 49, 30, 350, DateTimeKind.Local).AddTicks(638) });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Comment", "ProductId", "Rate", "TimePosted" },
                values: new object[] { "one tired else well-made industrious something pig you hello text love pin something ten anything worried naive industrious paragragh text anything one bye hello ten industrious else bye you cent ", 11, 2, new DateTime(2022, 6, 20, 14, 49, 30, 350, DateTimeKind.Local).AddTicks(686) });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Comment", "ProductId", "Rate", "TimePosted" },
                values: new object[] { "hello numberless thick one love industrious love tired numberless paragragh bye industrious love paragragh text walk three you you industrious cent naive thick pin you cent fix pin body paragragh ", 29, 3, new DateTime(2022, 6, 20, 14, 49, 30, 350, DateTimeKind.Local).AddTicks(735) });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Comment", "ProductId", "Rate", "TimePosted" },
                values: new object[] { "thick naive bye one fix thick pig walk well-made thick else cent pin tired something numberless thick fix else pin well-made pig thick cent text naive else else something three ", 13, 2, new DateTime(2022, 6, 20, 14, 49, 30, 350, DateTimeKind.Local).AddTicks(793) });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Comment", "ProductId", "Rate", "TimePosted" },
                values: new object[] { "paragragh walk paragragh one walk cent ten hello something text three ten else cent pin hello one tired else bye industrious anything industrious industrious anything thick three industrious else two ", 18, 2, new DateTime(2022, 6, 20, 14, 49, 30, 350, DateTimeKind.Local).AddTicks(844) });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Comment", "ProductId", "Rate", "TimePosted" },
                values: new object[] { "anything thick tired three else industrious three cent something walk tired one fix two bye bye naive walk industrious walk cent you walk three industrious else two love naive text ", 23, 2, new DateTime(2022, 6, 20, 14, 49, 30, 350, DateTimeKind.Local).AddTicks(861) });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Comment", "ProductId", "Rate", "TimePosted" },
                values: new object[] { "industrious tired love pig ten cent ten fix one bye love love one bye something thick love naive paragragh hello bye thick well-made pin cent two text pin hello body ", 25, 1, new DateTime(2022, 6, 20, 14, 49, 30, 350, DateTimeKind.Local).AddTicks(927) });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Comment", "ProductId", "TimePosted" },
                values: new object[] { "fix tired fix numberless text walk paragragh worried tired something something else pin naive well-made two pin well-made body pin anything naive bye paragragh worried three worried cent hello ten ", 29, new DateTime(2022, 6, 20, 14, 49, 30, 350, DateTimeKind.Local).AddTicks(978) });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Comment", "ProductId", "Rate", "TimePosted" },
                values: new object[] { "else anything fix cent numberless two something something one two numberless love text two body three thick industrious body well-made pin three pin industrious love text you love numberless one ", 20, 3, new DateTime(2022, 6, 20, 14, 49, 30, 350, DateTimeKind.Local).AddTicks(1031) });
        }
    }
}
