using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Avalonia.Controls;
using Microsoft.VisualBasic;
using Tmds.DBus.Protocol;

namespace Notepad_V2.Models; 

public class FileModel
{
    
    
    
    public class FileModelChanged : INotifyPropertyChanged
    {
        private string Filepath;
        private string Filename;
        private string Filetype;   
        
        
        public string _filename { get => Filename; set => Filename = value; }
        public string _filetype { get => Filetype; set => Filetype = value; }
        
        
        
        public event PropertyChangedEventHandler? PropertyChanged;
        
        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "") // got this from the docs
        {
            if (PropertyChanged != null) // my undestanding of this is that when this is a method that will ba called if a property is changed(ex:if a filename is changed it will get the new file name)
            
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
        
        
    }
    
}