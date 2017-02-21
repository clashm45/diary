public class BusinessLogic {
	
	public int GetValueIndex(Model model) {
		if(! string.IsNullOrEmpty(model.Value10)) {
			return 10;
		}
		else if(! string.IsNullOrEmpty(model.Value9)) {
			return 9;
		}
		else if(! string.IsNullOrEmpty(model.Value8)) {
			return 8;
		}
		else if(! string.IsNullOrEmpty(model.Value7)) {
			return 7;
		}
		else if(! string.IsNullOrEmpty(model.Value6)) {
			return 6;
		}
		else if(! string.IsNullOrEmpty(model.Value5)) {
			return 5;
		}
		else if(! string.IsNullOrEmpty(model.Value4)) {
			return 4;
		}
		else if(! string.IsNullOrEmpty(model.Value3)) {
			return 3;
		}
		else if(! string.IsNullOrEmpty(model.Value2)) {
			return 2;
		}
		else if(! string.IsNullOrEmpty(model.Value1)) {
			return 1;
		}
		else
		{
			return 0;
		}
	}
}