<%@ Page Title="" Language="C#" MasterPageFile="~/CapaVista/default.Master" AutoEventWireup="true" CodeBehind="EliminarUsuario.aspx.cs" Inherits="labLaboratorio.CapaVista.EliminarUsuario" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

      <article>
        <center><h1>Eliminar usuario</h1></center>
        <center>
            <table>
                <tr>
          <td><asp:Label ID="Label1" runat="server" Text="Seleccione usuario"></asp:Label></td><td><asp:DropDownList ID="DArea" runat="server" DataTextField="no seleccion" ></asp:DropDownList></td>
                    <td><asp:Button ID="cmdConsultar" runat="server" Text="Eliminar" BackColor="#F89A41" Height="40px"  Width="80px" OnClick="cmdConsultar_Click" ></asp:Button></td>
            </tr>
                <tr><td colspan="3"><asp:Label ID="Msg" runat="server" Text=""></asp:Label></td></tr>
          </table>    

           <asp:GridView ID="Data" runat="server"></asp:GridView>
            <asp:ObjectDataSource ID="ObjectDataSource1" runat="server"></asp:ObjectDataSource>
        </center>
    </article>

</asp:Content>
