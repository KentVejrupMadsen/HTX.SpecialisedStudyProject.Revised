/** Author: Kent vejrup Madsen
  * Title: Program
  * Description: 
  * Tags: 
  * License: MIT License 
    * (https://raw.githubusercontent.com/KentVejrupMadsen/SpecialisedStudyProject.Revised/main/LICENSE.md)
    * (https://opensource.org/licenses/MIT)
  */
namespace SSPApplication
{
    internal class Program
    {
        public static void Main( String[] arguments )
        {
            Application app = new Application( arguments );
            Application.ApplicationFramework = app;

            Application.ApplicationFramework.run();
        }
    }
}