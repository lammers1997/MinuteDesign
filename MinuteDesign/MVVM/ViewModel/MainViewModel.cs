using MinuteDesign.Core;

namespace MinuteDesign.MVVM.ViewModel
{
    class MainViewModel : ObservableObject
    {

        public RelayCommand HomeViewCommand { get; set; }
        public RelayCommand WallBeamViewCommand{ get; set; }
        public RelayCommand FreeBodyDiagramViewCommand { get; set; }
        public HomeViewModel HomeVM { get; set; }
        public WallBeamViewModel WallBeamVM{ get; set; }
        public FreeBodyDiagramViewModel FreeBodyDiagramVM { get; set; }

        private object _currentView;

        public object CurrentView
        {
            get { return _currentView; }
            set { _currentView = value;
                OnPropertyChanged();
            }
        }

        public MainViewModel()
        {


            HomeVM = new HomeViewModel();
            WallBeamVM = new WallBeamViewModel();
            FreeBodyDiagramVM = new FreeBodyDiagramViewModel();

            CurrentView = HomeVM;

            HomeViewCommand = new RelayCommand(o =>
            {
                CurrentView = HomeVM;
            });

            WallBeamViewCommand= new RelayCommand(o =>
            {
                CurrentView = WallBeamVM;
            });
            FreeBodyDiagramViewCommand = new RelayCommand(o =>
            {
                CurrentView = FreeBodyDiagramVM;
            });
        }
    }
}
