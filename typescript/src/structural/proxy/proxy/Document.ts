export interface Document{
    display: (user:string) => void;
}


export class RealDocument implements Document {
    private filename: string
    private content: null
    
    constructor(filename: string, content: null){
        this.filename = filename
        this.content = content
    }
    
    sleep(ms: number): Promise<void> {
        return new Promise(resolver => setTimeout(resolver, ms))
    }
    
    async loadFromDisk(): Promise<void> {
        console.log(`📄 Load ${this.filename} document from disk...`)
        await this.sleep(3000)
    }

    async display(user: string): Promise<void> {
        if (!this.content) {
            await this.loadFromDisk(); // Esperar a que el documento se cargue
        }
        console.log(`${user} is watching document: ${this.filename}`);
    }
}