using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studyProject.TestCase
{
  internal class DateTimeUtility
  {
    ///<summary>
    ///날짜와 시간관련 유틸리티 클래스
    ///</summary>
      public static String ShowTimeOrDate(object dt, String format = "yyyy/MM/dd")
      {
        if(dt != null && DateTime.TryParse(dt.ToString(), out DateTime dateTime))
        {
          if(dateTime.Date == DateTime.Now.Date)
          {
            return dateTime.ToString("HH:mm:ss");
          }
          else
          {
            return dateTime.ToString(format);
          }
        }
        else
        {
          return "";
        }
      }
  }
}
