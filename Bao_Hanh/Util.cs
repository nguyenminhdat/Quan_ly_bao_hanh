using System;
using System.Data;
using System.Data.SqlClient;

public class Util
{
    public static string connectionstring = "";
    public static SqlConnection conn = new SqlConnection(@"Data Source =.; Initial Catalog = QuanLyBaoHanh; Integrated Security = True");

    public static bool connectSQL()
    {
        try
        {
            if (conn == null || conn.State != ConnectionState.Open)
            {
                conn.Open();
            }
            return true;
        }
        catch (Exception ex)
        {
            return false;
        }
    }

    public static void disconnectSQL()
    {
        try
        {
            if (conn != null && conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
        }
        catch (Exception) { }
    }

    public static int RunSql(string query)
    {
        connectSQL();
        SqlCommand cmd = new SqlCommand(query, conn);
        try
        {
            int a = cmd.ExecuteNonQuery();
            return a;

        }
        catch (Exception ex) { return -1; }
        finally
        {
            disconnectSQL();
        }

    }
    public static DataTable GetData(string sql)
    {
        try
        {
            connectSQL();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            da.Fill(dt);
            return dt;
        }
        catch (Exception ex) { return null; }
        finally
        {
            disconnectSQL();
        }

    }
    public static DataTable GetData(string sql, SqlParameter[] param)
    {
        try
        {
            connectSQL();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            da.Fill(dt);
            return dt;
        }
        catch (Exception ex) { return null; }
        finally
        {
            disconnectSQL();
        }

    }
    public static DataTable GetStoredData(string sql)
    {
        try
        {
            connectSQL();
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            return dt;
        }
        catch (Exception ex) { return null; }
        finally
        {
            disconnectSQL();
        }

    }
    public static DataTable GetStoredData(string sql, SqlParameter[] param)
    {
        try
        {
            connectSQL();
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand(sql,conn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            return dt;
        }
        catch (Exception ex) { return null; }
        finally
        {
            disconnectSQL();
        }

    }
}
