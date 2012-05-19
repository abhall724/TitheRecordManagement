using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using ADOX;
using ADODB;
using System.IO;
using System.Windows.Forms;

namespace TitheProgram
{
    class titheFile
    {
        

        
        //private titheDatabase mDatabase;
       

        public titheFile()
        {

        }

       public bool TitheDirectory()
       {
           if (Directory.Exists("C:\\TitheProgram"))
           {
               return true;
           }
           else
           {
               var result = MessageBox.Show("Directory does not exist! Create Directory?", "Create Directory!", MessageBoxButtons.OKCancel);

               if (result == DialogResult.OK)
               {
                   try
                   {
                       Directory.CreateDirectory("C:\\TitheProgram");
                       return true;
                   }
                   catch (Exception ex)
                   {
                       MessageBox.Show(ex.Message, "Error!");
                       return false;
                   }
               }
               else
               {
                   return false;
               }
           }
       }

       public bool fileExist()
       {
           if (File.Exists("C:\\TitheProgram\\tithe.accdb"))
           {
               return true;
           }
           else
           {
               return false;
           }
       }

       /*
        * This method doesn't work. Corrupts database files.
        * 
        * public bool CreateTitheFile()
       {
           string myConnection = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" +filename+ ";";
           ADOX.Catalog cat = new ADOX.Catalog();
           ADOX.Table memberTable = new ADOX.Table();
           ADOX.Table recordTable = new ADOX.Table();
           memberTable.Name = "Members";
           memberTable.Columns.Append("MemberID", ADOX.DataTypeEnum.adVarChar);
           memberTable.Columns.Append("LastName", ADOX.DataTypeEnum.adVarChar);
           memberTable.Columns.Append("FirstName", ADOX.DataTypeEnum.adVarChar);
           memberTable.Columns.Append("MiddleInitial", ADOX.DataTypeEnum.adVarChar);
           memberTable.Columns.Append("Suffix", ADOX.DataTypeEnum.adVarChar);
           memberTable.Columns.Append("Address", ADOX.DataTypeEnum.adVarChar);
           memberTable.Columns.Append("City", ADOX.DataTypeEnum.adVarChar);
           memberTable.Columns.Append("State", ADOX.DataTypeEnum.adVarChar);
           memberTable.Columns.Append("Zip", ADOX.DataTypeEnum.adVarChar);
           //memberTable.Keys.Append("MemberID", KeyTypeEnum.adKeyPrimary);
           recordTable.Name = "TitheRecord";
           recordTable.Columns.Append("TitheRecordID", ADOX.DataTypeEnum.adSmallInt);
           recordTable.Columns.Append("MemberID", ADOX.DataTypeEnum.adVarChar);
           recordTable.Columns.Append("TitheRecordDate", ADOX.DataTypeEnum.adDate);
           recordTable.Columns.Append("Check(YesOrNo)", ADOX.DataTypeEnum.adBoolean);
           recordTable.Columns.Append("CheckNumber", ADOX.DataTypeEnum.adVarChar);
           recordTable.Columns.Append("RecordAmount", ADOX.DataTypeEnum.adDecimal);
           recordTable.Columns.Append("Cash(YesOrNO)", ADOX.DataTypeEnum.adBoolean);
           recordTable.Columns.Append("TitheType", ADOX.DataTypeEnum.adVarChar);
           //recordTable.Keys.Append("TitheRecordID", KeyTypeEnum.adKeyPrimary);
           //recordTable.Keys.Append("MemberID", KeyTypeEnum.adKeyForeign);

           try
           {
               cat.Create(myConnection);
               cat.Tables.Append(memberTable);
               cat.Tables.Append(recordTable);
               ADODB.Connection con = cat.ActiveConnection as ADODB.Connection;
               if (con != null)
                   con.Close();
               cat = null;
               return true;
               
           }
           catch (Exception ex)
           {
               MessageBox.Show(ex.Message);
               return false;
           }

           
       }*/
    }
}
