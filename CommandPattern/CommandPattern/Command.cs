using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    public interface Command
    {
        void execute();
        void undo();
    }
    public class noCommand : Command
    {
        public void execute()
        {
            Console.WriteLine("This is null command");
        }
        public void undo()
        {
        }
    }
    public class LightOnCommand : Command
    {
        Light light;
        public LightOnCommand(Light light)
        {
            this.light = light;
        }

        public void undo(){
            this.light.off();
        }

        public void execute(){
            this.light.on();
        }
    }


    public class GarageDoorClose : Command
    {
        Garage garage;
        public GarageDoorClose(Garage garage)
        {
            this.garage = garage;
        }
        public void execute()
        {
            this.garage.off();
        }
        public void undo()
        {
            this.garage.on();
        }
    }


    public class LightOffCommand : Command
    {
        Light light;
        public LightOffCommand(Light light)
        {
            this.light = light;

        }

        public void undo()
        {
            this.light.on();
        }
        public void execute()
        {
            this.light.off();
        }
    }


    public class GarageDoorOpen : Command
    {
        Garage garage;
        public GarageDoorOpen(Garage garage)
        {
            this.garage = garage;
        }
        public void execute()
        {
            this.garage.on();
        }

        public void undo()
        {
            this.garage.off();
        }

    }

    public class FanOnCommand : Command{
        Fan fan;
        int prevSpeed;
        public FanOnCommand(Fan fan)
        {
            this.fan = fan;
        }

        public void execute(){
            prevSpeed=this.fan.Speed;
            this.fan.on();
        }

        public void undo()
        {
            if (prevSpeed == 1)
            {
                this.fan.off();
            }
            else if (prevSpeed == 2)
            {
                this.fan.on();
            }
            else if (prevSpeed == 3)
            {
                this.fan.medium();
            }
            else if (prevSpeed == 0)
            {
                this.fan.high();
            }
        }
    }


    public class FanOffCommand : Command
    {

        Fan fan;
        int prevSpeed;
        public FanOffCommand(Fan fan)
        {
            this.fan = fan;
        }

        public void execute(){
            prevSpeed=this.fan.Speed;
            this.fan.off();
        }

        public void undo()
        {
            if (prevSpeed == 1)
            {
                this.fan.off();
            }
            else if (prevSpeed == 2)
            {
                this.fan.on();
            }
            else if (prevSpeed == 3)
            {
                this.fan.medium();
            }
            else if (prevSpeed == 0)
            {
                this.fan.high();
            }
        }


    }


    public class MacroCommand : Command
    {
        protected Command[] md;
        public MacroCommand(Command[] listOfCommands)
        {
            md = listOfCommands;
        }
        public void execute()
        {
            for (var i = 0; i < md.Length; i++)
            {
                md[i].execute();
            }
        }
        public void undo()
        {
            for (var i = 0; i < md.Length; i++)
            {
                md[i].undo();
            }
        }
    }


}
