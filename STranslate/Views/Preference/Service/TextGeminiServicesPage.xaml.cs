﻿using STranslate.Model;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace STranslate.Views.Preference.Service
{
    public partial class TextGeminiServicesPage : UserControl
    {
        public TextGeminiServicesPage(ITranslator vm)
        {
            InitializeComponent();

            DataContext = vm;
        }

        /// <summary>
        /// 通过缓存加载View时刷新ViewModel
        /// </summary>
        /// <param name="vm"></param>
        public void UpdateVM(ITranslator vm)
        {
            DataContext = vm;
        }

        private void Hyperlink_Click(object sender, RoutedEventArgs e) =>
            Process.Start(new ProcessStartInfo { FileName = "https://makersuite.google.com/app/apikey", UseShellExecute = true });

        /// <summary>
        /// 限制输入数字
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AcceptOnlyNumber(object sender, KeyEventArgs e)
        {
            if (!IsAllowedKey(e.Key))
            {
                e.Handled = true;
            }
        }

        private bool IsAllowedKey(Key key)
        {
            return (key >= Key.D0 && key <= Key.D9) || (key >= Key.NumPad0 && key <= Key.NumPad9) || key == Key.Back || key == Key.Delete || key == Key.Left || key == Key.Right;
        }
    }
}
