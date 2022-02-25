using System;

public abstract class DbConnection
{
    public string ConnectionString { get; set; }
    public TimeSpan TimeOut { get; set; }

    public DbConnection(string connection)
    {
        if(string.IsNullOrEmpty(connection))
        {
            throw new ArgumentException();
        }
        else{
            this.ConnectionString = connection;
        }
    }

    public abstract void Open();
    public abstract void Close();
}