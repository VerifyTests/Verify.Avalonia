using Avalonia.Controls;

[TestFixture]
public class Tests
{
    [Test]
    public void Types()
    {
        var solutionDirectory = AttributeReader.GetSolutionDirectory();

        var visual = typeof(Visual);
        var types =
            //Avalonia.Controls
            typeof(Window).Assembly.GetTypes()
                .Concat(
                    //Avalonia.Base
                    typeof(InputElement).Assembly.GetTypes())
                .Concat(
                    //Avalonia.Controls.ColorPicker
                    typeof(ColorPicker).Assembly.GetTypes())
                .Concat(
                    //Avalonia.Controls.DataGrid
                    typeof(DataGrid).Assembly.GetTypes())

                .Where(_ => _.IsAssignableTo(visual) && _.IsPublic)
                .OrderByDescending(GetDepth)
                .ToList();

        WriteConvertersFile(solutionDirectory, types);
    }

    static void WriteConvertersFile(string solutionDirectory, List<Type> types)
    {
        var path = Path.Combine(solutionDirectory, @"Verify.Avalonia\VerifyAvalonia_Converters.cs");

        File.Delete(path);
        using var writer = File.CreateText(path);
        writer.WriteLine(
            """
            namespace VerifyTests;

            public static partial class VerifyAvalonia
            {
            """);
        writer.WriteLine(
            """
                static void AddConverters() =>
                    VerifierSettings.AddExtraSettings(
                        _ =>
                        {
            """);
        foreach (var type in types)
        {
            writer.WriteLine(
                $"                _.Converters.Add(new AvaloniaConverter<{type.Name}>());");
        }

        writer.WriteLine("             });");
        writer.WriteLine("}");
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
}