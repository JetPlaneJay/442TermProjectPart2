<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CustomerIncidentDisplay.aspx.cs" Inherits="MIS442_TermOutline_JTabares.CustomerIncidentDisplay" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:DropDownList ID="ddlIncidents1" runat="server" DataSourceID="SqlDataSource1" DataTextField="Name" DataValueField="CustomerID">
            </asp:DropDownList>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:TechSupportConnectionString %>" SelectCommand="SELECT [CustomerID], [Name] FROM [Customers] ORDER BY [Name]"></asp:SqlDataSource>
        </div>
        <asp:DropDownList ID="ddlIncidents" runat="server" DataSourceID="SqlDataSource2" DataTextField="Version" DataValueField="Name">
            <asp:ListItem></asp:ListItem>
            <asp:ListItem></asp:ListItem>
        </asp:DropDownList>
        <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString2 %>" SelectCommand="SELECT Technicians.Name, Incidents.DateOpened, Incidents.DateClosed, Products.Version, Products.ReleaseDate FROM Incidents INNER JOIN Products ON Incidents.ProductCode = Products.ProductCode INNER JOIN Technicians ON Incidents.TechID = Technicians.TechID"></asp:SqlDataSource>
        <asp:Label ID="lblIncidentID" runat="server" Text="Label"></asp:Label>
        <asp:Label ID="lblProductCode" runat="server" Text="Label"></asp:Label>
        <asp:Label ID="lblTechID" runat="server" Text="Label"></asp:Label>
        <asp:Label ID="lblName" runat="server" Text="Label"></asp:Label>
    </form>
</body>
</html>
