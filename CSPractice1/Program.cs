using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSPractice1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //컨텍스트 키워드
            var abc = "Hello World";    //ok

            //한줄주석
            /* 여러줄
             주석*/
            /*** xml 주석 ***/

            //출력
            Console.WriteLine("Hello World");
            Console.Write("뉴라인X");

            //#1 12-3. 기본자료형
            //정수
            Console.WriteLine(52 + 4 - 1);
            //사칙연산자 = 산술연산자 = Arithmetic Operator
            //+ - * / %

            //실수(real number)
            Console.WriteLine(52.0);

            //문자(Character)
            Console.WriteLine('A');
            Console.WriteLine('가');

            //문자열(String)
            Console.WriteLine("Hello World");
            //이스케이프 문자
            Console.WriteLine("미\n\\림\t마\"고");

            //문자열 연결 연산자(Concatenations Operator)
            Console.WriteLine("Hello" + " " + "World");
            //문자열 인덱스 접근 []
            Console.WriteLine("Hello World"[4]);    //'o'
            Console.WriteLine("Hello World"[100]);  //예외발생

            //주의
            Console.WriteLine('가' + '힣');   //문자열 연결 연산자xx -> 덧셈연산자로 인식

            //논리(boolean)
            Console.WriteLine(true);
            Console.WriteLine(false);
            //비교연산자(Comparison Operator)
            //== !- > < >= <=
            //논리연산자(logical operator)
            //&&||!
            Console.WriteLine(!true);
            Console.WriteLine(true && false);
            Console.WriteLine(true || false);

            // #1 12-4 변수
            //변수(Variable)
            string name = "문자열 자료형";

            // #1 12-5. 복합대입 연산자
            //+= -= *= /= %=
            string output = "Hello"; ;
            output += "World";
            Console.WriteLine(output);

            // #1 12-6. 증감연산자
            int number = 10;
            Console.WriteLine(number++);    //10
            Console.WriteLine(++number);    //12
            Console.WriteLine(number--);    //12
            Console.WriteLine(--number);    //10

            // #1 12-8. var 키워드
            var varnumber = 20;
            //var abc;    //에러, 반드시 초기화해줘야함

            // #1 12-9 입력
            string input = Console.ReadLine();
            Console.WriteLine(input);

            // #1 12-10 자료형변환
            //중요함

            // #2 13-1. if 조건문
            bool condition = true;
            if (condition) {
                //true
            }
            else if(condition) {
                //true2
            }
            else {
                //other
            }

            // #2 13-2 switch 조건문
            int v = 0;
            switch (v)
            {
                case 0:
                    //0
                    break;
                default:
                    //other
                    break;
            }

            // #2 13-6. 삼항연산자
            Console.WriteLine(number % 2 = 0 ? "짝수" : "홀수");

            // #3 14-1. 반복문과 배열
            int[] intArray = new int[100];
            Console.WriteLine(intArray[99]);

            // #3 14-2. while 반복문
            int i = 0;
            int[] intArray2 = { 52, 273, 32 };
            while(i<intArray2.Length)
            {
                Console.WriteLine(intArray2[i]);
                i++;    //탈출을 위한 변수
            }








        }
    }
}
