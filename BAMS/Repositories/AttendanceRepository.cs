//using System.Data;
//using System;
//using Microsoft.Data.SqlClient;
//using BAMS.Forms;

//namespace BAMS.Repositories
//{
//    internal class AttendanceRepository
//    {
//        private readonly string connectionString =
//            "Server=localhost;Database=BAMS_DB;User Id=eijeizs;Password=aspiringrapper3;TrustServerCertificate=True;";

//        public DataTable GetAttendanceLogs(DateTime fromDate, DateTime toDate, string employeeName = "")
//        {
//            using (SqlConnection conn = new SqlConnection(connectionString))
//            {
//                string query = @"
//                    SELECT 
//                        A.AttendanceId AS ID,
//                        U.FullName,
//                        A.Day,

//                        FORMAT(A.AM_In, 'hh:mm tt') AS AM_In,
//                        FORMAT(A.AM_Out, 'hh:mm tt') AS AM_Out,
//                        FORMAT(A.PM_In, 'hh:mm tt') AS PM_In,
//                        FORMAT(A.PM_Out, 'hh:mm tt') AS PM_Out,

//                        A.Remarks

//                    FROM Attendance A
//                    INNER JOIN Users U ON A.UserId = U.Id

//                    WHERE A.Day BETWEEN @FromDate AND @ToDate
//                ";

//                if (!string.IsNullOrWhiteSpace(employeeName))
//                {
//                    query += " AND U.FullName LIKE @EmployeeName";
//                }

//                query += " ORDER BY A.Day DESC";

//                using (SqlCommand cmd = new SqlCommand(query, conn))
//                {
//                    cmd.Parameters.Add("@FromDate", SqlDbType.Date).Value = fromDate.Date;
//                    cmd.Parameters.Add("@ToDate", SqlDbType.Date).Value = toDate.Date;

//                    if (!string.IsNullOrWhiteSpace(employeeName))
//                    {
//                        cmd.Parameters.Add("@EmployeeName", SqlDbType.VarChar).Value = "%" + employeeName + "%";
//                    }

//                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
//                    {
//                        DataTable dt = new DataTable();
//                        adapter.Fill(dt);
//                        return dt;
//                    }
//                }
//            }
//        }

//        public void AddAttendance(
//            int userId,
//            DateTime day,
//            DateTime amIn,
//            DateTime amOut,
//            DateTime pmIn,
//            DateTime pmOut,
//            string remarks)
//        {
//            using (SqlConnection conn = new SqlConnection(connectionString))
//            {
//                string query = @"
//                    INSERT INTO Attendance
//                    (UserId, Day, AM_In, AM_Out, PM_In, PM_Out, Remarks)
//                    VALUES
//                    (@UserId, @Day, @AMIn, @AMOut, @PMIn, @PMOut, @Remarks)
//                ";

//                using (SqlCommand cmd = new SqlCommand(query, conn))
//                {
//                    cmd.Parameters.Add("@UserId", SqlDbType.Int).Value = userId;
//                    cmd.Parameters.Add("@Day", SqlDbType.Date).Value = day.Date;
//                    cmd.Parameters.Add("@AMIn", SqlDbType.DateTime).Value = amIn;
//                    cmd.Parameters.Add("@AMOut", SqlDbType.DateTime).Value = amOut;
//                    cmd.Parameters.Add("@PMIn", SqlDbType.DateTime).Value = pmIn;
//                    cmd.Parameters.Add("@PMOut", SqlDbType.DateTime).Value = pmOut;
//                    cmd.Parameters.Add("@Remarks", SqlDbType.VarChar).Value = remarks ?? "";

//                    conn.Open();
//                    cmd.ExecuteNonQuery();
//                }
//            }
//        }

//        public DataTable GetEmployees()
//        {
//            using (SqlConnection conn = new SqlConnection(connectionString))
//            {
//                string query = "SELECT Id, FullName FROM Users ORDER BY FullName";

//                using (SqlDataAdapter adapter = new SqlDataAdapter(query, conn))
//                {
//                    DataTable dt = new DataTable();
//                    adapter.Fill(dt);
//                    return dt;
//                }
//            }
//        }

//        //private void LoadEmployees()
//        //{
//        //    AttendanceRepository repo = new AttendanceRepository();

//        //    DataTable dt = repo.GetEmployees();

//        //    cmbEmployee.Datasource = dt;
//        //    cmbEmployee.DisplayMember = "FullName";
//        //    cmbEmployee.ValueMember = "Id";
//        //}

//        //public AddAttendanceForm()
//        //{
//        //    LoadEmployees();
//        //}
//    }
//}

using System;
using System.Data;
using System.Data.SqlClient;

namespace BAMS.Repositories
{
    public class AttendanceRepository
    {
        private string connectionString =
            @"Data Source=MSI;
              Initial Catalog=BAM;
              Integrated Security=True";

        public DataTable GetAttendanceLogs(DateTime from, DateTime to, string name, string role)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"
                SELECT 
                    a.AttendanceId,
                    u.FullName,
                    u.Position,
                    a.Day,
                    a.AM_In,
                    a.AM_Out,
                    a.PM_In,
                    a.PM_Out,
                    a.Undertime,
                    a.Overtime,
                    a.TotalHours,
                    a.Remarks
                FROM Attendance a
                INNER JOIN Users u ON a.UserId = u.Id
                WHERE a.Day BETWEEN @From AND @To
                AND (@Name = '' OR u.FullName LIKE '%' + @Name + '%')
                AND (@Role = 'All' OR u.Position = @Role)
                ORDER BY a.Day DESC";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@From", from.Date);
                cmd.Parameters.AddWithValue("@To", to.Date);
                cmd.Parameters.AddWithValue("@Name", name ?? "");
                cmd.Parameters.AddWithValue("@Role", role ?? "All");

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                return dt;
            }
        }

        public void UpdateComputedHours(int attendanceId, double undertime, double overtime, double totalHours)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"
                UPDATE Attendance
                SET Undertime = @UT,
                    Overtime = @OT,
                    TotalHours = @TH
                WHERE AttendanceId = @Id";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@UT", undertime);
                cmd.Parameters.AddWithValue("@OT", overtime);
                cmd.Parameters.AddWithValue("@TH", totalHours);
                cmd.Parameters.AddWithValue("@Id", attendanceId);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}