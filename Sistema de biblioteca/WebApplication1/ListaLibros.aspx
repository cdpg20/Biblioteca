<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ListaLibros.aspx.cs" Inherits="WebApplication1.ListaLibros" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml" ng-app="biblioteca">
<head runat="server">
    <title ng-controller="HelloWorldCtrl">{{helloMessage}}</title>
    <script src="https://code.angularjs.org/1.4.0/angular.js"></script>
    <script type="text/javascript">
        angular.module('biblioteca', []).controller('HelloWorldCtrl', function ($scope) {
            $scope.helloMessage = 'Hello World';
            debugger;

        });

    </script>
</head>
<body ng-controller="HelloWorldCtrl">
    <h1>{{helloMessage}}</h1>
    <form id="form1" runat="server">
        <div>
            <asp:Table ID="tblListaLibros" runat="server" >
                <asp:TableHeaderRow>
                    <asp:TableCell>Nombre del Libro</asp:TableCell>
                    <asp:TableCell>Author</asp:TableCell>
                    <asp:TableCell>Numero de Copias</asp:TableCell>
                    <asp:TableCell>Codigo del Libro</asp:TableCell>
                    <asp:TableCell>Edicion</asp:TableCell>
                </asp:TableHeaderRow>
            </asp:Table>
        </div>
    </form>
    <style type="text/css">
table {
  font-family: "Trebuchet MS", Arial, Helvetica, sans-serif;
  border-collapse: collapse;
  width: 100%;
}

 td, th {
  border: 1px solid #ddd;
  padding: 8px;
}

tr:nth-child(even){background-color: #f2f2f2;}

tr:hover {background-color: #ddd;}
 th {
  padding-top: 12px;
  padding-bottom: 12px;
  text-align: left;
  background-color: #4CAF50;
  color: white;
}
        </style>
</body>
</html>
