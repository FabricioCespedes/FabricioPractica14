<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="wfrmHiddenControl.aspx.cs" Inherits="FabricioPractica14.wfrmHiddenControl" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:HiddenField ID="hfValor" runat="server" />
            <asp:Label ID="Label1" runat="server" Text="Nombre"></asp:Label>
            <br />
            <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="lblMostrar" runat="server" Text="Label" Visible="False"></asp:Label>
            <br />
            <asp:Button ID="btnLeer" runat="server" Text="Leer" OnClick="btnLeer_Click" />
            <br />
            <asp:Button ID="btnMostrar" runat="server" Text="Mostrar" OnClick="btnMostrar_Click" />
        </div>
    </form>
</body>
</html>
