<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="ListaPersonagensPage.aspx.cs" Inherits="RPGProjectOnis.Web.WF.ListaPersonagensPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Panel runat="server" GroupingText="Filtros">
        <asp:Table id="Table1" runat="server" 
                    GridLines="Both"  
                    HorizontalAlign="Center" CellSpacing="0" 
                    CellPadding="0" Width="100%" BorderWidth="0px">
            <asp:TableRow>

                <asp:TableCell Width="25%" BorderWidth="0px">
                    <asp:Label ID="Label1" runat="server" Text="Nome do Personagem"></asp:Label>
                    <asp:TextBox ID="tbNome" runat="server" Width="90%"></asp:TextBox>
                </asp:TableCell>

                <asp:TableCell Width="25%" BorderWidth="0px">
                    <asp:Label ID="Label2" runat="server" Text="Jogador" ></asp:Label>
                    <asp:TextBox ID="tbJogador" runat="server" Width="90%"></asp:TextBox>
                </asp:TableCell>

                <asp:TableCell Width="15%" BorderWidth="0px">
                    <asp:Label ID="Label3" runat="server" Text="Classe"></asp:Label>
                    <asp:DropDownList ID="dpClasses" runat="server" Width="90%" AutoPostBack="True"
                    OnSelectedIndexChanged="dpClasses_OnSelectedIndexChanged"></asp:DropDownList>
                </asp:TableCell>

                <asp:TableCell Width="15%" BorderWidth="0px">
                    <asp:Label ID="Label4" runat="server" Text="Raça"></asp:Label>
                    <asp:DropDownList ID="dpRacas" runat="server" Width="90%" AutoPostBack="True"
                    OnSelectedIndexChanged="dpRacas_OnSelectedIndexChanged"></asp:DropDownList>
                </asp:TableCell>

                <asp:TableCell Width="10%" BorderWidth="0px">
                    <asp:Label ID="Label5" runat="server" Text="Nivel"></asp:Label>
                    <asp:DropDownList ID="dpNivel" runat="server" Width="90%" AutoPostBack="True"
                    OnSelectedIndexChanged="dpNivel_OnSelectedIndexChanged"></asp:DropDownList>
                </asp:TableCell>
                
                <asp:TableCell Width="10%" BorderWidth="0px"></asp:TableCell>
            </asp:TableRow>
        </asp:Table>
    </asp:Panel>

    <asp:Table id="Table2" runat="server" 
                    GridLines="Both"  
                    HorizontalAlign="Center" CellSpacing="0" 
                    CellPadding="0" Width="100%" BorderWidth="0px">
        <asp:TableRow>
            <asp:TableCell Width="100%" BorderWidth="0px">
                <br />
                <asp:GridView ID="gdPersonagens" runat="server" Width="100%" OnPageIndexChanging="grdItens_PageIndexChanging"></asp:GridView>
            </asp:TableCell>
        </asp:TableRow>
    </asp:Table>
</asp:Content>
