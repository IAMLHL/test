<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="test.aspx.cs" Inherits="TestProgram.test" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AutoGenerateColumns="False" DataSourceID="SqlDataSource1" PageIndex="1" AllowSorting="True" CellPadding="4" ForeColor="#333333" GridLines="None">
                <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                <Columns>
                    <asp:BoundField DataField="Name" HeaderText="名称" SortExpression="Name" />
                    <asp:BoundField DataField="Brand" HeaderText="品牌" SortExpression="Brand" />
                    <asp:BoundField DataField="Pict" HeaderText="图片" SortExpression="Pict" />
                    <asp:BoundField DataField="AllCount" HeaderText="总库存" SortExpression="AllCount" />
                    <asp:BoundField DataField="SellCount" HeaderText="已售数量" SortExpression="SellCount" />
                    <asp:BoundField DataField="Price" HeaderText="价格" SortExpression="Price" />
                    <asp:BoundField DataField="AddTime" HeaderText="添加时间" SortExpression="AddTime" />
                    <asp:CommandField ShowSelectButton="True" />
                    <asp:CommandField ShowDeleteButton="True" />
                    <asp:CommandField ShowEditButton="True" />
                    <asp:ButtonField Text="按钮" />
                </Columns>
                <EditRowStyle BackColor="#999999" />
                <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                <PagerSettings FirstPageText="1111" LastPageText="2222" Position="TopAndBottom" />
                <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                <SortedAscendingCellStyle BackColor="#E9E7E2" />
                <SortedAscendingHeaderStyle BackColor="#506C8C" />
                <SortedDescendingCellStyle BackColor="#FFFDF8" />
                <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
            </asp:GridView>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:testConnectionString %>" SelectCommand="SELECT [Name], [Brand], [Pict], [AllCount], [SellCount], [Price], [AddTime] FROM [P_Product]"></asp:SqlDataSource>
        </div>
    </form>
</body>
</html>
