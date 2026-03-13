using System;
using System.IO;
using Avalonia.Controls;
using Notepad_V2.Views;
using Notepad_V2.Models;

namespace Notepad_V2.ViewModels;




public class TextBoxViewModel
{
 
 FileModel _filemodel;
 FileMenuViewModel _filemenuviewmodel;
 FormatViewModel _formatviewmodel;
 EditMenuViewModel _editmenuviewmodel;
 Viewheaderviewmodel _viewheaderviewmodel;
 TextboxModel _TextBoxModel;
 LowerLabelsModel _lowerlabelsmodel;
 
 public bool ismodified;
 

 
 public TextBoxViewModel()
 {
     
 
     
  
 
 }

 private void MainTextbox_OnSizeChanged(object? sender, SizeChangedEventArgs e)
 {
var Mainwindowview = new MainWindowView();
  var maintextbox = Mainwindowview.MainTextbox;
  
  
  
  
 }
 
 
}