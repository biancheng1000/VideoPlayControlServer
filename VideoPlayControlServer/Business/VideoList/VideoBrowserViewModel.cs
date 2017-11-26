using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Prism.Commands;

namespace VideoPlayControlServer.Business.VideoList
{
	/// <summary>
	/// 视频文件浏览和编辑功能
	/// </summary>
	public class VideoBrowserViewModel
	{

		#region Commands

		/// <summary>
		/// 删除选中的视频文件
		/// </summary>
		public ICommand DeleteSelectFile
		{
			get
			{
				return new DelegateCommand(()=> { });
			}
		}
		#endregion

		#region 方法

		/// <summary>
		/// 加载共享目录中的视频文件
		/// </summary>
		private void LoadFiles()
		{

		}
		#endregion
	}
}
