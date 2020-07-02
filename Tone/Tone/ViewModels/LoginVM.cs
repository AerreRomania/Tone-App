using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Tone.Views;
using Xamarin.Forms;

namespace Tone.ViewModels
{
   public class LoginVM
    {
        public ICommand LoginCommand { get; set; }
        public ICommand RegisterCommand { get; set; }
        public LoginVM()
        {
            LoginCommand = new Command(() => LoginTask());
            RegisterCommand = new Command(()=>RegisterNav());

        }
        public void RegisterNav()
        {
            Application.Current.MainPage.Navigation.PushModalAsync(new RegisterView());
        }
        public void LoginTask()
        {
            var tabbedPage = Application.Current.MainPage as TabbedPage;
            tabbedPage.Children.RemoveAt(3);
            tabbedPage.Children.Add(new AccountDetailsView());
            tabbedPage.CurrentPage = tabbedPage.Children[3];
        }
    }
}
