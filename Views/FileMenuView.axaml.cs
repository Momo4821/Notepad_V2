using System.ComponentModel.DataAnnotations;
using System.Linq;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Input.TextInput;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;
using CommunityToolkit.Mvvm.Input;
using Notepad_V2.Models;
using Notepad_V2.ViewModels;

namespace Notepad_V2.Views;

public partial class FileMenuView : UserControl
{

 
    
    public FileMenuView()
    {

        var model = new FileModel();
        DataContext = new FileMenuViewModel(model, this);
        
        InitializeComponent();
        
        
        
    }
    
    
    


  
}

