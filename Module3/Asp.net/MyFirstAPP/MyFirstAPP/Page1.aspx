<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Page1.aspx.cs" Inherits="MyFirstAPP.Page1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Enter Name <asp:TextBox ID="txtName" 
                runat="server"></asp:TextBox>
            <asp:Button ID="Button1" runat="server" 
                Text="GOTO" OnClick="DoIt" />
        </div>
    </form>
</body>
</html>
