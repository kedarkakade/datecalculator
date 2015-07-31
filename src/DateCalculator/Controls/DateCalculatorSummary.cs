using System.Windows.Forms;
using DateCalculator.Lib;

namespace DateCalculator.UI.Controls
{
    public partial class DateCalculatorSummary : UserControl
    {
        public DateSpan Results { get; set; }

        public DateCalculatorSummary()
        {
            InitializeComponent();
        }

        public void Bind()
        {
            YearsLabel.Text = Results.Years.ToString();
            MonthsLabel.Text = Results.Months.ToString();
            DaysLabel.Text = Results.Days.ToString();
        }

        public void Reset()
        {
            YearsLabel.Text = MonthsLabel.Text = DaysLabel.Text = string.Empty;
        }

        private void DateCalculatorSummary_Load(object sender, System.EventArgs e)
        {
            YearsLabel.Text = MonthsLabel.Text = DaysLabel.Text = string.Empty;
        }
    }
}
