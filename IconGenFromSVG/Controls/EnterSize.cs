using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IconGenFromSVG.Controls
{
	public partial class EnterSize : Form
	{
		public Size ImageSize { get; set; }

		public EnterSize()
		{
			InitializeComponent();
			ImageSize = Size.Empty;
		}
		/// <summary>
		/// Initialize the Display
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void EnterSize_Load(object sender, EventArgs e)
		{
			numHeight.Value = ImageSize.Height;
			numWidth.Value = ImageSize.Width;
		}
		/// <summary>
		/// Save the results
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void button1_Click(object sender, EventArgs e)
		{
			ImageSize = new Size(Convert.ToInt32(numWidth.Value), Convert.ToInt32(numHeight.Value));
		}
	}
}
