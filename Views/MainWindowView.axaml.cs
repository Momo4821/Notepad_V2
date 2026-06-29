using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows.Input;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Platform.Storage;
using Notepad_V2.Models;
using Notepad_V2.ViewModels;
using Notepad_V2.Views;

namespace Notepad_V2;



public partial class MainWindowView : Window
{


    
    
    public MainWindowView()
    {
      
        this.Width = 800;
        this.Height = 450;
   
        
        InitializeComponent();
        DataContext = new MainWindowViewModel(this);
        
        

    }

    
  
  
}
    

  