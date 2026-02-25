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
using Notepad_V2.ViewModels;

namespace Notepad_V2;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
        FileMenuViewModel fileMenuViewModel = new FileMenuViewModel();
        DataContext = fileMenuViewModel; // Intialize the filemenu view model anytime the main view model is active

    }
    
    
    }
    


//mvm

//model 