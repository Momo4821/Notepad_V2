using System;
using Avalonia.Controls;
using Avalonia.Platform.Storage;

namespace Notepad_V2;

public class Mainwindowviewmodel
{

    
    
    //1.define a delegate
    //2. deine an event basd on that delegate
    //3. raise the event

    public OpenfileEventhandler OpenButtonCommnad { get; set; } // define a property of type delegate
    public NewfileEventhandler NewFileButtonCommand { get; set; }
    
public delegate void OpenfileEventhandler(object source, EventArgs args); //define a delegate
            //delegate for new file open eventhandler
            public delegate void NewfileEventhandler(object source, EventArgs args);

public event OpenfileEventhandler Fileopened; //define an event based on that delegate
//define event based on the newfile method
public event NewfileEventhandler newfilecreated;

public Mainwindowviewmodel() // constructor that initializes the properties 
{
    
OpenButtonCommnad = Fileopened; // define a property of type delegate
NewFileButtonCommand = newfilecreated; // define a property of type delegate





    
}




//two delegates 
    //lowercase keyword define type that has parameter and retrun requirments
    //uppercase retunrs delegate 
    
    //name or property of type delegate
    
    
    //lower case delegate would define all the open file stuff that is neeeded
    
    //uppercase delegate would return the actual event handler that would be used in the command binding

    
    
    
    
    
  
    }