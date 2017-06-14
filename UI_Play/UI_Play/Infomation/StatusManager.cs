using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI_Play
{
    class StatusManager
    {
        static public Status status;

        static private string[] ParseStatus(string data)
        {
            string[] value = new string[3];

            string[] spstring = data.Split('\n');
            foreach(string _string in spstring)
            {
                string[] _spstring = _string.Split(':');
                if ("songid".Equals(_spstring[0].Trim()))
                    value[0] = _spstring[1].Trim();
                else if ("time".Equals(_spstring[0].Trim()))
                    value[1] = _spstring[1].Trim();
                else if ("state".Equals(_spstring[0].Trim()))
                    value[2] = _spstring[1].Trim();
            }

            return value;
        }

        static public Status GetStatus()
        {
            status = new Status();

            string data = SocketManager.Comunicate("status");
            string[] value = ParseStatus(data);

            status.SongID = Convert.ToInt32(value[0]);
            status.Time = Convert.ToInt32(value[1]);
            status.PP = value[2];

            return status;
        }
    }
}
