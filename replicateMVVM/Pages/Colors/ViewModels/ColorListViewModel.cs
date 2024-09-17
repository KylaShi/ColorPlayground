using System.Collections.ObjectModel;
using replicateMVVM.Pages.Colors.Models;

namespace replicateMVVM.Pages.Colors.ViewModels
{
	public class ColorListViewModel
	{
		public ColorListViewModel()
		{
			Initialize();
		}

		public ObservableCollection<Colour> Colours { get; set; } = new ObservableCollection<Colour>();
		public void Initialize()
		{
			Random random = new Random();
			for (int i=0; i<5; i++)
			{
				Colours.Add(new Colour
				{
					Name =$"Palette {i + 1}",
					HexCode =GenerateRandomHexCode(random),
                    HexCode2 = GenerateRandomHexCode(random),
                    HexCode3 =  GenerateRandomHexCode(random)
                });
			}

			Colours.Add(new Colour
			{
				Name = "Palette 6",
				HexCode = "#000000",
				HexCode2 = "#FFFFFF",
				HexCode3 = "#808080"

			});

		}

        private string GenerateRandomHexCode(Random random)
        {
            const string hexChars = "0123456789ABCDEF";
            char[] hexCode = new char[6];
            for (int i = 0; i < hexCode.Length; i++)
            {
                hexCode[i] = hexChars[random.Next(hexChars.Length)];
            }
            return $"#{new string(hexCode)}";
        }
    }
}
