/*Caio Guilherme Ferreira da Silva and Sanya Saddi
 *AI Clustering Project
 *Version 1.0
 *Decription: This program is a headache searcher, it will ask the user a series of questions to determine the type of headache they are experiencing.
 */
using System;

class Program
{
    static void Main()
    {
        // Welcome message
        Console.WriteLine("Hello, Welcome Mind Heathier!");
        Console.WriteLine("Do you have a headache? (yes/no)");
        string headacheChk = GetValidInput();
        // Ask the user a series of questions to determine the type of headache they are experiencing
        if (headacheChk == "yes")
        {
            Console.WriteLine("Check your blood pressure, do you have high blood pressure? (yes/no)");
            string highBloodPressureChk = GetValidInput();
            // Check if the user has high blood pressure
            if (highBloodPressureChk == "no")
            {               
                Console.WriteLine("Have you experienced head trauma in the last 7 days? (yes/no)");
                string headTraumaChk = GetValidInput();
                // Check if the user has experienced head trauma
                if (headTraumaChk == "no")
                {
                    Console.WriteLine("Have you undergone spinal surgery in the last 72 hours? (yes/no)");
                    string spinalSurgeryChk = GetValidInput();
                    // Check if the user has undergone spinal surgery
                    if (spinalSurgeryChk == "no")
                    {
                        // Sanya's code
                        Console.Write("Do you have itchy or watery eyes and/or sneezing? (yes/no) ");
                        string sinusChk = GetValidInput();
                        Console.WriteLine("Is the pain and pressure felt in the cheeks, nose, brow, or forehead region? (yes/no) ");
                        string allergyChk = GetValidInput();
                        // Check if the user has sinus or allergy symptoms
                        if (sinusChk == "yes" || allergyChk == "yes")
                        {
                            Console.WriteLine("You have a Sinus Headache. It is recommended to take ibuprofen and nasal reliefs (such as nasal sprays). If it lasts more than a week, visit your doctor.");
                        }
                        else
                        {
                            //Check if the user has Ice Pick symptoms
                            Console.Write("Are you feeling any sharpened, intense, and stabbing pain in targeted area(s)? (yes/no) ");
                            string icePickChk = GetValidInput();

                            if (icePickChk == "yes")
                            {
                                Console.WriteLine("You have an Ice Pick headache. Rest and take ibuprofen. If pain lasts several days, visit your local GP.");
                            }
                            else
                            {
                                //Check if the user has Tension symptoms
                                Console.Write("Are you feeling pressure or tightness on your head? When affected areas are touched, does it hurt? (yes/no) ");
                                string tensionChk = GetValidInput();

                                if (tensionChk == "yes")
                                {
                                    Console.WriteLine("This is a Tension headache. Typically, there isn’t much to worry about. Take medication prescribed by your GP or visit the ER if the pain is terrible.");
                                }
                                else
                                {
                                    //Check if the user has Migraine symptoms
                                    Console.Write("Are you experiencing any sensitivity to light, smell, or sound? (yes/no) ");
                                    string migraineS1Chk = GetValidInput();
                                    Console.Write("Do you have blurred vision and/or confusion? (yes/no) ");
                                    string migraineS2Chk = GetValidInput();

                                    if (migraineS1Chk == "yes" || migraineS2Chk == "yes")
                                    {
                                        Console.WriteLine("You have a Migraine. Visit your doctor for appropriate medication. If this headache is the most painful you've experienced, go to the ER.");
                                    }
                                    else
                                    {
                                        Console.WriteLine("You seem to have a general headache, it’s best to rest and monitor symptoms.");
                                    }
                                }
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("You are having a Post-Surgical headache. Take some ibuprofen. If the pain persists, see the doctor.");
                    }
                }
                else
                {
                    Console.WriteLine("You are having a Post-Traumatic headache. Take some ibuprofen. If the pain persists, see the doctor.");
                }
            }
            else
            {
                Console.WriteLine("You are having a Hypertension headache. Take your high blood pressure medication and relax for a few minutes until the pain fades away.");
            }
        }
        else//If the user does not have a headache
        {
            Console.WriteLine("You are not having a headache. Have a nice day!");
        }

        // Pause for 10 seconds
        System.Threading.Thread.Sleep(10000);
    }
    /// <summary>Check the user is Yes or No independent is lower or upper case</summary>
    /// <returns>Return the user input</returns>
    static string GetValidInput()
    {
        string input;
        while (true)//Infinite loop until the user enters a valid input
        {
            input = Console.ReadLine().Trim().ToLower();//Trim removes any leading or trailing white spaces
            if (input == "yes" || input == "no")
            {
                return input;
            }
            //Check if the user entered a short form of yes
            if (input == "y")
            {
                input = "yes";
                return input;
            }
            //Check if the user entered a short form of no
            if (input == "n")
            {
                input = "no";
                return input;
            }   
            else
            {
                Console.WriteLine("Invalid input. Please enter 'yes' or 'no'.");
            }
        }
    }
}
