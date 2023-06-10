using MatoRichTextEditor.ViewModels;

namespace MatoRichTextEditor.Views;

public partial class RichTextEditorSamplePage : ContentPage
{
    public RichTextEditorSamplePage()
    {
        InitializeComponent();
        this.BindingContext=new RichTextEditorSamplePageViewModel();
    }
}