using System;
using System.Windows;
using WeatherApp.Model;
using WeatherApp.ViewModel;

namespace WeatherApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Root index = IndexViewModel.IndexViewMod();
            Rootobject dailyForeCast = DailyForecastViewModel.DailyForecastViewMod(index);

            City.DataContext = index.Properties.RelativeLocation.Properties1;
            State.DataContext = index.Properties.RelativeLocation.Properties1;

            Box1.DataContext = dailyForeCast.Properties.Periods[0];
            Box2.DataContext = dailyForeCast.Properties.Periods[1];
            Box3.DataContext = dailyForeCast.Properties.Periods[2];
            Box4.DataContext = dailyForeCast.Properties.Periods[3];
            Box5.DataContext = dailyForeCast.Properties.Periods[4];
            Box6.DataContext = dailyForeCast.Properties.Periods[5];
            Box7.DataContext = dailyForeCast.Properties.Periods[6];
            Box8.DataContext = dailyForeCast.Properties.Periods[7];


            Nextforecast.DataContext = dailyForeCast.Properties.Periods[0];
            NFDetail.DataContext = dailyForeCast.Properties.Periods[0];
            NextforecastTemp.DataContext = dailyForeCast.Properties.Periods[0];

            Nextforecastb.DataContext = dailyForeCast.Properties.Periods[1];
            NFDetailb.DataContext = dailyForeCast.Properties.Periods[1];
            NextforecastTempb.DataContext = dailyForeCast.Properties.Periods[1];

            Forecast1.DataContext = dailyForeCast.Properties.Periods[2];
            FDetail1.DataContext = dailyForeCast.Properties.Periods[2];
            ForecastTemp1.DataContext = dailyForeCast.Properties.Periods[2];

            Forecast1b.DataContext = dailyForeCast.Properties.Periods[3];
            FDetail1b.DataContext = dailyForeCast.Properties.Periods[3];
            ForecastTemp1b.DataContext = dailyForeCast.Properties.Periods[3];

            Forecast2.DataContext = dailyForeCast.Properties.Periods[4];
            FDetail2.DataContext = dailyForeCast.Properties.Periods[4];
            ForecastTemp2.DataContext = dailyForeCast.Properties.Periods[4];

            Forecast2b.DataContext = dailyForeCast.Properties.Periods[5];
            FDetail2b.DataContext = dailyForeCast.Properties.Periods[5];
            ForecastTemp2b.DataContext = dailyForeCast.Properties.Periods[5];

            Forecast3.DataContext = dailyForeCast.Properties.Periods[6];
            FDetail3.DataContext = dailyForeCast.Properties.Periods[6];
            ForecastTemp3.DataContext = dailyForeCast.Properties.Periods[6];

            Forecast3b.DataContext = dailyForeCast.Properties.Periods[7];
            FDetail3b.DataContext = dailyForeCast.Properties.Periods[7];
            ForecastTemp3b.DataContext = dailyForeCast.Properties.Periods[7];
        }
    }
}
