using System;
using System.IO;
using System.Windows.Input;
using Avalonia.Controls;
using HarfBuzzSharp;
using Notepad_V2.BaseCommands;
using Notepad_V2.Models;
namespace Notepad_V2.ViewModels;
public class FileMenuViewModel // create an instance of the viewmodel in the mainview
{  
    public ICommand OpenButtonCommand { get; set; }
    

    public ICommand NewFileButtonCommand {get;set;}

    public ICommand NewwindowMenuCommand  {get;set;}

    public ICommand SaveAsCommand   {get;set;}

    public ICommand PrintCommand   {get;set;}

    public ICommand ExitCommand  {get;set;}
    
    public FileMenuViewModel()
    {
        
     
    var _Filemodel = new FileModel();
    var _filetype = _Filemodel.Filetype;
    var _filename = _Filemodel.filename;
    var _filepath = _Filemodel.Filepath;
    var _file = _Filemodel.file;
    
    OpenButtonCommand = new Commands();
    O
    
    
   

    
    
    
                                                        
                                                        
                                                        
    }
     
   
      

 
 


    



    
    
    




    

    
    




}