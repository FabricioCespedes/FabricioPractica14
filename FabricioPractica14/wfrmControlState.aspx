<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="wfrmControlState.aspx.cs" Inherits="FabricioPractica14.wfrmControlState" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <br />
            <asp:Button ID="btnSummit" runat="server" Text="Precione click" OnClick="btnSummit_Click" />
        </div>
         <div>
            <asp:Label ID="Label2" runat="server" Text="Salida"></asp:Label>
            <br />
            <asp:Label ID="lblSalida" runat="server" Text="Label"></asp:Label>
        </div>
    </form>
</body>
</html>
