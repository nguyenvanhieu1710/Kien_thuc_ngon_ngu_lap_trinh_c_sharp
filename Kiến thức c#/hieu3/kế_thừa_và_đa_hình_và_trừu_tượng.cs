using System;

namespace MyApplication
{
    class Animal  // lớp cha 
    {
        public virtual void animalSound()// virtual là ghi đè lên của lớp cha(bắt buộc phải có từ này)
        {
            Console.WriteLine("The animal makes a sound");
        }
        public void sleep()
        {
            Console.WriteLine("Zzz");
        }
    }

    class Pig : Animal  // lớp con 
    {
        public override void animalSound()// override là ghi đè cuả lớp con(bắt buộc phải có từ này)
        {
            Console.WriteLine("The pig says: wee wee");
        }  
    }

    class Dog : Animal  // Derived class (child) 
    {
        public override void animalSound()
        {
            Console.WriteLine("The dog says: bow wow");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Animal myAnimal = new Animal();  // Create a Animal object
            Animal myPig = new Pig();  // Create a Pig object
            Animal myDog = new Dog();  // Create a Dog object

            myAnimal.animalSound();
            myPig.animalSound();
            myDog.animalSound();
            myPig.sleep();// từ lớp con trích xuất lấy của lớp cha
        }
    }
}