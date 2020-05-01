<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Sannibhhhh.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <center>
    <form id="form1" runat="server">
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <div>
        </div>
        <div  style=" color:white;
            background-color: #800000;
            height:6px;
            width: 300px;
            padding: 20px;
            padding-bottom:30px;
            margin: 60px;">
            
            History</div>
        <p>
            &nbsp;</p>
        <p>
            <asp:TextBox ID="SearchText" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="Search" BackColor="#800000" ForeColor="White" runat="server" OnClick="TextSearch" Text="Search" />
        </p>
        <p>
            &nbsp;</p>
        <asp:GridView ID="GridView1" runat="server" ShowHeaderWhenEmpty="true" EmptyDataText="no records found" Width="483px">
        </asp:GridView>
        <br />
        <br />
        <asp:Button ID="Button2" BackColor="#800000" ForeColor="White" runat="server" Text="Home" href="#"  />
    </form>
    </center>
</body>
</html>
