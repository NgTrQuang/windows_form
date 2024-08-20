using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_SinhVien
{
    internal class MyPublics
    {
        public static SqlConnection conMyConnection;
        public static string strMSSV, strLop, strQuyenSD, strHK, strNK;
        public static void ConnectDatabase()
        {
            string strConn = "Server = QUANG-PST\\QUANG; Database = QL_SinhVien; Integrated Security = false; UID = TN207User; PWD = TN207User";
            // Có thể sử dụng địa chỉ IP hoặc tên máy cho thông tin Server
            conMyConnection = new SqlConnection();
            conMyConnection.ConnectionString = strConn;
            try
            {
                conMyConnection.Open();
            }
            catch (Exception)
            {
            }
        }
        public static string MaHoaPassword(string strPassword)
        {
            string strTemp1, strTemp2;
            int i, n;
            strTemp1 = "";
            strTemp2 = "";
            n = strPassword.Length;
            for (i = 0; i < n; i = i + 2)
            {
                strTemp1 += strPassword[i];
                if (n > i + 1)
                    strTemp2 += strPassword[i + 1];
            }
            return (strTemp1 + strTemp2);
        }
        public static void OpenData(string strSelect, DataTable dtTable) 
        { 
            SqlDataAdapter daDataAdapter = new SqlDataAdapter();
            try 
            { 
                if (conMyConnection.State == ConnectionState.Closed) 
                    conMyConnection.Open();
                daDataAdapter.SelectCommand = new SqlCommand(strSelect, conMyConnection);
                daDataAdapter.Fill(dtTable);
                conMyConnection.Close();
            } 
            catch (Exception)
            { 
            } 
        }
        public static bool TonTaiKhoaChinh(string strGiaTri, string strTenTruong, string strTable)
        {
            bool blnRessult = false; 
            try
            {
                string sqlSelect = "Select 1 From "+ strTable + " Where " + strTenTruong + "='" + strGiaTri + "'";
                if (conMyConnection.State == ConnectionState.Closed) 
                    conMyConnection.Open();
                SqlCommand cmdCommand = new SqlCommand(sqlSelect, conMyConnection);
                SqlDataReader drReader = cmdCommand.ExecuteReader();
                if (drReader.HasRows) 
                    blnRessult = true; 
                drReader.Close(); 
                conMyConnection.Close();
            }
            catch (Exception) 
            { 
            }
            return blnRessult;
        }
    }
}
