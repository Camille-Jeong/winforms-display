using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI_Play
{
    static class DataManager
    {
        static public Data data;

        static private string[] ParseStatus(string status)
        {
            string[] value = new string[2];
            string[] spstring = status.Split('\n');
            foreach (string _string in spstring)
            {
                string[] _spstring = _string.Split(':');
                if ("audio".Equals(_spstring[0].Trim()))
                {
                    value[0] = _spstring[1].Trim();
                    value[1] = _spstring[2].Trim();
                }
            }
            return value;
        }

        static private string[] ParseCurrentSong(string status)
        {

            string[] value = new string[4];
            string[] spstring = status.Split('\n');
            foreach (string _string in spstring)
            {
                string[] _spstring = _string.Split(':');
                if ("Artist".Equals(_spstring[0].Trim()))
                    value[0] = _spstring[1].Trim();
                else if ("Title".Equals(_spstring[0].Trim()))
                    value[1] = _spstring[1].Trim();
                else if ("file".Equals(_spstring[0].Trim()))
                {
                    string[] _file = _spstring[1].Split('.');
                    value[2] = _file[1].Trim();
                }
                else if ("Time".Equals(_spstring[0].Trim()))
                    value[3] = _spstring[1].Trim();

            }
            return value;
        }

        static public Data GetData()
        {
            data = new Data();

            string status;
            status = SocketManager.Comunicate("status");
            string[] _temp = ParseStatus(status);
            data.SamplingRate = _temp[0];
            data.BitWidth = _temp[1];

            string currentsong;
            currentsong = SocketManager.Comunicate("currentsong");
            _temp = ParseCurrentSong(currentsong);
            data.Artist = _temp[0];
            data.Title = _temp[1];
            data.FileFormat = _temp[2];
            data.Length = Convert.ToInt32(_temp[3]);

            return data;
        }
    }
}
