﻿using System;
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

namespace zagadka
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

       
        private void Start_OnClick(object sender, RoutedEventArgs e)
        {
           // Random rnd = new Random();
           // int text2 = rnd.Next(0, 10); 
           
           int text2 = 7;
            int text1 =Convert.ToInt32(Input.Text);
           
            
            if (text1 > 10 | text1 < 0)
            {
                Otvet1.Content= "ВВедено неверное число введите другое число";
                return;
            }
            
            if (text2-text1>=3 |text2-text1>=3 )
            {
                Otvet1.Content="холодно";
                return;
            }
            if (text2-text1==2 |text2-text1==2 )
            {
                Otvet1.Content="тепло";
                return;
            }
            
            if (text2-text1==1 |text2-text1==1 )
            {
                Otvet1.Content="горячо";
                return;
            }
            
            if (text2==text1)
            {
                Otvet1.Content="угдали";
                
            }
        }
    }
}