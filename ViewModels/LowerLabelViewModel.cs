using System;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Notepad_V2.Models;

namespace Notepad_V2.ViewModels;

public partial class LowerLabelViewModel : ObservableObject
{
       public LowerLabelViewModel (LowerLabelsModel model, FileMenuModel fileMenumodel)
       {

       FileMenu = fileMenumodel;
       Labels = model;
       
}

LowerLabelsModel Labels { get;set;}
 FileMenuModel FileMenu { get;set;}





}








    
  
  
  
  
  
  