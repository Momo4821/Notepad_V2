using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Runtime.CompilerServices;
using Avalonia.Controls;
using CommunityToolkit.Mvvm.ComponentModel;
using Microsoft.VisualBasic;
using Tmds.DBus.Protocol;

namespace Notepad_V2.Models; 

public partial class FileMenuModel : ObservableObject
{
    //Textbox
    
    [ObservableProperty]
    private string content;
    
    
   [ObservableProperty]
   private string filepath;
  
   
    
    
    
    public string Filename => Path.GetFileName(Filepath);
    
    public string Filetype => Path.GetExtension(Filepath);
    
    public string Downloads => Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + @"\Downloads";



} 
    