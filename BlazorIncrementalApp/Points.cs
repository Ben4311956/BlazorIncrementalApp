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
    public int BasePoint { get; set; } = 1;
    public int Upgrades { get; set; } = 1;
    public int Upgrade2 { get; set; } = 1;
    public bool Upgrade2Unlocked { get; set; }
    public int PointMulti => BasePoint * (Upgrades * Upgrade2);

    private void NotifyStateChanged() => OnChange?.Invoke();
}