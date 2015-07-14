<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" 
Inherits="System.Web.Mvc.ViewPage<Grupo1Cliente.Controllers.DetalhesCorrida>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	Details
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h2>Detalhes da Corrida</h2>

    <table>

        <tr>
            <th><%= Html.ActionLink("Voltar", "Index")%></th>
            <th><%= Html.Encode(Model.run.nome) %></th>
            <th>Status: <%= Html.Encode(Model.run.status) %></th>
        </tr> 
        <tr><th colspan="3" align=center>Corredores</th></tr>

    <% foreach (var item in Model.runners) { %>

        <tr>
            <td>
            </td>
            <td><%= Html.Encode(item.nome) %></td>
            <td>Status: <%= Html.Encode(item.status) %></td>
        </tr>

    <% } %> 

    </table>

</asp:Content>
