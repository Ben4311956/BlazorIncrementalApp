public class MoonPoints
{
    public event Action? OnChange;
    private decimal _moonPoint;
    public decimal MoonPoint 
    { get => _moonPoint; 
        set
        {
            _moonPoint = value;
            NotifyStateChanged();
        }
    }

    private bool _moonUnlocked;
    public bool MoonUnlocked 
    { get => _moonUnlocked; 
        set 
        {
            _moonUnlocked = value;
            NotifyStateChanged();
        } 
    }

    private void NotifyStateChanged() => OnChange?.Invoke();
}

