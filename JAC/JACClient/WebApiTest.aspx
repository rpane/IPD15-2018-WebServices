<%@ Page Language="C#" Async="true" AutoEventWireup="true" CodeBehind="WebApiTest.aspx.cs" Inherits="JACClient.WebApiTest" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <p>Please enter student's information.</p>
            <asp:Label ID="Label1" runat="server" Text="First Name: "></asp:Label>
            <asp:TextBox ID="tbFN" runat="server"></asp:TextBox><br />
            <asp:Label ID="Label2" runat="server" Text="Last Name: "></asp:Label>
            <asp:TextBox ID="tbLN" runat="server"></asp:TextBox><br />
            <asp:Label ID="Label3" runat="server" Text="Enrollment Date:"></asp:Label>
            <asp:Calendar ID="CalEnrol" runat="server"></asp:Calendar>
            <asp:Button ID="btnSave" runat="server" Text="Save" OnClick="btnSave_ClickAsync" />
       </div>            
        
        <p>
            <asp:Label ID="Label4" runat="server" Text=""></asp:Label>
        </p>
        
        
        
        
        
    </form>
</body>
</html>
