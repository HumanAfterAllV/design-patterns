import { exec } from "child_process";

const args = process.argv.slice(2);
const pattern = args[0];

if (!pattern){
    console.error("❌ Debes especificar un patrón. Ej: npm run pattern singleton")
    process.exit(1)
}

const paths = [
    `src/creational/${pattern}/index.ts`,
    `src/structural/${pattern}/index.ts`,
    `src/behavioral/${pattern}/index.ts`,
]

const fs = require("fs")

const found = paths.find(fs.existsSync)

if (!found){
    console.error(`❌ No se encontró el patrón '${pattern}' en creational, structural o behavioral.`)
    process.exit(1)
}

exec(`npx ts-node ${found}`, (err, stdout, stderr) => {
    if(err){
        console.error(`❌ Error al ejecutar ${found}`)
        console.error(stderr)
        return;
    }

    console.log(stdout)
})
