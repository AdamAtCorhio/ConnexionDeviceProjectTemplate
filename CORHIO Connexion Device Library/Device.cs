using System;
using System.Collections.Generic;
$if$ ($targetframeworkversion$ >= 3.5)using System.Linq;
$endif$using System.Text;
using System.Threading;
using Connexion.Core;
using Connexion.Core.HL7;
using System.Threading.Tasks;

namespace $safeprojectname$
{
	/// <summary>
	/// Update the attribute below to include a device name, input and output types (object if your device accepts any type), and device configuration type.
	/// </summary>
	[DevicePlugin("$safeprojectname$","$safeprojectname$ Connexion Device", DeviceDefinitionFlags.None, typeof(object), typeof(object), typeof($safeprojectname$Factory))]
	public class $safeprojectname$ : BaseDevice<$safeprojectname$Configuration>
	{
		public override void Start()
		{
			// place any custom startup logic here. This will be called once when the channel is started
			MessageChannel.Logger.Write(EventSeverity.Info, "Device is starting");
		}

		public override void Stop()
		{
			// place any custom cleanup logic here. This will be called once when the channel is stopped
			MessageChannel.Logger.Write(EventSeverity.Info, "Device is stopping");
		}

		// Please use the async version if possible. this will be called for each message that is being sent through the system.
		//public override void ProcessMessage(IMessageContext context)
		//{
		//  // get and cast the message to the desired type
		//  var message = context.Message;

		//  // you can write processing events which are tied to the current message
		//  context.WriteEvent(EventSeverity.Info, "Some text");
		//}

		// this will be called for each message that is being sent through the system.
		public override async Task ProcessMessageAsync(IMessageContext context, CancellationToken token)
		{
			// get and cast the message to the desired type
			var message = context.Message;

			// you can write processing events which are tied to the current message
			context.WriteEvent(EventSeverity.Info, "Some text");
		}

		// called when an exception occurs in ProcessMessage (or the async version)
		public override void OnError(IMessageContext context, ErrorEventArgs args)
		{
			// retry the message?
			args.ShouldRetry = true;

			// todo: write something to the context and/or log

			// wait before trying again?
			args.SleepTime = TimeSpan.FromSeconds(args.TotalRetries > 2 ? 30 : 5);
		}
	}
}
