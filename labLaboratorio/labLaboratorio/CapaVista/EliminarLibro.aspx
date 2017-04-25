<%@ Page Title="" Language="C#" MasterPageFile="~/CapaVista/default.Master" AutoEventWireup="true" CodeBehind="EliminarLibro.aspx.cs" Inherits="labLaboratorio.CapaVista.EliminarLibro" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <article>
        <center><h1>Eliminar libro</h1></center>
        <center>
            
             <table>
                  <tr><td colspan="3"><center><asp:Label ID="Msg" runat="server" Text=""></asp:Label></center>
                     </td></tr>   
                <tr>
          <td><asp:Label ID="Label4" runat="server" Text="Seleccione Libro"></asp:Label></td><td><asp:DropDownList ID="DArea" runat="server" DataTextField="no seleccion" ></asp:DropDownList></td>
                    <td><asp:Button ID="cmdEliminar" runat="server" Text="Eliminar" BackColor="#F89A41" Height="40px" Width="80px" OnClick="cmdEliminar_Click"   ></asp:Button></td>
            </tr>
          </table>
</asp:Content>
