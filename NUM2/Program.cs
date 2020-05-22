using System;

namespace NUM2
{

     sealed class information
    {
        private string ID="";
        private string cipher="";

        public string UserId
        {
            get
            {
                return ID;
            }
            set
            {
                ID = value;
            }
        }
        public string UserCipher
        {
            get
            {
                return cipher;
            }
            set
            {
                cipher = value;
            }
        }
        public void showinformation()
        {
            Console.WriteLine("用户名：" + ID);
            Console.WriteLine("密  码：" + cipher);
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            information i = new information();
            Console.WriteLine("请输入用户名：");
            i.UserId = Console.ReadLine();
            Console.WriteLine("请输入密码：");
            i.UserCipher= Console.ReadLine();
            i.showinformation();
        }
    }
}
