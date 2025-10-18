public class Points
{
    public event Action? OnChange;

    private decimal _point;
    public decimal Point
    {
        get => _point;
        set
        {
            _point = value;
            NotifyStateChanged();
        }
    }
    public decimal BasePoint { get; set; } = 1;
    public decimal Upgrades { get; set; } = 1;
    public decimal Upgrade2 { get; set; } = 1;
    public bool Upgrade2Unlocked { get; set; }
    public decimal Upgrade3 { get; set; } = 1;
    public bool Upgrade3Unlocked { get; set; }
    public decimal Upgrade4 { get; set; } = 1;
    public bool Upgrade4Unlocked { get; set; }
    public decimal PointMulti => BasePoint * ((Upgrades * Upgrade2 * Upgrade3) * Upgrade4);
    public decimal Prestige { get; set; } = 0;
    public bool PrestigeUnlocked { get; set; }

    private void NotifyStateChanged() => OnChange?.Invoke();

    public static string FormatNumbers(decimal number)
    {
        if (number >= 1_000_000_000_000_000)
            return (number / 1_000_000_000_000_000m).ToString("0.##") + "Qd";
        if (number >= 1_000_000_000_000)
            return (number / 1_000_000_000_000m).ToString("0.##") + "T";
        if (number >= 1_000_000_000)
            return (number / 1_000_000_000m).ToString("0.##") + "B";
        if (number >= 1_000_000)
            return (number / 1_000_000m).ToString("0.##") + "M";
        if (number >= 1_000)
            return (number / 1_000m).ToString("0.##") + "K";
        return number.ToString("N0");
    }
}