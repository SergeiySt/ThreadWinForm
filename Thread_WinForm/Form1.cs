using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Diagnostics;

namespace Thread_WinForm
{
    public partial class Form1 : Form
    {
        private int numThreads;
      
        private int[] dataArray;
        private int[] processedArray;
        static Stopwatch stopwatch = new Stopwatch();
        private Thread processingThread;
        private Thread[] threads;

        public Form1()
        {
            InitializeComponent();

            numThreads = Environment.ProcessorCount;

            label_ProcessorCount.Text = $"{numThreads}";
        }

        private void button_Start_Click(object sender, EventArgs e)
        {
            richTextBox_Result.Clear();

            int arraySize = int.Parse(textBox_A.Text);
            dataArray = GenerateArray(arraySize);
            processedArray = new int[arraySize];
            stopwatch.Start();

            //processingThread = new Thread(ProcessArray);
            //processingThread.Start();

            threads = new Thread[numThreads];

            for (int i = 0; i < numThreads; i++)
            {
                int threadIndex = i; // Захватываем локальную копию переменной цикла
                threads[i] = new Thread(() => ProcessArray(threadIndex));
                threads[i].Start();
            }

            foreach (Thread thread in threads)
            {
                thread.Join();
            }

            stopwatch.Stop();

            PrintResult("Результати обробки масиву даних:");

            //for (int i = 0; i < dataArray.Length; i++)
            //{
            //    PrintResult(dataArray[i].ToString());
            //}
            for (int i = 0; i < processedArray.Length; i++)
            {
                PrintResult(processedArray[i].ToString());
            }

          
            //processingThread.Join();
            PrintResult("Час виконання: " + stopwatch.Elapsed);
            PrintResult("Кількість потоків: " + numThreads);
         
            
        }

        private void ProcessArray(int threadIndex)
        {
            int start = threadIndex * (dataArray.Length / numThreads);
            int end = (threadIndex == numThreads - 1) ? dataArray.Length : (threadIndex + 1) * (dataArray.Length / numThreads);

            if (checkBox_Summ.Checked)
            {
                int sum = CalculateSum(start, end);
                processedArray[threadIndex] = sum;
            }

            if (checkBox_MaxElement.Checked)
            {
                int max = FindMax(start, end);
                processedArray[threadIndex] = max;
            }

            if (checkBox_MinElement.Checked)
            {
                int min = FindMin(start, end);
                processedArray[threadIndex] = min;
            }
        }

        //private void ProcessArray()
        //{
        //    if (checkBox_Summ.Checked)
        //    {
        //        int[] sum = CalculateSum();
        //        PrintResult("Сумма: " + string.Join(", ", sum));
        //    }

        //    if (checkBox_MaxElement.Checked)
        //    {
        //        int[] max = FindMax();
        //        PrintResult("Максимальный элемент: " + string.Join(", ", max));
        //    }

        //    if (checkBox_MinElement.Checked)
        //    {
        //        int[] min = FindMin();
        //        PrintResult("Минимальный элемент: " + string.Join(", ", min));
        //    }
        //}

        private int[] GenerateArray(int size)
        {
            int[] array = new int[size];
            Random random = new Random();

            for (int i = 0; i < size; i++)
            {
                array[i] = random.Next(1000);
            }

            return array;
        }

        //private int[] CalculateSum()
        //{
        //    int sum = 0;

        //    foreach (int num in dataArray)
        //    {
        //        sum += num;
        //    }

        //    return new int[] { sum };
        //}

        //private int[] FindMax()
        //{
        //    int max = int.MinValue;

        //    foreach (int num in dataArray)
        //    {
        //        if (num > max)
        //        {
        //            max = num;
        //        }
        //    }

        //    return new int[] { max };
        //}

        //private int[] FindMin()
        //{
        //    int min = int.MaxValue;

        //    foreach (int num in dataArray)
        //    {
        //        if (num < min)
        //        {
        //            min = num;
        //        }
        //    }

        //    return new int[] { min };
        //}

        private int CalculateSum(int start, int end)
        {
            int sum = 0;

            for (int i = start; i < end; i++)
            {
                sum += dataArray[i];
            }

            return sum;
        }

        private int FindMax(int start, int end)
        {
            int max = int.MinValue;

            for (int i = start; i < end; i++)
            {
                if (dataArray[i] > max)
                {
                    max = dataArray[i];
                }
            }

            return max;
        }

        private int FindMin(int start, int end)
        {
            int min = int.MaxValue;

            for (int i = start; i < end; i++)
            {
                if (dataArray[i] < min)
                {
                    min = dataArray[i];
                }
            }

            return min;
        }
        private void PrintResult(string result)
        {
            BeginInvoke(new Action(() =>
            {
                richTextBox_Result.AppendText(result + Environment.NewLine);
                richTextBox_Result.ScrollToCaret();
            }));
        }

        private void checkBox_OneArray_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_OneArray.Checked == true)
            {
                groupBox_OneArray.Enabled = true;
            }
            else
            {
                groupBox_OneArray.Enabled = false;
            }
        }

        private void checkBox_TwoArray_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox_TwoArray.Checked == true)
            {
                groupBox_TwoArray.Enabled = true;
            }
            else
            {
                groupBox_TwoArray.Enabled = false;
            }
        }
    }
}
