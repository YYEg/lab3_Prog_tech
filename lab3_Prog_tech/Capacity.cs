using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3_Prog_tech
{
    public enum MeasureType { ml, m3, l, brrl};
    public class Capacity
    {
        private double value;
        private MeasureType type;

        public Capacity(double value, MeasureType type)
        {
            this.value = value;
            this.type = type;
        }

        public string Verbose()
        {
            string typeVerbose = "";
            switch (this.type)
            {
                case MeasureType.m3:
                    typeVerbose = "м.куб.";
                    break;
                case MeasureType.ml:
                    typeVerbose = "мл.";
                    break;
                case MeasureType.l:
                    typeVerbose = "л.";
                    break;
                case MeasureType.brrl:
                    typeVerbose = "баррель";
                    break;
            }
            return String.Format("{0} {1}", this.value, typeVerbose);
        }
        public static Capacity operator+(Capacity instance, double number)
        {
            var newValue = instance.value + number;
            var lenght = new Capacity(newValue, instance.type);
            return lenght;
        }
        public static Capacity operator+(double number, Capacity instance)
        {
            return instance + number;
        }
        public static Capacity operator-(Capacity instance, double number)
        {
            var newValue = instance.value - number;
            var lenght = new Capacity(newValue, instance.type);
            return lenght;
        }
        public static Capacity operator -(double number, Capacity instance)
        {
            return instance - number;
        }
        public static Capacity operator *(Capacity instance, double number)
        {
            var newValue = instance.value * number;
            var lenght = new Capacity(newValue, instance.type);
            return lenght;
        }
        public static Capacity operator *(double number, Capacity instance)
        {
            return instance * number;
        }
        public Capacity To(MeasureType newType)
        {
            var newValue = this.value;
            if(this.type == MeasureType.ml)
            {
                switch(newType)
                {
                    case MeasureType.ml:
                        newValue = this.value;
                        break;
                    case MeasureType.m3:
                        newValue = this.value / 1000000;
                        break;
                    case MeasureType.l:
                        newValue = this.value / 1000;
                        break;
                    case MeasureType.brrl:
                        newValue = this.value / (6.28981 * Math.Pow(10, 6));
                        break;
                }
            }
            else if(newType == MeasureType.ml)
            {
                switch(this.type)
                {
                    case MeasureType.ml:
                        newValue = this.value;
                        break;
                    case MeasureType.m3:
                        newValue = this.value * 1000000;
                        break;
                    case MeasureType.l:
                        newValue = this.value * 1000;
                        break;
                    case MeasureType.brrl:
                        newValue = this.value * (6.28981 * Math.Pow(10, 6));
                        break;
                }
            }
            else
            {
                newValue = this.To(MeasureType.ml).To(newType).value;
            }
            return new Capacity(newValue, newType);
        }
        public static Capacity operator +(Capacity instance1, Capacity instance2)
        {
            return instance1 + instance2.To(instance1.type).value;
        }

        public static Capacity operator -(Capacity instance1, Capacity instance2)
        {
            return instance1 - instance2.To(instance1.type).value;
        }
    }
}