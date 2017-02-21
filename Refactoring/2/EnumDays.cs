public enum Days {
	Sat=1,
	Sun,
	Mon,
	Tue,
	Wed,
	Thu,
	Fri
}

// todayが火曜であることを確認する処理
string today = "4";//どこかから取得した値
bool b = ((int)Days.Tue).ToString().Equals(today);

// 日曜かどうかboolを取りたい場合
bool b = ((int)Days.Sun).ToString().Equals(today);

// ひたすらintにcastしてToString().Equals()...!