using System;

namespace Class_Ex
{
    class Cat
    {
        public string Name;
        public string Color;

        // 기본 생성자
        public Cat()
        {
            Name = "";
            Color = "";
        }

        // 생성자 오버로딩
        public Cat(string _name, string _color)
        {
            Name = _name;
            Color = _color;
        }

        public void Meow() {
            Console.WriteLine("야옹");
        }

        // 소멸자
        ~Cat()
        {
            Console.WriteLine($"{Name} : 잘가");
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            Cat kitty = new Cat();
            kitty.Name = "키티";
            kitty.Color = "하얀색";
            kitty.Meow();

            Cat nero = new Cat();
            nero.Name = "네로";
            nero.Color = "검정색";
            nero.Meow();

            Cat kitty2 = new Cat(_name:"키티2", "하얀색");
            kitty2.Meow();
            Console.WriteLine($"{kitty2.Name}, {kitty2.Color}");
        }
    }
}
