public class Model {
	
	// モデルの構造は諸事情により、変更不可とする。
	public string Value1 { get; set; }
	public string Value2 { get; set; }
	public string Value3 { get; set; }
	public string Value4 { get; set; }
	public string Value5 { get; set; }
	public string Value6 { get; set; }
	public string Value7 { get; set; }
	public string Value8 { get; set; }
	public string Value9 { get; set; }
	public string Value10 { get; set; }

	public Dictionary<int, string> GetValues() {
		return new Dictionary<int, string>() {
			{1, Value1},
			{2, Value2},
			{3, Value3},
			{4, Value4},
			{5, Value5},
			{6, Value6},
			{7, Value7},
			{8, Value8},
			{9, Value9},
			{10, Value10},
		}
	}

}