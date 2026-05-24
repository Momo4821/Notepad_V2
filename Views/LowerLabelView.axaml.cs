using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Notepad_V2.Models;
using Notepad_V2.ViewModels;

namespace Notepad_V2.Views;

public partial class LowerLabelView : UserControl
{
    public LowerLabelView()
    {
        InitializeComponent();
        var model = new LowerLabelsModel();
        DataContext = new LowerLabelViewModel(model);
    }
}