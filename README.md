# Dominion Log Analyzer
ドミニオンオンラインのログの解析ツールです。対応は日本語のみです。二人戦のみです。
![property](doc/screenshot.png)<br>

## 開発環境
Visual Studio 2017

## 実行ファイル
exeフォルダをフォルダごとコピーし、フォルダ中のDominion_Log_Analyzer.exeを実行して下さい。

## 使い方 (手動更新)
1. ログをコピー&ペーストします。(ドミニオンオンラインプレイ中にCtrl+a, Ctrl+cで全てのログをコピーできます。)
2. ログの解析ボタンを押します。
3. 自分と相手の所持カード、及び自分の山札が表示されます。エラーがある場合はボタンの隣にメッセージが表示されます。
4. エラー出力ボタンを押すと実行ファイルと同じフォルダに3つのログファイルが作られます。これらは上書きされます。エラーがある場合はご連絡いただけると幸いです。

## 使い方 (自動更新)
1. 自動更新チェックボックスをチェックします。
2. FirefoxでDominion Onlineが起動します。そのままプレイします。
2. 自分と相手の所持カード、及び自分の山札が表示されます。エラーがある場合はボタンの隣にメッセージが表示されます。
3. エラー出力ボタンを押すと実行ファイルと同じフォルダに3つのログファイルが作られます。これらは上書きされます。エラーがある場合はご連絡いただけると幸いです。

## ログの問題
- 伝令官の購入時効果：この効果で山札に行くカード名が匿名の「カード」となるログの不具合があるため正常動作しません。
- 隠遁者使用時の廃棄：手札から廃棄したか捨て札から廃棄したかはログから判別できません。手札からを優先とします。手札にあるカードと同じ種類のカードを捨て札から廃棄し、そのターン中にシャフルが入ると山札のカウントが実際と食い違うことがあります。
- 家臣使用時の効果：家臣で山札から捨て札にしたカードを使用せずに、次のアクションで手札から同名のカードを使用した場合はログから判別できません。そういう動きをし、そのターン中にシャフルが入ると山札のカウントが実際と食い違うことがあります。
- 資料庫複数使用時の効果：ルールでは使用した資料庫ごとに個別にカードを置けるのですが、カードをどの資料庫から取り出したかはログから判別出来ないため資料庫置き場を共通としています。共通の資料庫置き場が空になった時に全ての資料庫は捨て札になります。このため複数の資料庫の使用中にシャフルが入ると、山札のカウントが実際と食い違うことがあります。
- 納骨堂複数使用時の効果：資料庫と同様です。
