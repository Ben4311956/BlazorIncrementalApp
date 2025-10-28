public class VenusPoints
{
    public event Action? OnChange;
    private decimal _crysallite;
    public decimal Crysallite { get => _crysallite; 
        set
        {
            _crysallite = value;
            NotifyStateChanged();
        }
            
    }


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
