using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace VideoPlayControlServer.Business.VideoList
{
	/// <summary>
	/// Interaction logic for VideoBrowserView.xaml
	/// </summary>
	public partial class VideoBrowserView : UserControl
	{
		public VideoBrowserView(VideoBrowserViewModel data)
		{
			InitializeComponent();
			this.DataContext = data;
		}
	}
}
