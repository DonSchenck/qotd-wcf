using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace qotdwcf
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Qotd : IQotd
    {
        public string GetQuote()
        {
            string q;
            string[] quotes = new string[6];
            quotes[0] = "40 is the old age of youth, while 50 is the youth of old age. -- Victor Hugo";
            quotes[1] = "Knowledge is power. –- Francis Bacon";
            quotes[2] = "Life is really simple, but we insist on making it complicated. -- Confucius";
            quotes[3] = "This above all, to thine own self be true. -- William Shakespeare";
            quotes[4] = "Live your dreams. -– Les Brown";
            quotes[5] = "Doo be doo be dooo. -- Frank Sinatra";
            Random rnd = new Random();
            int i = rnd.Next(0, 6);
            return quotes[i];
        }
    }
}
