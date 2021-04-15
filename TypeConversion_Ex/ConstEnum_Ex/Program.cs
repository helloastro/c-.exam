using System;

namespace ConstEnum_Ex
{
    class Program
    {
        enum DialogResult { YES, NO, OK, CANCEL } //열거형 형식 선언
        enum DialogResult2 { YES = 10, NO, OK = 50, CANCEL }

        static void Main(string[] args)
        {
            /* 상수 */
            const int MAX_INT = 1000000;
            const int MIN_INT = -1000000;

            /* 열거형 */
            Console.WriteLine((int)DialogResult.YES); // 0
            Console.WriteLine((int)DialogResult.CANCEL); // 3

            DialogResult result = DialogResult.YES;
            Console.WriteLine(result == DialogResult.YES);
            Console.WriteLine(result == DialogResult.CANCEL);

            Console.WriteLine((int)DialogResult2.YES); // 10
            Console.WriteLine((int)DialogResult2.NO); // 11
            Console.WriteLine((int)DialogResult2.CANCEL); // 51
            
            /* enum 연산(flg) 테스트 */

        }
    }
}
