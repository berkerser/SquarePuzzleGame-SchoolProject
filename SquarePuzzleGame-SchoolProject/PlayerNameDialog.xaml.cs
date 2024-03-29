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
using System.Windows.Shapes;

namespace SquarePuzzleGame_SchoolProject
{
    /// <summary>
    /// Interaction logic for PlayerNameDialog.xaml
    /// </summary>
    public partial class PlayerNameDialog : Window
    {
        public PlayerNameDialog()
        {
            InitializeComponent();
        }

        private void Ok_Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = Owner as MainWindow;
            string playerName = nameTextBox.Text;
            if (string.IsNullOrWhiteSpace(playerName))
            {
                MessageBox.Show("Lütfen ismi boş bırakmayınız.");
                return;
            }
            if (playerName.Any(ch => char.IsSeparator(ch)))
            {
                MessageBox.Show("Lütfen ismin için herhangi bir boşluk bırakmayınız.");
                return;
            }
            mainWindow.PlayerName = playerName;
            DialogResult = true;
            Close();
        }
    }
}
