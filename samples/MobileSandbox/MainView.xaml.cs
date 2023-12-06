using System;
using System.Windows.Input;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace MobileSandbox
{
    public class MainView : UserControl
    {
        public MainView()
        {
            AvaloniaXamlLoader.Load(this);

            DataContext = this;
        }

        public void ButtonCommand()
        {
            if(TopLevel.GetTopLevel(this) is Window window)
            {
                var size = window.ClientSize;
                window.MoveResize(window.Position, size.Inflate(new Avalonia.Thickness(1, 0)));
            }
        }
    }
}
