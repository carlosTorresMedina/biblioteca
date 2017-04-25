<%@ Page Title="" Language="C#" MasterPageFile="~/CapaVista/default.Master" AutoEventWireup="true" CodeBehind="ModificarArea.aspx.cs" Inherits="labLaboratorio.CapaVista.ModificarArea" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <article>
        <center><h1>Modificar area</h1></center>
        <center>
            
             <table>
                <tr>
          <td><asp:Label ID="Label4" runat="server" Text="Seleccione area"></asp:Label></td><td><asp:DropDownList ID="DArea" runat="server" DataTextField="no seleccion" ></asp:DropDownList></td>
                    <td><asp:Button ID="cmdConsultar" runat="server" Text="Consultar" BackColor="#F89A41" Height="40px" Width="80px" OnClick="cmdConsultar_Click"></asp:Button></td>
            </tr>
          </table> 

            <table>
                <tr><td><asp:Label ID="Label1" runat="server" Text="Codigo area"></asp:Label></td><td><asp:TextBox ID="txtCodigo" runat="server" Enabled="False" ></asp:TextBox></td></tr>
                 <tr><td><asp:Label ID="Label2" runat="server" Text="Nombre area"></asp:Label></td><td><asp:TextBox ID="txtNombre" runat="server" ></asp:TextBox></td></tr>
                 <tr><td><asp:Label ID="Label3" runat="server" Text="Tiempo max"></asp:Label></td><td><asp:TextBox ID="txtTiempo" runat="server" ></asp:TextBox></td></tr>
                 <tr><td colspan="2"><center><asp:Button ID="ButonIngresar" runat="server" Text="Guardar cambios"  BackColor="#F89A41" Height="40px" Width="130px" OnClick="ButonIngresar_Click" /></center>
                     </td></tr> 
                <tr><td colspan="2"><center><asp:Label ID="Msg" runat="server" Text=""></asp:Label></center>
                     </td></tr>   
            </table>
                 
        </center>
    </article>
</asp:Content>
