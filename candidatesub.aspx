﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="candidatesub.aspx.cs" Inherits="WebApplication1.candidatesub" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            text-align: center;
        }
        .auto-style2 {
            width: 66%;
        }
        .auto-style3 {
            text-align: left;
        }
        .auto-style4 {
            text-align: left;
            margin-left: 40px;
        }
        .auto-style5 {
            height: 29px;
            text-align: left;
            width: 668px;
        }
        .auto-style6 {
            text-align: left;
            height: 29px;
            margin-left: 40px;
        }
        .auto-style7 {
            text-align: left;
            width: 668px;
        }
        .auto-style8 {
            text-align: left;
            height: 29px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="auto-style1">
            <strong>Register</strong>
            <table class="auto-style2">
                <tr>
                    <td class="auto-style7">Name</td>
                    <td class="auto-style3">
                        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style5">Skills </td>
                    <td class="auto-style8">
                        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style7">Programming Languages</td>
                    <td class="auto-style3">
                        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style7">High Qualification</td>
                    <td class="auto-style4">
                        <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style5">College Name</td>
                    <td class="auto-style6">
                        <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style7">University</td>
                    <td class="auto-style4">
                        <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style7">Permanent Address</td>
                    <td class="auto-style4">
                        <asp:TextBox ID="TextBox7" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style7">Experience(in years)</td>
                    <td class="auto-style4">
                        <asp:TextBox ID="TextBox8" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style7">Notice Period(in months)</td>
                    <td class="auto-style4">
                        <asp:TextBox ID="TextBox9" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style7">Latest Company(working/worked)</td>
                    <td class="auto-style4">
                        <asp:TextBox ID="TextBox10" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style7">Latest Designation(working/worked)</td>
                    <td class="auto-style4">
                        <asp:TextBox ID="TextBox11" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style7">Current Salary(in figures)</td>
                    <td class="auto-style4">
                        <asp:TextBox ID="TextBox12" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style7">Age</td>
                    <td class="auto-style4">
                        <asp:TextBox ID="TextBox13" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style7">Date of birth</td>
                    <td class="auto-style4">
                        <asp:TextBox ID="TextBox14" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style7">Email id</td>
                    <td class="auto-style4">
                        <asp:TextBox ID="TextBox15" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td colspan="2">
                        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Submit" />
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
