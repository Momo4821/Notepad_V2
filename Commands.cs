using System;
using Avalonia.Controls;
using Avalonia.Platform.Storage;


namespace Notepad_V2;

public class OpenFileCommand
{
public delegate void OpenFileEventHandler();

public OpenFileEventHandler OpenFileEvent;

public OpenFileCommand()
{
    
   
    
    
}
    
    
    



private void OpenFile()
{
   
 var topLevel = Window;
 var storageProvider = topLevel.StorageProvider;
 var options = new FilePickerOpenOptions();


}

