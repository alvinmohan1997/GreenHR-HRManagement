<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="website.aspx.cs" Inherits="WebApplication1.website" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="width: 1461px">
    <form id="form1" runat="server">
        <div>
            <asp:Repeater ID="Repeater1" runat="server" DataSourceID="SqlDataSource1">
                
                <HeaderTemplate>
                    <table border="1">
                    <tr>
                        <th>Open Date</th>
                        <th>Designation</th>
                    </tr>
                </HeaderTemplate>
                
                <ItemTemplate>
                    <tr>
                        <td><%#Eval("dateapp") %></td>
                        <td><%# Eval("desg") %></td>
                        
                        <td>
                            <asp:Button ID="Button1" runat="server" Text="Apply now" CommandArgument='<%#Eval("appl_id") %>' OnClick="mybtnhandler"/>
                        </td>
                    </tr> 

                </ItemTemplate>
                   
            </asp:Repeater>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:greenhrConnectionString2 %>" SelectCommand="SELECT DISTINCT [appl_id], [desg], [dateapp] FROM [application_table] WHERE ([appstatus] = @appstatus) ORDER BY [dateapp] DESC">
              
                <SelectParameters>
                    <asp:Parameter DefaultValue="inprogress" Name="appstatus" Type="String" />
                </SelectParameters>
            </asp:SqlDataSource>
            
        </div>
    </form>

    
    <p>
        &nbsp;</p>
</body>
</html>
