public class Points
{
    public event Action? OnChange;

    private long _point;
    public long Point
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
    public int Upgrade3 { get; set; } = 1;
    public bool Upgrade3Unlocked { get; set; }
    public int PointMulti => BasePoint * (Upgrades * Upgrade2 * Upgrade3);
    public int Prestige { get; set; } = 0;
    public bool PrestigeUnlocked { get; set; }

    private void NotifyStateChanged() => OnChange?.Invoke();

    public static string FormatNumbers(long number)
    {
        if (number >= 1_000_000_000_000)
            return (number / 1_000_000_000_000D).ToString("0.##") + "T";
        if (number >= 1_000_000_000)
            return (number / 1_000_000_000D).ToString("0.##") + "B";
        if (number >= 1_000_000)
            return (number / 1_000_000D).ToString("0.##") + "M";
        if (number >= 1_000)
            return (number / 1_000D).ToString("0.##") + "K";
        return number.ToString("N0");
    }
}