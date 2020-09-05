<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="pdtmanagerview1.aspx.cs" Inherits="WebApplication1.pdtmanagerview1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 246px;
        }
        .auto-style3 {
            width: 246px;
            height: 26px;
        }
        .auto-style4 {
            height: 26px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="auto-style1">
                <tr>
                    <td class="auto-style3">managername</td>
                    <td class="auto-style4">
                        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">projectname</td>
                    <td>
                        <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">period(in month)</td>
                    <td class="auto-style4">
                        <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">vacancy</td>
                    <td>
                        <asp:Label ID="Label4" runat="server" Text="Label"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">skill</td>
                    <td>
                        <asp:Label ID="Label5" runat="server" Text="Label"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">programing language</td>
                    <td>
                        <asp:Label ID="Label6" runat="server" Text="Label"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">experience(in years)</td>
                    <td>
                        <asp:Label ID="Label7" runat="server" Text="Label"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">request description</td>
                    <td class="auto-style4">
                        <asp:Label ID="Label8" runat="server" Text="Label"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">request id</td>
                    <td>
                        <asp:Label ID="Label9" runat="server" Text="Label"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">request status</td>
                    <td>
                        <asp:Label ID="Label10" runat="server" Text="Label"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">designation</td>
                    <td>
                        <asp:Label ID="Label11" runat="server" Text="Label"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">date of request</td>
                    <td class="auto-style4">
                        <asp:Label ID="Label12" runat="server" Text="Label"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        &nbsp;</td>
                    <td>
                        &nbsp;</td>
                </tr>
            </table>
        </div>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="cand_id" DataSourceID="SqlDataSource2" OnRowCommand="GridView1_RowCommand" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
            <Columns>
                <asp:BoundField DataField="cand_id" HeaderText="cand_id" ReadOnly="True" SortExpression="cand_id" />
                <asp:BoundField DataField="cand_name" HeaderText="cand_name" SortExpression="cand_name" />
                <asp:BoundField DataField="skills" HeaderText="skills" SortExpression="skills" />
                <asp:BoundField DataField="pgm_language" HeaderText="pgm_language" SortExpression="pgm_language" />
                <asp:BoundField DataField="req_id" HeaderText="req_id" SortExpression="req_id" />
                <asp:BoundField DataField="hired_date" HeaderText="hired_date" SortExpression="hired_date" />
                <asp:ButtonField ButtonType="Button" CommandName="CandidateView" Text="CandidateDetails" />
            </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:greenhrConnectionString4 %>" SelectCommand="SELECT [cand_id], [cand_name], [skills], [pgm_language], [req_id], [hired_date] FROM [hiredcandidate_table] ORDER BY [hired_date] DESC"></asp:SqlDataSource>
    </form>
</body>
</html>
