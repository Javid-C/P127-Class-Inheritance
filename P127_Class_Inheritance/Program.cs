using System;
using System.Text;

namespace P127_Class_Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {

            #region HomeWork
            //Console.Write("\n Kicik herfleri boyuk,boyuk herflri kicik yazin:");
            //Console.Write( "\n Metninizi daxil edin \n");
            //string str = Console.ReadLine();
            //char[] chChar = str.ToCharArray();

            //for (int i = 0; i < chChar.Length; i++)
            //{
            //    if (char.IsUpper(chChar[i]))
            //    {
            //        chChar[i]=char.ToLower(chChar[i]);
            //    }
            //    else
            //    {
            //        chChar[i]=char.ToUpper(chChar[i]);
            //    }


            //}
            //str = new string(chChar);
            //Console.WriteLine(str);


            //string avaz = "";
            //foreach (char letter in chChar)
            //{
            //    char other = letter;
            //    if (char.IsUpper(other))
            //    {
            //        other = char.ToLower(letter);

            //    }
            //    else
            //    {
            //        other = char.ToUpper(letter);
            //    }
            //    avaz += other;


            //}

            //Console.WriteLine(avaz);

            //Console.WriteLine(ChangeStr(str));
            #endregion

            //int num = 5;
            //for (int i = 0; i < 5; i++)
            //{
            //    num += i;
            //}
            //Console.WriteLine(num);


            string str = "okay";
            for (int i = 0; i < 5; i++)
            {
                str += i;

            }
            Console.WriteLine(str);



            //string wrongStr = "   Bu.cumle.yanlis.yazilib    ";
            //Console.WriteLine(Sentence(wrongStr));

            //StringBuilder stringBuilder = new StringBuilder();
            //stringBuilder.AppendLine("a");
            //stringBuilder.Append('a');
            //stringBuilder.Append('a');
            //Console.WriteLine(stringBuilder);



            Human human = new Human("Avaz","Mammadli",24,180,80,"Male");

            Console.WriteLine(human.GetFullname());
            Console.WriteLine(human.GetInfo());

            Human human1 = new Human("Rabil", "Alakbarov", 21, 30.2d, 230d, "Male");
           
            Console.WriteLine(human1.GetInfo());

            Human human2 = new Human("Oruc", "Dostuyev", 16, 190, 20, "Male");
            Console.WriteLine(human2.GetFullname());

            //string name = "Kamran";
            //string surname = "Abilov";
            //int age = 30;

            //string[] arr = { name, surname };

            //Console.WriteLine("{0} {1} {2}","okay",arr[1],age);




        }

        #region HomeWork
        //public static string ChangeStr(string text)
        //{
        //    string newStr = "";
        //    foreach (char letter in text)
        //    {
        //        char other = letter;
        //        if (char.IsUpper(other))
        //        {
        //            other = char.ToLower(letter);

        //        }
        //        else
        //        {
        //            other = char.ToUpper(letter);
        //        }
        //        newStr += other;


        //    }
        //    return newStr;
        //}

        //public static string Sentence(string text)
        //{
        //    //string newStr = "";
        //    text = text.Trim();
        //    string[] arr = text.Split('.');
        //    StringBuilder stringBuilder = new StringBuilder();
        //    for (int i = 0; i < arr.Length; i++)
        //    {
        //        stringBuilder.Append(arr[i]+" ");
        //    }


        //    return stringBuilder.ToString();

        //}
        #endregion

    }

    class Human
    {
        // fields
        public string Name;
        public string Surname;
        public int Age;
        public double Weight;
        public double Height;
        public string Gender;

        public Human(string name,string surname,int age,double weight,double height, string gender)
        {
            Name = name;
            Surname = surname;
            Age = age;
            Weight = weight;
            Height = height;
            Gender = gender;
        }

        public string GetFullname()
        {
            return Name + " " + Surname;
        }

        public string GetInfo()
        {
            //return Name + " " + Surname + " " + Age + " " + Gender + " " + Weight + " " + Height;

            return $"Name: {Name}\nSurname: {Surname}\nAge: {Age}\nGender: {Gender}\nWeight: {Weight}\nHeight: {Height} ";

            //return "{0},{1},{2}";
        }

    }
}
