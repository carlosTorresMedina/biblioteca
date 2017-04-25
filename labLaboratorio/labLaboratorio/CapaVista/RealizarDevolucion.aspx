<%@ Page Title="" Language="C#" MasterPageFile="~/CapaVista/default.Master" AutoEventWireup="true" CodeBehind="RealizarDevolucion.aspx.cs" Inherits="labLaboratorio.CapaVista.RealizarDevolucion" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

       <article>
        <center><h1>Realizar Devolucion</h1></center>
        <center>
            
            <table>

                 <tr><td colspan="2"><center><asp:Label ID="Msg" runat="server" Text=""></asp:Label></center>
                     </td></tr> 

                <tr><td><asp:Label ID="Label4" runat="server" Text="Codigo prestamo"></asp:Label></td><td><asp:TextBox ID="txtCodigo" runat="server"></asp:TextBox></td></tr>
                
                <tr><td><asp:Label ID="Label1" runat="server" Text="Fecha"></asp:Label></td>
                    <td class="auto-style1"><asp:TextBox ID="Fecha1" runat="server" Enabled="False"></asp:TextBox><asp:Button ID="Button1" runat="server" Text="open" BackColor="#F89A41" OnClick="Button1_Click" ></asp:Button><asp:Calendar ID="CFecha" runat="server" Height="10px" Visible="False"  Width="145px" OnSelectionChanged="CFecha_SelectionChanged"></asp:Calendar></td></tr>

                 <tr><td><asp:Label ID="Label2" runat="server" Text="Usuario"></asp:Label></td>
                     <td class="auto-style1"><asp:DropDownList ID="DUsuario" runat="server"></asp:DropDownList></td></tr>

                 <tr><td><asp:Label ID="Label3" runat="server" Text="Libro"></asp:Label></td>
                     <td class="auto-style1"><asp:DropDownList ID="DLibro" runat="server"></asp:DropDownList></td></tr>
                                       

                <tr><td colspan="2"><center><asp:Button ID="ButonIngresar" runat="server" Text="Guardar"  BackColor="#F89A41" Height="40px" Width="80px" OnClick="ButonIngresar_Click" /></center>
                     </td></tr> 
                 
            </table>
           
        </center>
    </article>

</asp:Content>
