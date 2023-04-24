// Copyright (c) Microsoft Corporation and Contributors.
// Licensed under the MIT License.
using Microsoft.UI.Xaml;
using System;
using WinUI_hashCheck.ControlHandler;
namespace WinUI_hashCheck
{
    /// <summary>
    /// An empty window that can be used on its own or navigated to within a Frame.
    /// "C:\softwareDownloads\dotnet-sdk-7.0.203-win-x64.exe"
    /// "b2c09ba8454da835304075760c4f355ee1e394c47402800695c75e2da964c5dcd0bb70c1f0c5c67c425369d7fdc9eb060a3936ea755a140342ba12ea47d7cd8b"
    /// </summary>
    public sealed partial class MainWindow : Window
    {
        public MainWindow()
        {
            this.InitializeComponent();
            Title = "SHA 512 of downloaded file check";
        }
        /*
        <summary>
            This is the check hash button handler.
            It triggers the downloaded file hash computing and comparison with the expected one.
        </summary>
        <param name="sender">button</param>
        <param name="e">click event</param>
        */
        private void ButtonCheckSHA_Click(object sender, RoutedEventArgs e)
        {
            if (!(string.IsNullOrWhiteSpace(filePath.Text)
                && string.IsNullOrWhiteSpace(expectedHash.Text)))
            {
                ValueTuple<string, string> result = CheckHash.Check(filePath.Text, expectedHash.Text);
                computedHash.Text = result.Item1;
                checkResult.Text = result.Item2;
            }
        }
    }
}
