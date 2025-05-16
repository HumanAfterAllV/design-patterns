export function loggerAction(user: string, action: string): void{
    const now = new Date();
    console.    log(`${now.getFullYear}-${now.getTime} Attempted access by: ${user} - ${action}`)
}