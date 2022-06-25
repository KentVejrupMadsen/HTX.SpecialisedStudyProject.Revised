using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Persistence.dataset
{
    interface IDatasetLazyLoading
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
        public abstract string[] ObjectAttributes();


        /** 
         *  
         */
        public abstract string LoadContent();

        /**
         * 
         */
        public abstract bool IsDone();
    }
}