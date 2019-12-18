using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace bubbleSort
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
      
        }
        int[] DrawDigits(int n, int max = 100, int min = 0)
        {
            System.Random r = new System.Random((int)System.DateTime.Now.Ticks);
            int[] result = new int[n];
            for (int i = 0; i < result.Length; i++)
            {
                result[i] = r.Next(min, max + 1);
            }

            return result;
        }

        #region BubbleSort
        public int[] BubleSort(int[] tab)
        {
            bool doSwap = false;
            do
            {
                doSwap = false;
                for (int i = 0; i < tab.Length - 1; i++)
                {
                    if (tab[i] > tab[i + 1])
                    {
                        var tmp = tab[i];
                        tab[i] = tab[i + 1];
                        tab[i + 1] = tmp;
                        doSwap = true;
                    }
                }
            } while (doSwap);

            return tab;
        }
        #endregion

        #region InsertSort

        public int[] InsertSort(int[] array)
        {
            for (int i = 1; i < array.Length; i++)
            {
                int valueOfArray = array[i];
                int j = i - 1;
                while (j >= 0 && array[j] > valueOfArray)
                {
                    array[j + 1] = array[j];
                    j--;
                }

                array[j + 1] = valueOfArray;
            }

            return array;
        }

        #endregion

        #region  SelectSort

        public int[] SelectSort(int[] tab)
        {
            for (int i = 0; i < tab.Length - 1; i++)
            {
                int min = i;
                for (int j = i + 1; j < tab.Length; j++)
                {
                    if (tab[j] < tab[min])
                        min = j;
                }

                if (min != i)
                {
                    int tmp = 0;
                    tmp = tab[i];
                    tab[i] = tab[min];
                    tab[min] = tmp;
                }
            }

            return tab;
        }

        #endregion

        #region CountingSort
        public int[] CountingSort(int[] array)
        {
            int[] tab = new int[array.Max() + 1];
            for (int i = 0; i < array.Length; i++)
                ++tab[array[i]];
            for (int i = 1; i < array.Max() + 1; i++)
                tab[i] += tab[i - 1];

            int[] tab2 = new int[array.Length];

            for (int i = array.Length - 1; i >= 0; i--)
                tab2[--tab[array[i]]] = array[i];

            return tab2;
        }

        #endregion

        #region Merge

        public int[] Merge(int[] array)
        {
            if (array.Length <= 1) return array;

            var leftArray = new int[array.Length / 2];
            var rightArray = new int[array.Length - (array.Length / 2)];

            
            for (int i = 0; i < leftArray.Length; i++)
                leftArray[i] = array[i];

            for (int i = 0; i < rightArray.Length; i++)
                rightArray[i] = array[i + leftArray.Length];

            leftArray = Merge(leftArray);
            rightArray = Merge(rightArray);

            return mergeSort(leftArray, rightArray);
        }

        public int[] mergeSort(int[] arrayLeft, int[] arrayRight)
        {

            var result = new int[arrayLeft.Length + arrayRight.Length]; //jebany rozmiar tablicy napraw to

            int x = 0, y = 0, z = 0;

            while (x < arrayLeft.Length && y < arrayRight.Length)
            {
                if (arrayLeft[x] < arrayRight[y])
                {
                    result[z] = arrayLeft[x];
                    x++;
                }
                else
                {
                    result[z] = arrayRight[y];
                    y++;
                }

                z++;
            }

            while (x < arrayLeft.Length)
            {
                result[z] = arrayLeft[x];
                x++;
                z++;
            }

            while (y < arrayRight.Length)
            {
                result[z] = arrayRight[y];
                y++;
                z++;
            }

            return result;

        }

        #endregion



        int[] Conversion(string digOfStr)
        {
            string[] digitsTabOfStr = digOfStr.Split(new char[] { ' ' }, System.StringSplitOptions.RemoveEmptyEntries);
            int[] digitsTabOfInt = new int[digitsTabOfStr.Length];

            for (int i = 0; i < digitsTabOfStr.Length; i++)
            {
                digitsTabOfInt[i] = int.Parse(digitsTabOfStr[i].Trim());
            }

            return digitsTabOfInt;
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            string digitsOfStr = textBox1.Text;
            int[] digitsTabOfInt = Conversion(digitsOfStr);
            digitsTabOfInt = BubleSort(digitsTabOfInt);
            textBox1.Text = string.Join("  ", digitsTabOfInt);
        }
        private void button1_MouseEnter(object sender, System.EventArgs e)
        {
            this.Cursor = System.Windows.Forms.Cursors.Default;
        }

        private void button1_MouseLeave(object sender, System.EventArgs e)
        {
            this.Cursor = System.Windows.Forms.Cursors.Default;
        }
        private void textBox1_TextChanged(object sender, System.EventArgs e)
        {

        }

        private void button2_Click(object sender, System.EventArgs e)
        {
            string digitsOfStr = textBox1.Text;
            int[] digitsTabOfInt = Conversion(digitsOfStr);
            digitsTabOfInt = InsertSort(digitsTabOfInt);
            textBox1.Text = string.Join("  ", digitsTabOfInt);
        }
        private void button2_MouseLeave(object sender, System.EventArgs e)
        {
            this.Cursor = System.Windows.Forms.Cursors.Default;
        }
        private void textBox2_TextChanged(object sender, System.EventArgs e)
        {

        }

        private void button3_Click(object sender, System.EventArgs e)
        {
            string digitsOfStr = textBox1.Text;
            int[] digitsTabOfInt = Conversion(digitsOfStr);
            digitsTabOfInt = SelectSort(digitsTabOfInt);
            textBox1.Text = string.Join("  ", digitsTabOfInt);
        }
        private void button3_MouseEnter(object sender, System.EventArgs e)
        {
            this.Cursor = System.Windows.Forms.Cursors.Default;
        }

        private void button3_MouseLeave(object sender, System.EventArgs e)
        {
            this.Cursor = System.Windows.Forms.Cursors.Default;
        }

        private void button4_Click(object sender, System.EventArgs e)
        {
            string digitsOfStr = textBox1.Text;
            int[] digitsTabOfInt = Conversion(digitsOfStr);
            digitsTabOfInt = CountingSort(digitsTabOfInt);
            textBox1.Text = string.Join("  ", digitsTabOfInt);
        }



        private void backgroundWorker1_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            int[] tab = e.Argument as int[];
            int counter = 0;
            bool doSwap = false;
            do
            {
                this.Invoke((System.Windows.Forms.MethodInvoker)delegate {
                });
                counter++;
            } while (doSwap);
            e.Result = tab;
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            int[] digits = e.Result as int[];
            textBox1.Text = string.Join("  ", digits);
        }
        private void button6_Click(object sender, System.EventArgs e)
        {
            int[] digits = Conversion(textBox1.Text);
            digits = DrawDigits(100);
            backgroundWorker1.RunWorkerAsync(digits);
        }
        private void Form1_Load(object sender, System.EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, System.EventArgs e)
        {

        }

        private void button5_Click(object sender, System.EventArgs e)
        {
            string digitsOfStr = textBox1.Text;
            int[] digitsTabOfInt = Conversion(digitsOfStr);
            digitsTabOfInt = Merge(digitsTabOfInt);
            textBox1.Text = string.Join("  ", digitsTabOfInt);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }
    }
}
