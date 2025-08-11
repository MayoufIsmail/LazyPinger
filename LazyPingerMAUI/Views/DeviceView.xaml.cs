namespace LazyPingerMAUI.Views;

public partial class DeviceView : ContentView
{
    public static readonly BindableProperty DeviceNameProperty = BindableProperty.Create(nameof(DeviceName), typeof(string), typeof(DeviceView), string.Empty);

    public static readonly BindableProperty DeviceColorProperty = BindableProperty.Create(nameof(DeviceColor), typeof(Color), typeof(DeviceView));

    public static readonly BindableProperty DeviceBorderColorProperty = BindableProperty.Create(nameof(DeviceBorderColor), typeof(Color), typeof(DeviceView));

    public string DeviceName
    {
        get => (string)GetValue(DeviceNameProperty);
        set => SetValue(DeviceNameProperty, value);
    }

    public Color DeviceColor
    {
        get => (Color)GetValue(DeviceColorProperty);
        set => SetValue(DeviceColorProperty, value);
    }

    public Color DeviceBorderColor
    {
        get => (Color)GetValue(DeviceBorderColorProperty);
        set => SetValue(DeviceBorderColorProperty, value);
    }

    public DeviceView()
	{
		InitializeComponent();
	}
}