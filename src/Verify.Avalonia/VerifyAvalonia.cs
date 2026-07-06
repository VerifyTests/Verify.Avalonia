using System.ComponentModel;
using System.Windows.Input;
using Avalonia.Styling;

namespace VerifyTests;

public static partial class VerifyAvalonia
{
    public static bool Initialized { get; private set; }

    public static void IncludeThemeVariant()
    {
        InnerVerifier.ThrowIfVerifyHasBeenRun();
        ShouldIncludeThemeVariant = true;
    }

    internal static bool ShouldIncludeThemeVariant;

    public static void Initialize()
    {
        if (Initialized)
        {
            throw new("Already Initialized");
        }

        Initialized = true;

        // WindowsBase registers CommandConverter as the TypeConverter for ICommand,
        // but on .NET 10 CommandConverter.CanConvertTo throws TypeLoadException for
        // MS.Internal.SecurityCriticalDataForSet. Override with a no-op converter so
        // Argon contract resolution can run without hitting the broken converter.
        TypeDescriptor.AddAttributes(typeof(ICommand), new TypeConverterAttribute(typeof(TypeConverter)));

        InnerVerifier.ThrowIfVerifyHasBeenRun();
        VerifierSettings.RegisterFileConverter<Window>(WindowToImage);
        VerifierSettings.RegisterFileConverter<TopLevel>(TopLevelToImage);
        VerifierSettings.RegisterFileConverter<UserControl>(ControlToImage);
        AddConverters();
    }

    static ConversionResult ControlToImage(UserControl control, IReadOnlyDictionary<string, object> context) =>
        Convert(() =>
        {
            var window = new Window
            {
                Content = control,
                SizeToContent = SizeToContent.WidthAndHeight,
            };
            window.Show();
            return new(
                control,
                BuildWindowTargets(window),
                Cleanup(window));
        });


    static Func<Task> Cleanup(Window window) =>
        () =>
        {
            var syncContext = SynchronizationContext.Current;
            try
            {
                window.Close();
            }
            finally
            {
                SynchronizationContext.SetSynchronizationContext(syncContext);
            }

            return Task.CompletedTask;
        };

    static ConversionResult WindowToImage(Window window, IReadOnlyDictionary<string, object> context) =>
        Convert(() =>
        {
            window.Show();
            return new(
                window,
                BuildWindowTargets(window),
                Cleanup(window));
        });

    // Showing an Avalonia window installs an AvaloniaSynchronizationContext as
    // SynchronizationContext.Current on the current thread. Verify runs its pipeline free of any
    // SynchronizationContext (it does async IO without ConfigureAwait(false); see
    // SettingsTask.ToTask), so restore the previous context after rendering. Otherwise the leaked
    // context would be captured by Verify's downstream async IO and its continuation posted to a
    // message pump that is never run - deadlocking whenever a snapshot is new or mismatched.
    static ConversionResult Convert(Func<ConversionResult> convert)
    {
        var syncContext = SynchronizationContext.Current;
        try
        {
            return convert();
        }
        finally
        {
            SynchronizationContext.SetSynchronizationContext(syncContext);
        }
    }

    static IEnumerable<Target> BuildWindowTargets(TopLevel window)
    {
        if (ShouldIncludeThemeVariant)
        {
            var application = Application.Current!;
            application.RequestedThemeVariant = ThemeVariant.Light;
            var light = new Target("png", window.ToImage(), "light");
            application.RequestedThemeVariant = ThemeVariant.Dark;
            var dark = new Target("png", window.ToImage(), "dark");
            return [light, dark];
        }

        return [new("png", window.ToImage())];
    }

    static ConversionResult TopLevelToImage(TopLevel topLevel, IReadOnlyDictionary<string, object> context) =>
        Convert(() => new(topLevel, BuildWindowTargets(topLevel)));
}