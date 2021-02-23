<%@ Page Title="About" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="About.aspx.cs" Inherits="IconConverterApp.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">


<%--ドットによる箇条書き--%>
<ul>
  <li>1つめの項目</li>
  <li>2つめの項目</li>
  <li>3つめの項目</li>
</ul>

<%--数字による箇条書き--%>
 <ol>
  <li>1つめの項目</li>
  <li>2つめの項目</li>
  <li>3つめの項目</li>
</ol>


<div class="media">
	<a class="media-left" href="#">
		<img src="Images/skateboard.jpeg">
	</a>
	<div class="media-body">
		<h4 class="media-heading">見出し</h4>
		内容。これはサンプル。
	</div>
</div>

<div class="input-group">
	<input type="text" class="form-control" placeholder="abc123">
	<span class="input-group-addon" id="basic-addon2">@example.com</span>
</div>

<div class="btn-group" role="group">
	<button type="button" class="btn btn-default">左</button>
	<button type="button" class="btn btn-default">中央</button>
	<button type="button" class="btn btn-default">右</button>
</div>

<ul class="list-group">
	<li class="list-group-item visible-xs-block">visible-xs-block</li>
	<li class="list-group-item visible-sm-block">visible-sm-block</li>
	<li class="list-group-item visible-md-block">visible-md-block</li>
	<li class="list-group-item visible-lg-block">visible-lg-block</li>
</ul>

<button class="btn btn-default visible-lg-inline visible-md-inline visible-sm-inline visible-xs-inline">lg md sm xs</button>
<button class="btn btn-default visible-lg-inline visible-md-inline visible-sm-inline">lg md sm</button>
<button class="btn btn-default visible-lg-inline visible-md-inline">lg md</button>
<button class="btn btn-default visible-lg-inline">lg</button>

<button class="btn btn-default visible-lg-inline visible-md-inline visible-sm-block visible-xs-block">Ａ</button>
<button class="btn btn-default visible-lg-inline visible-md-inline visible-sm-block visible-xs-block">Ｂ</button>
<button class="btn btn-default visible-lg-inline visible-md-inline visible-sm-block visible-xs-block">Ｃ</button>


<div class="container bg-info">
	<h1>サンプル</h1>
	<p><a class="btn btn-primary" href="../css/container.html#usage1" target="_blank">固定幅のコンテナ</a> のサンプル。</p>
	<p>・・・</p>
	<p>・・・</p>
	<p>・・・</p>
</div>

<div class="container-fluid bg-info">
	<h1>サンプル</h1>
	<p><a class="btn btn-primary" href="../css/container.html#usage1" target="_blank">全幅のコンテナ</a> のサンプル。</p>
	<p>・・・</p>
	<p>・・・</p>
	<p>・・・</p>
</div>

<div class="container-fluid">
	<div class="row">
		<div class="col-md-4">カラムＡ</div>
		<div class="col-md-4">カラムＢ</div>
		<div class="col-md-4">カラムＣ</div>
	</div>
</div>

</asp:Content>
