using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Threading;

namespace Tetris
{
    /// <summary>
    /// Lógica de interacción para App.xaml
    /// </summary>
    public partial class App : Application
    {
        //Declaracion de variables 
        //Lista para agregar 2 sonidos. wav
        List<System.Media.SoundPlayer> soundlist = new List<System.Media.SoundPlayer>();
        //DispatcherTime
        DispatcherTimer timer;
        //Figuras Ramdom
        Random shapeRandom;


        //Reproducir el sonido. index = 0 va a reproducir collided.wav y index = 1 reproducri delete line
        private void playsound(int index)
        {
            soundlist[index].Play();
        }
    }
}
