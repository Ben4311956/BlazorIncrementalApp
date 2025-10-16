public class Buttons
{
    public event Action? OnChange;

    private bool _midPointBtnUnlocked;
    public bool MidPointBtnUnlocked 
    { get => _midPointBtnUnlocked;
        set
        {
            _midPointBtnUnlocked = value;
            OnChange?.Invoke();
        }
    }
    public bool HighPointBtnUnlocked { get; set; }
}

