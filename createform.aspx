<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="createform.aspx.cs" Inherits="WebApplication1.createform" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    
      <script src="Scripts/PersianDatePicker.min.js"></script>
     <link href="Content/PersianDatePicker.css" rel="stylesheet" type="text/css" />
    <title></title>
    <style type="text/css">

         .auto-style51 {
                    border-style: solid;
                border-color: inherit;
            border-width: 1px;
            width: 990px;
            height: 14px;
        }
        .auto-style1 {
            height: 35px;
        }
        .auto-style2 {
            width: 124px;
        }
         </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" Visible="False" />
    
        <br />
    
    </div>
    <div>
    
        <table align="center" cellpadding="4" cellspacing="5" class="auto-style51">
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>
                    <asp:ImageButton ID="ImageButton1" runat="server" Height="35px" ImageUrl="~/img/back.png" OnClick="ImageButton1_Click" Width="34px" />
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>
                    <asp:ImageButton ID="ImageButton2" runat="server" Height="36px" ImageUrl="~/img/exiticon.png" OnClick="ImageButton2_Click" Width="33px" />
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td colspan="2">
                    <asp:Panel ID="Panel1" runat="server" HorizontalAlign="Center">
                        <asp:Image ID="Image1" runat="server" Height="67px" ImageUrl="~/img/222.jpg" Width="71px" />
                    </asp:Panel>
                </td>
                <td>
                    &nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1"></td>
                <td class="auto-style1"></td>
                <td class="auto-style1" aria-checked="undefined" aria-haspopup="False"></td>
                <td class="auto-style1" aria-checked="undefined" aria-haspopup="False">
                    <asp:TextBox ID="TextBox3" runat="server" Visible="False"></asp:TextBox>
                </td>
                <td class="auto-style1" aria-checked="undefined" aria-haspopup="False"></td>
                <td class="auto-style1" aria-checked="undefined" aria-haspopup="False"></td>
                <td class="auto-style1" aria-checked="undefined" aria-haspopup="False"></td>
                <td class="auto-style1" aria-checked="undefined" aria-haspopup="False">&nbsp;</td>
                <td class="auto-style1" aria-checked="undefined" aria-haspopup="False"></td>
                <td class="auto-style1" aria-checked="undefined" aria-haspopup="False"></td>
                <td class="auto-style1" aria-checked="undefined" aria-haspopup="False">
                    <asp:TextBox ID="TextBox2" runat="server" Width="162px"></asp:TextBox>
                </td>
                <td class="auto-style1" aria-checked="undefined" aria-haspopup="False">تاریخ درخواست</td>
                <td class="auto-style1" aria-checked="undefined" aria-haspopup="False"></td>
                <td class="auto-style1" aria-checked="undefined" aria-haspopup="False"></td>
                <td class="auto-style1" aria-checked="undefined" aria-haspopup="False">&nbsp;</td>
                <td class="auto-style1" aria-checked="undefined" aria-haspopup="False"></td>
                <td class="auto-style1" aria-checked="undefined" aria-haspopup="False"></td>
                <td class="auto-style1" aria-checked="undefined" aria-haspopup="False">
                    <asp:TextBox ID="TextBox1" runat="server" Width="162px"></asp:TextBox>
                </td>
                <td class="auto-style1" aria-checked="undefined" aria-haspopup="False"></td>
                <td class="auto-style1" aria-checked="undefined" aria-haspopup="False"></td>
                <td class="auto-style1" aria-checked="undefined" aria-haspopup="False" >نام حوزه</td>
                <td class="auto-style1" aria-checked="undefined" aria-haspopup="False"></td>
                <td class="auto-style1"></td>
                <td class="auto-style1"></td>
                <td class="auto-style1"></td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td aria-checked="undefined" aria-haspopup="False">&nbsp;</td>
                <td aria-checked="undefined" aria-haspopup="False">
                    <asp:TextBox ID="TextBox6" runat="server" Visible="False"></asp:TextBox>
                </td>
                <td aria-checked="undefined" aria-haspopup="False">&nbsp;</td>
                <td aria-checked="undefined" aria-haspopup="False">&nbsp;</td>
                <td aria-checked="undefined" aria-haspopup="False">&nbsp;</td>
                <td class="auto-style1" aria-checked="undefined" aria-haspopup="False">&nbsp;</td>
                <td aria-checked="undefined" aria-haspopup="False">&nbsp;</td>
                <td aria-checked="undefined" aria-haspopup="False">&nbsp;</td>
                <td aria-checked="undefined" aria-haspopup="False">
                    <asp:DropDownList ID="DropDownList4" runat="server" Height="159px" Width="170px" Visible="False">
                        <asp:ListItem>بندرعباس</asp:ListItem>
                        <asp:ListItem>قشم</asp:ListItem>
                        <asp:ListItem>کیش</asp:ListItem>
                        <asp:ListItem>بندرلنگه</asp:ListItem>
                        <asp:ListItem>پارسیان</asp:ListItem>
                        <asp:ListItem>میناب</asp:ListItem>
                    </asp:DropDownList>
                </td>
                <td aria-checked="undefined" aria-haspopup="False">&nbsp;</td>
                <td aria-checked="undefined" aria-haspopup="False">&nbsp;</td>
                <td aria-checked="undefined" aria-haspopup="False">&nbsp;</td>
                <td class="auto-style1" aria-checked="undefined" aria-haspopup="False">&nbsp;</td>
                <td aria-checked="undefined" aria-haspopup="False">&nbsp;</td>
                <td aria-checked="undefined" aria-haspopup="False">&nbsp;</td>
                <td aria-checked="undefined" aria-haspopup="False">
                    <asp:TextBox ID="TextBox4" runat="server" Visible="False"></asp:TextBox>
                </td>
                <td aria-checked="undefined" aria-haspopup="False">&nbsp;</td>
                <td aria-checked="undefined" aria-haspopup="False">&nbsp;</td>
                <td class="auto-style1" aria-checked="undefined" aria-haspopup="False">&nbsp;</td>
                <td aria-checked="undefined" aria-haspopup="False">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td aria-checked="undefined" aria-haspopup="False">&nbsp;</td>
                <td aria-checked="undefined" aria-haspopup="False">
                    <asp:TextBox ID="TextBox9" runat="server" Width="162px"></asp:TextBox>
                </td>
                <td aria-checked="undefined" aria-haspopup="False">&nbsp;</td>
                <td aria-checked="undefined" aria-haspopup="False">&nbsp;</td>
                <td aria-checked="undefined" aria-haspopup="False">&nbsp;</td>
                <td class="auto-style1" aria-checked="undefined" aria-haspopup="False">شماره شناسه دستگاه </td>
                <td aria-checked="undefined" aria-haspopup="False">&nbsp;</td>
                <td aria-checked="undefined" aria-haspopup="False">&nbsp;</td>
                <td aria-checked="undefined" aria-haspopup="False">
                    <asp:TextBox ID="TextBox12" runat="server" Width="162px"></asp:TextBox>
                </td>
                <td aria-checked="undefined" aria-haspopup="False">نوع کولر</td>
                <td aria-checked="undefined" aria-haspopup="False">&nbsp;</td>
                <td aria-checked="undefined" aria-haspopup="False">&nbsp;</td>
                <td class="auto-style1" aria-checked="undefined" aria-haspopup="False">&nbsp;</td>
                <td aria-checked="undefined" aria-haspopup="False">&nbsp;</td>
                <td aria-checked="undefined" aria-haspopup="False">&nbsp;</td>
                <td aria-checked="undefined" aria-haspopup="False">
                    <asp:DropDownList ID="DropDownList5" runat="server" Height="21px" Width="162px">
                        <asp:ListItem>کولر</asp:ListItem>
                    </asp:DropDownList>
                </td>
                <td aria-checked="undefined" aria-haspopup="False">&nbsp;</td>
                <td aria-checked="undefined" aria-haspopup="False">&nbsp;</td>
                <td class="auto-style1" aria-checked="undefined" aria-haspopup="False">نوع دستگاه</td>
                <td aria-checked="undefined" aria-haspopup="False">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>
                    <asp:DropDownList ID="DropDownList6" runat="server" Height="16px" Width="115px" Visible="False">
                        <asp:ListItem>1</asp:ListItem>
                        <asp:ListItem>2</asp:ListItem>
                    </asp:DropDownList>
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>
                    <asp:TextBox ID="TextBox7" runat="server" Width="162px"></asp:TextBox>
                </td>
                <td>
                    محل نصب </td>
                <td>
                    &nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>
                    <asp:TextBox ID="TextBox10" runat="server" Width="162px"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>شماره تماس متقاضی </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>
                    <asp:TextBox ID="TextBox14" runat="server" Width="162px"></asp:TextBox>
                </td>
                <td>
                    تعمیرکار</td>
                <td>
                    &nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>
                    <asp:TextBox ID="TextBox13" runat="server" Width="162px"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>تاریخ تعمیر</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td colspan="15">
                    <asp:TextBox ID="TextBox11" runat="server" Width="851px"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>نوع سرویس</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td colspan="15">
                    <asp:Panel ID="Panel2" runat="server" Direction="RightToLeft">
                        <asp:TextBox ID="TextBox5" runat="server" Width="851px"></asp:TextBox>
                    </asp:Panel>
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>توضیحات</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td colspan="17">
                    <table align="center">
                        <tr>
                            <td>&nbsp;</td>
                            <td class="auto-style2">
                                <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="ثبت اطلاعات" Width="124px" style="height: 26px" />
                            </td>
                            <td>
                                &nbsp;</td>
                        </tr>
                        <tr>
                            <td>&nbsp;</td>
                            <td class="auto-style2">&nbsp;</td>
                            <td>&nbsp;</td>
                        </tr>
                    </table>
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td colspan="15">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
