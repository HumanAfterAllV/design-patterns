export function slugGenerator(title: string): string{
    if (!title){
        throw new Error("El titulo no puede estar vacío.")
    }

    // Convertir a minúsculas y eliminar espacios al inicio y al final
    title = title.toLowerCase().trim();

    // Reemplazar caracteres no alfanuméricos (excepto guiones y espacios) con una cadena vacía
    title = title.replace(/[^\w\s-]/g, "");

    // Reemplazar múltiples espacios o guiones consecutivos con un solo guión
    title = title.replace(/[\s_-]+/g, "-");

    // Eliminar guiones al inicio o al final
    title = title.replace(/^-+|-+$/g, "");

    return title
}