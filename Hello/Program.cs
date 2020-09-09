using System;

namespace Hello
{
    class Program
    {
        static void Main(string[] args)
        {
            string Cc1 = "";
            string Flc1 = "";
            string c1 = "";
            string name = "";
            string Fcc1 = "";
            string Fcc2 = "";
            string Fcc3 = "";
            string c2c1 = "";
            string no1 = "";
            start();
            
            void start(){ //Start
                Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;
            Console.Title = "A small Adventure";
            Console.WriteLine("-Welcome to my simple camp Traveler");
            while(name == ""){
                Console.WriteLine("-Who are you?");
                name = Console.ReadLine();
                Console.Clear();
            }
            Console.WriteLine("-Hello " + name +", I am Bjorn where are yee heading?");
            while(c1 != "Forest" && c1 != "forest" && c1 != "Castle" && c1 != "castle" && c1 != "No" && c1 != "NO" && c1 != "no"){
                Console.WriteLine("[Forest or Castle]");
                c1= Console.ReadLine();
                Console.Clear();
            }    
            if(c1 == "Forest" || c1 == "forest"){ 
                c1Forest();
            }
            if(c1 == "Castle" || c1 == "castle"){
                c1Castle();
            }
            if(c1 == "No" || c1 == "no" || c1 == "NO"){no();}
            }


            void c1Forest(){ //>Forest
                Console.BackgroundColor = ConsoleColor.DarkGreen;
                if(Cc1!=""){Console.WriteLine("-Good, keep away from that Castle, boy");}
                if(Cc1==""){ Console.WriteLine("-Well then we will part for I am heading for the far North");}
                Console.WriteLine("The Traveler walks away along the road as you enter the great Fangorn");
                Console.WriteLine("The Great path splits into 3");
                string Fc1 ="";
                while(Fc1 != "Left" && Fc1 != "left" && Fc1 != "Center" && Fc1 != "center" && Fc1 != "Right" && Fc1 != "right"){
                System.Console.WriteLine("[Left, Center or Right]");
                Fc1 = Console.ReadLine();
                Console.Clear();
                if(Fc1 == "Left" || Fc1 == "left"){Fc1ForestLeft();}
                if(Fc1 == "Center" || Fc1 == "center"){Fc1ForestCenter();}
                if(Fc1 == "Right" || Fc1 == "right"){Frc1();}
            }}
            

            void Fc1ForestLeft(){ //>Forest>Left (Cont)
                Console.WriteLine("The swingeling path leads to a dark cave");
                
                while(Flc1 != "Yes" && Flc1 != "yes" && Flc1 != "No" && Flc1 != "no"){
                    Console.WriteLine("Do you enter?");
                    Console.WriteLine("[Yes or No]");
                    Flc1 = Console.ReadLine();
                    Console.Clear();
                }
                if(Flc1 == "Yes" || Flc1 == "yes"){Flc2();}
                if(Flc1 == "No" || Flc1 == "no"){giveUp();}
            }

            void Flc2(){ //>Forest>Left>Cave (Death)
                Console.ResetColor();
                 Console.WriteLine("As you enter the cave the darkness closes around you");
                Console.ReadLine();
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("You see less and less");
                Console.ReadLine();
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("You are lost and after hours accept that you will die in this cave");
                Console.ReadLine();
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("Days Later");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("You are dead stupid idiot, dont go into caves without a torch!");
                Console.ReadLine();
            }

            void giveUp(){ //>No more adventure (Win)
                System.Console.WriteLine("Goodbye " + name + ", you gave up but atleast you are alive");
                Console.ReadLine();
            }
            

            void Fc1ForestCenter(){ //>Forest>Center (Cont)

            Console.WriteLine("You take the Center path deeper into the woods");
                Console.WriteLine("After an hour or so you feel watched");
                Console.ReadLine();
                Console.Clear();
                while(Fcc1 != "Yes" && Fcc1 != "yes" && Fcc1 != "No" && Fcc1 != "no"){
                    Console.WriteLine("Do you shrug it off?");
                    Console.WriteLine("[Yes or No]"); 
                    Fcc1 = Console.ReadLine();
                    Console.Clear();
                }
                if(Fcc1 == "Yes" || Fcc1 == "yes"){Shrugoff();}
                if(Fcc1 == "No" || Fcc1 == "no"){Fcc2ForestCenter();}
            }

            void Shrugoff(){ //>Forest>Center>No care (Death)
                 Console.WriteLine("You shrug it off and think no more of it.");
                Console.WriteLine("The only warning you get is a crunching leaf");
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Always look behind you, now you dont even know what killed you kid.");
                Console.ReadLine();
            }
            
            void Fcc2ForestCenter(){ //>Forest>Center>Battle (Cont)
                Console.WriteLine("You look around and see a wolf");
                Console.WriteLine("An easy foe after you saw it but it could have been deadly");
                Console.ReadLine();
                Console.Clear();
                Console.WriteLine("How do you react?");
                while(Fcc2 != "Flee" && Fcc2 != "flee" && Fcc2 != "Attack" && Fcc2 != "attack"){
                    Console.WriteLine("[Attack or Flee]"); 
                    Fcc2 = Console.ReadLine();
                    Console.Clear();
                    }
                if(Fcc2 == "Flee" || Fcc2 == "flee"){Fcc2Flee();}
                if(Fcc2 == "Attack" || Fcc2 == "attack"){Fcc3ForestCenter();}
            }

            void Fcc2Flee(){ //>Forest>Center>Flee (Death)
                Console.WriteLine("Are you feking STUPID!");
                Console.WriteLine("I told you that it was an easy fight");
                Console.ReadLine();
                Console.Clear();
                Console.WriteLine("I EVEN GAVE YOU A CLUE!");
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("You are dead and you deserve it mate!");
                Console.ReadLine();


            }
           
            void Fcc3ForestCenter(){ //>Forest>Center>Battle>Victory (Cont)
                Console.WriteLine("As you are not stupid you attack and kill the wolf");
                Console.WriteLine("What a hero you are, feel proud.");
                Console.ReadLine();
                Console.Clear();
                Console.WriteLine("I encourege you to return home a hero");
                while(Fcc3 != "Yes" && Fcc3 != "yes" && Fcc3 != "No" && Fcc3 != "no"){
                    Console.WriteLine("Do you return home a hero?");
                    Console.WriteLine("[Yes or No]"); 
                    Fcc3 = Console.ReadLine();
                    Console.Clear();
                }
                if(Fcc3 == "Yes" || Fcc3 == "yes"){returnHome();}
                if(Fcc3 == "No" || Fcc3 == "no"){Fcc3Continue();}

            }
            
            void returnHome(){ //>Forest>Center>Battle>Victory>Home (Win)
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("You return home as a hero, you are the guy from movies getting the girl");
                Console.ReadLine();
            }
           
            void Fcc3Continue(){ //>Forest>Center>Battle>Victory>Continue (Death)
                Console.WriteLine("ARE YOU SERIOUS, ALWAYS LISTEN TO THE NARRATOR!");
                Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine(name + " killed by Narrator");
                Console.ReadLine();
           }


           void Frc1(){//>Forest>Right (Death)
                System.Console.WriteLine("Whats happening in this part of the script then, OMG lol hahah, ok ok wait a minute");
                Console.WriteLine("ok, haha it says HAHA, you fell over, you get me, you fell over and DIED! HAHA!");
                Console.WriteLine("How sould I be able to be serious to make a serious deathnote, ok I will try");
                Console.ReadLine();
                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("The great " + name + " sadly passed away by HAHA! falling over!");
                Console.BackgroundColor = ConsoleColor.DarkGreen;
                Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.Black; 
                System.Console.WriteLine("I am so sry, but its to funny");
                Console.ReadLine();
            }     
 


            void c1Castle(){ //>Castle (Cont)
                Console.WriteLine("-Well then we will part as your demise draws closer, I am heading for the far North");
                Console.ReadLine();
                Console.Clear();
                Console.WriteLine("-Are you sure traveler that you want to head to the Castle of the Lich King?");
                while(Cc1 != "Yes" && Cc1 != "yes" && Cc1 != "No" && Cc1 != "no" && Cc1 != "No 2" && Cc1 != "no 2" && Cc1 != "No2" && Cc1 != "no2"){
                Console.WriteLine("[Yes(Lich King), No(Forest), No 2(With Bjorn)]");
                Cc1 = Console.ReadLine();
                Console.Clear();
                }
                if(Cc1 == "Yes" || Cc1 == "yes"){c2Castle();}
                if(Cc1 == "No" || Cc1 == "no"){c1Forest();}
                if(Cc1 == "No 2" || Cc1 == "no 2" || Cc1 == "No2" || Cc1 == "no2"){c1North();}
            }

            void c2Castle(){//>Castle>Castle (Cont)
                Console.WriteLine("As you're not the brightest you choose to attack a lich as your first adventure");
                Console.WriteLine("A guard stands outside the castle");
                Console.ReadLine();
                Console.Clear();
                while(c2c1 != "Give Gifts" && c2c1 != "give Gifts" && c2c1 != "Give gifts" && c2c1 != "give gifts" && c2c1 != "Kill Him" && c2c1 != "kill Him" && c2c1 != "Kill him" && c2c1 != "kill him"){
                    Console.WriteLine("-Why are yee aprotching the seat of our Overlord?");
                    Console.WriteLine("[Give Gifts(Lie) or Kill him]"); 
                    c2c1 = Console.ReadLine();
                    Console.Clear();
                }
                if(c2c1 == "Give Gifts" || c2c1 == "give Gifts" || c2c1 == "Give gifts" || c2c1 == "give gifts"){c2gift();}
                if(c2c1 == "Kill Him" || c2c1 == "kill Him" || c2c1 == "Kill him" || c2c1 == "kill him"){c2kill();}
            }
           
           void c2gift(){//>Castle>Castle>Gift (Death)
               Console.WriteLine("As your charisma is very low he arrest you and takes you to the dungeons");
               Console.ForegroundColor = ConsoleColor.DarkRed;
               Console.WriteLine("You are left in an tiny cell until you die");
               Console.ReadLine();
           }

           void c2kill(){//>Castle>Castle>Kill (Win)
               Console.WriteLine("Of coure the guard kill you right away.. WAIT WHAT, it says.. right here in the scrip");
               Console.WriteLine("The guard laughts thinking you are joking and lets you in");
               Console.WriteLine("Bruh how stupid can he be, well it dosen't matter, a lich isent that stupid");
               Console.WriteLine("You go to the throne room and tell the lich you will kill him in a joking manner, oh now you are dead lol");
               Console.ReadLine();
               Console.Clear();
               Console.WriteLine("OMG who wrote this script, it says and I am paraphrasing : As he thinks you are joking he dosen't kill you");
               Console.WriteLine("That moment you stab him in the heart, supring all and killing him");
               Console.ReadLine();
               Console.ForegroundColor = ConsoleColor.Green;
               Console.Clear();
               Console.WriteLine("The people celebrate you and thinking you are a brave knight you become king and live happily ever after");
               Console.ReadLine();
               Console.ForegroundColor = ConsoleColor.Black;
               Console.WriteLine("As a narrator I think this is a stupid ending, crew can we skip it? oh its just me..");
               Console.WriteLine("I guess you get the girl and all that..  host* bullshit*");
               Console.WriteLine("");
               Console.WriteLine("I got the worst scriptwriter EVER, " + name + " could you make a script for me maybe");
               Console.ReadLine();
           }
           
           void c1North(){//>Castle>North (Death)
               System.Console.WriteLine("You go with Bjorn traveling north");
               System.Console.WriteLine("-It's nice of you to go with me " + name);
               Console.ForegroundColor = ConsoleColor.White;
               Console.BackgroundColor = ConsoleColor.Black;
               Console.ReadLine();
               System.Console.WriteLine("Night falls");
               Console.ReadLine();
               Console.Clear();
               Console.ReadLine();
               Console.WriteLine("You wake up by a slight touch and hear a voice: - I'm sorry " + name);
               Console.ForegroundColor = ConsoleColor.Red;
               System.Console.WriteLine("You feel the knife spliting your throat and you're body violently twitching");
               System.Console.WriteLine("Bjorn leaves you with nothing dead on the street with no honor left");
               Console.ReadLine();
           }
       
       
       void no(){ //>Sectet No
        c1 = "";
        System.Console.WriteLine("I am just a simple narrator please dont make my life hard");
        System.Console.WriteLine("You know why you shouldn't make my life hard, look here, I have power");
        Console.ReadLine();
        Console.Clear();
        Console.Write("*Snap*");
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.Write(" Superchad420 died ");
        Console.ForegroundColor = ConsoleColor.Black;
        Console.ReadLine();
        Console.Clear();
        Console.Write("*Snap!*");
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.Write(" Trump is so dead my dudes");
        Console.ForegroundColor = ConsoleColor.Black;
        Console.ReadLine();
        Console.Clear();
        Console.Write("*SNAP!*");
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine(" THE QUEEN OF ENGLAND got struck by lightning AND DIED ");
        Console.ForegroundColor = ConsoleColor.Black;
        while(no1 != "No" && no1 != "no" && no1 != "Yes" && no1 != "yes" && no1 != "NO"){
                System.Console.WriteLine("Ya see I am GOD!! I can kill immortal beings!");
                no1 = Console.ReadLine();
                Console.Clear();
            }    
            if(no1 == "NO" || no1 == "No" || no1 == "no"){ 
                 Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.Write("You died the slowest and grusomest dead possible, beyond human comprehension");
        Console.ReadLine();
            }
            if(no1 == "yes" || no1 == "Yes"){
                System.Console.WriteLine("Thank u for understanding, I will ask you again");
                while(c1 != "Forest" && c1 != "forest" && c1 != "Castle" && c1 != "castle" && c1 != "No" && c1 != "NO" && c1 != "no"){
                Console.WriteLine("[Forest or Castle]");
                c1= Console.ReadLine();
                Console.Clear();
            }    
            if(c1 == "Forest" || c1 == "forest"){ 
                c1Forest();
            }
            if(c1 == "Castle" || c1 == "castle"){
                c1Castle();
            }
            if(c1 == "No" || c1 == "no" || c1 == "NO"){
                System.Console.WriteLine("I hate you");
                Console.ForegroundColor = ConsoleColor.DarkRed;
                System.Console.WriteLine("You are so dead *Knucke Crunch*");
                Console.ReadLine();
            }
        }
     }
       
        }
    }
}
