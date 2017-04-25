<%@ Page Title="" Language="C#" MasterPageFile="~/CapaVista/default.Master" AutoEventWireup="true" CodeBehind="ModificarUsuario.aspx.cs" Inherits="labLaboratorio.CapaVista.ModificarUsuario" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

     <article>
        <center><h1>Modificar usuario</h1></center>
        <center>
            
            <table>
                <tr>
          <td><asp:Label ID="Label7" runat="server" Text="Seleccione usuario"></asp:Label></td><td><asp:DropDownList ID="DArea" runat="server" DataTextField="no seleccion" ></asp:DropDownList></td>
                    <td><asp:Button ID="cmdConsultar" runat="server" Text="Consultar" BackColor="#F89A41" Height="40px"  Width="80px" OnClick="cmdConsultar_Click" ></asp:Button></td>
            </tr>
          </table>

            <table>
                 <tr><td colspan="2"><center><asp:Label ID="Msg" runat="server" Text=""></asp:Label></center>
                     </td></tr> 
                <tr><td><asp:Label ID="Label1" runat="server" Text="Documento"></asp:Label></td>
                    <td><asp:TextBox ID="txtCodigo" runat="server" Enabled="False" ></asp:TextBox></td></tr>

                 <tr><td><asp:Label ID="Label2" runat="server" Text="Nombre"></asp:Label></td>
                     <td><asp:TextBox ID="txtNombre" runat="server" ></asp:TextBox></td></tr>

                 <tr><td><asp:Label ID="Label3" runat="server" Text="Direccion"></asp:Label></td>
                     <td><asp:TextBox ID="txtDireccion" runat="server"  ></asp:TextBox></td></tr>

                 

                  <tr><td><asp:Label ID="Label4" runat="server" Text="Telefono"></asp:Label></td>
                      <td><asp:TextBox ID="txtTelefono" runat="server" ></asp:TextBox></td></tr>    
                              
                  <tr><td><asp:Label ID="Label5" runat="server" Text="Correo"></asp:Label></td>
                      <td><asp:TextBox ID="txtCorreo" runat="server" ></asp:TextBox></td></tr>  

                 <tr><td><asp:Label ID="Label6" runat="server" Text="Estado"></asp:Label></td>
                      <td><asp:TextBox ID="txtEstado" runat="server" ></asp:TextBox></td></tr>  

                <tr><td colspan="2"><center><asp:Button ID="ButonIngresar" runat="server" Text="Guardar cambios"  BackColor="#F89A41" Height="40px" Width="110px" OnClick="ButonIngresar_Click" /></center>
                     </td></tr> 
                 
            </table>
                 
        </center>
    </article>

</asp:Content>
