
using System;
public class DbCommand 
{
    public string cmd { get; set; }
    public DbCommand(DbConnection dbConnection, string command)
    {
        if(dbConnection.Equals(null))
        {
            throw new InvalidOperationException("Connection Not Open");
        }
        
        if(string.IsNullOrEmpty(command))
        {
            throw new InvalidOperationException("Invalid Query String");
        }
        else{
            this.cmd = command;
            Console.WriteLine("Query for {} executed successfully", dbConnection.ConnectionString);
        }

    }
}