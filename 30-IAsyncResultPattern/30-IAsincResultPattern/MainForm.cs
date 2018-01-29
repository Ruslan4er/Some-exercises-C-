using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _30_IAsincResultPattern
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private int counter;
        private Func<int, int, int> function;
        private AsyncCallback callback;
        private SynchronizationContext sync;

        private int Add(int x1,int x2)
        {
            Thread.Sleep(1000);
            return x1 + x2;
        }

        private void IsCompleteButton_Click(object sender, EventArgs e)
        {
            function =Add;
            var func = function.BeginInvoke(1,2,null,null);
            while (!func.IsCompleted)
            {
                Thread.Sleep(100);
            }
            MessageBox.Show(@"Операция выполнена!");

            label1.Text = string.Format("Результат: {0}", function.EndInvoke(func));

        }

        private void EndButton_Click(object sender, EventArgs e)
        {
            function = Add;
            var func = function.BeginInvoke(3, 2, null, null);
            MessageBox.Show(@"Операция выполнена!");
            label1.Text = string.Format("Результат: {0}", function.EndInvoke(func));
        }




        private void CallBack(IAsyncResult asyncResult)
        {
            var async = asyncResult as AsyncResult;
            var delegateAdd = async.AsyncDelegate as Func<int,int,int>;
            var result = delegateAdd.EndInvoke(asyncResult);
            sync.Post(delegate { label1.Text = result.ToString(); },null);
            MessageBox.Show(asyncResult.AsyncState.ToString());
        }

        private void CallBackButton_Click(object sender, EventArgs e)
        {
            callback = CallBack;
            function = Add;

            sync = SynchronizationContext.Current;;

            var func = function.BeginInvoke(4, 2, callback, "Данные сообщенные вместе с callback методом");

            MessageBox.Show(@"CallBack метод завершен");
        }
    }
}
