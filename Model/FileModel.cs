
using System.IO;


namespace Notepad_V2.Models; 

public partial class FileModel
{
    public string Content { get; set; }
    public string Filepath { get; set; }

    public string Filename
    {
        get => Path.GetFileName(Filepath);
        set => Path.GetFileName(Filepath);
    }

    public string Filetype
    {
        get => Path.GetExtension(Filepath);
        set => Path.GetExtension(Filepath);
        
    }
    public bool IsFile => !string.IsNullOrEmpty(Filepath);
   
} 

