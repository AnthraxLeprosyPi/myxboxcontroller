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
using System.IO;
using MediaPortal.GUI;
using MPCore.MediaPortal.GUI.Library;

using MediaPortal.Services;

using MpConf = MediaPortal.Configuration.Config;

namespace MyXboxController.Plugin.Config {
    public static class Settings {
        #region SectionType enum

        public enum SectionType {
            Music,
            Video,
            Photo
        }

        #endregion

        public const string PLUGIN_NAME = "MyXboxController";
        public const string PLUGIN_AUTHOR = "Anthrax";
        public const string PLUGIN_VERSION = "1.5.0";
        public const string PLUGIN_DESCRIPTION = "A MediaPortal plugin to browse your Plex Media Server(s).";

        public static string PLUGIN_LOG_FILE = Path.Combine(MpConf.GetFolder(MpConf.Dir.Log), PLUGIN_NAME + ".txt");

        public const int PLUGIN_WINDOW_ID = 20110614;
        public const int DIALOG_BUFFERING_WINDOW_ID = 20110615;

        public static string SKIN_FOLDER_MEDIA = Path.Combine(GUIGraphicsContext.Skin, @"Media\" + PLUGIN_NAME);
        public static string PLUGIN_MEDIA_HOVER = @"hover_MyXboxController.png";
        public static string PLEX_BACKGROUND_DEFAULT = Path.Combine(SKIN_FOLDER_MEDIA, "default_background.jpg");
        public static string PLEX_ICON_DEFAULT = Path.Combine(SKIN_FOLDER_MEDIA, "icon_default.png");
        public static string PLEX_ICON_DEFAULT_BONJOUR = Path.Combine(SKIN_FOLDER_MEDIA, "icon_bonjour.png");
        public static string PLEX_ICON_DEFAULT_BACK = Path.Combine(SKIN_FOLDER_MEDIA, "icon_back.png");
        public static string PLEX_ICON_DEFAULT_ONLINE = Path.Combine(SKIN_FOLDER_MEDIA, "icon_online.png");
        public static string PLEX_ICON_DEFAULT_OFFLINE = Path.Combine(SKIN_FOLDER_MEDIA, "icon_offline.png");
        public static string PLEX_ARTWORK_CACHE_ROOT_PATH = Path.Combine(MpConf.GetFolder(MpConf.Dir.Thumbs), PLUGIN_NAME);


        public static string PLEX_SERVER_LIST_XML = Path.Combine(MpConf.GetFolder(MpConf.Dir.Config), "PlexServers.xml");

        public static string PLEX_ARTWORK_DEFAULT = Path.Combine(SKIN_FOLDER_MEDIA, "default_fanart.png");


        public static string SKINFILE_MAIN_WINDOW = GUIGraphicsContext.Skin + @"\MyXboxController.xml";

        public static string SKINFILE_DIALOG_BUFFERING = GUIGraphicsContext.Skin + @"\MyXboxController.GuiDialogBufferingProgress.xml";

        public static string PLEX_ICON_DEFAULT_SEARCH = Path.Combine(SKIN_FOLDER_MEDIA, "icon_online.png");

        static Settings() {
           //Set defaults           
            MyPlexUser = String.Empty;
            MyPlexPass = String.Empty;
            CacheFolder = PLEX_ARTWORK_CACHE_ROOT_PATH;
            SelectQualityPriorToPlayback = true;
            ShowDebugwindow = true;
            DeleteCacheOnExit = false;
            DownloadArtwork = true;
        }

        public static MediaPortal.Profile.Settings MediaPortalSettings {
            get {
                return new MediaPortal.Profile.Settings(MpConf.GetFile(MpConf.Dir.Config, "MediaPortal.xml"));
            }
        }



        public static int FetchCount { get; set; }
        public static string CacheFolder { get; set; }
        public static string MyPlexUser { get; set; }
        public static string MyPlexPass { get; set; }
        public static bool DeleteCacheOnExit { get; set; }
        public static bool SelectQualityPriorToPlayback { get; set; }
        public static bool ShowDebugwindow { get; set; }
        public static bool DownloadArtwork { get; set; }



        /// <summary>
        ///   Load the settings from the mediaportal config
        /// </summary>
        public static void Load() {
            try {
                CacheFolder = MediaPortalSettings.GetValueAsString(PLUGIN_NAME, "CacheFolder", CacheFolder);
                MyPlexUser = MediaPortalSettings.GetValue(PLUGIN_NAME, "MyPlexUser");
                SelectQualityPriorToPlayback = MediaPortalSettings.GetValueAsBool(PLUGIN_NAME, "SelectQualityPriorToPlayback", true);
                DeleteCacheOnExit = MediaPortalSettings.GetValueAsBool(PLUGIN_NAME, "DeleteCacheOnExit", DeleteCacheOnExit);
                ShowDebugwindow = MediaPortalSettings.GetValueAsBool(PLUGIN_NAME, "ShowDebugwindow", ShowDebugwindow);
                DownloadArtwork = MediaPortalSettings.GetValueAsBool(PLUGIN_NAME, "DownloadArtwork", DownloadArtwork);
            }
            catch { }
        }

        /// <summary>
        ///   Save the settings to the MP config
        /// </summary>
        public static void Save() {
            try {
                MediaPortalSettings.SetValue(PLUGIN_NAME, "CacheFolder", CacheFolder);
                MediaPortalSettings.SetValue(PLUGIN_NAME, "MyPlexUser", MyPlexUser);
                MediaPortalSettings.SetValueAsBool(PLUGIN_NAME, "SelectQualityPriorToPlayback", SelectQualityPriorToPlayback);
                MediaPortalSettings.SetValueAsBool(PLUGIN_NAME, "DownloadArtwork", DownloadArtwork);
            }
            catch { }
        }



        public static double SleepTimeStep { get; set; }

        public static int SleepTimeMaxium { get; set; }

        public static int NotifyBeforeSleep { get; set; }

        public static int NotifyTimeOutMs { get; set; }

        public static bool ShutdownForce { get; set; }

        public static MPCore.MediaPortal.Util.RestartOptions ShutdownType { get; set; }
    }
}