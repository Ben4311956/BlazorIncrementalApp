public class Points
{
    public event Action? OnChange;

    private int _point;
    public int Point 
    { 
        get => _point; 
        set 
        {
            _point = value;
            NotifyStateChanged();
        } 
    }
    public int Upgrades { get; set; }

    private void NotifyStateChanged() => OnChange?.Invoke();
}