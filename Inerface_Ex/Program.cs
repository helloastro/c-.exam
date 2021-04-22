using System;
using System.IO;

namespace Inerface_Ex
{
    interface ILogger
    {
        void WriteLog(string log);
        void WriteError(string msg) // 기본구현 메서드 - 부모 인터페이스 타입만 호출 가능, 자식 타입 구현필수.
        {
            WriteLog($"Error: {msg}");
        }
    }
    
    class ClimateMonitor
    {
        private ILogger logger;

        public ClimateMonitor(ILogger logger)
        {
            this.logger = logger;
        }

        public void Start()
        {
            while(true)
            {
                Console.Write("온도를 입력해 주세요.: ");
                string temp = Console.ReadLine();

                if (temp == "")
                    break;

                //Console.WriteLine($"현재 온도는 : {temp}");
                logger.WriteLog(temp);
            }
        }
    }

    class ConsoleLogger: ILogger
    {
        public void WriteLog(string log)
        {
            Console.WriteLine($"현재 온도는 : {log}");
        }
    }

    class FileLogger: ILogger
    {
        private StreamWriter writer;

        public FileLogger(string path)
        {
            writer = File.CreateText(path);
            writer.AutoFlush = true;
        }

        public void WriteLog(string log)
        {
            writer.WriteLine($"{DateTime.Now.ToShortTimeString()} {log}");
        }
    }
 
    class Program
    {
        static void Main(string[] args)
        {
            //ClimateMonitor monitor = new ClimateMonitor();
            ClimateMonitor monitor = new ClimateMonitor(new ConsoleLogger());
            //ClimateMonitor monitor = new ClimateMonitor(new FileLogger("log.txt"));

            monitor.Start();
        }
    }
}
