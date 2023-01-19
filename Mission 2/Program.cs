//Author: Austin Cox
using System;

namespace Mission_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // intro to program
            Console.WriteLine("Welcome to the dice throwing simulator!" + Environment.NewLine + "How many dice would you like to roll?: ");
            
            //set variable to number of rolls desired
            int rollNum = Convert.ToInt32(Console.ReadLine());

            //instantiate random number variable and array to hold roll counts
            Random r = new Random();

            int[] blah = new int[12];

            //fill array with 0's
            for (int i = 0; i < 12; i++)
            {
                blah[i] = 0;
            }


            //roll the two dice x amount of times (where x equals desired number of rolls) and increment array number counts accordingly
            for (int i = 0; i < rollNum; i++)
            {
                int roll = r.Next(6);
                int roll2 = r.Next(6);

                blah[roll + roll2]++;

            }

            //display results and calculate histogram (I just KNOW there is a better way to do this with a loop but I got this to work and didn't have time to fiddle with it more)
            Console.WriteLine("DICE ROLLING SIMULATION RESULTS" + Environment.NewLine + "Each '*' represents 1 % of the total number of rolls." + Environment.NewLine + "Total number of rolls = " + rollNum);

            for (int i = 0; i < 11; i++)
            {
                float value = (blah[i]);
                float percent = (value / rollNum) ;
                string starz = " ";
                
                if (percent < 0.005)
                {
                    starz = " ";
                }
                else if (percent < 0.015)
                {
                    starz = "*";
                }
                else if (percent < 0.025)
                {
                    starz = "**";
                }

                else if (percent < 0.035)
                {
                    starz = "***";
                }

                else if (percent < 0.045)
                {
                    starz = "****";
                }

                else if (percent < 0.055)
                {
                    starz = "*****";
                }

                else if (percent < 0.065)
                {
                    starz = "******";
                }

                else if (percent < 0.075)
                {
                    starz = "*******";
                }

                else if (percent < 0.085)
                {
                    starz = "********";
                }

                else if (percent < 0.095)
                {
                    starz = "*********";
                }

                else if (percent < 0.105)
                {
                    starz = "**********";
                }

                else if (percent < 0.115)
                {
                    starz = "***********";
                }

                else if (percent < 0.125)
                {
                    starz = "************";
                }

                else if (percent < 0.135)
                {
                    starz = "*************";
                }

                else if (percent < 0.145)
                {
                    starz = "**************";
                }

                else if (percent < 0.155)
                {
                    starz = "***************";
                }

                else if (percent < 0.165)
                {
                    starz = "****************";
                }

                else if (percent < 0.175)
                {
                    starz = "*****************";
                }

                else if (percent < 0.185)
                {
                    starz = "******************";
                }

                else if (percent < 0.195)
                {
                    starz = "*******************";
                }

                else if (percent < 0.205)
                {
                    starz = "********************";
                }

                else if (percent < 0.215)
                {
                    starz = "*********************";
                }

                else if (percent < 0.225)
                {
                    starz = "**********************";
                }

                else if (percent < 0.235)
                {
                    starz = "***********************";
                }

                else if (percent < 0.245)
                {
                    starz = "************************";
                }

                else if (percent < 0.255)
                {
                    starz = "*************************";
                }

                else if (percent < 0.265)
                {
                    starz = "**************************";
                }

                else if (percent < 0.275)
                {
                    starz = "***************************";
                }

                else if (percent < 0.285)
                {
                    starz = "****************************";
                }

                else if (percent < 0.295)
                {
                    starz = "*****************************";
                }

                else if (percent < 0.305)
                {
                    starz = "******************************";
                }

                else if (percent < 0.315)
                {
                    starz = "*******************************";
                }

                else if (percent < 0.325)
                {
                    starz = "********************************";
                }

                else if (percent < 0.335)
                {
                    starz = "*********************************";
                }

                else if (percent < 0.345)
                {
                    starz = "**********************************";
                }

                else if (percent < 0.355)
                {
                    starz = "***********************************";
                }
                else
                {
                    starz = "************************************";
                }

                Console.WriteLine((i + 2) + ": " + starz);

            



            }
            Console.WriteLine("Thank you for choosing the dice throwing simulator. Goodbye!");

        }
    }
}
