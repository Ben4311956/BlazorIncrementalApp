using System.ComponentModel.DataAnnotations;

public class MoonPoints
{
    [Key]
    public int MoonPointsID { get; set; }
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
    public bool PlanetsUnlocked { get; set; }
    public decimal MoonPointMultiplier => PlanetsUnlocked ? (TotalVenusMultiplier * TotalMindoorMultiplier) : 0m;
    public bool MoonUnlocked { get; set; }
    public bool VenusUnlocked { get; set; }
    public bool MindoorUnlocked { get; set; }
    public decimal TotalMindoorMultiplier { get; set; }
    public decimal TotalVenusMultiplier { get; set; }
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

