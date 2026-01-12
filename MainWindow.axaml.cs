using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Platform.Storage;

namespace Notepad_V2;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }
    
    //public downloads folder
    public static DirectoryInfo downloadsFolder = new DirectoryInfo(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\Downloads");
 
    
    //Delclare a delegate for the open file operation
    
    public delegate void OpenFileDelegate_eventhandler(IStorageFile file);
    
    
    //Create an event based on the delegate
    public event OpenFileDelegate_eventhandler OnOpenFileEvent;
    
    
    

    
  

    
}