using System;
using System.Collections.Generic;
$if$ ($targetframeworkversion$ >= 3.5)using System.Linq;
$endif$
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Connexion.Core;
using System.Reflection;

namespace $safeprojectname$
{
  	public partial class $safeprojectname$UI : UserControl, IEmbeddedHelpFile
	{
    	public $safeprojectname$UI()
		{
			XamlInitializer.Initialize(this);
		}

    	public $safeprojectname$UI($safeprojectname$Configuration config, IDeviceUIParams deviceUIParams) :
		  this()
		{
      		var vm = new $safeprojectname$UIViewModel(config, deviceUIParams);
			DataContext = vm;
		}

		#region Help File

		public string FileName
		{
			get { return "http://myhelpfileurl"; }
		}

		public System.IO.Stream GetHelpFile()
		{
			return null;
		}

		public string Keyword
		{
			get { return string.Empty; }
		}

		public string CachePath { get; set; }

		#endregion

	}
}
