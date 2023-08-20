using Avalonia.Controls;

[TestFixture]
public class Tests
{
    [Test]
    public void Types()
    {
        var convertersPath = Path.Combine(AttributeReader.GetSolutionDirectory(), @"Verify.Avalonia\Converters\");
        foreach (var file in Directory.EnumerateFiles(convertersPath))
        {
            File.Delete(file);
        }
        var visual = typeof(Visual);
        WriteType(visual, convertersPath);
        var types = typeof(Window).Assembly.GetTypes().Concat(typeof(InputElement).Assembly.GetTypes());
        foreach (var type in types.Where(_ => _.IsAssignableTo(visual)))
        {
            if (type.IsPublic)
            {
                WriteType(type, convertersPath);
            }
        }
    }

    static void WriteType(Type type, string convertersPath)
    {
        var builder = new StringBuilder();
        builder.AppendLine(
            $$"""
              class {{type.Name}}Converter :
                  WriteOnlyJsonConverter<{{type.Name}}>
              {
                  public override void Write(VerifyJsonWriter writer, {{type.Name}} value)
                  {
                      writer.WriteStartObject();
                      WriteMembers(writer, value);
              """);
        if (type != typeof(Visual))
        {
            builder.AppendLine(
                $"        {type.BaseType!.Name}Converter.WriteMembers(writer, value);");
        }

        builder.AppendLine(
            """
                    writer.WriteEndObject();
                }
            """);

        builder.AppendLine(
            $$"""

                  public static void WriteMembers(VerifyJsonWriter writer, {{type.Name}} value)
                  {
              """);
        foreach (var property in type.GetProperties(BindingFlags.Instance | BindingFlags.Public))
        {
            if (property.DeclaringType != type)
            {
                continue;
            }

            if (property.GetCustomAttribute<ObsoleteAttribute>() != null)
            {
                continue;
            }

            builder.AppendLine(
                $"""
                          writer.WriteMember(value, value.{property.Name}, "{property.Name}");
                 """);
        }

        builder.AppendLine("    }");
        builder.AppendLine("}");
        File.WriteAllText(Path.Combine(convertersPath, $"{type.Name}Converter.cs"), builder.ToString());
    }
}