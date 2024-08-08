using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace MinuteDesign.MVVM.Model
{
    public class BeamSupportModel
    {
        public string SupportType { get; set; }

        public double LocationFromLeft { get; set; }

        public int SelectedImagePath { get; set; }

        public string ImagePath
        {
            get
            {
                switch (SelectedImagePath)
                {
                    case 0:
                        return @"C:\Sources\MinuteDesign\Images\pinned_support.png";
                    case 1:
                        return @"C:\Sources\MinuteDesign\Images\rolling_support.png";
                    case 2:
                        return @"C:\Sources\MinuteDesign\Images\fixed_support.png";
                    default:
                        return "unknown";
                }
            }
            set { }
            
        }

        public string AllInfo
        {
            get
            {
                return $"{ SupportType} {LocationFromLeft} {SelectedImagePath}";
            }
        }

    }
}
