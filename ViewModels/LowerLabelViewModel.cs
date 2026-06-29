using System;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Notepad_V2.Models;

namespace Notepad_V2.ViewModels;

public partial class LowerLabelViewModel : ObservableObject
{
   public LowerLabelsModel LowerLabelsModel {get;}
   public FileModel FileModel {get;}
       
       
       public LowerLabelViewModel (LowerLabelsModel model,FileModel file)
       {
           FileModel =  file;
           LowerLabelsModel = model;
           
           
       }

    






}








    
  
  
  
  
  
  