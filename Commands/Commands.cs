using Avalonia.Controls;

namespace Notepad_V2.Commands;

public class Commands : MainWindow
{

    public void OpenButtonCommnad()
    {

        var openfile = new OpenFileDialog();
        openfile.Title = "Open file";
        openfile.Directory = "/home/momo/Downloads";
        
        

    }
    
    
}