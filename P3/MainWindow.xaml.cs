using Microsoft.WindowsAPICodePack.Dialogs;
using System;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Forms;
using System.Windows.Threading;

namespace P3
{
    public partial class MainWindow : Window
    {
        private string DirectoryFile = "";
        private bool isRepeat = false;
        private bool isAccidentally = false;
        private DispatcherTimer TimerMedia = new DispatcherTimer();

        public MainWindow()
        {
            InitializeComponent();
            TimerMedia.Tick += new EventHandler(TimerTick);
            TimerMedia.Interval = new TimeSpan(1);
        }

        

        private void OpenDirectory(object sender, RoutedEventArgs e)
        {
            CommonOpenFileDialog dialog = new CommonOpenFileDialog() { IsFolderPicker = true };
            var result = dialog.ShowDialog();
            if(result == CommonFileDialogResult.Ok)
            {
                DirectoryFile = dialog.FileName;
                foreach (string file in Directory.GetFiles(DirectoryFile))
                {
                    if (Path.GetExtension(file) == ".mp3")
                    {
                        string fileName = Path.GetFileName(file);
                        GetMyListBox.Items.Add(fileName);
                    }
                }

                if(GetMyListBox.Items.Count > 0) GetMyListBox.SelectedItem = GetMyListBox.Items[0];
            }
        }
        
        
        private void media_MediaEnded(object sender, RoutedEventArgs e)
        {
            if (isRepeat) media.Position = new TimeSpan(Convert.ToInt64(0));
            else if (isAccidentally)
            {
                Random rnd = new Random();
                int newRnd = rnd.Next(GetMyListBox.Items.Count);
                GetMyListBox.SelectedItem = GetMyListBox.Items[newRnd];
            }
            else NextSound.RaiseEvent(new RoutedEventArgs(System.Windows.Controls.Button.ClickEvent));
        }

        private void media_MediaFailed(object sender, ExceptionRoutedEventArgs e)
        {
            System.Windows.MessageBox.Show("Не удалось загрузить медиа-файл.");
        }

        private void TimerTick(object sender, EventArgs e)
        {
            if (media.NaturalDuration.HasTimeSpan)
            {
                timerLabel.Content = media.Position.ToString(@"hh\:mm\:ss");
                AudioSlider.Value = media.Position.TotalSeconds;
            }
        }

        private void media_MediaOpened(object sender, RoutedEventArgs e)
        {
            if (media.NaturalDuration.HasTimeSpan)
            {
                AudioSlider.Maximum = media.NaturalDuration.TimeSpan.TotalSeconds;
                timerLabel2.Content = media.NaturalDuration.TimeSpan.ToString(@"hh\:mm\:ss");
            }
        }

        private void AudioSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (media.NaturalDuration.HasTimeSpan)
            {
                media.Position = TimeSpan.FromSeconds(AudioSlider.Value);
            }
        }

        private void AudioVolume_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (media.NaturalDuration.HasTimeSpan)
            {
                media.Volume = AudioVolume.Value / 100.0;
            }
        }








        private void GetMyListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int i = GetMyListBox.SelectedIndex;
            if (i < 0) return;
            PlaySound(false);
        }

        private void Back(object sender, RoutedEventArgs e)
        {
            int max = GetMyListBox.Items.Count - 1;
            int selectIndex = GetMyListBox.SelectedIndex;
            if (selectIndex == 0) GetMyListBox.SelectedItem = GetMyListBox.Items[max];
            else GetMyListBox.SelectedItem = GetMyListBox.Items[selectIndex - 1];
        }

        private void Play(object sender, RoutedEventArgs e)
        {
            if (!media.NaturalDuration.HasTimeSpan) PlaySound(false);
            else
            {
                if (PlayButton.Content.Equals("Играть")) PlaySound(true);
                else
                {
                    PlayButton.Content = "Играть";
                    media.Pause();
                }
            }
        }

        private void Next(object sender, RoutedEventArgs e)
        {
            int max = GetMyListBox.Items.Count - 1;
            int selectIndex = GetMyListBox.SelectedIndex;
            if (selectIndex == max) GetMyListBox.SelectedItem = GetMyListBox.Items[0];
            else GetMyListBox.SelectedItem = GetMyListBox.Items[selectIndex + 1];
        }

        private void Repeat(object sender, RoutedEventArgs e)
        {
            if (isAccidentally)
            {
                isAccidentally = false;
            }
            if(isRepeat)
            {
                isRepeat = false;
            }
            else
            {
                isRepeat = true;
            }
        }

        private void Accidentally(object sender, RoutedEventArgs e)
        {
            if (isRepeat)
            {
                isRepeat = false;
            }
            if(isAccidentally)
            {
                isAccidentally = false;
            }
            else
            {
                isAccidentally = true;
            }
        }

        private void PlaySound(bool active)
        {
            if (!active)
            {
                PlayButton.Content = "Пауза";
                if (TimerMedia.IsEnabled) TimerMedia.Stop();
                string firstFilePath = GetMyListBox.Items[GetMyListBox.SelectedIndex].ToString();
                media.Source = new Uri(DirectoryFile + "/" + firstFilePath);
                media.Play();
                media.Volume = AudioVolume.Value / 100.0;

                TimerMedia.Start();
            }
            else
            {
                PlayButton.Content = "Пауза";
                media.Play();
            }
        }

        private void StopSound()
        {

        }
    }
}
