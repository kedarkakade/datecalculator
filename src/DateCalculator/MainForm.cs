using System;
using System.Windows.Forms;
using DateCalculator.Lib;

namespace DateCalculator.UI
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            var firstInput = FirstDate.Value > SecondDate.Value ? SecondDate.Value : FirstDate.Value;
            var secondInput = FirstDate.Value > SecondDate.Value ? FirstDate.Value : SecondDate.Value;

            var difference = Calculator.CalculateDifference(firstInput, secondInput);

            ResultSummary.Results = difference;
            ResultSummary.Bind();
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            FirstDate.Value = SecondDate.Value = DateTime.Now;
            ResultSummary.Reset();
        }

        private void Reset2Button_Click(object sender, EventArgs e)
        {
            FromDate.Value = DateTime.Today;
            Years.Value = Months.Value = Days.Value = 0;
            Add.Checked = true;
        }

        private void Calculate2Button_Click(object sender, EventArgs e)
        {
            var fromDate = FromDate.Value;

            var function = Add.Checked ? DateFunction.Add : DateFunction.Subtract;

            var dateSpan = new DateSpan
                               {
                                   Years = Convert.ToInt32(Years.Value),
                                   Months = Convert.ToInt32(Months.Value),
                                   Days = Convert.ToInt32(Days.Value)
                               };
            var result = Calculator.GetModifiedDate(fromDate, function, dateSpan);

            ResultedDate.Text = result.ToLongDateString();
        }
    }
}