<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RegistrarLibro.aspx.cs" Inherits="WebApplication1.RegistarLibro" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
    

<body>
    
    <h1>Registar Libro</h1>

    
    <form id="form1" runat="server">
        <asp:label ID="lblNombreLibro" Text ="Nombre del libro" runat="server"></asp:label>
        <asp:TextBox ID="txtTituloLibro" TextMode="SingleLine" runat="server" ></asp:TextBox> <br />
        <asp:label ID="Label1" Text ="Nombre del Author" runat="server"></asp:label>
        <asp:TextBox ID="txtAuthor" TextMode="SingleLine" runat="server" ></asp:TextBox> <br />
        <asp:label ID="Label2" Text ="Edicion" runat="server"></asp:label>
        <asp:TextBox ID="txtEdition" TextMode="SingleLine" runat="server" ></asp:TextBox> <br />
        <asp:label ID="Label3" Text ="codigo del libro" runat="server"></asp:label>
        <asp:TextBox ID="txtCodigoLibro" TextMode="SingleLine" runat="server" ></asp:TextBox> <br />
        <asp:label ID="Label4" Text ="Numero de Copias" runat="server"></asp:label>
        <asp:TextBox ID="txtCopias" TextMode="SingleLine" runat="server" ></asp:TextBox> <br />
        <asp:label ID="Label5" Text ="editorial" runat="server"></asp:label>
        <asp:TextBox ID="txtEditorial" TextMode="SingleLine" runat="server" ></asp:TextBox> <br />

        <asp:Button ID="btnGuardar" Text="Guardar"  OnClick ="btnGuardar_Click" runat="server" />
        
    </form>
</body>
</html>
