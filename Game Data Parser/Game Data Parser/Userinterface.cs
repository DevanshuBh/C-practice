using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Game_Data_Parser
{
    public class Userinterface
    {
        private readonly userinteraction _userinteraction;
        private readonly jsondata _jsondata;
        public Userinterface(userinteraction userinteraction , jsondata jsondata)
        {
            _userinteraction = userinteraction;
            _jsondata = jsondata;
        }
        public void run()
        {
            _userinteraction.user_input();
            string filename = _userinteraction.UserInput;
            _jsondata.read(filename);
            
            
        }
    }
}
