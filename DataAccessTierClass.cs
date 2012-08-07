    using System;
    using System.Windows.Forms;
    using System.Data.OleDb;
    using System.Data;
    using System.Drawing;
    using System.Collections;
    using System.ComponentModel;
    
    namespace WpfApplication3
   {
       /// <summary>
       /// Summary description for DataAccessClass.
       /// </summary>
       public class DataAccessTierClass
       {
        
           public OleDbConnection    con;
           public OleDbDataAdapter   dAdapter;
           public DataSet                dSet;     
           public string conString=@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=..\\..\\Database2.sdf";   
           
           /*-------------------------------------------------------------------------
          * public method 
          * Overloaded     : no
          * Parameters     : no
          * Return value       : bool (true or false)
          * Purpose            : creates a connection to the database,a DataAdapter,
           *                         a DataSet and returns true if all ok otherwise false
           *-------------------------------------------------------------------------*/
           public bool fnGetDataConnection()
           {   
             try {  
                con =new OleDbConnection(conString);         
                dAdapter=new OleDbDataAdapter("select * from Dictionaries", con);
                dSet=new DataSet(); 
                //refreshes rows in the DataSet            
                dAdapter.Fill(dSet,"Dictionaries");
             }catch(Exception ex) {
                   MessageBox.Show("Error : "+ex.Message);
                   //connectection failed
                   return false;
             }//try-catch     
             //connection ok!
             return true;
           } 
   
       }//class
   }//namespace
