<%@ Page Title="DropDownList-RTL-ASP.NET-SYNCFUSION" Language="C#" MasterPageFile="~/Samplebrowser.Master" AutoEventWireup="true" CodeBehind="RTL.aspx.cs" Inherits="WebSampleBrowser.DropDownList.RTL" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ControlsSection" runat="server">

    <div class="frame">
        <div class="control">
            <ej:DropDownList ID="skillsets" runat="server" DataTextField="Skills" EnableRTL="true" WatermarkText="Select a language" Width="100%"></ej:DropDownList>
        </div>
    </div>

</asp:Content>


