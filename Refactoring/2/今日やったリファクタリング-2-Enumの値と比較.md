# 今日やったリファクタリング - 2 : Enumの値と比較

今日じゃないけど、最近やったリファクタリング。  
  
言語は**C#**.  
  
  
enumって列挙型で、定数とかを定義するのに使います。  
簡単な例で言うと、曜日とかを列挙したり。

```cs
public enum Days {
	Sat=1,
	Sun,
	Mon,
	Tue,
	Wed,
	Thu,
	Fri
}
```
  
  
ただ、このままだと結構使いづらくて、こんなコードを書いてしまう場合もあります。
  
  
  
## Before
  
```cs
// todayが火曜であることを確認する処理
string today = "4";//どこかから取得した値
bool b = ((int)Days.Tue).ToString().Equals(today);

// 日曜かどうかboolを取りたい場合
bool b = ((int)Days.Sun).ToString().Equals(today);
```
  
**ひたすらintにcastしてToString().Equals()...!**  
  
ダサいので、やめましょう。  
  
  
## After
  
今回リファクタリングした結果はこんな感じ。  
  
  
```cs
public class Days {
	
	private enum _Days {
		Sat=1,
		Sun,
		Mon,
		Tue,
		Wed,
		Thu,
		Fri
	}

	private _Days val;
	private Days(_Days d) {
		this.val = d;
	}

	public static readonly Days Saturday = new Days(_Days.Sat);
	public static readonly Days Sunday = new Days(_Days.Sun);
	public static readonly Days Monday = new Days(_Days.Mon);
	public static readonly Days Tuesday = new Days(_Days.Tue);
	public static readonly Days Wednesday = new Days(_Days.Wed);
	public static readonly Days Thursday = new Days(_Days.Thu);

	public bool Equals(string value) {
		return Val().Equals(value);
	}

	public string Val() {
		return ((int)this.val).ToString();
	}
}
```
  
  
こんな風にenumをwrapするクラスを作りました。  
そんで、使うときには、  
  
  
  
```cs
// todayが火曜であることを確認する処理
string today = "2";//どこかから取得した値
bool b = Days.Tuesday.Equals(today);

// 日曜かどうかboolを取りたい場合
bool b = Days.Sunday.Equals(today);
```
  
  
毎回castするよりかは可読性は上がりました。  
  
  
  
今回は、C#の場合でしたが、Javaでも同じような書き方が出来ます。  
Javaではenumに独自メソッド書けるけど、まぁどっちがいいやろかね。  
  
  
  
この記事みた後だと、今回の修正後もダサく感じてきます。  
  
C# の enum に関連する小技。  
http://qiita.com/hugo-sb/items/38fe86a09e8e0865d471  
  
  
C#ではこのやり方が一番良いかも！  
  
  
  
以上。  