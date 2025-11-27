using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

public class Buttons
{
    [Key]
    public int ButtonsID { get; set; }
    public event Action? OnChange;

    private bool _midPointBtnUnlocked;
    public bool MidPointBtnUnlocked 
    { get => _midPointBtnUnlocked;
        set
        {
            _midPointBtnUnlocked = value;
            OnChange?.Invoke();
        }
    }
    public bool HighPointBtnUnlocked { get; set; }
    public bool CriticalGainUnlocked { get; set; }
    public bool AutoClickerUnlocked { get; set; }
}

