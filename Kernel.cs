using Cosmos.System.Graphics;
using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using Cosmos.System.Graphics;
using Sys = Cosmos.System;
using System.Security.Cryptography;
using System.Threading;
using Cosmos.Core.IOGroup;

namespace Cosmosvirtual
{
    

    class graf
    {
        public static Canvas canvas;
        public static Bitmap bitmap;

        public static void Points(int x, int y)
        {


            Pen p = new Pen(Color.FromArgb(0, 0, 0));
            canvas.DrawPoint(p, x, y);





        }

        public static void starts()
        {


            canvas = FullScreenCanvas.GetFullScreenCanvas();
            Sys.MouseManager.ScreenWidth=(uint) 1020;
            Sys.MouseManager.ScreenHeight =(uint) 798;



        }
        public static void displays()
        {

            canvas.Display();


        }
        public static void cls(Color c)
        {


            canvas.Clear(c);

        }

    }


    public class Kernel : Sys.Kernel
    {
        static int x = 0;static int y = 0;
        protected override void BeforeRun()
        {
            Console.WriteLine("Cosmos booted successfully. Type a line of text to get it echoed back.");
        }

        protected override void Run()
        {
            while (true) 
            {  
                graf.starts();
                
                while (true)
                {
                        Thread.Sleep(200);
                     
                        tests.mainLoop();
    

                    
                    ;

                }
            }
            
            
        }
    }





    class tests



    {


        public static void mainLoop()
        {
            //


            Pen p = new Pen(Color.Black, 1);
            graf.canvas.Clear(Color.White);
            
            if((int)Sys.MouseManager.Y>=0 && (int)Sys.MouseManager.X>=0 && (int)Sys.MouseManager.Y<800 && (int)Sys.MouseManager.X < 1024) { 
                graf.canvas.DrawLine(p, 0,(int) Sys.MouseManager.Y, 1024, (int)Sys.MouseManager.Y);
                graf.canvas.DrawLine(p, 0, 800, (int)Sys.MouseManager.X, (int)Sys.MouseManager.Y);
                graf.canvas.DrawLine(p, 1024, 800, (int)Sys.MouseManager.X, (int)Sys.MouseManager.Y);
                graf.displays();
            }
            
        }

    }





}
