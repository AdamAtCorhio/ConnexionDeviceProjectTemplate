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
	/// <summary>
    /// The code behind for the $safeprojectname$ UserControl.
    /// Implements the <see cref="System.Windows.Controls.UserControl" />
    /// Implements the <see cref="Connexion.Core.IEmbeddedHelpFile" />
    /// Implements the <see cref="System.Windows.Markup.IComponentConnector" />
    /// </summary>
    /// <seealso cref="System.Windows.Controls.UserControl" />
    /// <seealso cref="Connexion.Core.IEmbeddedHelpFile" />
    /// <seealso cref="System.Windows.Markup.IComponentConnector" />
  	public partial class $safeprojectname$UI : UserControl, IEmbeddedHelpFile
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="$safeprojectname$UI"/> class.
		/// </summary>
    	public $safeprojectname$UI()
		{
			XamlInitializer.Initialize(this);
		}

		/// <summary>
        /// Initializes a new instance of the <see cref="$safeprojectname$UI"/> class.
        /// </summary>
        /// <param name="config">The configuration.</param>
        /// <param name="deviceUIParams">The device UI parameters.</param>
        public $safeprojectname$UI($safeprojectname$Configuration config, IDeviceUIParams deviceUIParams) :
		  this()
		{
      		var vm = new $safeprojectname$UIViewModel(config, deviceUIParams);
			DataContext = vm;
		}

		#region Help File

        /// <summary>
		/// Help file filename.
		/// </summary>
		public string FileName
		{
			get { return "http://myhelpfileurl"; }
		}

        /// <summary>
        /// Returns a stream to the help file.
        /// </summary>
		public System.IO.Stream GetHelpFile()
		{
			return null;
		}

        /// <summary>
		/// Help keyword.
		/// </summary>
		public string Keyword
		{
			get { return string.Empty; }
		}

        /// <summary>
		/// Help file cache path.
		/// </summary>
		public string CachePath { get; set; }

		#endregion

	}
}

