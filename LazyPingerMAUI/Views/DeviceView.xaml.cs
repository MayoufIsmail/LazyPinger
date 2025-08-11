using LazyPinger.Core.Models;

namespace LazyPingerMAUI.Views;

public partial class DeviceView : ContentView
{
    public static readonly BindableProperty DeviceColorProperty = BindableProperty.Create(nameof(DeviceColor), typeof(Color), typeof(DeviceView));

    public static readonly BindableProperty DeviceBorderColorProperty = BindableProperty.Create(nameof(DeviceBorderColor), typeof(Color), typeof(DeviceView));

    public static readonly BindableProperty DevicePingProperty = BindableProperty.Create(nameof(DevicePing), typeof(DevicePing), typeof(DeviceView));

    public DevicePing DevicePing
    {
        get => (DevicePing)GetValue(DevicePingProperty);
        set => SetValue(DevicePingProperty, value);
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