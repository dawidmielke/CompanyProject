namespace CompanyProject.Tools
{
    public static class ImageUtil
    {
        public static string? ToBase64Image(IFormFile image)
        {
            string base64img = null;
            if (image != null && image.Length > 0)
            {
                using (var ms = new MemoryStream())
                {
                    image.CopyTo(ms);
                    var fileBytes = ms.ToArray();
                    base64img = Convert.ToBase64String(fileBytes);
                }
            }
            return base64img;
        }
    }
}
