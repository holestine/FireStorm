using System.Windows.Controls;
using FireStorm.PdfServiceReference;

namespace FireStorm
{
    public partial class MainPage : UserControl
    {
        public MainPage()
        {
            InitializeComponent();
            var client = new PdfServiceClient();

            client.TestCompleted += TestCompleted;
            
            //client.TestAsync(true);
        }

        private void TestCompleted(object sender, TestCompletedEventArgs e)
        {
           
        }
    }
}
