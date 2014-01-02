using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace CodingSample
{
    public partial class Form1 : Form
    {
        String file = @"people.csv";
        const float BMIMax = 30;
        const float BMIMin = 18.5f;

        public Form1()
        {
            InitializeComponent();
            
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void tallestButton_Click(object sender, EventArgs e)
        {
            string line;
            string[] words;
            string output = "";
            int tallest = 0;

            StreamReader inputStream = File.OpenText(file);
            inputStream.ReadLine();//Do skip over the Key on the first line of the file.
            while ((line = inputStream.ReadLine()) != null)//Then in the while loop interate until the end of the file to find the tallest value.
            {
                words = line.Split(',');

                if (Convert.ToInt16(words[5]) > tallest)
                {
                    tallest = Convert.ToInt16(words[5]);
                }
            }
            inputStream.Close();

            inputStream = File.OpenText(file);//Then we do it again in oreder to output all people with the value found.
            inputStream.ReadLine();
            while ((line = inputStream.ReadLine()) != null)
            {
                words = line.Split(',');

                if (Convert.ToInt16(words[5]) == tallest)
                {
                    output += line + "\n";//Add whoever has the tallest value to the string and place it on a new line.
                }
            }
            inputStream.Close();

            Output.Text = output;//Then out put the combined string of all the people sharing this value.
        }

        private void shortestButton_Click(object sender, EventArgs e)
        {
            string line;
            string[] words;
            string output = "";//This entire method works very like the tallest method
            int shortest = 1000;//Except shortest is initally a large value and we check if values are smaller than it.

            StreamReader inputStream = File.OpenText(file);
            inputStream.ReadLine();
            while ((line = inputStream.ReadLine()) != null)
            {
                words = line.Split(',');

                if (Convert.ToInt16(words[5]) < shortest)
                {
                    shortest = Convert.ToInt16(words[5]);
                }
            }
            inputStream.Close();

            inputStream = File.OpenText(file);
            inputStream.ReadLine();
            while ((line = inputStream.ReadLine()) != null)
            {
                words = line.Split(',');

                if (Convert.ToInt16(words[5]) == shortest)
                {
                    output += line + "\n";
                }
            }
            inputStream.Close();

            Output.Text = output;
        }

        private void youngestButton_Click(object sender, EventArgs e)
        {
            string line;
            string[] words;
            string[] date;
            string output = "";
            int[] age = {0,0,0};

            StreamReader inputStream = File.OpenText(file);
            inputStream.ReadLine();
            while ((line = inputStream.ReadLine()) != null)
            {
                words = line.Split(',');//We find the section with the date
                date = words[2].Split('/');//And split it into the values for days,months,years

                if (Convert.ToInt16(date[2]) > age[2])//We get the largest year
                {
                    age[2] = Convert.ToInt16(date[2]);
                }
            }
            inputStream.Close(); 
            
            inputStream = File.OpenText(file);
            inputStream.ReadLine();
            while ((line = inputStream.ReadLine()) != null)
            {
                words = line.Split(',');
                date = words[2].Split('/');

                if (Convert.ToInt16(date[2]) == age[2] && Convert.ToInt16(date[1]) > age[1])//And once we have the largest year we get the largest month
                {
                    age[1] = Convert.ToInt16(date[1]);
                }
            }
            inputStream.Close();

            inputStream = File.OpenText(file);
            inputStream.ReadLine();
            while ((line = inputStream.ReadLine()) != null)
            {
                words = line.Split(',');
                date = words[2].Split('/');

                if (Convert.ToInt16(date[2]) == age[2] && Convert.ToInt16(date[1]) == age[1] && Convert.ToInt16(date[0]) > age[0])//Eventually getting the largest day
                {
                    age[0] = Convert.ToInt16(date[0]);
                }
            }
            inputStream.Close();

            inputStream = File.OpenText(file);//Now that we have the most recent birth date we check again for the people born on that day
            inputStream.ReadLine();
            while ((line = inputStream.ReadLine()) != null)
            {
                words = line.Split(',');
                date = words[2].Split('/');

                if (Convert.ToInt16(date[2]) == age[2] &&
                    Convert.ToInt16(date[1]) == age[1] &&
                    Convert.ToInt16(date[0]) == age[0])
                {
                    output += line + "\n";
                }
            }
            inputStream.Close();

            Output.Text = output;
        }

        private void oldestButton_Click(object sender, EventArgs e)
        {
            string line;
            string[] words;
            string[] date;
            string output = "";
            int[] age = { 31, 12, 2014 };

            StreamReader inputStream = File.OpenText(file);
            inputStream.ReadLine();
            while ((line = inputStream.ReadLine()) != null)
            {
                words = line.Split(',');
                date = words[2].Split('/');

                if (Convert.ToInt16(date[2]) < age[2])
                {
                    age[2] = Convert.ToInt16(date[2]);
                }
            }
            inputStream.Close();

            inputStream = File.OpenText(file);
            inputStream.ReadLine();
            while ((line = inputStream.ReadLine()) != null)
            {
                words = line.Split(',');
                date = words[2].Split('/');

                if (Convert.ToInt16(date[2]) == age[2] && Convert.ToInt16(date[1]) < age[1])
                {
                    age[1] = Convert.ToInt16(date[1]);
                }
            }
            inputStream.Close();

            inputStream = File.OpenText(file);
            inputStream.ReadLine();
            while ((line = inputStream.ReadLine()) != null)
            {
                words = line.Split(',');
                date = words[2].Split('/');

                if (Convert.ToInt16(date[2]) == age[2] && Convert.ToInt16(date[1]) == age[1] && Convert.ToInt16(date[0]) < age[0])
                {
                    age[0] = Convert.ToInt16(date[0]);
                }
            }
            inputStream.Close();

            inputStream = File.OpenText(file);
            inputStream.ReadLine();
            while ((line = inputStream.ReadLine()) != null)
            {
                words = line.Split(',');
                date = words[2].Split('/');

                if (Convert.ToInt16(date[2]) == age[2] &&
                    Convert.ToInt16(date[1]) == age[1] &&
                    Convert.ToInt16(date[0]) == age[0])
                {
                    output += line + "\n";
                }
            }
            inputStream.Close();

            Output.Text = output;
        }

        private void meanAgeButton_Click(object sender, EventArgs e)
        {
            string line;
            string[] words;
            string[] date;
            float ageTotal = 0;
            int counter = 0;
            int currentYear = 2014;

            StreamReader inputStream = File.OpenText(file);
            inputStream.ReadLine();
            while ((line = inputStream.ReadLine()) != null)
            {
                words = line.Split(',');
                date = words[2].Split('/');

                ageTotal += currentYear - Convert.ToInt16(date[2]);//We add the users age in years to the total
                ageTotal += Convert.ToInt16(date[1]) / 12;         //Divide their month by twelve because its value is twelve times smaller than a year
                ageTotal += Convert.ToInt16(date[0]) / 365;        //Do the same for the days whoose values are 365 times smaller than that of a year.
                counter++;                                         //Increase the counter
            }

            Output.Text = "The Mean age of all applicants is " + ageTotal/counter; //And divide it the total of all the people by the total number to get the mean age.

            inputStream.Close();
        }

        private void healthButton_Click(object sender, EventArgs e)
        {
            string line;
            string[] words;
            int overWeight = 0;
            int underWeight = 0;
            int healthyWeight = 0;

            StreamReader inputStream = File.OpenText(file);
            inputStream.ReadLine();
            while ((line = inputStream.ReadLine()) != null)
            {
                words = line.Split(',');
                float bmi = (Convert.ToInt16(words[6]) / ((Convert.ToInt16(words[5]) / 100) * (Convert.ToInt16(words[5]) / 100)));
                if (bmi > BMIMax)
                {
                    overWeight++;
                }
                else if (bmi < BMIMin)
                {
                    underWeight++;
                }
                else
                {
                    healthyWeight++;
                }
            }

            Output.Text = "The number of Over Weight people is " + overWeight + "\n" +
                          "The number of Under Weight people is " + underWeight + "\n"+
                          "The number of Healthy Weight people is " + healthyWeight;

            inputStream.Close();
        }

        private void stateButton_Click(object sender, EventArgs e)
        {
            string line;
            string[] words;

            int overWeightState = 0;
            int underWeightState = 0;
            int healthyWeightState = 0;

            string outputState1 = "";
            string outputState2 = "";
            string outputState3 = "";

            Dictionary<string, int> overWeightDictionary = new Dictionary<string, int>();
            Dictionary<string, int> underWeightDictionary = new Dictionary<string, int>();
            Dictionary<string, int> healthyWeightDictionary = new Dictionary<string, int>();

            StreamReader inputStream = File.OpenText(file);
            inputStream.ReadLine();
            while ((line = inputStream.ReadLine()) != null)
            {
                words = line.Split(',');
                if (overWeightDictionary.ContainsKey(words[3])){ }//If the string is already in the dictionary we do nothing
                else
                {
                    overWeightDictionary.Add(words[3], 0);//Otherwise we add the state to our dictionary and give it a number of 0
                }

                if (underWeightDictionary.ContainsKey(words[3])){}//And repeat for each of the three dictionary types
                else
                {
                    underWeightDictionary.Add(words[3], 0);
                }

                if (healthyWeightDictionary.ContainsKey(words[3])){}
                else
                {
                    healthyWeightDictionary.Add(words[3], 0);
                }
            }
            
            inputStream = File.OpenText(file);
            inputStream.ReadLine();
            while ((line = inputStream.ReadLine()) != null)
            {
                words = line.Split(',');

                float bmi = (Convert.ToInt16(words[6]) / ((Convert.ToInt16(words[5]) / 100) * (Convert.ToInt16(words[5]) / 100)));//like before we get the BMI to determine if each person is overweight etc
                if (bmi > BMIMax)
                {
                    overWeightDictionary[words[3]] += 1;//Except this time we add them to the dictionary with the corrisponding state
                }
                else if (bmi < BMIMin)
                {
                    underWeightDictionary[words[3]] += 1;
                }
                else
                {
                    healthyWeightDictionary[words[3]] += 1;
                }
            }

            foreach (var i in overWeightDictionary.Keys)
            {
                if (overWeightDictionary[i] > overWeightState)
                {
                    overWeightState = overWeightDictionary[i];//Like with the tallest we then find out which is the heaviest/lightest state.
                    outputState1 = i;
                }
            }
            foreach (var i in underWeightDictionary.Keys)
            {
                if (underWeightDictionary[i] > underWeightState)
                {
                    underWeightState = underWeightDictionary[i];//Repeat for each one
                    outputState2 = i;
                }
            }
            foreach (var i in healthyWeightDictionary.Keys)
            {
                if (healthyWeightDictionary[i] > healthyWeightState)
                {
                    healthyWeightState = healthyWeightDictionary[i];
                    outputState3 = i;
                }
            }

            //And then output
            Output.Text = "The state with the most overweight people is " + outputState1 + " with " + overWeightState + " overweight people\n" +
                          "The state with the most underweight people is " + outputState2 + " with " + underWeightState + " underweight people\n" +
                          "The state with the most healthyweight people is " + outputState3 + " with " + healthyWeightState + " healthyweight people\n";

            inputStream.Close();
        }

        private void weightLossButton_Click(object sender, EventArgs e)
        {
            string line;
            string[] words;
            float totalWeight = 0;
            float averageWeight = 0;
            float targetWeight = 0;
            float targetAverageWeight = 0;
            int count = 0;

            StreamReader inputStream = File.OpenText(file);
            inputStream.ReadLine();
            while ((line = inputStream.ReadLine()) != null)
            {
                words = line.Split(',');
                totalWeight += Convert.ToInt16(words[6]);//We will get the real average weight by adding up all the weights of all the people

                float bmi = (Convert.ToInt16(words[6]) / ((Convert.ToInt16(words[5]) / 100) * (Convert.ToInt16(words[5]) / 100)));
                if (bmi > BMIMax)
                {
                    targetWeight += BMIMax;//But if they are overweight or underweight then we add the max/min weight to the target weight
                }
                else if (bmi < BMIMin)
                {
                    targetWeight += BMIMin;
                }
                else
                {
                    targetWeight += Convert.ToInt16(words[6]);
                }
                count++;
            }

            averageWeight = totalWeight / count;//We calculate the average weight of all the people
            averageWeight = (averageWeight / 100) * 90;//But then we only get 90% of the people because that's all we need
            targetAverageWeight = targetWeight / count;//We also calcualte the target average weight that everyone should be.

            Output.Text = "The average weight loss needed for 90% of applicants to be healthy is " + (averageWeight - targetAverageWeight) + "Kg";
            inputStream.Close();
        }
    }
}
