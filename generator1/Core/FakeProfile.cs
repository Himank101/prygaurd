﻿using System.Diagnostics;
using System.ComponentModel;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Globalization;
using generator1.ChromeAPI;

namespace generator1.Core
{
    [DebuggerDisplay("{UserAgent}")]
    public class FakeProfile : INotifyPropertyChanged
    {
        public EBrowserType BrowserTypeType { get; set; }

        private ChromeLanguageInfo _chromeLanguageInfo;
        public ChromeLanguageInfo ChromeLanguageInfo
        {
            get => _chromeLanguageInfo;
            set
            {
                if (_chromeLanguageInfo == value)
                    return;
                _chromeLanguageInfo = value;
                OnPropertyChanged(nameof(ChromeLanguageInfo));
            }
        }
        public EChromeLanguage CurrentChromeLanguage
        {
            get => ChromeLanguageInfo.Language;
            set => ChromeLanguageInfo = EChromeLanguageHelper.GetFullInfo(EChromeLanguage.EnUsa);
        }

        private EOSVersion _osVersion;
        public EOSVersion OsVersion
        {
            get => _osVersion;
            set
            {
                if (_osVersion == value)
                    return;
                _osVersion = value;
                OnPropertyChanged(nameof(OsVersion));
            }
        }

        public bool IsX64 { get; set; } = true;

        public string Platform { get; set; } = "Win32";

        private AutoManualEnum _cpuStatus;
        public AutoManualEnum CpuStatus
        {
            get => _cpuStatus;
            set
            {
                if (_cpuStatus == value)
                    return;
                _cpuStatus = value;
                OnPropertyChanged(nameof(CpuStatus));
            }
        }

        private int _cpuConcurrency;
        public int CpuConcurrency
        {
            get => _cpuConcurrency;
            set
            {
                if (_cpuConcurrency == value)
                    return;
                _cpuConcurrency = value;
                OnPropertyChanged(nameof(CpuConcurrency));
            }
        }

        private AutoManualEnum _memStatus;
        public AutoManualEnum MemStatus
        {
            get => _memStatus;
            set
            {
                if (_memStatus == value)
                    return;
                _memStatus = value;
                OnPropertyChanged(nameof(MemStatus));
            }
        }
        private int _memoryAvailable;
        public int MemoryAvailable
        {
            get => _memoryAvailable;
            set
            {
                if (_memoryAvailable == value)
                    return;
                _memoryAvailable = value;
                OnPropertyChanged(nameof(MemoryAvailable));
            }
        }

        private bool _isSendDoNotTrack;
        public bool IsSendDoNotTrack
        {
            get => _isSendDoNotTrack;
            set
            {
                if (_isSendDoNotTrack == value)
                    return;
                _isSendDoNotTrack = value;
                OnPropertyChanged(nameof(IsSendDoNotTrack));
            }
        }

        public bool IsMac { get; set; }

        private string _userAgent;
        public string UserAgent
        {
            get => _userAgent;
            set
            {
                if (_userAgent == value)
                    return;
                _userAgent = value;
                OnPropertyChanged(nameof(UserAgent));
            }
        }

        public string AppVersion
        {
            get
            {
                if (string.IsNullOrWhiteSpace(UserAgent) || UserAgent.Length < 8)
                    return string.Empty;
                return UserAgent.Substring(8);
            }
        }
        private bool _hideCanvas;
        public bool HideCanvas
        {
            get => _hideCanvas;
            set
            {
                if (_hideCanvas == value)
                    return;
                _hideCanvas = value;
                OnPropertyChanged(nameof(HideCanvas));
            }
        }
        public string CanvasFingerPrintHash { get; set; }

        public double BaseLatency { get; set; }

        public double ChannelDataDelta { get; set; }

        public double ChannelDataIndexDelta { get; set; }

        public double FloatFrequencyDataDelta { get; set; }

        public double FloatFrequencyDataIndexDelta { get; set; }
        private ScreenSize _screenSize;
        public ScreenSize ScreenSize
        {

            get => _screenSize;
            set
            {
                if (_screenSize == value)
                    return;
                _screenSize = value;
                OnPropertyChanged(nameof(ScreenSize));
            }
        }

        private bool _hideFonts = true;
        public bool HideFonts
        {
            get => _hideFonts;
            set
            {
                if (_hideFonts == value)
                    return;
                _hideFonts = value;
                OnPropertyChanged(nameof(HideFonts));
            }
        }
        public List<string> Fonts { get; set; }

        public int FontsCount => Fonts.Count;

        private WebGLSetting _webGL;
        public WebGLSetting WebGL
        {
            get => _webGL;
            set
            {
                if (_webGL == value)
                    return;
                _webGL = value;
                OnPropertyChanged(nameof(WebGL));
            }
        }

        private MediaDevicesSettings _mediaDevicesSettings;
        public MediaDevicesSettings MediaDevicesSettings
        {
            get => _mediaDevicesSettings;
            set
            {
                if (_mediaDevicesSettings == value)
                    return;
                _mediaDevicesSettings = value;
                OnPropertyChanged(nameof(MediaDevicesSettings));
            }
        }

        private WebRTCSettings _webRTCSettings;
        public WebRTCSettings WebRtcSettings
        {
            get => _webRTCSettings;
            set
            {
                if (_webRTCSettings == value)
                    return;
                _webRTCSettings = value;
                OnPropertyChanged(nameof(WebRtcSettings));
            }
        }
        public GeoSettings GeoSettings { get; set; }
        public TimezoneSetting TimezoneSetting { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChangedEventHandler propertyChanged = PropertyChanged;
            if (propertyChanged == null)
                return;
            propertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }

        public override string ToString()
        {
            return $"UserAgent: {UserAgent}\n" +
                   $"Browser Type: {BrowserTypeType}\n" +
                   $"OS Version: {OsVersion}\n" +
                   $"Is 64-bit: {IsX64}\n" +
                   $"Platform: {Platform}\n" +
                   $"CPU Status: {CpuStatus}\n" +
                   $"CPU Concurrency: {CpuConcurrency}\n" +
                   $"Memory Status: {MemStatus}\n" +
                   $"Memory Available: {MemoryAvailable}\n" +
                   $"Send Do Not Track: {IsSendDoNotTrack}\n" +
                   $"Is Mac: {IsMac}\n" +
                   $"Hide Canvas: {HideCanvas}\n" +
                   $"Canvas Fingerprint Hash: {CanvasFingerPrintHash}\n" +
                   $"Base Latency: {BaseLatency}\n" +
                   $"Channel Data Delta: {ChannelDataDelta}\n" +
                   $"Channel Data Index Delta: {ChannelDataIndexDelta}\n" +
                   $"Float Frequency Data Delta: {FloatFrequencyDataDelta}\n" +
                   $"Float Frequency Data Index Delta: {FloatFrequencyDataIndexDelta}\n" +
                   $"Screen Size: {ScreenSize}\n" +
                   $"Hide Fonts: {HideFonts}\n" +
                   $"Fonts Count: {FontsCount}\n" +
                   $"WebGL: {WebGL}\n" +
                   $"Media Devices Settings: {MediaDevicesSettings}\n" +
                   $"WebRTC Settings: {WebRtcSettings}\n" +
                   $"Geo Settings: {GeoSettings}\n" +
                   $"Timezone Setting: {TimezoneSetting}";
        }
    }
}
