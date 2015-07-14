<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<Grupo1Cliente.Controllers.CorredoresModel>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	Details
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h2>Details</h2>

    <fieldset>
        <legend>Fields</legend>
        
        <div class="display-label">Id</div>
        <div class="display-field"><%: Model.id %></div>
        
        <div class="display-label">Nome</div>
        <div class="display-field"><%: Model.nome %></div>
        
        <div class="display-label">Nascimento</div>
        <div class="display-field"><%: Model.data_nasc %></div>
        
        <div class="display-label">Cidade</div>
        <div class="display-field"><%: Model.cidade %></div>
        
        <div class="display-label">Estado</div>
        <div class="display-field"><%: Model.estado %></div>
        
        <div class="display-label">Status</div>
        <div class="display-field"><%: Model.status %></div>
        
        <div class="display-label">Cadastrado em</div>
        <div class="display-field"><%: Model.data_cadastro %></div>
        
    </fieldset>
    <p>
        <%: Html.ActionLink("Editar", "Edit", new { id=Model.id }) %> |
        <%: Html.ActionLink("Voltar a lista de corredores", "Index") %>
    </p>

</asp:Content>

