
<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="CriarPersonagemPage.aspx.cs" Inherits="RPGProjectOnis.Web.WF.CriarPersonagemPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">          
    <asp:Table id="Table1" runat="server" 
                GridLines="Both"  
                HorizontalAlign="Center" CellSpacing="0" 
                CellPadding="0" Width="100%" BorderWidth="0px">
        <asp:TableRow >
            <asp:TableCell Width="50%" BorderWidth="0px">
                <asp:Label ID="Label3" runat="server" Text="Nome do Personagem" CssClass="lbTitle"></asp:Label>
                <br />
                <asp:TextBox ID="TbNomePers" runat="server" Width="90%"></asp:TextBox>
                <br />
                <br />
                <asp:Label ID="Label13" runat="server" Text="Jogador" CssClass="lbTitle"></asp:Label>
                <br />
                <asp:TextBox ID="tbJogador" runat="server" Width="90%"></asp:TextBox>
                <br />   
            </asp:TableCell>
            <asp:TableCell Width="30%" BorderWidth="0px">
                              
                <asp:Label ID="Label8" runat="server" Text="Raça" CssClass="lbTitle"></asp:Label>
                <br />
                <asp:DropDownList ID="dpRacas" runat="server" Width="90%" AutoPostBack="True"
                    OnSelectedIndexChanged="dpRacas_OnSelectedIndexChanged"></asp:DropDownList>
                <br />
                <br />
                <asp:Label ID="Label11" runat="server" Text="Classe" CssClass="lbTitle"></asp:Label>
                <br />
                <asp:DropDownList ID="dpClasses" runat="server" Width="90%" AutoPostBack="True"
                    OnSelectedIndexChanged="dpClasses_OnSelectedIndexChanged"></asp:DropDownList>
            </asp:TableCell>
            <asp:TableCell Width="10%" BorderWidth="0px">
                <asp:Label ID="Label6" runat="server" Text="CA" CssClass="lbTitle"></asp:Label>
                <br />
                <asp:TextBox ID="tbCA" runat="server" Width="80%" type="number"></asp:TextBox>
                <br />
                <br />
                <asp:Label ID="Label19" runat="server" Text="Vida" Visible="false" ></asp:Label>
                <br />
                <asp:TextBox ID="TextBox2" runat="server" Width="80%" Visible="false" ></asp:TextBox>
            </asp:TableCell>
             <asp:TableCell Width="10%" BorderWidth="0px">
                <asp:Label ID="Label17" runat="server" Text="Vida" CssClass="lbTitle"></asp:Label>
                <br />
                <asp:TextBox ID="tbVida" runat="server" Width="80%" Enabled="false"></asp:TextBox>
                <br />
                <br />
                <asp:Label ID="Label18" runat="server" Text="Vida" Visible="false" ></asp:Label>
                <br />
                <asp:TextBox ID="TextBox1" runat="server" Width="80%" Visible="false" ></asp:TextBox>
            </asp:TableCell>
            
        </asp:TableRow>        
    </asp:Table>
    
    <br />
    <asp:Table id="Table2" runat="server" 
                GridLines="Both"  
                HorizontalAlign="Center" CellSpacing="0" 
                CellPadding="0" Width="100%" BorderWidth="0px">
        <asp:TableRow>

            <asp:TableCell Width="5%" BorderWidth="0px">                                
                <asp:Label ID="Label4" runat="server" Text="Força"></asp:Label>                 
                <br />
                <asp:Label ID="Label9" runat="server" Text="Destreza"></asp:Label>
                <br />
                <asp:Label ID="Label7" runat="server" Text="Constituição"></asp:Label> 
            </asp:TableCell>

            <asp:TableCell Width="10%" BorderWidth="0px">
                <asp:TextBox ID="tbForca" runat="server" Width="35%" type="number"></asp:TextBox>
                &ensp;<asp:Label ID="lbAddFor" runat="server" Text="+???"></asp:Label> 
                &ensp;<asp:Image runat="server" ID="forImg" ImageUrl="~/Images/check-icone-scaled.png" Width="15px" Height="15px" />
                <br />
                <asp:TextBox ID="tbDest" runat="server" Width="35%" type="number"></asp:TextBox>
                &ensp;<asp:Label ID="lbAddDes" runat="server" Text="+???"></asp:Label> 
                &ensp;<asp:Image runat="server" ID="Image2" ImageUrl="~/Images/check-icone-scaled.png" Width="15px" Height="15px" />
                <br />
                <asp:TextBox ID="tbConst" runat="server" Width="35%" type="number"></asp:TextBox>
                &ensp;<asp:Label ID="lbAddCon" runat="server" Text="+???"></asp:Label> 
                &ensp;<asp:Image runat="server" ID="Image1" ImageUrl="~/Images/check-icone-scaled.png" Width="15px" Height="15px" />            
            </asp:TableCell>

            <asp:TableCell Width="5%" BorderWidth="0px">
                <asp:Label ID="Label5" runat="server" Text="Inteligência"></asp:Label>                 
                <br />
                <asp:Label ID="Label10" runat="server" Text="Sabedoria"></asp:Label>                 
                <br />
                <asp:Label ID="Label12" runat="server" Text="Carisma"></asp:Label>  
            </asp:TableCell>

            <asp:TableCell Width="10%" BorderWidth="0px">
                <asp:TextBox ID="tbInt" runat="server" Width="35%" type="number"></asp:TextBox>
                &ensp;<asp:Label ID="lbAddInt" runat="server" Text="+???"></asp:Label> 
                &ensp;<asp:Image runat="server" ID="Image3" ImageUrl="~/Images/check-icone-scaled.png" Width="15px" Height="15px" />
                <br />
                <asp:TextBox ID="tbSab" runat="server" Width="35%" type="number"></asp:TextBox>
                &ensp;<asp:Label ID="lbAddSab" runat="server" Text="+???"></asp:Label> 
                &ensp;<asp:Image runat="server" ID="Image4" ImageUrl="~/Images/check-icone-scaled.png" Width="15px" Height="15px" />
                <br />
                <asp:TextBox ID="tbCaris" runat="server" Width="35%" type="number"></asp:TextBox>
                &ensp;<asp:Label ID="lbAddCaris" runat="server" Text="+???"></asp:Label> 
                &ensp;<asp:Image runat="server" ID="Image5" ImageUrl="~/Images/check-icone-scaled.png" Width="15px" Height="15px" />
            </asp:TableCell>

            <asp:TableCell Width="5%" BorderWidth="0px">
                
            </asp:TableCell>             

            <asp:TableCell Width="5%" BorderWidth="0px">
                
             </asp:TableCell>

            <asp:TableCell Width="35%" BorderWidth="0px">
             
                
            </asp:TableCell>

            <asp:TableCell Width="5%" BorderWidth="0px"></asp:TableCell>

        </asp:TableRow>
    </asp:Table>

    <asp:Table id="Table3" runat="server" 
                GridLines="Both"  
                HorizontalAlign="Center" CellSpacing="0" 
                CellPadding="0" Width="100%" BorderWidth="0px">
        <asp:TableRow >
            <asp:TableCell Width="49%" BorderWidth="0px">
                <br />
                <asp:Label ID="Label14" runat="server" Text="Habilidades Iniciais de Classe" CssClass="lbTitle"></asp:Label>
                <br />
                <br />
                <asp:Label ID="lbHabClasse" runat="server" Text="Texto aqui"></asp:Label>
             </asp:TableCell>
             <asp:TableCell Width="2%" BorderWidth="0px"></asp:TableCell>
            <asp:TableCell Width="49%" BorderWidth="0px">
                <br />
                <asp:Label ID="Label15" runat="server" Text="Habilidades de Raças" CssClass="lbTitle"></asp:Label>
                <br />
                <br />
                <asp:Label ID="lbHabRaca" runat="server" Text="Texto Aqui"></asp:Label>
             </asp:TableCell>
        </asp:TableRow>
    </asp:Table>

    <asp:Table id="Table4" runat="server" 
                GridLines="Both"  
                HorizontalAlign="Center" CellSpacing="0" 
                CellPadding="0" Width="100%" BorderWidth="0px">
        <asp:TableRow >
            <asp:TableCell Width="50%" BorderWidth="0px">
                <br />
                <asp:Label ID="Label16" runat="server" Text="Itens Iniciais" CssClass="lbTitle"></asp:Label>
                <br />
                <br />
                <asp:DropDownList ID="dpEq1" runat="server" Width="90%"></asp:DropDownList>
                <asp:DropDownList ID="dpEq2" runat="server" Width="90%"></asp:DropDownList>
                <asp:DropDownList ID="dpEq3" runat="server" Width="90%"></asp:DropDownList>
                <asp:DropDownList ID="dpEq4" runat="server" Width="90%"></asp:DropDownList>
             </asp:TableCell>
            <asp:TableCell Width="50%" BorderWidth="0px">
                
             </asp:TableCell>
        </asp:TableRow>
    </asp:Table>
    
    <asp:Table id="Table5" runat="server" 
                GridLines="Both"  
                HorizontalAlign="Center" CellSpacing="0" 
                CellPadding="0" Width="100%" BorderWidth="0px">
         <asp:TableRow >
             <asp:TableCell Width="25%" BorderWidth="0px">
                 <br />
                 <asp:Button id="btnCriarPers" runat="server" Text="Criar Personagem"  OnClick="btnCriarPers_OnClick" />
             </asp:TableCell>
             <asp:TableCell Width="25%" BorderWidth="0px"></asp:TableCell>
             <asp:TableCell Width="25%" BorderWidth="0px"></asp:TableCell>
             <asp:TableCell Width="25%" BorderWidth="0px"></asp:TableCell>
         </asp:TableRow>
    </asp:Table>
</asp:Content>
