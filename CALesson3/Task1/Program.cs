using System;
using System.Collections.Generic;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;

namespace Task1
{
    
    public class PointClass
    {
        public float X;
        public float Y;        
    }
    
    public class PointStruct
    {
        public float X;
        public float Y;
    }

    public class PointStructD
    {
        public double X;
        public double Y;
    }

    public class listPoint
    {
        public List<PointClass> listPC;
        public List<PointStruct> listPS;
        public List<PointStructD> listPD;

        public listPoint()
        {
            listPC = new List<PointClass>();
            Random random = new Random(50);
            for (int i = 0; i < 10; i++)
            {
                PointClass pC = new PointClass();
                pC.X = random.Next();
                pC.Y = random.Next();
                listPC.Add(pC);
            }

            listPS = new List<PointStruct>();            
            for (int i = 0; i < 10; i++)
            {
                PointStruct pS = new PointStruct();
                pS.X = random.Next();
                pS.Y = random.Next();
                listPS.Add(pS);
            }

            listPD = new List<PointStructD>();
            for (int i = 0; i < 10; i++)
            {
                PointStructD pD = new PointStructD();
                pD.X = random.Next();
                pD.Y = random.Next();
                listPD.Add(pD);
            }
        }
    }   



    class Program
    {        

        static void Main(string[] args)
        {

            //listPoint lPC = new listPoint();
            //List<PointClass> list = lPC.listPC;
            //List<PointClass> lPointClass = new List<PointClass>();
            //var randomValue = new Random(50);            
            /*for (int i = 0; i < 10; i++)
            {
                lPointClass.Add(new PointClass { X = randomValue.Next(), Y = randomValue.Next() });
            }*/
            BenchmarkSwitcher.FromAssembly(typeof(Program).Assembly).Run(args);
        }
    }

    public class BechmarkClass
    {        

        public static float PointDistanceClassFloat(PointClass pointOne, PointClass pointTwo)
        {              
            float x = pointOne.X - pointTwo.X;
            float y = pointOne.Y - pointTwo.Y;
            return MathF.Sqrt((x * x) + (y * y));
        }

        public static float PointDistanceStructFloat(PointStruct pointOne, PointStruct pointTwo)
        {
            float x = pointOne.X - pointTwo.X;
            float y = pointOne.Y - pointTwo.Y;
            return MathF.Sqrt((x * x) + (y * y));
        }

        public static float PointDistanceStructFloatNoSqrt(PointStruct pointOne, PointStruct pointTwo)
        {
            float x = pointOne.X - pointTwo.X;
            float y = pointOne.Y - pointTwo.Y;
            return (x * x) + (y * y);
        }

        public static double PointDistanceStructDouble(PointStructD pointOne, PointStructD pointTwo)
        {
            double x = pointOne.X - pointTwo.X;
            double y = pointOne.Y - pointTwo.Y;
            return Math.Sqrt((x * x) + (y * y));
        }

       [Benchmark]
        public void TestPointDistanceClassFloat()
        {
            listPoint lPC = new listPoint();
            List<PointClass> list = lPC.listPC;
            for (int i = 0; i < list.Count-1; i++)
            {
                PointClass pointOne = new PointClass { X = list[i].X, Y = list[i].Y };
                PointClass pointTwo = new PointClass { X = list[i].X, Y = list[i].Y };
                PointDistanceClassFloat(pointOne, pointTwo);
            }            
        }

        [Benchmark]
        public void TestPointDistanceStructFloat()
        {
            listPoint lPC = new listPoint();
            List<PointStruct> list = lPC.listPS;
            for (int i = 0; i < list.Count - 1; i++)
            {
                PointStruct pointOne = new PointStruct { X = list[i].X, Y = list[i].Y };
                PointStruct pointTwo = new PointStruct { X = list[i].X, Y = list[i].Y };
                PointDistanceStructFloat(pointOne, pointTwo);
            }
        }

        [Benchmark]
        public void TestPointDistanceStructFloatNoSqrt()
        {
            listPoint lPC = new listPoint();
            List<PointStruct> list = lPC.listPS;
            for (int i = 0; i < list.Count - 1; i++)
            {
                PointStruct pointOne = new PointStruct { X = list[i].X, Y = list[i].Y };
                PointStruct pointTwo = new PointStruct { X = list[i].X, Y = list[i].Y };
                PointDistanceStructFloatNoSqrt(pointOne, pointTwo);
            }
        }

        [Benchmark]
        public void TestPointDistanceStructDouble()
        {
            listPoint lPD = new listPoint();
            List<PointStructD> list = lPD.listPD;
            for (int i = 0; i < list.Count - 1; i++)
            {
                PointStructD pointOne = new PointStructD { X = list[i].X, Y = list[i].Y };
                PointStructD pointTwo = new PointStructD { X = list[i].X, Y = list[i].Y };
                PointDistanceStructDouble(pointOne, pointTwo);
            }
        }
    }
    
}
