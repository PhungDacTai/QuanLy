﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace QuanLy.DAL
{
  public  class Connection
    {
        //Son
        SqlConnection con;
        //1
        //2
        //3

        //quang
        //4

        //Quang 1123
        public SqlConnection getConnection()
        {
            string st = ConfigurationManager.ConnectionStrings["ManagerBook"].ToString();
            con = new SqlConnection(st);
            return con;
        }
        // update 6

        public DataTable LoadData(string sql)
        {
            // update 5
            getConnection().Open();
            SqlDataAdapter da = new SqlDataAdapter(sql,con);
            DataTable dtThAccount = new DataTable();
            da.Fill(dtThAccount);
            getConnection().Close();
            return dtThAccount;
            
        }



    }

}
