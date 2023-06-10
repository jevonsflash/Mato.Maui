using MatoRichTextEditor.ViewModels;

namespace MatoRichTextEditor;

public partial class MainPage : ContentPage
{
    int count = 0;

    public MainPage()
    {
        InitializeComponent();
        this.BindingContext=new MainPageViewModel();

    }

}


