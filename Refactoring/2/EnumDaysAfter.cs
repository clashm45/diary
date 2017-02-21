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


// todayが火曜であることを確認する処理
string today = "2";//どこかから取得した値
bool b = Days.Tuesday.Equals(today);

// 日曜かどうかboolを取りたい場合
bool b = Days.Sunday.Equals(today);

