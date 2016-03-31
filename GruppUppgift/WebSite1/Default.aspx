<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    
    <p>
    </p>
    <asp:GridView ID="GridView1" runat="server" DataSourceID="SqlDataSourceGrupp">
    </asp:GridView>
    <asp:SqlDataSource ID="SqlDataSourceGrupp" runat="server" ConnectionString="<%$ ConnectionStrings:SQLDB GruppUppgiftConnectionString %>" SelectCommand="SqlStoredProcedure1" SelectCommandType="StoredProcedure"></asp:SqlDataSource>
    <asp:GridView ID="GridView2" runat="server" DataSourceID="SqlDataSourcegrupp2">
    </asp:GridView>
    <asp:SqlDataSource ID="SqlDataSourcegrupp2" runat="server" ConnectionString="<%$ ConnectionStrings:SQLDB GruppUppgiftConnectionString %>" SelectCommand="findAllCharacters" SelectCommandType="StoredProcedure">
        <SelectParameters>
            <asp:ControlParameter ControlID="TextBox1" Name="firstLetter" PropertyName="Text" Type="String" />
        </SelectParameters>
    </asp:SqlDataSource>
    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    <asp:Button ID="Button1" runat="server" Text="Button" />
    
    <!---->

 
</asp:Content>
