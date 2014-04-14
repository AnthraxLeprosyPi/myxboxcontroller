extern alias MPCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Timer = System.Timers.Timer;
using System.Windows.Forms;
using MediaPortal.Configuration;
using MediaPortal.Dialogs;
using MPCore.MediaPortal.GUI.Library;
using MPCore.MediaPortal.Util;
using MyXboxController.Plugin.Configuration;
using MyXboxController.Plugin.Window;
using MPCore.MediaPortal.Player;
using MPCore.MediaPortal.Playlists;
using MyXboxController.Plugin.Config;

namespace MyXboxController.Plugin {

    [PluginIcons("MyXboxController.Resources.img.MyXboxController_enabled.png", "MyXboxController.Resources.img.MyXboxController_disabled.png")]
    public class MyXboxController : ISetupForm {

        #region ISetupForm Members

        /// <summary>
        /// Gets the plugin name.
        /// </summary>
        /// <returns>The plugin name.</returns>
        public string PluginName() {
            return "MyXboxController";
        }

        /// <summary>
        /// Gets the description of the plugin.
        /// </summary>
        /// <returns>The plugin description.</returns>
        public string Description() {
            return Translation.PluginDescription;
        }

        /// <summary>
        /// Gets the plugin author.
        /// </summary>
        /// <returns>The plugin author.</returns>
        public string Author() {
            return "Anthrax";
        }

        /// <summary>
        /// Shows the plugin configuration.
        /// </summary>
        public void ShowPlugin() {
            new MyXboxControllerConfig().ShowDialog();
        }

        /// <summary>
        /// Determines whether this plugin can be enabled.
        /// </summary>
        /// <returns>
        /// <c>true</c> if this plugin can be enabled; otherwise, <c>false</c>.
        /// </returns>
        public bool CanEnable() {
            return true;
        }

        /// <summary>
        /// Gets the window id.
        /// </summary>
        /// <returns>The window id.</returns>
        public int GetWindowId() {
            // WindowID of windowplugin belonging to this setup
            // enter your own unique code
            return -1;
        }

        /// <summary>
        /// Defaults enabled.
        /// </summary>
        /// <returns>true if this plugin is enabled by default, otherwise false.</returns>
        public bool DefaultEnabled() {
            return true;
        }

        /// <summary>
        /// Determines whether this plugin has setup.
        /// </summary>
        /// <returns>
        /// <c>true</c> if this plugin has setup; otherwise, <c>false</c>.
        /// </returns>
        public bool HasSetup() {
            return true;
        }

        /// <summary>
        /// If the plugin should have it's own button on the main menu of Mediaportal then it
        /// should return true to this method, otherwise if it should not be on home
        /// it should return false
        /// </summary>
        /// <param name="strButtonText">text the button should have</param>
        /// <param name="strButtonImage">image for the button, or empty for default</param>
        /// <param name="strButtonImageFocus">image for the button, or empty for default</param>
        /// <param name="strPictureImage">subpicture for the button or empty for none</param>
        /// <returns>true : plugin needs it's own button on home
        /// false : plugin does not need it's own button on home</returns>
        public bool GetHome(out string strButtonText, out string strButtonImage,
                            out string strButtonImageFocus, out string strPictureImage) {
            strButtonText = PluginName();
            strButtonImage = String.Empty;
            strButtonImageFocus = String.Empty;
            strPictureImage = String.Empty;
            return false;
        }

        #endregion

        #region StateMachine Configuration

        enum State {
            SleepTimerOff,
            SleepTimerOn,
            ShutDown,
            NotifyVisible,
            NotifyHidden
        }

        enum Trigger {
            ButtonSet,
            ButtonIncrease,
            ButtonDecrease,
            ButtonShutdownNext,
            ButtonShutdownPrev,
            NotifyTimerElapsed,
            SleepTimerElapsed,
            SleepTimerStopped
        }

       
        #endregion


        //timers
        private Timer ShutDownTimer { get; set; }
        private Timer NotificationTimer { get; set; }
        private string ShutDownType { get; set; }
        private LinkedList<String> ShutDownIterator { get; set; }

        public MyXboxController() {
            Settings.Load();
            SetupStateMachine();
           
           ShutDownIterator = new LinkedList<String>();
            foreach (string option in Enum.GetNames(typeof(RestartOptions))) {
                ShutDownIterator.AddLast(option);
            }
            ShutDownTimer = new Timer();
            NotificationTimer = new Timer();
            NotificationTimer.AutoReset = true;
            NotificationTimer.Elapsed += NotificationTimer_Elapsed;
            ShutDownIterator.AddLast("Exit MediaPortal");
            ShutDownIterator.AddLast("Show Basic Home");            
            GUIWindowManager.OnNewAction += GUIWindowManager_OnNewAction;
        }

        void TimerShutDown_Elapsed(object sender, System.Timers.ElapsedEventArgs e) {
           
        }

        void GUIWindowManager_OnNewAction(MPCore.MediaPortal.GUI.Library.Action action) {
            //if (action.wID == null) {
               
            //} else if (_MyXboxController.IsInState(State.NotifyVisible)) {
            //    switch (action.wID) {
            //        case MediaPortal.GUI.Library.Action.ActionType.ACTION_MOVE_RIGHT:
            //            if (_MyXboxController.CanFire(Trigger.ButtonIncrease)) {
            //                _MyXboxController.Fire(Trigger.ButtonIncrease);
            //            }
            //            break;
            //        case MediaPortal.GUI.Library.Action.ActionType.ACTION_MOVE_LEFT:
            //            if (_MyXboxController.CanFire(Trigger.ButtonDecrease)) {
            //                _MyXboxController.Fire(Trigger.ButtonDecrease);
            //            }
            //            break;
            //        case MediaPortal.GUI.Library.Action.ActionType.ACTION_PREVIOUS_MENU:
            //            if (_MyXboxController.CanFire(Trigger.SleepTimerStopped)) {
            //                _MyXboxController.Fire(Trigger.SleepTimerStopped);
            //            }
            //            break;
            //        case MediaPortal.GUI.Library.Action.ActionType.ACTION_MOVE_UP:
            //            if (_MyXboxController.CanFire(Trigger.ButtonShutdownNext)) {
            //                _MyXboxController.Fire(Trigger.ButtonShutdownNext);
            //            }
            //            break;
            //        case MediaPortal.GUI.Library.Action.ActionType.ACTION_MOVE_DOWN:
            //            if (_MyXboxController.CanFire(Trigger.ButtonShutdownPrev)) {
            //                _MyXboxController.Fire(Trigger.ButtonShutdownPrev);
            //            }
            //            break;
            //    }
            //}
        }

        private void SetupStateMachine() {
            //try {
            //    _MyXboxController = new StateMachine<State, Trigger>(State.SleepTimerOff);
            //    _MyXboxController.Configure(State.SleepTimerOff)
            //        .OnEntryFrom(Trigger.SleepTimerStopped, SleepTimerOffEntryFrom)
            //        .Permit(Trigger.ButtonSet, State.NotifyVisible);
            //    _MyXboxController.Configure(State.SleepTimerOn)
            //        .OnEntry(SleepTimerOnEntry)
            //        .OnExit(SleepTimerOnExit)
            //        .Permit(Trigger.ButtonSet, State.NotifyVisible)
            //        .Permit(Trigger.SleepTimerElapsed, State.ShutDown)
            //        .Permit(Trigger.SleepTimerStopped, State.SleepTimerOff);
            //    _MyXboxController.Configure(State.NotifyVisible)
            //        .SubstateOf(State.SleepTimerOn)
            //        .OnEntry(NotifyVisibleEntry)
            //        .Permit(Trigger.NotifyTimerElapsed, State.NotifyHidden)
            //        .Permit(Trigger.SleepTimerStopped, State.SleepTimerOff)
            //        .PermitReentry(Trigger.ButtonIncrease)
            //        .PermitReentry(Trigger.ButtonDecrease)
            //        .PermitReentry(Trigger.ButtonShutdownNext)
            //        .PermitReentry(Trigger.ButtonShutdownPrev)
            //        .PermitReentry(Trigger.ButtonSet);
            //    _MyXboxController.Configure(State.NotifyHidden)
            //        .SubstateOf(State.SleepTimerOn)
            //        .Permit(Trigger.ButtonSet, State.NotifyVisible);
            //    _MyXboxController.Configure(State.ShutDown)
            //        .OnEntry(ShutDownEntry)
            //        .OnExit(ShutDownExit)
            //        .Permit(Trigger.SleepTimerElapsed, State.SleepTimerOff);
            //} catch (Exception ex) {
            //    Log.Error(ex);
            //}
        }

        void SleepTimerOffEntryFrom() {
            ShowNotifyDialog(Settings.NotifyTimeOutMs, Translation.TimerStopped);
        }

        void ShutDownEntry() {
            //ShowNotifyDialog(Settings.NotifyTimeOutMs, Translation.TimeIsUp);
            //if (_MyXboxController.CanFire(Trigger.SleepTimerElapsed)) {
            //    _MyXboxController.Fire(Trigger.SleepTimerElapsed);
            //}
        }

        void ShutDownExit() {
            switch (ShutDownType) {
                default:
                    RestartOptions tmp;
                    try{
                     tmp = (RestartOptions)Enum.Parse(typeof(RestartOptions), ShutDownType);
                    }catch{
                      tmp = Settings.ShutdownType;
                    }
                    WindowsController.ExitWindows(tmp, Settings.ShutdownForce, null);
                    break;
                case "Exit MediaPortal":
                    Application.Exit();
                    break;
                case "Show Basic Home":
                    GUIWindowManager.ActivateWindow((int)GUIWindow.Window.WINDOW_HOME, true);
                    break;
            }
        }

        DateTime Shutdown { get; set; }
        TimeSpan Remaining {
            get {
                DateTime now = DateTime.Now;
                return Shutdown <= now ? TimeSpan.Zero : Shutdown - now;
            }
        }

        void SleepTimerOnEntry() {
            double currentRemaining = GetRemainingPlaytime();
            if (currentRemaining <= 0) {
                currentRemaining = Settings.SleepTimeStep * 60 * 1000;
            }
            Shutdown = DateTime.Now.AddMilliseconds(currentRemaining);
            ShutDownTimer = new Timer(Remaining.TotalMilliseconds);
            ShutDownTimer.Elapsed += TimerShutDown_Elapsed;
            ShutDownTimer.AutoReset = false;
            ShutDownTimer.Start();
            if (Settings.NotifyBeforeSleep > 0 && Settings.NotifyBeforeSleep < Remaining.TotalMinutes) {
                NotificationTimer.Interval = Remaining.TotalMilliseconds - Settings.NotifyBeforeSleep * 60 * 1000;
                NotificationTimer.AutoReset = true;
                NotificationTimer.Start();
            }
        }

        void NotificationTimer_Elapsed(object sender, System.Timers.ElapsedEventArgs e) {
            NotificationTimer.Interval = 15 * 1000;
            GUIGraphicsContext.form.Invoke(new MethodInvoker(ShowNotifyDialog));
        }

        void SleepTimerOnExit() {
            if (ShutDownTimer.Enabled) {
                ShutDownTimer.Stop();
            }
            if (NotificationTimer.Enabled) {
                NotificationTimer.Stop();
            }
        }

        //private void NotifyVisibleEntry(StateMachine<State, Trigger>.Transition trans) {
        //    if (trans.IsReentry) {
        //        switch (trans.Trigger) {
        //            case Trigger.ButtonDecrease:
        //                Shutdown = Shutdown.AddMinutes(-Settings.SleepTimeStep);
        //                if (Remaining.Ticks <= 0 && _MyXboxController.CanFire(Trigger.SleepTimerStopped)) {
        //                    _MyXboxController.Fire(Trigger.SleepTimerStopped);
        //                    return;
        //                }
        //                break;
        //            case Trigger.ButtonShutdownNext:
        //                try {
        //                    ShutDownType = ShutDownIterator.Find(ShutDownType).Next.Value;
        //                } catch {
        //                    ShutDownType = ShutDownIterator.First();
        //                }
        //                break;
        //            case Trigger.ButtonShutdownPrev:
        //                try {
        //                    ShutDownType = ShutDownIterator.Find(ShutDownType).Previous.Value;
        //                } catch {
        //                    ShutDownType = ShutDownIterator.Last();
        //                }
        //                break;
        //            case Trigger.ButtonIncrease:
        //            case Trigger.ButtonSet:
        //                Shutdown = Shutdown.AddMinutes(Settings.SleepTimeStep);
        //                if (Remaining.TotalMilliseconds > Settings.SleepTimeMaxium * 60 * 1000 && _MyXboxController.CanFire(Trigger.SleepTimerStopped)) {
        //                    _MyXboxController.Fire(Trigger.SleepTimerStopped);
        //                    return;
        //                }
        //                break;
        //        }
        //    }
        //    ShutDownTimer.Interval = Remaining.TotalMilliseconds;
        //    if (Settings.NotifyBeforeSleep > 0 && Settings.NotifyBeforeSleep < Remaining.TotalMinutes) {
        //        NotificationTimer.Interval = Remaining.TotalMilliseconds - Settings.NotifyBeforeSleep * 60 * 1000;
        //        NotificationTimer.Start();
        //    }
        //    ShowNotifyDialog();
        //    if (_MyXboxController.CanFire(Trigger.NotifyTimerElapsed)) {
        //        _MyXboxController.Fire(Trigger.NotifyTimerElapsed);
        //    }
        //}

        private void ShowNotifyDialog() {
            ShowNotifyDialog(Settings.NotifyTimeOutMs);
        }

        private void ShowNotifyDialog(int timeOutMs) {
            //▲▼►◄
            StringBuilder notifyMessage = new StringBuilder();
            notifyMessage.AppendFormat("▲ {0} ▼\n\n", ShutDownType.ToString());
            notifyMessage.AppendFormat("◄ {0} h ►", new DateTime(Remaining.Ticks).ToString("T"));
            ShowNotifyDialog(timeOutMs, notifyMessage.ToString());
        }

        private void ShowNotifyDialog(int timeOutMs, string notifyMessage) {
            try {
                GUIDialogNotify _dialogSleepTimerNotify = (GUIDialogNotify)GUIWindowManager.GetWindow((int)GUIWindow.Window.WINDOW_DIALOG_NOTIFY);
                _dialogSleepTimerNotify.TimeOut = timeOutMs;
                _dialogSleepTimerNotify.SetImage(GUIGraphicsContext.Skin + @"\Media\MyXboxController_enabled.png");
                _dialogSleepTimerNotify.SetHeading("MyXboxController");
                _dialogSleepTimerNotify.SetText(notifyMessage);
                _dialogSleepTimerNotify.DoModal(GUIWindowManager.ActiveWindow);
            } catch (Exception ex) {
                Log.Error(ex);
            }
        }

        private double GetRemainingPlaytime() {
            double duration = 0;
            if (PlayListPlayer.SingletonPlayer.CurrentPlaylistType != PlayListType.PLAYLIST_NONE) {
                PlayList playList = PlayListPlayer.SingletonPlayer.GetPlaylist(PlayListPlayer.SingletonPlayer.CurrentPlaylistType);
                playList.Where((item, index) => !item.Played && index > PlayListPlayer.SingletonPlayer.CurrentSong).ToList().ForEach(item => duration += item.Duration * 1000);
            }
            return (g_Player.Duration - g_Player.CurrentPosition) * 1000 + duration;
        }
        
        //private void HideNotifyDialog() {
        //    GUIDialogNotify _dialogSleepTimerNotify = (GUIDialogNotify)GUIWindowManager.GetWindow((int)GUIWindow.Window.WINDOW_DIALOG_NOTIFY);
        //    GUIMessage msg = new GUIMessage(GUIMessage.MessageType.GUI_MSG_WINDOW_DEINIT, _dialogSleepTimerNotify.GetID, 0, 0, 0, 0, null);
        //    _dialogSleepTimerNotify.OnMessage(msg);
        //}
    }
}

