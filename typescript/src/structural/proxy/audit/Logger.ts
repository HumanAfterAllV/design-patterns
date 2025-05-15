export function logAccess(user: string, filename: string): void{
    const now = new Date();
    console.log(`${now.getFullYear()} - ${now.getTime()} Attempted access by: ${user} - ${filename}`)
}