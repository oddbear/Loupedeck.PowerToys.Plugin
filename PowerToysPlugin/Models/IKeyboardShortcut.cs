namespace Loupedeck.PowerToysPlugin.Models
{
    public interface IKeyboardShortcut
    {
        bool Win { get; set; }
        
        bool Ctrl { get; set; }
        
        bool Alt { get; set; }
        
        bool Shift { get; set; }
        
        int Code { get; set; }
        
        string Key { get; set; }
    }
}
