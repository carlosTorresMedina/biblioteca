<%@ Page Title="" Language="C#" MasterPageFile="~/CapaVista/default.Master" AutoEventWireup="true" CodeBehind="IngresarArea.aspx.cs" Inherits="labLaboratorio.CapaVista.Area" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <article>
        <center><h1>Ingresar area</h1></center>
        <center>
            
            <table>
                 <tr><td colspan="2"><center><asp:Label ID="Label4" runat="server" Text=""></asp:Label></center>
                     </td></tr>  
                <tr><td><asp:Label ID="Label1" runat="server" Text="Codigo area"></asp:Label></td><td><asp:TextBox ID="txtCodigo" runat="server" ></asp:TextBox></td></tr>
                 <tr><td><asp:Label ID="Label2" runat="server" Text="Nombre area"></asp:Label></td><td><asp:TextBox ID="txtNombre" runat="server" ></asp:TextBox></td></tr>
                 <tr><td><asp:Label ID="Label3" runat="server" Text="Tiempo max"></asp:Label></td><td><asp:TextBox ID="txtTiempo" runat="server" ></asp:TextBox></td></tr>
                 <tr><td colspan="2"><center><asp:Button ID="ButonIngresar" runat="server" Text="Ingresar" OnClick="ButonIngresar_Click" BackColor="#F89A41" Height="40px" Width="80px" /></center>
                     </td></tr> 
                <tr><td colspan="2"><center><asp:Label ID="Msg" runat="server" Text=""></asp:Label></center>
                     </td></tr>   
            </table>
                 
        </center>
    </article>
</asp:Content>
