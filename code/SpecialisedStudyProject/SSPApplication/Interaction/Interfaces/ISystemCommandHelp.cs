/** Author: Kent vejrup Madsen
  * Title: CommandIntrepeter
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
    interface ISystemCommandHelp
    {
        /**
         * 
         */
        public abstract string HelpShort();


        /**
         * 
         */
        public abstract string HelpDescriptive();
    }
}
