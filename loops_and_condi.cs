using System;

namespace loopsandconi
{

    class diff_loops
    {
        public void m_if_loop()
        {

            Console.Write("Enter Name:");
            var Name = Console.ReadLine();

            Console.Write("Enter Age:");
            int Age = Convert.ToInt32(Console.ReadLine());

            if(Age<0){
                throw new Exception("Age cannot be negative"); // throwing an exoection will kill the run of the program
            }

            Console.Write("Enter MOB:");
            var Month = Console.ReadLine();

            Console.WriteLine("Are you married?(y)");
            var check=Console.ReadLine();
            Boolean m_check=true;
            if(check !="y"){
                m_check=false;
            }

            Console.WriteLine("Name is:" + Name + " Age:" + Age + " MOB:" + Month);

            if (Month == "Jan") // if condition
            {
                Console.WriteLine("Jan Star");
            }
            else if (Month == "Aug")
            {
                Console.WriteLine("Aug Star");
            }
            else
            {
                Console.WriteLine("Unknown Star");
            }            

            if(m_check){//in here we only have only parameter as all these loops work as loo=ng as they are true. that means if the value is true it is going work as seen here.
                Console.WriteLine("You are married.");

            }

            
        }

        public void m_while_loop()
        {
            var Pass = "sec";
            int logincounter = 3;
            Console.WriteLine("Enter Pass:");
            var Passcheck = Console.ReadLine();

            while (logincounter > 0) // while loop runs for as long as the condition is true.
            //while(flag) also works if flag is a boolean data type.
            {
                if (Pass == Passcheck)
                {
                    Console.WriteLine("Good Pass");
                    break;
                }
                else
                {
                    Console.WriteLine(logincounter + " Tries remain to reenter Pass:");
                    Passcheck = Console.ReadLine();
                    logincounter--;

                }

            }
        }

        public void for_loop(){
            
            for(int i=0; i < 5;i++){
                Console.WriteLine(i);
            }
        }

        public void m_foreach()
        { // this loop is used to access all the indexs of an array.
            var arr_digits = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            
            foreach (var i in arr_digits)//here var picks up the data type and data into i which is a variable from arr_digits which is the collection and prints it out.
            // so we cannot print more than 1 array at a time.
            {
                Console.WriteLine(i);
            }
        }
        public void switch_condi(){
            Console.WriteLine("Enter Value between 1 and 4");
            int i = Convert.ToInt32(Console.ReadLine());
            switch (i)
            {
                case 1:
                    Console.WriteLine("You have entered one");
                    break;
                case 2:
                    Console.WriteLine("You have entered two");
                    break;
                case 3:
                    Console.WriteLine("You have entered three");
                    break;
                case 4:
                    Console.WriteLine("You have entered four");
                    break;
                default:
                Console.WriteLine("not in the range");
                break;
            }

        }

        public void m_try_catch(){
            var l_check=true;
            while(l_check){
            try{                
                Console.WriteLine("enter a number");
                int s=Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("{0} is a number",s);// these two lines doesnt run unless you enter a number as the above line throws an expection
                break;
            }
            catch{//catch by default cahtchs all execptions you can also have catch statmnets that catchs 
                Console.WriteLine("you dint enter a number");

            }
            }
        
        }
        
    }
}