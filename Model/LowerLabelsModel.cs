using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using CommunityToolkit.Mvvm.ComponentModel;
using Microsoft.VisualBasic;

namespace Notepad_V2.Models;

public class LowerLabelsModel : INotifyPropertyChanged
{    /*public DateAndTime Colum_Row  { get;}
    //public string _User_id { get;}
   // public string TextBlockFileLabel { get; set; }

   public string ZoomLabel { get; set; }*/
 
    
    
private string _Colum_Row { get; set; }
private string _ZoomLabel { get; set; }
private ulong  _characters { get; set; }
public event PropertyChangedEventHandler? PropertyChanged;
private void NotifyPropertyChanged([CallerMemberName] String propertyName = "") // got this from the docs
{
    if (PropertyChanged != null) // my undestanding of this is that when this is a method that will ba called if a property is changed(ex:if a filename is changed it will get the new file name)
            
    {
        PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
    }
}

public string Colum_Row
{
    get => _Colum_Row;
    set
    {
        _Colum_Row = value;
        NotifyPropertyChanged(Colum_Row);
    }
}


public string ZoomLabel
{
    get => _ZoomLabel;  
    set
    {
        _ZoomLabel = value;
        NotifyPropertyChanged(ZoomLabel);
    }
}

public ulong Characters
{
    get => _characters;
    set
    {
        _characters = value;
        NotifyPropertyChanged(Characters.ToString());
    }
}   
}   

    
    
    
    
  
    
