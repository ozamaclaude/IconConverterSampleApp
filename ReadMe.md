## Pngなどを、Iconに変換して返すアプリ

- 作成中（検討中）
- 不要なファイルはアップロードさせないよう整理
  - その他、WPF側の生産物も見直したほうが良いかもしれない

### アップロード履歴をDBで管理
```
 psql -U postgres -d postgres
```
- TransactionScopeはそのまま実装するとアセンブリ参照エラーが発生。[参照]から参照を追加する。

#### 問題
- 「Can't write CLR type System.String with handler type TimestampHandler」がcmd.ExecuteNonQuery();で発生


