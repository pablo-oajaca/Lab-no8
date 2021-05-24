<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Lab_no8._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>CONTROL DEPARTAMENTOS</h1>

    <div class="row">
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Seleccione el departamento<br />
        <asp:DropDownList ID="DropDownListDepartamento" runat="server" Height="22px" Width="140px">
        </asp:DropDownList>
        <p>Ingrese la temperatura</p>
        <p>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Guardar" />
        </p>
    </div>

    </div>

    </asp:Content>
