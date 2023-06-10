using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatoRichTextEditor.ViewModels
{
    public class RichTextEditorSamplePageViewModel : ObservableObject
    {
        public RichTextEditorSamplePageViewModel()
        {
            this.Content="";
            this.PlaceHolder="你可以在这写一封信";

        }

        private string _content;

        public string Content
        {
            get { return _content; }
            set
            {
                _content = value;
                OnPropertyChanged();
            }
        }

        private string _placeHolder;

        public string PlaceHolder
        {
            get { return _placeHolder; }
            set
            {
                _placeHolder = value;
                OnPropertyChanged();
            }
        }

        private string _htmlContent;

        public string HtmlContent
        {
            get { return _htmlContent; }
            set
            {
                _htmlContent = value;
                OnPropertyChanged();
            }
        }

    }
}
