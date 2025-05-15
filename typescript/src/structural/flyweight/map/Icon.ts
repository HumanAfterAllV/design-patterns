export class Icon {
    private type: string;
    private imagePath: string;

    constructor(type: string, imagePath: string){
        this.type = type;
        this.imagePath = imagePath;
    }

    static render(icon: Icon, latitude: number, longitude: number): void{
        console.log(`Render icon type '${icon.type.toUpperCase()}' at (${latitude} - ${longitude}) using image: ${icon.imagePath}`)
    }
}