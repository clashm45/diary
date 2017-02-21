public class BusinessLogic {
	
	public int GetValueIndex(Model model) {
		return model.GetValues().Where(v => !string.IsNullOrEmpty(v)).Select(v => v.Key).Max();
	}
}