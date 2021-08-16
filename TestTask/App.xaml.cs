using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Windows;
using TestTask.Models;
using TestTask.ViewModels;
using TinyIoC;

namespace TestTask
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private static TinyIoCContainer _container;
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            // создаем контейнер внедрения зависимостей
            _container = new TinyIoCContainer();
            _container.Register<ISourceData, SourceData>();
            _container.Register<IDataModel, DataModel>();

            var viewModel = _container.Resolve<MainViewModel>();

            // теперь можно показывать главное окно
            var mainWindow = new MainWindow() { DataContext = viewModel };
            
            mainWindow.Show();
        }
    }
}
