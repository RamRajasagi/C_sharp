using System;
 namespace diff_methods{
     class method_types{
         public void m1_access_speci_method(){ 
             // here public or private are access specifiers this will tell if someone else can access the method or not.
             //the persence of void give the method permission for not retruning a value. 
             Console.WriteLine("my point");

         }

         private void m2_access_speci_method(){ 
             // testing private access specifier. you'll not be able too call this method from main method
             Console.WriteLine("my point");

         }
         // other access specifiers are:
         //internal: any class within the project can access them.
         // protected: only inherited class can access them. ie only child class can access
         //protected internal: a combination oof the above two.

         public void m3_returing_methods(){ 
             //we have the retrurn type as void. so it is not needed for the method to retunr a vlue.
             //console.wl() is not returning a value. it is a method with in this metjod that writes data to console.
            var k ="";
            Console.WriteLine("Enter value to k:");
            k=Console.ReadLine();
            while(k== ""){
                Console.WriteLine("No Value entered. Enter value to k:");
                k=Console.ReadLine();                           
                
            }
            Console.WriteLine("value of k is: "+k);

         }

         public string m4_returing_methods(){
             var k ="";
            Console.WriteLine("Enter value to k:");
            k=Console.ReadLine();
            while(k== ""){
                Console.WriteLine("No Value entered. Enter value to k:");
                k=Console.ReadLine();                           
                
            }
            return k;
         }

         public void m5_pass_parameters(int i,int j){ //here i and j are parameters
             Console.WriteLine("Adding {0} and {1}. Do you want to change the values press (y)",i,j);
             var d= Console.ReadLine();
             if(d=="y"){
                Console.WriteLine("Enter two new values");
                i=Convert.ToInt32(Console.ReadLine());//the data that comes from a terminal is always a var
                j=Convert.ToInt32(Console.ReadLine());
             }             
             int t=i+j;
             Console.WriteLine("sum is: "+t);

         }

         public static void  m6_static_method(){
             //for static method you dont need an instance.
             Console.WriteLine("My static point.");

         }
        public string const_test;
        public method_types(){ 
             //this is a constrctor. the name of this should be the same name as the class.
             //this is the first thing that is goin to be exectued when we create an insatnce of the class.
             const_test="no arguments";
             Console.WriteLine(this.const_test);
         }

         public method_types( string s){ 
             //this is constrctor can tae argumnets just like a method and there can be multiple conts in a class
             //the only way we can differencate btw all these is by number of argumnets/parameters each connstrctur takes
             const_test=s;
             Console.WriteLine(this.const_test);
         }



     }

    
 }