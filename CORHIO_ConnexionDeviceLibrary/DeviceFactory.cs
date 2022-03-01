using System;
using System.Collections.Generic;
$if$ ($targetframeworkversion$ >= 3.5)using System.Linq;
$endif$
using System.Text;
using Connexion.Core;
using System.ComponentModel;
using System.Windows;
using System.Windows.Media.Imaging;
using System.Reflection;

namespace $safeprojectname$
{
    /// <summary>
	/// Connexion Device Factory Class
	/// </summary>
	/// <seealso cref="Connexion.Core.BaseDeviceFactory{$safeprojectname$.$safeprojectname$Configuration}" />
    public class $safeprojectname$Factory : BaseDeviceFactory<$safeprojectname$Configuration>
	{
		/// <summary>
		/// This class handles the creation of the device configuration and user interface for the Connexion main window. If you created or edited
		/// the name of the configuration class, all instances of DeviceConfiguration will need to be changed. Additionally, if you created or edited
		/// the name of the device user interface, update all instances of deviceUIParams to your new UI class. You may also need to update the DeviceImage
		/// property if you included your own custom device icon.
		/// </summary>
		public override FrameworkElement GetUserInterface(IDeviceUIParams deviceUIParams)
		{
			return new $safeprojectname$UI(Configuration, deviceUIParams);
		}

		/// <summary>
		/// This is the device icon which will be displayed in the main user interface.
		/// If you wish to use your own, add a new image, set it as an embedded 
		/// resource, and update the code below to point to your bitmap filename.
		/// </summary>
		public override BitmapImage DeviceImage
		{
			get
			{
				var image = new BitmapImage();
				image.BeginInit();
				image.StreamSource = Assembly.GetExecutingAssembly().GetManifestResourceStream($"{nameof($safeprojectname$)}.DeviceIcon.png");
				image.EndInit();
				return image;
			}
		}

        /// <summary>
        /// If you would like your device to show up in a specific category when being added to a channel,
        /// enter it here. If you return null, your device will be categorized under "Other".
        /// </summary>
        public override string[] Categories
		{
			get { return null; } // return new[] { "Category A", "CategoryB/SubCat A" }; 
		}
	}
}
