﻿using SensorAnalogico.App.ViewModels;

namespace SensorAnalogico.App
{
    public static class ResourcePages
    {

        public enum PageName
        {
            MainView,
            Component,
            AnalogicInput,
            ConfigurationAnalogicInput,
            SensorClimatico
        }

        public static ViewModelBase GetPage(PageName pageName)
        {
            ViewModelBase? model = null;
            switch (pageName)
            {
                case PageName.MainView:
                    model = new MainViewModel();
                    break;
                case PageName.Component:
                    model = new ComponentViewModel();
                    break;
                case PageName.AnalogicInput:
                    model = new AnalogicInViewModel();
                    break;
                case PageName.ConfigurationAnalogicInput:
                    model = new AnalogicInConfigViewModel();
                    break;
                case PageName.SensorClimatico:
                    model = new SensorClimaticoViewModel();
                    break;
            }
            return model??new ViewModelBase();
        }

    }
}
