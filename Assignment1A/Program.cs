using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetApplication
{
    class Pet
    {
        private string name; //pets name
        private int age; //pets age
        private bool isFemale; //true if girl false if boy

    
    

    public void DisplayPetInfo()
        {
            string textOut = "Name: " + name + " Age: " + age; //name and age printout are now called textOut
            Console.WriteLine();
            Console.WriteLine(textOut);

            if
            (isFemale == true) //check value of bool
            Console.WriteLine(""+ name +" is a good girl!");
            if
            (isFemale == false) //check value of bool
                Console.WriteLine("" + name + " is a good boy!");
            

        }//display

        public void ReadAndSavePetData()
        {
            Console.Write("What is the name of your pet?  "); //asks name, leaves cursor and space to write
            name = Console.ReadLine(); //sets name value

            Console.Write("How old is " + name + "?  ");
            string textValue = Console.ReadLine(); //read response to age q
            age = int.Parse(textValue); //convert string to number

            Console.Write("Is "+name+" female? Y/N ");
            char response = char.Parse(Console.ReadLine()); //what characters does the answer contain
            if ((response == 'y') || (response == 'Y')) // y or Y means true
                { isFemale = true; }
            else
                { isFemale = false; }

        }//readandsave

        public void Start()

        {
            Console.WriteLine(); //gives blank line
            Console.WriteLine("Greetings from a Pet object!"); //greetings from this project
            Console.WriteLine(); //gives blank line


        }//start


    class PetOwnerMain
        {
    static void Main(string[] args)
            {

                Pet petObj = new Pet(); //create an object of class Pet

                petObj.Start(); //use object Pet
                petObj.ReadAndSavePetData(); //progress
                Console.WriteLine(); //spacing
                Console.WriteLine("**********************************"); //division spacing
                petObj.DisplayPetInfo(); //progress
                Console.WriteLine(); //spacing
                Console.WriteLine("**********************************"); //division spacing
                Console.WriteLine("Press enter to exit");//exit dialogue
                Console.ReadLine( ); //message stays on screen until key pressed
            }//main
        }//class


    }
}//namespace

