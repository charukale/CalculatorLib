namespace LoggerContractsLib
{
    //contract btw high level n low level modules
    
        // 4/ let high level module have refrence of abstraction of low level module (program for interface not for implementation) 
        // 5 define dependency injection (constructor , property or method)
    public interface ILogger
    {
        void write(string msg);
    }
}