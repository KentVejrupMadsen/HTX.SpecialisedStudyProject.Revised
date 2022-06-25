/** Author: Kent vejrup Madsen
  * Title: SystemCommandInterface
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


namespace SSPApplication.Interfaces
{
    internal interface ISystemCommandProcess
    {
        /**
         * Command to be executed.
         */
        public abstract void ExecuteCommand();


        /**
         * Returns a set of lines to be written as output to the system
         */
        public abstract string[] Output();


        /**
         * 
         */
        public abstract bool IsImplemented();

        /**
         * 
         */
        public abstract bool IsDeprecated();


        /**
         * 
         */
        public abstract bool IsOperation();
    }
}
