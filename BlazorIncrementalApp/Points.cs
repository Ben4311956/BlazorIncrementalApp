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
    public double CriticalBoost { get; set; } = 1;
    public int CriticalGainAmount { get; set; } = 0;
    public double CriticalGainChance { get; set; } = 0;
    private bool _overdoseUnlocked;
    private decimal _overdose;
    public bool OverdoseUnlocked 
    {
        get => _overdoseUnlocked;
        set
        {
            _overdoseUnlocked = value;
            NotifyStateChanged();
        }
    }
    public decimal Overdose
    {
        get => _overdose;
        set
        {
            _overdose = value;
            NotifyStateChanged();
        }
    }
    public decimal OverdoseAmount { get; set; } = 0;
    public decimal OverdoseMulti => OverdoseUnlocked ? Overdose : 1;
    public int DelayAmount { get; set; } = 1000;
    public int AutoClickerUpgrades { get; set; } = 0;
    public decimal PointMulti => BasePoint * (((Upgrades * Upgrade2 * Upgrade3) * Upgrade4) * OverdoseMulti) * PetsMulti;
    public decimal PetsMulti => Pet1Boost * Pet2Boost;
    public bool Pet1 { get; set; }
    public decimal Pet1Boost { get; set; } = 1m;
    public bool Pet1Equipped { get; set; }
    public bool Pet2 { get; set; }
    public decimal Pet2Boost { get; set; } = 1m;
    public bool Pet2Equipped { get; set; }
    public bool Pet3 { get; set; }
    public decimal Pet3Boost { get; set; } = 1m;
    public bool Pet3Equipped { get; set; }
    public decimal Prestige { get; set; } = 0;
    public bool PrestigeUnlocked { get; set; }

    private void NotifyStateChanged() => OnChange?.Invoke();

    public static string FormatNumbers(decimal number)
    {
        if (number >= 1e27m)
            return (number / 1e27m).ToString("0.##") + "Oc";
        if (number >= 1e24m) 
            return (number / 1e24m).ToString("0.##") + "Sp";
        if (number >= 1e21m)
            return (number / 1e21m).ToString("0.##") + "Sx";
        if (number >= 1e18m)
            return (number / 1e18m).ToString("0.##") + "Qn";
        if (number >= 1e15m)
            return (number / 1e15m).ToString("0.##") + "Qd";
        if (number >= 1e12m) 
            return (number / 1e12m).ToString("0.##") + "T";
        if (number >= 1e9m) 
            return (number / 1e9m).ToString("0.##") + "B";
        if (number >= 1e6m) 
            return (number / 1e6m).ToString("0.##") + "M";
        if (number >= 1e3m) 
            return (number / 1e3m).ToString("0.##") + "K";
        return number.ToString("N0");
    }
}