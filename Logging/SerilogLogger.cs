using Microsoft.Extensions.Configuration;
using Serilog;

namespace Notepad_V2.NotepadV2.Logging;

public class SerilogLogger
{
 
    public SerilogLogger()
    {
        var config = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
        
        var logger = new LoggerConfiguration().ReadFrom.Configuration(config)
            .MinimumLevel.Information().
            CreateLogger();
        
    }
    
    
    
    
}