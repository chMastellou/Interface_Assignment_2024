using Music_Showcase.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Music_Showcase
{
    public partial class Device_Management : Form
    {
        List<Image> sound_images;
        List<Image> speaker_images;
        public Device_Management()
        {
            InitializeComponent();
            sound_images = new List<Image>();
            sound_images = [Properties.Resources.sound_on, Properties.Resources.sound_off];
            speaker_images = new List<Image>();
            speaker_images = [Properties.Resources.speaker_on, Properties.Resources.speaker_off];
        }


        private void frontLeftSpeaker_Click(object sender, EventArgs e)
        {
            if (frontLeftSound.Image != sound_images[0])
            {
                frontLeftSound.Image = sound_images[0];
                frontLeftSpeaker.Image = speaker_images[0];
                FLstate.Text = "Ανοιχτό";
            }
            else
            {
                frontLeftSound.Image = sound_images[1];
                frontLeftSpeaker.Image = speaker_images[1];
                FLstate.Text = "Κλειστό";
            }
        }

        private void frontRightSpeaker_Click(object sender, EventArgs e)
        {
            if (frontRightSound.Image != sound_images[0])
            {
                frontRightSound.Image = sound_images[0];
                frontRightSpeaker.Image = speaker_images[0];
                FRstate.Text = "Ανοιχτό";
            }
            else
            {
                frontRightSound.Image = sound_images[1];
                frontRightSpeaker.Image= speaker_images[1];
                FRstate.Text = "Κλειστό";
            }
        }

        private void backLeftSpeaker_Click(object sender, EventArgs e)
        {
            if (backLeftSound.Image != sound_images[0])
            {
                backLeftSound.Image = sound_images[0];
                backLeftSpeaker.Image = speaker_images[0];
                BLstate.Text = "Ανοιχτό";
            }
            else
            {
                backLeftSound.Image = sound_images[1];
                backLeftSpeaker.Image= speaker_images[1];
                BLstate.Text = "Κλειστό";
            }
        }

        private void backRightSpeaker_Click(object sender, EventArgs e)
        {
            if (backRightSound.Image != sound_images[0])
            {
                backRightSound.Image = sound_images[0];
                backRightSpeaker.Image = speaker_images[0];
                BRstate.Text = "Ανοιχτό";
            }
            else
            {
                backRightSound.Image = sound_images[1];
                backRightSpeaker.Image = speaker_images[1];
                BRstate.Text = "Κλειστό";
            }
        }
    }
}
