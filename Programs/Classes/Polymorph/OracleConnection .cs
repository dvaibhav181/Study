using System;

public class OracleConnection : DbConnection
{
    public OracleConnection(string connection) : base(connection)
    {
    }

    public override void Close()
    {
        Console.WriteLine("Oracle Connection Closed.");
        //throw new System.NotImplementedException();
    }

    public override void Open()
    {
        Console.WriteLine("Oracle Connection to {0} is successful !!!", this.ConnectionString);
        //throw new System.NotImplementedException();
    }
}
