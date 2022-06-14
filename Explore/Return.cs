using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Explore
{
    public partial class Return : UserControl
    {
        private Return_detail return_detail;
        public Return(Return_detail return_detail)
        {
            InitializeComponent();
            this.return_detail = return_detail;
            this.button_next.Hide();
        }

        private void Button_search_click(object sender, EventArgs e)
        {
            this.button_next.Show();
        }

        private void Button_next_click(object sender, EventArgs e)
        {
            this.return_detail.Show();
            this.Hide();
        }
    }
}
