using System;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Notepad_V2.Models;

namespace Notepad_V2.ViewModels;

public partial class LowerLabelViewModel : ObservableObject
{
private readonly FileMenuModel _filemodel;
private readonly LowerLabelsModel _lowerlabelsmodel;


public LowerLabelViewModel (LowerLabelsModel model)
{

       _lowerlabelsmodel = model;
       _filemodel = new FileMenuModel();
    
       
    
}

public LowerLabelsModel labels => _lowerlabelsmodel;





public void updatelabels ()
{
       /*_filemodel.content = _filemodel.content ?? string.Empty;
       var lines = _filemodel.content.Split(new[] { Environment.NewLine }, StringSplitOptions.None);
       var lineCount = lines.Length;
       var columnCount = lines.Length > 0 ? lines[0].Length : 0;
       _lowerlabelsmodel.Row = lineCount.ToString();
       _lowerlabelsmodel.Col = columnCount.ToString();*/
       
  
       
       
       
       
       
}
}






    
  
  
  
  
  
  