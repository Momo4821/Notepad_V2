using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using CommunityToolkit.Mvvm.ComponentModel;
using Microsoft.VisualBasic;

namespace Notepad_V2.Models;

public partial class LowerLabelsModel : ObservableObject
{    
    
    [ObservableProperty]
    private string _col;

    [ObservableProperty]

    private string _row;

    
    public string col_row => $"{_col}{_row}";




    
    
    partial void OnColChanged (string value)
    {
        OnPropertyChanged(nameof(col_row));
    }
    
    
    partial void OnRowChanged (string value)

    {   
    OnPropertyChanged(nameof(col_row));
        
        
    }
    
    
}   


    
    
    
    
  
    
