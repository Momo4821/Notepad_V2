using System.ComponentModel;
using Avalonia.Controls;
using Notepad_V2.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Runtime.CompilerServices;
using Avalonia.Controls;
using Microsoft.VisualBasic;
using Tmds.DBus.Protocol;
namespace Notepad_V2.Views;

public class TextboxModel
{ 
public string Text { get; set; }    
public string TextColor { get; set; }
public string Font { get; set; }
public string Textstyle { get; set; }


public bool TextUnderline { get; set;}
public bool Textstrikeout { get; set;}
public bool ismodied;


TextBoxView _textBoxView;



private void Textbox_TextChanged(object sender, TextChangedEventArgs e)
{
    ismodied = true;
    
}








}