using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Runtime.CompilerServices;
using Avalonia.Controls;
using Microsoft.VisualBasic;
using Tmds.DBus.Protocol;

namespace Notepad_V2.Models; 

public class FileModel : INotifyPropertyChanged
{
    /*public string _filename { get => Filename; set => Filename = value; }
    public string _filetype { get => Filetype; set => Filetype = value; }
    public string _filepath { get => Filepath; set => Filepath = value; }
    
  public FileModel (string filepath, string filename, string filetype)
  {
      Filepath = filepath;
      Filename = filename;
      Filetype = filetype;
}
    private string Filepath;
    private string Filename;
    private string Filetype;  */ 

    private string _filename;
    private string _filepath;
    private string _filetype; 
    public event PropertyChangedEventHandler? PropertyChanged;
        
    
    
    
    
        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "") // got this from the docs
        {
            if (PropertyChanged != null) // my undestanding of this is that when this is a method that will ba called if a property is changed(ex:if a filename is changed it will get the new file name)
            
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
        
        public string FileName 
        {
            get => _filename;
            set
            {
                _filename = value;
                NotifyPropertyChanged(FileName);
            }
        }
        
        public string Filepath
        {
            get => _filepath;   
            set
            {
                _filepath = value;
                NotifyPropertyChanged(Filepath);
            }
        }
        
        public string Filetype
        {
            get => _filetype;
            set
            {
                _filetype = value;
                NotifyPropertyChanged(Filetype);
            }
            
        }
        
        
    } 
    