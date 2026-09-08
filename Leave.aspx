<%@ Page Language="C#" AutoEventWireup="true"
    CodeBehind="Leave.aspx.cs"
    Inherits="Practicle_5.Leave" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Leave Management</title>
</head>

<body>

<form id="form1" runat="server">

    <h1>Leave Management System</h1>

    <asp:Label ID="lblUser"
        runat="server"
        Font-Size="Large"
        ForeColor="Blue">
    </asp:Label>

    <hr />

    <h2>Apply for Leave</h2>

    <asp:Label ID="Label1"
        runat="server"
        Text="Select Leave Date:">
    </asp:Label>

    <br />

    <asp:Calendar ID="Calendar1"
        runat="server"
        OnSelectionChanged="Calendar1_SelectionChanged">
    </asp:Calendar>

    <br />

    <asp:Label ID="lblDate"
        runat="server"
        ForeColor="Blue">
    </asp:Label>

    <br /><br />

    <asp:Label ID="Label2"
        runat="server"
        Text="Leave Type:">
    </asp:Label>

    <asp:DropDownList ID="ddlLeaveType"
        runat="server">

        <asp:ListItem Text="-- Select Leave Type --" Value="">
        </asp:ListItem>

        <asp:ListItem Text="Sick Leave" Value="Sick Leave">
        </asp:ListItem>

        <asp:ListItem Text="Personal Leave" Value="Personal Leave">
        </asp:ListItem>

        <asp:ListItem Text="Emergency Leave" Value="Emergency Leave">
        </asp:ListItem>

    </asp:DropDownList>

    <br /><br />

    <asp:Label ID="Label3"
        runat="server"
        Text="Reason:">
    </asp:Label>

    <br />

    <asp:TextBox ID="txtReason"
        runat="server"
        TextMode="MultiLine"
        Rows="4"
        Columns="40">
    </asp:TextBox>

    <br /><br />

    <asp:Button ID="btnApply"
        runat="server"
        Text="Apply Leave"
        OnClick="btnApply_Click" />

    <br /><br />

    <asp:Label ID="lblMessage"
        runat="server"
        Font-Size="Large">
    </asp:Label>

    <hr />

    <h2>Leave Applications</h2>

    <asp:GridView ID="GridView1"
        runat="server"
        AutoGenerateColumns="true">
    </asp:GridView>

    <br />

    <asp:HyperLink ID="lnkHome"
        runat="server"
        NavigateUrl="Default.aspx">
        Back to Home
    </asp:HyperLink>

</form>

</body>
</html>