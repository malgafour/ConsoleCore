﻿using System;  // System Libarary
using System.Text;
using System.Collections;

namespace ConsoleCore  // Project name space
{

    // Human class 
    class Human : Object
    {
        // single line comment

        // variables with data type
        int age = 10;                 // integar variable    >> states
        char symbol = 'c';            // character variable  >> states
        string string1 = "string";    // string variable     >> states
        double double1 = 15.5;        // double variable     >> states
        float float1 = 15.5f;         // float variable      >> states
        bool bool1 = true;            // bool variable       >> states


        // Function = Methods
        // Add Method  >> non static method >> Behavior
        public int add(int a, int b)  // Behavior with parametrs
        {
            int z = a + b;  // the function process 
            return z;  // or return a + b ;

            // unreachable 
            // Console.WriteLine(z);
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
            string name = "mohamed";  // first location
            name += "abd algafour";   // secound location

            StringBuilder sb = new StringBuilder();
            sb.Append("mohamed");    // first location 
            sb.Append("abd algafour"); // at same first location
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


    enum Colors
    {
        Red = 'R',
        Green = 'G',
        Yellow = 'Y'
    }

    // partial class
    partial class DemoF
    {
        public void Eat()
        {

        }
        public void Walk()
        {

        }
        public void WakeUp()
        {

        }
    }

    // example to parital class 

    public class para{
        // do anything
    }

    public partial class para{
    // do anything too 
    }


    // example to interface

    public interface Ireport{
        void Header();
        void Body();
        void Footer();
    }

    public interface Iname{
    }

    public class PDFReport : Ireport , Iname{
        public void Header()
        {
        
        Console.WriteLine("pdf header");
        }

        public void Body()
        {
            Console.WriteLine("pdf body");
        }

        public void Footer()
        {
            Console.WriteLine("pdf footer");
        }
    }

    // example for abstruct class 

    public abstract class Reports
    {
        public abstract void Head();
        public abstract void Foot();
        public void Welcome()
        {
            Console.WriteLine("Welcome from abstruct !!");
        }
    }


    public class OnRepo : Reports
    {
        public override void Head();
        public override void Foot();
         

    }

    // Defult Class [Program Class].
    class Program
    {
        // Main method.
        static void Main()
        {
            Console.WriteLine(Colors.Red); // return enum key
            Console.WriteLine((char)Colors.Red); // return enum value


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
                case 20:
                    Console.WriteLine("same age");
                    break;  // end proccess

                case 30:
                    Console.WriteLine("not match");
                    break;  // end proccess

                default:
                    Console.WriteLine("plz chose"); //like else
                    break;
            }


            int xa = 5;
            double ya = 7.3;

            // working with casting ... 

            xa = (int)ya; // explicit casting
            ya = xa;  // implicit casting 

            // another implicit casting 
            var s = "hi"; // string
            var d = 5;  // int
            Console.WriteLine(s + d);
            // working with Anonymous types

            Demo rr = new Demo();
            var rrr = new Demo();
            var anonymousType = new { name = "reco ", age = 25, salary = 1000 };
            Console.WriteLine(anonymousType.name);


            // daynamic type it's can evaluate the compile time at same run time 
            dynamic uu = 20; // runtime
            var uuu = 50;   // compile time
            Console.WriteLine(uuu);

            const double PI = 3.14; // cannot be re-intialize
            // PI = 15.5; // > error
            Console.WriteLine(PI);


            Ireport ireport = new PDFReport();
            ireport.Header();
            ireport.Body();
            ireport.Footer();


            // example of arrays
            // 1- single dimention array 

            int[] ages = { 10, 20, 80, 40, 50, 15 };
            // or int[] ages = new int[2];
            // ages[0] = 1;
            // ages[1] = 2;

            // or int[] ages = new int[6]  { 10, 20, 30, 40, 50, 60 };

            // sorting array 
            Array.Sort(ages);

            // reverse array
            Array.Reverse(ages);
            for (int i = 0; i < ages.Length; i++)
            {
                Console.WriteLine("i[" + i + "]" + "=" + ages[i]);
            }

            // 2- two dimention array

            string[,] rectangle = new string[2, 3];  // row * coulmns
            rectangle[0, 0] = "mohamed";
            rectangle[0, 1] = "abd";
            rectangle[0, 2] = "algafour";
            rectangle[1, 0] = "ahmed";
            rectangle[1, 1] = rectangle[0, 0];
            rectangle[1, 2] = "ali";

            for (int row = 0; row <= rectangle.GetUpperBound(0); row++)
            {
                for (int coulmn = 0; coulmn <= rectangle.GetUpperBound(1); coulmn++)
                {
                    Console.WriteLine(rectangle[row, coulmn]);
                }
            }

            // 3- array of array 

            int[][] jagged = new int[3][];
            jagged[0] = new int[3] { 1, 2, 3 };
            jagged[1] = new int[2] { 50, 60 };
            jagged[2] = new int[5] { 1, 2, 3, 4, 5 };

            for (int outer = 0; outer < jagged.Length; outer++)
            {
                for (int inner = 0; inner < jagged[outer].Length; inner++)
                {
                    Console.Write(jagged[outer][inner] + ",");
                }
                Console.WriteLine();
            }


            // example of collections and workink ... 

            // arraylist
            int[] age = {100,200,300};
            ArrayList seq = new ArrayList();
            seq.Add(1);
            seq.Add('c');
            seq.InsertRange(1,age);
            seq.Insert(0,"hi");
            seq.Remove(100);
            seq.RemoveAt(0);
            foreach (var item in seq)
            {
                Console.WriteLine(item);
            }


            //sortedlist
            SortedList seq2 = new SortedList();
            seq2.Add("team A" ,50);
            seq2.Add("team B" ,50);
            seq2.Add("team C" ,50); 
            foreach (DictionaryEntry item in seq2)
            {
                Console.WriteLine(item.Key);
                Console.WriteLine(item.Value);
            }

			 // stack
                Stack st= new Stack();
                st.Push("1");
                st.Push("10");
                st.Push("11");
                st.Push("12");
                st.Pop("1");
                st.Pop("10");
                st.Pop("11");
                st.Pop("12");

            //  Queue
            Queue q = new Queue();
            q.Enqueue(1);
            q.Enqueue(15);
            q.Enqueue(23);
            q.Enqueue(2);
        }
    }
}


/*
  mohamed abd algafour >> 01090406649 >> m.abdalgafour@gmail.com
 thanks itShare <3
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
    
    1- Public :: The type or member can be accessed by any other code in the same assembly or another assembly that references it.
        1.1- Take object.
        1.2- Inherite.
        1.3- All asymbliy.

    2- Private :: The type or member can be accessed only by code in the same class or struct.
       2.1- In his class only or scope.

    3- sealed
       3.1- Its public in project and canot be Inherit.
 
    4- protected :: The type or member can be accessed only by code in the same class, or in a class that is derived from that class.

    5- private protected :: The type or member can be accessed only within its declaring assembly, by code in the same class or in a                         type that is derived from that class.
       5.1-   

    6- internal :: The type or member can be accessed by any code in the same assembly, but not from another assembly.
       6.1-

    7- protected internal :: The type or member can be accessed by any code in the assembly in which it's declared, or from within a                          derived class in another assembly.
       7.1-
 
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
        
     B.1 - float        : 4 byte  = 32 bit. >> like float z = 15.5f  >> -3.402823e38 to 3.402823e38
     B.2 - double       : 8 byte  = 64 bit. >> like double z = 15.5  >>>> by defualt. >>  	-1.79769313486232e308 to 1.79769313486232e308 
     B.3 - int          : 4 byte  = 32 bit. >> like int z = 15       >> -2,147,483,648 to 2,147,483,647 
     B.4 - string       : **********   A sequence of Unicode characters  *****  
     B.5 - char         : 2 byte  = 16 bit. >> like char z = 'a'     >> Any valid character, e.g. a,*, \x0058 (hex), or\u0058 (Unicode) 
     B.6 - bool         : 1 byte  = 8  bit. >> like bool z = true.   >> True or False 
     B.7 - object       : ********** Base type of all other types.  **********
     B.8 - DateTime     : ********** Represents date and time       **********  >> 0:00:00am 1/1/01 to 11:59:59pm 12/31/9999 
     B.9 - byte         : 1 byte  = 8 bit.  >>                       >>  0 to 255
     B.10- sbyte        : 1 byte  = 8 bit.  >>                       >>  -128 to 127 
     B.11- short        : 2 byte  = 16 bit.                          >>  -32,768 to 32,767 
     B.12- ushort       : 2 byte  = 16 bit. >>                       >>  0 to 65,535 
     B.13- uint         : 4 byte  = 32 bit. >>                       >>  0 to 4,294,967,295 
     B.14- long         : 8 byte  = 64 bit. >>                       >>  -9,223,372,036,854,775,808 to 9,223,372,036,854,775,807 
     B.15- ulong        : 8 byte  = 64 bit. >>                       >>  0 to 18,446,744,073,709,551,615  
     B.16- decimal      : 16 byte = 128 bit.>>                       >>  (+ or -)1.0 x 10e-28 to 7.9 x 10e28  
     B.17- decimal      : 16 byte = 128 bit.>>                       >>  0 to 18,446,744,073,709,551,615  
      

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


/*
 
 *****************************************************************************************************************************
 *                          *                                         *                                                      *
 *          access          *              take object                *                       inheritance                    *
 *                          *                                         *                                                      *
 *****************************************************************************************************************************
 *                          *                                         *                                                      *
 *   public                 *                   YES                   *                            YES                       *
 *                          *                                         *                                                      *
 *   private                *          scope of class only            *                            NO                        *
 *                          *                                         *                                                      *
 *   protected              *                   NO                    *                            YES                       *
 *                          *                                         *                                                      *
 *   internal               *                   YES                   *                            YES                       *
 *                          *                                but within current DLL                                          *
 *                          *                                         *                                                      *
 *   protected internal     *       YES but within current DLL        *                            YES                       *
 *                          *                                         *                                                      *
 *   private protected      *                   NO                    *              YES but within current DLL              *
 *                          *                                         *                                                      *
 *****************************************************************************************************************************
 
 */


/*
    DLL :
      |
      |____ Dynamic Link Library
           |
           |___ have more namespace 



 
 */


/*
   ----------- C# TOPICS -----------
   | 
   |__Data type
   | |
   | |____Value Type
   | |    |
   | |    |____Any type you know how many size in memory  like int x = 5;
   | |
   | |
   | |____Reference Type
   | |
   | |____Like class demo() {}
   | 
   | 
   | Implicit and Explicit casting
   | |
   | |____ implict casting  x = y 
   | |
   | |____ explicit casting  x = (double)y
   | 
   | 
   |__Anonymous types
   | |
   | |____ its a temparty
   | 
   | 
   |__Dynamic Types
   | |
   | |____ daynamic type it's can evaluate the compile time at same run time (dynamic)
   | 
   | 
   |__const
   | |
   | |____ cannot be re-intialize
   | |____ variable name it's principles Uppercase
   | 
   |__enum
   |  |
   |  |____ to create new type with values
   | 
   |__property
   | |
   | |___ set; get;
   |
   |__StringBuilder
   | |
   | |___immutable
   | |   |
   | |   |____String s = new String ("Hellow World");
   | |   |______ s+="Hi";       >> this case have 2 string location in memory 'in heep'
   | |
   | |___mutable
   | |   |
   | |   |____StringBiulder s = new StringBiulder("Hellow World");
   | |   |______s.append("Hi");     >> this case have only one string location in memory 'in heep' and updated :)
   |
   |
   |__Partial class
   | 
   |__Abstract class vs interface
   | 
   |__Struct
   | 
   |__Array
   | 
   |__Collections and Generics
   | 
   |__Extentions Methods
   | 
   |__Exceptions
   |____________________________________________________________________________


 
 
 */



/*
   -- equ of max min signed and unsigned
     |
     |__________signed_________
     |     |  
     |     |_______ min: -1 * 2^N
     |     |_______ max:  1 * 2^N
     |
     |__________unsigned_________
           |  
           |_______ min: 0
           |_______ min: 2^N-1


*************** N ******* >> is a count of bits
 */


/*
partial class : 
- multi class name to split methods  
    class demo
    partial class demo
    partial class demo
.....
*/


/*
 interface  >>>> just blo print
    is a signtur to uniqe the methodths names .
    interface implimenting : in class. 
    class can be inhrite from multi interfaces
    interfaces canot be token by object.
 */

/*
 abstruct class 
    have a abstruct methods
    including signur and implimntation
    class inhiret only one abstruct class and methods should be override
 */


/*
 Array
    collection of data have same datatype (hemogenous) , its an object , fixed size.

    1.0 - single dimenstion array
    2.0 - multi dimenstion array
    3.0 - array of array (jagged array)
 */



/*
 Collections
    collection of data items
    diffrent data types = hetrogenous
    using System.Collections;
    dynamic size 
        1.0- arraylist
        2.0- sortedlist
        3.0- stack
        4.0- queue
        5.0- hashtable
        6.0- bitarray
 */


/*
 Generic
    dynamic size 
    collection of data items
    hemogenous = have the same data types
    
 */


/*
 stack:-
    last in first out  LIFO
    push & pop
 */


/*
 Queue
    first in last out  FIFO
    enqueue
 */