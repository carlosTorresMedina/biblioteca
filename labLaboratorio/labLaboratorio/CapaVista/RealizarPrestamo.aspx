<%@ Page Title="" Language="C#" MasterPageFile="~/CapaVista/default.Master" AutoEventWireup="true" CodeBehind="RealizarPrestamo.aspx.cs" Inherits="labLaboratorio.CapaVista.RealizarPrestamo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 215px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <article>
        <center><h1>Realizar prestamo</h1></center>
        <center>
            
            <table>
                 <tr><td colspan="2"><center><asp:Label ID="Msg" runat="server" Text=""></asp:Label></center>
                     </td></tr> 

                   <tr><td><asp:Label ID="Label6" runat="server" Text="Codigo prestamo"></asp:Label></td>
                      <td class="auto-style1"><asp:TextBox ID="txtCodigo" runat="server" ></asp:TextBox></td></tr>   

                <tr><td><asp:Label ID="Label1" runat="server" Text="Fecha"></asp:Label></td>
                    <td class="auto-style1"><asp:TextBox ID="Fecha1" runat="server" Enabled="False"></asp:TextBox><asp:Button ID="Button1" runat="server" Text="open" BackColor="#F89A41" OnClick="Button1_Click"></asp:Button><asp:Calendar ID="CFecha" runat="server" Height="10px" Visible="False" OnSelectionChanged="CFecha_SelectionChanged" Width="145px"></asp:Calendar></td></tr>

                 <tr><td><asp:Label ID="Label2" runat="server" Text="Usuario"></asp:Label></td>
                     <td class="auto-style1"><asp:DropDownList ID="DUsuario" runat="server"></asp:DropDownList></td></tr>

                <tr><td colspan="2"><center><asp:Button ID="ButtonGuardar" runat="server" Text="guardar prestamo" BackColor="#F89A41" Height="40px" Width="120px" OnClick="ButtonGuardar_Click" /></center>
                     </td></tr> 

                 <tr><td><asp:Label ID="Label3" runat="server" Text="Libro"></asp:Label></td>
                     <td class="auto-style1"><asp:DropDownList ID="DLibro" runat="server"></asp:DropDownList></td></tr>

                 

                  <tr><td><asp:Label ID="Label5" runat="server" Text="Cantidad"></asp:Label></td>
                      <td class="auto-style1"><asp:TextBox ID="txtCantidad" runat="server" ></asp:TextBox></td></tr>   
                
             <tr><td><asp:Label ID="Label4" runat="server" Text="Fecha limite"></asp:Label></td>
                    <td class="auto-style1"><asp:TextBox ID="txtFechaLimite" runat="server" Enabled="False"></asp:TextBox><asp:Button ID="Button2" runat="server" Text="open" BackColor="#F89A41" OnClick="Button2_Click" ></asp:Button><asp:Calendar ID="CFechaLimite" runat="server" Height="10px" Visible="False"  Width="145px" OnSelectionChanged="CFechaLimite_SelectionChanged"></asp:Calendar></td></tr>   
                              
                 

                <tr><td colspan="2"><center><asp:Button ID="ButonIngresar" runat="server" Text="Agregar"  BackColor="#F89A41" Height="40px" Width="80px" OnClick="ButonIngresar_Click" /></center>
                     </td></tr> 
                 
            </table>
            <asp:GridView ID="data" runat="server"></asp:GridView>     
        </center>
    </article>

</asp:Content>
