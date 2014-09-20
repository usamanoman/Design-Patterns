using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            RemoteController remote = new RemoteController();
            //Installing Light control
            Light lightObject = new Light();
            LightOnCommand Lighton = new LightOnCommand(lightObject);
            LightOffCommand Lightoff = new LightOffCommand(lightObject);
            //Installing garage control
            Garage garageObject = new Garage();
            GarageDoorClose garageClose = new GarageDoorClose(garageObject);
            GarageDoorOpen garageOpen = new GarageDoorOpen(garageObject);
            //Installing fanControl
            Fan fabObject = new Fan();
            FanOnCommand fanOpen = new FanOnCommand(fabObject);
            FanOffCommand fanClose = new FanOffCommand(fabObject);
            Command[] commadsList = { Lighton,garageOpen,fanOpen ,Lightoff};
            MacroCommand mcmdon = new MacroCommand(commadsList);
            MacroCommand mcmdoff = new MacroCommand(commadsList);

            remote.setCommand(0, mcmdon, mcmdoff);
            remote.toString();


            remote.onButtonWasPressed(0);
            


            remote.undoButtonWasPressed();

        }
    }
}
