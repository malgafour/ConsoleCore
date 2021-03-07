using System;  // System Libarary

namespace ConsoleCore  // Project name space
{

    // Human class 
    class Human : Object
    {
        // single line comment

        // variables with data type
        int age = 10;              // integar variable    >> states
        char symbol = 'c';          // character variable  >> states
        string string1 = "string";    // string variable     >> states
        double double1 = 15.5;        // double variable     >> states
        float float1 = 15.5f;        // float variable      >> states
        bool bool1 = true;          // bool variable       >> states


        // Function = Methods
        // Add Method  >> non static method >> Behavior
        public int add(int a, int b)  // Behavior with parametrs
        {
            int z = a + b;  // the function process 
            return z;  // or return a + b ;

            // unreachable 
            Console.WriteLine(z);
        }

        // Sum method >> static method  >> Behavior
        public static int sum(int a, int b)  // Behavior with parametrs
        {
            int z = a + b;  // the function process 
            return z;  // or return a + b ;
        }
    }

    // Parent = Base = Root class
    class Fathers
    {
        public string name; // public string variable  >> states
        public int age;  // public integr variable  >> states

        // public integer method  >> Behavior
        public int sallary(int salary)
        {
            return salary;
        }

        // public integer method  >> Behavior
        // overloading for sallary method.
        public int sallary(int salary, int year)
        {
            return salary * year;
        }


        // public integer method  >> Behavior
        // overloading for sallary method.
        public string sallary(int salary, string year)
        {
            return salary + "pear" + year;
        }

        // No return type method and it have private access modifire
        void Helpermethod()
        {
            // do any thing to helping 
        }

        // Private string method >> Behavior  -- canot be inhert to chiled -- 
        private string address(string state, int estatenum, string country)
        {
            return estatenum + state + country;
        }
    }

    // Child = sub class
    // Child is a Father  >> is a relationship
    class Childs : Fathers
    {

    }



    // Example of store have Branches using OOP
    class Store
    {
        // you shoud using static to shaird this to all objects.
        private static int productQuntity = 100;  // intial value

        public int NumberOfReminingProduct(int requestedProduct)
        {
            productQuntity = productQuntity - requestedProduct;
            return productQuntity;
        }
    }


    // Example of constractor

    class Demo
    {
        // the constrctour is:-
        // a special kind of method 
        // calling at the time of object creation.
        // it's a public method.
        // it's have a class name.
        // it's a no return type or void.
        // can be overloading.

        /*
         public Demo()
        {
            Console.WriteLine("Welcome reco from constrctor...");
        }

        */


        /*
         
         public Demo(string name)
        {
            Console.WriteLine("Welcome " + name + " from constrctor...");
        }
        
         */
        public void PrintMe()
        {
            Console.WriteLine("Welcome reco...");
        }


        // Example to calculate numbe of objects at time of object creation....

        private static int counter = 0;
        public Demo()
        {
            int count = counter++;
            Console.WriteLine("number of counter of object : " + count);
        }
    }


    // Example for Design Pattern:- 
    // |
    // |__ Creational pattern
    //    |
    //    |__ Singleton pattern
    //       |
    //       |__for get only one object from class.
    class Reco
    {
        private static bool flag = false;
        private Reco()
        {

        }

        public static Reco createObj()
        {
            if (flag == false)
            {
                Reco r = new Reco();
                flag = true;
                return r;
            }
            else
            {
                return null;
            }

        }

        public void speak()
        {
            Console.WriteLine("speack process");
        }
    }


    class utilits
    {

        static utilits()
        {
            Console.WriteLine("priortiy of excution");
        }
        public utilits()
        {
            Console.WriteLine("excute at the time of object creation");
        }


        public utilits(string name)
        {
            Console.WriteLine(name);
        }
    }

    class MyClass
    {
        public string name = "reco sheah ...";
    }

    // Defult Class [Program Class].
    class Program
    {
        // Main method.
        static void Main()
        {
            Console.Title = "Console App Core";  // Title of the console screen.

            // calling class with non static method.
            Human mohamed = new Human(); // ahmed object from human , calling with object.
            mohamed.add(10, 20); // return 30.

            // calling class with static method.
            Human.sum(10, 20);  // return 30.
            // above code it printing in memory.


            // hear printing from memory to user interfsce.
            System.Console.WriteLine(Human.sum(10, 20)); // without system libarary.


            // Example for swaping varibles.

            int a = 10;
            int b = 20;
            // swap a = 20 , b = 10 without using any temp varaible.
            b = a;         // b = 10.
            a = b + b;     // a = 10 + 10 = 20.

            int x = 99;
            int y = 101;
            //swap x = 101 , y = 99 without using any temp varaible.
            x = x + y;     // x = 99 + 101 = 200.
            y = x - y;     // y = 200 - 101 = 99.
            x = x - y;     // x = 200 - 99 = 101.


            Childs childs = new Childs();  // object from childs  >> has a relationship.
            Console.WriteLine(childs.age);

            Store Cairo = new Store();
            Console.WriteLine(Cairo.NumberOfReminingProduct(20));      // 20 requested quntity  >> 80 all quntity

            Store Ismailia = new Store();
            Console.WriteLine(Ismailia.NumberOfReminingProduct(30));   // 30 requested quntity  >> 50 all quntity

            Store Alex = new Store();
            Console.WriteLine(Alex.NumberOfReminingProduct(50));      // 50 requested quntity  >> 0 all quntity


            //  Demo d = new Demo();  // proccess 1   >>  time 1  : time of object creation.
            //d.PrintMe();          // proccess 2   >>  time 2  : time of calling to method.


            // when class have constructor
            Demo dc = new Demo(); // only 1 proccess and 1 time.

            // object with constructor overloding
            Demo dco = new Demo(); // only 1 proccess and 1 time.



            MyClass m1 = new MyClass();
            // Console.WriteLine(m1.name);

            MyClass m2 = m1;
            m2.name = "reco2";
            Console.WriteLine(m1.name);
            Console.WriteLine(m2.name);


            Reco r = Reco.createObj();
            r.speak();

            utilits u = new utilits("reco"); // object from class with overload constructor.
            string username = "ahmed";
            string password = "123456";
            // fore loop
            for (int i = 0; i < 100; i++) // strucur of for loop with condition and incriment.
            {
                if (i % 2 == 0)
                {
                    if (i <= 9)
                    {
                        Console.WriteLine("even number :  " + i);
                    }
                    else
                    {
                        Console.WriteLine("even number : " + i);
                    }

                }

                else
                {
                    Console.WriteLine("odd  number :  " + i);
                }

            }

            // while
            int index = 0;
            while (index < 10)
            {
                Console.WriteLine(index);
                index++;
            }

            // do while
            int val = 0;
            do
            {
                Console.WriteLine(val);
                val++;
            }
            while (val < 8);

            //foreach

            // inline if  , // ternary operator {dision making}.
            string answer = "good"; 
            string result = (answer == "good") ? "good job" : "bad job";
            Console.WriteLine(result);


            //if else

            if (username == "ahmed" && password == "123456")
            {
                Console.WriteLine("login success ... ");
            }

            else
            {
                Console.WriteLine("login faild ...");
            }

            //if elseif else 
            if (username == "ahmed" && password == "123456")
            {
                Console.WriteLine("login success ... ");
            }

            else if (username == "ahmed" || password == "123456")
            {
                Console.WriteLine("login simi success .... ");
            }

            else
            {
                Console.WriteLine("login faild ... ");
            }

            //swich case comapre between value and value only  >>  like if else but cant using multi operators.
            int myAge = 20;
            switch (myAge)
            {
                case 20: Console.WriteLine("same age");
                    break;  // end proccess

                case 30: Console.WriteLine("not match");
                    break;  // end proccess

                default: Console.WriteLine("plz chose"); //like else
                    break;
            }
             
           
        }
    }
}


/*
   all copy right to mohamed abd algafour >> 01090406649 >> m.abdalgafour@gmail.com
 
 summary of OOP
  
OOP :  Object Orianted Programming
       it have 3 stunderd  princplsve 

****** 1- Encapsulation
****** 2- Inheritance
****** 3- Polymorphism
  
---------------------------------------------[[Encapsulation]]---------------------------------------------
************ 1.1- Create class 
                  states (Varaibles) + Behaviors (Methods)
************ 1.2- Use to class  (Data Hidden) >> anotation of the class where hover on it

-----------------------------------------------[[Inheritance]]----------------------------------------------

                 using asign  :
************ 2.1- Parent class or Base class or Root class inhert his states & Behaviors to child class.
************ 2.2- Re-using code without rebate.
************ 2.3- c# not support multi inheritance becouse diamond problem , but fix it using abstruct class or interface.

 -----------------------------------------------[[Polymorphism]]--------------------------------------------
************ 3.1- تعدد الاشكال لشئ واحد
************ 3.2- Overloading
***************** 3.2.1- methods have same name and data types but changed from parameter {type or count}.
************ 3.3- Overriding
***************** 3.3.1- methods have same name but changed data type using virtual or override.

 */

/*
  summary of Methods
    
    1- Return Data Type 
    2- No return  - {void method}
 
 */

/*
  summary of Acess Modifers
    
    1- Public
        1.1- Take object.
        1.2- Inherite.
        1.3- All asymbliy.

    2- Private
       2.1- In his class only or scope.

    3- sealed
       3.1- Its public in project and canot be Inherit.
 
    4- protected
       4.1-  

    5- private protected
       5.1-   
 
 */

/*
   summary of type of relationship

    1- is a relationship
       1.1- is a relationship between chiled class and base class.

    2- has a relationship
       2.1- is the class has an object from another class.
 */



/*
   summary of Data types


  A =>> {Reference Type}
          in heep
     A.1- 
  B =>> {Value Type}
        
     B.1- float        : 4 byte = 32 bit. >> like float z = 15.5f
     B.2- double       : 8 byte = 64 bit. >> like double z = 15.5 >>>> by defualt.
     B.3- int          :
     B.4- string       :
     B.5- char         :
     B.6- bool         :
     B.7- object       :
     B.8- var          :

  */



/*

   summary of stack and heep {memory representation}:-
   |
   |___the memory = stack + heep   ==> logical not phshycal.
       |
       |__ heep: have acual object.
       |
       |__ stack: have a refrance of object.

       
    

 static method : it's have a priority in job
 
 
 */



/*
    summary of control statement 
     |
     |____ loop statement:
     |    |
     |    |____ for -------- {intialize + condition + doing + increment }.
     |    |
     |    |____ while ------ {intialize + condition + doing  +increment }.
     |    |
     |    |____ do while --- {intialize + doing + condition + increment} excute at least one.
     |    |
     |    |____ foreach.
     |
     |___ conditional statement:
         |
         |____ if.
         |
         |____ if else.
         |
         |____ if elseif else.
         |
         |____ swich case.
 
 */



/*
    summary of operators 
     |
     |____ comparson operator                              ==
     |
     |____ comparson operator with type , count and value  ===
     |
     |____ not equal                                       !=
     |
     |____ smaller than                                    <
     |
     |____ beger than                                      >
     |
     |____ smaller than and equal                          <=
     |
     |____ beger than and equal                            >=
     |
     |____ and operator                                    &&
     |
     |____ or operator                                     ||
 
 */