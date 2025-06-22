using Xamarin.Forms;

namespace zd5_1_KonkovArseniy
{
    public partial class App :Application
    {
        public static string CurrentUser { get; set; }

        public App()
        {
            InitializeComponent();
            MainPage = new NavigationPage(new LoginPage());
        }

        protected override void OnStart() { }
        protected override void OnSleep() { }
        protected override void OnResume() { }
    }
}