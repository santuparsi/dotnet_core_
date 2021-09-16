<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="HandsOnControls.Register" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
	<br />
	<table align="center" style="width: 50%">
		<tr>
			<td>Name *</td>
			<td>
				<asp:TextBox ID="txtName" runat="server"></asp:TextBox>
				<asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtName" ErrorMessage="Pls Enter Name"></asp:RequiredFieldValidator>
			</td>
		</tr>
		<tr>
			<td>Gender</td>
			<td>
				Male: <asp:RadioButton ID="rbtMale" runat="server" />
				<br />
				FeMale: <asp:RadioButton ID="rbtFeMale" runat="server" />
			</td>
		</tr>
		<tr>
			<td>Email *</td>
			<td>
				<asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
			</td>
		</tr>
		<tr>
			<td>Mobile *</td>
			<td>
				<asp:TextBox ID="txtMobile" runat="server"></asp:TextBox>
			</td>
		</tr>
		<tr>
			<td>Age</td>
			<td>
				<asp:TextBox ID="txtage" runat="server" TextMode="Date"></asp:TextBox>
			</td>
		</tr>
		<tr>
			<td>Country</td>
			<td>
				<asp:DropDownList ID="ddlCountry" runat="server">
					<asp:ListItem>India</asp:ListItem>
					<asp:ListItem>US</asp:ListItem>
					<asp:ListItem>UK</asp:ListItem>
					<asp:ListItem>Japan</asp:ListItem>
				</asp:DropDownList>
			</td>
		</tr>
		<tr>
			<td>Password *</td>
			<td>
				<asp:TextBox ID="txtPwd" runat="server" TextMode="Password"></asp:TextBox>
			</td>
		</tr>
		<tr>
			<td>Confirm Password</td>
			<td>
				<asp:TextBox ID="txtCPwd" runat="server" TextMode="Password"></asp:TextBox>
			</td>
		</tr>
		<tr>
			<td>&nbsp;</td>
			<td>
				<asp:CheckBox ID="CheckBox1" runat="server" /> Accept all terms and conditions
			</td>
		</tr>
		<tr>
			<td>&nbsp;</td>
			<td>
				<asp:Button ID="btnRegister" runat="server" Text="Register" OnClick="SignUp" />
			&nbsp;
				<asp:Button ID="btnRegister0" runat="server" Text=" Delete" OnClick="SignUp" />
			&nbsp;<asp:Button ID="btnRegister1" runat="server" Text="Update" OnClick="SignUp" />
			&nbsp;<asp:Button ID="btnRegister2" runat="server" Text="Searech" OnClick="SignUp" />
			</td>
		</tr>
		<tr>
			<td>&nbsp;</td>
			<td>
				<asp:GridView ID="GridView1" runat="server">
				</asp:GridView>
			</td>
		</tr>
	</table>
	
</asp:Content>
