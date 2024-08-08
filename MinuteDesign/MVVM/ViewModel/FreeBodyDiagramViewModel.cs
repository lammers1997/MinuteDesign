using MinuteDesign.Core;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;
using MinuteDesign.MVVM.Model;
using System.Text;
using System.Linq;

namespace MinuteDesign.MVVM.ViewModel
{
    class FreeBodyDiagramViewModel : ObservableObject
    {


        private int _lengthTextBox = 5000;
        public ObservableCollection<BeamSupportModel> BeamSupportModels { get; set; }
        public BeamModel Beam { get; set; }


        public FreeBodyDiagramViewModel()
        {
            BeamSupportModels = new ObservableCollection<BeamSupportModel>();
            Beam = new BeamModel();
            Beam.Length = _lengthTextBox;


        }


        public RelayCommand AddSupportCommand => new RelayCommand(execute => AddSupport(), canExecute => CanAddSupport());

        public int LengthTextBox
        {
            get { return _lengthTextBox; }
            set { _lengthTextBox = value;
                OnPropertyChanged("LengthTextBox");
                Beam.Length = _lengthTextBox;
            }
        }

        public bool CanAddSupport()
        {
            if(_lengthTextBox > 0)
            {
                return true;
            }
            else 
            {
                return false;
            }
            return true;
        }
        public void AddSupport()
        {
            BeamSupportModel support1 = new BeamSupportModel();
            OnPropertyChanged("BeamSupportModels");
            BeamSupportModels.Add(support1);
            Beam.supports = BeamSupportModels.ToList<BeamSupportModel>();

        }
        public void drawSupport()
        {


            //MessageBox.Show("drawSupport");
            
        }
    }
}
