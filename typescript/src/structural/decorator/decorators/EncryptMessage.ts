import { IMessage } from "../interfaces/IMessage";
import { MessageDecorator } from "./MessageDecorator";

import { Buffer } from "buffer";
import crypto from "crypto"

export class EncryptMessage extends MessageDecorator {
    private password: string;

    constructor( password: string, message: IMessage){
        super(message)
        this.password = password
    }

    encryptMessage(): IMessage{
        try{

            const plaintext = Buffer.from(this.message.getContent(), "utf-8");
            
            const salt = crypto.randomBytes(12)
            const key = crypto.pbkdf2Sync(this.password, salt, 100000, 32 , "sha256")
            
            const cipher = crypto.createCipheriv("aes-256-ccm", key, salt, {authTagLength: 16});
            const ciphertext = Buffer.concat([cipher.update(plaintext), cipher.final()]);
            const tag = cipher.getAuthTag();

            const encryptData = Buffer.concat([salt, tag, ciphertext]);
            const encryptB64 = encryptData.toString("base64");

            this.message.setContent(encryptB64);

            return this.message;
        }
        catch(error){
            throw new Error("Encryption failed: "+ error)
        }

    }

    processMessage(): IMessage {
        this.message = this.message.processMessage();
        return this.encryptMessage();
    }

}