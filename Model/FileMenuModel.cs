using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Runtime.CompilerServices;
using Avalonia.Controls;
using Avalonia.Platform.Storage;
using CommunityToolkit.Mvvm.ComponentModel;
using Microsoft.VisualBasic;
using Tmds.DBus.Protocol;

namespace Notepad_V2.Models; 

public partial class FileMenuModel
{
    public string Content { get; set; }
    public string Filepath { get; set; }

    public string Filename => Path.GetFileName(Filepath);
    public string Filetype => Path.GetExtension(Filepath);
    public bool IsFile => !string.IsNullOrEmpty(Filepath);
   
} 

