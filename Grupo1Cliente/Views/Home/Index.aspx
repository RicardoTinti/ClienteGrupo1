<%@ Page Language="C#" MasterPageFile="~/Views/Shared/Site.Master" 
    Inherits="System.Web.Mvc.ViewPage<IEnumerable<Grupo1Cliente.Controllers.CorridaModel>>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Home Page
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: ViewData["Message"] %></h2>
    <p>
        
        <table>

        <tr>

            <th></th>
            <th>Estado</th>
            <th>Cidade</th>
            <th>Data</th>
            <th>Nome</th>
            <th>Descrição</th>
            <th>Valor Inscrição</th>
            <th>Status</th>
        </tr> 

    <% foreach (var item in Model) { %>

        <tr>

            <td>
                <%= Html.ActionLink("Excluir", "Delete", new { id = item.id })%>
                <%= Html.ActionLink("Editar", "Edit", new { id = item.id })%>
                <%= Html.ActionLink("Detalhes", "Details", new { id = item.id })%>
            </td>
            <td><%= Html.Encode(item.estado) %></td>
            <td><%= Html.Encode(item.cidade) %></td>
            <td><%= Html.Encode(item.data) %></td>
            <td><%= Html.Encode(item.nome) %> </td>
            <td><%= Html.Encode(item.descricao) %></td>
            <td><%= Html.Encode(item.valor_inscricao) %> </td>
            <td><%= Html.Encode(item.status) %> </td>
        </tr>

    <% } %> 

    </table> 

    <p><%= Html.ActionLink("Nova Corrida", "Create") %></p>

    </p>
</asp:Content>
