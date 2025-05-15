export function plainToHtml(content: string) : string{
    const lines = content.trim().split("\n")
    const htmlLines = []
    let inList = false

    for (let line in lines){
        line = line.trim()

        if (line.startsWith("## ")){
            htmlLines.push(`<h2>${line.slice(3)}</h2>`)
        }
        else if(line.startsWith("# ")){
            htmlLines.push(`<h1>${line.slice(2)}</h2>`)
        }
        else if(line.startsWith("- ")){
            if (!inList){
                htmlLines.push("<ul>")
                inList = true
            }
            htmlLines.push(`<li>${line.slice(3)}</li>`)
        }
        else{
            if (inList){
                htmlLines.push("</ul>")
                inList = false
            }
            htmlLines.push(`<p>${line}</p>`)
        }

    }

    if (inList){
        htmlLines.push("</ul>")
    }
    
    return htmlLines.join("\n")
}