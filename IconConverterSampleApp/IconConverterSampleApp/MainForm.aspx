<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MainForm.aspx.cs" Inherits="IconConverterSampleApp.MainForm" %>

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
    <div class="row">
        <div class="col-sm-offset-12"/>
        
        <div class="col-sm-8">PNGファイルを選択してください</div>
                    
        <div class="col-sm-2" />
        <div class="col-sm-8">
            <input id="File1" type="file" />
        </div>
        <div class="col-sm-2" />
        <div class="col-sm-2" />
        <div class="col-sm-12" />
        <div class="col-sm-4" />
        <div class="col-sm-4" >
            <input id="Button1" type="button" value="変換開始" />
        </div>
        <div class="col-sm-4" />
    </div>
</body>
</html>
