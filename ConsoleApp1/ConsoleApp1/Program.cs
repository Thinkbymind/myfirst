using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //第一部分：
            //Student wx = new Student();
            //wx.age = 18;
            //wx.name = "微信用户";
            //wx.Enroll();
            //Student clone = new Student();
            //clone.age = 20;
            //clone.name = "克隆用户";
            //clone.Enroll();
            //Console.WriteLine("已经完成");
            //第二部分：
            //User fg = new User();
            //fg.name = "飞哥";
            //fg.bMoney = 100;
            //Article atl = new Article();
            //atl.title = "锋利的C#";
            //atl.author = fg;
            //atl.Publish();
            //Console.WriteLine(fg.name+"的金额剩余："+fg.bMoney);
            //第三部分：

            Student student = new Student("大飞");
            student.diaoyong();
            Console.WriteLine("完毕");
            
        }

        class Student
        {
            private string name;
            public Student(string name)
            {
                this.name = name;
            }
            public void diaoyong()
            {
                Console.WriteLine("这个学生的名字是："+name);
            }
        }

        //class User
        //{
        //    public string name;
        //    public Article[] articles;  //为什么就不是static的呢？对比Student.enroll()
        //    public int bMoney;
        //}
        //class Article
        //{
        //    public string title;
        //    public User author;
        //    public void Publish()
        //    {
        //        author.bMoney--;
        //        Console.WriteLine(title);
        //        //article 添加到 articles
        //    }
        //}

        //static Student[] students = new Student[18];
        //class Student
        //{
        //    public string name;
        //    public int age;
        //    public void Enroll()
        //    {
        //        for (int i = 0; i < students.Length; i++)
        //        {
        //            //找到一个为null值的“空位”
        //            if (students[i] == null)
        //            {
        //                //把新同学放到空位中
        //                students[i] = this;
        //                return;
        //            }
        //        }

        //    }
        //}
    }


}