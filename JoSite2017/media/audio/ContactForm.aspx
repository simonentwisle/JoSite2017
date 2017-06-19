<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ContactForm.aspx.cs" Inherits="ContactForm" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>ContactForm</title>
   <link href="css/joTemp.css" type="text/css" rel="stylesheet" /> 
</head>
<body>
    <form id="form1" runat="server">
    <div id="contactform">
			<table width="50%">
				<tr align="center">
					<td colspan="2"><P>If you would like to contact me please complete the following form 
							and I will get back to you.</P>
					</td>
				</tr>
				<tr>
					<td>Name:</td>
					<td>
						<asp:TextBox id="Name" runat="server" Width="200px"></asp:TextBox></td>
				</tr>
				<tr>
					<td>Email:</td>
					<td>
						<asp:TextBox id="Email" runat="server" Width="200px"></asp:TextBox></td>
				</tr>
				<tr>
					<td>Message:</td>
					<td>
						<asp:TextBox id="Message" runat="server" TextMode="MultiLine" Width="199px" Rows="8"></asp:TextBox></td>
				</tr>
				<tr align="center">
					<td colspan="2">
						<asp:Button id="Button1" runat="server" Text="Submit" CssClass="button" OnClick="Button1_Click"></asp:Button></td>
				</tr>
			</table>
		</div>
    </form>
</body>
</html>
