static class Extensions
{
    public static MemoryStream ToImage(this TopLevel topLevel)
    {
        using var bitmap = topLevel.CaptureRenderedFrame();
        if (bitmap == null)
        {
            throw new("No RenderedFrame");
        }

        var stream = new MemoryStream();
        bitmap.Save(stream);
        return stream;
    }
}