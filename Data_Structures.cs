using System;
using System.Collections;

//collections: arrays (static, dynamic) , array-list, hash tables, Queue, Stacks
//collections.generic: dictionary,List
//collection.concurrent:(thread safe)  concurrent Dictionary, concurrent-queue, concurrent-stack, concurrent-bag, blocking Collection
/*
Arrays: A fixed-size collection of elements of the same type.
Example: int[] numbers = {1, 2, 3, 4, 5};

Lists: A dynamic array that can grow or shrink in size.
Example: List<int> list = new List<int> {1, 2, 3, 4, 5};

Stacks:Follows the Last In, First Out (LIFO) principle.
Example: Stack<int> stack = new Stack<int>();

Queues: Follows the First In, First Out (FIFO) principle.
Example: Queue<int> queue = new Queue<int>();

LinkedList: A collection of nodes where each node contains data and a reference to the next node.
Example: LinkedList<int> linkedList = new LinkedList<int>();

Dictionary (Dictionary<TKey, TValue>): A collection of key-value pairs.
Example: Dictionary<string, int> dictionary = new Dictionary<string, int>();

HashSet:A collection of unique elements.
Example: HashSet<int> hashSet = new HashSet<int>();

SortedSet: A collection of unique, sorted elements.
Example: SortedSet<int> sortedSet = new SortedSet<int>();

Queue<T> (System.Collections.Generic): A generic implementation of a queue.
Example: Queue<int> genericQueue = new Queue<int>();

Stack<T> (System.Collections.Generic): A generic implementation of a stack.
Example: Stack<int> genericStack = new Stack<int>();

Tuple (System): Represents a lightweight, immutable data structure containing multiple elements.
Example: Tuple<int, string> myTuple = Tuple.Create(1, "Hello");

KeyValuePair (System.Collections.Generic): Represents a key-value pair.
Example: KeyValuePair<int, string> kvp = new KeyValuePair<int, string>(1, "Hello");
*/

namespace ds
{
    class diff_ds
    {
        public void m1_arrays_static()
        {
            //int Array[]; declaring array  //Array = new int[20]; allocating memory to array
            int[] studentGrades = new int[10]; // creating an array and allocating memory to it in the same line.
            // we can also create aan array of classes like diff_ds[] d= new diff_ds[5], this will hold five instance of this class
            //var Array[];    //declaring array
            //Array = new int[20];  // allocating memory to array
            var studentGrades = new int[10]; // creating an array and allocating memory to it in the same line.
            studentGrades[1] = 20; //using index to access the the array and saving our data in it. 
            studentGrades[5] = 50;
            Console.WriteLine(studentGrades[5]); //we use an index too get specific value of an array.
            studentGrades = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 }; // another way of assigning values to an array
            Console.WriteLine(studentGrades[5]); // we can only print index by index not all at once.

        }

        public void m2_arrays_dynamic()
        {
            Console.Write("Enter Number of students:");
            int stu_count = Convert.ToInt32(Console.ReadLine());

            string[] stu_name = new string[stu_count];// we are declaring the size of this array during run time, however once we declare the size it cant be changed and hence lists
            int[] stu_grade = new int[stu_count];

            for (int i = 0; i < stu_count; i++)
            {
                Console.Write("Enter Student Name:");
                stu_name[i] = Console.ReadLine();

                Console.Write("Enter Student rank:");

            var stu_name = new string[stu_count];
            var stu_grade = new int[stu_count];

            for (int i = 0; i < stu_count; i++)
            {
                Console.Write("Enter Student Name:");
                stu_name[i] = Console.ReadLine();

                Console.Write("Enter Student Grade:");
                stu_grade[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i < stu_count; i++)
            {
                Console.WriteLine("Student Name is: " + stu_name[i]);
                Console.WriteLine("Student rank is: " + stu_grade[i]);
                Console.WriteLine("Student Grade is: " + stu_grade[i]);
            }

        }

        public void m2_1_arraylist()
        { // in the m2_arrays_dynamic method we have two arrays as we had to deal with2 different type of data types. 
          // if you want only one type of data type then we can use arraylist
          // as it is a n array list we can use both the array style and we dont have to specify the size
            ArrayList stu_al = new ArrayList();

            string more_students = "y";
            string stu_name;
            int stu_rank;

            while (more_students == "y")
            {
                more_students = "n";
                Console.Write("enter student name:");
                stu_name = Console.ReadLine();
                stu_al.Add(stu_name);
                Console.Write("enter student rank:");
                stu_rank = Convert.ToInt32(Console.ReadLine());
                stu_al.Add(stu_rank);
                Console.Write("do you have more students to add(y):");
                more_students = Console.ReadLine();
            }

            foreach (var stu in stu_al)
            {
                Console.WriteLine($"the student details are: {stu}");
            }
        }


        public void m3_list()
        {
            // similar to arrays with index based access but their size can be changed at run time unlike array where size is fixed
            List<string> stu_name = new List<string>(); //creating a list. here no need to declare size as list can grow as you like
            List<int> stu_grade = new List<int>();

            string onemore = "y";

        public void m3_list()
        {
            var stu_name = new List<string>(); //creating a list
            var stu_grade = new List<int>();

            string onemore = "y";

            while (onemore == "y")
            {
                Console.Write("Enter Student Name:");
                stu_name.Add(Console.ReadLine());

                Console.Write("Enter Student Grade:");
                stu_grade.Add(Convert.ToInt32(Console.ReadLine()));

                Console.Write("Do want to add one more student? (y)");
                onemore = Console.ReadLine();
            }
            for (int i = 0; i < stu_grade.Count; i++)
            { // list name.count is how you get the length of the list
                Console.WriteLine("Student Name is: " + stu_name[i]); // access data in list is similar to that of arrays
                Console.WriteLine("Student Grade is: " + stu_grade[i]);
            }
        }

        /* different methods inside a list
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

        public void m4_list_cls_objs()
        {
            //example of lists handling class objects i.e a set of data rather than one value per index.
            List<Student> list_student = new List<Student>(); // creating a list that takes all the variables that are declared in class Student in one index place
            // Student class is declared below
            string onemore = "y";

            string onemore = "y";

            while (onemore == "y")
            {
                var obj_student = new Student(); // creating a class instance to access the class variables
                Student.Stu_roll++;//accessing static variable can only be done by class reference directly not by object
                Console.WriteLine("next roll is:" + Student.Stu_roll);

                Console.Write("Enter Student Name:");
                obj_student.Stu_name = Console.ReadLine();

                Console.Write("Enter Student Age:");
                obj_student.Stu_age = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter Student City:");
                obj_student.Stu_city = Console.ReadLine();

                Console.Write("Enter Student Gender:");
                obj_student.set_gender(Console.ReadLine()); // we cannot access the pvt variables directly. we need to pass the value through a function.
                //we call that function a setter function and this concepts is called encapsulation

                Console.Write("Enter Student Rank:");
                obj_student.S_rank = Convert.ToInt32(Console.ReadLine());//this is a property also used to access non public felids


                list_student.Add(obj_student); // once we have collected all data we need to add it to the list and one indexed value


                Console.Write("Do want to add one more student? (y)");
                onemore = Console.ReadLine();
            }

            foreach (Student s in list_student) // here in the place of regular var we used the class name as the data type is the info that we are collecting form the list
            {
                Console.WriteLine(" Name of the Student is {0} and age is {1} and is from {2} and is a {3} and is {4} in the class. Number of students in the class is {5}",
                s.Stu_name, s.Stu_age, s.Stu_city, s.get_gender(), s.S_rank, Student.Stu_roll);

            }

        }

        public void m5_stacks()
        {
            var myStack = new Stack<int>();

            // Pushing elements onto the stack
            myStack.Push(10);
            myStack.Push(20);
            myStack.Push(30);

            // Peeking at the top element without removing it
            int topElement = myStack.Peek();
            Console.WriteLine($"Top element: {topElement}");

            // Popping elements from the stack
            int poppedElement1 = myStack.Pop();
            Console.WriteLine($"Popped element: {poppedElement1}");

            int poppedElement2 = myStack.Pop();
            Console.WriteLine($"Popped element: {poppedElement2}");

            // Checking if the stack is empty
            bool isEmpty = myStack.Count == 0;
            Console.WriteLine($"Is the stack empty? {isEmpty}");

            // Pushing more elements onto the stack
            myStack.Push(40);
            myStack.Push(50);

            // Iterating through the stack
            Console.WriteLine("Stack elements:");
            foreach (int element in myStack)
            {
                Console.WriteLine(element);
            }
        }


    }

    class Student
    {
        static public int Stu_roll = 0; //static means is not effected/changed by any instance of the class and is same for all the instances
        public string Stu_name; // when you are creating class variable that you want to be accessed by other classes best not use var
        public int Stu_age; // these are also called as fields
        public string Stu_city;
        private string stu_gender; // for private variables we use lower case as a nom
        private int stu_rank;

        public void set_gender(string v)
        { //this is a set method
            stu_gender = v;
        }

        public string get_gender()
        { //this is a get method
            return stu_gender;
        }

        public int S_rank
        { //this is called property. we can use this when the language supports set and get accesses and both are specified in the same property
        { //this is called property. we can you when the language supports set and get accessors and both are specified in the same property
            set
            {
                stu_rank = value; //here value is a keyword with has the value of S_rank property
            }
            get
            {
                return stu_rank;
            }
        }
    }


    



    }
}