using Interface.IDocument;
using Audit.Logger;

namespace Proxy.Proxy
{
    public enum UserRoles
    {
        Admin,
        Dr,
        Patient,
    }
    public class ProxyDocument : IDocument
    {
        private readonly string fileName;
        private Dictionary<string, string> authorizedUser = new Dictionary<string, string>();
        private Document.Document? realDocument;

        public ProxyDocument(string fileName, Document.Document realDocument, Dictionary<string, string> authorizedUser)
        {
            this.fileName = fileName;
            this.authorizedUser = authorizedUser;
            this.realDocument = realDocument;
        }

        public async Task Display(string user)
        {
            var logger = new Logger();

            logger.LogAccess(user, fileName);

            if (!Enum.TryParse<UserRoles>(user, out _))
            {
                throw new Exception($"Invalid user role: {user}");
            }

            if (!authorizedUser.ContainsKey(user))
            {
                throw new Exception($"User {user} does not have permission to access this document");
            }

            if (realDocument == null)
            {
                realDocument = new Document.Document(fileName, null);
            }

            if (realDocument != null)
            {
                await realDocument.LoadFromDisk();
                await realDocument.Display(user);
            }

        }
    }
}