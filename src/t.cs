namespace RandomSmth;

public class Test
{
    public bool Enabled
    {
	
	get
	{
		
		return true;

		
	}
    }

    public bool Enabled2
    {
        get 
        { 
	    System.Console.WriteLine("Getting the enabled flag.");


	    return false; 
        }
    }
}
