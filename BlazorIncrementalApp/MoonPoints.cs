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
    public bool MoonUnlocked { get; set; }
    private void NotifyStateChanged() => OnChange?.Invoke();


}

