/** Author: Kent vejrup Madsen
  * Title: InteractiveConsole
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


namespace Persistence.dataset
{
    interface IDatasetLoad
    {

        /**
         * 
         */
        public abstract string ObjectName();

        /**
         * 
         */
        public abstract string ObjectType();


        /**
         * 
         */
        public abstract string[][] ObjectAttributes();
        
        /**
         * 
         */
        public abstract string[] ObjectKeyAttribute( String key );


        /** 
         *  
         */
        public abstract string LoadContent();
    }
}
