using Microsoft.Phone.Controls;

namespace WindowsPhoneObliqueStrategies
{
    public partial class MainPage : PhoneApplicationPage
    {
        public MainPage()
        {
            InitializeComponent();
            SetRandomStrategy();
        }


        private void SetRandomStrategy()
        {
            const string titleFormat = "#{0}";
            var strategy = Strategy.Random();

            PageTitle.Text = string.Format(titleFormat, strategy.Number.ToString());
            StrategyText.Text = strategy.Text;
        }


        private void MainPage_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            SetRandomStrategy();
        }
    }
}