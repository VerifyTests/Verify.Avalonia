static class Extensions
{
    public static MemoryStream ToImage(this TopLevel topLevel)
    {
        using var bitmap = topLevel.CaptureRenderedFrame();
        var stream = new MemoryStream();
        if (bitmap == null)
        {
            throw new("No RenderedFrame");
        }

        bitmap.Save(stream);
        return stream;
    }
}