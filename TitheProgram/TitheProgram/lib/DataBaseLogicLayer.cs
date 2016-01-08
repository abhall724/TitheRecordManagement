// -----------------------------------------------------------------------
// <copyright file="DataBaseLogicLayer.cs" company="Microsoft">
// TODO: Update copyright text.
// </copyright>
// -----------------------------------------------------------------------

namespace TitheProgram.lib
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Data.SqlClient; 

    public class DataBaseLogicLayer
    {
        private string connectionString;

        public DataBaseLogicLayer(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public bool SetupDatabase()
        {
            using (SqlConnection con = new SqlConnection(this.connectionString))
            {
                con.Open();

                try
                {
                    using (SqlCommand cmd = new SqlCommand("CREATE TABLE Members (MemberID int, LastName VarChar, FirstName VarChar, MiddleInitial VarChar, Suffix VarChar, Address VarChar, City VarChar, State VarChar, Zip VarChar)", con))
                    {
                        cmd.ExecuteNonQuery();

                        cmd.CommandText = "CREATE TABLE TitheRecord (TithRecordID int, MemberID int, TitheRecordDate Date, PaymentType int, CheckNumber VarChar, RecordAmount Decimal, TitheType varChar)";

                        cmd.ExecuteNonQuery();

                        cmd.CommandText = "CREATE TABLE PaymentTypes (PaymentTypeId int, TypeName VarChar)";

                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    return false;
                }
            }
            return true;
        }
        
    }
}
