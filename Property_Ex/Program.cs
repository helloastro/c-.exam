using System;

namespace Property_Ex
{
    class Profile
    {
        private string name;
        private int height;

        // property
        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public int Height
        {
            get
            {
                return height;
            }

            set
            {
                height = value;
            }
        }
    }

    // 자동구현 프로퍼티
    class Profile2
    {
        public string Name { get; set; }
        public int Height { get; set; }
    }

    // 값검사
    class Profile3
    {
        private int height;

        public string Name { get; set; }
        public int Height
        {
            get { return height; }
            set
            {
                if (value < 0 )
                {
                    throw new Exception("키는 0보다 작을 수 없습니다.");
                }
                height = value;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Profile profile = new Profile();
            profile.Name = "홍길동";
            profile.Height = 180;
            Console.WriteLine($"{profile.Name}, {profile.Height}");
            Console.WriteLine();

            // 자동구현
            Profile2 profile2 = new Profile2() { Name="홍길동", Height=180 };
            Console.WriteLine($"{profile2.Name}, {profile2.Height}");
            Console.WriteLine();

            // 값검사.(예외처리)
            try
            {
                Profile3 profile3 = new Profile3() { Name = "홍길동", Height = -180 };
                Console.WriteLine($"{profile3.Name}, {profile3.Height}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine();
        }
    }
}
