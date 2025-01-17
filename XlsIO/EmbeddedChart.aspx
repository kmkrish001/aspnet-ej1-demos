<%@ Page Title="XlsIO-Embedded Chart-ASP.NET-SYNCFUSION"   MasterPageFile="~/samplebrowser.master" Language="C#" AutoEventWireup="true"
    CodeFile="EmbeddedChart.aspx.cs" Inherits="WebSampleBrowser.XlsIO.EmbeddedChart" %>

<asp:content id="Content2" contentplaceholderid="ControlsSection" runat="server">
    <p>
        Essential XlsIO has APIs for creating an embedded chart. The <strong>IChartShape</strong>
        interface represents the embedded chart in memory. This object can be used to format
        and modify chart settings; it is similar to modifying chart properties using Excel.
    </p>
    <br />
    <p>
        Click the button to view an Excel spreadsheet generated by Essential XlsIO. 
        Please note that Microsoft Excel Viewer or Microsoft Excel is required to view the resultant document.
    </p>
    <div>
        <table id="PanelTable" width="750px" cellpadding="0" cellspacing="0" border="0">
            <tr>
                <td>                    
                    <div>
                        <table width="80%" cellpadding="0" cellspacing="0" border="0">
                            <tr>
                            <td>
                                <asp:label runat="server" id="label2" text="Save As:"></asp:label>
                                <asp:radiobutton style="margin-left: 10px" id="rBtnXls" runat="server" groupname="Group1" text="XLS" />
                                <asp:radiobutton style="margin-left: 10px" id="rBtnXlsx" runat="server" groupname="Group1" text="XLSX" checked="true" />
                                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Create Document"
                                        Width="200px" />
                            </td>
                            </tr>
                        </table>
                    </div>
                </td>
            </tr>
        </table>
    </div>
</asp:content>

