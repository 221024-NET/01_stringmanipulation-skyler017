using System;

namespace StringManipulationChallenge
{
    public class Program
    {
        static void Main(string[] args)
        {
            string userInputString; //this will hold your users message
            int elementNum;         //this will hold the element number within the messsage that your user indicates
            char char1;             //this will hold the char value that your user wants to search for in the message.
            string fName;           //this will hold the users first name
            string lName;           //this will hold the users last name
            string userFullName;    //this will hold the users full name;
            
            //
            //
            //implement the required code here and within the methods below.
            //
            //

            /* #01  */
            int numbers;
            string letters;

            /* #02  */
            //userInputString = Console.ReadLine();

            /*  #03  */
            Console.WriteLine("Please enter your message and press enter");

            /*  #04  */
            userInputString = Console.ReadLine();

            /*  #05  */
            letters = userInputString;

            /*  #06  */
            Console.WriteLine("Please enter a number LESS THAN the length of your string and press enter");

            /*  #07 #08  */
            userInputString = Console.ReadLine();
            numbers = Int32.Parse(userInputString);
            elementNum = numbers;

            /*  #09  */
            StringToUpper(letters);
            StringToLower(letters);
            StringTrim(letters);
            StringSubstring(letters,numbers);
            SearchChar(letters,'c');
            ConcatNames(letters, letters);

            /*  #10  */
            Console.WriteLine(StringToUpper(letters));
            Console.WriteLine(StringToLower(letters));
            Console.WriteLine(StringTrim(letters));
            Console.WriteLine(StringSubstring(letters,numbers));
            Console.WriteLine(SearchChar(letters,'f'));
            Console.WriteLine(ConcatNames(letters, letters));
            
            /*  #11  */
            char c;

            /*  #12  */
            Console.WriteLine("For which character should I search in your original message?");
            userInputString = Console.ReadLine();

            /*  #13  */
            c = userInputString.ToCharArray(0,1)[0];
            char1 = c;

            /*  #14  */
            Console.WriteLine(SearchChar(letters,c));

            /*  #15  */
            Console.WriteLine("Please enter your first name.");
            fName = Console.ReadLine();

            /*  #16  */
            Console.WriteLine("Please enter your last name.");
            lName = Console.ReadLine();

            /*  #17  */
            Console.WriteLine(ConcatNames(fName,lName));

        } // end of main()

        // This method has one string parameter. 
        // It will:
        // 1) change the string to all upper case, 
        // 2) print the result to the console and 
        // 3) return the new string.
        public static string StringToUpper(string x)
        {
            //throw new NotImplementedException("StringToUpper method not implemented.");
            string edited = x.ToUpper();
            Console.WriteLine(edited);
            return edited;
        }

        // This method has one string parameter. 
        // It will:
        // 1) change the string to all lower case, 
        // 2) print the result to the console and 
        // 3) return the new string.        
        public static string StringToLower(string x){
            //throw new NotImplementedException("StringToUpper method not implemented.");
            string edited = x.ToLower();
            Console.WriteLine(edited);
            return edited;
        }
        
        // This method has one string parameter. 
        // It will:
        // 1) trim the whitespace from before and after the string, 
        // 2) print the result to the console and 
        // 3) return the new string.
        public static string StringTrim(string x){
            //throw new NotImplementedException("StringTrim method not implemented.");
            string edited = x.TrimStart(' ');
            edited = edited.TrimEnd(' ');
            return edited;
        }
        
        // This method has two parameters, one string and one integer. 
        // It will:
        // 1) get the substring based on the integer received, 
        // 2) print the result to the console and 
        // 3) return the new string.
        public static string StringSubstring(string x, int elementNum){
            //throw new NotImplementedException("StringSubstring method not implemented.");
            string edited = x.Substring(elementNum);
            Console.WriteLine(edited);
            return edited;
        }

        // This method has two parameters, one string and one char.
        // It will:
        // 1) search the string parameter for the char parameter
        // 2) return the index of the char.
        public static int SearchChar(string userInputString, char x){
            //throw new NotImplementedException("SearchChar method not implemented.");
            int index = userInputString.IndexOf(x);
            return index;
        }

        // This method has two string parameters.
        // It will:
        // 1) concatenate the two strings with a space between them.
        // 2) return the new string.
        public static string ConcatNames(string fName, string lName){
            //throw new NotImplementedException("ConcatNames method not implemented.");
            return fName + " " + lName;
        }



    }//end of program
}
