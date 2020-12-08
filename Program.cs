/*
 * WITCH
 * by Kyle, 11/16/2020
     _   __      _        _____           _      
    | | / /     | |      /  __ \         | |     
    | |/ / _   _| | ___  | /  \/ ___   __| | ___ 
    |    \| | | | |/ _ \ | |    / _ \ / _` |/ _ \
    | |\  \ |_| | |  __/ | \__/\ (_) | (_| |  __/
    \_| \_/\__, |_|\___|  \____/\___/ \__,_|\___|
            __/ |                                
           |___/                                 
 
 ascii text generator http://patorjk.com/software/taag/#p=display&f=Bloody&t=%0A
 */




using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Security.Cryptography.X509Certificates;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;
using System.Reflection.PortableExecutable;


namespace WitchGame
{
    class Program
    {



        static void Main(string[] args)
        {
            //Resizes console to try and show the title picture
            Console.SetWindowSize(100, 55);

            //Loads the Title Screen and the rest of the game.
            Game.startGame();


        }

    }
}