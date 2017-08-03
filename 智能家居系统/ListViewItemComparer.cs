using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace 智能家居系统
{
    class ListViewItemComparer : IComparer
    {
        private int ColumnIndex = -1;
        public ListViewItemComparer(int columnIndex)
        {
            ColumnIndex = columnIndex;
        }

        public int Compare(object X, object Y)
        {
            try
            {
            int ReturnVal = -1;
            ReturnVal = String.Compare(((ListViewItem)X).SubItems[ColumnIndex].Text,
            ((ListViewItem)Y).SubItems[ColumnIndex].Text);
            return ReturnVal;
            }
            catch(Exception ex)
            {
                System.Diagnostics.Debug.Print(DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss")+"    点击列头排序，遇到错误：" + ex.Message);
                return 0;
            }
        }
    }
}