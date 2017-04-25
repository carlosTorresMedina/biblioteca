<%@ Page Title="" Language="C#" MasterPageFile="~/CapaVista/default.Master" AutoEventWireup="true" CodeBehind="IngresarLibro.aspx.cs" Inherits="labLaboratorio.CapaVista.IngresarLibro" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
      <article>
        <center><h1>Ingresar libro</h1></center>
        <center>
            
            <table>
                 <tr><td colspan="2"><center><asp:Label ID="Msg" runat="server" Text=""></asp:Label></center>
                     </td></tr> 
                <tr><td><asp:Label ID="Label1" runat="server" Text="Codigo libro"></asp:Label></td>
                    <td><asp:TextBox ID="txtCodigo" runat="server" ></asp:TextBox></td></tr>

                 <tr><td><asp:Label ID="Label2" runat="server" Text="Nombre libro"></asp:Label></td>
                     <td><asp:TextBox ID="txtNombre" runat="server" ></asp:TextBox></td></tr>

                 <tr><td><asp:Label ID="Label3" runat="server" Text="N° de paginas"></asp:Label></td>
                     <td><asp:TextBox ID="txtPaginas" runat="server"  ></asp:TextBox></td></tr>

                 

                  <tr><td><asp:Label ID="Label5" runat="server" Text="Editorial"></asp:Label></td>
                      <td><asp:TextBox ID="txtEditorial" runat="server" ></asp:TextBox></td></tr>    
                              
                   <tr><td><asp:Label ID="Label6" runat="server" Text="Area"></asp:Label></td>
                       <td><asp:DropDownList ID="dArea" runat="server" Height="16px" Width="121px"></asp:DropDownList></td></tr>

                <tr><td colspan="2"><center><asp:Button ID="ButonIngresar" runat="server" Text="Ingresar" OnClick="ButonIngresar_Click" BackColor="#F89A41" Height="40px" Width="80px" /></center>
                     </td></tr> 
                 
            </table>
                 
        </center>
    </article>
</asp:Content>
