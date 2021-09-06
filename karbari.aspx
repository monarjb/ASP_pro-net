<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="karbari.aspx.cs" Inherits="Webtamrin1.karbari" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 96px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Panel ID="Panel1" runat="server">
        </asp:Panel>
        <asp:Panel ID="Panel2" runat="server" Font-Bold="True">
            <table align="center">
                <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td class="auto-style1">&nbsp;</td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td class="auto-style1">
                        <asp:Panel ID="Panel5" runat="server" HorizontalAlign="Center">
                            <asp:Image ID="Image1" runat="server" Height="54px" ImageUrl="~/img/kalle.png" Width="49px" />
                        </asp:Panel>
                    </td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>
                        <asp:Panel ID="Panel6" runat="server" HorizontalAlign="Center">
                            <asp:Label ID="Label1" runat="server" ForeColor="#0033CC" Text="Label"></asp:Label>
                        </asp:Panel>
                    </td>
                    <td>&nbsp;</td>
                    <td class="auto-style1">یوزر جاری</td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>
                        <asp:ImageButton ID="ImageButton2" runat="server" Height="30px" ImageUrl="~/img/exiticon.png" OnClick="ImageButton2_Click" Width="29px" />
                    </td>
                    <td>
                        <asp:ImageButton ID="ImageButton1" runat="server" Height="26px" ImageUrl="~/img/refresh.png" OnClick="ImageButton1_Click" Width="23px" />
                    </td>
                    <td>&nbsp;</td>
                    <td>
                        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                    <td class="auto-style1">تغییر کلمه عبور</td>
                </tr>
            </table>
        </asp:Panel>
        <asp:Panel ID="Panel3" runat="server">
        </asp:Panel>
        <asp:Panel ID="Panel4" runat="server">
        </asp:Panel>
    
    </div>
    </form>
</body>
</html>
