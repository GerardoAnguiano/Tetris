using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;
namespace Tetris
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //Declaracion de variables 
        //Lista para agregar 2 sonidos. wav
        List<System.Media.SoundPlayer> soundlist = new List<System.Media.SoundPlayer>();
        //DispatcherTime
        DispatcherTimer timer;
        //Figuras Ramdom
        Random shapeRandom;
        private static Color O_TetrominoColor = Colors.DarkViolet;
        private static Color I_TetrominoColor = Colors.Blue;
        private static Color T_TetrominoColor = Colors.Indigo;
        private static Color S_TetrominoColor = Colors.IndianRed;
        private static Color Z_TetrominoColor = Colors.LightCyan;
        private static Color J_TetrominoColor = Colors.Aquamarine;
        private static Color L_TetrominoColor = Colors.SeaGreen;

        //listas de la posicion actual de los Tetrominos
        //Row
        List<int> currentTetrominoRow = null;
        //columna
        List<int> currentTetrominoColum = null;
        //variable para el nivel
        private int gameLevel = 1;
        //variable para el score
        private int gameScore = 0;
        //variable para contar la velocidad
        private double gameSpeedCounter = 0;
        //variable para el gameover
        private bool isGameOver = false;
        //variable para verificar si choco con el limite 
        private bool bottomCollided = false;
        private bool leftCollided = false;
        private bool rightCollided = false;
        // variable para saber si va rotando la figura 
        private bool isRotated = false;
        private int rotation = 0;
        //Reproducir el sonido. index = 0 va a reproducir collided.wav y index = 1 reproducri delete line
        private void playsound(int index)
        {
            soundlist[index].Play();
        }
        public MainWindow()
        {
            InitializeComponent();
        }

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
