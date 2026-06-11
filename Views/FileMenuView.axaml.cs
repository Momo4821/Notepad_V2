using System.ComponentModel.DataAnnotations;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Notepad_V2.Models;
using Notepad_V2.ViewModels;

namespace Notepad_V2.Views;

public partial class FileMenuView : UserControl
{
    
    public LowerLabelsModel LowerLabels { get; set; }
    public FileMenuModel  FileMenu { get; set; }
    public FileMenuView()
    {
        InitializeComponent();
        DataContext = new FileMenuViewModel(FileMenu) ;
        
        
    }
}