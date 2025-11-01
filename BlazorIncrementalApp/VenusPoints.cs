public class VenusPoints
{
    public event Func<Task>? OnChange;
    private decimal _crysallite;
    public decimal Crysallite { get => _crysallite; 
        set
        {
            _crysallite = value;
            _ = NotifyStateChanged();
        }
            
    }

    public async Task NotifyStateChanged()
    {
        if (OnChange is not null)
            await OnChange.Invoke();
    }

    private CancellationTokenSource? _autoClickerCts;
    private bool _autoClickerRunning = false;

    public void StartAutoClicker()
    {
        if (_autoClickerRunning || !AutoDrillUnlocked) return;

        _autoClickerRunning = true;
        _autoClickerCts = new CancellationTokenSource();

        _ = RunAutoClickerLoop(_autoClickerCts.Token);
    }

    private async Task RunAutoClickerLoop(CancellationToken token)
    {
        try
        {
            while (!token.IsCancellationRequested)
            {
                var production = AutoDrillBoost;
                if (LaserMinerUnlocked)
                {
                    production *= LaserMinerBoost;
                }
                Crysallite += production;
                await Task.Delay(1000, token);
            }
        }
        catch (TaskCanceledException)
        {

        }
        finally
        {
            _autoClickerRunning = false;
        }
    }

    public void StopAutoClicker()
    {
        _autoClickerCts?.Cancel();
        _autoClickerCts?.Dispose();
        _autoClickerCts = null;
        _autoClickerRunning = false;
    }

    public int MineLevel { get; set; } = 1;
    public int MineCost { get; set; } = 250;
    public int AutoDrillBoost { get; set; } = 0;
    public bool AutoDrillUnlocked { get; set; }
    public bool LaserMinerUnlocked { get; set; } = false;
    public int LaserMinerBoost { get; set; } = 3;
    public int TrueAutoDrillBoost => LaserMinerBoost * AutoDrillBoost;
    public bool QuantumExtractorUnlocked { get; set; }
    public decimal Crysalline { get; set; }

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
