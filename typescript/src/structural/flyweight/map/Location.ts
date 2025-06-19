import { Icon } from "./Icon";

export class MapLocation{
    private lat: number;
    private long: number;
    private icon: Icon;
    private name: string;

    constructor(lat: number, long: number, icon: Icon, name: string){
        this.lat = lat
        this.long = long
        this.icon = icon
        this.name = name
    }

    draw(): void{
        console.log(`📌 ${this.name}`)
        Icon.render(this.icon, this.lat, this.long)
    }
}