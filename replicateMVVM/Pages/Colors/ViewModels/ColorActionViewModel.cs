using Microsoft.AspNetCore.Components;
using replicateMVVM.Pages.Colors.Models;

namespace replicateMVVM.Pages.Colors.ViewModels
{
	public class ColorActionViewModel
	{

		private readonly NavigationManager _navigationManager;
		private readonly ColorFormViewModel _colorFormViewModel;
		private readonly ColorListViewModel _colorListViewModel;

		public ColorActionViewModel(NavigationManager navigationManager, ColorFormViewModel colorFormViewModel, ColorListViewModel colorListViewModel)
		{
			_navigationManager = navigationManager;
			_colorFormViewModel = colorFormViewModel;
			_colorListViewModel = colorListViewModel;
		}

		public void CreateColor()
		{
			_colorFormViewModel.IsUpdate = false;

			_colorFormViewModel.Colour = new Colour
			{
				Name = string.Empty,
				HexCode = string.Empty,
                HexCode2 = string.Empty,
                HexCode3 = string.Empty

            };

			_navigationManager.NavigateTo("/colours/create");
		}

		public void UpdateColor(Colour colour)
		{
			_colorFormViewModel.IsUpdate = true;
			_colorFormViewModel.Colour = colour;
			_navigationManager.NavigateTo("/colours/update");
		}
	}
}
