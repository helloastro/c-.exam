using System;

namespace Class_Ex
{
    class Cat
    {
        public static int count = 0; // 생성된 객체수. 정적변수

        public string Name;
        public string Color;

        // 기본 생성자
        public Cat()
        {
            this.Name = "";
            this.Color = "";
            ++count;
        }

        // 생성자 오버로딩
        public Cat(String _name, String _color)
        {
            this.Name = _name;
            this.Color = _color;
            ++count;
        }

        public void Meow()
        {
            Console.WriteLine($"{Name}({Color}) : 야옹");
        }

        // 깊은복사
        public Cat DeepCopy()
        {
            Cat newCopy = new Cat();
            newCopy.Name = this.Name;
            newCopy.Color = this.Color;

            return newCopy; // 새로운 객체의 레퍼런스 반환
        }

        // 접근한정자
        private string hair = ""; // 털길이

        public string GetHair()
        {
            return this.hair;
        }

        public void SetHair(string _hair)
        {
           this.hair = _hair;
        }

        // 소멸자
        ~Cat()
        {
            Console.WriteLine($"{this.Name} : 안녕.");
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
            nero.Color = "검은색";
            nero.Meow();

            Cat kitty2 = new Cat(_name:"키티2", "하얀색");
            kitty2.Meow();
            Console.WriteLine($"{kitty2.Name}, {kitty2.Color}");

            // static
            Console.WriteLine($"생성된 객체수: {Cat.count}");

            // 얕은 복사
            Cat kitty3 = kitty2;
            kitty3.Name = "키티3";
            Console.WriteLine($"{kitty3.Name}, {kitty2.Name}");

            // 깊은 복사
            Cat kitty4 = kitty2.DeepCopy();
            kitty4.Name = "키티4";
            Console.WriteLine($"{kitty4.Name}, {kitty2.Name}");

            // 접근 한정자
            kitty4.SetHair("털이 긴");
            Console.WriteLine($"{kitty4.GetHair() }");
        }
    }
}
