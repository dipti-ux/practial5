<%@ Page Language="C#" AutoEventWireup="true"
    CodeBehind="Default.aspx.cs"
    Inherits="Practicle_5.Default" %>

<!DOCTYPE html>

<html>
<head runat="server">
    <title>Academic Calendar & Leave Management</title>
</head>

<body>
    <form id="form1" runat="server">

        <h1>Academic Calendar & Leave Management System</h1>

        <asp:Label ID="lblWelcome" runat="server"
            Font-Size="Large">
        </asp:Label>

        <hr />

        <h2>Academic Calendar</h2>

        <asp:Calendar ID="Calendar1"
            runat="server"
            OnSelectionChanged="Calendar1_SelectionChanged">
        </asp:Calendar>

        <br />

        <asp:Label ID="lblSelectedDate"
            runat="server"
            ForeColor="Blue">
        </asp:Label>

        <hr />

        <asp:HyperLink ID="lnkLeave"
            runat="server"
            NavigateUrl="Leave.aspx">
            Apply for Leave
        </asp:HyperLink>

        <br /><br />

        <asp:Button ID="btnLogout"
            runat="server"
            Text="Logout"
            OnClick="btnLogout_Click" />

    </form>
</body>
</html>
