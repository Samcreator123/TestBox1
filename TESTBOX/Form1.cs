using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Diagnostics;
using Dapper;
using System.IO;
using System.Globalization;

namespace TESTBOX
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //拆分工具
        //如果linq b select a再 b取出第一個為c 將c修改不會影響到a
        //但a 取出第一個為b 對b做修改會影響到a
        private void button1_Click(object sender, EventArgs e)
        {
            IntClass[] a = new IntClass[] { new IntClass(1), new IntClass(2), new IntClass(3) };

            IntClass[] b = a.Select(o=>new IntClass(o.num+1)).ToArray();
            IntClass c = a.First();
            c.num -= 1;
            Debug.WriteLine(a.First());
            foreach (var item in a)
            {
                Debug.WriteLine(item.num);
            }

            foreach (var item in b)
            {
                Debug.WriteLine(item.num);
            }
            foreach (var item in a)
            {
                Debug.WriteLine(item.num);
            }

        }
        
        private void LinqTestByAddress()
        {
            IntClass[] originalArray = new IntClass[]{ new IntClass(8)
                , new IntClass(5), new IntClass(1)
                , new IntClass(6), new IntClass(5)
                , new IntClass(2), new IntClass(3) };

            var selectArray = from o in originalArray
                              where o.num < 5
                              orderby o.num ascending
                              select o;

            twoArrayInDebug<int, int>(originalArray.Select(o => o.num).ToArray()
                                    , selectArray.Select(o => o.num).ToArray());

            foreach (var a in selectArray)
            {
                a.num -= 1;
            }
            twoArrayInDebug<int, int>(originalArray.Select(o => o.num).ToArray()
                                , selectArray.Select(o => o.num).ToArray());

            var b = originalArray.First();
            Debug.WriteLine(b.num);
            MinusOne(b);
            Debug.WriteLine("");
            Debug.WriteLine("");
            Debug.WriteLine("");
            foreach (var a in originalArray)
            {
                Debug.WriteLine(a.num);
            }
            Debug.WriteLine("");
            MinusOne(originalArray);
            foreach (var a in originalArray)
            {
                Debug.WriteLine(a.num);
            }
        }
        private void MinusOne(IntClass a)
        {
            a.num -= 1;
        }
        private void MinusOne(IntClass[] a)
        {
            a.First().num -= 1;
        }
        private void twoArrayInDebug<T1,T2>(T1[] firstArray ,T2[] secondArray)
        {

            Debug.WriteLine($"{nameof(firstArray)}");

            foreach (var a in firstArray)
            {
                Debug.WriteLine(a);
            }

            Debug.WriteLine($"{nameof(secondArray)}");

            foreach (var b in secondArray)
            {
                Debug.WriteLine(b);
            }
        }
        private void MakeATXT()
        {
            string path = @"C:\Users\user\Desktop\RT47";
            string line = "";
            List<string> listOfRT47 = new List<string>();

            using (StreamReader sr = new StreamReader(path, Encoding.ASCII))
            {
                while ((line = sr.ReadLine()) != null)
                {
                    SplitStringByLen(line, 160, out listOfRT47);
                }
            }
            bool stopPoint = true;

            string writePath = @"C:\Users\user\Desktop\新增 文字文件 (2).txt";

            using (StreamWriter sw = new StreamWriter(writePath))
            {
                StringBuilder lineOfWrite = new StringBuilder();
                int theMaxOfLine = 14;
                int propertyNum = 19;
                int indexNow = 0;
                int[] propertyLen = new int[] { 6, 2, 8, 8, 8, 8, 8, 8, 8, 14, 13, 9, 12, 13, 12, 1, 8, 10, 4 };
                for (int i = 0; i < 19; i++)
                {
                    lineOfWrite.Clear();
                    foreach (string lineOfRT47 in listOfRT47)
                    {
                        byte[] templine = Encoding.ASCII.GetBytes(lineOfRT47, indexNow, propertyLen[i]);
                        string tempString = Encoding.ASCII.GetString(templine);
                        if (tempString.Length < theMaxOfLine)
                        {
                            tempString = tempString.PadLeft(theMaxOfLine);
                        }
                        lineOfWrite.Append(tempString + "|");
                    }
                    sw.WriteLine(lineOfWrite.ToString());
                    indexNow += propertyLen[i];
                }
            }
        }
        private void SplitStringByLen(string line, int length, out List<string> listOfString)
        {
            listOfString = new List<string>();
            byte[] byteOfLine = Encoding.ASCII.GetBytes(line);
            int nowIndex = 0;
            int allLen = line.Length - 1;//都從0開始計算
            while (true)
            {
                if (nowIndex > allLen)
                {
                    break;
                }
                listOfString.Add(Encoding.ASCII.GetString(byteOfLine,nowIndex,length));
                nowIndex += length;
            }
        }
    }

    public class student
    {
        private string age;
        private decimal height;
        private decimal weight;

        public string Age { get => age; set => age = value; }
        public decimal Height { get => height; set => height = value; }
        public decimal Weight { get => weight; set => weight = value; }

        public student(string age, decimal height, decimal weight)
        {
            this.age = age;
            this.height = height;
            this.weight = weight;
        }
    }
    public class IntClass
    {
        public int num { get; set; } = 0;

        public IntClass(int num)
        { 
            this.num = num;
        }
    }
}
