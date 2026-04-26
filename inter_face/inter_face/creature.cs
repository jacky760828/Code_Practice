using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inter_face
{
    abstract class creature
    {
        protected int hp = 100;
        public virtual string say()
        {
            return "I am a" + Getneme() + "我有" + hp + "滴血";
        }

        public void injure(int damage)
        {
            hp -= damage;
            if (hp < 0) hp = 0;
        }
        public abstract string Getneme();//抽象方法，必须在子类中实现
    }
}
