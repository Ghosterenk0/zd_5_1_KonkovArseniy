using Xamarin.Forms;

namespace zd5_1_KonkovArseniy
{
    public partial class LoginPage :ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void OnLoginClicked(object sender, System.EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(usernameEntry.Text))
            {
                DisplayAlert("Ошибка", "Введите логин", "OK");
                return;
            }

            App.CurrentUser = usernameEntry.Text;
            Application.Current.MainPage = new MainPage();
        }
    }
}