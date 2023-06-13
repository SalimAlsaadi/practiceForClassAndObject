namespace practiceForcClassAndObject
{
     class Program
    {
        static void Main(string[] args)
        {
            Teacher tch1 = new Teacher();//Teacher is class name. tch1 is object name. we can take many objects from one class and every object has different properties.
            tch1.name = "Ammar";//name is one property of class that i can give object
            tch1.className = "programming";// class name is one property of class that i can give object
            tch1.teacherPhoneNum = "9999999";//teacher number is one property of class that i can give object

            Console.WriteLine("teacher name: " +tch1.name);
            Console.WriteLine("class name: " + tch1.className);
            Console.WriteLine("teacher phone number: " + tch1.teacherPhoneNum);

            tch1.teacherDo();

        }
    }
}