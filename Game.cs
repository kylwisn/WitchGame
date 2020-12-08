using System;
using System.Collections.Generic;
using System.Text;

namespace WitchGame
{
    class Game
    {


        //Dialog - Defines speaking roles. Use this section to create colors for characters or events. IE - Narrator, Hero, Villan.
        //This will also wrap the text in that uses this.
        public static void Dialog(string message, string color)
        {
            //this part defines the word wrapping
            int columnWidth = 98;
            string sentence = message;
            string[] words = sentence.Split(' ');
            StringBuilder newSentence = new StringBuilder();

            string line = "";
            foreach (string word in words)
            {
                if ((line + word).Length > columnWidth)
                {
                    newSentence.AppendLine(line);
                    line = "";
                }
                line += string.Format("{0} ", word);
            }

            if (line.Length > 0)
                newSentence.AppendLine(line);

            // This part colors the text based on the character speaking
            if (color == "evil")
            { Console.ForegroundColor = ConsoleColor.Red; }
            else if (color == "hero")
            { Console.ForegroundColor = ConsoleColor.Green; }
            else if (color == "narrator")
            { Console.ForegroundColor = ConsoleColor.White; }
            else
            { Console.ForegroundColor = ConsoleColor.White; }

            // this prints out the text as the color of the character
            Console.WriteLine(newSentence.ToString());

            //Console.WriteLine(message);
            Console.ResetColor();

            // End Dialogue Function
        }






        // This section defines the "press any key to continue" message. One will clear the screen and the other will not.
        public static void AnyKey()
        {
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();

        }

        public static void AnyKeyClear()
        {
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            Console.Clear();

        }



        public static int stat;

        public static void RollStat(int minStat, int maxStat)
        {
            Random rnd = new Random();
            stat = rnd.Next(minStat, maxStat);
            //Program.AnyKeyClear();
            //return (stat);
        }







        // print out game title and overview
        public static void startGame()
        {
            //The Title Screen Of The Game Go 
            //Ascii image converter https://www.text-image.com/convert/
            Console.WriteLine(@"dddmmmNNNNNNNNNNMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMNNNNNNNNNNNmmmmmmmmmmmmdddddddhhhhhhhhhhyyyyyyys");
            Console.WriteLine(@"ddmmmmNNNNNNNNNNMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMNNNNNNNNmmmmmmmmmmmmmmdddddddddhhhhhhhhyyyy");
            Console.WriteLine(@"dmmmmmNNNNNNNMNMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMNNNNNyoodNNmmmmmmmmmmmmddddddddddhhhhh");
            Console.WriteLine(@"mmmmmNNNNNNMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM:  oNNNNNNNNNNNNmmmmmmmmmmmdddddh");
            Console.WriteLine(@"mmmNNNNNNo:://///+++++oososssyyyhhhhhhhdddddmmddddddhhhhhhyyhhyyyys.  :o+++++///::::--..--mNNNmmmmdd");
            Console.WriteLine(@"NNNNNNNNs.`````````````````.```.............``````````````````` `                         :MMMNNNmmm");
            Console.WriteLine(@"NNNNNNNh.``````````````````...```.....`...``````````````                                   sMMMMNNNN");
            Console.WriteLine(@"NNNNNNm-```````````````````.................```.````  ``` ````                             `dMMMMMNN");
            Console.WriteLine(@"NNNNNN/..`....````````````.....--.........`..```.. ```  `````  ``                           -NMMMMMN");
            Console.WriteLine(@"NNNNNo````..`..`.````.......--.--.---...`````./syys/. ``` ``    ```              `....      `+MMMMMN");
            Console.WriteLine(@"NNNNh.`````````````````...............````.::++++////::. ```   `                              yMMMNN");
            Console.WriteLine(@"NNNo.``````````````````````````..````.``:ohh:`       :hyo: ```                                `dMNNN");
            Console.WriteLine(@"NNNs///``````````````````````````````` .shhh/`       /yyys`                                .-//hNNNN");
            Console.WriteLine(@"NNNNNNy````````````-..........```````  -shhh:`      `/hyys. ``````````````````.``````...```oNNNNNNNN");
            Console.WriteLine(@"NNNNNNs/yyysyyysyyyy-:.:/-`-:yyyssoo+/::yhhh:       `/hhhs-://++oooso-o     `//ossossooooo:sNNNNNNNm");
            Console.WriteLine(@"NNNNNNd/yysyyhyyhyys:. ` .:::yhyyyysso/-yhhh+`      `/yhho-/+oosssssy:o`    `+/yyyyyyyyyyy+oNNNNmmmm");
            Console.WriteLine(@"NNNNNNh/yyyssyyyyyys:.     :-hhhyyyyss+:yhhy+`-`    ./yyys-+oossssyyy:o`````.+:ssyyyyyssss++Nmmmmmmm");
            Console.WriteLine(@"NNNNNNh+yhyyyyysyyys:.     ::hhhhhyyss+:shhh/`      `/hhys:+oosssyyyy:+      /:yyyyyyyyysso+mmmmmmdd");
            Console.WriteLine(@"NNNNNNy+hhhhhhhsyyys/.```` ::yyssyssoo//ooss/`      `:ysso:+osssssyss:/      /:yyyyhhyyyys+/mmmmdddd");
            Console.WriteLine(@"NNNNNNyoyyyyyyyyysso/:-----/:ossoo++++/-yyss+`      ./ooss.:////+ooss//----:://so+osssoo+o/+mmmddddd");
            Console.WriteLine(@"NNNNNNs//:-:::-----------:----.-.....`````````   `````````````````` `````````````   ````````sdmddddd");
            Console.WriteLine(@"NNNNNNs...........``....:/:.``` ```````````````````````````  ``  `                        `-mmmmdddd");
            Console.WriteLine(@"NNNNNNo--:--:----://oso+:-`  ```.-``````..-.          `.`.      ```             ```      ``/mmmmmddd");
            Console.WriteLine(@"NNNNNNo/soo+/::://:-`        `..--``````:://``````  ``:::-  `````.``           ``````...-:-/mmmddddd");
            Console.WriteLine(@"NNNNNNo+++++:::....`        `...--.```` +ooo``      ``//// ``````.-..`         ....--::://::dmdddddd");
            Console.WriteLine(@"NNNNNN+-//:----....`        `..-:-...`` syys.`      ``ssso``.``..-:--.        `::///+++oo+::hmdddddh");
            Console.WriteLine(@"mNNNNN-//+//:::----`        `----:---.. yyyy..      `.yyyy`.-.----:::-        `++ooooossso/:hmmmdddd");
            Console.WriteLine(@"mmmmNd-:++++++///::.        .//::::::-. yhhh..      `.hhhh.---::/-://:        `osssssssyys/:hmmmdddd");
            Console.WriteLine(@"mmmmmm./oooooo+++++.        .+//:://::-`hhdh-.      `.hhhh--://++::+o/        `sssyyssyso+/:ymmddddd");
            Console.WriteLine(@"dmmmmm.oosssssoosoo.        -++/://///-`yddd..      `.hddh--//++o::oo/`````````syyyyyyyyso/-ymdddddd");
            Console.WriteLine(@"/ymmNm.os+ooooo+ooo++oooooooooo+:/++//:.shhh-.   :ss+-yhhh-:++++o//osssyyyyyyyysyyyssssso+:-sddddddd");
            Console.WriteLine(@".odhhd-++//////++/+++oooooooo+++:/o++/:.+ooo:.   /dNh-+oo+-:++o+++:osyyyyyyyyyyyysssooo+/:-:/hhssydd");
            Console.WriteLine(@"--:-.-.---.--/-----:----:::---.---:--.......-....--::--.....---..-----------::--+++::--.....----.-/+");
            Console.WriteLine(@"+++:::-.---::://::::-:::::-----:/::...-.-.-...---................-.-..............--------------....");
            Console.WriteLine(@"yosyso+//::/oo+++/o+osssoosyyyssso++++++++++//:::::-:::-:////--------------::--:--...--------::::---");
            Console.WriteLine(@"oo++:-+:::+/--+ysso/+syyyyyyyyhhyyyhhhhyhhhhhyyyyssssyyyysooooossooooo+o+/++//++///:/---::::///::/::");
            Console.WriteLine();
            // Text creator here http://patorjk.com/software/taag/#p=display&f=Bloody&t=GAME%20OVER
            Console.WriteLine("Welcome to...");
            Console.WriteLine("");
            Console.WriteLine(@" █     █░ ██▓▄▄▄█████▓ ▄████▄   ██░ ██ ");
            Console.WriteLine(@"▓█░ █ ░█░▓██▒▓  ██▒ ▓▒▒██▀ ▀█  ▓██░ ██▒");
            Console.WriteLine(@"▒█░ █ ░█ ▒██▒▒ ▓██░ ▒░▒▓█    ▄ ▒██▀▀██░");
            Console.WriteLine(@"░█░ █ ░█ ░██░░ ▓██▓ ░ ▒▓▓▄ ▄██▒░▓█ ░██ ");
            Console.WriteLine(@"░░██▒██▓ ░██░  ▒██▒ ░ ▒ ▓███▀ ░░▓█▒░██▓");
            Console.WriteLine(@"░ ▓░▒ ▒  ░▓    ▒ ░░   ░ ░▒ ▒  ░ ▒ ░░▒░▒");
            Console.WriteLine(@"  ▒ ░ ░   ▒ ░    ░      ░  ▒    ▒ ░▒░ ░");
            Console.WriteLine(@"  ░   ░   ▒ ░  ░      ░         ░  ░░ ░");
            Console.WriteLine(@"    ░     ░           ░ ░       ░  ░  ░");
            Console.WriteLine(@"                      ░                ");
            Console.WriteLine("");

            AnyKeyClear();

            characterCreation();

            // End StartGame
        }



        // Creating the characterName string to use for character creation
        public static string characterName;

        static void characterCreation()
        {
            Dialog("Please Enter your name: ", "narrator");
            characterName = Console.ReadLine();
            Console.WriteLine();
            Dialog("Welcome " + characterName + ", to Witch! This is a choose your own adventure game. The choices you make will decide your ultimate survival. Consider the options carefully before you make your decisions.", "narrator");
            AnyKeyClear();
            part1Step1();
        }




        // Chracter Hit Points
        // Base hit points will start at 1
        public static int hitPoints = 1;










        public static void part1Step1()
        {

            Console.WriteLine(@" █     █░ ▄▄▄       ██ ▄█▀▓█████▓██   ██▓    █     █░ ▄▄▄       ██ ▄█▀▓█████▓██   ██▓");
            Console.WriteLine(@"▓█░ █ ░█░▒████▄     ██▄█▒ ▓█   ▀ ▒██  ██▒   ▓█░ █ ░█░▒████▄     ██▄█▒ ▓█   ▀ ▒██  ██▒");
            Console.WriteLine(@"▒█░ █ ░█ ▒██  ▀█▄  ▓███▄░ ▒███    ▒██ ██░   ▒█░ █ ░█ ▒██  ▀█▄  ▓███▄░ ▒███    ▒██ ██░");
            Console.WriteLine(@"░█░ █ ░█ ░██▄▄▄▄██ ▓██ █▄ ▒▓█  ▄  ░ ▐██▓░   ░█░ █ ░█ ░██▄▄▄▄██ ▓██ █▄ ▒▓█  ▄  ░ ▐██▓░");
            Console.WriteLine(@"░░██▒██▓  ▓█   ▓██▒▒██▒ █▄░▒████▒ ░ ██▒▓░   ░░██▒██▓  ▓█   ▓██▒▒██▒ █▄░▒████▒ ░ ██▒▓░");
            Console.WriteLine(@"░ ▓░▒ ▒   ▒▒   ▓▒█░▒ ▒▒ ▓▒░░ ▒░ ░  ██▒▒▒    ░ ▓░▒ ▒   ▒▒   ▓▒█░▒ ▒▒ ▓▒░░ ▒░ ░  ██▒▒▒ ");
            Console.WriteLine(@"  ▒ ░ ░    ▒   ▒▒ ░░ ░▒ ▒░ ░ ░  ░▓██ ░▒░      ▒ ░ ░    ▒   ▒▒ ░░ ░▒ ▒░ ░ ░  ░▓██ ░▒░ ");
            Console.WriteLine(@"  ░   ░    ░   ▒   ░ ░░ ░    ░   ▒ ▒ ░░       ░   ░    ░   ▒   ░ ░░ ░    ░   ▒ ▒ ░░  ");
            Console.WriteLine(@"    ░          ░  ░░  ░      ░  ░░ ░            ░          ░  ░░  ░      ░  ░░ ░     ");
            Console.WriteLine(@"                                 ░ ░                                         ░ ░    ");

            Dialog("OUCH my head, what happened? How did I get here?", "hero");
            Dialog("You wake up in the forest with no memory of how you ended up there. Feeling a throbbing senstation, you find you have a bump on the head from an impact, but from what you don't know. The fog of your breath clouds your vision, the chill of the dropping temperature is starting sink into your skin. You're not dressed for the occasion and if you don't find shelter fast, you're not going to last long in the cold.", "narrator");

            string part1Choice1;
            Console.WriteLine();
            Dialog("What will you do?", "narrator");
            Console.WriteLine("1. Look around and get your bearings?");
            Console.WriteLine("2. Take stock of what you have?");
            Console.WriteLine();
            Dialog("Type the number corresponding to your choice and press enter on your keyboard: ", "narrator");
            part1Choice1 = Console.ReadLine().ToLower();

            switch (part1Choice1)
            {
                case "1":
                    {
                        Console.Clear();
                        Dialog("You slowly turn your head and try to get your bearings from your surroundings.", "narrator");
                        Dialog("Trees... Rocks....  I'm in the middle of fricken nowhere and I'm not going to last.", "hero");
                        Dialog("The foreboding woods bears down on you, there is barely enough light to see into the distance and the number of trees would surley silence any sounds of civilization, like a highway. You feel like something is watching you, like one of those old photographs in you grandparent's house.", "narrator");
                        break;
                    }
                case "2":
                    {
                        Console.Clear();
                        Dialog("Patting yourself down, you try to find anything useful.", "narrator");
                        Dialog("Short sleeve shirt.... Jeans... No wallet.... Comfortable sneakers..... That's it. Well at least I don't have amnesia and know my name.... " + characterName + "?", "hero");
                        Dialog("While you're glad you at least know your name, it doesn't really help the current situation. You're more concerned over the dropping temperature. It's time to move!", "narrator");
                        break;
                    }
                default:
                    {
                        Dialog("I do not understand that command, press enter to try again...", "narrator");
                        AnyKeyClear();
                        part1Step1();
                        break;
                    }

                    // End part1Choice1 Switch
            }


            // Depending on partOneChoice1, it will display the opposite choice so that both choices will have played out. If you picked 1, then it will show the contents of 2.
            if (part1Choice1 == "1")
            {
                Dialog("Patting yourself down, you try to find anything useful.", "narrator");
                Dialog("Short sleeve shirt.... Jeans... No wallet.... Comfortable sneakers..... That's it. Well at least I don't have amnesia and know my name.... " + characterName + "?", "hero");
                Dialog("While you're glad you at least know your name, it doesn't really help the current situation. You're more concerned over the dropping temperature. It's time to move!", "narrator");
            }
            else if (part1Choice1 == "2")
            {
                Dialog("You slowly turn your head and try to get your bearings from your surroundings.", "narrator");
                Dialog("Trees... Rocks....  I'm in the middle of fricken nowhere and I'm not going to last.", "hero");
                Dialog("The foreboding woods bears down on you, there is barely enough light to see into the distance and the number of trees would surley silence any sounds of civilization, like a highway. You feel like something is watching you, like one of those old photographs in you grandparent's house.", "narrator");
            }


            AnyKeyClear();

            Part1Step2();


            // End part1Step1
        }



        public static bool part1Step2LookFlag = false;


        public static void Part1Step2()
        {
            // part one step 2

            string part1Choice2;
            Dialog("I highly doubt anybody even knows where I am right now, my head is kiling me and it's getting colder. I need to find shelter... Maybe I just got drunk at a party and ended up in a park somewhere and there's a shelter facility nearby. ", "hero");
            Dialog("What will you do?", "narrator");
            Console.WriteLine("1. Walk left?");
            Console.WriteLine("2. Walk right?");
            Console.WriteLine("3. Walk straight?");
            Console.WriteLine("4. Look around?");
            Console.WriteLine();
            Dialog("Type the number corresponding to your choice and press enter on your keyboard: ", "narrator");
            part1Choice2 = Console.ReadLine().ToLower();

            switch (part1Choice2)
            {
                case "1":
                    {
                        // walk left
                        //Console.Clear();
                        Dialog("Screw it... I might as well start walking, anywhere else is better than freezing my ass of here.", "hero");
                        Dialog("One foot at a time, you start walking to your left, following the treeline hoping to find any semblance of civilization.", "narrator");
                        AnyKeyClear();
                        Part1Step3();
                        break;
                    }
                case "2":
                    {
                        // walk right
                        //Console.Clear();
                        Dialog("Screw it... I might as well start walking, anywhere else is better than freezing my ass of here.", "hero");
                        Dialog("One foot at a time, you start walking to your right, following the treeline hoping to find any semblance of civilization.", "narrator");
                        AnyKeyClear();
                        Part1Step3();
                        break;
                    }
                case "3":
                    {
                        // walk straight
                        //Console.Clear();
                        Dialog("Screw it... I might as well start walking, anywhere else is better than freezing my ass of here.", "hero");
                        Dialog("One foot at a time, you start walking straight ahead, following the treeline hoping to find any semblance of civilization.", "narrator");
                        AnyKeyClear();
                        Part1Step3();
                        break;
                    }
                case "4":
                    {
                        // begin this with if statement on if you've been here. If so, you ask yourself why you're checking again
                        // make it a counter and if you search twice, the third time you find an easter egg
                        Console.Clear();
                        if (!part1Step2LookFlag)
                        {
                            Dialog("You decide to give the area a more thorough look. Kicking up some leaves here and there, to your surprise you stumble across a tattered knapsack. Inside are a pair of wool socks with a couple of holes. On any normal day, you wouldn't dare, but there's nothing normal about today. You instantly drop to the ground and put the socks on, and while it doesn't do much to stave off the cold, any little morale booster helps!", "narrator");
                            Dialog("Standing back up, it's time to choose where you're going to go.", "narrator");
                            hitPoints++;
                            part1Step2LookFlag = true;
                            AnyKeyClear();
                            Part1Step2();
                        }
                        else
                        {
                            Dialog("While you thought you'd get lucky with another once over, there's nothing else in the area. It's time to get moving... but where would you go?", "narrator");
                            AnyKeyClear();
                            Part1Step2();
                        }
                        break;
                    }
                default:
                    {
                        Dialog("I do not understand that command, press enter to try again...", "narrator");
                        AnyKeyClear();
                        Part1Step2();
                        break;
                    }

                    // End part1Choice2 Switch
            }

            // End part1Step2
        }





        public static bool part1Step3LookFlag = false;
        public static int part1Step3FindRoll;

        public static void Part1Step3()
        {
            // part1Step3 - Lost in the woods

            string part1Choice3;

            if (!part1Step3LookFlag)
            {
                // Independent text before the next choice so the next choice can repeat without showing this text. 
                Dialog("Where the hell am I?", "hero");
                Dialog("You can't tell right from left. The trees grow thicker and thicker, seemingly choking the very air around you. No signs of running water, no wind, no road noises... just silence. Your head begins to throb and you drop to your knees in pain. Vision blurry, you have to make a decision on what to do next.", "narrator");
            }

            Dialog("Maybe it'll be better to double back or try something else... Or should I just press on and see if my luck changes?", "hero");
            Console.WriteLine("1. Circle back? Maybe you'll have better luck in the other direction.");
            Console.WriteLine("2. Press on and try your luck if you continue moving forward.");
            Console.WriteLine("3. Search your surroundings for anything useful.");
            Console.WriteLine();
            Dialog("Type the number corresponding to your choice and press enter on your keyboard: ", "narrator");
            part1Choice3 = Console.ReadLine().ToLower();

            switch (part1Choice3)
            {
                case "1":
                    {
                        // circle back
                        Dialog("Taking a few deep breaths helps calm your nerves and the sharp pain in your head dulls down. It's still present, but you feel like you can function again.", "narrator");
                        Dialog("I'm just going to turn around. Maybe I'm walking away and help was right behind me the whole time?", "hero");
                        Dialog("After another 20 minutes of walking, you're not even sure if any of this looks familiar. It's getting colder and you're feeling it deeper in your bones.", "narrator");
                        AnyKeyClear();
                        Part1Step4();
                        break;
                    }
                case "2":
                    {
                        // Keep going
                        Dialog("Taking a few deep breaths helps calm your nerves and the sharp pain in your head dulls down. It's still present, but you feel like you can function again.", "narrator");
                        Dialog("No sense in turning around. I know where I've been, but where I'm going is unknown so I'm going to going forward.", "hero");
                        Dialog("After another 20 minutes of walking, you're not even sure if you're getting closer to finding anything. It's getting colder and you're feeling it deeper in your bones.", "narrator");
                        AnyKeyClear();
                        Part1Step4();
                        break;
                    }
                case "3":
                    {
                        // search area
                        if (!part1Step3LookFlag)
                        {
                            Dialog("Taking a few deep breaths helps calm your nerves and the sharp pain in your head dulls down. It's still present, but you feel like you can function again. You trace a 50 yard radius around the parameter, peering out in all directions for any clues on where to go. You also scan the nearby ground for anything useful.", "narrator");
                            part1Step3LookFlag = true;

                            // Roll a number to see if you will find something.
                            RollStat(1, 10);
                            part1Step3FindRoll = stat;

                            if (part1Step3FindRoll >= 7)
                            {
                                // if part1Step3FindRoll is 7 or more
                                Dialog("Kicking up some leaves, you find what look to be human bones on the ground. In a full blown panic, you drop to the ground and kick away from the bones. This is a grim reminder of your fate if you don't get out of the cold. Is that why these bones are here? They got lost in the woods and died in the elements? Nearby is a tattered pack. You decide to search it and find a painkiller. Throwing caution to the wind, you decide to take the pill. ", "narrator");
                                hitPoints++;
                                Dialog("I'm going to have to make a choice.", "hero");
                                AnyKeyClear();
                                Part1Step3();
                            }
                            else
                            {
                                // if part1Step3FindRoll less than 7
                                Dialog("Kicking up some leaves, you find nothing, but you're still going to have to make a choice.", "narrator");
                                AnyKeyClear();
                                Part1Step3();
                            }
                        }
                        else if (part1Step3FindRoll >= 7)
                        {
                            Dialog("I'd rather not stumble across anything else here.... It's time to figure something out.", "narrator");
                            AnyKeyClear();
                            Part1Step3();
                        }
                        else if (part1Step3FindRoll < 7)
                        {
                            Dialog("There's nothing else of interest. Time to move on.", "narrator");
                            AnyKeyClear();
                            Part1Step3();
                        }

                        break;
                    }
                default:
                    {
                        Dialog("I do not understand that command, press enter to try again...", "narrator");
                        AnyKeyClear();
                        Part1Step3();
                        break;
                    }

                    // End part1Choice3 Switch
            }

            // End part1Step3
        }






        public static void Part1Step4()
        {
            // Part1Step4

            string part1Choice4;
            Dialog("You're hopelessly lost. Stopping in your tracks... You decide to make one last decision on direction.", "narrator");
            Dialog("I feel like I should stick to my guns, but yet I'm here lost so I don't know....", "hero");
            Dialog("What will you do?", "narrator");
            Console.WriteLine("1. Keep pressing forward?");
            Console.WriteLine("2. Try a different direction?");
            Console.WriteLine();
            Dialog("Type the number corresponding to your choice and press enter on your keyboard: ", "narrator");
            part1Choice4 = Console.ReadLine().ToLower();

            switch (part1Choice4)
            {
                case "1":
                    {
                        // Keep pressing forward
                        //Console.Clear();
                        Dialog("Must... Hold out.... Ther must be something", "hero");
                        Dialog("You are starting to visibly shiver, your last chance is to move forward.", "narrator");
                        Dialog("Eventually you come up to a clearing and that's when you see it.", "narrator");
                        AnyKeyClear();
                        Part2Step1();
                        break;
                    }
                case "2":
                    {
                        // Try a different direction
                        //Console.Clear();
                        Dialog("Must... Hold out.... Ther must be something", "hero");
                        Dialog("You are starting to visibly shiver, your last chance is to try a different direction.", "narrator");
                        AnyKeyClear();
                        Dialog("After 10 more minutes of trying to find your way, the cold has overtaken you and you're not going to last. Collapsing from the shivering, which causes the pain in your head to ramp up. You may not be a medical expert, but you know some of the signs of hypothermia. After attempting to struggle, you give up all hope. You curl up into the fetal position and fall asleep.... forever.", "narrator");
                        GameOver();

                        break;
                    }
                default:
                    {
                        Dialog("I do not understand that command, press enter to try again...", "narrator");
                        AnyKeyClear();
                        Part1Step4();
                        break;
                    }

                    // End part1Choice4 Switch
            }

            // End part1Step4
        }




        public static int gameOverCounter = 0;

        public static void GameOver()
        {
            // Red game over screen
            gameOverCounter++;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(@"........,.,,,,,,,,,,,,,,,,,,,,,,********************//********/*****************************,,,,,,,,");
            Console.WriteLine(@"..........,,,,,,,,,,,,,,,,,**,,****************/********///*********/*************************,*,,,,");
            Console.WriteLine(@"....,.,,,,,,,,,,,,**,,***************//*/****/*/**/*/*/*//////////////*////*/*/********************,");
            Console.WriteLine(@"...,,,,,,,,,,,,,*,,*******************//*/*///*//*/////////////////////////*///***/*****************");
            Console.WriteLine(@".,,,,,,,,,,,,,,********************///*//*///////*/////*////////////////(///////*////////**/********");
            Console.WriteLine(@",,,,,,,,,,,,*****************////////////////////////////////////////////////////////*/**//*********");
            Console.WriteLine(@",,,,,,,,,***********/*/*/////////(////////////////////////////(///////////////////////////*/****/***");
            Console.WriteLine(@",,,,*****************/*///*///#(//(////(////////////////////(/////((/((/(//////////////////*//***/*/");
            Console.WriteLine(@",*,,**********/**/***//////*(%&%%%%##&&%(((//(//(/((/(((/((((//(((((/((/(/(((/(/((((//(//////(//////");
            Console.WriteLine(@",*,,***********/*///////,###((.(###%&&@@@&(((((((((((((((((((((((/(#((/(((/(((((/((((///(///////////");
            Console.WriteLine(@",**********////*///%&%%//(////(/(/....*%%&&&&%((*%%&%&%&%&%%%(((((((((((##((((((/((((((//(//(///////");
            Console.WriteLine(@",*********/*///////####%%%%%%((((/(//(/...(%&&&%%%#(%&&&%%&@&&%((((#((((#(((/(((((/((#(///((////(///");
            Console.WriteLine(@"*********/////////(/ ...(#%&@@@&&&&##(((((..,%&@@@@@@@&#/,*(#&&&&&#((((#((#((((((##((#(/((////(/(///");
            Console.WriteLine(@"************/*/////(/((((/..#&&&&&&@@@@@@&#(/&@@@@@@@@@@@&&%#&&&@@&@@@@#(((((((((((#(((((((((((((//(");
            Console.WriteLine(@"*****,**///////////(((((((((((*...%%&&&@@&&@@@@@@@@@@@@@@@&&&@@@@&@@@@@@@((((((###((((((/(((#(((((/(");
            Console.WriteLine(@"******////#%&&%%%&&&%%&&@&%(((/((((/...(&@@@@@@@@@@@@@@@@@@@@@&@@@@@@@@@@&##((((((((((((((((((((((((");
            Console.WriteLine(@"***/*///,(/*//(####((#%&&@@@@@@@&&&%#%#&&@@@@@@@@@@@@@@@@@@@@@@@@&&@@@@@@@@&#(#(#(((##(((((((((((((/");
            Console.WriteLine(@"****////////((/(/(///......%%&&&@@&&&@@@@@@@@@@@@@@@@@@@@&@@@@@@@@@@@&@@@@@@@#(#(###((#(#(((((((((((");
            Console.WriteLine(@"/****//*/////(/((((((((((((#((...,&%&&@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@&@@@&&&######(##(((#(#((((((");
            Console.WriteLine(@"*/***////(///(//(((((((((/#(((((#(#..%@@@@@@@@@@@@@@&&&@@@@@@@@@@&@@@@@@@@@@&@@@&####(#(##(#((((((((");
            Console.WriteLine(@"*////*////((/%&&&&%%%##%(%%%##(######/(@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@&%@&(#(#(##((((((((((");
            Console.WriteLine(@"//*/////(((/(*#&&%%%%%&#%%@@@@@@@@@@@%@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@&&###%(%#(##(##(((");
            Console.WriteLine(@"////////(//(/(((((((*...,*%&@&&&&%&&%%&@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@&####(#((##(#((");
            Console.WriteLine(@"//////(//(((/((((((((((#(((((######(*....(&@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@&&&%####(#(#(#");
            Console.WriteLine(@"////////((/((((((((#(((##########%#%##%##%#(*..*%@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@&&&&&%%#(###");
            Console.WriteLine(@"////////(/((/(((((((((######(####%##%%#%%#%#%%%%%%#%/..,*#&@@@@@@@@@@@@@@@@@@@@@@@@@@@&&&&&&&&&&&#((");
            Console.WriteLine(@"//////(/(((((((((((((###(###########%####%%%%%%%%%%%%#%#&##%#%/..,*...(&&&@@@@@&@@@@@@@@@&&&&&&%%&%%");
            Console.WriteLine(@"/////////((((((#((#((((########(###(#%##(##%%%%#%#%%%&&%%%%%#%%##%%%%%%%%%%##* ./%&&&@@&&&&&&&&&@%%%");
            Console.WriteLine(@"*/*/////(((((((((#(((((#######(############%%#%%%%%%%%%#%%%#%##%%%%%##%#####%#####..#%&&&%&%&&&&%%%%");
            Console.WriteLine(@"****/////(//(((((((((((#(########((########%####%%%%%###%%%%%%%#%%#%%#################. ##%&&&&%%%%%");
            Console.WriteLine(@"  ▄████  ▄▄▄       ███▄ ▄███▓▓█████     ▒█████   ██▒   █▓▓█████  ██▀███  ");
            Console.WriteLine(@" ██▒ ▀█▒▒████▄    ▓██▒▀█▀ ██▒▓█   ▀    ▒██▒  ██▒▓██░   █▒▓█   ▀ ▓██ ▒ ██▒");
            Console.WriteLine(@"▒██░▄▄▄░▒██  ▀█▄  ▓██    ▓██░▒███      ▒██░  ██▒ ▓██  █▒░▒███   ▓██ ░▄█ ▒");
            Console.WriteLine(@"░▓█  ██▓░██▄▄▄▄██ ▒██    ▒██ ▒▓█  ▄    ▒██   ██░  ▒██ █░░▒▓█  ▄ ▒██▀▀█▄  ");
            Console.WriteLine(@"░▒▓███▀▒ ▓█   ▓██▒▒██▒   ░██▒░▒████▒   ░ ████▓▒░   ▒▀█░  ░▒████▒░██▓ ▒██▒");
            Console.WriteLine(@" ░▒   ▒  ▒▒   ▓▒█░░ ▒░   ░  ░░░ ▒░ ░   ░ ▒░▒░▒░    ░ ▐░  ░░ ▒░ ░░ ▒▓ ░▒▓░");
            Console.WriteLine(@"  ░   ░   ▒   ▒▒ ░░  ░      ░ ░ ░  ░     ░ ▒ ▒░    ░ ░░   ░ ░  ░  ░▒ ░ ▒░");
            Console.WriteLine(@"░ ░   ░   ░   ▒   ░      ░      ░      ░ ░ ░ ▒       ░░     ░     ░░   ░ ");
            Console.WriteLine(@"      ░       ░  ░       ░      ░  ░       ░ ░        ░     ░  ░   ░     ");
            Console.WriteLine(@"                                            ░                            ");
            Console.WriteLine();
            Console.ResetColor();
            AnyKeyClear();
            Console.WriteLine("TRY AGAIN?");
            Console.WriteLine();
            Console.WriteLine("1. Try again?");
            Console.WriteLine("2. Give up?");
            Console.WriteLine();
            Dialog("Type the number corresponding to your choice and press enter on your keyboard: ", "narrator");
            string gameOverChoice;
            gameOverChoice = Console.ReadLine().ToLower();

            switch (gameOverChoice)
            {
                case "1":
                    {
                        // try again
                        Console.WriteLine("Retry counter: " + gameOverCounter);
                        Console.WriteLine();

                        Dialog("No, I can't give up so easily!", "hero");

                        // resetting the public variables and flags
                        //Prints out the current value of the stats that will be reset
                        /*Console.WriteLine(hitPoints);
                        Console.WriteLine(part1Step2LookFlag);
                        Console.WriteLine(part1Step3LookFlag);*/
                        hitPoints = 1;
                        part1Step2LookFlag = false;
                        part1Step3LookFlag = false;

                        //Showing the results of resetting these values. IE hit points should now be back to 1, it's original value at the start of the game.
                        /*Console.WriteLine("RESET VALUES");
                        Console.WriteLine(hitPoints);
                        Console.WriteLine(part1Step2LookFlag);
                        Console.WriteLine(part1Step3LookFlag);*/

                        // Going back to the beginning
                        AnyKeyClear();
                        startGame();
                        break;
                    }
                case "2":
                    {
                        // end game
                        Environment.Exit(0);
                        break;
                    }
                default:
                    {
                        Dialog("I do not understand that command, press enter to try again...", "narrator");
                        AnyKeyClear();
                        GameOver();
                        break;
                    }

                    // End game over Switch
            }
            // End game over
        }




















        public static int encounterCounter;

        public static void Part2Step1()
        {
            // Part2Step1
            // You've arrived at the house. 
            Console.WriteLine(@"▄▄▄█████▓ ██░ ██ ▓█████     ██░ ██  ▒█████   █    ██   ██████ ▓█████ ");
            Console.WriteLine(@"▓  ██▒ ▓▒▓██░ ██▒▓█   ▀    ▓██░ ██▒▒██▒  ██▒ ██  ▓██▒▒██    ▒ ▓█   ▀ ");
            Console.WriteLine(@"▒ ▓██░ ▒░▒██▀▀██░▒███      ▒██▀▀██░▒██░  ██▒▓██  ▒██░░ ▓██▄   ▒███   ");
            Console.WriteLine(@"░ ▓██▓ ░ ░▓█ ░██ ▒▓█  ▄    ░▓█ ░██ ▒██   ██░▓▓█  ░██░  ▒   ██▒▒▓█  ▄ ");
            Console.WriteLine(@"  ▒██▒ ░ ░▓█▒░██▓░▒████▒   ░▓█▒░██▓░ ████▓▒░▒▒█████▓ ▒██████▒▒░▒████▒");
            Console.WriteLine(@"  ▒ ░░    ▒ ░░▒░▒░░ ▒░ ░    ▒ ░░▒░▒░ ▒░▒░▒░ ░▒▓▒ ▒ ▒ ▒ ▒▓▒ ▒ ░░░ ▒░ ░");
            Console.WriteLine(@"    ░     ▒ ░▒░ ░ ░ ░  ░    ▒ ░▒░ ░  ░ ▒ ▒░ ░░▒░ ░ ░ ░ ░▒  ░ ░ ░ ░  ░");
            Console.WriteLine(@"  ░       ░  ░░ ░   ░       ░  ░░ ░░ ░ ░ ▒   ░░░ ░ ░ ░  ░  ░     ░   ");
            Console.WriteLine(@"          ░  ░  ░   ░  ░    ░  ░  ░    ░ ░     ░           ░     ░  ░");
            Console.WriteLine();
            Dialog("What the hell? Why is this here in the middle of nowhere?", "hero");
            Dialog("You've come up to an old dilapidated house in the middle of the woods. The house is falling apart, but compared to being out in the dropping temperature, you'd rather take your chances indoors.", "narrator");
            Console.WriteLine();
            AnyKeyClear();
            Part2Step2();
        }




        //These variables are flags for if you have been in a room on the first floor or basement. 
        public static bool kitchenReveal = false; //You've been in the kitchen before
        public static bool diningReveal = false; //You've been in the dining room before
        public static bool firstFloorBathReveal = false; //You've been in the first floor bathroom before
        public static bool livingReveal = false; //You've been in the living room before
        public static bool basementReveal = false; //You've been in the basement before



        public static int part2Step2FindRoll; // creates the stat roll for part2step2
        public static bool part2Step2LookFlag = false; //Flag for if you've searched in this spot in part2step2.
        public static bool Part2Step2CellarFall = false; //flag for if you fell into the cellar or not so the context of the room established.

        public static bool frontdoorknobbroken = false; //is the front doorknob already broken?
        public static bool windowglasssharp = true; //did you clear the sharp glass?


        public static void Part2Step2()
        {
            string Part2Step2Choice1;
            Dialog("Looking at the front of the house, the front door is sitting past a broken porch, with a broken window off to the side with shards of glass justting out of the frame.", "narrator");
            Dialog("What will you do?", "narrator");
            Console.WriteLine("1. Try the front door?");
            Console.WriteLine("2. Climb through the broken window?");
            Console.WriteLine("3. Walk around the house to see if there is another way in?");
            Console.WriteLine("4. Look around to see if there is anything useful?");
            Console.WriteLine();
            Dialog("Type the number corresponding to your choice and press enter on your keyboard: ", "narrator");
            Part2Step2Choice1 = Console.ReadLine().ToLower();

            switch (Part2Step2Choice1)
            {
                case "1":
                    {
                        // choice 1 - front door
                        encounterCounter++;
                        Dialog("Hopefully nobody is home...", "hero");
                        Dialog("You approach the front door and turn the metal handle and it barely moves, nearly rusted in place. After a struggle, it's finally open enough for you to slide through. Once inside, you slide the door shut. Pushing from the handle, you excert too much force and the handle slaps clean off.", "narrator");
                        Dialog("Shit... I wont be able to open this again.", "hero");
                        frontdoorknobbroken = true;
                        livingReveal = true;
                        AnyKeyClear();
                        Part3Step1();
                        break;
                    }
                case "2":
                    {
                        // Choice 2 - window
                        encounterCounter++;
                        Dialog("You approach the broken window. Try as you might, you're unable to fully open the window. Taking as much care as you can, you use your fist to knock out the shards of glass.", "narrator");
                        Dialog("Ah shit!", "hero");
                        Dialog("Despite your care, your hand scraped against the sharp glasses. Luckily the cut isn't very deep, but you're able to tear a strap off a piece of clothing and wrap your hand to keep pressure on the wound. Once done, you're abler to climb through the window without further incident and now you're in the house.", "narrator");
                        hitPoints--;
                        livingReveal = true;
                        AnyKeyClear();
                        Part3Step1();
                        break;
                    }
                case "3":
                    {
                        // choice 3 - Takes you to the next choice
                        Dialog("You decide to take a walk around the house to explore other options.", "narrator");
                        AnyKeyClear();
                        Part2Step3();
                        break;
                    }
                case "4":
                    {
                        // Choice 4 - Look around Roll a number to see if you will find something.

                        if (!part2Step2LookFlag)
                        {
                            Dialog("You look around the front of the house to see if there is anything useful you can use.", "narrator");
                            RollStat(1, 10);
                            part2Step2FindRoll = stat;
                            if (part2Step2FindRoll >= 7)
                            {
                                Dialog("After searching for a few minutes, you come across a pretty thick stick that is strong enough to break the rest of the window glass. Taking a few breaths to prepare, you turn your head and swing the stick at the window to a sharp smashing sound, the rest of the glass shards break away and you climb through the window unscathed.", "narrator");
                                part2Step2LookFlag = true;
                                windowglasssharp = false;
                                livingReveal = true;
                                encounterCounter++;
                                AnyKeyClear();
                                Part3Step1();
                            }
                            else if (part2Step2FindRoll < 7)
                            {
                                Dialog("After a searching for a few minutes, you don't find anything useful.", "narrator");
                                part2Step2LookFlag = true;
                                AnyKeyClear();
                                Part2Step2();
                            }

                            //end IF for checking if you've searched before
                        }
                        else
                        {
                            Dialog("You search again, but there is nothing of use.", "narrator");
                            AnyKeyClear();
                            Part2Step2();
                        }
                        break;
                    }
                default:
                    {
                        Dialog("I do not understand that command, press enter to try again...", "narrator");
                        AnyKeyClear();
                        Part2Step1();
                        break;
                    }

                    // End Part2Step2Choice1 Switch
            }

            // End Part2Step2
        }




        public static bool backDoorAvailable = false;


        public static void Part2Step3()
        {
            // Back of the house, choose the cellar or the back door
            Dialog("Walking around the house, you come to the back of the house, you see a back door and a cellar door.", "narrator");
            string Part2Step3Choice1;
            Dialog("What will you do?", "narrator");
            Console.WriteLine("1. Try the back door?");
            Console.WriteLine("2. Try the cellar?");
            Console.WriteLine();
            Dialog("Type the number corresponding to your choice and press enter on your keyboard: ", "narrator");
            Part2Step3Choice1 = Console.ReadLine().ToLower();
            switch (Part2Step3Choice1)
            {
                case "1":
                    {
                        //Choose the back door
                        Dialog("You try the back door. The door scratches and drags across the floor. it will not be easy to open again, but at least you're inside and out of the elements now. You've entered the first floor of the house at the rear. You are in a kitchen, but you don't look around yet, instead you marvel at how this house is still standing despite it's age and how isolated it is. You walk into the next room.", "narrator");
                        backDoorAvailable = true;
                        kitchenReveal = true;
                        encounterCounter++;
                        AnyKeyClear();
                        Part3Step1();
                        break;
                    }
                case "2":
                    {
                        //Choose the cellar
                        Dialog("You try the cellar door. The cellar door is heavy, but you manage to get it open, but it slams against you as it closes, you fall into the basement head first and fall on your hands as you shield your head from the fall.", "narrator");
                        hitPoints--;
                        //will use basement reveal bool after the fall into the cellar part is done. 
                        Part2Step2CellarFall = true;
                        encounterCounter++;
                        AnyKeyClear();
                        Part3Step2();
                        break;
                    }
                default:
                    {
                        Dialog("I do not understand that command, press enter to try again...", "narrator");
                        AnyKeyClear();
                        Part2Step3();
                        break;
                    }

            }


        }




        public static void Part3Step1()
        {
            // In the house on the first floor
            //switch to explore the following rooms. use if statements to reveal the names of any room you've been in.
            //Kitchen, Dining Room, Living Room, Bathroom, Stairway to second floor, basement stairway.

            // CHECK ENCOUNTER COUNTER
            if (encounterCounter == 4) // if encounter counter = 4 on this floor, trigger encounterone
            {
                firstEncounterFirstFloor = true;
                firstEncounterSecondFloor = false;
                encounterOne();
            }
            else if (encounterCounter == 7)// if encounter counter = 6 on this floor, trigger encounterone
            {
                secondEncounterFirstFloor = true;
                secondEncounterSecondFloor = false;
                encounterTwo();
            }
            else if (encounterCounter == 10)// if encounter counter = 6 on this floor, trigger encounterone
            {
                thirdEncounterFirstFloor = true;
                thirdEncounterSecondFloor = false;
                encounterThree();
            }


            Dialog("In the living room, you look around and see there are multiple rooms you can search for anything useful. You're still hurting and cold, anything that you can find will be helpful to surviving the elements.", "narrator");
            string Part3Step1Choice1;
            Dialog("What will you do?", "narrator");

            // Revealing the names of the rooms if you've been in them before and have flipped the room flag to true.
            // ie: if kitchenReveal = true, then you can use "try the kitchen"
            if (!kitchenReveal)
            {
                Console.WriteLine("1. Try the far back room?");
            }
            else if (kitchenReveal)
            {
                Console.WriteLine("1. Try the kitchen?");
            }

            if (!diningReveal)
            {
                Console.WriteLine("2. Try the left room?");
            }
            else if (diningReveal)
            {
                Console.WriteLine("2. Try the dining room?");
            }

            // Living room is default so will be shown regardless right now, but the flag has been set for modifications later. 
            Console.WriteLine("3. Explore the living room?");

            //First floor bathroom
            if (!firstFloorBathReveal)
            {
                Console.WriteLine("4. Try the door to the right?");
            }
            else if (firstFloorBathReveal)
            {
                Console.WriteLine("4. Try the bathroom?");
            }

            //Basement
            if (!secondFloorReveal)
            {
                Console.WriteLine("5. Try the staircase leading up?");
            }
            else if (secondFloorReveal)
            {
                Console.WriteLine("5. Try the upstairs?");
            }

            //upstairs
            if (!basementReveal)
            {
                Console.WriteLine("6. Try the staircase leading down?");
            }
            else if (basementReveal)
            {
                Console.WriteLine("6. Try the basement?");
            }

            Console.WriteLine();
            Dialog("Type the number corresponding to your choice and press enter on your keyboard: ", "narrator");
            Part3Step1Choice1 = Console.ReadLine().ToLower();
            switch (Part3Step1Choice1)
            {
                case "1":
                    {
                        //Kitchen
                        Dialog("Walking into the far back room, you find yourself in the kitchen.", "narrator");
                        encounterCounter++;
                        AnyKeyClear();
                        Part3Step3();
                        break;
                    }
                case "2":
                    {
                        //Dining Room
                        Dialog("Walking into the left room, you find yourself in the dining room.", "narrator");
                        encounterCounter++;
                        AnyKeyClear();
                        Part3Step4();
                        break;
                    }
                case "3":
                    {
                        //Living Room
                        encounterCounter++;
                        Part3Step5();
                        break;
                    }
                case "4":
                    {
                        //1st floor bathroom

                        // check to see if you have the bathroom key
                        if (!livingBathroomKey && !firstFloorBathReveal)
                        {
                            Dialog("You go to the door to the right and try to open it, but the door is locked.", "narrator");
                            Dialog("Well if it's locked, there has to be a key around here somewhere. I should keep looking around.", "hero");
                            AnyKeyClear();
                            Part3Step1();
                        }
                        else if (livingBathroomKey && !firstFloorBathReveal)
                        {
                            Dialog("You go to the door to the right. It's locked, but you just found a key.", "narrator");
                            Dialog("Here goes nothing, time to see if this key works.", "hero");
                            Dialog("You wiggle the key into the lock and it eventually fits and unlocks! You slowly open the door and go in the room.", "narrator");
                            encounterCounter++;
                            AnyKeyClear();
                            Part3Step6();
                        }
                        else if (livingBathroomKey && firstFloorBathReveal)
                        {
                            Dialog("You deicde to try the bathroom again to see if you missed anything.", "narrator");
                            encounterCounter++;
                            AnyKeyClear();
                            Part3Step6();
                        }

                        break;
                    }
                case "5":
                    {
                        //Second Floor
                        Dialog("You approach the dark staircase that looks like it goes to the second floor.", "narrator");

                        encounterCounter++;
                        AnyKeyClear();
                        Part3Step7();
                        break;
                    }
                case "6":
                    {
                        //Basement
                        Dialog("text", "narrator");
                        encounterCounter++;
                        Dialog("You approach the dark staircase that looks like it goes into a basement. Descending the stairs step by step, each step creaks unstably, you hope that the steps will not give way.", "narrator");
                        AnyKeyClear();
                        Part3Step2();
                        break;
                    }
                default:
                    {
                        Dialog("I do not understand that command, press enter to try again...", "narrator");
                        AnyKeyClear();
                        Part3Step1();
                        break;
                    }

                    //end Part3Step1 switch
            }

            // End part3Step1
        }



        public static bool pantryHideAbility = false;

        public static bool kitchenSearched = false;


        public static void Part3Step3()
        {
            // The Kitchen

            if (!kitchenSearched)
            {
                Dialog("You're in the kitchen now. You look search all the pantry space and cupboards, but you find nothing except rusty pots and pans. You do note that the pantry is just large enough to fit in.", "narrator");
                Dialog("Finding nothing else of note, you head back out to the living room.", "narrator");
            }
            else if (kitchenSearched)
            {
                Dialog("Searching the kitchen again, you find nothing else of note, you head back out to the living room.", "narrator");
            }

            kitchenReveal = true;
            pantryHideAbility = true;
            kitchenSearched = true;

            AnyKeyClear();
            Part3Step1();
        }


        public static bool diningSearched = false;

        public static void Part3Step4()
        {
            // The Dining Room

            if (!diningSearched)
            {
                Dialog("The dining room table is broken and half of it has collapsed, but curiously, one of the ends is still standing. It looks only a little worn, like you could still eat there.", "narrator");
                Dialog("Finding nothing else of note, you head back out to the living room.", "narrator");
            }
            else if (diningSearched)
            {
                Dialog("Searching the dining room again, you find nothing else of note, you head back out to the living room.", "narrator");
            }

            diningReveal = true;
            diningSearched = true;
            AnyKeyClear();
            Part3Step1();
        }


        public static bool livingSearched = false;
        public static bool livingBathroomKey = false;
        public static bool firstFloorBathroomHideAbility = false;


        public static void Part3Step5()
        {
            // The Living Room

            if (!livingSearched && !livingBathroomKey)
            {
                Dialog("Taking a closer look at the living room, you find debris with bits of the ceiling littered across the floor along with broken glass with mounds of dust and dirt. One of the end tables has a drawer still attached, but when you pull it, it's tough to move and barely budges and inch. Defeated, you decide to look elsewhere to explore.", "narrator");
                livingReveal = true;
                livingSearched = true;
            }
            else if (livingSearched && !livingBathroomKey)
            {
                Dialog("You look around the room again and come back to the end table drawer. Determined, you spend the next five minutes wiggling the drawer and pulling with whatever upper body strength you can bring to bear until the drawer finally snaps open, hurling you backwards to the floor. You hear a metallic sound nearby your head, reaching out you find it's a small key that looks like it will open a door.", "narrator");
                livingBathroomKey = true;
                firstFloorBathroomHideAbility = true;
            }
            else if (livingSearched && livingBathroomKey)
            {
                Dialog("Searching the living room again, you find nothing else of note.", "narrator");
            }

            AnyKeyClear();
            Part3Step1();
        }

        public static void Part3Step6()
        {
            // 1st floor bathroom

            if (!firstFloorBathReveal)
            {
                Dialog("Broken glass and tiles litter the floor, it's a good thing you're wearing shoes shoes. In the medicine cabinet you find old pain pills. You decide to take it to dull the throbbing pain of your head..", "narrator");
                Dialog("Feeling some relief, you leave the bathroom.", "narrator");
                hitPoints++;
                firstFloorBathReveal = true;
            }
            else if (firstFloorBathReveal)
            {
                Dialog("You find nothing else of interest in the bathroom and go back out to the living room.", "narrator");
            }
            AnyKeyClear();
            Part3Step1();
        }

        public static void Part3Step7()
        {
            // Staircase to upstairs, walking upstairs
            // Transition into the upstairs hub for the upstairs rooms

            Dialog("You slowly ascend the staircase. Step by step, your steps become hallow. Sharp splinters stick out of some of the steps, you try and navigate as carefully as you can. After some time, you finally arrive upstairs.", "narrator");

            AnyKeyClear();
            Part3Step9();
        }







        public static bool basementHomeAlone = false;
        public static bool basementFootSlide = false;
        public static bool basementWallCrouch = false;
        public static bool basementCenterCrouch = false;
        public static bool basementWallStand = false;
        public static bool basementCenterStand = false;


        public static bool wardrobeKey = false;

        public static void Part3Step2()
        {
            // In the basement

            if (Part2Step2CellarFall && !basementReveal)
            {
                // If you fell into the cellar & the cellar reveal is false, play the fell into cellar section
                Dialog("Wow, that really hurt", "hero");
                Dialog("You take a minute to compose yourself after falling into the basement. There is not enough light to see except for a small shaft of light coming through a small window. It illuminates a small section of the floor in front of you.", "narrator");
            }
            else if (Part2Step2CellarFall && basementReveal)
            {
                // if you fell into the cellar and/or have already explored the room
                // a special line of dialog will play referencing the fact you fell into the cellar
                Dialog("The thought of coming back into this room makes your head and arms ache from the fall. You really don't want to try and explore the basement again, but you take a deep breath and proceed.", "narrator");
            }
            else if (basementReveal)
            {
                // First time in the basement if you did not fall into it.
                Dialog("You really don't want to try and explore the basement again, but you take a deep breath and proceed.", "narrator");
            }
            else if (!basementReveal)
            {
                // First time in the basement from the first floor
                Dialog("You are now in an old musty basement. There is not enough light to see except for a small shaft of light coming through a small window. It illuminates a small section of the floor in front of you.", "narrator");
            }


            string Part3Step2Choice1;
            Dialog("I can't make anything out down here, I should play this smart.", "hero");
            Dialog("What will you do?", "narrator");
            Console.WriteLine("1. Crouch down and proceed carefully?");
            Console.WriteLine("2. Remain standing and proceed carefully?");
            Console.WriteLine();
            Dialog("Type the number corresponding to your choice and press enter on your keyboard: ", "narrator");
            Part3Step2Choice1 = Console.ReadLine().ToLower();


            switch (Part3Step2Choice1)
            {

                case "1":
                    {
                        // choice 1 - crouch

                        Dialog("Okay I'm crouched, how should I explore the room?", "hero");
                        string Part3Step2Choice2;
                        Dialog("What will you do?", "narrator");
                        Console.WriteLine("1. Stick to the walls.");
                        Console.WriteLine("2. Screw the walls! Venture out into the room.");
                        Console.WriteLine();
                        Part3Step2Choice2 = Console.ReadLine().ToLower();

                        switch (Part3Step2Choice2)
                        {
                            case "1":
                                {
                                    //stay along the walls
                                    if (!basementWallCrouch)
                                    {
                                        Dialog("Slowly and methodolically you explore the room. Part-way along the wall, you place your hand down and your fingers dip down. You realize that if you hadn't been more careful, you could have fell into a hole in the floor. Wiping the cold sweat off your forehead, you press on until you finish exploring the basement.", "narrator");
                                        Dialog("After stumbling in the dark for a good while, you stumble onto a creaky stairway. Climbing the stairway and pushing past a heavy door, you find yourself on the ground floor and in the main area of the house.", "narrator");
                                        basementWallCrouch = true;
                                    }
                                    else if (basementWallCrouch)
                                    {
                                        Dialog("Staying along the walls again, you find nothing else of interst and you make your way back to the creaky staircase to the first floor", "narrator");
                                    }
                                    AnyKeyClear();
                                    basementReveal = true;
                                    Part3Step1();
                                    break;
                                }
                            case "2":
                                {
                                    //Explore the middle of the room
                                    //If you were "home alone'd" here, you avoid it a subsequent time.
                                    if (!basementHomeAlone)
                                    {
                                        Dialog("Slowly and methodolically you explore the room by venturing out into the middle of the room. After a few minutes of moving carefully, your hand lands on something that is very sharp. Crying out in pain, you rollover onto your back and nurse your hand until the throbbing lessens. As you prop yourself back up onto your hands and knees, your knee brushes against something metalic that slides across the floor.", "narrator");
                                        Dialog("Hey it's a key with faint writing on it... W-A-R-D-R-O-B-E. Maybe this could come in handy.", "hero");
                                        Dialog("After stumbling in the dark for a good while, you stumble onto a creaky stairway. Climbing the stairway and pushing past a heavy door, you find yourself on the ground floor and in the main area of the house.", "narrator");
                                        hitPoints--;
                                        wardrobeKey = true;
                                        basementReveal = true;
                                        basementHomeAlone = true;
                                    }
                                    else if (basementHomeAlone)
                                    {
                                        Dialog("Being extra careful this time, you avoid the nails in the center of the room. You don't find anything else of interset and you proceed back to the creaky stairway to the first floor.", "narrator");
                                    }

                                    AnyKeyClear();
                                    basementHomeAlone = true;
                                    Part3Step1();
                                    break;
                                }
                            default:
                                {
                                    //default action
                                    Dialog("I do not understand that command, press enter to try again...", "narrator");
                                    AnyKeyClear();
                                    Part3Step2();
                                    break;
                                }
                        }
                        break;
                    }
                case "2":
                    {
                        // Choice 2 - walk

                        Dialog("Okay I'm going to stay standing, how should I explore the room?", "hero");
                        string Part3Step2Choice2;
                        Dialog("What will you do?", "narrator");
                        Console.WriteLine("1. Stick to the walls.");
                        Console.WriteLine("2. Screw the walls! Venture out into the room.");
                        Console.WriteLine();
                        Dialog("Type the number corresponding to your choice and press enter on your keyboard: ", "narrator");
                        Part3Step2Choice2 = Console.ReadLine().ToLower();

                        switch (Part3Step2Choice2)
                        {
                            case "1":
                                {
                                    //stay along the walls
                                    //If you you fell into the hole here, you avoid it a subsequent time.
                                    if (!basementFootSlide)
                                    {
                                        Dialog("Slowly and methodolically you explore the room. Part-way along the wall, you let out a shriek of panic as your foot unexpectely falls into a hole in the floor. Luckily, you did not twist your ankle and it was shallow enough that you only felt a sharp pain in your back from the drop. Wiping the cold sweat off your forehead, you limp on until you finish exploring the basement.", "narrator");
                                        Dialog("After stumbling in the dark for a good while, you stumble onto a creaky stairway. Climbing the stairway and pushing past a heavy door, you find yourself on the ground floor and in the main area of the house.", "narrator");
                                        AnyKeyClear();
                                        hitPoints--;
                                        basementFootSlide = true;
                                    }
                                    else if (basementFootSlide)
                                    {
                                        Dialog("Luckily you remembered where the hole in the floor was and managed to evade it, but you find nothing else of interst and you make your way back to the creaky staircase to the first floor.", "narrator");
                                    }
                                    basementReveal = true;
                                    Part3Step1();
                                    break;
                                }
                            case "2":
                                {
                                    //Explore the middle of the room

                                    if (!basementCenterStand)
                                    {
                                        Dialog("Slowly and methodolically you explore the room by venturing out into the middle of the room. After a few minutes of moving carefully, your foot taps something small and metalic. Feeling at your feet, you feel a slight prick of a pointed object, you very nearly stepped on nails.", "narrator");
                                        Dialog("Wow that was a close call, that would have hurt.", "hero");
                                        Dialog("After stumbling in the dark for a good while, you stumble onto a creaky stairway. Climbing the stairway and pushing past a heavy door, you find yourself on the ground floor and in the main area of the house.", "narrator");
                                        basementCenterStand = true;
                                    }
                                    else if (basementCenterStand)
                                    {
                                        Dialog("Carefully exploring the middle of the room again, you find nothing else of interst and you make your way back to the creaky staircase to the first floor", "narrator");
                                    }
                                    AnyKeyClear();
                                    basementReveal = true;
                                    Part3Step1();
                                    break;
                                }
                            default:
                                {
                                    //default action
                                    Dialog("I do not understand that command, press enter to try again...", "narrator");
                                    AnyKeyClear();
                                    Part3Step2();
                                    break;
                                }
                        }
                        break;
                    }
                default:
                    {
                        //default action
                        Dialog("I do not understand that command, press enter to try again...", "narrator");
                        AnyKeyClear();
                        Part3Step2();
                        break;
                    }

            }

            // end Part3Step2
        }





        // Second Floor Section Of Room Exploration


        //Transition from second floor to first floor
        public static void Part3Step8()
        {
            // Staircase to upstairs, walking back to first floor
            // Transition into the upstairs hub for the upstairs rooms

            Dialog("You slowly descend the staircase, carefully avoiding the splinters you passed by earlier. After some time, you finally arrive downstairs on the first floor.", "narrator");

            AnyKeyClear();

            // back to first floor hub
            Part3Step1();
        }



        public static bool secondFloorReveal = false; //You've been upstairs before
        public static bool secondFloorBathReveal = false; //You've been to the upstairs bathroom before
        public static bool secondFloorBedroomReveal = false; //You've been to the upstairs bedroom before
        public static bool secondFloorStudyReveal = false; //You've been to the upstairs study before


        //second floor hub where you can select the rooms
        public static void Part3Step9()
        {
            // Upstairs Hub
            // Transition into the upstairs hub for the upstairs rooms
            // CHECK ENCOUNTER COUNTER FOR ENCOUNTER
            if (encounterCounter == 4)// if encounter counter = 4 on this floor, trigger encounterone
            {
                firstEncounterFirstFloor = false;
                firstEncounterSecondFloor = true;
                encounterOne();
            }
            else if (encounterCounter == 7)// if encounter counter = 6 on this floor, trigger encounterone
            {
                secondEncounterFirstFloor = false;
                secondEncounterSecondFloor = true;
                encounterTwo();
            }
            else if (encounterCounter == 10)// if encounter counter = 6 on this floor, trigger encounterone
            {
                thirdEncounterFirstFloor = false;
                thirdEncounterSecondFloor = true;
                encounterThree();
            }





            Dialog("On the second floor now, you see three more doors. ", "narrator");
            secondFloorReveal = true;

            string Part3Step9Choice1;
            Dialog("What will you do?", "narrator");

            // Shows the name of the room if the "revealed" flag is true.
            if (!secondFloorBedroomReveal)
            {
                Console.WriteLine("1. Try the left door?");
            }
            else if (secondFloorBedroomReveal)
            {
                Console.WriteLine("1. Try the bedroom?");
            }

            if (!secondFloorBathReveal)
            {
                Console.WriteLine("2. Try the middle door?");
            }
            else if (secondFloorBathReveal)
            {
                Console.WriteLine("2. Try the bathroom?");
            }

            if (!secondFloorStudyReveal)
            {
                Console.WriteLine("3. Try the door to the right?");
            }
            else if (secondFloorStudyReveal)
            {
                Console.WriteLine("3. Try the study?");
            }
            Console.WriteLine("4. Take the stairs back to the first floor?");
            Console.WriteLine();
            Dialog("Type the number corresponding to your choice and press enter on your keyboard: ", "narrator");
            Part3Step9Choice1 = Console.ReadLine().ToLower();

            switch (Part3Step9Choice1)
            {
                case "1": //Bedroom
                    {
                        if (!secondFloorBedroomReveal)
                        {
                            Dialog("You approach the door and enter the room.", "narrator");
                        }
                        else if (secondFloorBedroomReveal)
                        {
                            Dialog("You decide to search the bedroom again.", "narrator");
                        }
                        encounterCounter++;
                        Part3Step10();
                        break;
                    }
                case "2": //second floor bathroom
                    {
                        if (!secondFloorBathReveal)
                        {
                            Dialog("You approach the door and enter the room.", "narrator");
                        }
                        else if (secondFloorBathReveal)
                        {
                            Dialog("You decide to search the bathroom again.", "narrator");
                        }
                        encounterCounter++;
                        Part3Step11();
                        break;
                    }
                case "3": //study
                    {
                        if (!secondFloorStudyReveal)
                        {
                            Dialog("You approach the door and enter the room.", "narrator");
                        }
                        else if (secondFloorStudyReveal)
                        {
                            Dialog("You decide to search the study again.", "narrator");
                        }
                        encounterCounter++;
                        Part3Step12();
                        break;
                    }
                case "4": // Go back down to first floor
                    {
                        encounterCounter++;
                        Part3Step8();
                        break;
                    }
                default:
                    {
                        //default action
                        Dialog("I do not understand that command, press enter to try again...", "narrator");
                        AnyKeyClear();
                        Part3Step9();
                        break;
                    }

                    // End switch for Part3Step9  
            }

            //end second floor hub
        }




        public static bool bedroomHideAbility = false;

        public static void Part3Step10() //Second floor bedroom
        {

            if (!secondFloorBedroomReveal)
            {

                Dialog("The bed is tattered, there are moldy sheets on top of the bed.", "narrator");
                Dialog("Even if I was at death's door, I would not touch those sheets.", "hero");
                Dialog("Getting past the gag inducing smell, you note that there is enough space to crawl under the bed. Finding nothing else of note, you decide to head back into the hallway.", "narrator");

                secondFloorBedroomReveal = true;
                bedroomHideAbility = true;
            }

            else if (secondFloorBedroomReveal)
            {
                Dialog("You find nothing else of interest in the bedroom and head back out into the hallway.", "narrator");
            }

            AnyKeyClear();
            // back to second floor hub
            Part3Step9();
        }

        public static void Part3Step11() //Second floor bathroom
        {

            if (!secondFloorBathReveal)
            {
                Dialog("The bathroom is torn up, shattered glass and tiles everywhere. The tub is cracked in half and exposed pipe is jutted out of the wall. There's very little room to maneuver and the doorknob is broken and wont lock.", "narrator");
                secondFloorBathReveal = true;
            }

            else if (secondFloorBathReveal)
            {
                Dialog("You find nothing else of interest in the bathroom and head back out into the hallway.", "narrator");
            }

            AnyKeyClear();
            // back to second floor hub
            Part3Step9();
        }



        public static bool keyToWin = false;
        public static bool studyNothingLeft = false;
        public static bool studyHideAbility = false;

        public static void Part3Step12() //Second floor study
        {

            // implement the wardrobe chest to open to get the item you need to survive the game.

            if (!secondFloorStudyReveal && !wardrobeKey && !studyNothingLeft)
            {
                // If you have not been in the study before & you don't have the wardrobe key

                Dialog("You've entered a study. The floor is scratched like a path from the door to the window. Looking out the window, you see the front of the house where you were standing. It would have been easy to see you coming up to the house if someone was here. Looking inside, along the  wall, there is a large wardrobe chest. You try to open it, but it's locked. You search the room, but don't find a key.", "narrator");
                Dialog("There has to be a key around here somewhere..... but where.", "hero");
                Dialog("Finding no key, you leave the study.", "narrator");
                secondFloorStudyReveal = true;
            }
            else if (!secondFloorStudyReveal && wardrobeKey && !studyNothingLeft)
            {
                // If you have not been in the study before & you DO have the wardrobe key


                Dialog("You've entered a study. The floor is scratched like a path from the door to the window. Looking out the window, you see the front of the house where you were standing. It would have been easy to see you coming up to the house if someone was here. Looking inside, along the  wall, there is a large wardrobe chest. You try to open it, but it's locked.", "narrator");
                Dialog("Wait, I have that key from the basement!", "hero");
                Dialog("Frantically grabbing the key you open the wardrobe.", "narrator");
                Dialog("Holy shit!", "hero");
                Dialog("Shocked, you find a heavy winter coat, and pants! Exactly what you'd need to be outisde in the freezing temperature. You quickly put on the clothing. At first you feel the chill of the clothes sitting in that chest for lord knows how long, but after a short time, the chill turns into warmth and you're feeling comfortable, while you're still able to move around.", "narrator");
                Dialog("Satisifed with your reward, you head out of the study, but note that the wardrobe is large enough for you to fit in.", "narrator");
                keyToWin = true;
                hitPoints = hitPoints + 2;
                secondFloorStudyReveal = true;
                studyHideAbility = true;
                studyNothingLeft = true;
            }

            else if (secondFloorStudyReveal && !wardrobeKey && !studyNothingLeft)
            {
                // If you have been in the study before & DON'T have the wardrobe key
                Dialog("You've re-entered the study. Doing another once over on the room, you don't find anything else of use. Making another attempt, you try to open the wardrobe again, but it's still locked and impossible to open without the key. Defeated, you leave the study.", "narrator");
            }

            else if (secondFloorStudyReveal && wardrobeKey && !studyNothingLeft)
            {
                // if you have been in the study before & DO have the wardrobe key.
                Dialog("You've re-entered a study with the wardrobe key now in your hand.", "narrator");
                Dialog("Let's see if this works...", "hero");
                Dialog("Nervously gripping the key, you open the wardrobe.", "narrator");
                Dialog("Holy shit!", "hero");
                Dialog("Shocked, you find a heavy winter coat, and pants! Exactly what you'd need to be outisde in the freezing temperature. You quickly put on the clothing. At first you feel the chill of the clothes sitting in that chest for lord knows how long, but after a short time, the chill turns into warmth and you're feeling comfortable, while you're still able to move around.", "narrator");
                Dialog("Satisifed with your reward, you head out of the study, but note that the wardrobe is large enough for you to fit in.", "narrator");
                keyToWin = true;
                hitPoints = hitPoints + 2;
                studyNothingLeft = true;
            }
            else if (studyNothingLeft)
            {
                // if none of the above are true, just in case a scenario is missed
                Dialog("You find nothing else of interest in the study and head back out into the hallway.", "narrator");
            }

            AnyKeyClear();
            // back to second floor hub
            Part3Step9();
        }








        public static bool firstEncounterFirstFloor = false;
        public static bool firstEncounterSecondFloor = false;
        public static bool secondEncounterFirstFloor = false;
        public static bool secondEncounterSecondFloor = false;
        public static bool thirdEncounterFirstFloor = false;
        public static bool thirdEncounterSecondFloor = false;



        public static void testfunction() //build the if statement for first encounter
        {

            if (encounterCounter == 4) // if encounter counter = 4 on this floor, trigger encounterone
            {
                firstEncounterFirstFloor = true;
                firstEncounterSecondFloor = false;
                encounterOne();
            }
            else if (encounterCounter == 6)// if encounter counter = 6 on this floor, trigger encounterone
            {
                firstEncounterFirstFloor = true;
                firstEncounterSecondFloor = false;
                encounterTwo();
            }
            else if (encounterCounter == 8)// if encounter counter = 6 on this floor, trigger encounterone
            {
                thirdEncounterFirstFloor = true;
                thirdEncounterSecondFloor = false;
                encounterThree();
            }



            if (encounterCounter == 4)// if encounter counter = 4 on this floor, trigger encounterone
            {
                secondEncounterFirstFloor = false;
                secondEncounterSecondFloor = true;
                encounterOne();
            }
            else if (encounterCounter == 6)// if encounter counter = 6 on this floor, trigger encounterone
            {
                secondEncounterFirstFloor = false;
                secondEncounterSecondFloor = true;
                encounterTwo();
            }
            else if (encounterCounter == 8)// if encounter counter = 6 on this floor, trigger encounterone
            {
                thirdEncounterFirstFloor = false;
                thirdEncounterSecondFloor = true;
                encounterThree();
            }





        }


        public static void encounterOne() //build the if statement for first encounter
        {

            if (firstEncounterFirstFloor && !firstEncounterSecondFloor) //if triggered in first floor
            {
                Dialog("You're startled by a noise, a small scratching sound. Looking around the living room, you turn over broken floorboard and...", "narrator");
                Dialog("Holy fuck!", "hero");
                Dialog("An oversized rat lunges out of the debris, nearly landing on you as you stumble back to dodge it. At full speed, it flies down the hall and into the darkness. The patter of it's tiny paws echoes, it sounds like it crawled into the wall and is finding a new hiding spot.", "narrator");
                Dialog("Taking a deep breath and calming down, a new noise pierces the sound of your heartbeat...", "narrator");
                Dialog("GRAUUUUUW", "evil");
                Dialog("You hear a growling sound off in the distance, but it sounds like it's just past the tree line outside. You look out the window in the location of the sound, but there isn't enough light to see past the first trees outside.", "narrator");
                Dialog("Your heart beating louder, you take a moment to calm down and proceed to search for something that could hel you survive the cold air, you know you don't want to linger in this house much longer.", "narrator");
                AnyKeyClear();
                encounterCounter++;
                Part3Step1(); //back to the living room
            }
            else if (!firstEncounterFirstFloor && firstEncounterSecondFloor) //if triggered on second floor
            {
                Dialog("You're startled by a noise, a small scratching sound. Looking around the upstairs hallway, you turn over broken floorboard and...", "narrator");
                Dialog("Holy fuck!", "hero");
                Dialog("An oversized rat lunges out of the debris, nearly landing on you as you stumble back to dodge it. At full speed, it flies down the stairs and into the darkness. The patter of it's tiny paws echoes, it sounds like it crawled into the wall and is finding a new hiding spot.", "narrator");
                Dialog("Taking a deep breath and calming down, a new noise pierces the sound of your heartbeat...", "narrator");
                Dialog("GRAUUUUUW", "evil");
                Dialog("You hear a growling sound off in the distance, but it sounds like it's just past the tree line outside. You look out the window in the location of the sound. While the leaves on the trees are deathly still, there is a single tree with branches that are swaying as if something had just brushed up against them.", "narrator");
                Dialog("Your heart beating louder, you take a moment to calm down and proceed to search for something that could hel you survive the cold air, you know you don't want to linger in this house much longer.", "narrator");
                AnyKeyClear();
                encounterCounter++;
                Part3Step9(); //back to the upstairs hallway
            }
            else
            {
                Dialog("Encounter One Error, could not ascertain which floor event occurs on", "evil");
            }



        }


        public static int encounterTwoRoll;
        public static int raccoonHit;


        public static void encounterTwo() //build the if statement for first encounter
        {

            if (secondEncounterFirstFloor && !secondEncounterSecondFloor) //if triggered in first floor
            {
                Dialog("Back in the living room, you take a few steps forward and...", "narrator");
                Dialog("What the fuck!?", "hero");
                Dialog("A fat raccoon darts out from behind a broken wooden seat. It stops and turns towards you, snarling and showing its teeth and slowly crawling towards you!", "narrator");

                // Roll a number to see if you will find something.
                RollStat(1, 10);
                encounterTwoRoll = stat;

                if (encounterTwoRoll >= 5)
                {
                    // if encounterTwoRoll is 5 or more
                    Dialog("Scrambling, you look for anything that could be useful. Luckily, there happens to be a rock near your feet. You pick up the rock and hurl it at the raccoon.", "narrator");
                    RollStat(1, 10);
                    raccoonHit = stat;

                    if (raccoonHit >= 8) // you hit the raccoon with the rock
                    {
                        Dialog("The rock connects directly with the raccoon's cranium, sending it scurrying away, grumling as it flees.", "narrator");

                    }
                    else // you miss the raccoon and suffer the consequence
                    {
                        Dialog("The rock grazes its leg. It looks down at the rock you threw and then looks back up at you and charges full speed. It sinks its teeth into your leg. Luckily you're able to kick it off of you and it scurries away, grumbling as it flees.", "narrator");
                        hitPoints--;
                    }
                }
                else
                {
                    // if encounterTwoRoll less than 5
                    Dialog("Panicked, you're unable to find anything to defend yourself against the approaching raccoon. It sinks its teeth into your leg. Luckily you're able to kick it off of you and it scurries away, grumbling as it flees.", "narrator");
                    hitPoints--;
                }
                AnyKeyClear();
                encounterCounter++;
                Part3Step1(); //back to the living room
            }
            else if (!secondEncounterFirstFloor && secondEncounterSecondFloor) //if triggered on second floor
            {
                Dialog("Back in the upstairs hallway, you take a few steps forward and...", "narrator");
                Dialog("What the fuck!?", "hero");
                Dialog("A fat raccoon darts out from the steps. It stops and turns towards you, snarling and showing its teeth and slowly crawling towards you!", "narrator");

                // Roll a number to see if you will find something.
                RollStat(1, 10);
                encounterTwoRoll = stat;

                if (encounterTwoRoll >= 5)
                {
                    // if encounterTwoRoll is 5 or more
                    Dialog("Scrambling, you look for anything that could be useful. Luckily, there happens to be a rock near your feet. You pick up the rock and hurl it at the raccoon.", "narrator");
                    RollStat(1, 10);
                    raccoonHit = stat;

                    if (raccoonHit >= 8) // you hit the raccoon with the rock
                    {
                        Dialog("The rock connects directly with the raccoon's cranium, sending it scurrying away, grumling as it flees.", "narrator");
                    }
                    else // you miss the raccoon and suffer the consequence
                    {
                        Dialog("The rock grazes its leg. It looks down at the rock you threw and then looks back up at you and charges full speed. It sinks its teeth into your leg. Luckily you're able to kick it off of you and it scurries away, grumbling as it flees.", "narrator");
                        hitPoints--;
                    }
                }
                else
                {
                    // if encounterTwoRoll less than 5
                    Dialog("Panicked, you're unable to find anything to defend yourself against the approaching raccoon. It sinks its teeth into your leg. Luckily you're able to kick it off of you and it scurries away, grumbling as it flees.", "narrator");
                    hitPoints--;
                }

                AnyKeyClear();
                encounterCounter++;
                Part3Step9(); //back to the upstairs hallway
            }
            else
            {
                Dialog("Encounter One Error, could not ascertain which floor event occurs on", "evil");
            }

        }


        public static int encounterThreeRollStat;



        public static void encounterThree() //build the if statement for third encounter
        {

            // set up the upstairs and downstairs. see if it can all be implemented into this one function to handle ALL the rooms and text and what could happen. 
            // If upstairs or downstairs
            // Make if/else and put a switch for upstairs room and downstairs rooms
            // make both switches cover all rooms.
            // failing to hide you get hit and you escape to upstairs or first floor and then you get one more chance to hide in encounter 4. If you can't hide then, you're dead. If you can hide, you get the escape sequence and you get hit point loss, frozen death or you win. If you successfully hide, the monster goes away until you explore more rooms till encounter 4. 


            string encounterThreeChoice1;


            if (thirdEncounterFirstFloor && !thirdEncounterSecondFloor) //if triggered in first floor
            {
                Dialog("Back in the living room, you hear a crashing noise outside followed by loud footsteps.... Someone is trying to get into the house, but the footsteps don't sound like normal footsteps. They are highly irregular, almost shambling, but moving with a purpose. Whatever it is, you can hear the distinct sound of deep breaths. After a moment of silcence...", "narrator");
                Dialog("GRAUUUUUW", "evil");
                Dialog("Whatever is outside... it. knows. you're. here. The footsteps abruptly change towards the front door followed by loud impacts against the splintered wood. It's looking for you and trying to get into the house.", "narrator");
                Dialog("Fuck... Fuck! What do I do!?", "hero");
                Dialog("You quietly mutter to yourself. You need to make a decision right away!", "narrator");
                Dialog("What will you do?", "narrator");



                // all the ground floor 3rd encounter happens here. 


                // If you survive encounterthree on the first floor you go to:
                //encounterFourDownstairs();



                // Shows the name of the room if the "revealed" flag is true.

                if (!kitchenReveal)
                {
                    Console.WriteLine("1. Try the far back room?");
                }
                else if (kitchenReveal)
                {
                    Console.WriteLine("1. Hide in the kitchen?");
                }

                if (!diningReveal)
                {
                    Console.WriteLine("2. Try the left room?");
                }
                else if (diningReveal)
                {
                    Console.WriteLine("2. Hide in the dining room?");
                }

                // Living room is default so will be shown regardless right now, but the flag has been set for modifications later. 
                Console.WriteLine("3. Hide in the living room?");

                //First floor bathroom
                if (!firstFloorBathReveal)
                {
                    Console.WriteLine("4. Try the door to the right?");
                }
                else if (firstFloorBathReveal)
                {
                    Console.WriteLine("4. Hide in the bathroom?");
                }

                //Basement
                if (!secondFloorReveal)
                {
                    Console.WriteLine("5. Try the staircase leading up?");
                }
                else if (secondFloorReveal)
                {
                    Console.WriteLine("5. Try hiding upstairs?");
                }

                //upstairs
                if (!basementReveal)
                {
                    Console.WriteLine("6. Try the staircase leading down?");
                }
                else if (basementReveal)
                {
                    Console.WriteLine("6. Hide in the basement?");
                }

                Console.WriteLine();
                Dialog("Type the number corresponding to your choice and press enter on your keyboard: ", "narrator");

                encounterThreeChoice1 = Console.ReadLine().ToLower();


                switch (encounterThreeChoice1)
                {
                    case "1":
                        {
                            //Kitchen hide - automatically successful because there is a pantry.
                            AnyKeyClear();
                            if (!kitchenReveal && !pantryHideAbility)
                            {
                                Dialog("You find yourself in the kitchen. Scrambling to find a place to hide, you spot a small pantry that's just big enough for you to fit in it. You squeeze in just in time. There's just enough room to peer out at your surroundings.", "narrator");
                            }
                            else if (kitchenReveal && !pantryHideAbility)
                            {
                                Dialog("You burst back into the kitchen. Scrambling to find a place to hide, you spot a small pantry that's just big enough for you to fit in it. You squeeze in just in time. There's just enough room to peer out at your surroundings.", "narrator");
                            }
                            else if (kitchenReveal && pantryHideAbility)
                            {
                                Dialog("You burst back into the kitchen. You remembered the pantry and quickly squeeze yourself inside with no time to spare. There's just enough room to peer out at your surroundings.", "narrator");
                            }


                            // successful hide
                            Dialog("The treading of the shambling footsteps grows louder and louder. You hear other doors smashed open as whatever is looking for you continues to prowl the house.", "narrator");
                            Dialog("After a short time, the scraping footsteps arrive in the room.", "narrator");
                            Dialog("That's when you get a good look at it.... It appears humanoid, but very old, yet it somehow has strength even though the skin appears to be cracked and wretched and it can barely walk. There is a horrendus gurgling as it pants and strugles to breathe.", "narrator");
                            Dialog("It creeps up within feet of you.", "narrator");
                            Dialog("Time seems to slow down. Your heartbeat starts to sound like a ticking clock, the time between ticks grows ever longer.", "narrator");
                            Dialog("After what seems to feel like an eternity, the figure shambles out of the room and into another nearby room. You decide to make your move. Waiting for just the right time when the footsteps sound furthest away, you slide out from your hiding place and tiptoe to the hallway. Carefully peering out, it looks like it's in the next room. You make a break for it out of the room.", "narrator");
                            Dialog("WHHHHHHRGRAUUUUUW", "evil");
                            Dialog("FUCK!", "hero");
                            Dialog("You're able to dodge it's arm as it reaches at you, the creature following close behind.", "narrator");
                            
                            AnyKeyClear();
                            encounterFourDownstairs();

                            break;
                        }
                    case "2":
                        {
                            //Dining Room hide
                            AnyKeyClear();
                            
                            if (!diningReveal)
                            {
                                Dialog("You find yourself in the dining room. The dining room table is broken with half of it collapsed. Hoping it will be enough to hide you, you drop to your knees and crawl under the table.", "narrator");
                            }
                            else if (diningReveal)
                            {
                                Dialog("Rushing back to the dining room. It may not be much, but you're hoping the half broken dining room table will provide enough cover to hide under.", "narrator");
                            }

                            // failed hide
                            Dialog("The treading of the shambling footsteps grows louder and louder. You hear other doors smashed open as whatever is looking for you continues to prowl the house.", "narrator");
                            Dialog("After a short time, the scraping footsteps arrive in the room.", "narrator");
                            Dialog("That's when you get a good look at it.... It appears humanoid, but very old, yet it somehow has strength even though the skin appears to be cracked and wretched and it can barely walk. There is a horrendus gurgling as it pants and strugles to breathe.", "narrator");
                            Dialog("It creeps up within feet of you.", "narrator");
                            Dialog("Time seems to slow down. Your heartbeat starts to sound like a ticking clock, the time between ticks grows ever longer.", "narrator");
                            Dialog("You feel it's gaze measure you up as it lets out a shreik.", "narrator");
                            Dialog("WHHHHHHRGRAUUUUUW", "evil");
                            Dialog("FUCK!", "hero");
                            Dialog("Your screams are muffled as the creature engulfs you, pulling you closer to it as it bites out a large chunk of your neck. Your cries of terror echo throughout the house. Bite by bite, your body can no longer fight and your last moments are agonizing.", "narrator");

                            AnyKeyClear();
                            GameOverWitch();
                            break;
                        }
                    case "3":
                        {
                            //Living Room hide
                            AnyKeyClear();

                            Dialog("Scrambling, you decide to hide in the centralized room in the house, if you can get past whatever that thing is, you'll be closer to the exits. Hoping the couch and chairs will provide enough cover, you drop to your knees and hide behind the couch.", "narrator");


                            // failed hide
                            Dialog("The treading of the shambling footsteps grows louder and louder. You hear other doors smashed open as whatever is looking for you continues to prowl the house.", "narrator");
                            Dialog("After a short time, the scraping footsteps arrive in the room.", "narrator");
                            Dialog("That's when you get a good look at it.... It appears humanoid, but very old, yet it somehow has strength even though the skin appears to be cracked and wretched and it can barely walk. There is a horrendus gurgling as it pants and strugles to breathe.", "narrator");
                            Dialog("It creeps up within feet of you.", "narrator");
                            Dialog("Time seems to slow down. Your heartbeat starts to sound like a ticking clock, the time between ticks grows ever longer.", "narrator");
                            Dialog("You feel it's gaze measure you up as it lets out a shreik.", "narrator");
                            Dialog("WHHHHHHRGRAUUUUUW", "evil");
                            Dialog("FUCK!", "hero");
                            Dialog("Your screams are muffled as the creature engulfs you, pulling you closer to it as it bites out a large chunk of your neck. Your cries of terror echo throughout the house. Bite by bite, your body can no longer fight and your last moments are agonizing.", "narrator");

                            AnyKeyClear();
                            GameOverWitch();

                            break;
                        }
                    case "4":
                        {
                            //1st floor bathroom

                            // check to see if you have the bathroom key
                            if (!livingBathroomKey && !firstFloorBathReveal)
                            {
                                AnyKeyClear();
                                // not explored, no key
                                // failed hide, caught in the room
                                Dialog("You come up to the door, but the door is locked. Try as you might, you're unable to open the door and your heart sinks as the treading of the shambling footsteps grows louder and louder. You hear other doors smashed open as whatever is looking for you continues to prowl the house.", "narrator");
                                Dialog("After a short time, the scraping footsteps arrive in the room.", "narrator");
                                Dialog("That's when you get a good look at it.... It appears humanoid, but very old, yet it somehow has strength even though the skin appears to be cracked and wretched and it can barely walk. There is a horrendus gurgling as it pants and strugles to breathe.", "narrator");
                                Dialog("It creeps up within feet of you.", "narrator");
                                Dialog("Time seems to slow down. Your heartbeat starts to sound like a ticking clock, the time between ticks grows ever longer.", "narrator");
                                Dialog("You feel it's gaze measure you up as it lets out a shreik.", "narrator");
                                Dialog("WHHHHHHRGRAUUUUUW", "evil");
                                Dialog("FUCK!", "hero");
                                Dialog("Your screams are muffled as the creature engulfs you, pulling you closer to it as it bites out a large chunk of your neck. Your cries of terror echo throughout the house. Bite by bite, your body can no longer fight and your last moments are agonizing.", "narrator");

                            }
                            else if (livingBathroomKey && !firstFloorBathReveal)
                            {
                                // not explored, but you have key

                                AnyKeyClear();

                                // successful hide
                                Dialog("You come up to the door, but the door is locked. Try as you might, you're unable to open the door and your heart sinks as the treading of the shambling footsteps grows louder and louder. At the last moment, you realize that you have a key that could work for this door. Scrambling, you grab the key after several attempts, you steady your hand enough to slide the key into the lock. Your eyes widen as the key turns and the knob unlocks! Quickly, you open the door to reveal a small bathroom and you proceed to lock yourself in. There are a few cracks in the door that you're able to peer out through into the living room. You hear other doors smashed open as whatever is looking for you continues to prowl the house.", "narrator");
                                Dialog("After a short time, the scraping footsteps arrive in the living room.", "narrator");
                                Dialog("That's when you get a good look at it.... It appears humanoid, but very old, yet it somehow has strength even though the skin appears to be cracked and wretched and it can barely walk. There is a horrendus gurgling as it pants and strugles to breathe.", "narrator");
                                Dialog("It creeps up within feet of the door and hits the door with tremendous force, the sound rings in your ears it's so loud.", "narrator");
                                Dialog("Time seems to slow down. Your heartbeat starts to sound like a ticking clock, the time between ticks grows ever longer.", "narrator");
                                Dialog("After what seems to feel like an eternity, the figure shambles away from the door and into another nearby room. You decide to make your move. Waiting for just the right time when the footsteps sound furthest away, you slowly open the door and tiptoe into the living room. Carefully peering out, it looks like it's in the next room. You make a break for it.", "narrator");
                                Dialog("WHHHHHHRGRAUUUUUW", "evil");
                                Dialog("FUCK!", "hero");
                                Dialog("You're able to dodge it's arm as it reaches at you, the creature following close behind.", "narrator");

                                AnyKeyClear();
                                encounterFourDownstairs();

                            }
                            else if (livingBathroomKey && firstFloorBathReveal)
                            {
                                // explored AND you have the key
                                AnyKeyClear();

                                // successful hide
                                Dialog("You come up to the bathroom door which you unlocked earlier. Quickly, you open the door and you proceed to lock yourself in. There are a few cracks in the door that you're able to peer out through into the living room. You hear other doors smashed open as whatever is looking for you continues to prowl the house.", "narrator");
                                Dialog("After a short time, the scraping footsteps arrive in the living room.", "narrator");
                                Dialog("That's when you get a good look at it.... It appears humanoid, but very old, yet it somehow has strength even though the skin appears to be cracked and wretched and it can barely walk. There is a horrendus gurgling as it pants and strugles to breathe.", "narrator");
                                Dialog("It creeps up within feet of the door and hits the door with tremendous force, the sound rings in your ears it's so loud.", "narrator");
                                Dialog("Time seems to slow down. Your heartbeat starts to sound like a ticking clock, the time between ticks grows ever longer.", "narrator");
                                Dialog("After what seems to feel like an eternity, the figure shambles away from the door and into another nearby room. You decide to make your move. Waiting for just the right time when the footsteps sound furthest away, you slowly open the door and tiptoe into the living room. Carefully peering out, it looks like it's in the next room. You make a break for it.", "narrator");
                                Dialog("WHHHHHHRGRAUUUUUW", "evil");
                                Dialog("FUCK!", "hero");
                                Dialog("You're able to dodge it's arm as it reaches at you, the creature following close behind.", "narrator");

                                AnyKeyClear();
                                encounterFourDownstairs();
                            }

                            break;
                        }
                    case "5":
                        {
                            //Second Floor hide, takes you to a function that repeats the encounterthree options for the second floor.

                            Dialog("There's not much time, you want to put as much distance as you can between yourself and whatever that thing is. Taking your chances, you believe there will be a place you can hide upstairs. Moving fast, you crawl up the stairs taking care to make as little noise as possible so you don't give yourself away to the figure.", "narrator");
                            
                            AnyKeyClear();
                            encounterThreeHideUpstairs();

                            break;
                        }
                    case "6":
                        {
                            //Basement hide

                            // if you've explored the basement, you can hide
                            if (basementReveal)
                            {
                                // successful hide
                                AnyKeyClear();

                                Dialog("There is little light in the basement, it's hard to see anything. You decide to stick to the edge of the room since you can't see and you can hug the wall. You remember that the basement was hazardous and you move as carefully as you can, just in time to avoid your foot falling into a hole in the floor.", "narrator");
                                Dialog("The treading of the shambling footsteps above you grows louder and louder. You hear other doors smashed open as whatever is looking for you continues to prowl the house.", "narrator");
                                Dialog("After a short time, the scraping footsteps find the stairs and the figure descends into the basement.", "narrator");
                                Dialog("Though dimly lit, That's when you get your first look at it.... It appears humanoid, but very old, yet it somehow has strength even though the skin appears to be cracked and wretched and it can barely walk. There is a horrendus gurgling as it pants and strugles to breathe.", "narrator");
                                Dialog("It stalks the room and lets out a loud shriek, the sound rings in your ears it's so loud, but you keep your composure and hold your breath to not panic.", "narrator");
                                Dialog("Time seems to slow down. Your heartbeat starts to sound like a ticking clock, the time between ticks grows ever longer.", "narrator");
                                Dialog("After what seems to feel like an eternity, the figure shambles back to the stairs and creeps upstairs and into another room. You decide to make your move. Waiting for just the right time when the footsteps sound furthest away, you slowly ascend the staircase and tiptoe into the living room. Carefully peering out, it looks like it's in the next room. You make a break for it.", "narrator");
                                Dialog("WHHHHHHRGRAUUUUUW", "evil");
                                Dialog("FUCK!", "hero");
                                Dialog("You're able to dodge it's arm as it reaches at you, the creature following close behind.", "narrator");
                                
                                AnyKeyClear();
                                encounterFourDownstairs();

                            }
                            else if (!basementReveal)
                            {
                                // failed hide
                                AnyKeyClear();

                                Dialog("There is little light in the basement, it's hard to see anything. You decide to stick to the edge of the room since you can't see and you can hug the wall. As you move further into the room, your foot falls into a hole. Covering your mouth, you try to muffle your agony as you drop to the floor to tend to your foot.", "narrator");
                                Dialog("The treading of the shambling footsteps above you grows louder and louder. You hear other doors smashed open as whatever is looking for you continues to prowl the house.", "narrator");
                                Dialog("After a short time, the scraping footsteps find the stairs and the figure descends into the basement.", "narrator");
                                Dialog("Though dimly lit, That's when you get your first look at it.... It appears humanoid, but very old, yet it somehow has strength even though the skin appears to be cracked and wretched and it can barely walk. There is a horrendus gurgling as it pants and strugles to breathe.", "narrator");
                                Dialog("It creeps up within feet of you.", "narrator");
                                Dialog("Time seems to slow down. Your heartbeat starts to sound like a ticking clock, the time between ticks grows ever longer.", "narrator");
                                Dialog("You feel it's gaze measure you up as it lets out a shreik.", "narrator");
                                Dialog("WHHHHHHRGRAUUUUUW", "evil");
                                Dialog("FUCK!", "hero");
                                Dialog("Your screams are muffled as the creature engulfs you, pulling you closer to it as it bites out a large chunk of your neck. Your cries of terror echo throughout the house. Bite by bite, your body can no longer fight and your last moments are agonizing.", "narrator");

                                AnyKeyClear();
                                GameOverWitch();
                            }
                            
                            break;
                        }
                    default:
                        {
                            Dialog("I do not understand that command, press enter to try again...", "narrator");
                            AnyKeyClear();
                            encounterThree();
                            break;
                        }

                    //end encounterThree first floor switch
                }

                // end first floor encounterthree if statements
            }
            else if (!thirdEncounterFirstFloor && thirdEncounterSecondFloor) //if triggered on second floor
            {
                Dialog("Back in the hallway, you hear a crashing noise downstairs followed by loud footsteps.... Someone is in the house, but the footsteps don't sound like normal footsteps. They are highly irregular, almost shambling, but moving with a purpose. Whatever it is, you can hear the distinct sound of deep breaths. After a moment of silcence...", "narrator");
                Dialog("GRAUUUUUW", "evil");
                Dialog("Whatever is downstairs... it. knows. you're. here. The footsteps abruptly change towards the stairs. It's looking for you. One by one, you hear it slowly ascending the staircase.", "narrator");
                Dialog("Fuck... Fuck! What do I do!?", "hero");
                Dialog("You quietly mutter to yourself. You need to make a decision right away!", "narrator");
                Dialog("What will you do?", "narrator");


                // Shows the name of the room if the "revealed" flag is true.
                if (!secondFloorBedroomReveal)
                {
                    Console.WriteLine("1. Try the left door?");
                }
                else if (secondFloorBedroomReveal)
                {
                    Console.WriteLine("1. Hide in the bedroom?");
                }

                if (!secondFloorBathReveal)
                {
                    Console.WriteLine("2. Try the middle door?");
                }
                else if (secondFloorBathReveal)
                {
                    Console.WriteLine("2. Hide in the bathroom?");
                }

                if (!secondFloorStudyReveal)
                {
                    Console.WriteLine("3. Try the door to the right?");
                }
                else if (secondFloorStudyReveal)
                {
                    Console.WriteLine("3. Hide in the study?");
                }
                Console.WriteLine("4. Try to slip by as it comes up the stairs to get back to the first floor?");
                Console.WriteLine();
                Dialog("Type the number corresponding to your choice and press enter on your keyboard: ", "narrator");
                encounterThreeChoice1 = Console.ReadLine().ToLower();


                switch (encounterThreeChoice1)
                {
                    case "1": // hide in the Bedroom
                        {
                            AnyKeyClear();
                            if (!secondFloorBedroomReveal)
                            {
                                Dialog("You scramble to the door and burst into a bedroom.", "narrator");
                            }
                            else if (secondFloorBedroomReveal)
                            {
                                Dialog("You scramble to the bedroom to hide.", "narrator");
                            }

                            if (!bedroomHideAbility)
                            {
                                // if you have not previously seen you can hide here
                                Dialog("Looking around, you see a tattered bed with moldy sheets on top that give off a pungent odor. In a panic, you drop to your stomach and crawl under the bed and stay as still as you can.", "narrator");
                            }
                            else if (bedroomHideAbility)
                            {
                                // if you have seen that you can hide here
                                Dialog("Remembering the layout of the bedroom, you stare at the moldy sheets for a moment.", "narrator");
                                Dialog("I may be at death's door here.... I'm going to have to touch those sheets after all.", "hero");
                                Dialog("In a panic, you drop to your stomach and crawl under the bed and stay as still as you can.", "narrator");
                            }


                            // Bedroom is default successful Hiding sequence
                            Dialog("The treading of the shambling footsteps grows louder and louder. You hear other doors smashed open as whatever is looking for you continues to prowl the house.", "narrator");
                            Dialog("After a short time, the door bursts open, slamming the wall knocking curled paint shavings to the floor where they shatter into hundreds of pieces.", "narrator");
                            Dialog("That's when you get a good look at it.... It appears humanoid, but very old, yet it somehow has strength even though the skin appears to be cracked and wretched and it can barely walk. There is a horrendus gurgling as it pants and strugles to breathe.", "narrator");
                            Dialog("It creeps up within feet of you.", "narrator");
                            Dialog("Time seems to slow down. Your heartbeat starts to sound like a ticking clock, the time between ticks grows ever longer.", "narrator");
                            Dialog("After what seems to feel like an eternity, the figure shambles out of the room and into another nearby room. You decide to make your move. Waiting for just the right time when the footsteps sound furthest away, you slide out from under the bed and tiptoe to the door. Carefully peering out, it looks like it's in the next room. You make a break for the staircase.", "narrator");
                            Dialog("WHHHHHHRGRAUUUUUW", "evil");
                            Dialog("FUCK!", "hero");
                            Dialog("You're able to dodge it's arm as it reaches at you and you hit the staircase and start your long descent with the creature following close behind.", "narrator");

                            AnyKeyClear();
                            encounterFourDownstairs();

                            break;
                        }
                    case "2": //hide in the second floor bathroom
                        {
                            AnyKeyClear();
                            if (!secondFloorBathReveal)
                            {
                                Dialog("You scramble to the door and enter the room. You're in a small bathroom with little room to maneuver.", "narrator");
                                Dialog("Shit.. if it gets in here, I'm fucked.", "hero");
                                Dialog("Panicked, your eyes grow wide, but no time to rethink, it's coming closer.", "narrator");
                            }
                            else if (secondFloorBathReveal)
                            {
                                Dialog("You scramble to the bathroom to hide, but you realize there wasn't any room to maneuver", "narrator");
                                Dialog("Shit.. if it gets in here, I'm fucked.", "hero");
                                Dialog("Panicked, your eyes grow wide, but no time to rethink, it's coming closer.", "narrator");
                            }


                            // FAILED HIDING SEQUENCE
                            Dialog("The treading of the shambling footsteps grows louder and louder. You hear other doors smashed open as whatever is looking for you continues to prowl the house.", "narrator");
                            Dialog("After a short time, the door bursts open, slamming the wall knocking curled paint shavings to the floor where they shatter into hundreds of pieces.", "narrator");
                            Dialog("That's when you get a good look at it.... It appears humanoid, but very old, yet it somehow has strength even though the skin appears to be cracked and wretched and it can barely walk. There is a horrendus gurgling as it pants and strugles to breathe.", "narrator");
                            Dialog("Time seems to slow down. Your heartbeat starts to sound like a ticking clock, the time between ticks grows ever longer.", "narrator");
                            Dialog("You feel it's gaze measure you up as it lets out a shreik.", "narrator");
                            Dialog("WHHHHHHRGRAUUUUUW", "evil");
                            Dialog("FUCK!", "hero");
                            Dialog("Your screams are muffled as the creature engulfs you, pulling you closer to it as it bites out a large chunk of your neck. Your cries of terror echo throughout the house. Bite by bite, your body can no longer fight and your last moments are agonizing.", "narrator");
                            AnyKeyClear();
                            GameOverWitch();
                            break;
                        }
                    case "3": //hide in the study
                        {
                            AnyKeyClear();
                            if (!secondFloorStudyReveal)
                            {
                                Dialog("You scramble to the door and enter the room. You see a wardrobe in the corner of the room, but when you try and open it, it's locked tight. Panicked, you try to find a key, but turn up empty handed. You try to hide behind the wardrobe.", "narrator");
                                Dialog("Hopefully whatever that is wont come in here.", "hero");
                            }
                            else if (secondFloorStudyReveal)
                            {
                                Dialog("You scramble to the study to hide.", "narrator");
                            }

                            if (!studyHideAbility)
                            {
                                // FAILED HIDING SEQUENCE
                                Dialog("The treading of the shambling footsteps grows louder and louder. You hear other doors smashed open as whatever is looking for you continues to prowl the house.", "narrator");
                                Dialog("After a short time, the door bursts open, slamming the wall knocking curled paint shavings to the floor where they shatter into hundreds of pieces.", "narrator");
                                Dialog("That's when you get a good look at it.... It appears humanoid, but very old, yet it somehow has strength even though the skin appears to be cracked and wretched and it can barely walk. There is a horrendus gurgling as it pants and strugles to breathe.", "narrator");
                                Dialog("Time seems to slow down. Your heartbeat starts to sound like a ticking clock, the time between ticks grows ever longer.", "narrator");
                                Dialog("You feel it's gaze measure you up as it lets out a shreik.", "narrator");
                                Dialog("WHHHHHHRGRAUUUUUW", "evil");
                                Dialog("FUCK!", "hero");
                                Dialog("Your screams are muffled as the creature engulfs you, pulling you closer to it as it bites out a large chunk of your neck. Your cries of terror echo throughout the house. Bite by bite, your body can no longer fight and your last moments are agonizing.", "narrator");
                                AnyKeyClear();
                                GameOverWitch();
                            }
                            else if (studyHideAbility)
                            {
                                // successful hide
                                Dialog("Remembering you unlocked the wardrobe, you climb inside and shut the door just enough where you can barely see out of it.", "narrator");
                                Dialog("The treading of the shambling footsteps grows louder and louder. You hear other doors smashed open as whatever is looking for you continues to prowl the house.", "narrator");
                                Dialog("After a short time, the door bursts open, slamming the wall knocking curled paint shavings to the floor where they shatter into hundreds of pieces.", "narrator");
                                Dialog("That's when you get a good look at it.... It appears humanoid, but very old, yet it somehow has strength even though the skin appears to be cracked and wretched and it can barely walk. There is a horrendus gurgling as it pants and strugles to breathe.", "narrator");
                                Dialog("It creeps up within feet of you.", "narrator");
                                Dialog("Time seems to slow down. Your heartbeat starts to sound like a ticking clock, the time between ticks grows ever longer.", "narrator");
                                Dialog("After what seems to feel like an eternity, the figure shambles out of the room and into another nearby room. You decide to make your move. Waiting for just the right time when the footsteps sound furthest away, you slide out from under the bed and tiptoe to the door. Carefully peering out, it looks like it's in the next room. You make a break for the staircase.", "narrator");
                                Dialog("WHHHHHHRGRAUUUUUW", "evil");
                                Dialog("FUCK!", "hero");
                                Dialog("You're able to dodge it's arm as it reaches at you and you hit the staircase and start your long descent with the creature following close behind.", "narrator");
                                AnyKeyClear();
                                encounterFourDownstairs();
                            }

                                break;
                        }
                    case "4": // Go back down to first floor
                        {
                            AnyKeyClear();
                            Dialog("Trying your luck, you decide wait for your moment to lunge past the decrepid figure to get down to the first floor.", "narrator");
                            Dialog("The treading of the shambling footsteps grows louder and louder.", "narrator");
                            Dialog("That's when you get a good look at it.... It appears humanoid, but very old, yet it somehow has strength even though the skin appears to be cracked and wretched and it can barely walk. There is a horrendus gurgling as it pants and strugles to breathe.", "narrator");
                            Dialog("After what seems to feel like an eternity, the figure shambles out of the room and into another nearby room. You decide to make your move. Waiting for just the right time when the footsteps sound furthest away, you slide out from under the bed and tiptoe to the door. Carefully peering out, it looks like it's in the next room. You make a break for the staircase.", "narrator");
                            Dialog("Time seems to slow down. Your heartbeat starts to sound like a ticking clock, the time between ticks grows ever longer. You make your move and lunge forward.", "narrator");

                            // roll stat
                            RollStat(1, 10);
                            encounterThreeRollStat = stat;

                            if (encounterThreeRollStat >= 5)
                            {
                                // successful evade
                                Dialog("WHHHHHHRGRAUUUUUW", "evil");
                                Dialog("FUCK!", "hero");
                                Dialog("You're able to dodge it's arm as it reaches at you and you hit the staircase and start your long descent with the creature following close behind.", "narrator");
                                AnyKeyClear();
                                encounterFourDownstairs();
                            }
                            else if (encounterThreeRollStat < 5)
                            {
                                // you're fucked
                                Dialog("You try and evade the creature, but you feel an icy grip on your arm. You're unable to escape.", "narrator");
                                Dialog("WHHHHHHRGRAUUUUUW", "evil");
                                Dialog("FUCK!", "hero");
                                Dialog("Your screams are muffled as the creature engulfs you, pulling you closer to it as it bites out a large chunk of your neck. Your cries of terror echo throughout the house. Bite by bite, your body can no longer fight and your last moments are agonizing.", "narrator");
                                AnyKeyClear();
                                GameOverWitch();
                            }

                            break;
                        }
                    default:
                        {
                            //default action
                            Dialog("I do not understand that command, press enter to try again...", "narrator");
                            AnyKeyClear();
                            encounterThree();
                            break;
                        }
                    // End switch for encounterThree  
                }


            }
            else
            {
                Dialog("Encounter Three Error, could not ascertain which floor event occurs on", "evil");
            }

            // End encounterThree
        }




        public static void encounterThreeHideUpstairs() //encounter three hiding upstairs
        {
            // You were in the first floor and you decided to hide upstairs, so you can get the second floor encounter three hiding options. 

            Dialog("Now Upstairs, your time is limited, you can hear the that the figure has entered the house. You have only moments now.", "narrator");
            Dialog("What will you do?", "narrator");


            // Shows the name of the room if the "revealed" flag is true.
            if (!secondFloorBedroomReveal)
            {
                Console.WriteLine("1. Try the left door?");
            }
            else if (secondFloorBedroomReveal)
            {
                Console.WriteLine("1. Hide in the bedroom?");
            }

            if (!secondFloorBathReveal)
            {
                Console.WriteLine("2. Try the middle door?");
            }
            else if (secondFloorBathReveal)
            {
                Console.WriteLine("2. Hide in the bathroom?");
            }

            if (!secondFloorStudyReveal)
            {
                Console.WriteLine("3. Try the door to the right?");
            }
            else if (secondFloorStudyReveal)
            {
                Console.WriteLine("3. Hide in the study?");
            }
            Console.WriteLine("4. Try to slip by as it comes up the stairs to get back to the first floor?");
            Console.WriteLine();
            Dialog("Type the number corresponding to your choice and press enter on your keyboard: ", "narrator");
            string encounterThreeHideUpstairsChoice1;
            encounterThreeHideUpstairsChoice1 = Console.ReadLine().ToLower();

            switch (encounterThreeHideUpstairsChoice1)
            {
                case "1": // hide in the Bedroom
                    {
                        AnyKeyClear();
                        if (!secondFloorBedroomReveal)
                        {
                            Dialog("You scramble to the door and burst into a bedroom.", "narrator");
                        }
                        else if (secondFloorBedroomReveal)
                        {
                            Dialog("You scramble to the bedroom to hide.", "narrator");
                        }

                        if (!bedroomHideAbility)
                        {
                            // if you have not previously seen you can hide here
                            Dialog("Looking around, you see a tattered bed with moldy sheets on top that give off a pungent odor. In a panic, you drop to your stomach and crawl under the bed and stay as still as you can.", "narrator");
                        }
                        else if (bedroomHideAbility)
                        {
                            // if you have seen that you can hide here
                            Dialog("Remembering the layout of the bedroom, you stare at the moldy sheets for a moment.", "narrator");
                            Dialog("I may be at death's door here.... I'm going to have to touch those sheets after all.", "hero");
                            Dialog("In a panic, you drop to your stomach and crawl under the bed and stay as still as you can.", "narrator");
                        }


                        // Bedroom is default successful Hiding sequence
                        Dialog("The treading of the shambling footsteps grows louder and louder. You hear other doors smashed open as whatever is looking for you continues to prowl the house.", "narrator");
                        Dialog("After a short time, the door bursts open, slamming the wall knocking curled paint shavings to the floor where they shatter into hundreds of pieces.", "narrator");
                        Dialog("That's when you get a good look at it.... It appears humanoid, but very old, yet it somehow has strength even though the skin appears to be cracked and wretched and it can barely walk. There is a horrendus gurgling as it pants and strugles to breathe.", "narrator");
                        Dialog("It creeps up within feet of you.", "narrator");
                        Dialog("Time seems to slow down. Your heartbeat starts to sound like a ticking clock, the time between ticks grows ever longer.", "narrator");
                        Dialog("After what seems to feel like an eternity, the figure shambles out of the room and into another nearby room. You decide to make your move. Waiting for just the right time when the footsteps sound furthest away, you slide out from under the bed and tiptoe to the door. Carefully peering out, it looks like it's in the next room. You make a break for the staircase.", "narrator");
                        Dialog("WHHHHHHRGRAUUUUUW", "evil");
                        Dialog("FUCK!", "hero");
                        Dialog("You're able to dodge it's arm as it reaches at you and you hit the staircase and start your long descent with the creature following close behind.", "narrator");

                        AnyKeyClear();
                        encounterFourDownstairs();

                        break;
                    }
                case "2": //hide in the second floor bathroom
                    {
                        AnyKeyClear();
                        if (!secondFloorBathReveal)
                        {
                            Dialog("You scramble to the door and enter the room. You're in a small bathroom with little room to maneuver.", "narrator");
                            Dialog("Shit.. if it gets in here, I'm fucked.", "hero");
                            Dialog("Panicked, your eyes grow wide, but no time to rethink, it's coming closer.", "narrator");
                        }
                        else if (secondFloorBathReveal)
                        {
                            Dialog("You scramble to the bathroom to hide, but you realize there wasn't any room to maneuver", "narrator");
                            Dialog("Shit.. if it gets in here, I'm fucked.", "hero");
                            Dialog("Panicked, your eyes grow wide, but no time to rethink, it's coming closer.", "narrator");
                        }


                        // FAILED HIDING SEQUENCE
                        Dialog("The treading of the shambling footsteps grows louder and louder. You hear other doors smashed open as whatever is looking for you continues to prowl the house.", "narrator");
                        Dialog("After a short time, the door bursts open, slamming the wall knocking curled paint shavings to the floor where they shatter into hundreds of pieces.", "narrator");
                        Dialog("That's when you get a good look at it.... It appears humanoid, but very old, yet it somehow has strength even though the skin appears to be cracked and wretched and it can barely walk. There is a horrendus gurgling as it pants and strugles to breathe.", "narrator");
                        Dialog("Time seems to slow down. Your heartbeat starts to sound like a ticking clock, the time between ticks grows ever longer.", "narrator");
                        Dialog("You feel it's gaze measure you up as it lets out a shreik.", "narrator");
                        Dialog("WHHHHHHRGRAUUUUUW", "evil");
                        Dialog("FUCK!", "hero");
                        Dialog("Your screams are muffled as the creature engulfs you, pulling you closer to it as it bites out a large chunk of your neck. Your cries of terror echo throughout the house. Bite by bite, your body can no longer fight and your last moments are agonizing.", "narrator");
                        AnyKeyClear();
                        GameOverWitch();
                        break;
                    }
                case "3": //hide in the study
                    {
                        AnyKeyClear();
                        if (!secondFloorStudyReveal)
                        {
                            Dialog("You scramble to the door and enter the room. You see a wardrobe in the corner of the room, but when you try and open it, it's locked tight. Panicked, you try to find a key, but turn up empty handed. You try to hide behind the wardrobe.", "narrator");
                            Dialog("Hopefully whatever that is wont come in here.", "hero");
                        }
                        else if (secondFloorStudyReveal)
                        {
                            Dialog("You scramble to the study to hide.", "narrator");
                        }

                        if (!studyHideAbility)
                        {
                            // FAILED HIDING SEQUENCE
                            Dialog("The treading of the shambling footsteps grows louder and louder. You hear other doors smashed open as whatever is looking for you continues to prowl the house.", "narrator");
                            Dialog("After a short time, the door bursts open, slamming the wall knocking curled paint shavings to the floor where they shatter into hundreds of pieces.", "narrator");
                            Dialog("That's when you get a good look at it.... It appears humanoid, but very old, yet it somehow has strength even though the skin appears to be cracked and wretched and it can barely walk. There is a horrendus gurgling as it pants and strugles to breathe.", "narrator");
                            Dialog("Time seems to slow down. Your heartbeat starts to sound like a ticking clock, the time between ticks grows ever longer.", "narrator");
                            Dialog("You feel it's gaze measure you up as it lets out a shreik.", "narrator");
                            Dialog("WHHHHHHRGRAUUUUUW", "evil");
                            Dialog("FUCK!", "hero");
                            Dialog("Your screams are muffled as the creature engulfs you, pulling you closer to it as it bites out a large chunk of your neck. Your cries of terror echo throughout the house. Bite by bite, your body can no longer fight and your last moments are agonizing.", "narrator");
                            AnyKeyClear();
                            GameOverWitch();
                        }
                        else if (studyHideAbility)
                        {
                            // successful hide
                            Dialog("Remembering you unlocked the wardrobe, you climb inside and shut the door just enough where you can barely see out of it.", "narrator");
                            Dialog("The treading of the shambling footsteps grows louder and louder. You hear other doors smashed open as whatever is looking for you continues to prowl the house.", "narrator");
                            Dialog("After a short time, the door bursts open, slamming the wall knocking curled paint shavings to the floor where they shatter into hundreds of pieces.", "narrator");
                            Dialog("That's when you get a good look at it.... It appears humanoid, but very old, yet it somehow has strength even though the skin appears to be cracked and wretched and it can barely walk. There is a horrendus gurgling as it pants and strugles to breathe.", "narrator");
                            Dialog("It creeps up within feet of you.", "narrator");
                            Dialog("Time seems to slow down. Your heartbeat starts to sound like a ticking clock, the time between ticks grows ever longer.", "narrator");
                            Dialog("After what seems to feel like an eternity, the figure shambles out of the room and into another nearby room. You decide to make your move. Waiting for just the right time when the footsteps sound furthest away, you slide out from under the bed and tiptoe to the door. Carefully peering out, it looks like it's in the next room. You make a break for the staircase.", "narrator");
                            Dialog("WHHHHHHRGRAUUUUUW", "evil");
                            Dialog("FUCK!", "hero");
                            Dialog("You're able to dodge it's arm as it reaches at you and you hit the staircase and start your long descent with the creature following close behind.", "narrator");
                            AnyKeyClear();
                            encounterFourDownstairs();
                        }

                        break;
                    }
                case "4": // Go back down to first floor
                    {
                        AnyKeyClear();
                        Dialog("Trying your luck, you decide wait for your moment to lunge past the decrepid figure to get down to the first floor.", "narrator");
                        Dialog("The treading of the shambling footsteps grows louder and louder.", "narrator");
                        Dialog("That's when you get a good look at it.... It appears humanoid, but very old, yet it somehow has strength even though the skin appears to be cracked and wretched and it can barely walk. There is a horrendus gurgling as it pants and strugles to breathe.", "narrator");
                        Dialog("After what seems to feel like an eternity, the figure shambles out of the room and into another nearby room. You decide to make your move. Waiting for just the right time when the footsteps sound furthest away, you slide out from under the bed and tiptoe to the door. Carefully peering out, it looks like it's in the next room. You make a break for the staircase.", "narrator");
                        Dialog("Time seems to slow down. Your heartbeat starts to sound like a ticking clock, the time between ticks grows ever longer. You make your move and lunge forward.", "narrator");

                        // roll stat
                        RollStat(1, 10);
                        encounterThreeRollStat = stat;

                        if (encounterThreeRollStat >= 5)
                        {
                            // successful evade
                            Dialog("WHHHHHHRGRAUUUUUW", "evil");
                            Dialog("FUCK!", "hero");
                            Dialog("You're able to dodge it's arm as it reaches at you and you hit the staircase and start your long descent with the creature following close behind.", "narrator");
                            AnyKeyClear();
                            encounterFourDownstairs();
                        }
                        else if (encounterThreeRollStat < 5)
                        {
                            // you're fucked
                            Dialog("You try and evade the creature, but you feel an icy grip on your arm. You're unable to escape.", "narrator");
                            Dialog("WHHHHHHRGRAUUUUUW", "evil");
                            Dialog("FUCK!", "hero");
                            Dialog("Your screams are muffled as the creature engulfs you, pulling you closer to it as it bites out a large chunk of your neck. Your cries of terror echo throughout the house. Bite by bite, your body can no longer fight and your last moments are agonizing.", "narrator");
                            AnyKeyClear();
                            GameOverWitch();
                        }

                        break;
                    }
                default:
                    {
                        //default action
                        Dialog("I do not understand that command, press enter to try again...", "narrator");
                        AnyKeyClear();
                        encounterThree();
                        break;
                    }
                    // End switch for encounterThreeHideUpstairs  
            }

            // end encounterThreeHideUpstairs
        }



        public static bool caughtWilderness = false;
        public static bool bleedOut = false;

        public static void encounterFourDownstairs() //encounter four starting from the upstairs
        {

            Dialog("Your time is limited, the creature is after you. You have only moments now.", "narrator");
            Dialog("What will you do?", "narrator");
            
            Console.WriteLine("1. Try the front door?");
            Console.WriteLine("2. Try the broken window?");
            if (backDoorAvailable) //revelas the third option for back door
            {
                Console.WriteLine("3. Try the back door?");
            }

            Console.WriteLine();
            Dialog("Type the number corresponding to your choice and press enter on your keyboard: ", "narrator");
            string encounterThreeHideUpstairsChoice1;
            encounterThreeHideUpstairsChoice1 = Console.ReadLine().ToLower();

            switch (encounterThreeHideUpstairsChoice1)
            {
                case "1": // exit the front door
                    {
                        if (!frontdoorknobbroken)
                        {
                            Dialog("The creature is hot on your heels and gaining. Remembering you came in through the front door, you rush over to the front door and nearly kick it open. You feel an icy grip on your arm, but you're able to twist out of it as you stumble to the ground. Picking yourself up, you have no time to look behind you or think about where you're going. Anywhere is better than being right here.", "narrator");
                            Dialog("As you clear more distance from the house, you hear the creature's footsteps less and less in the distance. Looking behind you, the house is now out of sight and the creature is nowhere to be seen.", "narrator");
                            Dialog("While you breathe a sigh of relief that you've evaded the creature, you're quickly reminded by the vapor of your breath that the temperature is dangerously freezing.", "narrator");

                            if (keyToWin) // if you have the key item
                            {
                                // if you have the key to win
                                Dialog("Thank Christ I found those clothes!", "hero");
                                Dialog("The clothes you found are keeping you warm. While you don't know where you are, you'll be able to survive in the elements for longer now as you search for signs of cilization to escape this cursed place.", "narrator");
                                AnyKeyClear();
                                GameOverWin();
                            }
                            else if (!keyToWin && hitPoints > 0) // if you don't have the key item and hit points are higher than 1.
                            {
                                Dialog("Shit.... I never did find anything to protect myself from the cold.", "hero");
                                Dialog("The cold begins to overtake you and you're not going to last. Collapsing from the shivering. You may not be a medical expert, but you know some of the signs of hypothermia. After attempting to struggle, you give up all hope. You curl up into the fetal position.", "narrator");
                                Dialog("That's when you hear a noise drawing closer and your eyes open wide in horror...", "narrator");
                                Dialog("GRAUUUUUW", "evil");
                                caughtWilderness = true;
                                AnyKeyClear();
                                GameOverWitch();
                            }
                            else if (!keyToWin && hitPoints < 1) // if you don't have the key item and hit points are 1 or less.
                            {
                                Dialog("Shit.... I'm hurt bad.", "hero");
                                Dialog("While you've escaped the creature, your injuries make it impossible to move forward. The cold begins to overtake you and you're not going to last. Collapsing from the shivering and your injuries. You may not be a medical expert, but you know some of the signs of hypothermia. After attempting to struggle, you give up all hope. You curl up into the fetal position and close your eyes.", "narrator");
                                Dialog(".....Forever....", "narrator");
                                bleedOut = true;
                                AnyKeyClear();
                                GameOverWitch();
                            }

                        }
                        else if (frontdoorknobbroken)
                        {
                            Dialog("The creature is hot on your heels and gaining. Remembering you came in through the front door, you rush over to the front door, but the door wont budge.", "narrator");
                            Dialog("NO NO NO!!!", "hero");
                            Dialog("You remembered too late that the doorknob broke when you came into the house...", "narrator");
                            Dialog("WHHHHHHRGRAUUUUUW", "evil");
                            Dialog("FUCK!", "hero");
                            Dialog("Your screams are muffled as the creature engulfs you, pulling you closer to it as it bites out a large chunk of your neck. Your cries of terror echo throughout the house. Bite by bite, your body can no longer fight and your last moments are agonizing.", "narrator");
                            AnyKeyClear();
                            GameOverWitch();
                        }
                        break;
                    }
                case "2": //exit through the broken window
                    {
                        if (!windowglasssharp)
                        {
                            // don't take damage jumping out
                            Dialog("The creature is hot on your heels and gaining. You feel an icy grip on your arm, but you're able to twist out of it as you stumble and leap out of the window, hitting the ground hard. Luckily you had found that stick to clear the shards of glass, otherwise you could have sustained a deep gash. Picking yourself up, you have no time to look behind you or think about where you're going. Anywhere is better than being right here. ", "narrator");
                            Dialog("As you clear more distance from the house, you hear the creature's footsteps less and less in the distance. Looking behind you, the house is now out of sight and the creature is nowhere to be seen.", "narrator");
                            Dialog("While you breathe a sigh of relief that you've evaded the creature, you're quickly reminded by the vapor of your breath that the temperature is dangerously freezing.", "narrator");
                        }
                        else if (windowglasssharp)
                        {
                            // take damage jumping out
                            Dialog("The creature is hot on your heels and gaining. You feel an icy grip on your arm, but you're able to twist out of it as you stumble and leap out of the window, hitting the ground hard. You were in such a panic that you didn't feel it at first, but you feel your stomach and find a thick shard of glass embedded in your stomach. No time to think, you grip the shard as tight as you can and pull it out, the pain is incredible, causing you to nearly pass out. You have to move! Anywhere is better than being right here. ", "narrator");
                            Dialog("As you limp and struggle to clear more distance from the house, you hear the creature's footsteps less and less in the distance. Looking behind you, the house is now out of sight and the creature is nowhere to be seen.", "narrator");
                            Dialog("While you breathe a sigh of relief that you've evaded the creature, you're quickly reminded by the vapor of your breath that the temperature is dangerously freezing.", "narrator");
                            Dialog("You create a makeshift bandage and put pressure on your wound.", "narrator");
                            hitPoints--;
                        }

                        if (keyToWin) // if you have the key item
                        {
                            // if you have the key to win
                            Dialog("Thank Christ I found those clothes!", "hero");
                            Dialog("The clothes you found are keeping you warm. While you don't know where you are, you'll be able to survive in the elements for longer now as you search for signs of cilization to escape this cursed place.", "narrator");
                            AnyKeyClear();
                            GameOverWin();
                        }
                        else if (!keyToWin && hitPoints > 0) // if you don't have the key item and hit points are higher than 1.
                        {
                            Dialog("Shit.... I never did find anything to protect myself from the cold.", "hero");
                            Dialog("The cold begins to overtake you and you're not going to last. Collapsing from the shivering. You may not be a medical expert, but you know some of the signs of hypothermia. After attempting to struggle, you give up all hope. You curl up into the fetal position.", "narrator");
                            Dialog("That's when you hear a noise drawing closer and your eyes open wide in horror...", "narrator");
                            Dialog("GRAUUUUUW", "evil");
                            caughtWilderness = true;
                            AnyKeyClear();
                            GameOverWitch();
                        }
                        else if (!keyToWin && hitPoints < 1) // if you don't have the key item and hit points are 1 or less.
                        {
                            Dialog("Shit.... I'm hurt bad.", "hero");
                            Dialog("While you've escaped the creature, your injuries make it impossible to move forward. The cold begins to overtake you and you're not going to last. Collapsing from the shivering and your injuries. You may not be a medical expert, but you know some of the signs of hypothermia. After attempting to struggle, you give up all hope. You curl up into the fetal position and close your eyes.", "narrator");
                            Dialog(".....Forever....", "narrator");
                            bleedOut = true;
                            AnyKeyClear();
                            GameOverWitch();
                        }

                        AnyKeyClear();
                        break;
                    }
                case "3": //exit through the back door
                    {
                        AnyKeyClear();
                        
                        if (!backDoorAvailable) // if you didn't come through the back door, then this option isn't available and it acts like the DEFAULT case
                        {
                            //default action
                            Dialog("I do not understand that command, press enter to try again...", "narrator");
                            AnyKeyClear();
                            encounterFourDownstairs();
                            break;
                        }
                        else if (backDoorAvailable)
                        {
                            Dialog("The creature is hot on your heels and gaining. Remembering you came in through the back door, you rush into the kitchen and burst out the back door. You feel an icy grip on your arm, but you're able to twist out of it as you stumble to the ground. Picking yourself up, you have no time to look behind you or think about where you're going. Anywhere is better than being right here.", "narrator");
                            Dialog("As you clear more distance from the house, you hear the creature's footsteps less and less in the distance. Looking behind you, the house is now out of sight and the creature is nowhere to be seen.", "narrator");
                            Dialog("While you breathe a sigh of relief that you've evaded the creature, you're quickly reminded by the vapor of your breath that the temperature is dangerously freezing.", "narrator");

                            if (keyToWin) // if you have the key item
                            {
                                // if you have the key to win
                                Dialog("Thank Christ I found those clothes!", "hero");
                                Dialog("The clothes you found are keeping you warm. While you don't know where you are, you'll be able to survive in the elements for longer now as you search for signs of cilization to escape this cursed place.", "narrator");
                                AnyKeyClear();
                                GameOverWin();
                            }
                            else if (!keyToWin && hitPoints > 0) // if you don't have the key item and hit points are higher than 1.
                            {
                                Dialog("Shit.... I never did find anything to protect myself from the cold.", "hero");
                                Dialog("The cold begins to overtake you and you're not going to last. Collapsing from the shivering. You may not be a medical expert, but you know some of the signs of hypothermia. After attempting to struggle, you give up all hope. You curl up into the fetal position.", "narrator");
                                Dialog("That's when you hear a noise drawing closer and your eyes open wide in horror...", "narrator");
                                Dialog("GRAUUUUUW", "evil");
                                caughtWilderness = true;
                                AnyKeyClear();
                                GameOverWitch();
                            }
                            else if (!keyToWin && hitPoints < 1) // if you don't have the key item and hit points are 1 or less.
                            {
                                Dialog("Shit.... I'm hurt bad.", "hero");
                                Dialog("While you've escaped the creature, your injuries make it impossible to move forward. The cold begins to overtake you and you're not going to last. Collapsing from the shivering and your injuries. You may not be a medical expert, but you know some of the signs of hypothermia. After attempting to struggle, you give up all hope. You curl up into the fetal position and close your eyes.", "narrator");
                                Dialog(".....Forever....", "narrator");
                                bleedOut = true;
                                AnyKeyClear();
                                GameOverWitch();
                            }

                        }

                        break;
                    }
                default:
                    {
                        //default action
                        Dialog("I do not understand that command, press enter to try again...", "narrator");
                        AnyKeyClear();
                        encounterFourDownstairs();
                        break;
                    }
                    // End switch for encounterThreeHideUpstairs  
            }


            // End encounterTrheehideUpstiars
        }





        public static void GameOverWin()
        {
            // YOU SURVIVED... FOR NOW

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(@"%#####%(%%((#%%###((...,*##(/##%#(##*,,,,,.,*,.  ,  .,/(##%,*/#(###(((,*.,**#(///*((,.**.#(#(%(*/(##");
            Console.WriteLine(@"%#####%(%##(#%%((#((**.,*#//,%%,,/##.,*,.... ..*,,,,,**####*,/#//#(#(,/,./*/(#/*///,.,,,.((#((*,*//(");
            Console.WriteLine(@"(%##((%(%##(#%%(((((**..*##/*##**(##,,.,......,....*/,(####.,.#(/(#(#(/***,,(#///,***,/**((#(#/*,**(");
            Console.WriteLine(@"(%((((%(%((((%%#((((.,*/*###%#%,./##,**,,... ..,,,...,/#(#(...#((((((//*,.,*////(/#/,,/,*((((((/*(#/");
            Console.WriteLine(@"/###(/%(##((#%%##(((//,.*###/##.,(#%/*..*(/,.  ..,,..,/####*(/#(/((#/*///(((#(#,*///,/.,,(((##(#((#(");
            Console.WriteLine(@"/##((/#%##(//%###/(((**.*##/(##..(##,*,, ,,*..     ..*/((##//*(/((##(*/,,*,*/##((*,/,/*,,/((((#*/***");
            Console.WriteLine(@"%((#(/#%(##((%#%#(/(/,,.*#*#(#(,.(##.,,,,..,*,.. .....((###,/*((/(((*/,///*/##(((**,*,*,,(#(#(#/(//#");
            Console.WriteLine(@"*/##(/(##((/###%(((/(.//,(*(/%#,.(##,**,.,........,*..((##(,,/#(///((*((((#*(*#*/(##,*(*//((((#(/*/(");
            Console.WriteLine(@"*/(((///**/((##%(((/,//*/((((##,.(##.,..*,*,*/((##/###,(###*,*((/#(#(//#(/,.#(#,//(*////**(((((/((##");
            Console.WriteLine(@"/*#(((###/((((/*,(//((((((*((%#/*###,,.*,%##%%(%%%#%#(#%*#(//((/*/(#*.,*,**/((/**/%/#(,..**,*/((/(*/");
            Console.WriteLine(@"(//*/*/###(/(##///(/.,/(#%%((##*,*(#,*,*%&%#%%%&%&%%##%%&(/./(((//(((///,/(//(#(*/*/(/**,**((((/*///");
            Console.WriteLine(@"*/#(((/#%(((#####/**#((/%##**##*,(##/**##%%%%%&&%&%%%&&%##/*/*#(/(/((/,,/////#%*/(#*///*,*(/(//*,/**");
            Console.WriteLine(@"*(((///#%(((###(((*##*(*/#((###**(##,,*%#%%#%%%%#&&&&&&&&#%(/#((*//((/(/*/(//##(%%##*#(,,,/**//*///(");
            Console.WriteLine(@"((#(/(((%/((#%%##(((#//#(######/,(##*/(,%&&&&&&%%&&%&&%%%%/#*/%#(/*((/*//**,*##.,.##%%(*,*(/((((/(##");
            Console.WriteLine(@"(/#(((((#%(((%%%#///(###(#%##%/*,##%*((/#%&&%%%%&&%%&&&&%%////##/*////(/**/*/((***/***/#//(/((/(//(#");
            Console.WriteLine(@"#/#%#(/###/((#%%#(//#(#######%(**(##,.*,/%%%%%%%&%&%%%%&/#%((,((*//##((/,///(#%#(/#%####((((%/####((");
            Console.WriteLine(@"(/(#(%/(##((%%%#(///#((#(###%%(,,###/,/#((*.,.**,,,,,*,. #.*(//#*//(#/(*/////##//*(##(##((((((((((##");
            Console.WriteLine(@"%#*((((#%/#(#%%%(/**((%#((##(%///###***,((/###(/*.**..//*.,*##/(*///#/,/**,//##/((((((##//,*//((((/(");
            Console.WriteLine(@"%#%#(((%#//((%%%#(%&#*///#####//,#*,,*.,..*/*/(((#(#/###(####(...,/(#/(**/.//###%#((##%%/,((%(/((((#");
            Console.WriteLine(@"#%#%%(/#((/((%%%#(###%*/,(##%%(,**,,/*,,..,**//*,...  ......,*/((*/,(,/*/##%(#%##/(#(#%%%/((/(/////(");
            Console.WriteLine(@"%%((#((#((((#%#%(((#((((((####,. .....,*/**,. ...........((/*,.... , /(#(*///###(((%##%%%((/(##(##/#");
            Console.WriteLine(@"%%#((((#(/(((%%%#((/((#%%(/    ..(. ..    ... .. .,(#########/.. (.     .*%%/####(/((##%#(##((#(##(#");
            Console.WriteLine(@"%(#%#(((((/(#%##%(##/(#(/. . ....,*(/,,,.....,,,,,,,,,*,,,....#/.,..*.   .(*//(#/#(/**/%((((((((#(#%");
            Console.WriteLine(@"&%%#%#(#(#(##%####((/#((.,../. /,.,,**##(/**/((#((*,.....,/%#,,..,,*.,/. ..((##(((///###(//(/(#((#(%");
            Console.WriteLine(@"%%%((###/(#&#%%#%#(//#( ,,*..,//.,,,,,,*/%%%##(/////(#%%%%(*,,...,,**./*.. ./(#%((/*/*(%((.#/#(###(%");
            Console.WriteLine(@"%%/(%#(#%(#(#%##,*//*#.....,*//*,,*,.,***/##%%%%%%%%%%%##/*,,,,,,,**/*/**(/..%#(##//(((%#%#%/#((#%##");
            Console.WriteLine(@"%#%%#(((#(#(#%%##/((/*..,#.*/.,**/,,(//**/////(######((//*,,*/***,,///%(#(%*..%(/%(/#%#%#%(#/#//(%(%");
            Console.WriteLine(@"%%&*((/(((&(#####*(/*.,#(.*##/%,(*/#((/*///****///////****,*/(/**//,/(/%%%#(..,%%#//#%####(#/#((/((#");
            Console.WriteLine(@"#((*.**////#**,/*(((.,*#/#%%%%%#(##(((**(//*****************//(//*/#((#%&##(/,,%((#(#%%%%((%((/*((((");
            Console.WriteLine(@"#%#(/##,*.///((##(((,*///##%&&(####((**///*******,***********((/(%(/(##%%#%#(/,.(#%(#/////%(/***/*//");
            Console.WriteLine(@"%,**/***//**,(*/###,**/((/%%%/#%%##(/*///**********,*******,*((#((%%#(#%%%#(//*,/((((*,*(((%**(,*,,/");
            Console.WriteLine(@".//#%%%%%/*,(##%%((,**(%%%%%&(%%#(((,*///*/*********,*******,/#%%((%%%%&#####(/,,#%(((%&#*((%*,,/#/#");
            Console.WriteLine(@"#%((%%(,(****(#%#((*/*((##%%&%%%%%/,////***********,,*********.*#%#(#%%&%#%#(#/*,%###%#//(%%(//*/##/");
            Console.WriteLine(@"(*&%%&&%(((/##%(*#.**/((#%%%%%%(*,*(/////****/*****,,,*,*//#%%%#**(##%%%%%%##((*,.#*%%*/**%%%*//*(##");
            Console.WriteLine(@"&%%&&&&%/(#/,*#%%/*///(%#%%%&#/#%##(///*,,*************((##,*#%%%%%%%%&%##%##((/*,%#%%*/#(%#(////#(/");
            Console.WriteLine(@"&%%#((#//**/,*#%#(/(/%###%%%%%%%%%%%#(///*/((#(((((((##%%%%%%%*.,(#%%&&&%#%#%**(**&%###(%#%/##//(((/");
            Console.WriteLine(@"%#%%((%(((#(#%%%%(/((##%%##%#%/*///*/(##/////(####%%%%%#*/(###(/,,#%###*%%%###(/(/%#%#/*%%#%#%*/(/.*");
            Console.WriteLine(@"  ▄████  ▄▄▄       ███▄ ▄███▓▓█████     ▒█████   ██▒   █▓▓█████  ██▀███  ");
            Console.WriteLine(@" ██▒ ▀█▒▒████▄    ▓██▒▀█▀ ██▒▓█   ▀    ▒██▒  ██▒▓██░   █▒▓█   ▀ ▓██ ▒ ██▒");
            Console.WriteLine(@"▒██░▄▄▄░▒██  ▀█▄  ▓██    ▓██░▒███      ▒██░  ██▒ ▓██  █▒░▒███   ▓██ ░▄█ ▒");
            Console.WriteLine(@"░▓█  ██▓░██▄▄▄▄██ ▒██    ▒██ ▒▓█  ▄    ▒██   ██░  ▒██ █░░▒▓█  ▄ ▒██▀▀█▄  ");
            Console.WriteLine(@"░▒▓███▀▒ ▓█   ▓██▒▒██▒   ░██▒░▒████▒   ░ ████▓▒░   ▒▀█░  ░▒████▒░██▓ ▒██▒");
            Console.WriteLine(@" ░▒   ▒  ▒▒   ▓▒█░░ ▒░   ░  ░░░ ▒░ ░   ░ ▒░▒░▒░    ░ ▐░  ░░ ▒░ ░░ ▒▓ ░▒▓░");
            Console.WriteLine(@"  ░   ░   ▒   ▒▒ ░░  ░      ░ ░ ░  ░     ░ ▒ ▒░    ░ ░░   ░ ░  ░  ░▒ ░ ▒░");
            Console.WriteLine(@"░ ░   ░   ░   ▒   ░      ░      ░      ░ ░ ░ ▒       ░░     ░     ░░   ░ ");
            Console.WriteLine(@"      ░       ░  ░       ░      ░  ░       ░ ░        ░     ░  ░   ░     ");
            // resets console color
            Console.ResetColor();

            AnyKey();
            Environment.Exit(0);

        }



            public static void GameOverWitch()
        {
            // Red game over screen
            gameOverCounter++;

            //https://manytools.org/hacker-tools/convert-images-to-ascii-art/

            Console.ForegroundColor = ConsoleColor.Red;


            if (!caughtWilderness && !bleedOut)
            {
                Console.WriteLine(@"@@@@@&&&&&&&&&&@@@@@@@@@%&@@@@&&&%#(/*///(/*///#(,,,/*//**//((/(%&&&@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@");
                Console.WriteLine(@"@@@@@@@@@&&&&&&&&@@@@@@@@&@&#&%((**/(/**(/(((((((###((/(//(//(/////((#%&&&@&&@@@@@@@@@@@@@@@@@&&&&&&");
                Console.WriteLine(@"&&&&&&&&&&&&&&&@@@@@@@&&&&/%//*****//****/**(((///*((%/#(((###((((((/(/##%&&@@@@@@@@@@@@@@@@@@@@&@@&");
                Console.WriteLine(@"@&&&&&&&&&&&&&&&&&&&%&&&#%(*,..,*/*,*,**////**///(((/((#(/#/%###%/##(#(#((#%&@@@@@@@@@@@@@@@@@@@@@@@");
                Console.WriteLine(@"&&&&&&&&&&&&&&&@@@@(@@@&%,,. .,*.,*,/**/****,*/(/*//(((###%#/##(%##%#(##(#(###&@@@@@@@@@@@@@@@@@@@@@");
                Console.WriteLine(@"&&&&&&&&&&&&&&&&@@%&&&%,,.  ,,,,.,*,,*******/////((///#######/%%%*####(((((((#%%&@@@@@@@@@@@@@@@@@@&");
                Console.WriteLine(@"&&&&&&&&&&&&&&&@@@%@&*,.  .,,,,..,,*.***,*,//******(/(/(((######%#%%#%%(((/(((##%%&@@@@@@@@@@@@&&@&&");
                Console.WriteLine(@"&@@&@&&@&&&&@&@@@@%%,..   .....,..**/**,,,**////*/*(/////((#(%(((##%%%%##((*//((#%%&@@@@&@@@@@@@@@@@");
                Console.WriteLine(@"@@@@&&&&&&&@@@@&@@(,............**/**..,****//////**/*/////###(((#(###%%#(#//(((#(%&&&@@@@@@@@@@@@@@");
                Console.WriteLine(@"@@@@@@@@@@&&&&&&%(,,.... ... ..,,,*,.*/***/#(/(//**((///((/#%(####(%(####(#(/#((###%&@@@@@@@@@@@@@@@");
                Console.WriteLine(@"@@@@@@@@@@@@@@&%#,,. ... .    ,(//**,*/*/((//#((#//#/((///#(##%##(#(##(#&((((((((###%@@@@@@@@@@@@@@@");
                Console.WriteLine(@"@@@@@@@@@@@@&@@/.....  .     ***(,(*,./*///(,#/#%#/%/#%/((#/((###%%###%#%(###(#((##(%&@@@@@@@@@@@@@@");
                Console.WriteLine(@"@@@@@@@@@@&%%%&..,. ...     ,*,,..,(,,.,*/*(*%/%((%%*#%/%///#(##(##%#####(((%(#((#(#%%&@@@@@@@@@@@@@");
                Console.WriteLine(@"@@@@@@@@%&@&&(,.,..., ..  ./..../(##&###(#(##*#/(%%/*/&/#/(((#%&&@&&&%###(#(%(##((##(#&&@@@@@@@@@@@@");
                Console.WriteLine(@"@@@@@@@&@@@&%,.,...*..    ,*.((&@@@@@@@@@@&&(&./%%&((((&%%@@@@@@@@@@&&&%((((((##(###(#&@&@@@@@@@@@@@");
                Console.WriteLine(@"@@@@@@@&@@&(/.,,..*,,..  ...**&@@@@(&&&&%&@@@%%&&&&%&&@@@@@@@&%&&&&@@@&%%##(#((##(##((#&@@&@@@@@@@@@");
                Console.WriteLine(@"@@@@@@%@@@##,.,,,*,,,*.....*/#&@@@#&%&@@@@@@@@@/(*##%&@@@@@@@@@&%&&&@@@&%%#(%((#(####((%&@@@@@@@@@@@");
                Console.WriteLine(@"@@@@@@&@@&(/.,*.,,*,**,...*/%&&&&#@@@@@@@@@&@@#/.,/(%%&&&@&@@@@@@@@&@&@&%%#/#(#%(####(((&&@@@@@@@@@@");
                Console.WriteLine(@"@@@@@@%@@&/*,,,,*/,,*, .,,***(%&&%(%&@@@@&&%**,,,(/%%%%&&#&&@@@&&&&@@@&&&%#/#/########((#%&@&@@@@@@@");
                Console.WriteLine(@"@@@@@@@@@(/,*,.,/**/**,*,,/*((*/#%%###(*(##%%.,.#/**##%&%&&&&&%%&&&&&&%%%%#/((##(##%###(#%&&&@@@@@@@");
                Console.WriteLine(@"@@@@@@@#@/*,,***/*//.*,,.***(/###(%%##%%&&%*,,(@/#%%&((%%%&%&%&&&&&&&&&#%#(/##(###%%###(((%@@@@@@@@@");
                Console.WriteLine(@"@@@@&@@@&*,//**((//(,,.*,/*,./**/(((#(%(/*.,.&@@@@@@@@@&%##%%%##%%#%%%###(###(#%#%#%###((#(%&@&@@@@@");
                Console.WriteLine(@"(&@@@@@@#*,#**/(*/(,***,/****/**,****//*..,,/%&@((##&%@&#%#(%&#%###(#((((#%(%####%%%%%#(((#&&@@@@@@@");
                Console.WriteLine(@"@@@@@@@&/*/(/*((,((,/*,,***,*#%#/#%#%&/(,**,/#@@&/##@&%%@(#(###((%%%%%%&%%%##(#%#%%%%####((#%@@@@@@@");
                Console.WriteLine(@"@@@@@@#(//(%*(((*(/*/,,,*/**/%##&%#%%(&/.  .  ,.,((#%#((#%#(%%%%%%@&&&%%&&&((####%%%%%%####(%%&@@@@@");
                Console.WriteLine(@"@@@@@%((*/%%/#*/(/.*,*,**(,//#(%&#&%%&(*,,*,.*,.**//*#(######%%%%&&%&%%&&&%###%(#&%%%%%##%%##%&@@@@@");
                Console.WriteLine(@"@@@&%#%*##%/*/*(//,*,.*,*//*//#(#&%#%(*(#(##*(#&@@@&%@@&%%%###&#&&%&&&&&&&%######%#&%%&%%#%%#%&&&@@@");
                Console.WriteLine(@"@@&&((#,%##(/**(/*,.,,**/***((##(#&(##%**,*(,*#,#%&(**#*(%#%(/(/#&%%%%%&&&#%(####%&%%&&&&%%%##%@@@@@");
                Console.WriteLine(@"%@&((%**&((/**/**..,***,/***(((#%//&(#(@@@@@@@@@@@@@@@@@@@@@@@@&#%%%%%%&%%#(%###%#&%&&&&%%%%%%%@@@@@");
                Console.WriteLine(@"@/(&(&*#&(/**/**,..,*,///****#(//(/(&&%&@@&%@&@@&&@@@@@@&&&@@@@@&%%%%#%%%%%######%%&%&%&&&#%%%#@@@@@");
                Console.WriteLine(@"%#@&@&(#&,,(,/**,  ,,(//*,*,*/#(/(/(&((*@@&*#,&@%@&@@@@&&@@@@@@@%%#%%%%%%&&%%#%#%%%&&&&&&&%%%%%&@@@@");
                Console.WriteLine(@"%@@&%&(((***//**,,.//#/(/***//((/#*/((#/% &&% %#%&&%&&%%%&&@#&&%%%&&%%%%&&%%%%%%%%%&%&&&%&%%%##&&@@@");
                Console.WriteLine(@"%@@@@&##/(/*/*/**.*/###//#*/((((/(/**/#%%(*((#*(@%%%%%&&&*##%%%&%%&%&&%&&&@%%%%%%&&&&%&%&&%#%#%@&@@@");
                Console.WriteLine(@"&@@@@&//(*(////***/(%##*(#(#(##&#*(///#(%(*&%@%%@&&&%#&%&&&@@&%%%&@&&&&@@&&&&%&%%&&%%&%%&%%#%#%@&@@@");
                Console.WriteLine(@"@&&%(&*(#((///((///#/(##(*((%##(&@#%//(//(#%#(/#&@@@@@@@@@&&&%&%@@@&&&&%&&&%&&&&%&&&%%%%&&%%%%&%&@@@");
                Console.WriteLine(@"@&&(%/*(#(#(///((#(((((%###/%#((#%&#%#((/**,((%&@@@@@@&%#&%&%%&@@@@&&&&%%&&&&&&%&&&&%%#%&&&%%%%&&@@@");
                Console.WriteLine(@"%%#&,%(#%@#(((((((((##((/(#((##(%((@&#&(/(*/,*((#%%#&&&&&&%&#&@@@@&&&&&&&&%%&&&%&%%&%%#%%&%%%%%%&%@&");
                Console.WriteLine(@"#%//%#%##&#(/((/((#(((/((###((#/(&#(&%#&@/#(**(((%#//((((#%@@&@@@&%&&%&&%&&%%%%%%%%%%###%&&&%%%%&&&@");
                Console.WriteLine(@"&((%%##&&&#((//((#(((((/((##(/((%#&((&#%&@@@#((#%%&&&&&&&@@@&&@@%%&&%%%&%&%%%%#%%%%%%###%&&&&&&%&&&@");
            }
            else if (caughtWilderness && !bleedOut)
            {
                Console.WriteLine(@"@@@@@@@@@@@@@@@@@@@@@@@@@@@&&@@@&&@&&@@@@@@@@@@&@@&&&&&&&&@&&&%&&%%%%%&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&");
                Console.WriteLine(@"@@@@@@@@@@@@@@@@@@@@@@&@&&&&&&&&&&&&@&&&@@@@@@@@@&&&&&&&&&&&&&&&%%%%%&&&&&&&&&&&%&&&&&&&&&&&&&&&&&&&");
                Console.WriteLine(@"@@@@@@@@@@@@@@@@@@@&&&%&%&&&&@&%%%&&&&@&&@@&&@@@@&&&&&&&&&%&%%%%%%%&&&&&&&&&&&%%%%&&&&&&&&&&&&&&&&&&");
                Console.WriteLine(@"@@@@@@@@@@@@@@@@@&&&&%%&&&&%&&&&&%%&&&&&@@&&&&@&&&%%&@%%&&%%%##((#%%%%%%&%%#%%%%%%&&&&&&&&&&&&&&&&&&");
                Console.WriteLine(@"@@@@@@@@@@@@@@&&&&%&%##%##%%@%#&%%@@&&&&&@@@@&&@@&@&&&@&&&%##((####%%%%#((((###%%%&&&&@&&&&&&&&&&&&&");
                Console.WriteLine(@"@@@@@@@@@@@@&&&%%%(%%&%#####(&@#(@%&&@@@@@@@@@@@@@@@@@@@@@@@@@@@@&%##%#((###%%%%%&&%&%&&&&%%%%&&%%&&");
                Console.WriteLine(@"@@@@@@@@@@@&&&@#%&(((((((%%(//(@&#%&@@@@@@@@@@@@&@@@@@&&&@@&&&@@@@@@@@@@&%%#%%%%###%%%%%%%%&%%%%&&&&");
                Console.WriteLine(@"@@@@@@@@@@&&%#%#%&%(@@&%*//(/(%&&@@@@@&@@&&#%%##((#/(&#%#(##%((&@&&&&@@@@@@@@%%%%###%#%%%%%%%&&&&&%&");
                Console.WriteLine(@"@@@@@@@@&&%%#(%((#(((@(##(#&@&##%&&&&&###((((((((((((##(#((//((///##%%&&&@@@@@@@&%%%%%%%%%%&&%&%%%%%");
                Console.WriteLine(@"@@@@@@@&&%%#(((((((///(#%&%(%%%#&%###((//(%%##((###%%%%&&&&&&&@@@@&&@@@&@@@@@@@@&@@@%&&&&&&&&%%&&%&&");
                Console.WriteLine(@"@@@@@@&&&%%&&###%###%@@#%#(/#%#(((//(#/**,,,,,*/((#######%%%&&&&&@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@&&");
                Console.WriteLine(@"@@@@@@&&&%%&#(/(((###@#*(%/(///*(#*,..  .,*#%&@@@@@@@@@@@&&%###%%&@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@");
                Console.WriteLine(@"@@@@@@&&%%###&&@%&%#(/(/(/***//,.     ./%@@&@&%&&#%%####%&@@@@%#(#%&&@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@");
                Console.WriteLine(@"@@&&%&&@@%%%&&&&%%*(&,#/****,.      ,#@@@&%#(((/((#(%%###%%#@@@@&#(#%&&@@@@@@@@@@@@@@@@@@@@@@@@@@@@@");
                Console.WriteLine(@"@@@@@&&&%%%%%&%(#,/(/(/*/*.       .#@&&(((((///&#@@%#%%@#(#%%#@@@@&##%&&@@@@@@@@@@@@@@@@@@@@@@@@@@@@");
                Console.WriteLine(@"@@@@@@&&%%%%%@&/#((#(/(*,        ,&&&((#/*(/*%%%&&@@&%#%%&##&##&@@@&#(#&&&@@@@@@@@@@@@@@@@@@@@@@@@@@");
                Console.WriteLine(@"@@@@@@&&%&&&@%%#@%@%##%,        ,%&#/***//(%#&&@@@@@@@@%%#(##%#(&@@@%((%&&&@@@@@@@@@@@@@@@@@@@@@@@@@");
                Console.WriteLine(@"@@@@@@&@&&&@&@&&%&%%&&*.        *##/,,,%#(//#@@@@@@@@@@@#%#(((#(#&@@&((#%&&@@@@@@@@@@@@@@@@@@@@@@@@@");
                Console.WriteLine(@"@@@@@&@@@@@&&&@&@&&&@(,         *(/    **(&(%&&@@@@@@@%(//(/(#**%&&&%((#%&&&@@@@@@@@@@@@@@@@@@@@@@@@");
                Console.WriteLine(@"@&@@@@@@@@@@&@&@@&&@&/..        ,//***(/%(((((%#%%%#(*%%(((&#/*#&@&%((#%%&&&&@@@@@@@@@@@@@@@@@@@@@@@");
                Console.WriteLine(@"@@@@@@@@@@@@@&@@@@@@&/,.....     *((*//(,*/*#(/(/((####(##((###@@@%((#%%&&&@@@@@&@@@@@@@@@@@@@@@@@@@");
                Console.WriteLine(@"@@@@@@@@@@@@@@@@@@@@&/,.......   .*#(///%/*/(((*((/(#/#(###(#@@@&#((#%%&&&@@@@@&&@@@@@@@@@@@@@@@@@@@");
                Console.WriteLine(@"@@@@@@@@@@@@@@@@@@@@@(,..........  ,/%&&(*(#/((((##(/(#((#&&@@&#((#%%&&@@@@&#@@&@@@@@@@@@@@@@@@@@@@@");
                Console.WriteLine(@"@@@@@@@@@@@@@@@@@@@@@#*,...........  .*%&%%%(##(###%%#&&&@@&%####%%&@@@@@@@@@@@@@@@@@@@@@@@@@@@@@&&@");
                Console.WriteLine(@"@@@@@@@@@@@@@@@@@@@@@%(*,,,.............,*(#&&%&&&&@&&&&%%####%%&&%%&&&&%&&&&&@@@@@@@@@@@@@&&&&&#%&&");
                Console.WriteLine(@"@@@@@@@@@@@@@@@@@@@&@&%(**,,,,,,,......,,,,,**/((###########&&&%(/*/(###%%&&&@@@@@@@@@@@@&&%%&&&&&&&");
                Console.WriteLine(@"@@@@@@@@@@@@@@@@@@&&%%%%(//***,,,,,,,,,,,,***///(((###@@#***(,***//##%%&&&@@@@@@@@@@@@%&%%&#&&&%&%&@");
                Console.WriteLine(@"@@@@@@@@@@@@@@@@@@@&%##((((//****,,,,,*,******((/#*,./,.*****//(##%&&@@@@@@@@@@@@@@@&%%&&%%&#&&%&&&&");
                Console.WriteLine(@"@@@@@@@@@@@@@@@@@@&&&#(##(/*/*********,,,,*,//**(/*,/***/**(##%&&&@@@@@@@@@@@@@@%&%%##%&&&&%&&&&&%&&");
                Console.WriteLine(@"@@@@@@@@@@@@@@@@@@@@%%##(#(((%#(#*#**,*/#,**%***//(/((#(%%%&&&@@@@@@@@@@@@@&&%&&#&&%&&&&&&&@&&@&&&&&");
                Console.WriteLine(@"@@@@@@@@@@@@@@@@@@@@&&%%###(#%/////(**///*/((((((#((#%&&&&&@@@@@@@@@@@@&&&&%&%&%%%#%%#%&#&&%&&&&&&@&");
            }
            if (!caughtWilderness && bleedOut)
            {
                Console.WriteLine(@"........,.,,,,,,,,,,,,,,,,,,,,,,********************//********/*****************************,,,,,,,,");
                Console.WriteLine(@"..........,,,,,,,,,,,,,,,,,**,,****************/********///*********/*************************,*,,,,");
                Console.WriteLine(@"....,.,,,,,,,,,,,,**,,***************//*/****/*/**/*/*/*//////////////*////*/*/********************,");
                Console.WriteLine(@"...,,,,,,,,,,,,,*,,*******************//*/*///*//*/////////////////////////*///***/*****************");
                Console.WriteLine(@".,,,,,,,,,,,,,,********************///*//*///////*/////*////////////////(///////*////////**/********");
                Console.WriteLine(@",,,,,,,,,,,,*****************////////////////////////////////////////////////////////*/**//*********");
                Console.WriteLine(@",,,,,,,,,***********/*/*/////////(////////////////////////////(///////////////////////////*/****/***");
                Console.WriteLine(@",,,,*****************/*///*///#(//(////(////////////////////(/////((/((/(//////////////////*//***/*/");
                Console.WriteLine(@",*,,**********/**/***//////*(%&%%%%##&&%(((//(//(/((/(((/((((//(((((/((/(/(((/(/((((//(//////(//////");
                Console.WriteLine(@",*,,***********/*///////,###((.(###%&&@@@&(((((((((((((((((((((((/(#((/(((/(((((/((((///(///////////");
                Console.WriteLine(@",**********////*///%&%%//(////(/(/....*%%&&&&%((*%%&%&%&%&%%%(((((((((((##((((((/((((((//(//(///////");
                Console.WriteLine(@",*********/*///////####%%%%%%((((/(//(/...(%&&&%%%#(%&&&%%&@&&%((((#((((#(((/(((((/((#(///((////(///");
                Console.WriteLine(@"*********/////////(/ ...(#%&@@@&&&&##(((((..,%&@@@@@@@&#/,*(#&&&&&#((((#((#((((((##((#(/((////(/(///");
                Console.WriteLine(@"************/*/////(/((((/..#&&&&&&@@@@@@&#(/&@@@@@@@@@@@&&%#&&&@@&@@@@#(((((((((((#(((((((((((((//(");
                Console.WriteLine(@"*****,**///////////(((((((((((*...%%&&&@@&&@@@@@@@@@@@@@@@&&&@@@@&@@@@@@@((((((###((((((/(((#(((((/(");
                Console.WriteLine(@"******////#%&&%%%&&&%%&&@&%(((/((((/...(&@@@@@@@@@@@@@@@@@@@@@&@@@@@@@@@@&##((((((((((((((((((((((((");
                Console.WriteLine(@"***/*///,(/*//(####((#%&&@@@@@@@&&&%#%#&&@@@@@@@@@@@@@@@@@@@@@@@@&&@@@@@@@@&#(#(#(((##(((((((((((((/");
                Console.WriteLine(@"****////////((/(/(///......%%&&&@@&&&@@@@@@@@@@@@@@@@@@@@&@@@@@@@@@@@&@@@@@@@#(#(###((#(#(((((((((((");
                Console.WriteLine(@"/****//*/////(/((((((((((((#((...,&%&&@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@&@@@&&&######(##(((#(#((((((");
                Console.WriteLine(@"*/***////(///(//(((((((((/#(((((#(#..%@@@@@@@@@@@@@@&&&@@@@@@@@@@&@@@@@@@@@@&@@@&####(#(##(#((((((((");
                Console.WriteLine(@"*////*////((/%&&&&%%%##%(%%%##(######/(@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@&%@&(#(#(##((((((((((");
                Console.WriteLine(@"//*/////(((/(*#&&%%%%%&#%%@@@@@@@@@@@%@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@&&###%(%#(##(##(((");
                Console.WriteLine(@"////////(//(/(((((((*...,*%&@&&&&%&&%%&@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@&####(#((##(#((");
                Console.WriteLine(@"//////(//(((/((((((((((#(((((######(*....(&@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@&&&%####(#(#(#");
                Console.WriteLine(@"////////((/((((((((#(((##########%#%##%##%#(*..*%@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@&&&&&%%#(###");
                Console.WriteLine(@"////////(/((/(((((((((######(####%##%%#%%#%#%%%%%%#%/..,*#&@@@@@@@@@@@@@@@@@@@@@@@@@@@&&&&&&&&&&&#((");
                Console.WriteLine(@"//////(/(((((((((((((###(###########%####%%%%%%%%%%%%#%#&##%#%/..,*...(&&&@@@@@&@@@@@@@@@&&&&&&%%&%%");
                Console.WriteLine(@"/////////((((((#((#((((########(###(#%##(##%%%%#%#%%%&&%%%%%#%%##%%%%%%%%%%##* ./%&&&@@&&&&&&&&&@%%%");
                Console.WriteLine(@"*/*/////(((((((((#(((((#######(############%%#%%%%%%%%%#%%%#%##%%%%%##%#####%#####..#%&&&%&%&&&&%%%%");
                Console.WriteLine(@"****/////(//(((((((((((#(########((########%####%%%%%###%%%%%%%#%%#%%#################. ##%&&&&%%%%%");
            }
            Console.WriteLine(@"  ▄████  ▄▄▄       ███▄ ▄███▓▓█████     ▒█████   ██▒   █▓▓█████  ██▀███  ");
            Console.WriteLine(@" ██▒ ▀█▒▒████▄    ▓██▒▀█▀ ██▒▓█   ▀    ▒██▒  ██▒▓██░   █▒▓█   ▀ ▓██ ▒ ██▒");
            Console.WriteLine(@"▒██░▄▄▄░▒██  ▀█▄  ▓██    ▓██░▒███      ▒██░  ██▒ ▓██  █▒░▒███   ▓██ ░▄█ ▒");
            Console.WriteLine(@"░▓█  ██▓░██▄▄▄▄██ ▒██    ▒██ ▒▓█  ▄    ▒██   ██░  ▒██ █░░▒▓█  ▄ ▒██▀▀█▄  ");
            Console.WriteLine(@"░▒▓███▀▒ ▓█   ▓██▒▒██▒   ░██▒░▒████▒   ░ ████▓▒░   ▒▀█░  ░▒████▒░██▓ ▒██▒");
            Console.WriteLine(@" ░▒   ▒  ▒▒   ▓▒█░░ ▒░   ░  ░░░ ▒░ ░   ░ ▒░▒░▒░    ░ ▐░  ░░ ▒░ ░░ ▒▓ ░▒▓░");
            Console.WriteLine(@"  ░   ░   ▒   ▒▒ ░░  ░      ░ ░ ░  ░     ░ ▒ ▒░    ░ ░░   ░ ░  ░  ░▒ ░ ▒░");
            Console.WriteLine(@"░ ░   ░   ░   ▒   ░      ░      ░      ░ ░ ░ ▒       ░░     ░     ░░   ░ ");
            Console.WriteLine(@"      ░       ░  ░       ░      ░  ░       ░ ░        ░     ░  ░   ░     ");
            // resets console color
            Console.ResetColor();

            //Console.WriteLine("TRY AGAIN?"); IMPLMEMENT THIS LATER

            AnyKey();
            Environment.Exit(0);

            // END GAME
        }



        // End Game Class
    }
    


    // End Name Space WitchGame
}
