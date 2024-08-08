using MinuteDesign.Core;
using MinuteDesign.MVVM.Model;
using System.Windows;

namespace MinuteDesign.MVVM.ViewModel
{
	class WallBeamViewModel : ObservableObject
    {
		private int _wallWidth;
		private int _wallHeight;
		private int _wallLength;
		private int _wallLoading;
		private double _A_SRequired;

		public RelayCommand CalculateCommand => new RelayCommand(execute => Calculate(), canExecute => CanCalculate());

		public double A_SRequired
		{
			get { return _A_SRequired; }
			set { _A_SRequired = value; OnPropertyChanged("A_SRequired"); }
		}

		public int WallWidth
		{
			get { return _wallWidth; }
			set { _wallWidth = value; OnPropertyChanged("WallWidth");
			}
		}
		public int WallHeight
		{
			get { return _wallHeight; }
			set
			{
				_wallHeight = value; OnPropertyChanged("WallHeight");
			}
		}
		public int WallLength
		{
			get { return _wallLength; }
			set
			{
				_wallLength = value; OnPropertyChanged("WallLength");
			}
		}
		public int WallLoading
		{
			get { return _wallLoading; }
			set
			{
				_wallLoading = value; OnPropertyChanged("WallLoading");
			}
		}
		//Constructor
		public WallBeamViewModel()
		{
		}

		private bool CanCalculate()
		{
			//Check if values are given at every textbox. Also make sure they are positive integers
			return true;
		}
		private void Calculate()
		{
			WallBeam wBeam = new WallBeam();
			_A_SRequired = wBeam.calculate(_wallWidth, _wallLength, _wallHeight, _wallLoading);
			OnPropertyChanged("A_SRequired");
		} 

	}
}
