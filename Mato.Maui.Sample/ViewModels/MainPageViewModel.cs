using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatoRichTextEditor.ViewModels
{
    public class MainPageViewModel : ObservableObject
    {
        public MainPageViewModel()
        {
            NavigateCommand = new Command<Type>(
  async (Type pageType) =>
  {
      Page page = (Page)Activator.CreateInstance(pageType);
      await App.Current.MainPage.Navigation.PushAsync(page);
  });
        }

        public Command<Type> NavigateCommand { get; set; }
    }
}
