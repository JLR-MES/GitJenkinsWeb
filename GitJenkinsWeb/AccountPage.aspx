<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AccountPage.aspx.cs" Inherits="GitJenkinsWeb.AccountPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 140px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <table >
        <tr>
            <td>

            Add Numbers
            </td>
        </tr>
<tr>
    <td>
        First Number
    </td>
    <td class="auto-style1">

        <asp:TextBox ID="txtNum1" runat="server"></asp:TextBox>

    </td>
</tr>
        <tr>
    <td>
        
        Second Number</td>
    <td class="auto-style1">

        <asp:TextBox ID="txtNum2" runat="server"></asp:TextBox>

    </td>
</tr>
        <tr>
    <td>
    </td>
    <td class="auto-style1">

        <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" Text="Add" />

    </td>
</tr>


    </table>
    </div>
    </form>
</body>
</html>
