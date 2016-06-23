using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class Employee
    {
        /// <summary>
        /// 員工編號
        /// </summary>
        public int EmployeeID { get; set; }

        /// <summary>
        /// 員工名稱
        /// </summary>
        public string  FirstName { get; set; }

        /// <summary>
        /// 員工姓氏
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// 職稱
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// 到職日
        /// </summary>
        public DateTime HireDate { get; set; }

        /// <summary>
        /// 稱呼
        /// </summary>
        public string TitleOfCourtesy { get; set; }

        /// <summary>
        /// 生日
        /// </summary>
        public DateTime BirthDate { get; set; }

        public List<string> getTitle(WebApplication2.Models.Employee)
        {
            SqlDataReader reader;
            List<string> list = new List<string>(); 
            String select = "SELECT DISTINCT [Title] FROM [HR].[Employees]";
            using (SqlConnection conn = new SqlConnection()) {
                conn.Open();
                SqlCommand cmd = new SqlCommand(select, conn);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    list= (List<string>)reader["Title"];
                }
                conn.Close();	//關閉資料庫的連結
            }


            return list;
        }

    }
}