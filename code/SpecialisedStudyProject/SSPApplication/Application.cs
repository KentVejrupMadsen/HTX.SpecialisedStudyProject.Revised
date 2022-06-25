/** Author: Kent vejrup Madsen
  * Title: Application
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


namespace SSPApplication
{
    internal class Application
    {
        // Constructors
        public Application()
        {

        }

        public Application( String[] args )
        {

        }

        // Variables
        private string[] arguments = null;

        private CommandParser argumentParser = null;

        // Accessors
        public String[] Arguments
        {
            get
            {
                return this.arguments;
            }

            set
            {
                this.arguments = value;
            }
        }

        public CommandParser ArgumentParser
        {
            get
            {
                if( argumentParser == null )
                {
                    ArgumentParser = new CommandParser();
                }

                return this.argumentParser;
            }

            set
            {
                this.argumentParser = value;
            }
        }

        // Code
        public void initialise()
        {

        }

        public void execute()
        {

        }

        public void gc()
        {

        }

        // Execution
        public void run()
        {
            this.initialise();
            this.execute();
            this.gc();
        }
    }
}
