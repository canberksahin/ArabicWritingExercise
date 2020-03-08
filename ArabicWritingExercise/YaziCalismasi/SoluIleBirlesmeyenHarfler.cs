using ArabicWritingExercise.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArabicWritingExercise
{
    public partial class SoluIleBirlesmeyenHarfler : Form
    {
        public SoluIleBirlesmeyenHarfler()
        {
            InitializeComponent();
            #region Sol ile birleşmeyen harfler
            pbo1.BackgroundImage = Resources.ELİF;
            lbl1.Text = "ELİF";

            pbo2.BackgroundImage = Resources.DE;
            lbl2.Text = "DE";

            pbo3.BackgroundImage = Resources.PELTEK_ZE;
            lbl3.Text = "PELTEK_ZE";

            pbo4.BackgroundImage = Resources.RA;
            lbl4.Text = "RA";

            pbo5.BackgroundImage = Resources.ZE;
            lbl5.Text = "ZE";

            pbo6.BackgroundImage = Resources.VA;
            lbl6.Text = "VA";
            #endregion
        }
    }
}
