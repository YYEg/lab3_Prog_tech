using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab3_Prog_tech
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            var measureItems = new string[]
            {
                "мл.",
                "л.",
                "м.куб.",
                "баррель",
            };

            // привязываем списки значений к каждому комбобоксу
            cmbFirstType.DataSource = new List<string>(measureItems);
            cmbSecondType.DataSource = new List<string>(measureItems);
            cmbResultType.DataSource = new List<string>(measureItems);
        }
        private MeasureType GetMeasureType(ComboBox comboBox)
        {
            MeasureType measureType;
            switch (comboBox.Text)
            {
                case "мл.":
                    measureType = MeasureType.ml;
                    break;
                case "м.куб.":
                    measureType = MeasureType.m3;
                    break;
                case "л.":
                    measureType = MeasureType.l;
                    break;
                case "баррель":
                    measureType = MeasureType.brrl;
                    break;
                default:
                    measureType = MeasureType.ml;
                    break;
            }
            return measureType;
        }
        private void Calculate()
        {
            try
            {
                var firstCapcity = double.Parse(txtFirst.Text);
                var secondCapacity = double.Parse(txtSecond.Text);
                MeasureType firstType = GetMeasureType(cmbFirstType);
                MeasureType secondType = GetMeasureType(cmbSecondType);
                MeasureType resultType = GetMeasureType(cmbResultType);
                var firstCapasity = new Capacity(firstCapcity, firstType);
                var secondCapcity = new Capacity(secondCapacity, secondType);
                Capacity sumCapacity;
                switch(cmbOperation.Text)
                {
                    case "+":
                        sumCapacity = firstCapasity + secondCapcity;
                        break;
                    case "-":
                        sumCapacity = firstCapasity - secondCapcity;
                        break;
                    default:
                        sumCapacity = new Capacity(0, MeasureType.ml);
                        break;
                }
                txtResult.Text = sumCapacity.To(resultType).Verbose();
            }

            catch (FormatException)
            {

            }
        }
        private void cmbOperation_SelectedIndexChanged(object sender, EventArgs e)
        {
            Calculate();
        }
        private void onValueChanged(object sender, EventArgs e)
        {
            Calculate();
        }
    }
}
