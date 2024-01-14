﻿using STranslate.Model;
using System.Windows.Controls;

namespace STranslate.Views.Preference.Service
{
    public partial class TextBingServicesPage : UserControl
    {
        public TextBingServicesPage(ITranslator vm)
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
    }
}