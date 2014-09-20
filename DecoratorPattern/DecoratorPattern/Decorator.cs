using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    public abstract class Decorator : Baverage
    {
        public abstract string getDescription();   

    }

    class Mocha : Decorator
    {
        Baverage bvr;
        public Mocha(Baverage bvr)
        {
            this.bvr = bvr;
        }
        public  override string getDescription()
        {
            return this.bvr + " ,Mocha";
        }

        public override float cost()
        {
            return 0.1F + this.bvr.cost();
        }

    }

    class Cream : Decorator
    {
        Baverage bvr;
        public Cream(Baverage bvr)
        {
            this.bvr = bvr;
        }
        public  override string getDescription()
        {
            return this.bvr + " ,Cream";
        }

        public override float cost()
        {
            return 0.3F + this.bvr.cost();
        }
    }
    class Juice : Decorator {
        Baverage bvr;
        public Juice (Baverage bvr)
        {
            this.bvr = bvr;
        }
        public  override string getDescription()
        {
            return this.bvr + " ,Juice";
        }
        public override float cost()
        {
            return 0.8F + this.bvr.cost();
        }
    }
}
