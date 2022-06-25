/** Author: Kent vejrup Madsen
  * Title: CommandParser
  * Description: 
  * Tags: 
  * License: MIT License 
    * (https://raw.githubusercontent.com/KentVejrupMadsen/SpecialisedStudyProject.Revised/main/LICENSE.md)
    * (https://opensource.org/licenses/MIT)
  */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SSPApplication.Interaction
{
    internal class CommandParser
    {
        public struct Option
        {
            public Option(string key, string[] value)
            {
                Key = key;
                Value = value;
            }

            public string Key
            {
                get;
            }

            public string[] Value
            {
                get;
            }
        }

        public CommandParser()
        {

        }

        public CommandParser(string[] args)
        {

        }

        private string command;

        private CommandIntrepeter intrepeter;

        public CommandIntrepeter Interpeter
        {
            get
            {
                if (intrepeter == null)
                {
                    intrepeter = new CommandIntrepeter();
                }

                return intrepeter;
            }

            set
            {
                intrepeter = value;
            }
        }

        public void parseLines(string[] arguments)
        {

        }

        public void parseLine(string argument)
        {

        }

    }
}
