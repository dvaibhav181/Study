using System;

public class SqlConnection : DbConnection
{
    public SqlConnection(string connection) : base(connection)
    {
        
    }

    public override void Close()
    {
        Console.WriteLine("SQL Connection Closed.");
        //throw new System.NotImplementedException();
    }

    public override void Open()
    {
        Console.WriteLine("SQL Connection to {0} is successful !!!", this.ConnectionString);
        //throw new System.NotImplementedException();
    }
}