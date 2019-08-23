<%@ Page Title="PDF-Adventure Cycle Works-ASP.NET-SYNCFUSION"   Language="C#" MetaDescription="Example [C#] to simple table report in PDF document in ASP.NET Web Forms using Syncfusion .NET PDF library." MasterPageFile="~/Samplebrowser.Master" AutoEventWireup="true" CodeBehind="AdventureCycle.aspx.cs" Inherits="WebSampleBrowser.Pdf.AdventureCycle" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ControlsSection" runat="server">
    <div style = "font-size: 17px;font-weight: 400;">
		This sample demonstrates creation of simple table report in the PDF document using <a href="https://help.syncfusion.com/file-formats/pdf/working-with-tables#creating-a-simple-table-using-pdfgrid-in-a-new-document">PDF Grid.</a>Built-in <a href="https://help.syncfusion.com/file-formats/pdf/working-with-tables#built-in-table-styles">table styles</a> is applied to the grid, will appear like Microsoft Office table style and more styling options are available.


	</div>
                <br />
                <div style="border: solid 1px #788DB3; padding: 5px 7px 5px 7px; background-color: #EDF0F7;">
                    <table width="100%">
                        <tr>
                            <td align="left">
                                <asp:Label ID="Label1" runat="server">Choose built-in styles</asp:Label>
                            </td>                           
                        </tr>
                        <tr>
                            <td align="left">
                                <asp:DropDownList Width="25%" runat="server" ID="comComBox">                                   
                                </asp:DropDownList>
                            </td>                           
                        </tr>                        
                    </table>                                
                <div style="border: solid 1px #788DB3; padding: 5px 7px 5px 7px;margin-top:8px;margin-bottom:8px; background-color: #EDF0F7;">
                    <table width="100%">
                        <tr>
                            <td align="left">
                                <asp:Label ID="Label2" runat="server">Built-in style settings</asp:Label>
                            </td>                           
                        </tr>
                        <tr>
                            <td align="left">
                                <asp:CheckBox ID="CheckBox2" runat="server" Text=" Header row" />
                            </td>
                            <td align="left" >
                                <asp:CheckBox ID="CheckBox3" runat="server" Text=" Banded row" />
                            </td>
                             <td align="left" >
                                <asp:CheckBox ID="CheckBox4" runat="server" Text=" Banded column" />
                            </td> 
                            </tr>
                        <tr>
                            <td align="left">
                                <asp:CheckBox ID="CheckBox5" runat="server" Text=" First column" />
                            </td>
                             <td align="left" >
                                <asp:CheckBox ID="CheckBox6" runat="server" Text=" Last column" />
                            </td>
                             <td align="left" >
                                <asp:CheckBox ID="CheckBox7" runat="server" Text=" Last row" />
                            </td>   
                            </tr>
                                                                                
                        </tr>
                    </table>
                </div>                            
                   
                    <table width="100%">
                        <tr>
                            <td align="left" style="padding: 5px 7px 5px 7px;" width="100%" cellpadding="0" cellspacing="0" border="0">
                                <asp:CheckBox ID="CheckBox1" runat="server" Text=" Open Document inside Browser" />
                            </td>
                            <td align="right">
                                <asp:Button Width="100px" Style="margin-right: 1px" ID="Button1" Height="27px" runat="server"
                                    OnClick="Button1_Click" Text="Create PDF" />
                            </td>
                        </tr>
                    </table>
                    </div>
					  <br/>
		   <div style = "font-size: 17px;font-weight: 400;">
		
More information about the tables can be found in this documentation<a href="https://help.syncfusion.com/file-formats/pdf/working-with-tables"> section.</a>
 


           </div>
              
</asp:Content>



