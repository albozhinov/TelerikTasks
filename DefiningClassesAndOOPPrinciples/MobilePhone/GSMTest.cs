using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MobilePhone
{
    class GSMTest
    {
        public List<GSM> allgsm;

        public GSMTest()
        {
            this.allgsm = new List<GSM>();

            for (int i = 0; i < 3; i++)
            {
                var inputLine = Console.ReadLine().Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

                var model = inputLine[0];
                var manufacturer = inputLine[1];

                GSM currGSM = new GSM(model, manufacturer);

                allgsm.Add(currGSM);
            }
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            foreach (var gsm in allgsm)
            {
                sb.AppendLine(gsm.ToString());
            }
            return sb.ToString();
        }
    }
}
