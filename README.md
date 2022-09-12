# MJTimerTest
麻雀対局時計＆鳴きボタンサンプル

対局者の前にこのような対局時計＆鳴きボタン装置を置けば、ネット麻雀みたいに公平な対局ができるんじゃない？
持ち時間や発声関連の問題は解決されて、審判さえいれば、大体のトラブルは避けられそう。
（画面下部のオプションは、対局者の行動を表す）

ボタンの役割：
End：手番終了／精算終了
OK：対局開始／続行（鳴かない）
Call：捨て牌を鳴く（吃・碰・大明槓）／手番中行動（加槓・暗槓・抜く）
Win：和了（ツモ・ロン・搶槓）

基本原理：
打牌後、他家は「鳴かない」「鳴く」「ロン」のうち1つを選ぶ。
それらのボタンをある程度遮蔽し、選ぶときは他家から見えないようにする。
ロンを押す人がいれば和了ランプが光り、精算に移る。
鳴くを押す人が複数いれば、遠い方の手番に移る。

立直は、打牌を横置きしてEndを押し、他人の手番になって牌を取ってから供託を出す。
コマンド入力（OK押しっぱでEnd3回）で対局を中断できる。中断中ではCallとWinボタンで持ち時間の調整ができる。
再開コマンド（End押しっぱでOK3回）を入力したら、その人の打牌直後の鳴き選択フェーズから再開。
流局コマンドも用意できる（2人以上同時にEnd長押しとか）。
