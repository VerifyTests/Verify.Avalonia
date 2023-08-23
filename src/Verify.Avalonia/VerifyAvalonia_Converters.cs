namespace VerifyTests;

public static partial class VerifyAvalonia
{
    static List<WriteOnlyJsonConverter> converters = new()
    {
        new ThicknessConverter(),
        new CornerRadiusConverter(),
        new FontFamilyConverter()
    };

    static VerifyAvalonia()
    {
        var avaloniaObject = typeof(AvaloniaObject);
        var assemblies = new List<Assembly>
        {
            //Avalonia.Controls
            typeof(Window).Assembly,
            //Avalonia.Base
            typeof(InputElement).Assembly,
            //Avalonia.Controls.ColorPicker
            typeof(ColorPicker).Assembly,
            //Avalonia.Controls.DataGrid
            typeof(DataGrid).Assembly
        };
        var types = assemblies.SelectMany(_ => _.GetTypes())
            .Where(_ =>
                _.IsAssignableTo(avaloniaObject) &&
                _ is
                {
                    IsPublic: true,
                    IsAbstract: false
                })
            .OrderByDescending(GetDepth)
            .ToList();
        var avaloniaConverter = typeof(AvaloniaConverter<>);
        foreach (var type in types)
        {
            var genericType = avaloniaConverter.MakeGenericType(type);
            converters.Add((WriteOnlyJsonConverter) Activator.CreateInstance(genericType)!);
        }
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

    static void AddConverters() =>
        VerifierSettings.AddExtraSettings(
            _ => _.Converters.AddRange(converters));
}