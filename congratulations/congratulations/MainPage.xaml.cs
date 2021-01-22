using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Plugin.Messaging;

namespace congratulations
{
    public partial class MainPage : ContentPage
    {
        Random rnd;
        public MainPage()
        {
            InitializeComponent();
        }

        public void randombutton_Clicked(object sender, EventArgs e)
        {
            rnd = new Random();
            picker.SelectedIndex = rnd.Next(0, 5);
        }

        public void ButtonSend_Clicked(object sender, EventArgs e)
        {
            var emailMessenger = CrossMessaging.Current.EmailMessenger;
            if (emailMessenger.CanSendEmail)
            {
                emailMessenger.SendEmail($"{picker.SelectedItem}", $"{EntrySubject}", $"{EntryRecipients}");
            }
            ButtonSend.Text = "Отправлено!";
        }

        public  void picker_SelectedIndexChanged(object sender, EventArgs e)
        {
            picker.Title = "Вы выбрали: " + picker.Items[picker.SelectedIndex];
            if (picker.SelectedIndex == 0)
            {
                EntrySubject.Text = $"{picker}";
            }
            if (picker.SelectedIndex == 1)
            {
                EntrySubject.Text = $"{picker}";
            }
            if (picker.SelectedIndex == 2)
            {
                EntrySubject.Text = $"{picker}";
            }
            if (picker.SelectedIndex == 3)
            {
                EntrySubject.Text = $"{picker}";
            }
            if (picker.SelectedIndex == 4)
            {
                EntrySubject.Text = $"{picker}";
            }
        }
    }
}
