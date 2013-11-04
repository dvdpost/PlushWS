using System;

namespace CountryLookupProj
{
	/// <summary>
	/// Summary description for CountryLookupTest.
	/// </summary>
	class CountryLookupTest
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main(string[] args)
		{
            //CountryLookup cl = new CountryLookup(@"C:\winnt\system32\GeoIP-106_20020801.dat"); // D:\GeoIP\GeoIP.dat
            CountryLookup cl = new CountryLookup(@"D:\GeoIP\GeoIP.dat\GeoIP.dat");
			Console.WriteLine(cl.lookupCountryCode("151.38.39.114"));
			Console.WriteLine(cl.lookupCountryName("151.38.39.114"));
			Console.WriteLine(cl.lookupCountryName("12.25.205.51"));
            string iinput = Console.ReadLine();
            string ooutput = cl.lookupCountryCode(iinput);
            //Console.WriteLine(cl.lookupCountryName(iinput));
            Console.WriteLine(ooutput);
            Console.ReadLine();  

		}
	}
}
