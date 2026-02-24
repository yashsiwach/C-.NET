<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="WebTest.login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
   <form id="form1" runat="server">
        <div>
            <h1>Login Form</h1>

            <asp:Label ID="lblUser" runat="server" Text="Username:"></asp:Label>
            <asp:TextBox ID="txtUser" runat="server"></asp:TextBox>
            <br /><br />

            <asp:Label ID="lblPass" runat="server" Text="Password:"></asp:Label>
            <asp:TextBox ID="txtPass" runat="server" TextMode="Password"></asp:TextBox>
            <br /><br />

           

            <asp:Label ID="lblMessage" runat="server" ForeColor="Red"></asp:Label>
        </div>
    </form>
</body>
</html>
