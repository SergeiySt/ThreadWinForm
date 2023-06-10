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

        private int[] data; 
        private Thread processingThread; 

        private int sum;
        private int min;
        private int max;
        private object lockObject = new object();
        static Stopwatch stopwatch = new Stopwatch();
        public Form1()
        {
            InitializeComponent();

            numThreads = Environment.ProcessorCount;

            label_ProcessorCount.Text = $"{numThreads}";
        }

        private void button_Start_Click(object sender, EventArgs e)
        {

            if (processingThread != null && processingThread.IsAlive)
            {
                MessageBox.Show("Обробка даних вже запущена.");
                return;
            }

            int size;
            if (!int.TryParse(textBox_A.Text, out size) || size <= 0)
            {
                MessageBox.Show("Некоректний розмір масиву.");
                return;
            }

            data = GenerateRandomArray(size); 

            richTextBox_Result.Clear();

            stopwatch.Start();

            processingThread = new Thread(ProcessData); 
            processingThread.Start();

            PrintResult("Результати обробки масиву даних:");

            for (int i = 0; i < data.Length; i++)
            {
                PrintResult(data[i].ToString());
            }

            stopwatch.Stop();
            PrintResult("Час виконання: " + stopwatch.Elapsed);
        }

        private void ProcessData()
        {
            bool calculateSum = checkBox_Summ.Checked;
            bool findMin = checkBox_MinElement.Checked;
            bool findMax = checkBox_MaxElement.Checked;
            bool increaseByOne = checkBox_One.Checked;
            bool sort_array = checkBox_Sort.Checked;

            // Выполнение обработки данных в нескольких потоках
            Thread sumThread = calculateSum ? new Thread(CalculateSum) : null;
            Thread minThread = findMin ? new Thread(FindMin) : null;
            Thread maxThread = findMax ? new Thread(FindMax) : null;
            Thread incThread = increaseByOne ? new Thread(IncreaseByOne) : null;
            Thread sort = sort_array ? new Thread(Sort) : null;

            // Запуск потоков
            sumThread?.Start();
            minThread?.Start();
            maxThread?.Start();
            incThread?.Start();
            sort?.Start();

            // Ожидание завершения всех потоков
            sumThread?.Join();
            minThread?.Join();
            maxThread?.Join();
            incThread?.Join();
            sort?.Join();

            richTextBox_Result.Invoke(new Action(() =>
            {
                if (calculateSum)
                {
                    richTextBox_Result.AppendText("Сума всіх чисел: " + sum + Environment.NewLine);
                }
                if (findMin)
                {
                    richTextBox_Result.AppendText("Мінімальний елемент: " + min + Environment.NewLine);
                }
                if (findMax)
                {
                    richTextBox_Result.AppendText("Максимальний елемент: " + max + Environment.NewLine);
                }
                if (increaseByOne)
                {
                    richTextBox_Result.AppendText("Збільшення всіх елементів на 1 виконано." + Environment.NewLine);
                }
                if (sort_array)
                {
                    richTextBox_Result.AppendText("Сортування масиву виконано." + Environment.NewLine);
                }
            }));


            data = null; 
        }


        private int[] GenerateRandomArray(int size)
        {
            Random random = new Random();
            int[] array = new int[size];
            for (int i = 0; i < size; i++)
            {
                array[i] = random.Next(100); // Значения в пределах от 0 до 99
            }
            return array;
        }

   
        private void CalculateSum()
        {
            int localSum = 0;
            foreach (int element in data)
            {
                localSum += element;
            }

            lock (lockObject) // Блокировка для синхронизации доступа к общей переменной sum
            {
                sum += localSum;
            }
        }

   
        private void FindMin()
        {
            int localMin = int.MaxValue;
            foreach (int element in data)
            {
                if (element < localMin)
                {
                    localMin = element;
                }
            }

            lock (lockObject) // Блокировка для синхронизации доступа к общей переменной min
            {
                if (localMin < min)
                {
                    min = localMin;
                }
            }
        }

    
        private void FindMax()
        {
            int localMax = int.MinValue;
            foreach (int element in data)
            {
                if (element > localMax)
                {
                    localMax = element;
                }
            }

            lock (lockObject) // Блокировка для синхронизации доступа к общей переменной max
            {
                if (localMax > max)
                {
                    max = localMax;
                }
            }
        }


        private void IncreaseByOne()
        {
            for (int i = 0; i < data.Length; i++)
            {
                data[i]++;
            }
        }

        private  void Sort()
        {
            int[] sortedArray = (int[])data.Clone();
            Array.Sort(sortedArray);

            richTextBox_Result.Invoke(new Action(() =>
            {
                richTextBox_Result.AppendText("Відсортований масив:" + Environment.NewLine);
                for (int i = 0; i < sortedArray.Length; i++)
                {
                    PrintResult(sortedArray[i].ToString());
                }
                richTextBox_Result.ScrollToCaret();
            }));
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
