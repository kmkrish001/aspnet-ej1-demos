<%@ Page Title="Presentation-Header And Footer-ASP.NET-SYNCFUSION"   Language="C#" MasterPageFile="~/Samplebrowser.Master" AutoEventWireup="true" CodeBehind="HeaderAndFooter.aspx.cs" Inherits="WebSampleBrowser.PPTX.HeaderAndFooter" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ControlsSection" runat="server">
	<p>Essential Presentation library has support for inserting, editing and removing header and footer in a PowerPoint presentation.</p>
    <p>This sample demonstrates how to insert the header and footer in a PowerPoint presentation.</p>
	<p><b>Features:</b></p>	
	<p>
		<ul>
		<li>Add date and time, slide number and footer into a PowerPoint slide.</li>
		<li>Add header into a notes slide.</li>
        <li>Edit an existing header or footer.</li>
		</ul>
	</p>
    <table width="100%">
        <tr>
            <td align="left">
                <div>
                    <asp:Label Width="100%"  Style="text-align: justify;"
                        ID="label6" runat="server" Text="Click the button to view a presentation document generated by Essential Presentation.  Please note that MS PowerPoint viewer is required to view the resultant document."></asp:Label>
                </div>
                <br />
                <div style="border: solid 0px #788DB3; padding: 5px 7px 5px 7px;">
                    <table width="100%">
                        <tr>
                            <td align="left" width="100%" cellpadding="0" cellspacing="0" border="0">
                                <asp:Button Width="165px" Style="margin-right: 3px" ID="Button1" Height="27px" runat="server"
                                     OnClick="Button1_Click" Text="Create Presentation" />
                            </td>
                        </tr>
                    </table>
                </div>
            </td>
        </tr>
    </table>
</asp:Content>

