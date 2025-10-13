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
    public int Upgrades { get; set; } = 0;
    public int PointMulti => Upgrades * 2;

    private void NotifyStateChanged() => OnChange?.Invoke();
}