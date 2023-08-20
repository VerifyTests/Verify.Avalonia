class VisualConverter :
    WriteOnlyJsonConverter<Visual>
{
    public override void Write(VerifyJsonWriter writer, Visual value)
    {
        writer.WriteStartObject();
        WriteMembers(writer, value);
        writer.WriteEndObject();
    }

    public static void WriteMembers(VerifyJsonWriter writer, Visual value)
    {
         writer.WriteMember(value, value.Bounds, "Bounds");
         writer.WriteMember(value, value.ClipToBounds, "ClipToBounds");
         writer.WriteMember(value, value.Clip, "Clip");
         writer.WriteMember(value, value.IsEffectivelyVisible, "IsEffectivelyVisible");
         writer.WriteMember(value, value.IsVisible, "IsVisible");
         writer.WriteMember(value, value.Opacity, "Opacity");
         writer.WriteMember(value, value.OpacityMask, "OpacityMask");
         writer.WriteMember(value, value.Effect, "Effect");
         writer.WriteMember(value, value.HasMirrorTransform, "HasMirrorTransform");
         writer.WriteMember(value, value.RenderTransform, "RenderTransform");
         writer.WriteMember(value, value.RenderTransformOrigin, "RenderTransformOrigin");
         writer.WriteMember(value, value.FlowDirection, "FlowDirection");
         writer.WriteMember(value, value.ZIndex, "ZIndex");
    }
}
