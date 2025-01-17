<%@ Page Title="XlsIO-Sunburst-ASP.NET-SYNCFUSION"   MasterPageFile="~/samplebrowser.master" Language="C#" AutoEventWireup="true"
    CodeFile="Sunburst.aspx.cs" Inherits="WebSampleBrowser.XlsIO.Sunburst" %>

<asp:content id="Content2" contentplaceholderid="ControlsSection" runat="server">
    <p>
        Essential XlsIO has APIs for creating and modifying Sunburst charts.
    </p>
    <br />
    <p>
        Click the button to view an Excel spreadsheet generated by Essential XlsIO. 
        Please note that Microsoft Excel Viewer or Microsoft Excel is required to view the resultant document.
    </p>
    <div>
        <table id="PanelTable" width="100%" cellpadding="0" cellspacing="0" border="0">
            <tr style="margin-top: 5px;">
                <td>
                    <asp:label runat="server" id="label2" text="Location :"></asp:label>
                    <asp:radiobutton style="margin-left: 10px" id="rBtnEmbed" runat="server" groupname="formatgrp" text=" Embedded Chart" checked="true"/>
                    <asp:radiobutton  style="margin-left: 10px" id="rBtnSheet" runat="server" groupname="formatgrp" text=" Chart Sheet"  />
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <br />
                    <br />
                    <asp:button width="148px" id="Button3" runat="server" text="Create Document" onclick="Button1_Click"/>                                                          
                    &nbsp;&nbsp;
                    <asp:Button ID="Button4" runat="server" OnClick="Button2_Click" Text="Input Template" Width="148px" />                               
                </td>
            </tr>
        </table>        
    </div>
</asp:content>

