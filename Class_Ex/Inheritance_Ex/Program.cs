using System;

namespace Inheritance_Ex
{
    class Base
    {
        public Base()
        {
            Console.WriteLine("부모 생성자");
        }

        public void Method()
        {
            Console.WriteLine("부모 메서드");
        }

        public virtual void Method2()
        {
            Console.WriteLine("부모 메서드2");
        }

        ~Base()
        {
            Console.WriteLine("부모 소멸자");
        }

    }

    class Child: Base
    {
        public Child()
        {
            Console.WriteLine("자식 생성자");
        }

        public void ChildMethod()
        {
            Console.WriteLine("자식 메서드.");
        }

        ~Child()
        {
            Console.WriteLine("자식 소멸자");
        }
    }

    class Child2: Base
    {
        public Child2()
        {
            Console.WriteLine("자식2 생성자");
        }

        public void ChildMethod()
        {
            Console.WriteLine("자식2 메서드.");
        }

        public override void Method2() // 부모 메서드를 재정의. 부모 메서드 virtual
        {
            Console.WriteLine("자식2 메서드2.");
        }

        // 메서드 숨기기
        public new void Method()
        {
            Console.WriteLine("자식2 부모 메서드 숨기기.");
        }

        ~Child2()
        {
            Console.WriteLine("자식2 소멸자");
        }

    }
    
    class Program
    {
        static void Method(Base _base)
        {
            _base.Method2();
        }

        static void Main(string[] args)
        {
            Child child = new Child();
            child.ChildMethod();
            child.Method();

            Child2 child2 = new Child2();
            child2.ChildMethod();
            child2.Method();
            child2.Method2();

            //class 데이터타입
            Base child3 = new Child2();
            child3.Method();  // 부모
            child3.Method2(); // 자식 overriding

            ((Child2)child3).ChildMethod();
            ((Child2)child3).Method();


            Method(child2);
            Method(child);

        }
    }
}
