using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    class RemoteController
    {
        Command[] onSlot;
        Command[] offSlot;
        Command undoSlot;

        Command noSlot = new noCommand();
        public RemoteController() {
            onSlot = new Command[7];
            offSlot = new Command[7];
            undoSlot = noSlot;


            for (int i = 0; i < 7; i++)
            {
                onSlot[i] = noSlot;
                offSlot[i] = noSlot;

            }
            
        }
        public void setCommand(int Slot, Command onCommand, Command offCommand)
        {
            onSlot[Slot] = onCommand;
            offSlot[Slot] = offCommand;
        }
        public void onButtonWasPressed(int Slot)
        {
            onSlot[Slot].execute();
            undoSlot = onSlot[Slot];
        }
        public void offButtonWasPressed(int Slot)
        {
            offSlot[Slot].execute();
            undoSlot = onSlot[Slot];
        }

        public void undoButtonWasPressed()
        {
            undoSlot.undo();
        }
        public void toString()
        {
            for (int i = 0; i < 7; i++)
            {
                Console.WriteLine("The Object Name : " + onSlot[i].GetType()  );
                
            }
        }


    }

   

}
