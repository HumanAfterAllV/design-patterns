
namespace Publisher.HTMLConverter
{
    public static class HTMLConverter
    {
        public static string PlainHtml(string content)
        {
            List<string> htmlLine = new();
            bool inList = false;

            var lines = content.Trim().Split("\n");

            foreach (var rawLine in lines)
            {
                var line = rawLine.Trim();

                if (line.StartsWith("## "))
                {
                    htmlLine.Append($"<h2>{line.Substring(3)}</h2>");
                }
                else if (line.StartsWith("# "))
                {
                    htmlLine.Append($"<h1>{line.Substring(2)}</h2>");
                }
                else if (line.StartsWith("- "))
                {
                    if (!inList)
                    {
                        htmlLine.Append("<ul>");
                        inList = true;
                    }
                    htmlLine.Append($"<li>{line.Substring(2).Trim()}</li>");
                }
                else
                {
                    if (inList)
                    {
                        htmlLine.Append("</ul>");
                        inList = false;
                    }

                    htmlLine.Append($"<p>{line}</p>");
                }
            }

            if (inList)
            {
                htmlLine.Append("</ul>");
            }

            return string.Join("", htmlLine);
        }
    }
}