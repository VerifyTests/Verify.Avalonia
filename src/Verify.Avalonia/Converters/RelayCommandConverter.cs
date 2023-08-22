using CommunityToolkit.Mvvm.Input;

namespace VerifyTests;

public class RelayCommandConverter :
    WriteOnlyJsonConverter<RelayCommand>
{
    static FieldInfo executeField = typeof(RelayCommand)
        .GetField("execute", BindingFlags.Instance | BindingFlags.NonPublic)!;

    public override void Write(VerifyJsonWriter writer, RelayCommand value)
    {
        var action = (Action)executeField.GetValue(value)!;
        writer.Serialize(action);
    }
}