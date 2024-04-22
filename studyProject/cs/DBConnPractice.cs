using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studyProject.cs
{
    internal class DBConnPractice
    {
        static void Main(string[] args)
        {

            
            Console.Write("시작");

            using (OdbcConnection connection = new OdbcConnection(connectionString))
            {
                try
                {
                    // 데이터베이스 연결 열기
                    connection.Open();
                    Console.WriteLine("데이터베이스에 성공적으로 연결되었습니다.");

                    // SQL 쿼리
                    //string sql = "SELECT * FROM EDU.PRACTICE_USER";  // your_table은 조회할 데이터베이스 테이블 이름

                    string sql2 = "select * from EDU.PRACTICE_USER where USER_ID = ?";

                    // ODBC 커맨드 객체 생성
                    //OdbcCommand command = new OdbcCommand(sql, connection);

                    //// 쿼리 실행 및 결과 읽기
                    //using (OdbcDataReader reader = command.ExecuteReader())
                    //{
                    //    while (reader.Read())
                    //    {
                    //        Console.WriteLine(reader["USERNAME"].ToString()); // 'column_name'은 읽고 싶은 열의 이름
                    //    }
                    //}

                    Console.WriteLine("찾고 싶은 ID를 입력하세요.");
                    string userID = Console.ReadLine();

                    using (OdbcCommand command2 = new OdbcCommand(sql2, connection))
                    {
                        command2.Parameters.Add("@USERNAME", OdbcType.VarChar).Value = userID;

                        using (OdbcDataReader reader = command2.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Console.WriteLine(reader["EMAIL"].ToString()); // 'column_name'은 읽고 싶은 열의 이름
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }
        }
    }
}
