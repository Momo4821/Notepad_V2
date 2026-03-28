using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Notepad_V2.ViewModels;

namespace Notepad_V2.Views;

public partial class FileMenuView : UserControl
{
    public FileMenuView()
    {
        DataContext = new FileMenuViewModel();
        InitializeComponent();
        
    }
}