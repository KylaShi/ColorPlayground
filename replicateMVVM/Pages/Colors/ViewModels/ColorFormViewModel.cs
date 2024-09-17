using replicateMVVM.Pages.Colors.Models;

namespace replicateMVVM.Pages.Colors.ViewModels
{
	public class ColorFormViewModel
	{

		private readonly ColorListViewModel _colorListViewModel;

		public ColorFormViewModel(ColorListViewModel colorListViewModel)
		{
			_colorListViewModel = colorListViewModel;
		}

		public Colour Colour { get; set; }
		public bool IsUpdate { get; set; }

		public void SaveColour()
		{
			if (IsUpdate)
			{
				var index = _colorListViewModel.Colours.IndexOf(Colour);
				_colorListViewModel.Colours[index] = Colour;

			}
			else
			{
				_colorListViewModel.Colours.Add(Colour);
			}

		}
	
	}
}
