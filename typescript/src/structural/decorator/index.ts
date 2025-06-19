import { TextMessage } from "./models/TextMessage";
import { EncryptMessage } from "./decorators/EncryptMessage";

function Main() {
    
    const mensaje = new TextMessage("Este es un mensaje")
    console.log("Mensaje original: ", mensaje.getContent())

    const contraseña = "superclave123"

    const mensaje_encriptado = new EncryptMessage(contraseña, mensaje);
    const resultado = mensaje_encriptado.processMessage()

    console.log("Mensaje encriptado: ", resultado.getContent())

}   

Main()