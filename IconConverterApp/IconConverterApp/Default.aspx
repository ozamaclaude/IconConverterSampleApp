<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="IconConverterApp._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h2>変換アプリ</h2>

        <div class="m-1">
        <asp:FileUpload id="FileUpLoad1" runat="server" />    
        </div>

        <div class="mt-md-2">
        <asp:DropDownList ID="DropDownList1" runat="server">
            <asp:ListItem Value="0">変換しない</asp:ListItem>
            <asp:ListItem Value="1">100</asp:ListItem>
            <asp:ListItem Value="2">200</asp:ListItem>
            <asp:ListItem Value="3">300</asp:ListItem>
            <asp:ListItem Value="4">400</asp:ListItem>
        </asp:DropDownList>
            </div>

        <asp:CheckBox ID="CheckBox1" runat="server"></asp:CheckBox>

        <br />
        <div class="m-2">
        <asp:Button id="UploadBtn" OnClick="UploadBtn_Click" runat="server" Width="105px" />
        </div>
        <asp:Label ID="Label1" runat="server"/>
    


    </div>

    <div class="row">
        <div class="col-md-4">
            <h2>Getting started</h2>
            <p>
                ASP.NET Web Forms lets you build dynamic websites using a familiar drag-and-drop, event-driven model.
            A design surface and hundreds of controls and components let you rapidly build sophisticated, powerful UI-driven sites with data access.
            </p>
            <p>
                <a class="btn btn-default" href="https://go.microsoft.com/fwlink/?LinkId=301948">Learn more &raquo;</a>
            </p>
        </div>
        <div class="col-md-4">
            <h2>Get more libraries</h2>
            <p>
                NuGet is a free Visual Studio extension that makes it easy to add, remove, and update libraries and tools in Visual Studio projects.
            </p>
            <p>
                <a class="btn btn-default" href="https://go.microsoft.com/fwlink/?LinkId=301949">Learn more &raquo;</a>
            </p>
        </div>
        <div class="col-md-4">
            <h2>Web Hosting</h2>
            <p>
                You can easily find a web hosting company that offers the right mix of features and price for your applications.
            </p>
            <p>
                <a class="btn btn-default" href="https://go.microsoft.com/fwlink/?LinkId=301950">Learn more &raquo;</a>
            </p>
        </div>
    </div>

</asp:Content>
