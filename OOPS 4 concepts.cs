using System;
//encapsulation
//inheritance
//abstraction - abilty to hide 
//polymorphism

namespace oops_concepts
{
    class encap
    { //process of combining a data member and method into one unit. 
      // this means it is abilty to crate a class

        public int i; // data member
        public int multi()
        { //method
            int k = i * 5;
            return k;
        }
    }

    class inhert_parent
    {
        public int i2 = 10;
        public int add()
        {
            int h = i2 + 10;
            return h;
        }
    }

    class inhert_child : inhert_parent
    {
        public new int i2 = 20;
        public int add2()
        {
            int h = i2 + 10;
            return h;
        }

    }

    class poly{
        public int poly_add(int n, int m){
            var z=n+m;
            return z;
        }

        public int poly_add(int n, int m, int o){
            var z=n+m+o;
            return z;
        }
    }


}