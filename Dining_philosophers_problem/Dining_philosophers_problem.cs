using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dining_philosophers_problem
{
    public partial class Dining_philosophers_problem : Form
    {
        public Dining_philosophers_problem()
        {
            InitializeComponent();
        }

        Semaphore room = new Semaphore(4, 4);
        Semaphore[] chopstick = {
            new Semaphore(1,1),
            new Semaphore(1,1),
            new Semaphore(1,1),
            new Semaphore(1,1),
            new Semaphore(1,1)
        };

        private delegate void Mywork0();//delegate方法；
        private delegate void Mywork1();
        private delegate void Mywork2();
        private delegate void Mywork3();
        private delegate void Mywork4();

        private static void work0()
        {
            return;
        }//被调用方法；
        private static void work1()
        {
            return;
        }
        private static void work2()
        {
            return;
        }
        private static void work3()
        {
            return;
        }
        private static void work4()
        {
            return;
        }

        private void work0completed(IAsyncResult asyncResult)
        {
            while (true)
            {
                philosopher0.Image = Resource1.think;
                Thread.Sleep(4000);
                philosopher0.Image = Resource1.pause;
                room.WaitOne();
                chopstick[0].WaitOne();
                chopstick[1].WaitOne();
                philosopher0.Image = Resource1.eat;
                chopstick0.Image = Resource1.chopstick;
                chopstick1.Image = Resource1.chopstick;
                Thread.Sleep(6000);
                chopstick0.Image = Resource1.chopstick_;
                chopstick1.Image = Resource1.chopstick_;
                chopstick[0].Release();
                chopstick[1].Release();
                room.Release();
            }
        }//回调函数；
        private void work1completed(IAsyncResult asyncResult)
        {
            while (true)
            {
                philosopher1.Image = Resource1.think;
                Thread.Sleep(4000);
                philosopher1.Image = Resource1.pause;
                room.WaitOne();
                chopstick[1].WaitOne();
                chopstick[2].WaitOne();
                philosopher1.Image = Resource1.eat;
                chopstick1.Image = Resource1.chopstick;
                chopstick2.Image = Resource1.chopstick;
                Thread.Sleep(6000);
                chopstick1.Image = Resource1.chopstick_;
                chopstick2.Image = Resource1.chopstick_;
                chopstick[1].Release();
                chopstick[2].Release();
                room.Release();
            }
        }
        private void work2completed(IAsyncResult asyncResult)
        {
            while (true)
            {
                philosopher2.Image = Resource1.think;
                Thread.Sleep(4000);
                philosopher2.Image = Resource1.pause;
                room.WaitOne();
                chopstick[2].WaitOne();
                chopstick[3].WaitOne();
                philosopher2.Image = Resource1.eat;
                chopstick2.Image = Resource1.chopstick;
                chopstick3.Image = Resource1.chopstick;
                Thread.Sleep(6000);
                chopstick2.Image = Resource1.chopstick_;
                chopstick3.Image = Resource1.chopstick_;
                chopstick[2].Release();
                chopstick[3].Release();
                room.Release();
            }
        }
        private void work3completed(IAsyncResult asyncResult)
        {
            while (true)
            {
                philosopher3.Image = Resource1.think;
                Thread.Sleep(4000);
                philosopher3.Image = Resource1.pause;
                room.WaitOne();
                chopstick[3].WaitOne();
                chopstick[4].WaitOne();
                philosopher3.Image = Resource1.eat;
                chopstick3.Image = Resource1.chopstick;
                chopstick4.Image = Resource1.chopstick;
                Thread.Sleep(6000);
                chopstick3.Image = Resource1.chopstick_;
                chopstick4.Image = Resource1.chopstick_;
                chopstick[3].Release();
                chopstick[4].Release();
                room.Release();
            }
        }
        private void work4completed(IAsyncResult asyncResult)
        {
            while (true)
            {
                philosopher4.Image = Resource1.think;
                Thread.Sleep(4000);
                philosopher4.Image = Resource1.pause;
                room.WaitOne();
                chopstick[4].WaitOne();
                chopstick[0].WaitOne();
                philosopher4.Image = Resource1.eat;
                chopstick4.Image = Resource1.chopstick;
                chopstick0.Image = Resource1.chopstick;
                Thread.Sleep(6000);
                chopstick4.Image = Resource1.chopstick_;
                chopstick0.Image = Resource1.chopstick_;
                chopstick[4].Release();
                chopstick[0].Release();
                room.Release();
            }
        }

        private void start_Click(object sender, EventArgs e)
        {
            pause.Enabled = true;
            if (pause_pictureBox.Visible == true)
            {
                pause_pictureBox.Visible = false;
                return;
            }
            Mywork0 my0 = work0;
            Mywork0 my1 = work0;
            Mywork0 my2 = work0;
            Mywork0 my3 = work0;
            Mywork0 my4 = work0;
            IAsyncResult asyncResult0 = my0.BeginInvoke(work0completed, my0);
            IAsyncResult asyncResult1 = my1.BeginInvoke(work1completed, my1);
            IAsyncResult asyncResult2 = my2.BeginInvoke(work2completed, my2);
            IAsyncResult asyncResult4 = my4.BeginInvoke(work4completed, my4);
            IAsyncResult asyncResult3 = my3.BeginInvoke(work3completed, my3);
        }

        private void pause_Click(object sender, EventArgs e)
        {
            pause_pictureBox.Visible = true;
        }

        private void Dining_philosophers_problem_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            philosopher0.Image = Resource1.pause;
            philosopher1.Image = Resource1.pause;
            philosopher2.Image = Resource1.pause;
            philosopher3.Image = Resource1.pause;
            philosopher4.Image = Resource1.pause;
            chopstick0.Image = Resource1.chopstick_;
            chopstick1.Image = Resource1.chopstick_;
            chopstick2.Image = Resource1.chopstick_;
            chopstick3.Image = Resource1.chopstick_;
            chopstick4.Image = Resource1.chopstick_;
            pause.Enabled = false;
            pause_pictureBox.Image = Resource1.pause1;
            pause_pictureBox.Visible = false;
        }
    }
}
