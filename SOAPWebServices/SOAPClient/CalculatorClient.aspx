<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CalculatorClient.aspx.cs" Inherits="SOAPClient.CalculatorClient" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="First Number"></asp:Label><br />
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox><br />
            <asp:DropDownList ID="DropDownList1" runat="server">
                <asp:ListItem>+</asp:ListItem>
                <asp:ListItem>-</asp:ListItem>
                <asp:ListItem>*</asp:ListItem>
                <asp:ListItem>/</asp:ListItem>
            </asp:DropDownList><br />
               <asp:Label ID="Label2" runat="server" Text="Second Number"></asp:Label><br />
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox><br />
            <asp:Button ID="Button1" runat="server" Text="Calculate" OnClick="Button1_Click" /><br />
            <asp:Label ID="Label3" runat="server" Text=""></asp:Label><br />
             <asp:Label ID="Label4" runat="server" Text=""></asp:Label>
        </div>
        </form>
</body>
</html>
