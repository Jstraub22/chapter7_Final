using System;
using System.Collections.Generic;
using System.Text;

namespace chapter7_Final
{
    class Cohort
    {

        Dictionary<string, string> RocketLeague = new Dictionary<string, string>();
        Dictionary<string, string> R6 = new Dictionary<string, string>();
        Dictionary<string, string> Batman = new Dictionary<string, string>();
        Dictionary<string, string> Xbox = new Dictionary<string, string>();
        Dictionary<string, string> Pc = new Dictionary<string, string>();
        private string JacobStraub_Jacob_3_3_2020 { get; set; }




        public void DisplayGameInfo()
        {
            Console.WriteLine("RocketLeague");

            Console.WriteLine(" R6");

            Console.WriteLine(" Batman");

            Console.WriteLine( "Pc");

            Console.WriteLine(" Xbox");

        }

        public static implicit operator Cohort(Rocketleague v)
        {
            throw new NotImplementedException();
        }
    }
}
