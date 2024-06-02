namespace DiplomPRoject;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();

        LoadMap();
	}


    private void LoadMap()
    {
        // Загрузка HTML-кода с картой Яндекса
        string html = @"
                <!DOCTYPE html>
                <html>
                <head>
                    <meta name='viewport' content='initial-scale=1.0, user-scalable=no'>
                    <meta charset='utf-8'>
                    <style>
                        /* Установите размеры контейнера карты */
                        #map {
                            height: 100%;
                        }
                        html, body {
                            height: 100%;
                            margin: 0;
                            padding: 0;
                        }
                    </style>
                    <script src='https://api-maps.yandex.ru/2.1/?apikey=a6da2898-c703-4e40-a1bd-440682600465'></script>
                    <script>
                        ymaps.ready(init);
                        function init(){
                            var myMap = new ymaps.Map('map', {
                                center: [55.753215, 37.622504], // Координаты центра карты
                                zoom: 9 // Уровень масштабирования
                            });
                        }
                    </script>
                </head>
                <body>
                    <!-- Контейнер, в котором будет отображаться карта -->
                    <div id='map'></div>
                </body>
                </html>";

        string html2 = "<!DOCTYPE html>\r\n<html xmlns=\"http://www.w3.org/1999/xhtml\">\r\n<head>\r\n    <title>Быстрый старт. Размещение интерактивной карты на странице</title>\r\n    <meta http-equiv=\"Content-Type\" content=\"text/html; charset=utf-8\" />\r\n    <script src=\"https://api-maps.yandex.ru/2.1/?apikey=a6da2898-c703-4e40-a1bd-440682600465&lang=ru_RU\" type=\"text/javascript\">\r\n    </script>\r\n    <script type=\"text/javascript\">\r\n        ymaps.ready(init);\r\n        function init(){\r\n            var myMap = new ymaps.Map(\"map\", {\r\n                center: [55.76, 37.64],\r\n                zoom: 7\r\n            });\r\n        }\r\n    </script>\r\n</head>\r\n\r\n<body>\r\n    <div id=\"map\" style=\"width: 600px; height: 400px\"></div>\r\n</body>\r\n\r\n</html>";

        webViewMap.Source = new HtmlWebViewSource { Html = html2 };
    }

    //private void LoginButton_Clicked(object sender, EventArgs e)
    //{
    //       count++;
    //}

    //   private void RegisterButton_Clicked(object sender, EventArgs e)
    //   {

    //   }

    //   private void EmergencyButton_Clicked(object sender, EventArgs e)
    //   {

    //   }

    //   private void RegisterLabel_Tapped(object sender, EventArgs e)
    //   {

    //   }
}

