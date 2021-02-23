<%@ Page Title="Contact" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="IconConverterApp.Contact" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
<form class="form-horizontal">
	<div class="form-group">
		<label class="col-sm-2 control-label" for="InputEmail">メール・アドレス</label>
		<div class="col-sm-10">
			<input type="email" class="form-control" id="InputEmail" placeholder="メール・アドレス">
		</div>
	</div>
	<div class="form-group">
		<label class="col-sm-2 control-label" for="InputPassword">パスワード</label>
		<div class="col-sm-10">
			<input type="password" class="form-control" id="InputPassword" placeholder="パスワード">
		</div>
	</div>
	<div class="form-group">
		<label class="col-sm-2 control-label" for="InputSelect">選択</label>
		<div class="col-sm-10">
			<select class="form-control" id="InputSelect">
				<option>選択肢１</option>
				<option>選択肢２</option>
				<option>選択肢３</option>
			</select>
		</div>
	</div>
	<div class="form-group">
		<div class="col-sm-offset-2 col-sm-10">
			<div class="checkbox">
				<label>
					<input type="checkbox" value="checkboxA"> チェックボックスＡ
				</label>
			</div>
			<div class="checkbox">
				<label>
					<input type="checkbox" value="checkboxB"> チェックボックスＢ
				</label>
			</div>
		</div>
	</div>
	<div class="form-group">
		<div class="col-sm-offset-2 col-sm-10">
			<button type="submit" class="btn btn-default">送信</button>
		</div>
	</div>
</form>
</asp:Content>
