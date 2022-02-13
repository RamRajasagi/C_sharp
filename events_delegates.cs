using System;
using System.Threading;
namespace ed
{

    class action_here
    {
        //this is where we have some action taking palce that the othe classes want to hear.
        // this class is called publisher or event sender
        //we have this in three parts to plubish an Event: 
        //1. creating a delegate: which is like a pointer/refernce of a method that we use as a contract that a method sends the information in this way to anothr.
        //2. creating an event handler // which is what we trigger to send the info
        //3. publishing that an event has occured
        public delegate void AfterEnter_EventHandler(string str); //now you cannot declare a delegate inside a method.
        public event AfterEnter_EventHandler AfterEnter;// this is creating an event

        public void main_action()
        {

            System.Console.WriteLine("user clicked enter");
            if (AfterEnter != null) // to check if this publisher has some subscriber
            { AfterEnter("we have data from user"); } // we rae trigering the event as=nd as we said that this event is going to ssend a string while creating a deligate we have this line in brackets

        }
    }

    class reaction
    {//this class is subscriber class or event reciver
        private readonly action_here action;// creating a pvt feild called action to hold the reference call below
        // refernce is different from instantiation. 
        public reaction(action_here action)
        { // linking the publisher class by creating a refrence called action
            this.action = action; // saying that this is the event that we are referening to 
            action.AfterEnter += AfterEnter_EventHandler; //subscribing to the event
        }
        public void AfterEnter_EventHandler(string str)
        { //event to run after the publisher runs
            System.Console.WriteLine(str);
            System.Console.WriteLine("this is reaction after enter");
        }


    }

    class delegatez
    { // delegates are also used in different ways for anonymous methods or method assigmenet etc

        public delegate void test1_delegate();
        public delegate int test2_delegate(int k);
        
        
        public delegatez(){           
            test2_delegate sqaure = delegate(int n){ return n*n;}; //this is using delegate to create an anonymuns methods"delegate(int n){ return n*n;};"
            System.Console.WriteLine(sqaure(2));
        }

        public void deleg_test_method()
        {
            System.Console.WriteLine("we are testing this delegate");
        }

        public void assign_delg_method(){
            test1_delegate t1=deleg_test_method;
            t1();
        }

    }

    class lambda_exp{
        Func<int,int> square=x=>x*x;//=> is called lambda expression, this another way of method encapusaltion or anonymous methods
        // Func<input datatype,output datatype> method name = input => action
        public lambda_exp(){
            System.Console.WriteLine(square(4));
        }
        
        
    }
}


