﻿<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="IconConverterApp._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h2>変換アプリ</h2>

        <div class="m-1">
        <asp:FileUpload id="FileUpLoad1" runat="server" BackColor="White" ForeColor="Green"　/>    
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

        <asp:Label Text="ファイルアップロードのみ" runat="server"/>
        <asp:CheckBox ID="CheckBox1" runat="server" AutoPostBack="True" OnCheckedChanged="StatusChanged"/>

        <br />
        <div class="m-2">
        <asp:Button id="UploadBtn" BackColor="Blue" ForeColor="White" OnClick="UploadBtn_Click" runat="server" Width="105px" />
        </div>
        <asp:Label ID="Label1" runat="server"/>

    </div>

    <div class="row">
        <div class="col-md-4">
            <h2>登録状況</h2>
              <asp:GridView ID="GridView1" EnableViewState="false" runat="server" 
                  HeaderStyle-BackColor="Blue"
                  HeaderStyle-ForeColor="White"
                  AutoGenerateColumns="false" DataKeyNames="RegisterNumber" 
                  OnPageIndexChanging="GridView1_PageIndexChanging" 
                  OnRowCancelingEdit="GridView1_RowCancelingEdit" 
                  OnRowDeleting="GridView1_RowDeleting" 
                  OnRowEditing="GridView1_RowEditing" 
                  OnRowCommand="Grid1_RowCommand"
                  OnRowUpdating="GridView1_RowUpdating">
                <Columns>
                    <asp:BoundField DataField="RegisterNumber" HeaderText="登録No" HeaderStyle-Width="100" ReadOnly="true" />
                    <asp:BoundField DataField="RegisterDate" HeaderText="登録日" />
                    <asp:BoundField DataField="RegisterFileName" HeaderText="登録ファイル名" />
                    <asp:BoundField DataField="Notes" HeaderText="備考" />
                    <asp:CommandField ShowEditButton="true" />
                    <asp:ButtonField ButtonType="Button" CommandName="Select" HeaderText="選択" 
                        ShowHeader="True" Text="ダウンロード" />
                </Columns>
            </asp:GridView>
        </div>
    </div>
    <div class="row">
        <div class="col-md-4">
            <h2>カレンダー</h2>
            <asp:Calendar id="calendar1" runat="server">
                <OtherMonthDayStyle ForeColor="LightGray" />
                <TitleStyle BackColor="Blue" ForeColor="White" />
                <DayStyle BackColor="gray" />
                <SelectedDayStyle BackColor="LightGray" Font-Bold="True" />
            </asp:Calendar>
        </div>
    </div>
    <div class="row">
        <div class="col-md-8">
            <h2>パンくずリスト</h2>
        
            <ol class="breadcrumb">
                <li><a href="http://bootstrap3.cyberlab.info"><span class="glyphicon glyphicon-home" aria-hidden="true"></span> Bootstrap3日本語リファレンス</a></li>
                <li><a href="http://bootstrap3.cyberlab.info/components/">コンポーネント</a></li>
                <li class="active">パンくず</li>
            </ol>
        </div>
    </div>

</asp:Content>
