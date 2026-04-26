using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inter_face
{
    internal class player : creature, I_Attack_able, I_Talk
    {
        public void attack(creature target)
        {
            target.injure(10);
        }

        public override string Getneme()
        {
            return "村民";
        }
        public string TalkTo(creature target)
        {
            return "你好啊," + target.Getneme() + "我是村民";
        }
    }
}