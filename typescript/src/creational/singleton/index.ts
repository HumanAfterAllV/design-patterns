enum TYPE {
    info = "INFO",
    desc = "DESCRIPTION",
    error = "ERROR"
}

class Logger {
    private static instance: Logger
    private logList: string[]
    
    private constructor() {
        this.logList = []
    }

    public static getInstance() {
        if(!Logger.instance){
            Logger.instance = new Logger()
        }
        return Logger.instance
    }

    public addLog(message: string, type: TYPE): void {
        const now = new Date()
        this.logList.push(`[${now.toISOString()}: ${message} - ${type}]`)
    }

    public getLogs(): string[]{
        return this.logList;
    }
}

const logger = Logger.getInstance()

logger.addLog("Hello, this is a message", TYPE.info)
logger.addLog("Goodbye", TYPE.desc)

console.log(logger.getLogs())