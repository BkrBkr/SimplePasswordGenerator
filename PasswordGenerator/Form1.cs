//Copyright(C) 2019 Björn Kremer

//This file Is part Of SimplePasswordGenerator.

//SimplePasswordGenerator Is free software: you can redistribute it And/Or modify
//it under the terms Of the GNU General Public License As published by
//the Free Software Foundation, either version 3 Of the License, Or
//(at your option) any later version.

//SimplePasswordGenerator Is distributed In the hope that it will be useful,
//but WITHOUT ANY WARRANTY; without even the implied warranty of
//MERCHANTABILITY Or FITNESS FOR A PARTICULAR PURPOSE.  See the
//GNU General Public License For more details.

//You should have received a copy Of the GNU General Public License
//along with SimplePasswordGenerator. If Not, see < http: //www.gnu.org/licenses/>.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PasswordGenerator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            generate();
            Clipboard.SetText(txtPW.Text);
        }

        private void tbAmount_ValueChanged(object sender, EventArgs e)
        {
            generate();
        }
        private void generate()
        {
            lblCount.Text = tbAmount.Value.ToString();
            txtPW.Text = System.Web.Security.Membership.GeneratePassword(tbAmount.Value, 1);
        }
      
        private void tbAmount_MouseUp(object sender, MouseEventArgs e)
        {
            Clipboard.SetText(txtPW.Text);
            txtPW.Focus();
        }
    }
}
