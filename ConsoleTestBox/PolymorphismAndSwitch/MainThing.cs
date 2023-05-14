using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleTestBox.PolymorphismAndSwitch
{
    public class MainThing
    {
        public void MainProgress()
        {
            //比較多型與switch間的速度差別 switch大約快兩倍


            List<Animal> animals = new List<Animal>();

            animals.Add(new Dog());
            animals.Add(new Cat());
            animals.Add(new Dog());
            animals.Add(new Horse());

            string soundGet;

            Dictionary<string, string> dic = new Dictionary<string, string>();
            dic.Add("ConsoleTestBox.Dog", "汪");
            dic.Add("ConsoleTestBox.Cat", "喵");
            dic.Add("ConsoleTestBox.Horse", "嘶");


            using (CountingTime.CountingTimeObject time = new CountingTime.CountingTimeObject("poly"))
            {
                for (int i = 0; i < 10000; i++)
                {
                    foreach (var animal in animals)
                    {
                        soundGet = animal.Boo();
                    }
                }
            }
            using (CountingTime.CountingTimeObject time = new CountingTime.CountingTimeObject("switch"))
            {
                for (int i = 0; i < 10000; i++)
                {
                    foreach (var animal in animals)
                    {
                        switch (animal.GetType().ToString())
                        {
                            case "ConsoleTestBox.Dog":
                                soundGet = "汪";
                                break;
                            case "ConsoleTestBox.Cat":
                                soundGet = "喵";
                                break;
                            case "ConsoleTestBox.Horse":
                                soundGet = "嘶";
                                break;
                        }
                    }
                }
            }
            using (CountingTime.CountingTimeObject time = new CountingTime.CountingTimeObject("dic"))
            {
                for (int i = 0; i < 10000; i++)
                {
                    foreach (var animal in animals)
                    {
                        soundGet = dic[animal.GetType().ToString()];
                    }
                }
            }
        }
    }
    public abstract class Animal
    {
        public abstract string Boo();
    }

    public class Cat : Animal
    {
        public override string Boo()
        {
            return "汪";
        }
    }
    public class Dog : Animal
    {
        public override string Boo()
        {
            return "喵";
        }
    }

    public class Horse : Animal
    {
        public override string Boo()
        {
            return "嘶";
        }
    }
}
