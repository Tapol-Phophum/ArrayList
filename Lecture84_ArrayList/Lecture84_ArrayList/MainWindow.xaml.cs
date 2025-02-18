﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Lecture84_ArrayList
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ArrayList arrayList;
        public MainWindow()
        {
            InitializeComponent();
            arrayList = new ArrayList();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if(arrayList.Count==0)
            {
                MessageBox.Show("Data not found");
            }
            else
            {
                //Show Data
                txtInput.Text = "";
                int i = 1;

                    foreach (string data in arrayList)
                    {
                       txtInput.AppendText(i + ":" + data+", ");
                    i++;  
                    }

                //MessageBox.Show(data.ToString());
                //Count Array
               MessageBox.Show("Count" + " " + arrayList.Count.ToString());
                //sorting'
                // arrayList.Sort();
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(txtInput.Text)|| (arrayList.Count == 0))
            {
                MessageBox.Show("Please input data for Delete or data not have");
            }
            else
            {
                int i = 0; // keep array count
                string inText = txtInput.Text;
                //remove
                foreach (string data in arrayList)
                {
                    if (data == inText)
                    {
                        i++;
                    }
                }
                if(i>0)
                {
                    arrayList.Remove(inText); // remove object
                    //arrayList.RemoveAt(2); // remove index
                    txtInput.Clear();
                    lblStatusBar.Content = ("Remove complete");
                }
                else
                {
                    MessageBox.Show("data " + inText + " Data not found");
                }
            }
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            if (String.IsNullOrEmpty(txtInput.Text))
            {
                MessageBox.Show("Please input data before save");
            }
            else
            {
                //Add data
                arrayList.Add(txtInput.Text);
                txtInput.Clear();
                lblStatusBar.Content = ("Add complete");
            }
        }

        private void txtInput_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void txtInput_IsMouseCapturedChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            lblStatusBar.Content = (" Wait");
            txtInput.Text = "";
        }
    }
}
