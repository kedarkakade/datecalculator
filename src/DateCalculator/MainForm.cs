using System;
using System.Windows.Forms;
using DateCalculator.Lib;

namespace DateCalculator.UI
{
    public partial class MainForm : Form
    {
        private const string CalculateAgeOrExperienceTab = "DifferenceTab";
        private const string AddSubtractDateTab = "AddSubtractDate";

        public MainForm()
        {
            InitializeComponent();
        }

        private void CalculateButtonClick(object sender, EventArgs e)
        {
            CalculateAgeOrExperience();
        }

        private void CalculateAgeOrExperience()
        {
            var firstInput = FirstDate.Value > SecondDate.Value ? SecondDate.Value : FirstDate.Value;
            var secondInput = FirstDate.Value > SecondDate.Value ? FirstDate.Value : SecondDate.Value;

            var difference = Calculator.CalculateDifference(firstInput, secondInput);

            ResultSummary.Results = difference;
            ResultSummary.Bind();
        }

        private void ResetButtonClick(object sender, EventArgs e)
        {
            ResetAgeOrExperienceInputsAndOutputs();
        }

        private void ResetAgeOrExperienceInputsAndOutputs()
        {
            FirstDate.Value = SecondDate.Value = DateTime.Now;
            ResultSummary.Reset();
        }

        private void Reset2ButtonClick(object sender, EventArgs e)
        {
            ResetAddSubtractDateInputsAndOutputs();
        }

        private void ResetAddSubtractDateInputsAndOutputs()
        {
            FromDate.Value = DateTime.Today;
            Years.Value = Months.Value = Days.Value = 0;
            Add.Checked = true;
            ResultedDate.Clear();
        }

        private void Calculate2ButtonClick(object sender, EventArgs e)
        {
            CalculateResultsForAddOrSubtractDate();
        }

        private void CalculateResultsForAddOrSubtractDate()
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

        private void ExitMenuClick(object sender, EventArgs e)
        {
            Close();
            Application.Exit();
        }

        private void ResetMenuClick(object sender, EventArgs e)
        {
            switch (ApplicationTabs.SelectedTab.Name)
            {
                case CalculateAgeOrExperienceTab:
                    ResetAgeOrExperienceInputsAndOutputs();
                    break;

                case AddSubtractDateTab:
                    ResetAddSubtractDateInputsAndOutputs();
                    break;
            }
        }

        private void CalculateMenuClick(object sender, EventArgs e)
        {
            switch (ApplicationTabs.SelectedTab.Name)
            {
                case CalculateAgeOrExperienceTab:
                    CalculateAgeOrExperience();
                    break;

                case AddSubtractDateTab:
                    CalculateResultsForAddOrSubtractDate();
                    break;
            }
        }

        private void AboutMenuClick(object sender, EventArgs e)
        {
            var aboutForm = new AboutDateCalculator();
            aboutForm.Show(this);
        }
    }
}