<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Demo.aspx.cs" Inherits="Hello_world.Demo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Hi</title>
</head>
<body>
    <h1>Guestbook</h1>
    <form id="form1" runat="server">
         <div>
            <label for="name">Name:</label>
            <asp:TextBox ID="nameTextBox" runat="server" required="true"></asp:TextBox>
        </div>
        <div>
            <label for="message">Message:</label>
            <asp:TextBox ID="messageTextBox" runat="server" TextMode="MultiLine" required="true"></asp:TextBox>
        </div>
        <div>
            <label for="photo">Photo:</label>
            <asp:FileUpload ID="photoFileUpload" runat="server" />
        </div>
        <div>
            <asp:Button ID="submitButton" runat="server" Text="Submit" OnClick="SubmitButton_Click" />
        </div> 
    </form>

    <div id="entriesPanel" runat="server"></div>
</body>
</html>
