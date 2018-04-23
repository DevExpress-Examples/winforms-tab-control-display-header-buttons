using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraTab;
using DevExpress.XtraTab.ViewInfo;
using DevExpress.XtraTab.Registrator;
using DevExpress.XtraTab.Buttons;
using DevExpress.XtraTab.Drawing;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;

namespace XtraTabWithButtons
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            xtraTabControlDescendant1.PaintStyleName = SkinViewInfoRegistratorDescendant.MyViewName;
            xtraTabControlDescendant1.TabPages[0].Image = SystemIcons.Error.ToBitmap();
            CalcRadioGroup(typeof(TabHeaderLocation), radioGroup1);
            CalcRadioGroup(typeof(TabOrientation), radioGroup2);
        }

        private void CalcRadioGroup(Type EnumType, RadioGroup radioGroup) {
            foreach (object item in Enum.GetValues(EnumType)) {
                RadioGroupItem radioItem = new RadioGroupItem(item, item.ToString());
                radioGroup.Properties.Items.Add(radioItem);
            }
        }

        private void xtraTabPageDescendant1_CustomPageButtonClick(object sender, CustomHeaderButtonEventArgs e)
        {
            XtraTabPageDescendant xtraPage = sender as XtraTabPageDescendant;
            MessageBox.Show(string.Format("PageName {0}, click on button {1} kind {2}", xtraPage.Name, e.Button.Index, e.Button.Kind));
        }

        private void xtraTabControlDescendant1_CustomHeaderButtonClick(object sender, CustomHeaderButtonEventArgs e)
        {
            XtraTabControlDescendant xtraTab = sender as XtraTabControlDescendant;
            MessageBox.Show(string.Format("TabName {0}, click on button {1} kind {2}", xtraTab.Name, e.Button.Index, e.Button.Kind));
        }

        private void xtraTabPageDescendant2_CustomPageButtonClick(object sender, CustomHeaderButtonEventArgs e)
        {
            XtraTabPageDescendant xtraPage = sender as XtraTabPageDescendant;
            MessageBox.Show(string.Format("PageName {0}, click on button {1} kind {2}", xtraPage.Name, e.Button.Index, e.Button.Kind));
        }

        private void radioGroup1_SelectedIndexChanged(object sender, EventArgs e)
        {
            xtraTabControlDescendant1.HeaderLocation = (TabHeaderLocation)radioGroup1.EditValue;
        }

        private void radioGroup2_SelectedIndexChanged(object sender, EventArgs e)
        {
            xtraTabControlDescendant1.HeaderOrientation = (TabOrientation)radioGroup2.EditValue;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            xtraTabPageDescendant1.CustomButtons.Add(new CustomHeaderButton());
            xtraTabControlDescendant1.SelectedTabPage = xtraTabPageDescendant2;
            xtraTabControlDescendant1.SelectedTabPage = xtraTabPageDescendant1;
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            if (xtraTabPageDescendant1.CustomButtons.Count > 0)
                xtraTabPageDescendant1.CustomButtons.RemoveAt(xtraTabPageDescendant1.CustomButtons.Count - 1);
            xtraTabControlDescendant1.SelectedTabPage = xtraTabPageDescendant2;
            xtraTabControlDescendant1.SelectedTabPage = xtraTabPageDescendant1;
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            xtraTabPageDescendant2.CustomButtons.Add(new CustomHeaderButton());
            xtraTabControlDescendant1.SelectedTabPage = xtraTabPageDescendant1;
            xtraTabControlDescendant1.SelectedTabPage = xtraTabPageDescendant2;
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            if (xtraTabPageDescendant2.CustomButtons.Count > 0)
                xtraTabPageDescendant2.CustomButtons.RemoveAt(xtraTabPageDescendant2.CustomButtons.Count - 1);
            xtraTabControlDescendant1.SelectedTabPage = xtraTabPageDescendant1;
            xtraTabControlDescendant1.SelectedTabPage = xtraTabPageDescendant2;
        }

        private void simpleButton5_Click(object sender, EventArgs e) {
            xtraTabControlDescendant1.CustomHeaderButtons.Add(new CustomHeaderButton());
        }

        private void simpleButton6_Click(object sender, EventArgs e) {
            if (xtraTabControlDescendant1.CustomHeaderButtons.Count > 0)
                xtraTabControlDescendant1.CustomHeaderButtons.RemoveAt(xtraTabControlDescendant1.CustomHeaderButtons.Count - 1);
        }
    }
}