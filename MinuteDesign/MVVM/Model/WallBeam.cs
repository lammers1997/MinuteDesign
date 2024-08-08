using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using MinuteDesign.MVVM.ViewModel;

namespace MinuteDesign.MVVM.Model
{
    class WallBeam
    {
        public int Width { get; set; }

        public int Length { get; set; }

        public int Height { get; set; }

        public int Loading { get; set; }
        public WallBeam()
        {
           
        }
        private double loadingMoment(int loading, int length)
        {
            double moment = (loading * length * length) / 8;
            return moment;
        }
        private double torqueArm(int length, int height)
        {
            double torqueArm = 0.6 * height;
            return torqueArm;
        }
        private double steelNormalForce(double moment, double torqueArm)
        {
            double N = moment / torqueArm;
            return N;
        }
        private double requiredAreaOfSteel(double N, double f_yd)
        {
            return N / f_yd;
        }

        public double calculate(int width, int length, int height, int loading)
        {
            Width = width;
            Length = length;
            Height = height;
            Loading = loading;
            double M = loadingMoment(loading, length);
            double tArm = torqueArm(length, height);
            double sNF = steelNormalForce(M, 435);
            double A_s = requiredAreaOfSteel(sNF, 435);
            return A_s;
        }
    }
}
