using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Test__API;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Test_API
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class user_page : ContentPage
    {
        public user_page()
        {
            InitializeComponent();
            GetUserData();
        }

        private async void GetUserData()
        {
            HttpClient client = new HttpClient();

            var response = await client.GetStringAsync("https://jsonplaceholder.typicode.com/todos");

            var users = JsonConvert.DeserializeObject<List<UserData>>(response);

            UserDataListView.ItemsSource = users;
        }

        //protected override async void OnAppearing()
        //{
        //    base.OnAppearing();

        //    UserDataListView.ItemsSource = await App.Database.GetNotesAsync;
        //}
    }
}