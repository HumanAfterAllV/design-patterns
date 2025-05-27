using System.Text.RegularExpressions;

namespace Publisher.Slug
{
    public class Slug
    {
        public string SlugGenerator(string title)
        {
            if (string.IsNullOrEmpty(title))
            {
                return string.Empty;
            }

            
            // 1. Eliminar caracteres que no sean letras, números, espacios o guiones
            title = Regex.Replace(title, @"[^\w\s-]", "");

            // 2. Reemplazar múltiples espacios o guiones bajos/consecutivos por un solo guión
            title = Regex.Replace(title, @"[\s_-]+", "-");

            // 3. Eliminar guiones al inicio o al final
            title = Regex.Replace(title, @"^-+|-+$", "");

            return title;

        }
    }
}