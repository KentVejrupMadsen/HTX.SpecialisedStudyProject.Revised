/** Author: Kent vejrup Madsen
  * Title: Application
  * Description: 
  * Tags: 
  * License: MIT License 
    * (https://raw.githubusercontent.com/KentVejrupMadsen/SpecialisedStudyProject.Revised/main/LICENSE.md)
    * (https://opensource.org/licenses/MIT)
  */
using SSPApplication.Interaction;
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
            this.ArgumentParser.parseLines( args );
        }

        // Variables
        private string[] arguments;

        private CommandParser argumentParser;
        private bool continueApplication = false;

        private static Application applicationFramework;


        // Accessors
        public static Application ApplicationFramework
        {
            get
            {
                if( Application.applicationFramework == null )
                {
                    Application.applicationFramework = new Application();
                }

                return Application.applicationFramework;
            }
            set
            {
                Application.applicationFramework = value;
            }
        }

        public bool ContinueApplication
        {
            get
            {
                return this.continueApplication;
            }

            set
            {
                this.continueApplication = value;
            }
        }


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
