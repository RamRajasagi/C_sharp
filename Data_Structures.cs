using System;

// arrays (static, dynamic) , list, hash tables
namespace ds{
    class diff_ds{
        public void m1_arrays_static(){
            //int Array[]; declaring array  //Array = new int[20]; allocating memory to array
            int[] studentGrades = new int[10]; // creating an array and aloocating memory to it in the same line.
            // we can also create aan arry of classes like diff_ds[] d= new diff_ds[5], this will hold five instace of this class
            studentGrades[1]=20; //using index to access the the array and saveing our data in it. 
            studentGrades[5]=50;
            Console.WriteLine(studentGrades[5]); //we use an index too get specific vaule of an array.
            studentGrades= new int[10] {1,2,3,4,5,6,7,8,9,0}; // another way of assigning values to an array
            Console.WriteLine(studentGrades[5]); // we can only print index by index not all at once.

        }

        public void m2_arrays_dynamic(){
            Console.Write("Enter Number of students:");
            int stu_count= Convert.ToInt32(Console.ReadLine());
            
            string[] stu_name = new string[stu_count];
            int[] stu_grade= new int[stu_count];
            
            for(int i=0;i<stu_count;i++){
                Console.Write("Enter Student Name:");
                stu_name[i]=Console.ReadLine();

                Console.Write("Enter Student Grade:");
                stu_grade[i]=Convert.ToInt32(Console.ReadLine());
            }

            for(int i=0;i<stu_count;i++){
                Console.WriteLine("Student Name is: "+stu_name[i]);
                Console.WriteLine("Student Grade is: "+stu_grade[i]);
            }

        }

        public void m3_list(){
            // similler to arrays with index based access but their size can be changed at run time unlike array where size is fixed
            List<string> stu_name = new List<string>(); //creating a list. here no need to declare size as list can grow as you like
            List<int> stu_grade= new List<int>();

            string onemore="y";

            while(onemore =="y"){
                Console.Write("Enter Student Name:");
                stu_name.Add(Console.ReadLine());

                Console.Write("Enter Student Grade:");
                stu_grade.Add(Convert.ToInt32(Console.ReadLine()));

                Console.Write("Do want to add one more student? (y)");
                onemore=Console.ReadLine();                
            }
            for(int i=0;i<stu_grade.Count;i++){ // listname.count is how you get the length of the list
                Console.WriteLine("Student Name is: "+stu_name[i]); // access data in list is similar to that of arrays
                Console.WriteLine("Student Grade is: "+stu_grade[i]);
            }
        }

        /* differnt methods inside a list
         List<String> food = new List<String>();

            food.Add("pizza");
            food.Add("hamburger");
            food.Add("hotdog");
            food.Add("fries");

            //Console.WriteLine(food[0]);
            //Console.WriteLine(food[1]);
            //Console.WriteLine(food[2]);
            //Console.WriteLine(food[3]);

            //food.Remove("fries");
            //food.Insert(0, "sushi");
            //Console.WriteLine(food.Count);
            //Console.WriteLine(food.IndexOf("pizza"));
            //Console.WriteLine(food.LastIndexOf("fries"));
            //Console.WriteLine(food.Contains("pizza"));
            //food.Sort();
            //food.Reverse();
            //food.Clear();
            //String[] foodArray = food.ToArray();

            foreach (String item in food)
            {
                Console.WriteLine(item);
            }

            
        */

        public void m4_list_cls_objs(){
            //example of lists handling class objects i.e a set of data rather than one vaule per index.
            List<Student> list_student = new List<Student>(); // creating a list that takes all the variables that are declared in class Student in one index place
            // Student class is declared below
            string onemore="y";

            while(onemore =="y"){
                var obj_student = new Student(); // creating a class instace to access the class variables
                Student.Stu_roll++;//accessing static variable can only be done by class reference directly not by object
                Console.WriteLine("next roll is:"+Student.Stu_roll);
                
                Console.Write("Enter Student Name:");
                obj_student.Stu_name=Console.ReadLine();

                Console.Write("Enter Student Age:");
                obj_student.Stu_age=Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter Student City:");
                obj_student.Stu_city=Console.ReadLine();

                Console.Write("Enter Student Gender:");
                obj_student.set_gender(Console.ReadLine()); // we cannot access the pvt varibales directly. we need to pass the value through a function.
                //we call that function a setter function and this concepts is called encapsulation

                Console.Write("Enter Student Rank:");
                obj_student.S_rank=Convert.ToInt32(Console.ReadLine());//this is a property also used to access non public feilds


                list_student.Add(obj_student); // once we have collected all data we need to add it to the list and one indexed value
                

                Console.Write("Do want to add one more student? (y)");
                onemore=Console.ReadLine();                
            }

            foreach (Student s in list_student) // here in the place of regular var we used the class name as the data type is the info that we are colleceting form the list
            {
                Console.WriteLine(" Name of the Student is {0} and age is {1} and is from {2} and is a {3} and is {4} in the class. Number of students in the class is {5}",
                s.Stu_name,s.Stu_age,s.Stu_city,s.get_gender(),s.S_rank,Student.Stu_roll);
                
            }

        }

        
    }

    class Student{
        static public int Stu_roll=0; //static means is not effected/changed by any insatnce of the class and is same for all the insatnces
        public string Stu_name; // when you are creating class variable that you want to be accessed by other classes best not use var
        public int Stu_age; // these are also called as fields
        public string Stu_city;
        private string stu_gender; // for private variables we use lower case as a nom
        private int stu_rank;        

        public void set_gender(string v){ //this is a set method
            stu_gender=v;
        }

        public string get_gender(){ //this is a get method
            return stu_gender;
        }

        public int S_rank{ //this is called property. we can use this when the language supports set and get accessers and both are sepcifed in the same properity
            set{
                stu_rank=value; //here value is a keyword with has the value of S_rank property
                }
            get{
                return stu_rank;
            }
        } 


    
    } 
}