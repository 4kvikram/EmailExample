<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DashBoard.aspx.cs" Inherits="SendEmailExample.DashBoard" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table align="center">
                <tr>
                    <td>To</td>
                    <td><asp:TextBox ID="txtTo" runat="server" ></asp:TextBox> </td>
                </tr>
                <tr>
                    <td>CC</td>
                    <td><asp:TextBox ID="txtCC" runat="server" ></asp:TextBox> </td>
                </tr>
                <tr>
                    <td>BCC</td>
                    <td><asp:TextBox ID="txtBCC" runat="server" ></asp:TextBox> </td>
                </tr>
                <tr>
                    <td>Subject</td>
                    <td><asp:TextBox ID="txtSubject" runat="server" ></asp:TextBox> </td>
                </tr>
                 <tr>
                    <td>Body</td>
                    <td><asp:TextBox ID="txtBody" runat="server" ></asp:TextBox> </td>
                </tr>
                  <tr>
                    <td></td>
                    <td><asp:Button ID="btnSend" Text="Send Mail" runat="server" OnClick="btnSend_Click"/> </td>
                </tr>
                 <tr>
                    <td></td>
                    <td><asp:Label ID="lblmessage" runat="server"></asp:Label> </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
