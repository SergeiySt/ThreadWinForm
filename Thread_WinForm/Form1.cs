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

        static int processedCount = 0;  
        static Stopwatch stopwatch = new Stopwatch();
        private int[] processedArray;

        public Form1()
        {
            InitializeComponent();

            numThreads = Environment.ProcessorCount;

            label_ProcessorCount.Text = $"{numThreads}";
        }

        private void button_Start_Click(object sender, EventArgs e)
        {
            int arraySize = int.Parse(textBox_A.Text);
            dataArray = GenerateArray(arraySize);

            processedArray = new int[arraySize];

            Thread[] threads = new Thread[numThreads];

            stopwatch.Start();

            for (int i = 0; i < numThreads; i++)
            {
                threads[i] = new Thread(ProcessArray);
                threads[i].Start();
            }

            foreach (var thread in threads)
            {
                thread.Join();
            }

            stopwatch.Stop();

            PrintResult("Результаты обработки массива данных:");

            for (int i = 0; i < processedArray.Length; i++)
            {
                PrintResult(processedArray[i].ToString());
            }

            // Выводим статистику
            PrintResult("Время выполнения: " + stopwatch.Elapsed);
            PrintResult("Количество потоков: " + numThreads);
        }


        private void ProcessArray()
        {
            if (checkBox_Summ.Checked)
            {
                int[] sum = CalculateSum();
                PrintResult("Сумма: " + string.Join(", ", sum));
            }

            if (checkBox_MaxElement.Checked)
            {
                int[] max = FindMax();
                PrintResult("Максимальный элемент: " + string.Join(", ", max));
            }

            if (checkBox_MinElement.Checked)
            {
                int[] min = FindMin();
                PrintResult("Минимальный элемент: " + string.Join(", ", min));
            }
        }

        private int[] GenerateArray(int size)
        {
            int[] array = new int[size];
            Random random = new Random();

            for (int i = 0; i < size; i++)
            {
                array[i] = random.Next(1000); // Заполняем случайными числами от 0 до 99
            }

            return array;
        }

        private int[] CalculateSum()
        {
            int sum = 0;

            foreach (int num in dataArray)
            {
                sum += num;
            }

            return new int[] { sum };
        }

        private int[] FindMax()
        {
            int max = int.MinValue;

            foreach (int num in dataArray)
            {
                if (num > max)
                {
                    max = num;
                }
            }

            return new int[] { max };
        }

        private int[] FindMin()
        {
            int min = int.MaxValue;

            foreach (int num in dataArray)
            {
                if (num < min)
                {
                    min = num;
                }
            }

            return new int[] { min };
        }

        private void PrintResult(string result)
        {
            // Используем Invoke, чтобы выполнить обновление UI из основного потока
            BeginInvoke(new Action(() =>
            {
                richTextBox_Result.AppendText(result + Environment.NewLine);
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
