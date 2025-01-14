﻿using STranslate.Util;
using STranslate.ViewModels;
using System.Windows;
using System.Windows.Controls;

namespace STranslate.Views
{
    /// <summary>
    /// NotifyIcon.xaml 的交互逻辑
    /// </summary>
    public partial class NotifyIcon : UserControl
    {
        public NotifyIcon()
        {
            InitializeComponent();

            Singleton<NotifyIconViewModel>.Instance.OnShowBalloonTip += (msg)
                => TrayIcon.ShowBalloonTip("", msg, Hardcodet.Wpf.TaskbarNotification.BalloonIcon.None);
        }

        /// <summary>
        /// https://github.com/hardcodet/wpf-notifyicon/issues/19
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TrayIcon_TrayContextMenuOpen(object sender, RoutedEventArgs e)
        {
            TrayIconContextMenu.UpdateDefaultStyle();
        }
    }
}
