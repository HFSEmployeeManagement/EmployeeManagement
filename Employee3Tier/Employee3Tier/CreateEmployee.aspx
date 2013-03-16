<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CreateEmployee.aspx.cs" Inherits="Employee3Tier.CreateEmployee" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            height: 23px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <table class="auto-style1">
            <tr>
                <td colspan="2">Enter Employee Information:</td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblid" runat="server" Text="Employee Id"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtid" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="lblfirst" runat="server" Text="First Name"></asp:Label>
                </td>
                <td class="auto-style2">
                    <asp:TextBox ID="txtfirstname" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lbllast" runat="server" Text="Last Name"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtlname" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblbirth" runat="server" Text="Birth Date"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtbirthdate" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblsex" runat="server" Text="Sex"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtsex" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="btnsave" runat="server" OnClick="btnsave_Click" style="height: 26px; width: 42px" Text="Save" />
                    &nbsp;</td>
                <td>
                    <asp:Label ID="lblresult" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td colspan="2">
                    <asp:GridView ID="GridView1" runat="server">
                    </asp:GridView>
                </td>
            </tr>
            <tr>
                <td colspan="2">&nbsp;</td>
            </tr>
        </table>
    <div>
    
    </div>
    </form>
</body>
</html>
