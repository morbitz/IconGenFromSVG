using System.Drawing.Imaging;

using IconGenFromSVG.Controls;

namespace IconGenFromSVG
{
	public partial class Form1 : Form
	{
		private Size _currentSize;
		private Size _imageSize;
		private List<Size> _icoSizes;

		private Svg.SvgDocument? _svgDocument;

		public Form1()
		{
			InitializeComponent();
			_svgDocument = null;
			_icoSizes = new List<Size>();
		}
		/// <summary>
		/// Initialize the loaded form 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void Form1_Load(object sender, EventArgs e)
		{
			_currentSize = Size.Empty;
			_currentSize = Size.Empty;
			ckSize8.Tag = new Size(8, 8);
			ckSize16.Tag = new Size(16, 16);
			ckSize24.Tag = new Size(24, 24);
			ckSize32.Tag = new Size(32, 32);
			ckSize48.Tag = new Size(48, 48);
			ckSize128.Tag = new Size(128, 128);
			ckSize256.Tag = new Size(256, 256);
			UpdateStatusBar("Initialization Complete. Ready");
		}
		/// <summary>
		/// Update the Status Bar
		/// </summary>
		/// <param name="v"></param>
		/// <exception cref="NotImplementedException"></exception>
		private void UpdateStatusBar(string? msg = null)
		{
			if (!String.IsNullOrEmpty(msg))
				txtStatus.Text = msg;
			txtCurSize.Text = $"Current Size: {_currentSize.Width}, {_currentSize.Height}";
			txtSize.Text = $"Source Size: {_imageSize.Width}, {_imageSize.Height}";
		}
		/// <summary>
		/// Update The Image Size
		/// </summary>
		/// <param name="imageSize"></param>
		/// <exception cref="NotImplementedException"></exception>
		private void UpdateImageSize(Size imageSize)
		{
			_currentSize = imageSize;
			_svgDocument.Width = imageSize.Width;
			_svgDocument.Height = imageSize.Height;
			pictConvertedImage.Image = _svgDocument.Draw();
			UpdateStatusBar();
		}
		/// <summary>
		/// File Menu is Opening
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void fileToolStripMenuItem_DropDownOpening(object sender, EventArgs e)
		{
			bool _enabled = _svgDocument is not null;

			mnuSaveIcon.Enabled = _enabled && _icoSizes.Count > 0;
			mnuSaveImage.Enabled = _enabled;
		}
		/// <summary>
		/// Edit Menu is Opening
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void editToolStripMenuItem_DropDownOpening(object sender, EventArgs e)
		{
			bool _enabled = _svgDocument is not null;

			mnuCut.Enabled = _enabled;
			mnuCopy.Enabled	= _enabled;
			mnuClear.Enabled = _enabled;
		}
		/// <summary>
		/// View Menu is Opening
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void viewToolStripMenuItem_DropDownOpening(object sender, EventArgs e)
		{
			bool _enabled = _svgDocument is not null;

			mnuNextSize.Enabled = _enabled && _icoSizes.Count > 1;
			mnuPriviousSize.Enabled = _enabled && _icoSizes.Count > 1;
			mnuSelect.Enabled = _enabled;
		}
		/// <summary>
		/// Something is being Dragged over the application
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void Form1_DragEnter(object sender, DragEventArgs e)
		{
			if (e.Data.GetDataPresent(DataFormats.FileDrop))
			{
				String[] _files = (String[])e.Data.GetData(DataFormats.FileDrop);
				e.Effect = DragDropEffects.None;

				if (_files is not null && _files.Length == 1)
					if (Path.GetExtension(_files[0]).Equals(".svg", StringComparison.OrdinalIgnoreCase))
						e.Effect = DragDropEffects.Copy;
			}
		}
		/// <summary>
		/// File Has been Dropped in the Application
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void Form1_DragDrop(object sender, DragEventArgs e)
		{
			if (e.Data.GetDataPresent(DataFormats.FileDrop))
			{
				String[] _files = (String[])e.Data.GetData(DataFormats.FileDrop);

				if (_files.Length > 0)
					txtFileName.Text = _files[0];
			}
		}
		/// <summary>
		/// SVG Image File Changed
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void txtFileName_TextChanged(object sender, EventArgs e)
		{
			if (File.Exists(txtFileName.Text))
			{
				try
				{
					svg.SVGParser.MaximumSize = new Size(pictConvertedImage.Width, pictConvertedImage.Height);

					_svgDocument = svg.SVGParser.GetSvgDocument(txtFileName.Text);
					pictConvertedImage.Image = svg.SVGParser.GetBitmapFromSVG(txtFileName.Text);
					_currentSize = pictConvertedImage.Image.Size;
					_imageSize = pictConvertedImage.Image.Size;
					UpdateStatusBar("Image File Load Complete.");
				}
				catch (Exception ex)
				{
					UpdateStatusBar($"Image Failed to Load: {ex.Message}");
				}
			}
		}
		/// <summary>
		/// O
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void mnuOpenSVG_Click(object sender, EventArgs e)
		{
			if (openFileDialog1.ShowDialog() == DialogResult.OK)
				txtFileName.Text = openFileDialog1.FileName;
		}
		/// <summary>
		/// Save the Icon File with the Selected Images
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void mnuSaveIcon_Click(object sender, EventArgs e)
		{

		}
		/// <summary>
		/// Save the Image File as a image type
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void mnuSaveImage_Click(object sender, EventArgs e)
		{
			ImageFormat _imageFormat = ImageFormat.Png;

			saveFileDialog1.DefaultExt = ".png";
			saveFileDialog1.Filter = "PNG File|*.png|JPG File|*.jpg|Single Image Icon|*.ico|Bitmap File|*.bmp|All Files|*.*";
			if (saveFileDialog1.ShowDialog() == DialogResult.OK)
			{
				String _fext = Path.GetExtension(saveFileDialog1.FileName).ToLower();

				switch (_fext)
				{
					case ".png":
						_imageFormat = ImageFormat.Png;
						break;
					case ".jpg":
						_imageFormat = ImageFormat.Jpeg;
						break;
					case ".bmp":
						_imageFormat = ImageFormat.Bmp;
						break;
					case ".ico":
						_imageFormat = ImageFormat.Icon;
						break;
					default:
						break;
				}
				pictConvertedImage.Image.Save(saveFileDialog1.FileName, _imageFormat);
			}
		}
		/// <summary>
		/// Exit The Application
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void mnuExit_Click(object sender, EventArgs e)
		{
			this.Close();
		}
		/// <summary>
		/// Cut the Image to the clipboard
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void mnuCut_Click(object sender, EventArgs e)
		{

		}
		/// <summary>
		/// Copy the Image to the Clipboard
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void mnuCopy_Click(object sender, EventArgs e)
		{
		}
		/// <summary>
		/// Clear the current image
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void mnuClear_Click(object sender, EventArgs e)
		{
			txtFileName.Text = String.Empty;
			_currentSize = Size.Empty;
			_currentSize = Size.Empty;
			_icoSizes.Clear();
			pictConvertedImage.Image = null;
			UpdateStatusBar("Image Was Cleared. Ready");
		}
		/// <summary>
		/// Go top the previous image size
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void mnuPreviousSize_Click(object sender, EventArgs e)
		{

		}
		/// <summary>
		/// Go to the next image size
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void mnuNextSize_Click(object sender, EventArgs e)
		{

		}
		/// <summary>
		/// Enter a new Size Directly
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void mnuSelect_Click(object sender, EventArgs e)
		{
			EnterSize _dlg = new EnterSize();

			_dlg.ImageSize = _currentSize;
			if (_dlg.ShowDialog() == DialogResult.OK)
				UpdateImageSize(_dlg.ImageSize);
		}
		/// <summary>
		/// The Size Icon values have changed
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void sizeIconChanged(object sender, EventArgs e)
		{
			CheckBox _checkedItem = ((CheckBox)sender);
			Size _newSize;

			if (_checkedItem.Tag is not null)
			{
				_newSize = (Size)_checkedItem.Tag;
				if (_checkedItem.Checked)
				{
					if (!_icoSizes.Contains(_newSize))
						_icoSizes.Add(_newSize);
					UpdateImageSize(_newSize);
				}
				else
				{
					if (_icoSizes.Contains(_newSize))
						_icoSizes.Remove(_newSize);
					if (_icoSizes.Count > 0)
						UpdateImageSize(_icoSizes.First());
					else
						UpdateImageSize(_imageSize);
				}
			}
		}
	}
}