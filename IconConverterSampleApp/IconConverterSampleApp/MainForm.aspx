﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MainForm.aspx.cs" Inherits="IconConverterSampleApp.MainForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>

    <title></title>
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no"/>
    
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <link href="Content/Style.css" rel="stylesheet" type="text/css"/>

</head>
<body>
    <form id="Form1" method="post" runat="server" enctype="multipart/form-data">
    <h2>Icon変換アプリ</h2>
        <h3>PngからIconに変換します</h3>
       

     <p>PNGファイルを選択してください</p>
                    
     <input id="File1" type="file" name="postdata" />
            <%--<input id="Button1" type="button" value="変換開始" OnClick="Button1_Click" />--%>
     <asp:Button runat="server" id="button1" Text="OK" OnClick="Button1_Click"/>
     
     
     </form>
</body>
</html>
