﻿using Avalonia.Controls;

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
        foreach (var type in typeof(Window).Assembly.GetTypes().Where(_ => _.IsAssignableTo(visual)))
        {
            WriteType(type, convertersPath);
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

            builder.AppendLine(
                $"""
                          writer.WriteMember(value, value.{property.Name}, "{property.Name}");
                 """);
        }

        builder.AppendLine("    }");
        builder.AppendLine("}");
        File.WriteAllText(Path.Combine(convertersPath, type.Name)+".cs", builder.ToString());
    }
}