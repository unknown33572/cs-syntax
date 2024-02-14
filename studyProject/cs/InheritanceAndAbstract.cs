using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studyProject
{
    public interface IStandard { void Run(); }

    public abstract class KS
    {
        public abstract void Back(); // 추상 메서드
        public void Left() => Console.WriteLine("좌회전");
    }

    public partial class Machine : KS
    {
        public override void Back() => Console.WriteLine("후진"); // 추상 메서드 구현
    }

    public partial class Machine : KS // partial 클래스는 추상 메서드를 강제로 구현하지 않아도 됨
    {
        public void Right() => Console.WriteLine("우회전"); // 일반 메서드
    }

    public sealed class Car : Machine, IStandard // sealed 키워드는 상속을 막는다. 그래서 이 클래스는 더 이상 상속할 수 없음
    {
        public void Run() => Console.WriteLine("전진");
    }

  class InheritanceAndAbstract
  {
      static void Main()
      {
          Car car = new Car();
          car.Run();
          car.Left();
          car.Right();
          car.Back();
      }
  }
}
