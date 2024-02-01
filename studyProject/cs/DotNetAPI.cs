using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace studyProject
{
    class DotNetAPI
    {
        static void Main()
        {
            DateTime targetDate = new DateTime(2023, 12, 20);

            // 해당 월의 첫 번째 날
            DateTime firstDayOfMonth = new DateTime(targetDate.Year, targetDate.Month, 1);

            // 첫 주의 시작 요일 설정 (예: 일요일)
            DayOfWeek startOfWeek = DayOfWeek.Sunday;

            // 첫 번째 날과 첫 주의 시작 요일 사이의 차이 계산
            int daysOffset = (firstDayOfMonth.DayOfWeek - startOfWeek + 7) % 7;

            // 첫 주의 시작 날짜
            DateTime firstWeekStart = firstDayOfMonth.AddDays(-daysOffset);

            // 주차 계산
            int weekNumber = (int)((targetDate - firstWeekStart).TotalDays / 7) + 1;

            Console.WriteLine($"Year: {targetDate.Year}, Month: {targetDate.Month}, Week number in month: {weekNumber}");

            Console.WriteLine($"{targetDate.Year}년도 {targetDate.Month}월 {weekNumber}주차 로또번호는 : ");

            Random random = new Random();
            int[] arr = new int[6];
            int temp = 0;
            for(int i = 0; i < 6; i++)
            {
                temp = random.Next(45) + 1; // 0부터 시작하니까 +1
                bool flag = false;
                if(i > 0 && i < 6)
                {
                    for(int j = 0; j <= i; j++) // i가 돈 만큼 j 돌림
                    {
                        if(arr[j] == temp)
                        {
                            flag = true;
                        }
                    }
                }
                if(flag)
                {
                    --i;
                }
                else
                {
                    arr[i] = temp;
                }
            }
            foreach(int result in arr)
            {
                Console.WriteLine(result);
            }
            Console.WriteLine();
        }
    }
}
