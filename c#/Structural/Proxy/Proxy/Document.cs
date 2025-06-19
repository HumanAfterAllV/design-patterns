using Interface.IDocument;

namespace Proxy.Document
{
    public class Document : IDocument
    {
        private string fileName;
        private string? content;

        public Document(string fileName, string? content)
        {
            this.fileName = fileName;
            this.content = content;
        }

        public async Task Sleep(int ms)
        {
            await Task.Delay(ms);
        }

        public async Task LoadFromDisk()
        {
            Console.WriteLine($"Load {fileName} document from disk...");
            await Sleep(3000);
        }

        public async Task Display(string user)
        {
            if (string.IsNullOrEmpty(content))
            {
                await LoadFromDisk();
            }
            Console.WriteLine($"{user} is watching document: {fileName}");
        }
    }
    
}