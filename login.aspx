<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="Webtamrin1.login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 26px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Panel ID="Panel1" runat="server" HorizontalAlign="Center">
            <table align="center">
                <tr>
                    <td colspan="6">&nbsp;</td>
                </tr>
                <tr>
                    <td colspan="6">
                        &nbsp;</td>
                </tr>
                <tr>
                    <td colspan="6">
                        <asp:Label ID="Label5" runat="server" Font-Bold="True" Text="سامانه سیستم های برودتی "></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td colspan="6">&nbsp;</td>
                </tr>
                <tr>
                    <td colspan="6">
                        <asp:ImageButton ID="ImageButton1" runat="server" Height="257px" ImageUrl="~/img/1.jpg" Width="299px" />
                    </td>
                </tr>
                <tr>
                    <td colspan="6">
                        <asp:Label ID="Label3" runat="server" Font-Bold="True" ForeColor="#006699" Text="نام کاربری"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td colspan="6" class="auto-style1">
                        <asp:TextBox ID="TextBox1" runat="server" Width="162px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td colspan="6">
                        <asp:Label ID="Label4" runat="server" Font-Bold="True" ForeColor="#006699" Text="رمز عبور"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td colspan="6">
                        <asp:TextBox ID="TextBox2" runat="server" Width="162px" TextMode="Password"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td colspan="6">
                        <asp:Label ID="Label6" runat="server" Font-Bold="True" Text="سوال امنیتی"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td colspan="6">
                        <asp:TextBox ID="TextBox3" runat="server" ReadOnly="True"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td colspan="6">
                        <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td colspan="6">
                        <asp:Label ID="Label1" runat="server" Font-Bold="True" ForeColor="#FF3300"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td colspan="6">&nbsp;</td>
                </tr>
                <tr>
                    <td colspan="6">
                        <asp:Button ID="Button1" runat="server" Font-Bold="True" ForeColor="#003366" OnClick="Button1_Click" Text="ورود به سیستم" Width="162px" />
                    </td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
            </table>
        </asp:Panel>
    
    </div>
    </form>
</body>
</html>
