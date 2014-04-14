#region #region Copyright (C) 2005-2011 Team MediaPortal

// 
// Copyright (C) 2005-2011 Team MediaPortal
// http://www.team-mediaportal.com
// 
// MediaPortal is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation, either version 2 of the License, or
// (at your option) any later version.
// 
// MediaPortal is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the
// GNU General Public License for more details.
// 
// You should have received a copy of the GNU General Public License
// along with MediaPortal. If not, see <http://www.gnu.org/licenses/>.
// 

#endregion
extern alias MPCore;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using MPCore.MediaPortal.GUI.Library;
using MPCore.MediaPortal.UserInterface.Controls;
using System.Windows;
using J2i.Net.XInputWrapper;

namespace MyXboxController.Plugin.Config {
    public partial class ConfigurationForm :  MPCore.MediaPortal.UserInterface.Controls.MPConfigForm {

        XboxController _selectedController;

        public ConfigurationForm() {
            try {
                InitializeComponent();

                pictureBox2.LocationChanged += pictureBox2_LocationChanged;
                pictureBox2.Parent = pictureBox3;
                _selectedController = XboxController.RetrieveController(0);
                
                _selectedController.StateChanged += _selectedController_StateChanged;
                xboxControllerBindingSource.DataSource = _selectedController;
                XboxController.StartPolling();

            } catch (Exception ex) {
                Log.Error(ex);
            }
        }

        void pictureBox2_LocationChanged(object sender, EventArgs e) {
           
        }



        protected override void OnLoad(EventArgs e) {

        }

        protected override void OnClosing(System.ComponentModel.CancelEventArgs e) {
            XboxController.StopPolling();
        }

        protected override void OnShown(EventArgs e) {

        }


        void _selectedController_StateChanged(object sender, XboxControllerStateChangedEventArgs e) {
            //Invoke((MethodInvoker)delegate() {
            //   propertyGrid1.SelectedObject = _selectedController;
            //   xboxControllerBindingSource.ResetBindings(false);
                
            //});
           
        }

    }
}