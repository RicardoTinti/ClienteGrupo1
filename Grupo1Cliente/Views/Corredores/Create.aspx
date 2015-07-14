<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<Grupo1Cliente.Controllers.CorredoresModel>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	Cadastrar Corredor
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h2>Cadastrar Corredor</h2>

    <% using (Html.BeginForm()) {%>
        <%: Html.ValidationSummary(true) %>

        <fieldset>
            <legend>Campos</legend>
            
            <div class="editor-label">
                <%: Html.LabelFor(model => model.id) %>
            </div>
            <div class="editor-field">
                <%: Html.TextBoxFor(model => model.id) %>
                <%: Html.ValidationMessageFor(model => model.id) %>
            </div>
            
            <div class="editor-label">
                <%: Html.LabelFor(model => model.nome) %>
            </div>
            <div class="editor-field">
                <%: Html.TextBoxFor(model => model.nome) %>
                <%: Html.ValidationMessageFor(model => model.nome) %>
            </div>
            
            <div class="editor-label">
                <%: Html.LabelFor(model => model.data_nasc) %>
            </div>
            <div class="editor-field">
                <%: Html.TextBoxFor(model => model.data_nasc) %>
                <%: Html.ValidationMessageFor(model => model.data_nasc) %>
            </div>
            
            <div class="editor-label">
                <%: Html.LabelFor(model => model.cidade) %>
            </div>
            <div class="editor-field">
                <%: Html.TextBoxFor(model => model.cidade) %>
                <%: Html.ValidationMessageFor(model => model.cidade) %>
            </div>
            
            <div class="editor-label">
                <%: Html.LabelFor(model => model.estado) %>
            </div>
            <div class="editor-field">
                <%: Html.TextBoxFor(model => model.estado) %>
                <%: Html.ValidationMessageFor(model => model.estado) %>
            </div>
            
            <div class="editor-label">
                <%: Html.LabelFor(model => model.status) %>
            </div>
            <div class="editor-field">
                <%: Html.TextBoxFor(model => model.status) %>
                <%: Html.ValidationMessageFor(model => model.status) %>
            </div>
            
            <div class="editor-label">
                <%: Html.LabelFor(model => model.data_cadastro) %>
            </div>
            <div class="editor-field">
                <%: Html.TextBoxFor(model => model.data_cadastro) %>
                <%: Html.ValidationMessageFor(model => model.data_cadastro) %>
            </div>
            
            <p>
                <input type="submit" value="Create" />
            </p>
        </fieldset>

    <% } %>

    <div>
        <%: Html.ActionLink("Voltar para lista de corredores", "Index") %>
    </div>

</asp:Content>

