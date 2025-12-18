namespace VerifyTests;

public static partial class VerifyAvalonia
{
    static List<Assembly> avaloniaConverterAssemblies = [];

    static List<WriteOnlyJsonConverter> converters =
    [
        new CommandAwareObjectConverter(),
        new ThicknessConverter(),
        new CornerRadiusConverter(),
        new FontFamilyConverter()
    ];

    static VerifyAvalonia()
    {
        // Avalonia.Controls
        AddAvaloniaConvertersForAssemblyOfType<Window>();
        // Avalonia.Base
        AddAvaloniaConvertersForAssemblyOfType<InputElement>();
        // Avalonia.Controls.ColorPicker
        AddAvaloniaConvertersForAssemblyOfType<ColorPicker>();
        // Avalonia.Controls.DataGrid
        AddAvaloniaConvertersForAssemblyOfType<DataGrid>();
    }

    /// <summary>
    /// Add <see cref="AvaloniaConverter{T}"/> instances for all types
    /// in the given assembly of the given type <typeparamref name="T"/>
    /// that are assignable to <see cref="AvaloniaObject"/>
    /// </summary>
    /// <typeparam name="T"> The type of the assembly to scan </typeparam>
    public static void AddAvaloniaConvertersForAssemblyOfType<T>() =>
        AddAvaloniaConvertersForAssembly(typeof(T).Assembly);

    /// <summary>
    /// Add <see cref="AvaloniaConverter{T}"/> instances for all types
    /// in the given <paramref name="assembly"/> that are assignable to <see cref="AvaloniaObject"/>
    /// </summary>
    /// <param name="assembly"> The assembly to scan </param>
    public static void AddAvaloniaConvertersForAssembly(Assembly assembly)
    {
        InnerVerifier.ThrowIfVerifyHasBeenRun();
        avaloniaConverterAssemblies.Add(assembly);
    }

    static int GetDepth(Type type)
    {
        var level = 0;
        while (type != typeof(object))
        {
            level++;
            type = type.BaseType!;
        }

        return level;
    }

    static Type avaloniaConverterType = typeof(AvaloniaConverter<>);
    static Type avaloniaObjectType = typeof(AvaloniaObject);

    static void AddConverters()
    {
        var types = avaloniaConverterAssemblies
            .SelectMany(_ => _.GetTypes())
            .Where(_ =>
                _.IsAssignableTo(avaloniaObjectType) &&
                _ is
                {
                    IsPublic: true,
                    IsAbstract: false
                })
            .OrderByDescending(GetDepth);
        foreach (var type in types)
        {
            var genericType = avaloniaConverterType.MakeGenericType(type);
            converters.Add((WriteOnlyJsonConverter) Activator.CreateInstance(genericType)!);
        }

        VerifierSettings.AddExtraSettings(_ => _.Converters.AddRange(converters));
    }
}