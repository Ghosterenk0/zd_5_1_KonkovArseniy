using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace zd5_1_KonkovArseniy
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage :TabbedPage
    {
        public MainPage()
        {
            InitializeComponent();
            currentDatePicker.Date = DateTime.Now;
            rateSlider.ValueChanged += (s, e) =>
            {
                rateLabel.Text = $"{e.NewValue:F1}%";
            };

            this.BindingContext = Application.Current;
        }

        private void OnCalculateClicked(object sender, EventArgs e)
        {
            if (double.TryParse(amountEntry.Text, out double amount) &&
                int.TryParse(termEntry.Text, out int term) &&
                term > 0 && amount > 0)
            {
                double rate = rateSlider.Value / 100;
                string paymentType = paymentTypePicker.SelectedItem?.ToString();

                if (string.IsNullOrEmpty(paymentType))
                {
                    DisplayAlert("Ошибка", "Выберите тип платежа", "OK");
                    return;
                }

                if (paymentType == "Аннуитетный")
                {
                    double monthlyRate = rate / 12;
                    double coefficient = (monthlyRate * Math.Pow(1 + monthlyRate, term)) /
                                      (Math.Pow(1 + monthlyRate, term) - 1);
                    double monthlyPayment = amount * coefficient;

                    monthlyPaymentLabel.Text = $"{monthlyPayment:C2}";
                    double totalPayment = monthlyPayment * term;
                    totalPaymentLabel.Text = $"{totalPayment:C2}";
                    overpaymentLabel.Text = $"{(totalPayment - amount):C2}";
                }
                else
                {
                    double principal = amount / term;
                    double totalPayment = 0;

                    for (int i = 0; i < term; i++)
                    {
                        double remaining = amount - (principal * i);
                        double interest = remaining * rate / 12;
                        totalPayment += principal + interest;
                    }

                    monthlyPaymentLabel.Text = "переменный";
                    totalPaymentLabel.Text = $"{totalPayment:C2}";
                    overpaymentLabel.Text = $"{(totalPayment - amount):C2}";
                }

                resultFrame.IsVisible = true;
            }
            else
            {
                DisplayAlert("Ошибка", "Проверьте введенные данные:\n- Сумма > 0\n- Срок > 0", "OK");
            }
        }
    }
}