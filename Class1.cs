using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace bills

{
    class Class1
    {
        SqlConnection con = new SqlConnection("Data Source=LAPTOP-UFUH8S2R;Initial Catalog=master;Integrated Security=True");
        SqlCommand cmd;
        SqlDataAdapter adpt;
        SqlCommandBuilder cmdb;
        DataSet ds;
        public int add_data(string date, int customerID, int bill)
        {//insert into GUI values(1001,'hgg','ghhdhd');
            string str = "insert into bill values(" + date + ",'" + customerID + "','" + bill + "')";
            cmd = new SqlCommand(str, con);
            con.Open();
            int no = cmd.ExecuteNonQuery();                 //CONNECTED ARTITECTURE
            con.Close();
            return (no);

        }
        public DataSet Show_data()             //STORE SHOW DATA IN DATASET
        {
            string str = "select * from bill";
            adpt = new SqlDataAdapter(str, con);
            cmdb = new SqlCommandBuilder(adpt);                      //DISCONNECTED ARTITECTURE
            ds = new DataSet();            //DS IS OBJ OF DATASET          
            adpt.Fill(ds);
            return (ds);

        }
        public int update_data(string date, int customerID, int bill)
        {//insert into GUI values(1001,'hgg','ghhdhd');
            string str = "update  bill set date='" + date + "',bill='" + bill + "'where customerID=" + customerID;
            cmd = new SqlCommand(str, con);
            con.Open();
            int no = cmd.ExecuteNonQuery();                 //CONNECTED ARTITECTURE
            con.Close();
            return (no);
        }
        public DataSet Show_id_data(int customerID)             //STORE SHOW DATA IN DATASET
        {
            string str = "select * from bill where customerID=" + customerID;
            adpt = new SqlDataAdapter(str, con);
            cmdb = new SqlCommandBuilder(adpt);                      //DISCONNECTED ARTITECTURE
            ds = new DataSet();            //DS IS OBJ OF DATASET          
            adpt.Fill(ds);
            return (ds);

        }
        public int delete_data(int customerID)
        {
            string str = "delete from bill where customerID=" + customerID;
            cmd = new SqlCommand(str, con);
            con.Open();
            int no = cmd.ExecuteNonQuery();                 //CONNECTED ARTITECTURE
            con.Close();
            return (no);
        }
    }
}
