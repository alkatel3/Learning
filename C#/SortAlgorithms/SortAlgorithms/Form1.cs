using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using Algorithms;

namespace SortAlgorithms
{
    public partial class Form1 : Form
    {
        List<SortedItem> items=new List<SortedItem>();
        public Form1()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if(int.TryParse(AddTextBox.Text,out int value))
            {
                var item = new SortedItem(value,items.Count);
                items.Add(item);

            }

            RefrashItems();
            AddTextBox.Text = "";
        }

        private void FillButton_Click(object sender, EventArgs e)
        {
            if (int.TryParse(FillTextBox.Text, out int value))
            {
                var rnd = new Random();
                for(int i = 0; i < value; i++)
                {
                    var item = new SortedItem(rnd.Next(100),items.Count);
                    items.Add(item);
                }
                RefrashItems();
            }
            FillTextBox.Text = "";
        }

        private void DrowItems(List<SortedItem> items)
        {
            panel3.Controls.Clear(); 

            foreach (var item in items)
            {
                this.panel3.Controls.Add(item.ProgressBar);
                this.panel3.Controls.Add(item.Label1);
            }

            panel3.Refresh();
        }

        private void RefrashItems()
        {
            foreach( var item in items)
            {
                item.Refresh();
            }
            DrowItems(items);
        }

        private void AlgorithmSwopEvent(object sender, Tuple<SortedItem, SortedItem> e)
        {
            var temp = e.Item1.Number;
            e.Item1.SetPosition(e.Item2.Number);
            e.Item2.SetPosition(temp);
            panel3.Refresh();
        }

        private void AlgorithmCompareEvent(object sender, Tuple<SortedItem, SortedItem> e)
        {
            e.Item1.SetColor(Color.Red);
            e.Item2.SetColor(Color.Green);
            panel3.Refresh();
            Thread.Sleep(50);
            e.Item1.SetColor(Color.Blue);
            e.Item2.SetColor(Color.Blue);
            panel3.Refresh();
        }

        private void AlgorithmSetEvent(object sender, Tuple<int, SortedItem> e)
        {
            e.Item2.SetColor(Color.Red);
            panel3.Refresh();
            Thread.Sleep(20);

            e.Item2.SetPosition(e.Item1);
            panel3.Refresh();
            Thread.Sleep(20);
            e.Item2.SetColor(Color.Blue);
            panel3.Refresh();
            Thread.Sleep(20);
        }

        private void Btn_Click(AlgorithmBase<SortedItem> algorithm)
        {
            RefrashItems();
            for (int i = 0; i < algorithm.Items.Count; i++)
            {
                algorithm.Items[i].SetPosition(i);
            }
            panel3.Refresh();

            algorithm.CompareEvent += AlgorithmCompareEvent;
            algorithm.SwopEvent += AlgorithmSwopEvent;
            algorithm.SetEvent += AlgorithmSetEvent;
            var time = algorithm.Sort();
            timeLable.Text = "Time: " + time.Seconds;
            swopLabel.Text = "Swop count: " + algorithm.SwopCount;
            compereLabel.Text = "Comperation count: " + algorithm.ComparisonCount;
        }

        private void BubbleSortButton_Click(object sender, EventArgs e)
        {
            var bubble = new BubbleSort<SortedItem>(items);
            Btn_Click(bubble);
        }

        private void CoctailSortButton_Click(object sender, EventArgs e)
        {
            var coctail = new CocktailSort<SortedItem>(items);
            Btn_Click(coctail);
        }

        private void InsertionSortButton_Click(object sender, EventArgs e)
        {
            var insertion = new InsertionSort<SortedItem>(items);
            Btn_Click(insertion);
        }

        private void ShellSortButton_Click(object sender, EventArgs e)
        {
            var shell = new ShellSort<SortedItem>(items);
            Btn_Click(shell);
        }

        private void SellectionSortButton_Click(object sender, EventArgs e)
        {
            var sellection = new SelectionSort<SortedItem>(items);
            Btn_Click(sellection);
        }

        private void HeapSortButton_Click(object sender, EventArgs e)
        {
            var heap = new HeapSort<SortedItem>(items);

            Btn_Click(heap);
        }

        private void GnomSortButton_Click(object sender, EventArgs e)
        {
            var gnome = new GnomeSort<SortedItem>(items);

            Btn_Click(gnome);
        }

        private void TreeSortButton_Click(object sender, EventArgs e)
        {
            var tree = new TreeSort<SortedItem>(items);

            Btn_Click(tree);
        }

        private void LsdRadixSortButton_Click(object sender, EventArgs e)
        {
            var lsd = new LsdRadixSort<SortedItem>(items);

            Btn_Click(lsd);
        }

        private void MsdRadixSortButton_Click(object sender, EventArgs e)
        {
            var msd = new MsdRadixSort<SortedItem>(items);

            Btn_Click(msd);
        }
    }
}
 