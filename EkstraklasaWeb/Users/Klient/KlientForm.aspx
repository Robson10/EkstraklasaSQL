<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="KlientForm.aspx.cs" Inherits="EkstraklasaWeb.Users.Klient.KlientForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="Logout" runat="server" Text="Wyloguj"  style="border: none;font-size: 16px;color: wheat;background-color: dimgray;height:30px;float:right" OnClick="Logout_Click" />
        </div>
        <div>
            <asp:Panel ID="Panel1" runat="server" Width="200px" style="float:left">
                <asp:Button ID="BtSpotkania" runat="server" Text="Tabela Spotkań" Width="200px" style="border: none;font-size: 16px;color: wheat;background-color: dimgray;height:30px" OnClick="BtSpotkania_Click" />
                <br />
                <br />
                <asp:Button ID="BtWyniki" runat="server" Text="Wyniki Meczy" Width="200px"  style="border: none;font-size: 16px;color: wheat;background-color: dimgray;height:30px" OnClick="BtWyniki_Click"/>
                <br />
                <br />
                <asp:Button ID="BtZawodnicy" runat="server" Text="Lista Zawodników" Width="200px"  style="border: none;font-size: 16px;color: wheat;background-color: dimgray;height:30px" OnClick="BtZawodnicy_Click"/>
                <br />
                <br />
                <asp:DropDownList ID="ComboZawodnicy" runat="server" Width="200px" AutoPostBack="True" OnSelectedIndexChanged="ComboZawodnicy_SelectedIndexChanged"></asp:DropDownList>
            </asp:Panel>
            <asp:Panel ID="Panel2" runat="server" style="float:left">
                    <asp:GridView ID="GridView1" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" Width="500px" OnRowDataBound="GridView_RowDataBound">
                    <AlternatingRowStyle BackColor="White" />
                    <FooterStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
                    <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
                    <PagerStyle BackColor="#FFCC66" ForeColor="#333333" HorizontalAlign="Center" />
                    <RowStyle BackColor="#FFFBD6" ForeColor="#333333" HorizontalAlign="center" />
                    <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="Navy" />
                    <SortedAscendingCellStyle BackColor="#FDF5AC" />
                    <SortedAscendingHeaderStyle BackColor="#4D0000" />
                    <SortedDescendingCellStyle BackColor="#FCF6C0" />
                    <SortedDescendingHeaderStyle BackColor="#820000" />
                </asp:GridView>
            </asp:Panel>
        </div>
    </form>
</body>
</html>
