namespace TitheProgram.lib
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Data;
    using System.Data.OleDb;
    using TitheProgram.Models; 

    public class DataBaseLogicLayer
    {
        private string connectionString;

        public DataBaseLogicLayer(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public bool SetupDatabase()
        {
            using (OleDbConnection con = new OleDbConnection(this.connectionString))
            {
                con.Open();

                try
                {
                    using (OleDbCommand cmd = new OleDbCommand(
@"CREATE TABLE Members 
(id AUTOINCREMENT PRIMARY KEY, 
lastname VARCHAR, 
firstname VARCHAR, 
middleInitial VARCHAR, 
suffix VARCHAR, 
address VARCHAR, 
city VARCHAR, 
state VARCHAR, 
zip VARCHAR);

CREATE TABLE TitheRecords
(id AUTOINCREMENT PRIMARY KEY,
memberId INTEGER,
recordDate DATE,
paymentType INTEGER,
checkNumber VARCHAR,
amount CURRENCY,
recordType VARCHAR);", con))
                    {
                        cmd.ExecuteNonQuery();

                       
                        cmd.CommandText = "CREATE TABLE PaymentTypes (id int, typeName VarChar)";

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
        
        public string ReadTotalMembers()
        {
            using (OleDbConnection con = new OleDbConnection(this.connectionString))
            {
                con.Open();


                using (OleDbCommand cmd = new OleDbCommand("SELECT count(*) FROM Members", con))
                {
                    int count = System.Convert.ToInt32(cmd.ExecuteScalar());
                    return count.ToString();
                }
            }
        }

        public string ReadTotalDonationsForYear()
        {
            using (OleDbConnection con = new OleDbConnection(this.connectionString))
            {
                con.Open();


                using (OleDbCommand cmd = new OleDbCommand("SELECT count(*) FROM TitheRecord WHERE YEAR(TitheRecordDate) = YEAR(Now())", con))
                {
                    int count = System.Convert.ToInt32(cmd.ExecuteScalar());
                    return count.ToString();
                }
            }
        }

        public bool CreateMember(Member member)
        {
            using (OleDbConnection con = new OleDbConnection(this.connectionString))
            {
                con.Open();

                using (OleDbCommand cmd = new OleDbCommand("INSERT INTO Members (LastName, FirstName, MiddleInitial, Suffix, Address, City, State, Zip) VALUES "+
                    "(@LastName, @FirstName, @MiddleInitial, @Suffix, @Address, @City, @State, @Zip)", con))
                {
                    OleDbParameter lastName = new OleDbParameter("@LastName", OleDbType.VarChar);
                    lastName.Value = member.lastname;
                    cmd.Parameters.Add(lastName);

                    OleDbParameter firstName = new OleDbParameter("@FirstName", OleDbType.VarChar);
                    firstName.Value = member.firstname;
                    cmd.Parameters.Add(firstName);

                    OleDbParameter midInit = new OleDbParameter("@MiddleInitial", OleDbType.VarChar);
                    midInit.Value = member.middleInitial;
                    cmd.Parameters.Add(midInit);

                    OleDbParameter suffix = new OleDbParameter("@Suffix", OleDbType.VarChar);
                    suffix.Value = member.suffix;
                    cmd.Parameters.Add(suffix);

                    OleDbParameter address = new OleDbParameter("@Address", OleDbType.VarChar);
                    address.Value = member.address;
                    cmd.Parameters.Add(address);

                    OleDbParameter city = new OleDbParameter("@City", OleDbType.VarChar);
                    city.Value = member.city;
                    cmd.Parameters.Add(city);

                    OleDbParameter state = new OleDbParameter("@State", OleDbType.VarChar);
                    state.Value = member.state;
                    cmd.Parameters.Add(state);

                    OleDbParameter zip = new OleDbParameter("@Zip", OleDbType.VarChar);
                    zip.Value = member.zip;
                    cmd.Parameters.Add(zip);

                    int numRows = cmd.ExecuteNonQuery();

                    return numRows != 0;
                }
            }
        }

        public bool CreateTitheRecord(TitheRecord tithe)
        {
            using (OleDbConnection con = new OleDbConnection(this.connectionString))
            {
                con.Open();

                using (OleDbCommand cmd = new OleDbCommand("INSERT INTO TitheRecord (MemberID, TitheRecordDate, PaymentType, CheckNumber, RecordAmount, TitheType) VALUES " +
                    "(@TithRecordID, @MemberID, @TitheRecordDate, @PaymentType, @CheckNumber, @RecordAmount, @TitheType)", con))
                {
                    OleDbParameter memberId = new OleDbParameter("@MemberID", OleDbType.Integer);
                    memberId.Value = tithe.memberId;
                    cmd.Parameters.Add(memberId);

                    OleDbParameter recordDate = new OleDbParameter("@TitheRecordDate", OleDbType.Date);
                    recordDate.Value = tithe.recordDate;
                    cmd.Parameters.Add(recordDate);

                    OleDbParameter paymentType = new OleDbParameter("@PaymentType", OleDbType.Integer);
                    paymentType.Value = tithe.pamyentType;
                    cmd.Parameters.Add(paymentType);

                    OleDbParameter checkNum = new OleDbParameter("@CheckNumber", OleDbType.VarChar);
                    checkNum.Value = tithe.checkNum;
                    cmd.Parameters.Add(checkNum);

                    OleDbParameter amount = new OleDbParameter("@RecordAmount", OleDbType.Decimal);
                    amount.Value = tithe.amount;
                    cmd.Parameters.Add(amount);

                    OleDbParameter type = new OleDbParameter("@TitheType", OleDbType.VarChar);
                    type.Value = tithe.type;
                    cmd.Parameters.Add(type);

                    int numRows = cmd.ExecuteNonQuery();

                    return numRows != 0;
                }
            }
        }

        public List<Member> ReadAllMembers()
        {
            List<Member> members = new List<Member>();

            using (OleDbConnection con = new OleDbConnection(this.connectionString))
            {
                con.Open();

                using (OleDbCommand cmd = new OleDbCommand("SELECT id, lastname, firstname, middleInitial, suffix, address, city, state, zip FROM Members", con))
                {
                    var reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        Member member = new Member();
                        member.id = (int)reader.GetValue(0);
                        member.lastname = (string)reader.GetValue(1);
                        member.firstname = (string)reader.GetValue(2);
                        member.middleInitial = (string)reader.GetValue(3);
                        member.address = (string)reader.GetValue(4);
                        member.city = (string)reader.GetValue(5);
                        member.state = (string)reader.GetValue(6);
                        member.zip = (string)reader.GetValue(7);

                        members.Add(member);
                    }
                }
            }

            return members;
        }
    }
}
