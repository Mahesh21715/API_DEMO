using System;
using System.IO;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Test__API
{
    public partial class App : Application
    {
        static NoteDatabase database;

        //private static NoteDatabase Database
        //{
        //    get
        //    {
        //        if (database == null)
        //        {
        //            database = new NoteDatabase(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Notes.db3"));
        //        }
        //        return database;
        //    }
        //}

        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new LoginPage());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
