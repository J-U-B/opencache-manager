// 
//  Copyright 2010  Kyle Campbell
// 
//    Licensed under the Apache License, Version 2.0 (the "License");
//    you may not use this file except in compliance with the License.
//    You may obtain a copy of the License at
// 
//        http://www.apache.org/licenses/LICENSE-2.0
// 
//    Unless required by applicable law or agreed to in writing, software
//    distributed under the License is distributed on an "AS IS" BASIS,
//    WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//    See the License for the specific language governing permissions and
//    limitations under the License.

using System;

namespace ocmgtk
{


	[System.ComponentModel.ToolboxItem(true)]
	public partial class SetupAssistantPage1 : Gtk.Bin
	{
		protected virtual void OnButton1Activated (object sender, System.EventArgs e)
		{
			// System.Diagnostics.Process.Start("https://www.geocaching.com/membership/default.aspx");
			Helper.ProcessStartURL ("https://www.geocaching.com/membership/default.aspx");
		}
		
		

		public SetupAssistantPage1 ()
		{
			this.Build ();
		}
	}
}
