/*          Documentation
 *     Purpose:         A program to show the usage of three apps where names have been garnered from the user and their usage randomly determined by the program (up to 100% maximum)
 *     Input:           3 app names as strings
 *     Process:         calculate the usages for the apps
 *     Output:          3 app names, and their usage percentages
 *     Author:          Hoyden L'Heureux
 *     Date:            2020 JAN 21
 * 
 */

/*         INSTRUCTIONS
 *    Create a program that will ask the user for 3 different app names and then show the apps with random usages for their given apps.
 *    
 *    Sample Data:
 *    
 *    Please enter app name #1: Camera 
 *    Please enter app name #2: Messaging
 *    Please enter app name #3: Solitaire
 *    
 *           Phone Battery Usage
 *    ----------------------------------
 *      #1:     Camera              23%
 *      #2:     Messaging           38%
 *      #3:     Solitaire           19%
 *    ----------------------------------
 *            Percentage Remaining: 20%
 * 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneUsage_v1
{
    class Program
    {
        static void Main(string[] args)
        {
            //declare variables
            const int MAXIMUM_BATTERY_LEVEL = 100;
            Random keygen = new Random();
            string appName1, appName2, appName3,underline = new string('-',36);
            int app1Usage = 0, app2Usage = 0, app3Usage = 0,currentBatteryLevel = MAXIMUM_BATTERY_LEVEL;

            //prompt for the app names and store into their respective variables
            Console.Write("Please enter app name #1: ");
            appName1 = Console.ReadLine();

            Console.Write("Please enter app name #2: ");
            appName2 = Console.ReadLine();

            Console.Write("Please enter app name #3: ");
            appName3 = Console.ReadLine();

            //calculate the usage for app 1
            app1Usage = keygen.Next(0, currentBatteryLevel);

            //deplete the battery per app 1 usage
            currentBatteryLevel -= app1Usage;

            //determine app 2 usage (if not already depleted)
            if(currentBatteryLevel>0)
            {
                app2Usage = keygen.Next(0, currentBatteryLevel);
                currentBatteryLevel -= app2Usage;
            }

            //determine app 3 usage (if not already depleted)
            if(currentBatteryLevel>0)
            {
                app3Usage = keygen.Next(0, currentBatteryLevel);
                currentBatteryLevel -= app3Usage;
            }

            //display the results
            Console.WriteLine($"\n\n{"",7}Phone Battery Usage\n{underline}\n{"1:",5}{"",5}{appName1,-19}{"",3}{app1Usage}%\n{"2:",5}{"",5}{appName2,-19}{"",3}{app2Usage}%\n{"3:",5}{"",5}{appName3,-19}{"",3}{app3Usage}%\n{underline}\n{"Percentage Remaining:",31} {currentBatteryLevel,2}%");

            Console.ReadLine();
        }//End of Main(string[])
    }
}
