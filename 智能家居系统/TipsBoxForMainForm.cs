using System.Threading;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 智能家居系统
{
    partial class MainForm
    {
        Thread ShowTipsThread =null;
        Thread HideTipsThread = null;
        Thread SleepThread = null;

        private enum TipsState
        {
            Showing,
            Shown,
            Hiding,
            Hidden
        }
        TipsState TipsStateNow = TipsState.Hidden;

        private void TipsTitleLabel_Click(object sender, EventArgs e)
        {
            HideTipsMessage();
        }

        /// <summary>
        /// 在窗体内部显示一个轻巧的信息提示框
        /// </summary>
        /// <param name="Message">信息内容</param>
        /// <param name="iconType">提示框图标</param>
        private void ShowTipsMessage(string Message, MyMessageBox.IconType iconType)
        {
            ShowTipsMessage("智能家居系统：",Message,iconType);
        }

        /// <summary>
        /// 在窗体内部显示一个轻巧的信息提示框
        /// </summary>
        /// <param name="Title">提示框标题</param>
        /// <param name="Message">信息内容</param>
        /// <param name="iconType">提示框图标</param>
        private void ShowTipsMessage(string Title, string Message, MyMessageBox.IconType iconType)
        {

            switch (TipsStateNow)
            {
                case  TipsState.Showing:
                case  TipsState.Shown:
                    {
                        HideTipsMessage();
                        break;
                    }
                case TipsState.Hiding:
                    {
                        break;
                    }
                case TipsState.Hidden:
                    {
                        break;
                    }
            }

            TipsStateNow = TipsState.Showing;
            try{
                TipsBox.BringToFront();
                TipsBox.Left = TipsBox.Parent.Width;
                TipsTitleLabel.Text = Title;
                TipsMessageLabel.Text = Message;
                TipsIconLabel.Image = UnityResource.ResourceManager.GetObject(iconType.ToString()) as System.Drawing.Image;
                TipsBox.Show();
            }catch { }
            ShowTipsThread = new Thread(ShowTipsSub);
            ShowTipsThread.Start();
            ShowTipsThread.Join();
            TipsStateNow = TipsState.Shown;
            ShowTipsThread = null;
            SleepThread = new Thread(delegate (){
                Thread.Sleep(5000);
                HideTipsMessage();
            });
            SleepThread.Start();
        }

        private void HideTipsMessage()
        {
            switch (TipsStateNow)
            {
                case TipsState.Showing:
                    {
                        ShowTipsThread.Abort();
                        ShowTipsThread = null;
                        break;
                    }
                case TipsState.Shown:
                    {
                        break;
                    }
                case TipsState.Hiding:
                case TipsState.Hidden:
                    {
                        return;
                    }
            }

            TipsStateNow = TipsState.Hiding;
            try
            {
                TipsBox.Left = TipsBox.Parent.Width-TipsBox.Width;
            }
            catch { }
            HideTipsThread = new Thread(HideTipsSub);
            HideTipsThread.Start();
            HideTipsThread.Join();
            try{
                TipsBox.Hide();
            }catch { }
            TipsStateNow = TipsState.Hidden;
            HideTipsThread = null;
            if (SleepThread != null)
            {
                SleepThread.Abort();
                SleepThread = null;
            }
        }

        private void ShowTipsSub()
        {
            try
            {
                while (TipsBox.Left>TipsBox.Parent.Width-TipsBox.Width)
                {
                    TipsBox.Left -= 15;
                    TipsBox.Refresh();
                    Thread.Sleep(10);
                }
                TipsBox.Left = TipsBox.Parent.Width - TipsBox.Width+1;
            }
            catch { }
        }

        private void HideTipsSub()
        {
            try
            {
                while (TipsBox.Left < TipsBox.Parent.Width)
                {
                    TipsBox.Left += 15;
                    TipsBox.Refresh();
                    Thread.Sleep(10);
                }
                TipsBox.Left = TipsBox.Parent.Width;
            }
            catch{ }
        }

    }
}
