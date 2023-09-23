using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InicijalnoPonavljanje(2.dio)1
{
    class Biljka
    {
    	}

    	class Stablo : Biljka
    	{
        	bool opadajuListovi;
        	public bool OpadajuListovi { get => opadajuListovi; set => opadajuListovi = value; }
        	public Stablo(bool opadajuListovi1)
        	{
            	opadajuListovi = opadajuListovi1;
        	}
    	}
    	class Cvijet : Biljka
    	{

    	}
    	class Crnogoricno : Stablo
    	{
        	bool _opadajuListovi;
        	public Crnogoricno(bool opadajuListovi1) : base(opadajuListovi1)
        	{
            	_opadajuListovi = opadajuListovi1;

        	}
        	public override string ToString()
        	{
            	return "Opadaju listovi = " + _opadajuListovi;
        	}
    	}

    class Bijelogoricno : Stablo
    {
        bool _opadajuListovi;

        public Bijelogoricno(bool opadajuListovi1) : base(opadajuListovi1)
        {
            _opadajuListovi = opadajuListovi1;
        }

        public override string ToString()
        {
            return "Opadaju listovi = " + _opadajuListovi;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Crnogoricno Bor = new Crnogoricno(false);
            Bijelogoricno Hrast = new Bijelogoricno(true);

            Console.WriteLine("Bor: " + Bor.ToString());
            Console.WriteLine("Hrast: " + Hrast.ToString());

            Console.ReadLine();
        }
    }
}