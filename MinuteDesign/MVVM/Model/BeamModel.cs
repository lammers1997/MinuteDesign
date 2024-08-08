using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace MinuteDesign.MVVM.Model
{
    public class BeamModel
    {
        public int Length { get; set; }

        public List<BeamSupportModel> supports { get; set; }

        public string Material { get; set; }
        
        public double Forces { get; set; }

    }
}
