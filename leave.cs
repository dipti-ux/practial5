using Newtonsoft.Json.Linq;
using System.Drawing;
using System.Runtime.Remoting.Lifetime;
using System.Web.UI;
using System.Web.UI.WebControls;
using static System.Net.Mime.MediaTypeNames;

<%@ Page Language = "C#" AutoEventWireup="true"
    CodeBehind="Leave.aspx.cs"
    Inherits="Practicle_5.Leave" %>

<!DOCTYPE html>

<html>
<head runat="server">
    <title>Leave Management</title>
</head>

<body>

<form id="form1" runat="server">

    <h1>Leave Management</h1>

    <asp:Label ID = "lblUser"
        runat="server"
        Font-Size="Large"
        ForeColor="Green">
    </asp:Label >

    < hr />

    < h2 > Apply for Leave </ h2 >

    < asp:Label ID = "lblLeaveType"
        runat = "server"
        Text = "Leave Type:" >
    </ asp:Label >

    < br />

    < asp:DropDownList ID = "ddlLeaveType"
        runat = "server" >

        < asp:ListItem
            Text = "Select Leave Type"
            Value = "" >
        </ asp:ListItem >

        < asp:ListItem
            Text = "Medical Leave"
            Value = "Medical" >
        </ asp:ListItem >

        < asp:ListItem
            Text = "Casual Leave"
            Value = "Casual" >
        </ asp:ListItem >

        < asp:ListItem
            Text = "Personal Leave"
            Value = "Personal" >
        </ asp:ListItem >

        < asp:ListItem
            Text = "Emergency Leave"
            Value = "Emergency" >
        </ asp:ListItem >

    </ asp:DropDownList >

    < br />< br />

    < asp:Label ID = "lblReason"
        runat = "server"
        Text = "Reason:" >
    </ asp:Label >

    < br />

    < asp:TextBox ID = "txtReason"
        runat = "server"
        TextMode = "MultiLine"
        Rows = "4"
        Columns = "40" >
    </ asp:TextBox >

    < br />< br />

    < asp:Label ID = "lblSelectDate"
        runat = "server"
        Text = "Select Leave Date:" >
    </ asp:Label >

    < br />< br />

    < asp:Calendar ID = "Calendar1"
        runat = "server"
        OnSelectionChanged = "Calendar1_SelectionChanged" >
    </ asp:Calendar >

    < br />

    < asp:Label ID = "lblDate"
        runat = "server"
        ForeColor = "Blue" >
    </ asp:Label >

    < br />< br />

    < asp:Button ID = "btnApply"
        runat = "server"
        Text = "Apply Leave"
        OnClick = "btnApply_Click" />

    < br />< br />

    < asp:Label ID = "lblMessage"
        runat = "server"
        Font - Bold = "true" >
    </ asp:Label >

    < hr />

    < h2 > My Leave Applications </ h2 >

    < asp:GridView ID = "GridView1"
        runat = "server"
        AutoGenerateColumns = "true"
        EmptyDataText = "No leave applications" >
    </ asp:GridView >

    < br />

    < asp:HyperLink ID = "lnkHome"
        runat = "server"
        NavigateUrl = "Default.aspx" >
        Back to Home
    </ asp:HyperLink >

</ form >

</ body >
</ html >
