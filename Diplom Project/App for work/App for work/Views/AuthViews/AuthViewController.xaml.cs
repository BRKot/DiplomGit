

using App_for_work.Views.AuthViews;

namespace App_for_work;

public partial class AuthViewController : ContentPage
{
	public AuthViewController()
	{
		InitializeComponent();

        Grid grid = new Grid();

        TapGestureRecognizer tapGesture = new TapGestureRecognizer
        {
            NumberOfTapsRequired = 2
        };


        tapGesture.Tapped += (s, e) =>
        {
            TapSignUpLabel();
        };
        signUpLabel.GestureRecognizers.Add(tapGesture);
    }

    public void TapSignUpLabel()
    {
        var secondPage = new SignUpViewController(); // Создание экземпляра второго View
        Application.Current.MainPage = new NavigationPage(secondPage); // Установка второго View в качестве главной страницы
    }

}