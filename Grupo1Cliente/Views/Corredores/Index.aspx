<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<IEnumerable<Grupo1Cliente.Controllers.CorredoresModel>>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	Index
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h2>Lista Corredores</h2>

    <table>
        <tr>
            <th></th>
            <th>Nome</th>
            <th>Cidade</th>
            <th>Estado</th>
            <th>Status</th>
        </tr>

    <% foreach (var item in Model) { %>
    
        <tr>
            <td>
                <%: Html.ActionLink("Editar", "Edit", new { id=item.id }) %> |
                <%: Html.ActionLink("Detailhes", "Details", new { id = item.id })%> |
                <%: Html.ActionLink("Excluir", "Delete", new { id = item.id })%>
            </td>
            <td>
                <%: item.nome %>
            </td>
            <td>
                <%: item.cidade %>
            </td>
            <td>
                <%: item.estado %>
            </td>
            <td>
                <%: item.status %>
            </td>
        </tr>
    
    <% } %>

    </table>

    <p>
        <%: Html.ActionLink("Cadastrar Novo", "Create") %>
    </p>

</asp:Content>

