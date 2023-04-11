internal class Cars
{
    private string _model;
    public string Model
    {
        get { return _model; }
        set
        {
            if (string.IsNullOrEmpty(value) || value.Length > 10)
            {
                Console.WriteLine("Duzgun daxil edin");
            }
            else
            {
                _model = value;
            }
        }
    }

    private int _topspeed;
    public int Topspeed { get{return _topspeed;}set{if (value<10 || value>1000)
	{
                Console.WriteLine("Duzgun daxil edin,topspeed min 10 max 1000 ola biler");
	}else
	{
             _topspeed = value;
	}}}

    private double _engine;
    public double Engine { get{return _engine;} set{if (value<0.3||value>10)
	{
                        Console.WriteLine("Duzgun daxil edin,engine min 0.3 max 10 ola biler");

	}else
	{
             _engine = value;
	}} }

    private double _km;
    public double Km { get{return _km;} set{if( value<0)
	{
                                Console.WriteLine("Duzgun daxil edin,km minimum 0 ola biler");

	}else
	{
             _km = value;
	}} }

    private int _hp;
    public int Hp { get{ return _hp; } set{if (value<50||value>1000)
	{
                         Console.WriteLine("Duzgun daxil edin,hp min 50 max 1000 ola biler");

	}else
	{
             _hp=value;
	}} }

}

