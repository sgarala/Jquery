<%@ Page Language="C#" AutoEventWireup="true" CodeFile="DummyData.aspx.cs" Inherits="Ajax_DummyData" %>

<asp:datalist id="dlEmployee" runat="server">
    <HeaderTemplate>
        <table>
            <tr style="background-color: lightgray;">
                <td>ID</td>
                <td>First Name</td>
                <td>Last Name</td>
            </tr>
    </HeaderTemplate>
    <ItemTemplate>
    <tr>
        <td ><%# Eval("Id") %></td>
        <td ><%# Eval("FirstName") %></td>
        <td ><%# Eval("LastName") %></td>
    </tr>
        </ItemTemplate>
    <FooterTemplate>
        </table>
    </FooterTemplate>
</asp:datalist>
