import { Icon } from "./Icon";

export class IconFactory{
    private static instance: IconFactory;
    private icons: Map<string, Icon>

    private constructor(){
        this.icons = new Map<string, Icon>()
    }

    public static getInstance(): IconFactory {
        if(!IconFactory.instance){
            IconFactory.instance = new IconFactory();
        }
        return IconFactory.instance;
    }

    getIcon(iconType: string): Icon {
        if (!this.icons.has(iconType)){
            console.log(`🆕 Creating new icon for: ${iconType}`)
            let path: string = `/icons/${iconType}.png`
            const icon: Icon = new Icon(iconType, path)
            this.icons.set(iconType, icon)
        }
        else{
            console.log(`✅ Reusing icon for: ${iconType}`)
        }

        return this.icons.get(iconType)!
    }
}