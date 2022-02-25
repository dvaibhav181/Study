using System;
public class StopWatch
{
    private DateTime _start;
    private DateTime _stop;
    public TimeSpan duration;
    private Boolean isRunning;

    // public StopWatch()
    // {
    //     _start = new DateTime();
    //     _stop = new DateTime();
    // }
    public void Start()
    {
        if(isRunning)
        {
            throw new InvalidOperationException();
        }
        isRunning = true;
        _start = DateTime.Now;
    }

    public void Stop()
    {
        if(!isRunning)
        {
            throw new InvalidOperationException();
        }
        _stop = DateTime.Now;
        isRunning = false;
    }

    public TimeSpan Duration()
    {
        if(isRunning)
        {
           duration = DateTime.Now - _start; 
        }
        else{
            duration = _stop - _start;
        }
        
        return duration;
    }
}